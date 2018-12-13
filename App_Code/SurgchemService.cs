using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for SurgchemService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class SurgchemService : System.Web.Services.WebService {

    public SurgchemService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public List<string> GetProductName(string prefixText, int count)
    {
        using (SqlConnection con = new SqlConnection())
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["surgchemcon"].ConnectionString;

            using (SqlCommand com = new SqlCommand())
            {
                com.CommandText = "select distinct ProductName from Product where ProductName like @Search + '%'";
                //com.CommandText = "select ui.SubscriberID from UserInfo ui inner join LinkDevice ld on ui.SubscriberId=" +
                //    "ld.SubscriberID where ui.SubscriberId like @Search + '%' and ld.DeviceStatus='" +  + "'";
                com.Parameters.AddWithValue("@Search", prefixText);
                com.Connection = con;
                con.Open();
                List<string> productName = new List<string>();
                using (SqlDataReader sdr = com.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        productName.Add(sdr["ProductName"].ToString());
                    }
                }
                con.Close();
                return productName;
            }
        }
    }

    [WebMethod]
    public List<string> GetLocation(string prefixText, int count)
    {
        using (SqlConnection con = new SqlConnection())
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["surgchemcon"].ConnectionString;

            using (SqlCommand com = new SqlCommand())
            {
                com.CommandText = "select distinct Location from DUT_info where Location like @Search + '%'";
                //com.CommandText = "select ui.SubscriberID from UserInfo ui inner join LinkDevice ld on ui.SubscriberId=" +
                //    "ld.SubscriberID where ui.SubscriberId like @Search + '%' and ld.DeviceStatus='" +  + "'";
                com.Parameters.AddWithValue("@Search", prefixText);
                com.Connection = con;
                con.Open();
                List<string> location = new List<string>();
                using (SqlDataReader sdr = com.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        location.Add(sdr["Location"].ToString());
                    }
                }
                con.Close();
                return location;
            }
        }
    }

    [WebMethod]
    public List<string> GetBiomedicalID(string prefixText, int count)
    {
        using (SqlConnection con = new SqlConnection())
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["surgchemcon"].ConnectionString;

            using (SqlCommand com = new SqlCommand())
            {
                com.CommandText = "select distinct Biomedical_ID from DUT_info where Biomedical_ID like @Search + '%'";
                //com.CommandText = "select ui.SubscriberID from UserInfo ui inner join LinkDevice ld on ui.SubscriberId=" +
                //    "ld.SubscriberID where ui.SubscriberId like @Search + '%' and ld.DeviceStatus='" +  + "'";
                com.Parameters.AddWithValue("@Search", prefixText);
                com.Connection = con;
                con.Open();
                List<string> biomedicalId = new List<string>();
                using (SqlDataReader sdr = com.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        biomedicalId.Add(sdr["Biomedical_ID"].ToString());
                    }
                }
                con.Close();
                return biomedicalId;
            }
        }
    }

    [WebMethod]
    public List<string> GetSerialNo(string prefixText, int count)
    {
        using (SqlConnection con = new SqlConnection())
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["surgchemcon"].ConnectionString;

            using (SqlCommand com = new SqlCommand())
            {
                com.CommandText = "select distinct Serial_No from DUT_info where Serial_No like @Search + '%'";
                //com.CommandText = "select ui.SubscriberID from UserInfo ui inner join LinkDevice ld on ui.SubscriberId=" +
                //    "ld.SubscriberID where ui.SubscriberId like @Search + '%' and ld.DeviceStatus='" +  + "'";
                com.Parameters.AddWithValue("@Search", prefixText);
                com.Connection = con;
                con.Open();
                List<string> serialNo = new List<string>();
                using (SqlDataReader sdr = com.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        serialNo.Add(sdr["Serial_No"].ToString());
                    }
                }
                con.Close();
                return serialNo;
            }
        }
    }
}
