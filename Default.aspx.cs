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

public partial class _Default : System.Web.UI.Page
{
    Dbclass db1 = new Dbclass();
    protected void Page_Load(object sender, EventArgs e)
    {
        txtUsername.Focus();
        
    }
    string usertype = string.Empty;


    protected void btnlogin_Click(object sender, EventArgs e)
    {
        FormsAuthentication.Initialize();


        FormsAuthentication.SignOut();
        FormsAuthentication.Initialize();
        
        string query1 = "select * from LoginTb where Username='" + txtUsername.Value.Trim().Replace("'","''")+ "' and Password='" + txtPwd.Value.Trim().Replace("'", "''") + "'";
        SqlDataReader reader = db1.getDataReader(query1);
        FormsAuthentication.HashPasswordForStoringInConfigFile(txtPwd.Value, "sha1");
        // Fill our parameters

        if (reader.Read())
        {
            usertype = reader["Usertype"].ToString();
            // Create a new ticket used for authentication
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
            1, txtUsername.Value, DateTime.Now, DateTime.Now.AddMinutes(30), true, reader.GetString(1), FormsAuthentication.FormsCookiePath);

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
                //SelectMethod();
                Response.Redirect("Add_Hospital_admin.aspx");

            }
            else if (usertypeid == "1" || usertypeid=="3" || usertypeid=="4" || usertypeid=="5" || usertypeid=="6")
            {
                //SelectMethod();
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
            //// Username and or password not found in our database...
            //lbMsg.Text = "Username / password incorrect. Please login again.";
            //lbMsg.ForeColor = System.Drawing.Color.Red;
            //lbMsg.Visible = true;
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Invalid Username/Password !');", true);
        }

        reader.Close();
    }

    //public void Dbbackup()
    //{
    //    db1.strCommand = "select * from Calibration_Status";
    //    DataTable dt1 = db1.selecttable();
    //    string test = JsonConvert.SerializeObject(dt1);
    //    DataTable dt1_1 = (DataTable)JsonConvert.DeserializeObject(test, dt1.GetType());
    //    string filename = "~/Temp/Calibration_Status.txt";
    //    //StreamWriter sw = new StreamWriter(Server.MapPath(filename));
    //    using (var writer = new StreamWriter(Server.MapPath(filename)))
    //    {
    //        writer.WriteLine(test);
    //    }
    //    HyperLink1.NavigateUrl = strFileName;
    //}

    [WebMethod]
    public static string SelectMethod()
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Surgchem;Integrated Security=true");
        {
            SqlCommand cmd = new SqlCommand("select * from Calibration_Status", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());


                using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/Calibration_Status.txt")))
                {
                    writer.WriteLine(test);
                }


            }
            SqlCommand cmd1 = new SqlCommand("select * from check_perftest", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/check_perftest.txt")))
                {
                    writer.WriteLine(test);
                }



            }
            SqlCommand cmd2 = new SqlCommand("select * from Customer_Info", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/Customer_Info.txt")))
                {
                    writer.WriteLine(test);
                }



            }
            SqlCommand cmd3 = new SqlCommand("select * from DUT_info", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd3);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/DUT_info.txt")))
                {
                    writer.WriteLine(test);
                }



            }
            SqlCommand cmd4 = new SqlCommand("select * from ElectricalSafety", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd4);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/ElectricalSafety.txt")))
                {
                    writer.WriteLine(test);
                }



            }
            SqlCommand cmd5 = new SqlCommand("select * from Environ_condition", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd5);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/Environ_condition.txt")))
                {
                    writer.WriteLine(test);
                }



            }
            SqlCommand cmd6 = new SqlCommand("select * from Hospital", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd6);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/Hospital.txt")))
                {
                    writer.WriteLine(test);
                }



            }
            SqlCommand cmd7 = new SqlCommand("select * from LoginTb", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd7);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/LoginTb.txt")))
                {
                    writer.WriteLine(test);
                }



            }
            SqlCommand cmd8 = new SqlCommand("select * from Performance_Values", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd8);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/Performance_Values.txt")))
                {
                    writer.WriteLine(test);
                }



            }
            SqlCommand cmd9 = new SqlCommand("select * from PerformanceTest", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd9);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/PerformanceTest.txt")))
                {
                    writer.WriteLine(test);
                }



            }
            SqlCommand cmd10 = new SqlCommand("select * from perfvaluesplit", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd10);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/perfvaluesplit.txt")))
                {
                    writer.WriteLine(test);
                }



            }
            SqlCommand cmd11 = new SqlCommand("select * from Product", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd11);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/Product.txt")))
                {
                    writer.WriteLine(test);
                }



            }
            SqlCommand cmd12 = new SqlCommand("select * from Report_Info", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd12);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/Report_Info.txt")))
                {
                    writer.WriteLine(test);
                }



            }
            SqlCommand cmd13 = new SqlCommand("select * from Traceability_Info", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd13);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/Traceability_Info.txt")))
                {
                    writer.WriteLine(test);
                }


                return test;
            }
        }
    }
}