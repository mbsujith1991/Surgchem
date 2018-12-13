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

public partial class controls_PreventiveMaintenance : System.Web.UI.UserControl
{
    Dbclass db1 = new Dbclass();
    string usertype = "";
    DataTable calibdatetable = new DataTable();
    DateTime preventdatetime = new DateTime();
    Int32 preventid;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        usertype = Session["Usertype"].ToString();
        if (!IsPostBack)
        {
            clear();
            if (usertype == "2")
            {
                reportidhidden.Value = Request.QueryString["reportid"];
                PopulateHospitalId();
                datepreventionhidden.Value = preventdatetime.ToString();
                datepreventionhidden.Value = preventdatetime.ToString();
                PopulateProductdetails();
                GridBind();
            }
            else
            {
                Response.Redirect("Productview.aspx");
            }
        }
    }


   
    public void PopulateHospitalId()
    {
        if (usertype == "2")
        {
            db1.strCommand = "select HospitalID from Hospital hp " +
                            "inner join LoginTb lg on lg.LoginID=hp.LoginID where lg.Username='" + Page.User.Identity.Name + "' ";
            //hospid.Text=db1.executescalar();
            DataTable dt = db1.selecttable();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    idhospitalhidden.Value = dt.Rows[0]["HospitalID"].ToString();
                }
            }
        }
    }
    public void PopulateProductdetails()
    {
        if (usertype == "2")
        {
            
                    int hpid = Convert.ToInt32(idhospitalhidden.Value);
                    DataTable dt_result = new DataTable();
                    db1.strCommand = "select rp.ReportNo,rp.ProductID,rp.Date_of_calibration,hp.HospitalName,dt.Serial_No,dt.Biomedical_ID,dt.Location from Report_Info rp " +
                                         "inner join Hospital hp on hp.HospitalID=rp.HospitalID " +
                                         "inner join DUT_info dt on dt.Report_info_ID=rp.Report_info_ID where rp.HospitalID='" + hpid + "' and rp.Report_info_ID='" + reportidhidden.Value + "'";
                                         
                    DataTable dt = db1.selecttable();
                   
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            hospnamehidden.Value = dt.Rows[i]["HospitalName"].ToString();
                            db1.strCommand = "select * from Product where ProductID='" + dt.Rows[i]["ProductID"].ToString() + "'";
                            DataTable dt_prod = db1.selecttable();
                            if (dt_prod.Rows.Count > 0)
                            {
                                for (int j = 0; j < dt_prod.Rows.Count; j++)
                                {
                                    db1.strCommand = "insert into Prevention(HospitalID,ProductName,Manufacture,Model,DeviceType," +
                                    "DeviceClassi,Supply,Power,Serial_No,BiomedicalID,Location,Description)values" +
                                    "('" + hpid + "','" + dt_prod.Rows[j]["ProductName"].ToString() + "','" + dt_prod.Rows[j]["Company"].ToString() + "'," +
                                    "'" + dt_prod.Rows[j]["Model"].ToString() + "','" + dt_prod.Rows[j]["Device_Type"].ToString() + "'," +
                                    "'" + dt_prod.Rows[j]["Device_Classification"].ToString() + "','" + dt_prod.Rows[j]["Supply"].ToString() + "'," +
                                    "'" + dt_prod.Rows[j]["PowerRating"].ToString() + "','" + dt.Rows[i]["Serial_No"].ToString() + "'," +
                                    "'" + dt.Rows[i]["Biomedical_ID"].ToString() + "','" + dt.Rows[i]["Location"].ToString() + "','" + txtprevent.Text.Replace("'", "''") + "')";
                                    db1.insertqry();

                                    
                                }
                               
                            }

                        }

                        //GridView1.DataSource = dt_result;
                        //GridView1.DataBind();
                    }

                //}

            //}
        }
        else
        {
           
                }
            //}
        //}
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        //PopulateProductdetails();
        GridBind();
    }

   
   
    public void GridBind()
    {
        db1.strCommand = "select * from Prevention order by PreventID desc";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
  
    protected void btncancel_Click(object sender, EventArgs e)
    {
        clear();

    }
    public void clear()
    {
        txtproname.Text = "";
        txtmanu.Text = "";
        txtmodel.Text = "";
        txtdevtype.Text = "";
        txtdevclass.Text = "";
        txtsupply.Text = "";
        txtpower.Text = "";
        txtserial.Text = "";
        txtbiomedical.Text = "";
        txtlocation.Text = "";
        txtprevent.Text = "";
        txtcondofitem.Text = "";
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        btncancel_Click(sender, e);
        GridViewRow gvrow = (GridViewRow)((Button)sender).NamingContainer;
        preventid = Convert.ToInt32(GridView1.DataKeys[gvrow.RowIndex].Value);
        db1.strCommand = "select * from Prevention where PreventID='" + preventid + "'";
        DataTable dt_report = db1.selecttable();
        if (dt_report.Rows.Count > 0)
        {
            txtproname.Text = dt_report.Rows[0]["ProductName"].ToString();
            txtmanu.Text = dt_report.Rows[0]["Manufacture"].ToString();
            txtmodel.Text = dt_report.Rows[0]["Model"].ToString();
            txtdevtype.Text = dt_report.Rows[0]["DeviceType"].ToString();
            txtdevclass.Text = dt_report.Rows[0]["DeviceClassi"].ToString();
            txtsupply.Text = dt_report.Rows[0]["Supply"].ToString();
            txtpower.Text = dt_report.Rows[0]["Power"].ToString();
            txtserial.Text = dt_report.Rows[0]["Serial_No"].ToString();
            txtbiomedical.Text = dt_report.Rows[0]["BiomedicalID"].ToString();
            txtlocation.Text = dt_report.Rows[0]["Location"].ToString();
            //Response.Redirect("ViewReport.aspx?preventid=" + preventid);
        }
    }
    protected void btndelete_Click(object sender, EventArgs e)
    {
        GridViewRow gvrow = (GridViewRow)((Button)sender).NamingContainer;
        preventid = Convert.ToInt32(GridView1.DataKeys[gvrow.RowIndex].Value);
        db1.strCommand = "delete from Prevention where PreventID='" + preventid + "'";
        db1.insertqry();
        GridBind();
    }
}