using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class AdminPrevention : System.Web.UI.Page
{

    Dbclass db = new Dbclass();
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
                        BindPrevention();
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
                        PopulateHospitalId();
                        BindPrevention();
                    }

                }
            }
        }
        
    }
    protected void grdPrevention_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            ListBox lstcalibration = (ListBox)e.Row.FindControl("lstcalibration");
            HiddenField HiddenFieldPreventID = (HiddenField)e.Row.FindControl("HiddenFieldPreventID");
            int preventid = Convert.ToInt32(HiddenFieldPreventID.Value);
            db.strCommand = "Select ct.TestID,ct.TestName from AddCalibrationTest ct inner join Prevent_Join_Calibration pjc on " +
                       " ct.TestID=pjc.TestID where pjc.PreventID='" + preventid + "' and ct.ActiveStatus=1";
            DataTable dt = db.selecttable();
            lstcalibration.DataSource = dt;
            lstcalibration.DataTextField = "TestName";
            lstcalibration.DataValueField = "TestID";
            lstcalibration.DataBind();
        }
    }
    protected void grdPrevention_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdPrevention.PageIndex = e.NewPageIndex;
        BindPrevention();
    }

    public void BindPrevention()
    {
        if (!string.IsNullOrEmpty(hospitalidhidden.Value))
        {
            db.strCommand = "Select * from Prevention p inner join Hospital h on p.HospitalID=h.HospitalID where   p.ActiveStatus=1";
            DataTable dt = db.selecttable();
            grdPrevention.DataSource = dt;
            grdPrevention.DataBind();
        }

    }

    public void PopulateHospitalId()
    {
        if (utypeid_hidden.Value == "2")
        {
            db.strCommand = "select hp.HospitalID,hp.HospitalName from Hospital hp " +
                            "inner join LoginTb lg on lg.LoginID=hp.LoginID where lg.Username='" + Page.User.Identity.Name + "' ";
            //hospid.Text=db1.executescalar();
            DataTable dt = db.selecttable();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    hospitalidhidden.Value = dt.Rows[0]["HospitalID"].ToString();
                    //hospnamehidden.Value = dt.Rows[0]["HospitalName"].ToString();
                }
            }
        }
    }
}