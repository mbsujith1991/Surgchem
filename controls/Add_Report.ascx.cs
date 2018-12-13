using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Services;

public partial class controls_Add_Report : System.Web.UI.UserControl
{
    protected void Page_Init(object sender, EventArgs e)
    {
        //dbclass.strCommand="Select FirstName 
        if (Request.IsAuthenticated && Session["returnUrl"] != null)
        {
            string username = Page.User.Identity.Name;
            //db1.strCommand = "SELECT Username FROM LoginTb WHERE Username='" + username + "'";
            //string fullname = db1.sclarVal().ToString();

            Label1.Text = "Welcome " + username;
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [WebMethod]

    public static List<string> AutocompleteHospital(string HospitalName)
    {
        List<string> result = new List<string>();
        using (SqlConnection con = new SqlConnection("Data Source=.;Integrated Security=true;Initial Catalog=Surgchem"))
        {
            using (SqlCommand cmd = new SqlCommand("select DISTINCT HospitalName from Hospital where HospitalName LIKE '%'+@SearchText+'%'", con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@SearchText", HospitalName);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    result.Add(dr["HospitalName"].ToString());
                }
                return result;
            }
        }
    }
}