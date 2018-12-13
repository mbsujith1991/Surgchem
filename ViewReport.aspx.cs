using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using System.Data;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Web.Services;
using System.Collections;
using System.Text;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.Net;

public partial class ViewReport : System.Web.UI.Page
{
   
    int perfcount = 0;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.IsAuthenticated && Session["Usertype"] != null)
        {
            string usertype = Session["Usertype"].ToString();

            if (usertype == "")
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                 
                if (usertype == "2")
                {
                    
                    HtmlGenericControl listreport = (HtmlGenericControl)this.Master.FindControl("lireport");
                    listreport.Style.Add("background-color", "#195A7F");
                    HtmlGenericControl maindiv = (HtmlGenericControl)Master.FindControl("mainmenu");
                    maindiv.Visible = false;
                    HtmlGenericControl adminconsole = (HtmlGenericControl)this.Master.FindControl("adminconsole");
                    adminconsole.Visible = false;
                    LinkButton hyphome = (LinkButton)Page.Master.FindControl("home");
                    hyphome.Visible = false;
                    LinkButton lnkbackup = (LinkButton)Page.Master.FindControl("lnkbackup");
                    lnkbackup.Visible = false;
                    //pnlprint.Visible = false;
                    reportno_hidden.Value = Request.QueryString["reportno"];
                   
                }
                else
                {
                    HtmlGenericControl maindiv = (HtmlGenericControl)Master.FindControl("mainmenu");
                    maindiv.Visible = true;
                    HtmlGenericControl adminconsole = (HtmlGenericControl)this.Master.FindControl("adminconsole");
                    adminconsole.Visible = true;
                    LinkButton hyphome = (LinkButton)Page.Master.FindControl("home");
                    hyphome.Visible = true;
                    HtmlGenericControl listview = (HtmlGenericControl)this.Master.FindControl("liview");
                    listview.Style.Add("background-color", "#195A7F");
                    reportno_hidden.Value = Request.QueryString["reportno"];
                    btnprevent.Visible = false;
                    btnaddtestcases.Visible = false;
                    
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