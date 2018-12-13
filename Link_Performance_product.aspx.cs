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

public partial class Link_Performance_product : System.Web.UI.Page
{
    Dbclass db1 = new Dbclass();
    StringBuilder sb_perfid = new StringBuilder();
    string perfid = "",splitperfid="";
    string[] perfidarray = { };
    DataTable dt_Productname = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.IsAuthenticated && Session["Usertype"] != null)
        {

            lnk_perf_hidden.Value = Session["Usertype"].ToString();
            if (lnk_perf_hidden.Value == null)
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
                    BindPerformance();
                    BindPerfid();
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

    public void BindPerformance()
    {
        db1.strCommand = "select * from PerformanceTest";
        DataTable dt = db1.selecttable();
        lstperformance.Items.Clear();
        if (dt.Rows.Count > 0)
        {
            lstperformance.DataSource = dt;
            lstperformance.DataTextField = "Perf_TestName";
            lstperformance.DataValueField = "PerfID";
            lstperformance.DataBind();
        }
    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (lstperformance.SelectedIndex >= 0)
        {
            lnk_perf_hidden.Value = "";
            foreach (ListItem li in lstperformance.Items)
            {
                if (li.Selected == true)
                {

                    lnk_perf_hidden.Value += li.Value + ",";
                }
            }
            db1.strCommand = "update Product set PerfID='" + lnk_perf_hidden.Value + "' where ProductName like '" + drpproduct.SelectedValue + "%'";
            db1.insertqry();

            lblmsg.Text = "Data Inserted Successfully";
            BindProduct();
            BindPerformance();
            BindPerfid();
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Please Select Performance Details !');", true);
        }

    }

    protected void btncancel_Click(object sender, EventArgs e)
    {
        BindPerformance();
        BindProduct();
        BindPerfid();
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
   
    public void BindPerfid()
    {
        DataTable dt_result = new DataTable();
        dt_result.Columns.Add("ProductName", typeof(string));
        dt_result.Columns.Add("Perf_TestName", typeof(string));
        db1.strCommand = "select distinct ProductName from Product";
        dt_Productname = db1.selecttable();
        if (dt_Productname.Rows.Count > 0)
        {
            for (int k = 0; k < dt_Productname.Rows.Count; k++)
            {
                productname_hidden.Value = dt_Productname.Rows[k]["ProductName"].ToString();
                db1.strCommand = "select distinct PerfID from Product where ProductName like '"+dt_Productname.Rows[k]["ProductName"].ToString()+"%'";
                DataTable dt = db1.selecttable();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        
                        sb_perfid.Append(dt.Rows[i]["PerfID"].ToString());
                        perfid = sb_perfid.ToString();
                        perfidarray = perfid.Split(',');
                        if (perfidarray.Count() > 0)
                        {
                            for (int j = 0; j < perfidarray.Count() - 1; j++)
                            {
                                db1.strCommand = "select Perf_TestName from PerformanceTest where PerfID='" + perfidarray[j] + "'";
                                DataTable dt_perfname = db1.selecttable();
                                if (dt_perfname.Rows.Count > 0)
                                {
                                    perfname_hidden.Value += dt_perfname.Rows[0]["Perf_TestName"].ToString() + ",";
                                }
                            }
                        }
                        if (productname_hidden.Value != "" && perfname_hidden.Value != "")
                        {
                            dt_result.Rows.Add(productname_hidden.Value, perfname_hidden.Value);
                            perfname_hidden.Value = "";
                            sb_perfid.Clear();
                        }
                        
                    }

                }
                GridView1.DataSource = dt_result;
                GridView1.DataBind();
            }
        }
       
    }

    protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
    {
        BindPerfid();
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataBind();
    }
}