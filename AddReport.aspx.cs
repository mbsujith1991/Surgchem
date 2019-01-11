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
using System.Data.OleDb;
using System.Configuration;
using Microsoft.VisualBasic.FileIO;


public partial class AddReport : System.Web.UI.Page
{
    Dbclass db1 = new Dbclass();
    string sqlcon = ConfigurationManager.ConnectionStrings["surgchemcon"].ToString();
    ArrayList reportmaxid_arraylist = new ArrayList();
    string[] perfname = { };
    string[] performanceid = { };
    int performanceid_count = 0;
    //string maxelectid = "";
    int perfcount = 0;
    string Productid = "", maxid = "";
    HiddenField editreport_calibstatus = new HiddenField();
    protected void Page_Load(object sender, EventArgs e)
    {

        object usertypeObj = Session["Usertype"];
        if (usertypeObj != null)
        {
            utypeid_hidden.Value = Session["Usertype"].ToString();
        }
        else
        {
            utypeid_hidden.Value = "1";
        }

        txtdateofreceipt.Text = txtdateofcalib.Text;

        HtmlGenericControl listreport = (HtmlGenericControl)this.Master.FindControl("lireport");
        listreport.Style.Add("background-color", "#195A7F");
        if (!IsPostBack)
        {
            string editreport = Request.QueryString["editreport"];
            if (editreport == "1")
            {
                checkboxelectrical.Value = "0";
                checkboxperform.Value = "0";
                if (checkboxelectrical.Value == "0")
                {
                    elect_table.Visible = false;
                }
                if (checkboxperform.Value == "0")
                {
                    perf_table.Visible = false;
                }
                multiviewreport.ActiveViewIndex = 1;
                Bind_EditReportinfo(1, 50);
                btneditreport.Style.Add("background-color", "#195A7F");
                btnaddreport.Style.Add("background-color", "#4892DB");
            }
            else
            {
                checkboxelectrical.Value = "0";
                checkboxperform.Value = "0";
                if (checkboxelectrical.Value == "0")
                {
                    elect_table.Visible = false;
                }
                if (checkboxperform.Value == "0")
                {
                    perf_table.Visible = false;
                }
                chkelctrical.Checked = true;
                chkperform.Checked = true;
                perf_table.Visible = false;
                elect_table.Visible = false;
                MaxidReport_Pageload();
                Bind_ReferenceDate();
                Populate_Environ();
                BindProductName();
                BindHospitalname();
                perfid_hidden.Value = string.Empty;
                ddlmanuf.Items.Insert(0, "--Select Company--");
                ddlmodel.Items.Insert(0, "--Select Model--");
                ddlevicetype.Items.Insert(0, "--Select Device Type");
                ddldeviceclass.Items.Insert(0, "--Select Classification--");
                btnaddreport.Style.Add("background-color", "#195A7F");

            }

        }


    }
    #region functions


