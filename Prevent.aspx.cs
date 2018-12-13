using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Data.SqlClient;

public partial class Prevent : System.Web.UI.Page
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
                    }

                }
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
}