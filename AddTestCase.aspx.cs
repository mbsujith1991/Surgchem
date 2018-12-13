using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class AddTestCase : System.Web.UI.Page
{
    Dbclass db1 = new Dbclass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.IsAuthenticated && Session["Usertype"] != null)
        {

            utypeid_hidden.Value = Session["Usertype"].ToString();
            if (utypeid_hidden.Value == null)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    if (utypeid_hidden.Value == "2")
                    {
                        HtmlGenericControl listview = (HtmlGenericControl)this.Master.FindControl("liview");
                        listview.Style.Add("background-color", "#195A7F");
                        HtmlGenericControl maindiv = (HtmlGenericControl)Master.FindControl("mainmenu");
                        maindiv.Visible = false;
                        HtmlGenericControl adminconsole = (HtmlGenericControl)this.Master.FindControl("adminconsole");
                        adminconsole.Visible = false;
                        LinkButton hyphome = (LinkButton)Page.Master.FindControl("home");
                        hyphome.Visible = false;
                        LinkButton lnkbackup = (LinkButton)Page.Master.FindControl("lnkbackup");
                        lnkbackup.Visible = false;
                        PopulateHospitalId();
                        BindGrid();
                        
                    }
                    else
                    {
                        HtmlGenericControl listview = (HtmlGenericControl)this.Master.FindControl("liview");
                        listview.Style.Add("background-color", "#195A7F");
                        HtmlGenericControl maindiv = (HtmlGenericControl)Master.FindControl("mainmenu");
                        maindiv.Visible = true;
                        HtmlGenericControl adminconsole = (HtmlGenericControl)this.Master.FindControl("adminconsole");
                        adminconsole.Visible = true;
                        LinkButton hyphome = (LinkButton)Page.Master.FindControl("home");
                        hyphome.Visible = true;
                        btnprevent.Visible = false;
                        btnaddtestcases.Visible = false;
                        //PopulateHospitalId();
                        BindGrid();
                    }

                }
                lblmsg.Text = string.Empty;
            }
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void btnprodview_Click(object sender, EventArgs e)
    {
        Response.Redirect("Productview.aspx");
    }
    protected void btnviewreport_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewReport.aspx");
    }
    protected void btnprevent_Click(object sender, EventArgs e)
    {
        Response.Redirect("Prevent.aspx");
    }
    protected void btnaddtestcases_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddTestCase.aspx");
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (btnsave.Text == "Save")
        {
            Insert();

        }
        else if (btnsave.Text == "Update")
        {
            Update();
            btnsave.Text = "Save";
        }
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        if (btnsave.Text == "Update")
        {
            MultiView1.ActiveViewIndex = 1;
            txtdescrption.Text = string.Empty;
            txttestname.Text = string.Empty;
            btnsave.Text = "Save";
            lblmsg.Text = string.Empty;
        }
        else
        {
            txtdescrption.Text = string.Empty;
            txttestname.Text = string.Empty;
            btnsave.Text = "Save";
            lblmsg.Text = string.Empty;
        }
       
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        PopulateHospitalId();
        testidhidden.Value = e.CommandArgument.ToString();
        if (e.CommandName == "U")
        {
            MultiView1.ActiveViewIndex = 0;
            btnsave.Text = "Update";
            db1.strCommand = "Select * from AddCalibrationTest where ActiveStatus='True' and TestID='" + testidhidden.Value + "'";
            DataTable dt = db1.selecttable();
            if(dt.Rows.Count>0)
            {
                txttestname.Text = dt.Rows[0]["TestName"].ToString();
                txtdescrption.Text = dt.Rows[0]["Description"].ToString();

                
            }
            
        }
        if (e.CommandName == "D")
        {
            string query = "Update AddCalibrationTest set ActiveStatus='False' where TestID='" + testidhidden.Value + "'";
            db1.executeQuery(query);
            BindGrid();
            lblmsg.Text = "Deleted Successfully";
            lblmsg.Style.Add("color", "green");
        }
    }

    public void PopulateHospitalId()
    {
        if (utypeid_hidden.Value == "2")
        {
            db1.strCommand = "select hp.HospitalID,hp.HospitalName from Hospital hp " +
                            "inner join LoginTb lg on lg.LoginID=hp.LoginID where lg.Username='" + Page.User.Identity.Name + "' ";
            //hospid.Text=db1.executescalar();
            DataTable dt = db1.selecttable();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    hospidhidden.Value = dt.Rows[0]["HospitalID"].ToString();
                    //hospnamehidden.Value = dt.Rows[0]["HospitalName"].ToString();
                }
            }
        }
    }

    public void BindGrid()
    {
        db1.strCommand = "Select * from AddCalibrationTest where ActiveStatus='True' and HospitalID='"+hospidhidden.Value+"'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        else
        {
            DataTable dt_cl = new DataTable();
            dt_cl.Clear();
            GridView1.DataSource = dt_cl;
            GridView1.DataBind();
        }
    }

    public void Insert()
    {
        try
        {
            string query = "insert into AddCalibrationTest(TestName,Description,HospitalID,ActiveStatus)values('" + txttestname.Text.Trim() + "','" + txtdescrption.Text.Trim() + "','"+hospidhidden.Value+"','True')";
            int i = db1.executeQuery(query);
            if (i == 1)
            {
                BindGrid();
                txtdescrption.Text = string.Empty;
                txttestname.Text = string.Empty;
                lblmsg.Text = "Inserted Successfully";
                lblmsg.Style.Add("color", "green");
            }
            else
            {
                BindGrid();
                txtdescrption.Text = string.Empty;
                txttestname.Text = string.Empty;
                lblmsg.Text = "Insertion Failed";
                lblmsg.Style.Add("color", "red");
            }
        }
        catch(Exception ex)
        {
            lblmsg.Text = "Insertion Failed";
            lblmsg.Style.Add("color", "red");
        }
    }

    public void Update()
    {
        string query = "Update AddCalibrationTest set ActiveStatus='True',TestName='" + txttestname.Text.Trim() + "'," +
                "Description='" + txtdescrption.Text.Trim() + "',HospitalID='"+hospidhidden.Value+"' where TestID='" + testidhidden.Value + "'";
        int i = db1.executeQuery(query);
        if (i == 1)
        {
            BindGrid();
            txtdescrption.Text = string.Empty;
            txttestname.Text = string.Empty;
            lblmsg.Text = "Updated Successfully";
            lblmsg.Style.Add("color", "green");
        }
        else
        {
            BindGrid();
            txtdescrption.Text = string.Empty;
            txttestname.Text = string.Empty;
            lblmsg.Text = "Updation Failed";
            lblmsg.Style.Add("color", "red");
        }
    }
    protected void btnviewtest_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }
    protected void btnaddtest_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }
}