    // get ReportNo and Date from Report Info using max ReportId//
    public void MaxidReport_Pageload()
    {
        db1.strCommand = "select max(Report_info_ID) from Report_Info";
        maxid = db1.executescalar();

        db1.strCommand = "select ReportNo,Date_of_calibration,Calibration_Due_on from Report_Info where Report_info_ID='" + maxid + "'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            txtdateofcalib.Text = dt.Rows[0]["Date_of_calibration"].ToString();
            txtduedate.Text = dt.Rows[0]["Calibration_Due_on"].ToString();
            txtdateofreceipt.Text = txtdateofcalib.Text;
            StringBuilder sb_reportno = new StringBuilder();
            string max_reportno = "";
            sb_reportno.Append(dt.Rows[0]["ReportNo"].ToString());
            max_reportno = sb_reportno.ToString();
            if (utypeid_hidden.Value != "5" && utypeid_hidden.Value != "6")
            {
                string[] reportnoarray = max_reportno.Split('/');
                string reportnovalue = reportnoarray[1].ToString();
                int reportno_add = int.Parse(reportnovalue) + 1;
                lblReportNo.Text = "BMT/";
                lblBarcode.Text = "BMT/";
                txtreportno.Text = reportno_add.ToString();
                txtbarcode.Text = reportno_add.ToString();
            }
            else if (utypeid_hidden.Value == "5")
            {
                string[] reportnoarray = max_reportno.Split('/');
                string reportnovalue = reportnoarray[1].ToString();
                int reportno_add = int.Parse(reportnovalue) + 1;
                lblReportNo.Text = "BMT-MTH/";
                lblBarcode.Text = "BMT-MTH/";
                txtreportno.Text = reportno_add.ToString();
                txtbarcode.Text = reportno_add.ToString();
            }
            else if (utypeid_hidden.Value == "6")
            {
                string[] reportnoarray = max_reportno.Split('/');
                string reportnovalue = reportnoarray[1].ToString();
                int reportno_add = int.Parse(reportnovalue) + 1;
                lblReportNo.Text = "BMT-ACH/";
                lblBarcode.Text = "BMT-ACH/";
                txtreportno.Text = reportno_add.ToString();
                txtbarcode.Text = reportno_add.ToString();
            }
        }
    }

    public void Reload_dates()
    {
        db1.strCommand = "select Date_of_calibration,Calibration_Due_on from Report_Info where Report_info_ID='" + editreport_hidden.Value + "'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            txtdateofcalib.Text = dt.Rows[0]["Date_of_calibration"].ToString();
            txtduedate.Text = dt.Rows[0]["Calibration_Due_on"].ToString();
            txtdateofreceipt.Text = txtdateofcalib.Text;
        }
    }

    public void Bind_ReferenceDate()
    {
        db1.strCommand = "select Reference_Date from Customer_Info where Report_info_ID='" + maxid + "'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            txtreferencedate.Text = dt.Rows[0]["Reference_Date"].ToString();
        }
    }

    public void Reload_Referencedate()
    {
        db1.strCommand = "select Reference_Date from Customer_Info where Report_info_ID='" + editreport_hidden.Value + "'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            txtreferencedate.Text = dt.Rows[0]["Reference_Date"].ToString();
        }
    }

    public void Bind_DateofReceipt()
    {
        string calibrationdate = txtdateofcalib.Text;
        DateTime year = Convert.ToDateTime(txtdateofcalib.Text).AddDays(364);

        txtduedate.Text = (year.Date).ToString("dd/MM/yyyy");
        string expdate = txtduedate.Text.Trim().Replace("-", "/");
        txtduedate.Text = expdate;
    }

    //Populate Product details

    public void BindProductName1()
    {
        DataTable dt_result = new DataTable();
        dt_result.Columns.Add("ProductID", typeof(int));
        dt_result.Columns.Add("ProductName", typeof(string));

        db1.strCommand = "select distinct ProductName from Product";
        DataTable dt_proname = db1.selecttable();

        ddlproductname.Items.Clear();
        if (dt_proname.Rows.Count > 0)
        {
            //for(int i=0;i<dt_proname.Rows.Count;i++)
            //{
            //    db1.strCommand = "select ProductID from Product where ProductName='" + dt_proname.Rows[i]["ProductName"].ToString() + "'";
            //    DataTable dt_prodid = db1.selecttable();
            //    if (dt_prodid.Rows.Count > 0)
            //    {
            //        for (int j = 0; j < 1; j++)
            //        {
            //            dt_result.Rows.Add(dt_prodid.Rows[j]["ProductID"].ToString(), dt_proname.Rows[i]["ProductName"].ToString());
            //        }
            //    }
            //}

            foreach (DataRow row in dt_proname.Rows)
            {
                db1.strCommand = "select ProductID from Product where ProductName='" + row["ProductName"] + "'";
                DataTable dt_prodid = db1.selecttable();
                if (dt_prodid.Rows.Count > 0)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        dt_result.Rows.Add(dt_prodid.Rows[j]["ProductID"].ToString(), row["ProductName"]);
                    }
                }
            }

            ddlproductname.DataSource = dt_result;
            ddlproductname.DataTextField = "ProductName";
            ddlproductname.DataValueField = "ProductID";
            ddlproductname.DataBind();
        }
        ddlproductname.Items.Insert(0, "--Select ProductName--");

    }

    public void BindProductName()
    {
        db1.strCommand = "select ProductName from Product group by ProductName order by ProductName Asc";
        DataTable dt_proname = db1.selecttable();

        ddlproductname.Items.Clear();
        if (dt_proname.Rows.Count > 0)
        {
            ddlproductname.DataSource = dt_proname;
            ddlproductname.DataTextField = "ProductName";
            ddlproductname.DataValueField = "ProductName";
            ddlproductname.DataBind();
        }
        ddlproductname.Items.Insert(0, "--Select ProductName--");
    }


    public void BindCompany()
    {
        //db1.strCommand = "select distinct Company from Product where ProductName='" + ddlproductname.SelectedItem.Text + "' ";
        db1.strCommand = "select Company from Product where ProductName like '%" + ddlproductname.SelectedItem.Text + "%' group by Company";
        DataTable dt = db1.selecttable();
        ddlmanuf.Items.Clear();

        if (dt.Rows.Count > 0)
        {
            ddlmanuf.DataSource = dt;
            ddlmanuf.DataTextField = "Company";
            ddlmanuf.DataValueField = "Company";
            ddlmanuf.DataBind();
        }
        ddlmanuf.Items.Insert(0, "--Select Company--");
    }

    public void BindModel()
    {

        //db1.strCommand = "select distinct Model from Product where ProductName='" + ddlproductname.SelectedItem.Text + "' and Company like '%" + ddlmanuf.SelectedValue.ToString() + "%'";
        db1.strCommand = "select Model from Product where ProductName like '%" + ddlproductname.SelectedItem.Text + "%' and Company like '%" + ddlmanuf.SelectedValue.ToString() + "%'";
        DataTable dt1 = db1.selecttable();
        ddlmodel.Items.Clear();
        if (dt1.Rows.Count > 0)
        {
            ddlmodel.DataSource = dt1;
            ddlmodel.DataTextField = "Model";
            ddlmodel.DataValueField = "Model";
            ddlmodel.DataBind();
        }
        ddlmodel.Items.Insert(0, "--Select Model--");
    }

    public void BindDeviceType()
    {

        db1.strCommand = "select distinct Device_Type from Product where  ProductName like '%" + ddlproductname.SelectedItem.Text + "%' and Company like '%" + ddlmanuf.SelectedValue.ToString() + "%'" +
            "and Model='" + ddlmodel.SelectedValue.ToString() + "'";
        DataTable dt2 = db1.selecttable();
        ddlevicetype.Items.Clear();
        if (dt2.Rows.Count > 0)
        {
            ddlevicetype.DataSource = dt2;
            ddlevicetype.DataTextField = "Device_Type";
            ddlevicetype.DataValueField = "Device_Type";
            ddlevicetype.DataBind();
        }
        //ddlevicetype.Items.Insert(0, "--Select Device Type");
    }

    public void BindDeviceClassi()
    {
        db1.strCommand = "select distinct Device_Classification from Product where ProductName like '%" + ddlproductname.SelectedItem.Text + "%' and Company like '%" + ddlmanuf.SelectedValue.ToString() + "%'" +
        "and Model='" + ddlmodel.SelectedValue.ToString() + "'";
        DataTable dt3 = db1.selecttable();
        ddldeviceclass.Items.Clear();
        if (dt3.Rows.Count > 0)
        {
            ddldeviceclass.DataSource = dt3;
            ddldeviceclass.DataTextField = "Device_Classification";
            ddldeviceclass.DataValueField = "Device_Classification";
            ddldeviceclass.DataBind();
        }
        // ddldeviceclass.Items.Insert(0, "--Select Classification--");
    }


    public void Bindtraceid()
    {
        DataTable dt_result = new DataTable();
        DataTable dt_Productname = new DataTable();
        lsttrace.Items.Clear();
        string perfid = "", tracename_hidden = "";
        string[] perfidarray = { };
        StringBuilder sb_perfid = new StringBuilder();
        dt_result.Columns.Add("Tracibility_ID", typeof(int));
        dt_result.Columns.Add("Instrument", typeof(string));

        db1.strCommand = "select distinct Tracibility_ID from Product where ProductName like '" + ddlproductname.SelectedItem.Text + "%'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                sb_perfid.Append(dt.Rows[i]["Tracibility_ID"].ToString());
                perfid = sb_perfid.ToString();
                perfidarray = perfid.Split(',');
                if (perfidarray.Count() > 0)
                {
                    for (int j = 0; j < perfidarray.Count() - 1; j++)
                    {
                        db1.strCommand = "select Instrument from Traceability_Info where Tracibility_ID='" + perfidarray[j] + "'";
                        DataTable dt_perfname = db1.selecttable();
                        if (dt_perfname.Rows.Count > 0)
                        {
                            tracename_hidden = dt_perfname.Rows[0]["Instrument"].ToString();
                            dt_result.Rows.Add(perfidarray[j], tracename_hidden);
                        }
                    }
                }

                tracename_hidden = "";
                sb_perfid.Clear();
            }

        }
        lsttrace.DataSource = dt_result;
        lsttrace.DataTextField = "Instrument";
        lsttrace.DataValueField = "Tracibility_ID";
        lsttrace.DataBind();
        lsttrace.Items.Insert(0, "--Select--");


    }

    public void BindPerfid()
    {
        DataTable dt_Productname = new DataTable();
        DataTable dt_result = new DataTable();
        string perfid = "", perfname_hidden = "";
        string[] perfidarray = { };
        StringBuilder sb_perfid = new StringBuilder();
        dt_result.Columns.Add("PerfID", typeof(string));
        dt_result.Columns.Add("Perf_TestName", typeof(string));
        ddlperformance.Items.Clear();
        db1.strCommand = "select distinct PerfID from Product where ProductName like '" + ddlproductname.SelectedItem.Text + "%'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                sb_perfid.Append(dt.Rows[i]["PerfID"].ToString());
                perfid = sb_perfid.ToString();
                perfidarray = perfid.Split(',');
                if (perfidarray.Count() > 0)
                {
                    for (int j = 0; j < perfidarray.Count() - 1; j++)
                    {
                        db1.strCommand = "select Perf_TestName from PerformanceTest where PerfID='" + perfidarray[j] + "'";
                        DataTable dt_perfname = db1.selecttable();
                        if (dt_perfname.Rows.Count > 0)
                        {
                            perfname_hidden = dt_perfname.Rows[0]["Perf_TestName"].ToString();
                            dt_result.Rows.Add(perfidarray[j], perfname_hidden);
                        }
                    }
                }

                perfname_hidden = "";
                sb_perfid.Clear();
            }

        }
        ddlperformance.DataSource = dt_result;
        ddlperformance.DataTextField = "Perf_TestName";
        ddlperformance.DataValueField = "PerfID";
        ddlperformance.DataBind();
        ddlperformance.Items.Insert(0, "--Select Performance Test--");
    }

    public void BindRemarks()
    {
        db1.strCommand = "select Remarks from Product where ProductName like '" + ddlproductname.SelectedItem.Text + "%'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            txtremarks.Text = dt.Rows[0]["Remarks"].ToString();
        }
    }
    public void Bind_Supply_Power()
    {
        db1.strCommand = "select Supply,PowerRating from Product where ProductName like '" + ddlproductname.SelectedItem.Text + "%' and" +
            " Company like '" + ddlmanuf.SelectedValue + "%' and Model like '" + ddlmodel.SelectedValue + "%'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            txtsupply.Text = dt.Rows[0]["Supply"].ToString();
            txtpower.Text = dt.Rows[0]["PowerRating"].ToString();
        }
    }

    public void Populate_ProductID()
    {
        db1.strCommand = "select ProductID from Product where ProductName ='" + ddlproductname.SelectedItem.Text + "' and" +
            " Company ='" + ddlmanuf.SelectedValue + "' and Model ='" + ddlmodel.SelectedValue + "' and " +
            " Device_Type ='" + ddlevicetype.SelectedValue + "' and Device_Classification ='" + ddldeviceclass.SelectedValue + "'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            productidhidden.Value = dt.Rows[0]["ProductID"].ToString();
        }
    }

    public void Populate_Environ()
    {
        db1.strCommand = "select top 1 * from Environ_condition order by ECM_ID desc";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            txttemperature.Text = dt.Rows[0]["Temperature"].ToString();
            txtrelative.Text = dt.Rows[0]["Relative_Humidity"].ToString();
            txtambient.Text = dt.Rows[0]["Ambient_Barometric_measure"].ToString();
            ecmidhidden.Value = dt.Rows[0]["ECM_ID"].ToString();
        }
    }

    public void updateEnviron()
    {
        db1.strCommand = "update Environ_condition set Temperature='" + txttemperature.Text.Trim().Replace("'", "''") + "'," +
            "Relative_Humidity='" + txtrelative.Text.Trim().Replace("'", "''") + "',Ambient_Barometric_measure='" + txtambient.Text.Trim().Replace("'", "''") + "' where ECM_ID='" + ecmidhidden.Value + "'";
        db1.insertqry();
    }



    public void AddTraceidtoreport()
    {
        foreach (ListItem li in lsttrace.Items)
        {
            if (li.Selected)
            {
                lblValues.Text += li.Value + ",";
                traceid_hidden.Value += li.Text + ",";
            }
        }

    }
    //Populate Dropdownlist of Performance test and get the PerfId as DataValuefiled.
    public void Bindperformancetest()
    {
        db1.strCommand = "select PerfID,Perf_TestName from PerformanceTest where Perf_TestName is not null";
        DataTable dt = db1.selecttable();
        ddlperformance.Items.Clear();
        if (dt.Rows.Count > 0)
        {
            ddlperformance.DataSource = dt;
            ddlperformance.DataTextField = "Perf_TestName";
            ddlperformance.DataValueField = "PerfID";
            ddlperformance.DataBind();
        }
        ddlperformance.Items.Insert(0, "--Select Performance Test--");

    }


    //Populate Hospital Name to Dropdownlist and get HospitalID as datavalue field to Customer_info table
    public void BindHospitalname()
    {
        db1.strCommand = "select HospitalID,HospitalName from Hospital";
        DataTable dt = db1.selecttable();
        ddhospitalname.Items.Clear();
        if (dt.Rows.Count > 0)
        {
            ddhospitalname.DataSource = dt;
            ddhospitalname.DataTextField = "HospitalName";
            ddhospitalname.DataValueField = "HospitalID";
            ddhospitalname.DataBind();
        }
        ddhospitalname.Items.Insert(0, "--Select Hospital Name--");
        hospitalid_hidden.Value = dt.ToString();
    }
    //Populate Hospital Name to Dropdownlist and get HospitalID as datavalue field to Customer_info table
    public void BindHospitalAddress()
    {
        db1.strCommand = "select Address from Hospital where HospitalID='" + ddhospitalname.SelectedValue + "'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            txtaddress.Text = dt.Rows[0]["Address"].ToString();
        }

    }
    //Get the Electrical safety ID to add to the Report info table.
    public void populate_Electid()
    {
        db1.strCommand = "select max(ElectID) from ElectricalSafety";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            elect_hidden.Value = dt.Rows[0][0].ToString();

        }
    }


    public void Retreive_ProdID()
    {
        db1.strCommand = "select max(ProductID) from Prod_in_Report ";
        Productid = db1.executescalar();

    }

    public DataTable GetReportData(int startIndex, int maxRows)
    {
        db1.strCommand =
                "WITH ReportData AS \n" +
                "( \n" +
                "select report.Report_info_ID, report.ReportNo,report.Date_of_Calibration,report.Calibration_Due_on,hospital.HospitalName,\n" +
                "ecm.Temperature,ecm.Ambient_Barometric_measure, ecm.Relative_Humidity, dut.Biomedical_ID, dut.Serial_No,\n" +
                "product.ProductName,ROW_NUMBER() OVER(ORDER BY report.Report_info_ID desc) AS RowRank from Report_Info report \n" +
                "inner join Hospital hospital on report.HospitalID = hospital.HospitalID \n" +
                "inner join Environ_condition ecm on report.ECM_ID = ecm.ECM_ID \n" +
                "inner join DUT_info dut on report.Report_info_ID = dut.Report_info_ID \n" +
                "inner join Product product on report.ProductID = product.ProductID \n" +
                ") \n" +
                "select Report_info_ID,ReportNo, Date_of_Calibration, Calibration_Due_on, HospitalName, Temperature,\n" +
                "Ambient_Barometric_measure, Relative_Humidity, Biomedical_ID, Serial_No, ProductName,\n" +
                "RowRank from ReportData \n" +
                "WHERE RowRank BETWEEN(" + startIndex + " - 1) * " + maxRows + "+" + "1 AND(((" + startIndex + " - 1) * " + maxRows + " + 1) + " + maxRows + ") - 1";
        var reportData = db1.selecttable();
        return reportData;
    }

    public int TotalReportCount()
    {
        db1.strCommand = "Select Count(*) From Report_Info";
        var result = db1.executescalar();
        int totalCount = 0;
        if (!string.IsNullOrEmpty(result))
        {
            totalCount = Convert.ToInt32(result);
        }
        return totalCount;
    }

    private void PopulatePager(int recordCount, int currentPage, int maxRows)
    {
        double dblPageCount = (double)((decimal)recordCount / maxRows);
        int pageCount = (int)Math.Ceiling(dblPageCount);
        List<ListItem> pages = new List<ListItem>();
        if (pageCount > 0)
        {
            int showMax = 10;
            int startPage;
            int endPage;
            if (pageCount <= showMax)
            {
                startPage = 1;
                endPage = pageCount;
            }
            else
            {
                startPage = currentPage;
                endPage = currentPage + showMax - 1;
            }

            pages.Add(new ListItem("First", "1", currentPage > 1));

            for (int i = startPage; i <= endPage; i++)
            {
                pages.Add(new ListItem(i.ToString(), i.ToString(), i != currentPage));
            }

            pages.Add(new ListItem("Last", pageCount.ToString(), currentPage < pageCount));
        }
        rptPager.DataSource = pages;
        rptPager.DataBind();
    }

    public void Bind_EditReportinfo(int pageIndex, int maxRows)
    {
        var reportData = GetReportData(pageIndex, maxRows);
        if (reportData == null)
        {
            reportData = new DataTable();
        }
        rptPager.Visible = true;
        GridView1.DataSource = reportData;
        GridView1.DataBind();
        int totalReportResult = TotalReportCount();
        this.PopulatePager(totalReportResult, pageIndex, maxRows);
    }

    protected void Page_Changed(object sender, EventArgs e)
    {
        int pageIndex = int.Parse((sender as LinkButton).CommandArgument);
        Bind_EditReportinfo(pageIndex, 50);
    }

    //Insert query for Report_Info table
    public void InsertReportinfo()
    {
        perfid_hidden.Value = perfidtesthidden.Value;
        if (ch_elect.Checked == true && ch_perf.Checked == false)
        {

            db1.strCommand = "insert into Report_Info(ReportNo,Date_of_calibration,Calibration_Due_on,ElectID,Barcode_ID," +
                "ProductID,ECM_ID,Tracibility_ID,HospitalID,Remarks,PerfID) values('"
                + lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''")
                + "','" + txtdateofcalib.Text.Trim().Replace("'", "''") + "','" + txtduedate.Text.Trim().Replace("'", "''") + "','"
                + maxelectid.Value + "','" + lblBarcode.Text + txtbarcode.Text.Trim().Replace("'", "''") + "','" + productidhidden.Value + "'," +
                "'" + ecmidhidden.Value + "','" + lblValues.Text + "','" + ddhospitalname.SelectedValue + "','" + txtremarks.Text.Trim().Replace("'", "''") + "'," +
            "'" + perfid_hidden.Value + "')";
            db1.insertqry();
        }
        else if (ch_perf.Checked == true && ch_elect.Checked == false)
        {
            db1.strCommand = "insert into Report_Info(ReportNo,Date_of_calibration,Calibration_Due_on,PerfID,Barcode_ID,ProductID," +
                "ECM_ID,Tracibility_ID,HospitalID,Remarks,ElectID) values('"
                + lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''") + "','"
                + txtdateofcalib.Text.Trim().Replace("'", "''") + "','"
                + txtduedate.Text.Trim().Replace("'", "''") + "','"
                + perfid_hidden.Value + "','" + lblBarcode.Text + txtbarcode.Text.Trim().Replace("'", "''") + "','" + productidhidden.Value + "'," +
                "'" + ecmidhidden.Value + "','" + lblValues.Text + "','" + ddhospitalname.SelectedValue + "'," +
            "'" + txtremarks.Text.Trim().Replace("'", "''") + "','" + maxelectid.Value + "')";
            db1.insertqry();
        }
        else if (ch_elect.Checked == true && ch_perf.Checked == true)
        {
            db1.strCommand = "insert into Report_Info(ReportNo,Date_of_calibration,Calibration_Due_on,PerfID,ElectID,Barcode_ID," +
                "ProductID,ECM_ID,Tracibility_ID,HospitalID,Remarks) values('"
                + lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''") + "','"
                + txtdateofcalib.Text.Trim().Replace("'", "''") + "','"
                + txtduedate.Text.Trim().Replace("'", "''") + "','"
                + perfid_hidden.Value + "','" + maxelectid.Value + "','" + lblBarcode.Text + txtbarcode.Text.Trim().Replace("'", "''") + "'," +
                "'" + productidhidden.Value + "','" + ecmidhidden.Value + "','" + lblValues.Text + "','" + ddhospitalname.SelectedValue + "'," +
            "'" + txtremarks.Text.Trim().Replace("'", "''") + "')";
            db1.insertqry();
        }
        else if (ch_elect.Checked == false && ch_perf.Checked == false)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Please select Performance analysis/Electrical safety !');", true);

        }

    }

    //Insert query for Customer_Info table
    public void Customerinfo()
    {
        db1.strCommand = "insert into Customer_Info(HospitalID,Reference_Date,Date_Receipt,Report_info_ID) values('"
            + ddhospitalname.SelectedValue + "','"
            + txtreferencedate.Text.Trim().Replace("'", "''") + "','"
            + txtdateofreceipt.Text.Trim().Replace("'", "''") + "','" + reportid_hidden.Value + "')";
        db1.insertqry();
    }

    //get the Report_info Id for adding to other tables.
    public void select_Reportinfo()
    {
        db1.strCommand = "select Report_info_ID from Report_Info where ReportNo='" + lblReportNo.Text + txtreportno.Text.Trim() + "'";
        reportid_hidden.Value = db1.executescalar().ToString();
        int maxidaddone = Convert.ToInt32(db1.executescalar());
        reportidmax_hidden.Value = (maxidaddone + 1).ToString();
    }

    //insert query for Environmental condition table.
    public void Environmentalcondition()
    {
        db1.strCommand = "insert into Environ_condition(Report_info_ID,Temperature,Relative_Humidity,Ambient_Barometric_measure) values('"
            + reportid_hidden.Value + "','" + txttemperature.Text.Trim().Replace("'", "''") + "','"
            + txtrelative.Text.Trim().Replace("'", "''") + "','"
            + txtambient.Text.Trim().Replace("'", "''") + "')";
        db1.insertqry();
    }



    //insert query for DUT info table.
    public void DUT_info()
    {
        bool electrical_value = false;
        bool performance_value = false;
        if (ch_elect.Checked == true)
        {
            electrical_value = true;
        }
        else
        {
            electrical_value = false;
        }
        if (ch_perf.Checked == true)
        {
            performance_value = true;
        }
        else
        {
            performance_value = false;
        }
        db1.strCommand = "insert into DUT_info(Report_info_ID,Serial_No,Biomedical_ID,Location,Condition_of_item,ElectricalSafety,Performance) values('"
            + reportid_hidden.Value + "','"
            + txtserialno.Text.Trim().Replace("'", "''") + "','"
            + txtbiomedical.Text.Trim().Replace("'", "''") + "','"

            + txtlocation.Text.Trim().Replace("'", "''") + "','"
            + ddlcondition.SelectedValue + "','"
            + electrical_value + "','" + performance_value + "')";
        db1.insertqry();
    }


    public void calibrationstatus()
    {
        bool manuspeci = false;
        bool userspeci = false;
        bool withinspeci = false;
        bool outofspeci = false;
        bool calibrationspeci = false;
        bool electricalspeci = false;
        bool performspeci = false;

        if (chkmanu.Checked == true)
        {
            editreport_calibstatus.Value += chkmanu.Text + ",";
            manuspeci = true;
        }
        else
            manuspeci = false;
        if (chkuser.Checked == true)
        {
            userspeci = true;
            editreport_calibstatus.Value += chkuser.Text + ",";
        }
        else
            userspeci = false;
        if (chkwithin.Checked == true)
        {
            withinspeci = true;
            editreport_calibstatus.Value += chkwithin.Text + ",";
        }
        else
            withinspeci = false;
        if (chkout.Checked == true)
        {
            outofspeci = true;
            editreport_calibstatus.Value += chkout.Text + ",";
        }
        else
            outofspeci = false;
        if (chkcalib.Checked == true)
        {
            calibrationspeci = true;
            editreport_calibstatus.Value += chkcalib.Text + ",";
        }
        else
            calibrationspeci = false;
        if (chkelctrical.Checked == true)
        {
            electricalspeci = true;
            editreport_calibstatus.Value += chkelctrical.Text + ",";
        }
        else
            electricalspeci = false;
        if (chkperform.Checked == true)
        {
            performspeci = true;
            editreport_calibstatus.Value += chkperform.Text;
        }
        else
            performspeci = false;

        calibstatus_hidden.Value = editreport_calibstatus.Value;
        db1.strCommand = "insert into Calibration_Status(Report_info_ID,Manu_Specifi,User_Specifi,within_specifi,outof_specifi,calibration,Electrical_safety,Performance_analysis)values('"
            + reportid_hidden.Value + "','" + manuspeci + "','" + userspeci + "','" + withinspeci + "','"
            + outofspeci + "','" + calibrationspeci + "','" + electricalspeci + "','" + performspeci + "')";
        db1.insertqry();

    }


    public void Insert_Electricalsafety()
    {
        db1.strCommand = "insert into ElectricalSafety(Standard,Applicable_Spec) values('" + txtstandard.Text + "','" + txt_applicablespeci.Text.Trim() + "')";
        db1.insertqry();

        //Retrieve Max(Reportud for inserting it in to Excel values)

        db1.strCommand = "select max(ElectID) from ElectricalSafety";
        maxelectid.Value = db1.executescalar();
    }
    public void fileupload()
    {
        Insert_Electricalsafety();
        try
        {

            string savefolder = Server.MapPath("~/Upload/");
            string filepath = System.IO.Path.Combine(savefolder, elctrical_upload.FileName);
            elctrical_upload.SaveAs(filepath);
            string extension = System.IO.Path.GetExtension(elctrical_upload.FileName);
            if (extension == ".xlsx")
            {
                String excelConnString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0\"", filepath);
                //Create Connection to Excel work book 
                using (OleDbConnection excelConnection = new OleDbConnection(excelConnString))
                {
                    excelConnection.Open();
                    DataTable dt = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    String[] excelSheets = new String[dt.Rows.Count];
                    int i = 0;

                    // Add the sheet name to the string array.
                    foreach (DataRow row in dt.Rows)
                    {
                        excelSheets[i] = row["TABLE_NAME"].ToString();
                        i++;
                    }
                    string sheet = "Sheet1$";
                    //Create OleDbCommand to fetch data from Excel 
                    using (OleDbCommand cmd = new OleDbCommand("Select [TestName],[Partsconnected],[Value],[HighLimits],[Status] from [" + sheet + "]", excelConnection))
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        DataTable dtExcel = new DataTable();
                        da.Fill(dtExcel);
                        using (SqlBulkCopy sqlBulk = new SqlBulkCopy(sqlcon))
                        {
                            //Give your Destination table name 
                            sqlBulk.DestinationTableName = "ElectricalSafety";
                            sqlBulk.WriteToServer(dtExcel);
                        }
                        lblError.Text = "Uploaded successfully";
                        lblError.ForeColor = System.Drawing.Color.Green;

                    }
                }
            }
            else if (extension == ".csv")
            {
                string csv_file_path = filepath;// @"C:\Users\KlickEvents\Desktop\EPG for XML\asianet.csv";
                DataTable csvData = GetDataTabletFromCSVFile(csv_file_path);

                InsertDataIntoSQLServerUsingSQLBulkCopy(csvData);

                lblError.Text = "Uploaded successfully";
                lblError.ForeColor = System.Drawing.Color.Green;
            }
            else lblError.Text = "Invalid file format! Please upload .csv or .xlsx file";

        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }

    }

    private static DataTable GetDataTabletFromCSVFile(string csv_file_path)
    {
        DataTable csvData = new DataTable();
        try
        {
            using (TextFieldParser csvReader = new TextFieldParser(csv_file_path))
            {
                csvReader.SetDelimiters(new string[] { "," });
                csvReader.HasFieldsEnclosedInQuotes = true;
                string[] colFields = csvReader.ReadFields();
                foreach (string column in colFields)
                {
                    DataColumn datecolumn = new DataColumn(column);
                    datecolumn.AllowDBNull = true;
                    csvData.Columns.Add(datecolumn);
                }
                while (!csvReader.EndOfData)
                {
                    string[] fieldData = csvReader.ReadFields();
                    //Making empty value as null
                    for (int i = 0; i < fieldData.Length; i++)
                    {
                        if (fieldData[i] == "")
                        {
                            fieldData[i] = null;
                        }
                    }
                    csvData.Rows.Add(fieldData);
                }
            }
        }
        catch (Exception ex)
        {
        }
        return csvData;
    }
    // Copy the DataTable to SQL Server using SqlBulkCopy
    public void InsertDataIntoSQLServerUsingSQLBulkCopy(DataTable csvFileData)
    {
        using (SqlConnection dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["surgchemcon"].ConnectionString))
        {
            //csvFileData.Columns.Add(new DataColumn("@ColumnName", typeof(string), string.Format("'{0}'", "Asianet")));
            csvFileData.Columns.Add(new DataColumn("@ColumnName", typeof(string), string.Format("'{0}'", maxelectid.Value)));

            dbConnection.Open();
            using (SqlBulkCopy s = new SqlBulkCopy(dbConnection))
            {
                s.DestinationTableName = "ElectValues";
                //[SlNo],[IST],[GMT],[EPOCH],[Duration],[Title],[HTTP],[HLS],[Thumbnail Image]
                //foreach (var column in csvFileData.Columns)
                //    s.ColumnMappings.Add(column.ToString(), column.ToString());
                s.ColumnMappings.Add("SlNo", "SlNo");
                s.ColumnMappings.Add("TestName", "TestName");
                s.ColumnMappings.Add("Partsconnected", "Partsconnected");
                s.ColumnMappings.Add("Value", "Value");
                s.ColumnMappings.Add("HighLimits", "HighLimits");
                s.ColumnMappings.Add("Status", "Status");
                s.ColumnMappings.Add("@ColumnName", "ElectID");


                s.WriteToServer(csvFileData);
            }
        }
    }




    // This function used to update the tracebility table based on the Report id.
    public void Populate_Traceabilityinfo()
    {
        reportidmax_hidden.Value = Session["traceid"].ToString();
        StringBuilder traceid = new StringBuilder();
        traceid.Append(reportidmax_hidden.Value);
        string trid = traceid.ToString();
        string[] id = trid.Split();
        int count = id.Count();
        for (int i = 0; i < count; i++)
        {
            db1.strCommand = "select * from Traceability_Info where Tracibility_ID='" + id[i] + "'";
            DataTable dt = db1.selecttable();
            if (dt.Rows.Count > 0)
            {
                db1.strCommand = "update Traceability_Info set Report_info_ID='" + reportid_hidden.Value + "',Instrument='"
                    + dt.Rows[0]["Instrument"].ToString() + "',Make='" + dt.Rows[0]["Make"].ToString() + "',Model='"
                    + dt.Rows[0]["Model"].ToString() + "',Serial_No='" + dt.Rows[0]["Serial_No"].ToString() + "',Traceability_call_due='"
                    + dt.Rows[0]["Traceability_call_due"].ToString() + "',Reference='" + dt.Rows[0]["Reference"].ToString() + "' where Tracibility_ID=" + id[i];
                db1.insertqry();
            }
        }
    }



    public void Delete_check_perftest()
    {
        db1.strCommand = "delete from check_perftest";
        db1.insertqry();
    }
    public void populate_perfname()
    {
        db1.strCommand = "select Perf_TestName from Report_Info where Report_info_ID=" + reportid_hidden.Value;
        DataTable dt = db1.selecttable();
        StringBuilder sb = new StringBuilder();

        if (dt.Rows.Count > 0)
        {
            sb.Append(dt.Rows[0]["Perf_TestName"].ToString());
            string s1 = sb.ToString();

            //perfname array contains the No of performances in a report 
            perfname = s1.Split(',');
            perfcount = perfname.Count();

        }
    }

    public void bindperfid()
    {
        StringBuilder sb = new StringBuilder();
        string s1 = "";

        db1.strCommand = "select PerfID from Report_Info where Report_info_ID='" + reportid_hidden.Value + "'";

        DataTable dt = db1.selecttable();

        if (dt.Rows.Count > 0)
        {
            sb.Append(dt.Rows[0]["PerfID"].ToString() + " ");

        }

        s1 = sb.ToString();
        performanceid = s1.Split(',');
        performanceid_count = performanceid.Count();
    }

    //Bind Report_info_ID to Performance Values//
    public void Update_Reportinfoid_PerfValues()
    {
        db1.strCommand = "Update Performance_Values set Report_info_ID='" + reportid_hidden.Value + "' where ReportNo='" + lblReportNo.Text + txtreportno.Text.Trim() + "'";
        db1.insertqry();
    }

    public void add_Reportinfoto_perfvaluesplit()
    {
        string reportno = "";
        db1.strCommand = "Select Report_info_ID from Report_Info where ReportNo='" + lblReportNo.Text + txtreportno.Text.Trim() + "'";
        DataTable dt_reportno = db1.selecttable();
        if (dt_reportno.Rows.Count > 0)
        {
            reportno = dt_reportno.Rows[0]["Report_info_ID"].ToString();
        }
        db1.strCommand = "select * from perfvaluesplit where ReportNo='" + lblReportNo.Text + txtreportno.Text.Trim() + "'";
        DataTable dt_perfvalue = db1.selecttable();
        if (dt_perfvalue.Rows.Count > 0)
        {
            for (int i = 0; i < dt_perfvalue.Rows.Count; i++)
            {
                db1.strCommand = "update Performance_Values set " +
                    "Report_info_ID='" + reportno + "' where ValueID='" + dt_perfvalue.Rows[i]["ValueID"].ToString() + "'";
                db1.insertqry();
            }
        }
    }

    public void Update_ReportInfoID_PerfValues()
    {
        db1.strCommand = "Update Performance_Values set Report_info_ID='" + editreport_hidden.Value + "' where ReportNo='" + lblReportNo.Text + txtreportno.Text.Trim() + "'";
        db1.insertqry();
    }

    //this code not using
    public void Update_addreportinfo_perfvaluesplit()
    {
        db1.strCommand = "select * from perfvaluesplit where ReportNo='" + lblReportNo.Text + txtreportno.Text.Trim() + "'";
        DataTable dt_perfvalue = db1.selecttable();
        if (dt_perfvalue.Rows.Count > 0)
        {
            for (int i = 0; i < dt_perfvalue.Rows.Count; i++)
            {
                db1.strCommand = "update Performance_Values set " +
                    "Report_info_ID='" + editreport_hidden.Value + "' where ValueID='" + dt_perfvalue.Rows[i]["ValueID"].ToString() + "'";
                db1.insertqry();
            }
        }
    }

    public void Delete_perfvaluesplit()
    {
        db1.strCommand = "delete from perfvaluesplit where ReportNo='" + lblReportNo.Text + txtreportno.Text.Trim() + "'";
        db1.insertqry();
    }
    public void BindValue()
    {
        for (int k = 0; k < performanceid_count - 1; k++)
        {
            db1.strCommand = "select * from Performance_Values pv inner join Report_Info ri " +
            "on ri.PerfID=pv.PerfID where pv.PerfID='" + performanceid[k].ToString() + "' and ri.Report_info_ID='" + reportid_hidden.Value + "'";
            DataTable dt = db1.selecttable();
            int count = dt.Rows.Count;
            StringBuilder sb = new StringBuilder();
            StringBuilder sbid = new StringBuilder();
            string val = "", valid = ""; ;
            string[] value = { }, valueid = { };
            string[] splitarray = { };
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < count; i++)
                {

                    sb.Append(dt.Rows[i]["Perf_Value"].ToString() + " ");
                    sbid.Append(dt.Rows[i]["ValueID"].ToString() + " ");
                }


                val = sb.ToString();
                valid = sbid.ToString();
                value = val.Split();
                valueid = valid.Split();
                int validcount = valueid.Count();
                int valcount = value.Count();
                for (int i = 0; i < valcount - 1; i++)
                {
                    if (i == 0)
                    {
                        string value_1 = value[i].ToString();
                        string valueid_1 = valueid[i].ToString();
                        string[] value_1array = value_1.Split(',');
                        int valid_1count = value_1array.Count();
                        for (int j = 0; j < valid_1count - 1; j++)
                        {
                            db1.strCommand = "insert into perfvaluesplit(splitvalues,ValueID)values('" + value_1array[j].ToString() + "','" + valueid_1 + "')";
                            db1.insertqry();
                        }
                    }
                    if (i == 1)
                    {
                        string value_2 = value[i].ToString();
                        string valueid_2 = valueid[i].ToString();
                        string[] value_2array = value_2.Split(',');
                        int valid_2count = value_2array.Count();
                        for (int j = 0; j < valid_2count - 1; j++)
                        {
                            db1.strCommand = "insert into perfvaluesplit(splitvalues,ValueID)values('" + value_2array[j].ToString() + "','" + valueid_2 + "')";
                            db1.insertqry();
                        }
                    }
                    if (i == 2)
                    {
                        string value_3 = value[i].ToString();
                        string valueid_3 = valueid[i].ToString();
                        string[] value_3array = value_3.Split(',');
                        int valid_3count = value_3array.Count();
                        for (int j = 0; j < valid_3count - 1; j++)
                        {
                            db1.strCommand = "insert into perfvaluesplit(splitvalues,ValueID)values('" + value_3array[j].ToString() + "','" + valueid_3 + "')";
                            db1.insertqry();
                        }
                    }
                    if (i == 3)
                    {
                        string value_4 = value[i].ToString();
                        string valueid_4 = valueid[i].ToString();
                        string[] value_4array = value_4.Split(',');
                        int valid_4count = value_4array.Count();
                        for (int j = 0; j < valid_4count - 1; j++)
                        {
                            db1.strCommand = "insert into perfvaluesplit(splitvalues,ValueID)values('" + value_4array[j].ToString() + "','" + valueid_4 + "')";
                            db1.insertqry();
                        }
                    }
                    if (i == 4)
                    {
                        string value_5 = value[i].ToString();
                        string valueid_5 = valueid[i].ToString();
                        string[] value_5array = value_5.Split(',');
                        int valid_5count = value_5array.Count();
                        for (int j = 0; j < valid_5count - 1; j++)
                        {
                            db1.strCommand = "insert into perfvaluesplit(splitvalues,ValueID)values('" + value_5array[j].ToString() + "','" + valueid_5 + "')";
                            db1.insertqry();
                        }
                    }

                }
            }
        }
    }

    public void Reportno_increment()
    {
        db1.strCommand = "select max(Report_info_ID) from Report_Info";
        string reportid = db1.executescalar();
        if (reportid != "")
        {

            txtreportno.Text = (Convert.ToInt32(reportid) + 1).ToString();
            txtbarcode.Text = (Convert.ToInt32(reportid) + 1).ToString();
        }
        else
        {
            txtbarcode.Text = "1";
            txtreportno.Text = "1";
        }
    }


    #endregion


    protected void btnupload_Click(object sender, EventArgs e)
    {
        if (elctrical_upload.HasFile)
        {
            fileupload();
            btnupload.Focus();
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Please select the CSV file to upload !');", true);

        }

    }
    protected void btnsavereport_Click(object sender, EventArgs e)
    {
        if (btnsavereport.Text == "Save Report")
        {
            editreport_hidden.Value = "";
            try
            {
                db1.strCommand = "select ReportNo from Report_Info where ReportNo='" + lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''") + "'";
                DataTable dt_reptno = db1.selecttable();
                if (dt_reptno.Rows.Count <= 0)
                {

                    if (lsttrace.SelectedIndex > 0)
                    {
                        updateEnviron();
                        Populate_ProductID();
                        AddTraceidtoreport();
                        InsertReportinfo();
                        select_Reportinfo();
                        Customerinfo();
                        DUT_info();
                        calibrationstatus();
                        Delete_check_perftest();
                        //add_Reportinfoto_perfvaluesplit();
                        Update_Reportinfoid_PerfValues();
                        Response.Redirect("EditReport.aspx?ReportNoid='" + lblReportNo.Text + txtreportno.Text.Trim() + "'");
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Please Select Traceability Details !');", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Report No already exists !');", true);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Some Error Occured !');", true);

            }
        }
        else if (btnsavereport.Text == "Update Report")
        {
            try
            {
                if (lsttrace.SelectedIndex > 0)
                {
                    //Bind_check_perftest();
                    updateEnviron();
                    Populate_ProductID();
                    AddTraceidtoreport();
                    //Retreive_ProdID();
                    //populate_Electid();
                    Update_Reportinfo();
                    Update_CustomerInfo();
                    Update_Dut_Info();
                    Update_Calibrationstatus();
                    Delete_check_perftest();
                    Update_ReportInfoID_PerfValues();
                    //Update_addreportinfo_perfvaluesplit();
                    //Delete_perfvaluesplit();
                    Response.Redirect("EditReport.aspx?ReportNoid='" + lblBarcode.Text + txtbarcode.Text.Trim().Replace("'", "''") + "'");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Please Select Traceability Details !');", true);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Some Error Occured !');", true);
            }

        }


    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        string pagereload = Page.Request.Url.AbsolutePath;
        Response.Redirect(pagereload);
    }
    protected void ddhospitalname_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindHospitalAddress();
    }




    protected void ch_elect_CheckedChanged(object sender, EventArgs e)
    {
        if (ch_elect.Checked == true)
        {
            checkboxelectrical.Value = "1";
            elect_table.Visible = true;
        }
        else
        {
            elect_table.Visible = false;
            checkboxelectrical.Value = "0";
        }

        ch_elect.Focus();
    }
    protected void ddlperformance_SelectedIndexChanged(object sender, EventArgs e)
    {
        perfidtesthidden.Value += ddlperformance.SelectedValue + ",";
        if (ddlperformance.SelectedValue == "1")
        {
            Session["performancename1"] = ddlperformance.SelectedItem.Text;
            Session["perfid1"] = ddlperformance.SelectedValue;
            Session["Editreportid1"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 1;

        }
        if (ddlperformance.SelectedValue == "2")
        {
            Session["performancename2"] = ddlperformance.SelectedItem.Text;
            Session["perfid2"] = ddlperformance.SelectedValue;
            Session["Editreportid2"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 2;
        }
        if (ddlperformance.SelectedValue == "3")
        {
            Session["performancename3"] = ddlperformance.SelectedItem.Text;
            Session["perfid3"] = ddlperformance.SelectedValue;
            Session["Editreportid3"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 3;
        }
        if (ddlperformance.SelectedValue == "4")
        {
            Session["performancename4"] = ddlperformance.SelectedItem.Text;
            Session["perfid4"] = ddlperformance.SelectedValue;
            Session["Editreportid4"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 4;
        }
        if (ddlperformance.SelectedValue == "5")
        {
            Session["performancename5"] = ddlperformance.SelectedItem.Text;
            Session["perfid5"] = ddlperformance.SelectedValue;
            Session["Editreportid5"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 5;
        }
        if (ddlperformance.SelectedValue == "6")
        {
            Session["performancename6"] = ddlperformance.SelectedItem.Text;
            Session["perfid6"] = ddlperformance.SelectedValue;
            Session["Editreportid6"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 6;
        }
        if (ddlperformance.SelectedValue == "7")
        {
            Session["performancename7"] = ddlperformance.SelectedItem.Text;
            Session["perfid7"] = ddlperformance.SelectedValue;
            Session["Editreportid7"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 7;
        }
        if (ddlperformance.SelectedValue == "8")
        {
            Session["performancename8"] = ddlperformance.SelectedItem.Text;
            Session["perfid8"] = ddlperformance.SelectedValue;
            Session["Editreportid8"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 8;
        }
        if (ddlperformance.SelectedValue == "9")
        {
            Session["performancename9"] = ddlperformance.SelectedItem.Text;
            Session["perfid9"] = ddlperformance.SelectedValue;
            Session["Editreportid9"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 9;
        }
        if (ddlperformance.SelectedValue == "10")
        {
            Session["performancename10"] = ddlperformance.SelectedItem.Text;
            Session["perfid10"] = ddlperformance.SelectedValue;
            Session["Editreportid10"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 10;
        }
        if (ddlperformance.SelectedValue == "11")
        {
            Session["performancename11"] = ddlperformance.SelectedItem.Text;
            Session["perfid11"] = ddlperformance.SelectedValue;
            Session["Editreportid11"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 11;
        }
        if (ddlperformance.SelectedValue == "12")
        {
            Session["performancename12"] = ddlperformance.SelectedItem.Text;
            Session["perfid12"] = ddlperformance.SelectedValue;
            Session["Editreportid12"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 12;
        }
        if (ddlperformance.SelectedValue == "13")
        {
            Session["performancename13"] = ddlperformance.SelectedItem.Text;
            Session["perfid13"] = ddlperformance.SelectedValue;
            Session["Editreportid13"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 13;
        }
        if (ddlperformance.SelectedValue == "14")
        {
            Session["performancename14"] = ddlperformance.SelectedItem.Text;
            Session["perfid14"] = ddlperformance.SelectedValue;
            Session["Editreportid14"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 14;
        }
        if (ddlperformance.SelectedValue == "15")
        {
            Session["performancename15"] = ddlperformance.SelectedItem.Text;
            Session["perfid15"] = ddlperformance.SelectedValue;
            Session["Editreportid15"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 15;
        }
        if (ddlperformance.SelectedValue == "16")
        {
            Session["performancename16"] = ddlperformance.SelectedItem.Text;
            Session["perfid16"] = ddlperformance.SelectedValue;
            Session["Editreportid16"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 16;
        }
        if (ddlperformance.SelectedValue == "17")
        {
            Session["performancename17"] = ddlperformance.SelectedItem.Text;
            Session["perfid17"] = ddlperformance.SelectedValue;
            Session["Editreportid17"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 17;
        }
        if (ddlperformance.SelectedValue == "18")
        {
            Session["performancename18"] = ddlperformance.SelectedItem.Text;
            Session["perfid18"] = ddlperformance.SelectedValue;
            Session["Editreportid18"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 18;
        }
        if (ddlperformance.SelectedValue == "19")
        {
            Session["performancename19"] = ddlperformance.SelectedItem.Text;
            Session["perfid19"] = ddlperformance.SelectedValue;
            Session["Editreportid19"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 19;
        }
        if (ddlperformance.SelectedValue == "20")
        {
            Session["performancename20"] = ddlperformance.SelectedItem.Text;
            Session["perfid20"] = ddlperformance.SelectedValue;
            Session["Editreportid20"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 20;
        }
        if (ddlperformance.SelectedValue == "21")
        {
            Session["performancename21"] = ddlperformance.SelectedItem.Text;
            Session["perfid21"] = ddlperformance.SelectedValue;
            Session["Editreportid21"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 21;
        }
        if (ddlperformance.SelectedValue == "22")
        {
            Session["performancename22"] = ddlperformance.SelectedItem.Text;
            Session["perfid22"] = ddlperformance.SelectedValue;
            Session["Editreportid22"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 22;
        }
        if (ddlperformance.SelectedValue == "23")
        {
            Session["performancename23"] = ddlperformance.SelectedItem.Text;
            Session["perfid23"] = ddlperformance.SelectedValue;
            Session["Editreportid23"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 23;
        }
        if (ddlperformance.SelectedValue == "24")
        {
            Session["performancename24"] = ddlperformance.SelectedItem.Text;
            Session["perfid24"] = ddlperformance.SelectedValue;
            Session["Editreportid24"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 24;
        }
        if (ddlperformance.SelectedValue == "25")
        {
            Session["performancename25"] = ddlperformance.SelectedItem.Text;
            Session["perfid25"] = ddlperformance.SelectedValue;
            Session["Editreportid25"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 25;
        }
        if (ddlperformance.SelectedValue == "26")
        {
            Session["performancename26"] = ddlperformance.SelectedItem.Text;
            Session["perfid26"] = ddlperformance.SelectedValue;
            Session["Editreportid26"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 26;
        }
        if (ddlperformance.SelectedValue == "27")
        {
            Session["performancename27"] = ddlperformance.SelectedItem.Text;
            Session["perfid27"] = ddlperformance.SelectedValue;
            Session["Editreportid27"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 27;
        }
        if (ddlperformance.SelectedValue == "28")
        {
            Session["performancename28"] = ddlperformance.SelectedItem.Text;
            Session["perfid28"] = ddlperformance.SelectedValue;
            Session["Editreportid28"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 28;
        }
        if (ddlperformance.SelectedValue == "29")
        {
            Session["performancename29"] = ddlperformance.SelectedItem.Text;
            Session["perfid29"] = ddlperformance.SelectedValue;
            Session["Editreportid29"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 29;
        }
        if (ddlperformance.SelectedValue == "30")
        {
            Session["performancename30"] = ddlperformance.SelectedItem.Text;
            Session["perfid30"] = ddlperformance.SelectedValue;
            Session["Editreportid30"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 30;
        }
        if (ddlperformance.SelectedValue == "31")
        {
            Session["performancename31"] = ddlperformance.SelectedItem.Text;
            Session["perfid31"] = ddlperformance.SelectedValue;
            Session["Editreportid31"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 31;
        }
        if (ddlperformance.SelectedValue == "32")
        {
            Session["performancename32"] = ddlperformance.SelectedItem.Text;
            Session["perfid32"] = ddlperformance.SelectedValue;
            Session["Editreportid32"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 32;
        }
        if (ddlperformance.SelectedValue == "33")
        {
            Session["performancename33"] = ddlperformance.SelectedItem.Text;
            Session["perfid33"] = ddlperformance.SelectedValue;
            Session["Editreportid33"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 33;
        }
        if (ddlperformance.SelectedValue == "34")
        {
            Session["performancename34"] = ddlperformance.SelectedItem.Text;
            Session["perfid34"] = ddlperformance.SelectedValue;
            Session["Editreportid34"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 34;
        }
        if (ddlperformance.SelectedValue == "35")
        {
            Session["performancename35"] = ddlperformance.SelectedItem.Text;
            Session["perfid35"] = ddlperformance.SelectedValue;
            Session["Editreportid35"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 35;
        }
        if (ddlperformance.SelectedValue == "36")
        {
            Session["performancename36"] = ddlperformance.SelectedItem.Text;
            Session["perfid36"] = ddlperformance.SelectedValue;
            Session["Editreportid36"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 36;
        }
        if (ddlperformance.SelectedValue == "37")
        {
            Session["performancename37"] = ddlperformance.SelectedItem.Text;
            Session["perfid37"] = ddlperformance.SelectedValue;
            Session["Editreportid37"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 37;
        }
        if (ddlperformance.SelectedValue == "38")
        {
            Session["performancename38"] = ddlperformance.SelectedItem.Text;
            Session["perfid38"] = ddlperformance.SelectedValue;
            Session["Editreportid38"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 38;
        }
        if (ddlperformance.SelectedValue == "39")
        {
            Session["performancename39"] = ddlperformance.SelectedItem.Text;
            Session["perfid39"] = ddlperformance.SelectedValue;
            Session["Editreportid39"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 39;
        }
        if (ddlperformance.SelectedValue == "40")
        {
            Session["performancename40"] = ddlperformance.SelectedItem.Text;
            Session["perfid40"] = ddlperformance.SelectedValue;
            Session["Editreportid40"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 40;
        }
        if (ddlperformance.SelectedValue == "41")
        {
            Session["performancename41"] = ddlperformance.SelectedItem.Text;
            Session["perfid41"] = ddlperformance.SelectedValue;
            Session["Editreportid41"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 41;
        }
        if (ddlperformance.SelectedValue == "42")
        {
            Session["performancename42"] = ddlperformance.SelectedItem.Text;
            Session["perfid42"] = ddlperformance.SelectedValue;
            Session["Editreportid42"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 42;
        }
        if (ddlperformance.SelectedValue == "43")
        {
            Session["performancename43"] = ddlperformance.SelectedItem.Text;
            Session["perfid43"] = ddlperformance.SelectedValue;
            Session["Editreportid43"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 43;
        }
        if (ddlperformance.SelectedValue == "44")
        {
            Session["performancename44"] = ddlperformance.SelectedItem.Text;
            Session["perfid44"] = ddlperformance.SelectedValue;
            Session["Editreportid44"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 44;
        }
        if (ddlperformance.SelectedValue == "45")
        {
            Session["performancename45"] = ddlperformance.SelectedItem.Text;
            Session["perfid45"] = ddlperformance.SelectedValue;
            Session["Editreportid45"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 45;
        }
        if (ddlperformance.SelectedValue == "46")
        {
            Session["performancename46"] = ddlperformance.SelectedItem.Text;
            Session["perfid46"] = ddlperformance.SelectedValue;
            Session["Editreportid46"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 46;
        }
        if (ddlperformance.SelectedValue == "47")
        {
            Session["performancename47"] = ddlperformance.SelectedItem.Text;
            Session["perfid47"] = ddlperformance.SelectedValue;
            Session["Editreportid47"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 47;
        }
        if (ddlperformance.SelectedValue == "48")
        {
            Session["performancename48"] = ddlperformance.SelectedItem.Text;
            Session["perfid48"] = ddlperformance.SelectedValue;
            Session["Editreportid48"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 48;
        }

        if (ddlperformance.SelectedValue == "49")
        {
            Session["performancename49"] = ddlperformance.SelectedItem.Text;
            Session["perfid49"] = ddlperformance.SelectedValue;
            Session["Editreportid49"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 49;
        }

        if (ddlperformance.SelectedValue == "50")
        {
            Session["performancename50"] = ddlperformance.SelectedItem.Text;
            Session["perfid50"] = ddlperformance.SelectedValue;
            Session["Editreportid50"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 50;
        }

        if (ddlperformance.SelectedValue == "51")
        {
            Session["performancename51"] = ddlperformance.SelectedItem.Text;
            Session["perfid51"] = ddlperformance.SelectedValue;
            Session["Editreportid51"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 51;
        }

        if (ddlperformance.SelectedValue == "52")
        {
            Session["performancename52"] = ddlperformance.SelectedItem.Text;
            Session["perfid52"] = ddlperformance.SelectedValue;
            Session["Editreportid52"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 52;
        }

        if (ddlperformance.SelectedValue == "53")
        {
            Session["performancename53"] = ddlperformance.SelectedItem.Text;
            Session["perfid53"] = ddlperformance.SelectedValue;
            Session["Editreportid53"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 53;
        }

        if (ddlperformance.SelectedValue == "54")
        {
            Session["performancename54"] = ddlperformance.SelectedItem.Text;
            Session["perfid54"] = ddlperformance.SelectedValue;
            Session["Editreportid54"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 54;
        }

        if (ddlperformance.SelectedValue == "55")
        {
            Session["performancename55"] = ddlperformance.SelectedItem.Text;
            Session["perfid55"] = ddlperformance.SelectedValue;
            Session["Editreportid55"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 55;
        }

        if (ddlperformance.SelectedValue == "56")
        {
            Session["performancename56"] = ddlperformance.SelectedItem.Text;
            Session["perfid56"] = ddlperformance.SelectedValue;
            Session["Editreportid56"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 56;
        }

        if (ddlperformance.SelectedValue == "57")
        {
            Session["performancename57"] = ddlperformance.SelectedItem.Text;
            Session["perfid57"] = ddlperformance.SelectedValue;
            Session["Editreportid57"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 57;
        }
        if (ddlperformance.SelectedValue == "58")
        {
            Session["performancename58"] = ddlperformance.SelectedItem.Text;
            Session["perfid58"] = ddlperformance.SelectedValue;
            Session["Editreportid58"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 58;
        }
        if (ddlperformance.SelectedValue == "59")
        {
            Session["performancename59"] = ddlperformance.SelectedItem.Text;
            Session["perfid59"] = ddlperformance.SelectedValue;
            Session["Editreportid59"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 59;
        }
        if (ddlperformance.SelectedValue == "60")
        {
            Session["performancename60"] = ddlperformance.SelectedItem.Text;
            Session["perfid60"] = ddlperformance.SelectedValue;
            Session["Editreportid60"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 60;
        }
        if (ddlperformance.SelectedValue == "61")
        {
            Session["performancename61"] = ddlperformance.SelectedItem.Text;
            Session["perfid61"] = ddlperformance.SelectedValue;
            Session["Editreportid61"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 61;
        }
        if (ddlperformance.SelectedValue == "62")
        {
            Session["performancename62"] = ddlperformance.SelectedItem.Text;
            Session["perfid62"] = ddlperformance.SelectedValue;
            Session["Editreportid62"] = editreport_hidden.Value;
            Session["ReportNo"] = lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''");
            perfmulti.ActiveViewIndex = 62;
        }
        //ddlperformance.Focus();
        txtremarks.Focus();
    }
    protected void ddlproductname_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtproname.Text = ddlproductname.SelectedItem.Text;
        Bindtraceid();
        BindPerfid();
        BindRemarks();
        //BindTraceability(); 
        BindCompany();
        //ddlmodel.Focus();
        //btnsavereport.Focus();
        ddlcondition.Focus();
    }
    protected void txtdateofcalib_TextChanged(object sender, EventArgs e)
    {
        Session["calibdate"] = txtdateofcalib.Text;
        // DateTime year = Convert.ToDateTime(txtdateofcalib.Text).AddDays(364);
        DateTime year = Convert.ToDateTime(txtdateofcalib.Text, System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat).AddDays(364);
        txtduedate.Text = (year.Date).ToString("dd/MM/yyyy");
        string expdate = txtduedate.Text.Trim().Replace("-", "/");
        txtduedate.Text = expdate;
    }
    protected void ddlmanuf_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtmanu.Text = ddlmanuf.SelectedItem.Text;
        BindModel();
        //btnsavereport.Focus();
        //ddlmodel.Focus();
        ddlcondition.Focus();
    }
    protected void ddlmodel_SelectedIndexChanged(object sender, EventArgs e)
    {

        BindDeviceType();
        BindDeviceClassi();
        Bind_Supply_Power();
        txtmodel.Text = ddlmodel.SelectedItem.Text;
        txtdevtype.Text = ddlevicetype.SelectedItem.Text;
        txtdevclassification.Text = ddldeviceclass.SelectedItem.Text;
        txtsupplydata.Text = txtsupply.Text.Trim();
        txtpowerdate.Text = txtpower.Text.Trim();
        //ddlevicetype.Focus();
        //btnsavereport.Focus();
        ddlcondition.Focus();
    }
    protected void ch_perf_CheckedChanged(object sender, EventArgs e)
    {

        if (ch_perf.Checked == true)
        {
            checkboxperform.Value = "1";
            perf_table.Visible = true;
        }
        else
            perf_table.Visible = false;

        //btnsavereport.Focus();
        //ch_perf.Focus();
        txtremarks.Focus();
    }
    protected void btneditreport_Click(object sender, EventArgs e)
    {
        multiviewreport.ActiveViewIndex = 1;
        int pageIndex = 1, maxRows = 50;
        Bind_EditReportinfo(pageIndex, maxRows);
        btneditreport.Style.Add("background-color", "#195A7F");
        btnaddreport.Style.Add("background-color", "#4892DB");
    }
    protected void btnaddreport_Click(object sender, EventArgs e)
    {
        multiviewreport.ActiveViewIndex = 0;
        btnaddreport.Style.Add("background-color", "#195A7F");
        btneditreport.Style.Add("background-color", "#4892DB");
        Response.Redirect("AddReport.aspx");

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            editreport_hidden.Value = e.CommandArgument.ToString();

        }
    }

    public void Reload_EditReport(string reportno)
    {

        string Temp = "", Relative = "", Ambient = "", Product = "", slno = "", Biomedicalid = "";
        db1.strCommand = "select * from Report_Info where Report_info_ID='" + reportno + "'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                db1.strCommand = "select HospitalName from Hospital where HospitalID='" + dt.Rows[i]["HospitalID"].ToString() + "'";
                DataTable dt_hospital = db1.selecttable();
                if (dt_hospital.Rows.Count > 0)
                {
                    hospitalname.Value = dt_hospital.Rows[0]["HospitalName"].ToString();
                }


                db1.strCommand = "select Temperature,Relative_Humidity,Ambient_Barometric_measure from Environ_condition where ECM_ID='" + dt.Rows[i]["ECM_ID"].ToString() + "'";
                DataTable dt_environ = db1.selecttable();
                if (dt_environ.Rows.Count > 0)
                {
                    Temp = dt_environ.Rows[0]["Temperature"].ToString();
                    Relative = dt_environ.Rows[0]["Relative_Humidity"].ToString();
                    Ambient = dt_environ.Rows[0]["Ambient_Barometric_measure"].ToString();
                }
                else
                {
                    db1.strCommand = "select top 1 * from Environ_condition order by ECM_ID desc";
                    DataTable dt_en = db1.selecttable();
                    if (dt_en.Rows.Count > 0)
                    {
                        Temp = dt_en.Rows[0]["Temperature"].ToString();
                        Relative = dt_en.Rows[0]["Relative_Humidity"].ToString();
                        Ambient = dt_en.Rows[0]["Ambient_Barometric_measure"].ToString();
                        ecmidhidden.Value = dt_en.Rows[0]["ECM_ID"].ToString();
                    }
                }

                db1.strCommand = "select ProductName from Product where ProductID='" + dt.Rows[i]["ProductID"].ToString() + "'";
                DataTable dt_product = db1.selecttable();
                if (dt_product.Rows.Count > 0)
                {
                    Product = dt_product.Rows[0]["ProductName"].ToString();
                }

                db1.strCommand = "select Serial_No,Biomedical_ID from DUT_info where Report_info_ID='" + dt.Rows[i]["Report_info_ID"].ToString() + "'";
                DataTable dt_dut = db1.selecttable();
                if (dt_dut.Rows.Count > 0)
                {
                    slno = dt_dut.Rows[0]["Serial_No"].ToString();
                    Biomedicalid = dt_dut.Rows[0]["Biomedical_ID"].ToString();
                }

                //dt_result.Rows.Add(dt.Rows[i]["Report_info_ID"].ToString(), dt.Rows[i]["ReportNo"].ToString(), dt.Rows[i]["Date_of_calibration"].ToString(), dt.Rows[i]["Calibration_Due_on"].ToString(),
                //    Hospname, Temp, Relative, Ambient, Product, slno, Biomedicalid);
                if (dt.Rows[0]["ReportNo"].ToString().Contains("BMT/"))
                {
                    txtreportno.Text = dt.Rows[0]["ReportNo"].ToString().Replace("BMT/", "");
                    txtbarcode.Text = dt.Rows[0]["Barcode_ID"].ToString().Replace("BMT/", "");
                }
                else if (dt.Rows[0]["ReportNo"].ToString().Contains("BMT-MTH/"))
                {
                    txtreportno.Text = dt.Rows[0]["ReportNo"].ToString().Replace("BMT-MTH/", "");
                    txtbarcode.Text = dt.Rows[0]["Barcode_ID"].ToString().Replace("BMT-MTH/", "");
                }
                else if (dt.Rows[0]["ReportNo"].ToString().Contains("BMT-ACH/"))
                {
                    txtreportno.Text = dt.Rows[0]["ReportNo"].ToString().Replace("BMT-ACH/", "");
                    txtbarcode.Text = dt.Rows[0]["Barcode_ID"].ToString().Replace("BMT-ACH/", "");
                }
                txtdateofcalib.Text = dt.Rows[0]["Date_of_calibration"].ToString();
                txtduedate.Text = dt.Rows[0]["Calibration_Due_on"].ToString();
                txttemperature.Text = Temp;
                txtrelative.Text = Relative;
                txtambient.Text = Ambient;
                txtserialno.Text = slno;
                txtbiomedical.Text = Biomedicalid;
                ddhospitalname.Items.Insert(0, hospitalname.Value);
                //ddhospitalname.SelectedItem.Text = hospitalname.Value;
                //ddhospitalname.SelectedValue = "0";
                //ddlproductname.SelectedItem.Text = Product;
                ddlproductname.Items.Insert(0, Product);
                //ddlproductname.SelectedValue = Product;
            }

        }


    }
    //protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    //{

    //}
    protected void imgbtnEdit_Click(object sender, ImageClickEventArgs e)
    {
        GridViewRow gvrow = (GridViewRow)((ImageButton)sender).NamingContainer;
        editreport_hidden.Value = (GridView1.DataKeys[gvrow.RowIndex].Value).ToString();
        multiviewreport.ActiveViewIndex = 0;
        btnaddreport.Style.Add("background-color", "#195A7F");
        btneditreport.Style.Add("background-color", "#4892DB");
        Reload_dates();
        BindProductName();
        BindHospitalname();
        Reload_EditReport(editreport_hidden.Value);
        Reload_Referencedate();

        btnsavereport.Text = "Update Report";
    }

    public void Update_Reportinfo()
    {
        perfid_hidden.Value = perfidtesthidden.Value;
        if (checkboxperform.Value == "1")
        {
            string val = checkboxperform.Value;
        }
        if (checkboxperform.Value == "0")
        {
            perfid_hidden.Value = checkboxperform.Value;
        }
        if (checkboxelectrical.Value == "1")
        {
            string val = checkboxelectrical.Value;
        }
        if (checkboxelectrical.Value == "0")
        {
            elect_hidden.Value = checkboxelectrical.Value;
        }
        if (ch_elect.Checked == true && ch_perf.Checked == false)
        {
            db1.strCommand = "update Report_Info set ReportNo='" + lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''") + "',Barcode_ID='" + lblBarcode.Text + txtbarcode.Text.Trim().Replace("'", "''") + "'," +
                "Date_of_calibration='" + txtdateofcalib.Text.Trim().Replace("'", "''") + "',Calibration_Due_on='" + txtduedate.Text.Trim().Replace("'", "''") + "'," +
                "ProductID='" + productidhidden.Value + "',ElectID='" + maxelectid.Value + "',PerfID='" + 0 + "',ECM_ID='" + ecmidhidden.Value + "',Tracibility_ID='" + lblValues.Text + "'," +
                "HospitalID='" + ddhospitalname.SelectedValue + "',Remarks='" + txtremarks.Text.Trim().Replace("'", "''") + "' where Report_info_ID='" + editreport_hidden.Value + "'";

            db1.insertqry();


        }
        else if (ch_perf.Checked == true && ch_elect.Checked == false)
        {
            db1.strCommand = "update Report_Info set ReportNo='" + lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''") + "',Barcode_ID='" + lblBarcode.Text + txtbarcode.Text.Trim().Replace("'", "''") + "'," +
                "Date_of_calibration='" + txtdateofcalib.Text.Trim().Replace("'", "''") + "',Calibration_Due_on='" + txtduedate.Text.Trim().Replace("'", "''") + "'," +
                "ProductID='" + productidhidden.Value + "',PerfID='" + perfid_hidden.Value + "',ElectID='" + 0 + "',ECM_ID='" + ecmidhidden.Value + "',Tracibility_ID='" + lblValues.Text + "'," +
                "HospitalID='" + ddhospitalname.SelectedValue + "',Remarks='" + txtremarks.Text.Trim().Replace("'", "''") + "' where Report_info_ID='" + editreport_hidden.Value + "'";

            db1.insertqry();

        }
        else if (ch_elect.Checked == true && ch_perf.Checked == true)
        {
            db1.strCommand = "update Report_Info set ReportNo='" + lblReportNo.Text + txtreportno.Text.Trim().Replace("'", "''") + "',Barcode_ID='" + lblBarcode.Text + txtbarcode.Text.Trim().Replace("'", "''") + "'," +
                "Date_of_calibration='" + txtdateofcalib.Text.Trim().Replace("'", "''") + "',Calibration_Due_on='" + txtduedate.Text.Trim().Replace("'", "''") + "'," +
                "ProductID='" + productidhidden.Value + "',PerfID='" + perfid_hidden.Value + "',ECM_ID='" + ecmidhidden.Value + "',Tracibility_ID='" + lblValues.Text + "'," +
                "ElectID='" + maxelectid.Value + "',HospitalID='" + ddhospitalname.SelectedValue + "',Remarks='" + txtremarks.Text.Trim().Replace("'", "''") + "' where Report_info_ID='" + editreport_hidden.Value + "'";

            db1.insertqry();


        }
    }

    public void Update_CustomerInfo()
    {
        db1.strCommand = "update Customer_Info set HospitalID='" + ddhospitalname.SelectedValue + "',Reference_Date='" + txtreferencedate.Text.Trim().Replace("'", "''") + "'," +
            "Date_Receipt='" + txtdateofreceipt.Text.Trim().Replace("'", "''") + "' where Report_info_ID='" + editreport_hidden.Value + "'";
        db1.insertqry();
    }

    public void Update_Dut_Info()
    {
        bool electrical_value = false;
        bool performance_value = false;
        if (ch_elect.Checked == true)
        {
            electrical_value = true;
        }
        else
        {
            electrical_value = false;
        }
        if (ch_perf.Checked == true)
        {
            performance_value = true;
        }
        else
        {
            performance_value = false;
        }

        db1.strCommand = "update DUT_info set Serial_No='" + txtserialno.Text.Trim().Replace("'", "''") + "',Biomedical_ID='" + txtbiomedical.Text.Trim().Replace("'", "''") + "'," +
            "Location='" + txtlocation.Text.Trim().Replace("'", "''") + "',Condition_of_item='" + ddlcondition.SelectedValue + "'," +
            "ElectricalSafety='" + electrical_value + "',Performance='" + performance_value + "' where Report_info_ID='" + editreport_hidden.Value + "'";
        db1.insertqry();
    }

    public void Update_Calibrationstatus()
    {
        bool manuspeci = false;
        bool userspeci = false;
        bool withinspeci = false;
        bool outofspeci = false;
        bool calibrationspeci = false;
        bool electricalspeci = false;
        bool performspeci = false;

        if (chkmanu.Checked == true)
        {
            editreport_calibstatus.Value += chkmanu.Text + ",";
            manuspeci = true;
        }
        else
            manuspeci = false;
        if (chkuser.Checked == true)
        {
            userspeci = true;
            editreport_calibstatus.Value += chkuser.Text + ",";
        }
        else
            userspeci = false;
        if (chkwithin.Checked == true)
        {
            withinspeci = true;
            editreport_calibstatus.Value += chkwithin.Text + ",";
        }
        else
            withinspeci = false;
        if (chkout.Checked == true)
        {
            outofspeci = true;
            editreport_calibstatus.Value += chkout.Text + ",";
        }
        else
            outofspeci = false;
        if (chkcalib.Checked == true)
        {
            calibrationspeci = true;
            editreport_calibstatus.Value += chkcalib.Text + ",";
        }
        else
            calibrationspeci = false;
        if (chkelctrical.Checked == true)
        {
            electricalspeci = true;
            editreport_calibstatus.Value += chkelctrical.Text + ",";
        }
        else
            electricalspeci = false;
        if (chkperform.Checked == true)
        {
            performspeci = true;
            editreport_calibstatus.Value += chkperform.Text;
        }
        else
            performspeci = false;

        calibstatus_hidden.Value = editreport_calibstatus.Value;

        db1.strCommand = "update Calibration_Status set Manu_Specifi='" + manuspeci + "',User_Specifi='" + userspeci + "',within_specifi='" + withinspeci + "'," +
            "outof_specifi='" + outofspeci + "',calibration='" + calibrationspeci + "',Electrical_safety='" + electricalspeci + "',Performance_analysis='" + performspeci + "' " +
            "where Report_info_ID='" + editreport_hidden.Value + "'";
        db1.insertqry();
    }
    
    protected void btnSearchreport_Click(object sender, EventArgs e)
    {

        if (txtSearchString1.Text != "")
        {

            db1.strCommand = db1.strCommand = "select ri.Report_info_ID,ri.ReportNo,ri.Date_of_calibration,ri.Calibration_Due_on," +
                              "hp.HospitalName,ec.Temperature,ec.Relative_Humidity," +
                               "ec.Ambient_Barometric_measure,p.ProductName,di.Serial_No,di.Biomedical_ID " +
                                "from Report_Info ri join Hospital hp on ri.HospitalID=hp.HospitalID join Environ_condition ec " +
                                "on ri.ECM_ID=ec.ECM_ID join Product p on ri.ProductID=p.ProductID " +
                                "join DUT_info di on ri.Report_info_ID=di.Report_info_ID " +
                                "where ri.ReportNo='" + txtSearchString1.Text.Trim() + "'";
            DataTable dt = db1.selecttable();

            if (dt.Rows.Count > 0)
            {

                GridView1.DataSource = dt;
                GridView1.DataBind();
                txtSearchString1.Text = "";
            }
            else
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
                txtSearchString1.Text = "";
            }
            rptPager.Visible = false;
        }
        else if (txtsearchcompany.Text != "")
        {


            db1.strCommand = "select ri.Report_info_ID,ri.ReportNo,ri.Date_of_calibration,ri.Calibration_Due_on," +
                              "hp.HospitalName,ec.Temperature,ec.Relative_Humidity," +
                               "ec.Ambient_Barometric_measure,p.ProductName,di.Serial_No,di.Biomedical_ID " +
                                "from Report_Info ri join Hospital hp on ri.HospitalID=hp.HospitalID join Environ_condition ec " +
                                "on ri.ECM_ID=ec.ECM_ID join Product p on ri.ProductID=p.ProductID " +
                                "join DUT_info di on ri.Report_info_ID=di.Report_info_ID " +
                                "where hp.HospitalName like '" + txtsearchcompany.Text.Trim() + "%'";
            DataTable dt = db1.selecttable();
            if (dt.Rows.Count > 0)
            {

                GridView1.DataSource = dt;
                GridView1.DataBind();
                txtsearchcompany.Text = "";
            }
            else
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
                txtsearchcompany.Text = "";
            }
            rptPager.Visible = false;
        }
        else if (string.IsNullOrEmpty(txtsearchcompany.Text.Trim()) && string.IsNullOrEmpty(txtSearchString1.Text.Trim()))
        {
            Bind_EditReportinfo(1, 50);
        }

    }

    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> SearchHospital(string prefixText, int count)
    {
        using (SqlConnection conn = new SqlConnection())
        {
            conn.ConnectionString = ConfigurationManager
                    .ConnectionStrings["surgchemcon"].ConnectionString;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "select HospitalName from Hospital where " +
                "HospitalName like @SearchText + '%'";
                cmd.Parameters.AddWithValue("@SearchText", prefixText);
                cmd.Connection = conn;
                conn.Open();
                List<string> customers = new List<string>();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        customers.Add(sdr["HospitalName"].ToString());
                    }
                }
                conn.Close();
                return customers;
            }
        }
    }

    protected void radiosearchtype_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (radiosearchtype.SelectedValue == "0")
        {
            txtSearchString1.Visible = true;
            txtsearchcompany.Visible = false;
        }
        else if (radiosearchtype.SelectedValue == "1")
        {
            txtSearchString1.Visible = false;
            txtsearchcompany.Visible = true;
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        db1.strCommand = "insert into Product(ProductName,Company,Model,Device_Type,Device_Classification,Supply,PowerRating)values " +
                    "('" + txtproname.Text.Trim().Replace("'", "''") + "','" + txtmanu.Text.Trim().Replace("'", "''") + "','" + txtmodel.Text.Trim().Replace("'", "''") + "'," +
                    "'" + txtdevtype.Text.Trim().Replace("'", "''") + "','" + txtdevclassification.Text.Trim().Replace("'", "''") + "','" + txtsupplydata.Text.Trim().Replace("'", "''") + "'," +
            "'" + txtpowerdate.Text.Trim().Replace("'", "''") + "')";
        db1.insertqry();
        Clearfields();
    }
    protected void btncancelproduct_Click(object sender, EventArgs e)
    {
        Clearfields();
    }

    public void Clearfields()
    {
        txtproname.Text = "";
        txtmanu.Text = "";
        txtmodel.Text = "";
        txtdevtype.Text = "";
        txtdevclassification.Text = "";
        txtsupplydata.Text = "";
        txtpowerdate.Text = "";
    }
    protected void txtreportno_TextChanged(object sender, EventArgs e)
    {
        txtbarcode.Text = txtreportno.Text.Trim();
    }
}