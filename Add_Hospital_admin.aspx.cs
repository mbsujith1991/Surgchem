using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;
using System.Web.Script.Services;
using System.IO;
using System.Web.Security;
using System.Web.UI.HtmlControls;

public partial class Add_Hospital_admin : System.Web.UI.Page
{
    string utypeid = string.Empty;
    Dbclass db1 = new Dbclass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.IsAuthenticated && Session["Usertype"] != null)
        {
            utypeid = Session["Usertype"].ToString();
            AddHospital.UsertypeID = utypeid.ToString();
            if (utypeid == "")
            {
                Response.Redirect("Default.aspx");
            }
            else if (utypeid=="0")
            {
               HtmlGenericControl listhospital = (HtmlGenericControl)this.Master.FindControl("lihospital");
               listhospital.Style.Add("background-color", "#195A7F");
            }
            else if (utypeid == "1")
            {
               HtmlGenericControl listhospital = (HtmlGenericControl)this.Master.FindControl("lihospital");
               listhospital.Style.Add("background-color", "#195A7F");
               DropDownList ddlstatus = (DropDownList)AddHospital.FindControl("ddlstatus");
               ddlstatus.Visible = false;
              
                
            }
            else if (utypeid == "3")
            {
                HtmlGenericControl listhospital = (HtmlGenericControl)this.Master.FindControl("lihospital");
                listhospital.Style.Add("background-color", "#195A7F");
                DropDownList ddlstatus = (DropDownList)AddHospital.FindControl("ddlstatus");
                ddlstatus.Visible = false;


            }
            else if (utypeid == "4")
            {
                HtmlGenericControl listhospital = (HtmlGenericControl)this.Master.FindControl("lihospital");
                listhospital.Style.Add("background-color", "#195A7F");
                DropDownList ddlstatus = (DropDownList)AddHospital.FindControl("ddlstatus");
                ddlstatus.Visible = false;


            }
            else
            {
                Response.Redirect("Default.aspx");
            }
           
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }

   
}