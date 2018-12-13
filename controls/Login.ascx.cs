using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class controls_Login : System.Web.UI.UserControl
{
    Dbclass db1 = new Dbclass();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        txtUsername.Focus();
        HtmlGenericControl footer = new HtmlGenericControl();
        footer = (HtmlGenericControl)this.Page.Master.FindControl("footer");
        footer.Visible = false;
    }
    string usertype = string.Empty;
   

    protected void btnlogin_Click(object sender, EventArgs e)
    {
        FormsAuthentication.Initialize();


        FormsAuthentication.SignOut();
        FormsAuthentication.Initialize();

        string query1 = "select * from LoginTb where Username='" + txtUsername.Text.Trim().Replace("'", "''") + "' and Password='" + txtPwd.Text.Trim().Replace("'", "''") + "'";
        SqlDataReader reader = db1.getDataReader(query1);
        FormsAuthentication.HashPasswordForStoringInConfigFile(txtPwd.Text, "sha1");
        // Fill our parameters

        if (reader.Read())
        {
            usertype = reader["Usertype"].ToString();
            // Create a new ticket used for authentication
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
            1, txtUsername.Text, DateTime.Now, DateTime.Now.AddMinutes(30), true, reader.GetString(1), FormsAuthentication.FormsCookiePath);

            // Hash the cookie for transport over the wire
            string hash = FormsAuthentication.Encrypt(ticket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hash);

            // Add the cookie to the list for outbound response
            Response.Cookies.Add(cookie);

            //Redirect to requested URL, or homepage if no previous page requested
            string returnUrl = Request.QueryString["ReturnUrl"];
            if (returnUrl == null) returnUrl = "Login.aspx";
            Session["Usertype"] = reader["Usertype"].ToString();
            string usertypeid = Session["Usertype"].ToString();
            if (usertypeid == null)
            {
                Response.Redirect("Default.aspx");
            }

            if (usertypeid == "0")
            {
                db_backup();
                Response.Redirect("Add_Hospital_admin.aspx");
                
            }
            else if (usertypeid=="1")
            {
                db_backup();
                Response.Redirect("AddReport.aspx");
            }
            else if (usertypeid == "2")
            {
                Response.Redirect("ViewReport.aspx");
            }
            else
            {
                Response.Redirect("Default.aspx");
            }


        }
        else
        {
            // Username and or password not found in our database...
            lbMsg.Text = "Username / password incorrect. Please login again.";
            lbMsg.ForeColor = System.Drawing.Color.Red;
            lbMsg.Visible = true;
        }

        reader.Close();
    }

    public void db_backup()
    {
        db1.strCommand = "select * from LoginTb";
        DataSet ds = new DataSet();
        ds = db1.selectqry();
        //ds.Tables[0].WriteXml(@"D:\resumes\LoginTb.xml");
        ds.Tables[0].WriteXml(Server.MapPath("~/DB_Backup/LoginTb.xml"));

        db1.strCommand = "select * from Hospital";
        DataSet ds_hospital = new DataSet();
        ds_hospital = db1.selectqry();
        //ds_hospital.Tables[0].WriteXml(@"D:\resumes\Hospital.xml");
        ds_hospital.Tables[0].WriteXml(Server.MapPath("~/DB_Backup/Hospital.xml"));

        db1.strCommand = "select * from Calibration_Status";
        DataSet ds_calib = new DataSet();
        ds_calib = db1.selectqry();
        //ds_calib.Tables[0].WriteXml(@"D:\resumes\Calibration_Status.xml");
        ds_calib.Tables[0].WriteXml(Server.MapPath("~/DB_Backup/Calibration_Status.xml"));

        db1.strCommand = "select * from Customer_Info";
        DataSet ds_customer = new DataSet();
        ds_customer = db1.selectqry();
        //ds_customer.Tables[0].WriteXml(@"D:\resumes\Customer_Info.xml");
        ds_customer.Tables[0].WriteXml(Server.MapPath("~/DB_Backup/Customer_Info.xml"));

        db1.strCommand = "select * from DUT_info";
        DataSet ds_dut = new DataSet();
        ds_dut = db1.selectqry();
        //ds_dut.Tables[0].WriteXml(@"D:\resumes\DUT_info.xml");
        ds_dut.Tables[0].WriteXml(Server.MapPath("~/DB_Backup/DUT_info.xml"));

        db1.strCommand = "select * from ElectricalSafety";
        DataSet ds_electrical = new DataSet();
        ds_electrical = db1.selectqry();
        //ds_electrical.Tables[0].WriteXml(@"D:\resumes\ElectricalSafety.xml");
        ds_electrical.Tables[0].WriteXml(Server.MapPath("~/DB_Backup/ElectricalSafety.xml"));

        db1.strCommand = "select * from Environ_condition";
        DataSet ds_environ = new DataSet();
        ds_environ = db1.selectqry();
        //ds_environ.Tables[0].WriteXml(@"D:\resumes\Environ_condition.xml");
        ds_environ.Tables[0].WriteXml(Server.MapPath("~/DB_Backup/Environ_condition.xml"));

        db1.strCommand = "select * from Perf_Category";
        DataSet ds_perfcategory = new DataSet();
        ds_perfcategory = db1.selectqry();
        //ds_perfcategory.Tables[0].WriteXml(@"D:\resumes\Perf_Category.xml");
        ds_perfcategory.Tables[0].WriteXml(Server.MapPath("~/DB_Backup/Perf_Category.xml"));

        db1.strCommand = "select * from Perf_SubCategory";
        DataSet ds_subcategory = new DataSet();
        ds_subcategory = db1.selectqry();
        //ds_subcategory.Tables[0].WriteXml(@"D:\resumes\Perf_SubCategory.xml");
        ds_subcategory.Tables[0].WriteXml(Server.MapPath("~/DB_Backup/Perf_SubCategory.xml"));

        db1.strCommand = "select * from Perf_Value";
        DataSet ds_value = new DataSet();
        ds_value = db1.selectqry();
        //ds_value.Tables[0].WriteXml(@"D:\resumes\Perf_Value.xml");
        ds_value.Tables[0].WriteXml(Server.MapPath("~/DB_Backup/Perf_Value.xml"));

        db1.strCommand = "select * from PerformanceTest";
        DataSet ds_perftest = new DataSet();
        ds_perftest = db1.selectqry();
        //ds_perftest.Tables[0].WriteXml(@"D:\resumes\PerformanceTest.xml");
        ds_perftest.Tables[0].WriteXml(Server.MapPath("~/DB_Backup/PerformanceTest.xml"));

        db1.strCommand = "select * from Product";
        DataSet ds_product = new DataSet();
        ds_product = db1.selectqry();
        //ds_product.Tables[0].WriteXml(@"D:\resumes\Product.xml");
        ds_product.Tables[0].WriteXml(Server.MapPath("~/DB_Backup/Product.xml"));

        db1.strCommand = "select * from Report_Info";
        DataSet ds_report = new DataSet();
        ds_report = db1.selectqry();
        //ds_report.Tables[0].WriteXml(@"D:\resumes\Report_Info.xml");
        ds_report.Tables[0].WriteXml(Server.MapPath("~/DB_Backup/Report_Info.xml"));

        db1.strCommand = "select * from Traceability_Info";
        DataSet ds_traceability = new DataSet();
        ds_traceability = db1.selectqry();
        //ds_traceability.Tables[0].WriteXml(@"D:\resumes\Traceability_Info.xml");
        ds_traceability.Tables[0].WriteXml(Server.MapPath("~/DB_Backup/Traceability_Info.xml"));
    }
}