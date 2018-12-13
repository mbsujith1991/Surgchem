using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Web.Services;
using System.Data.SqlClient;
using System.Collections;
using System.Text;
using System.Configuration;

public partial class controls_Productviewforcustomer : System.Web.UI.UserControl
{
    Dbclass db1 = new Dbclass();
    string usertype = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        usertype = Session["Usertype"].ToString();
        if (!IsPostBack)
        {
            PopulateHospitalId();
            PopulateProductdetails();
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        PopulateProductdetails();
    }

    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> SearchProduct(string prefixText, int count)
    {
        using (SqlConnection conn = new SqlConnection())
        {
            conn.ConnectionString = ConfigurationManager
                    .ConnectionStrings["surgchemcon"].ConnectionString;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "select ProductName from Product where " +
                "ProductName like @SearchText + '%'";
                cmd.Parameters.AddWithValue("@SearchText", prefixText);
                cmd.Connection = conn;
                conn.Open();
                List<string> customers = new List<string>();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        customers.Add(sdr["ProductName"].ToString());
                    }
                }
                conn.Close();
                return customers;
            }
        }
    }

    public void PopulateHospitalId()
    {
        if (usertype == "2")
        {
            db1.strCommand = "select hp.HospitalID,hp.HospitalName from Hospital hp " +
                            "inner join LoginTb lg on lg.LoginID=hp.LoginID where lg.Username='" + Page.User.Identity.Name + "' ";
            //hospid.Text=db1.executescalar();
            DataTable dt = db1.selecttable();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    hospid.Value = dt.Rows[0]["HospitalID"].ToString();
                    //hospnamehidden.Value = dt.Rows[0]["HospitalName"].ToString();
                }
            }
        }
    }
    public void PopulateProductdetails()
    {
        if (usertype == "2")
        {
            int hpid = Convert.ToInt32(hospid.Value);
            
            db1.strCommand = "select rp.Report_info_ID,rp.ReportNo,rp.Barcode_ID,rp.ProductID,rp.Date_of_calibration,hsp.HospitalName,dt.Biomedical_ID,dt.Serial_No," +
                            "dt.Location,p.ProductName,p.Company,p.Model from Report_Info rp inner join Hospital  hsp on rp.HospitalID =hsp.HospitalID " +
                            "inner join DUT_info  dt on dt.Report_info_ID=rp.Report_info_ID " +
                            "inner join Product p on rp.ProductID=p.ProductID where rp.HospitalID='"+hpid+"' order by rp.Report_info_ID desc" ;
            DataTable dt_result = db1.selecttable();
            if(dt_result.Rows.Count>0)
            {
                GridView1.DataSource = dt_result;
                GridView1.DataBind();
            }
            //db1.strCommand = "select rp.Report_info_ID,rp.ReportNo,rp.Barcode_ID,rp.ProductID,rp.Date_of_calibration,hsp.HospitalName,dt.Biomedical_ID,dt.Serial_No,dt.Location from Report_Info as rp " +
            //                     "inner join Hospital as hsp on hsp.HospitalID=rp.HospitalID " +
            //                     "inner join DUT_info as dt on dt.Report_info_ID=rp.Report_info_ID where rp.HospitalID='" + hpid + "'";
            //DataTable dt = db1.selecttable();
            //dt_result.Columns.Add("Report_info_ID", typeof(int));
            //dt_result.Columns.Add("ProductID", typeof(int));
            //dt_result.Columns.Add("HospitalName", typeof(string));
            //dt_result.Columns.Add("Barcode_ID", typeof(string));
            //dt_result.Columns.Add("ProductName", typeof(string));
            //dt_result.Columns.Add("Company", typeof(string));
            //dt_result.Columns.Add("Model", typeof(string));
            ////dt_result.Columns.Add("Device_Type", typeof(string));
            //dt_result.Columns.Add("Biomedical_ID", typeof(string));
            ////dt_result.Columns.Add("Supply", typeof(string));
            //dt_result.Columns.Add("Date_of_calibration", typeof(string));
            //dt_result.Columns.Add("Serial_No", typeof(string));
            //dt_result.Columns.Add("Location", typeof(string));
            //dt_result.Columns.Add("ReportNo", typeof(string));
            //if (dt.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        hospnamehidden.Value = dt.Rows[i]["HospitalName"].ToString();
            //        db1.strCommand = "select * from Product where ProductID='" + dt.Rows[i]["ProductID"].ToString() + "'";
            //        DataTable dt_prod = db1.selecttable();
            //        if (dt_prod.Rows.Count > 0)
            //        {
            //            for (int j = 0; j < dt_prod.Rows.Count; j++)
            //            {


            //                dt_result.Rows.Add(dt.Rows[i]["Report_info_ID"].ToString(), dt_prod.Rows[j]["ProductID"].ToString(), dt.Rows[i]["HospitalName"].ToString(), dt.Rows[i]["Barcode_ID"].ToString(),
            //                                                dt_prod.Rows[j]["ProductName"].ToString(), dt_prod.Rows[j]["Company"].ToString(),
            //                                                dt_prod.Rows[j]["Model"].ToString(), dt.Rows[i]["Biomedical_ID"].ToString(), dt.Rows[i]["Date_of_calibration"].ToString(), dt.Rows[i]["Serial_No"].ToString(),
            //                                                dt.Rows[i]["Location"].ToString(), dt.Rows[i]["ReportNo"].ToString());
            //            }
            //            //DataTable dt1 = dt
            //            //object[] data = new object[dt_prod.Rows.Count];
            //            //data[j] = dt_prod.Rows[j].ToString();
            //            //dt_result.Rows.Add(data);

            //        }

            //    }

                

        }
        else
        {
            db1.strCommand = "select rp.Report_info_ID,rp.ReportNo,rp.Barcode_ID,rp.ProductID,rp.Date_of_calibration,hsp.HospitalName,dt.Biomedical_ID,dt.Serial_No," +
                            "dt.Location,p.ProductName,p.Company,p.Model from Report_Info rp inner join Hospital  hsp on rp.HospitalID =hsp.HospitalID " +
                            "inner join DUT_info  dt on dt.Report_info_ID=rp.Report_info_ID " +
                            "inner join Product p on rp.ProductID=p.ProductID";
            DataTable dt_result = db1.selecttable();
            if (dt_result.Rows.Count > 0)
            {
                GridView1.DataSource = dt_result;
                GridView1.DataBind();
            }
            //DataTable dt_result = new DataTable();
            //db1.strCommand = "select rp.Report_info_ID,rp.ReportNo,rp.Barcode_ID,rp.ProductID,rp.Date_of_calibration,hsp.HospitalName,dt.Biomedical_ID,dt.Serial_No,dt.Location from Report_Info as rp " +
            //                    "inner join Hospital as hsp on hsp.HospitalID=rp.HospitalID " +
            //                    "inner join DUT_info as dt on dt.Report_info_ID=rp.Report_info_ID";
            //DataTable dt = db1.selecttable();
            //dt_result.Columns.Add("Report_info_ID", typeof(int));
            //dt_result.Columns.Add("ProductID", typeof(int));
            //dt_result.Columns.Add("HospitalName", typeof(string));
            //dt_result.Columns.Add("Barcode_ID", typeof(string));
            //dt_result.Columns.Add("ProductName", typeof(string));
            //dt_result.Columns.Add("Company", typeof(string));
            //dt_result.Columns.Add("Model", typeof(string));
            ////dt_result.Columns.Add("Device_Type", typeof(string));
            //dt_result.Columns.Add("Biomedical_ID", typeof(string));
            ////dt_result.Columns.Add("Supply", typeof(string));
            //dt_result.Columns.Add("Date_of_calibration", typeof(string));
            //dt_result.Columns.Add("Serial_No", typeof(string));
            //dt_result.Columns.Add("Location", typeof(string));
            //dt_result.Columns.Add("ReportNo", typeof(string));
            //if (dt.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        hospnamehidden.Value = dt.Rows[i]["HospitalName"].ToString();
            //        db1.strCommand = "select * from Product where ProductID='" + dt.Rows[i]["ProductID"].ToString() + "'";
            //        DataTable dt_prod = db1.selecttable();
            //        if (dt_prod.Rows.Count > 0)
            //        {
            //            for (int j = 0; j < dt_prod.Rows.Count; j++)
            //            {


            //                dt_result.Rows.Add(dt.Rows[i]["Report_info_ID"].ToString(), dt_prod.Rows[j]["ProductID"].ToString(), dt.Rows[i]["HospitalName"].ToString(), dt.Rows[i]["Barcode_ID"].ToString(),
            //                                                 dt_prod.Rows[j]["ProductName"].ToString(), dt_prod.Rows[j]["Company"].ToString(),
            //                                                 dt_prod.Rows[j]["Model"].ToString(), dt.Rows[i]["Biomedical_ID"].ToString(),
            //                                                 dt.Rows[i]["Date_of_calibration"].ToString(), dt.Rows[i]["Serial_No"].ToString(), dt.Rows[i]["Location"].ToString(), dt.Rows[i]["ReportNo"].ToString());
            //            }
            //            //DataTable dt1 = dt
            //            //object[] data = new object[dt_prod.Rows.Count];
            //            //data[j] = dt_prod.Rows[j].ToString();
            //            //dt_result.Rows.Add(data);

            //        }

            //    }

            //    GridView1.DataSource = dt_result;
            //    GridView1.DataBind();
            //    lblerror.Visible = false;
            //}
        }
    }

    public void SearchDetails()
    {
        if (drpsearchtype.SelectedValue == "0")
        {
            if (usertype == "2")
            {
                int hpid = Convert.ToInt32(hospid.Value);

                db1.strCommand = "select rp.Report_info_ID,rp.ReportNo,rp.Barcode_ID,rp.ProductID,rp.Date_of_calibration,hsp.HospitalName,dt.Biomedical_ID,dt.Serial_No," +
                                "dt.Location,p.ProductName,p.Company,p.Model from Report_Info rp inner join Hospital  hsp on rp.HospitalID =hsp.HospitalID " +
                                "inner join DUT_info  dt on dt.Report_info_ID=rp.Report_info_ID " +
                                "inner join Product p on rp.ProductID=p.ProductID where  p.ProductName like '" + txtProductname.Text.Trim() + "%' and rp.HospitalID=" + hpid;
                DataTable dt_result = db1.selecttable();
                if (dt_result.Rows.Count > 0)
                {
                    GridView1.DataSource = dt_result;
                    GridView1.DataBind();
                }
                else
                {
                    DataTable dt_clear = new DataTable();
                    GridView1.DataSource = dt_clear;
                    GridView1.DataBind();
                    //lblerror.Visible = true;
                    //lblerror.Style.Add("color", "red");
                    //lblerror.Text = "No Records found";
                }

            }
            else
            {
                db1.strCommand = "select rp.Report_info_ID,rp.ReportNo,rp.Barcode_ID,rp.ProductID,rp.Date_of_calibration,hsp.HospitalName,dt.Biomedical_ID,dt.Serial_No," +
                            "dt.Location,p.ProductName,p.Company,p.Model from Report_Info rp inner join Hospital  hsp on rp.HospitalID =hsp.HospitalID " +
                            "inner join DUT_info  dt on dt.Report_info_ID=rp.Report_info_ID " +
                            "inner join Product p on rp.ProductID=p.ProductID where p.ProductName like '" + txtProductname.Text.Trim() + "%'";
                DataTable dt_result = db1.selecttable();
                if (dt_result.Rows.Count > 0)
                {
                    GridView1.DataSource = dt_result;
                    GridView1.DataBind();
                }
                else
                {
                    DataTable dt_clear = new DataTable();
                    GridView1.DataSource = dt_clear;
                    GridView1.DataBind();
                    //lblerror.Visible = true;
                    //lblerror.Style.Add("color", "red");
                    //lblerror.Text = "No Records found";
                }
            }
        }
        else if (drpsearchtype.SelectedValue == "1")
        {
            if (usertype == "2")
            {
                int hpid = Convert.ToInt32(hospid.Value);

                db1.strCommand = "select rp.Report_info_ID,rp.ReportNo,rp.Barcode_ID,rp.ProductID,rp.Date_of_calibration,hsp.HospitalName,dt.Biomedical_ID,dt.Serial_No," +
                                "dt.Location,p.ProductName,p.Company,p.Model from Report_Info rp inner join Hospital  hsp on rp.HospitalID =hsp.HospitalID " +
                                "inner join DUT_info  dt on dt.Report_info_ID=rp.Report_info_ID " +
                                "inner join Product p on rp.ProductID=p.ProductID where dt.Location like '" + txtsearchlocation.Text.Replace("'", "''") + "%' and rp.HospitalID=" + hpid;
                DataTable dt_result = db1.selecttable();
                if (dt_result.Rows.Count > 0)
                {
                    GridView1.DataSource = dt_result;
                    GridView1.DataBind();
                }
                else
                {
                    DataTable dt_clear = new DataTable();
                    GridView1.DataSource = dt_clear;
                    GridView1.DataBind();
                    //lblerror.Visible = true;
                    //lblerror.Style.Add("color", "red");
                    //lblerror.Text = "No Records found";
                }

            }
            else
            {

                db1.strCommand = "select rp.Report_info_ID,rp.ReportNo,rp.Barcode_ID,rp.ProductID,rp.Date_of_calibration,hsp.HospitalName,dt.Biomedical_ID,dt.Serial_No," +
                             "dt.Location,p.ProductName,p.Company,p.Model from Report_Info rp inner join Hospital  hsp on rp.HospitalID =hsp.HospitalID " +
                             "inner join DUT_info  dt on dt.Report_info_ID=rp.Report_info_ID " +
                             "inner join Product p on rp.ProductID=p.ProductID where dt.Location like '" + txtsearchlocation.Text.Replace("'", "''") + "%'";
                DataTable dt_result = db1.selecttable();
                if (dt_result.Rows.Count > 0)
                {
                    GridView1.DataSource = dt_result;
                    GridView1.DataBind();
                }
                else
                {
                    DataTable dt_clear = new DataTable();
                    GridView1.DataSource = dt_clear;
                    GridView1.DataBind();
                    //lblerror.Visible = true;
                    //lblerror.Style.Add("color", "red");
                    //lblerror.Text = "No Records found";
                }
            }
        }
        else if (drpsearchtype.SelectedValue == "2")
        {
            if (usertype == "2")
            {

                int hpid = Convert.ToInt32(hospid.Value);

                db1.strCommand = "select rp.Report_info_ID,rp.ReportNo,rp.Barcode_ID,rp.ProductID,rp.Date_of_calibration,hsp.HospitalName,dt.Biomedical_ID,dt.Serial_No," +
                                "dt.Location,p.ProductName,p.Company,p.Model from Report_Info rp inner join Hospital  hsp on rp.HospitalID =hsp.HospitalID " +
                                "inner join DUT_info  dt on dt.Report_info_ID=rp.Report_info_ID " +
                                "inner join Product p on rp.ProductID=p.ProductID where rp.Date_of_calibration like '" + txtdateofcalib.Text.Replace("'", "''") + "%' and rp.HospitalID=" + hpid;
                DataTable dt_result = db1.selecttable();
                if (dt_result.Rows.Count > 0)
                {
                    GridView1.DataSource = dt_result;
                    GridView1.DataBind();
                }
                else
                {
                    DataTable dt_clear = new DataTable();
                    GridView1.DataSource = dt_clear;
                    GridView1.DataBind();
                    //lblerror.Visible = true;
                    //lblerror.Style.Add("color", "red");
                    //lblerror.Text = "No Records found";
                }

            }
            else
            {

                db1.strCommand = "select rp.Report_info_ID,rp.ReportNo,rp.Barcode_ID,rp.ProductID,rp.Date_of_calibration,hsp.HospitalName,dt.Biomedical_ID,dt.Serial_No," +
                             "dt.Location,p.ProductName,p.Company,p.Model from Report_Info rp inner join Hospital  hsp on rp.HospitalID =hsp.HospitalID " +
                             "inner join DUT_info  dt on dt.Report_info_ID=rp.Report_info_ID " +
                             "inner join Product p on rp.ProductID=p.ProductID where rp.Date_of_calibration like '" + txtdateofcalib.Text.Replace("'", "''") + "%'";
                DataTable dt_result = db1.selecttable();
                if (dt_result.Rows.Count > 0)
                {
                    GridView1.DataSource = dt_result;
                    GridView1.DataBind();
                }
                else
                {
                    DataTable dt_clear = new DataTable();
                    GridView1.DataSource = dt_clear;
                    GridView1.DataBind();
                    //lblerror.Visible = true;
                    //lblerror.Style.Add("color", "red");
                    //lblerror.Text = "No Records found";
                }
            }
        }
        else if (drpsearchtype.SelectedValue == "3")
        {
            if (usertype == "2")
            {

                int hpid = Convert.ToInt32(hospid.Value);

                db1.strCommand = "select rp.Report_info_ID,rp.ReportNo,rp.Barcode_ID,rp.ProductID,rp.Date_of_calibration,hsp.HospitalName,dt.Biomedical_ID,dt.Serial_No," +
                                "dt.Location,p.ProductName,p.Company,p.Model from Report_Info rp inner join Hospital  hsp on rp.HospitalID =hsp.HospitalID " +
                                "inner join DUT_info  dt on dt.Report_info_ID=rp.Report_info_ID " +
                                "inner join Product p on rp.ProductID=p.ProductID where dt.Serial_No like '" + txtSearchSerialNo.Text.Replace("'", "''") + "%' and rp.HospitalID=" + hpid;
                DataTable dt_result = db1.selecttable();
                if (dt_result.Rows.Count > 0)
                {
                    GridView1.DataSource = dt_result;
                    GridView1.DataBind();
                }
                else
                {
                    DataTable dt_clear = new DataTable();
                    GridView1.DataSource = dt_clear;
                    GridView1.DataBind();
                    //lblerror.Visible = true;
                    //lblerror.Style.Add("color", "red");
                    //lblerror.Text = "No Records found";
                }

            }
            else
            {

                db1.strCommand = "select rp.Report_info_ID,rp.ReportNo,rp.Barcode_ID,rp.ProductID,rp.Date_of_calibration,hsp.HospitalName,dt.Biomedical_ID,dt.Serial_No," +
                             "dt.Location,p.ProductName,p.Company,p.Model from Report_Info rp inner join Hospital  hsp on rp.HospitalID =hsp.HospitalID " +
                             "inner join DUT_info  dt on dt.Report_info_ID=rp.Report_info_ID " +
                             "inner join Product p on rp.ProductID=p.ProductID where dt.Serial_No like '" + txtSearchSerialNo.Text.Replace("'", "''") + "%'";
                DataTable dt_result = db1.selecttable();
                if (dt_result.Rows.Count > 0)
                {
                    GridView1.DataSource = dt_result;
                    GridView1.DataBind();
                }
                else
                {
                    DataTable dt_clear = new DataTable();
                    GridView1.DataSource = dt_clear;
                    GridView1.DataBind();
                    //lblerror.Visible = true;
                    //lblerror.Style.Add("color", "red");
                    //lblerror.Text = "No Records found";
                }
            }
        }
        else if (drpsearchtype.SelectedValue == "4")
        {
            if (usertype == "2")
            {

                int hpid = Convert.ToInt32(hospid.Value);

                db1.strCommand = "select rp.Report_info_ID,rp.ReportNo,rp.Barcode_ID,rp.ProductID,rp.Date_of_calibration,hsp.HospitalName,dt.Biomedical_ID,dt.Serial_No," +
                                "dt.Location,p.ProductName,p.Company,p.Model from Report_Info rp inner join Hospital  hsp on rp.HospitalID =hsp.HospitalID " +
                                "inner join DUT_info  dt on dt.Report_info_ID=rp.Report_info_ID " +
                                "inner join Product p on rp.ProductID=p.ProductID where dt.Biomedical_ID like '" + txtSearchBiomed.Text.Replace("'", "''") + "%' and rp.HospitalID=" + hpid;
                DataTable dt_result = db1.selecttable();
                if (dt_result.Rows.Count > 0)
                {
                    GridView1.DataSource = dt_result;
                    GridView1.DataBind();
                }
                else
                {
                    DataTable dt_clear = new DataTable();
                    GridView1.DataSource = dt_clear;
                    GridView1.DataBind();
                    //lblerror.Visible = true;
                    //lblerror.Style.Add("color", "red");
                    //lblerror.Text = "No Records found";
                }

            }
            else
            {

                db1.strCommand = "select rp.Report_info_ID,rp.ReportNo,rp.Barcode_ID,rp.ProductID,rp.Date_of_calibration,hsp.HospitalName,dt.Biomedical_ID,dt.Serial_No," +
                             "dt.Location,p.ProductName,p.Company,p.Model from Report_Info rp inner join Hospital  hsp on rp.HospitalID =hsp.HospitalID " +
                             "inner join DUT_info  dt on dt.Report_info_ID=rp.Report_info_ID " +
                             "inner join Product p on rp.ProductID=p.ProductID where dt.Biomedical_ID like '" + txtSearchBiomed.Text.Replace("'", "''") + "%'";
                DataTable dt_result = db1.selecttable();
                if (dt_result.Rows.Count > 0)
                {
                    GridView1.DataSource = dt_result;
                    GridView1.DataBind();
                }
                else
                {
                    DataTable dt_clear = new DataTable();
                    GridView1.DataSource = dt_clear;
                    GridView1.DataBind();
                    //lblerror.Visible = true;
                    //lblerror.Style.Add("color", "red");
                    //lblerror.Text = "No Records found";
                }
            }
        }
    }
   

   
    
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string reportno = ((LinkButton)GridView1.SelectedRow.FindControl("lnkreportno")).Text;
        Response.Redirect("ViewReport.aspx?reportno=" + reportno);
       
    }

    protected void radiosearchtype_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
    protected void btnSearchreport_Click(object sender, EventArgs e)
    {
        SearchDetails();
    }
    protected void drpsearchtype_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (drpsearchtype.SelectedValue == "0")
        {
            txtProductname.Visible = true;
            txtsearchlocation.Visible = false;
            txtdateofcalib.Visible = false;
            txtSearchSerialNo.Visible = false;
            txtSearchBiomed.Visible = false;
            SearchDetails();
        }
        else if (drpsearchtype.SelectedValue == "1")
        {
            txtProductname.Visible = false;
            txtsearchlocation.Visible = true;
            txtdateofcalib.Visible = false;
            txtSearchSerialNo.Visible = false;
            txtSearchBiomed.Visible = false;
            SearchDetails();
        }
        else if (drpsearchtype.SelectedValue == "2")
        {
            txtProductname.Visible = false;
            txtsearchlocation.Visible = false;
            txtdateofcalib.Visible = true;
            txtSearchSerialNo.Visible = false;
            txtSearchBiomed.Visible = false;
            SearchDetails();
        }
        else if (drpsearchtype.SelectedValue == "3")
        {
            txtProductname.Visible = false;
            txtsearchlocation.Visible = false;
            txtdateofcalib.Visible = false;
            txtSearchSerialNo.Visible = true;
            txtSearchBiomed.Visible = false;
            SearchDetails();
        }
        else if (drpsearchtype.SelectedValue == "4")
        {
            txtProductname.Visible = false;
            txtsearchlocation.Visible = false;
            txtdateofcalib.Visible = false;
            txtSearchSerialNo.Visible = false;
            txtSearchBiomed.Visible = true;
            SearchDetails();
        }
    }
   
    protected void lnkprevent_Click(object sender, EventArgs e)
    {
        if (usertype == "2")
        {
            GridViewRow gvrow = (GridViewRow)((Button)sender).NamingContainer;
            int userid = Convert.ToInt32(GridView1.DataKeys[gvrow.RowIndex].Value);
            //int userid = int.Parse(((Button)GridView1.SelectedRow.FindControl("lnkprevent")).CommandArgument);
            Response.Redirect("Prevent.aspx?reportid=" + userid);
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Access Denied ');", true);
        }
    }
}