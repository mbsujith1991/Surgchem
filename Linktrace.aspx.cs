using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.IO;
using System.Web.UI.HtmlControls;

public partial class Linktrace : System.Web.UI.Page
{
    Dbclass db1 = new Dbclass();
    StringBuilder sb_perfid = new StringBuilder();
    string perfid = "", splitperfid = "";
    string[] perfidarray = { };
    DataTable dt_Productname = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.IsAuthenticated && Session["Usertype"] != null)
        {

            tracehidden.Value = Session["Usertype"].ToString();
            if (tracehidden.Value == null)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    HtmlGenericControl listproduct = (HtmlGenericControl)this.Master.FindControl("liproduct");
                    listproduct.Style.Add("background-color", "#195A7F");
                    BindProduct();
                    BindTraceability();
                    Bindtraceid();
                }
            }
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }

    public void BindProduct()
    {
        db1.strCommand = "select distinct ProductName from Product order by ProductName Asc";
        DataTable dt = db1.selecttable();
        drpproduct.Items.Clear();
        if (dt.Rows.Count > 0)
        {
            drpproduct.DataSource = dt;
            drpproduct.DataTextField = "ProductName";
            drpproduct.DataValueField = "ProductName";
            drpproduct.DataBind();
        }
        drpproduct.Items.Insert(0, "--Select Product--");
    }

    public void BindTraceability()
    {
        db1.strCommand = "select * from Traceability_Info order by Instrument Asc";
        DataTable dt = db1.selecttable();
        lsttrace.Items.Clear();
        if (dt.Rows.Count > 0)
        {
            lsttrace.DataSource = dt;
            lsttrace.DataTextField = "Instrument";
            lsttrace.DataValueField = "Tracibility_ID";
            lsttrace.DataBind();
        }

    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (lsttrace.SelectedIndex >= 0)
        {
            tracehidden.Value = "";
            foreach (ListItem li in lsttrace.Items)
            {
                if (li.Selected == true)
                {

                    tracehidden.Value += li.Value + ",";
                }
            }
            db1.strCommand = "update Product set Tracibility_ID='" + tracehidden.Value + "',Remarks='" + txtremarks.Text.Replace("'", "''") + "' where ProductName like '" + drpproduct.SelectedValue + "%'";
            db1.insertqry();
            txtremarks.Text = "";
            lblmsg.Text = "Data Inserted Successfully";
            BindProduct();
            BindTraceability();
            Bindtraceid();
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Please Select Traceability Details !');", true);
        }


    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        BindTraceability();
        BindProduct();
        Bindtraceid();
    }
    protected void drpproduct_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    //public void GridBind()
    //{
    //    db1.strCommand = "select * from Link_Product_Trace";
    //    DataTable dt = db1.selecttable();
    //    if (dt.Rows.Count > 0)
    //    {
    //        GridView1.DataSource = dt;
    //        GridView1.DataBind();
    //    }
    //}

    public void Bindtraceid()
    {
        DataTable dt_result = new DataTable();
        dt_result.Columns.Add("ProductName", typeof(string));
        dt_result.Columns.Add("Instrument", typeof(string));
        db1.strCommand = "select distinct ProductName from Product";
        dt_Productname = db1.selecttable();
        if (dt_Productname.Rows.Count > 0)
        {
            for (int k = 0; k < dt_Productname.Rows.Count; k++)
            {
                productname_hidden.Value = dt_Productname.Rows[k]["ProductName"].ToString();
                db1.strCommand = "select distinct Tracibility_ID from Product where ProductName like '" + dt_Productname.Rows[k]["ProductName"].ToString() + "%'";
                DataTable dt = db1.selecttable();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        sb_perfid.Append(dt.Rows[i]["Tracibility_ID"].ToString());
                        perfid = sb_perfid.ToString();
                        perfidarray = perfid.Split(',');
                        if (perfidarray.Count() > 0)
                        {
                            for (int j = 0; j < perfidarray.Count() - 1; j++)
                            {
                                db1.strCommand = "select Instrument from Traceability_Info where Tracibility_ID='" + perfidarray[j] + "'";
                                DataTable dt_perfname = db1.selecttable();
                                if (dt_perfname.Rows.Count > 0)
                                {
                                    tracename_hidden.Value += dt_perfname.Rows[0]["Instrument"].ToString() + ",";
                                }
                            }
                        }
                        if (productname_hidden.Value != "" && tracename_hidden.Value != "")
                        {
                            dt_result.Rows.Add(productname_hidden.Value, tracename_hidden.Value);
                            tracename_hidden.Value = "";
                            sb_perfid.Clear();
                        }
                    }

                }
                GridView1.DataSource = dt_result;
                GridView1.DataBind();
                
            }
        }
    }

    
   
    protected void btnaddpro_Click(object sender, EventArgs e)
    {
        Response.Redirect("Add_Product.aspx");
    }
    protected void btnaddtrace_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddTraceability.aspx");
    }
    protected void btnlink_Click(object sender, EventArgs e)
    {
        Response.Redirect("Linktrace.aspx");
    }
    protected void btnenviron_Click(object sender, EventArgs e)
    {
        Response.Redirect("Environ.aspx");
    }
    protected void btnlinkperformance_Click(object sender, EventArgs e)
    {
        Response.Redirect("Link_Performance_product.aspx");
    }
    protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
    {
        Bindtraceid();
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataBind();
    }
    protected void ConfirmPopupCloseImageButton_Click(object sender, ImageClickEventArgs e)
    {
        UserConfirmUpdatePanel.Update();
        ConfirmationModalPopupExtender.Hide();
    }
    protected void btnConfirmYes_Click(object sender, System.EventArgs e)
    {
        UserConfirmUpdatePanel.Update();
        ConfirmationModalPopupExtender.Hide();
    }
    protected void lsttrace_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        traceidhidden.Value = lsttrace.SelectedValue;
        string query = "select * from Traceability_Info where Tracibility_ID='" + traceidhidden.Value + "'";
        SqlDataReader dr = db1.getDataReader(query);
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                lblinstrument.Text = dr["Instrument"].ToString();
                lblmake.Text = dr["Make"].ToString();
                lblmodel.Text = dr["Model"].ToString();
                lblserno.Text = dr["Serial_No"].ToString();
                lblcalldue.Text = dr["Traceability_call_due"].ToString();
                lblref.Text = dr["Reference"].ToString();
            }
        }
    }
   
}