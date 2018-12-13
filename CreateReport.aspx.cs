using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;

public partial class CreateReport : System.Web.UI.Page
{
    Dbclass db1 = new Dbclass();
    protected void Page_Init(object sender, EventArgs e)
    {
        if (Request.IsAuthenticated && Session["returnUrl"] != null)
        {
            //string username = Page.User.Identity.Name;
            //Label1.Text = "Welcome " + username;
        }
        else
        {
            Response.Redirect("Default.aspx");
        }

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bindperformancetest();
            BindHospitalname();
        }
    }

    #region functions

    string perfid = "";
    public void Bindperformancetest()
    {
        db1.strCommand = "select PerfID,Perf_TestName from PerformanceTest";
        DataTable dt=db1.selecttable();
        ddperftestname.Items.Clear();
        if (dt.Rows.Count > 0)
        {
            ddperftestname.DataSource = dt;
            ddperftestname.DataTextField = "Perf_TestName";
            ddperftestname.DataValueField = "PerfID";
            ddperftestname.DataBind();
        }
        ddperftestname.Items.Insert(0, "--select Performance Test--");
        perfid = dt.ToString();
    }


    string hospitalid = "";
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
        ddhospitalname.Items.Insert(0, "--select Hospital Name--");
        hospitalid = dt.ToString();
    }


    public void InsertReportinfo()
    {

        db1.strCommand = "insert into Report_Info(ReportNo,Date_of_calibration,Calibration_Due_on,PerfID) values('" + txtreportno.Text + "','" + txtdateofcalib.Text + "','" + txtduedate.Text + "','" + ddperftestname.SelectedValue + "')";
        db1.insertqry();
    }


    public void Customerinfo()
    {
        db1.strCommand = "insert into Customer_Info(HospitalID,Reference_Date,Date_Receipt,Report_info_ID) values('" + ddhospitalname.SelectedValue + "','" + txtreferencedate.Text + "','" + txtdateofreceipt.Text + "','" + reportid + "')";
        db1.insertqry();
    }

    string reportid = "";
    public void select_Reportinfo()
    {
        db1.strCommand = "select max(Report_info_ID) from Report_Info";
        reportid = db1.executescalar().ToString();
    }

    public void Environmentalcondition()
    {
        db1.strCommand = "insert into Environ_condition(Report_info_ID,Temperature,Relative_Humidity,Ambient_Barometric_measure) values('" + reportid + "','" + txttemperature.Text + "','" + txtrelative.Text + "','" + txtambient.Text + "')";
        db1.insertqry();
    }

    public void TraceabilityInfo()
    {
        db1.strCommand = "insert into Traceability_Info(Report_info_ID,Instrument,Make,Model,SerialNo,Traceability_call_due,Reference) values('" + reportid + "','" + txtinstrument.Text + "','" + txtmake.Text + "','" + txtmodeltrace.Text + "','" + txtserialnotrace.Text + "','" + txttracebility.Text + "','" + txtracerefer.Text + "')";
        db1.insertqry();
    }

    public void DUT_info()
    {
        bool electrical_value=false;
        bool performance_value=false;
        if(ch_elect.Checked==true)
        {
            electrical_value=true;
        }
        else{
            electrical_value=false;
        }
        if(ch_perf.Checked==true)
        {
            performance_value=true;
        }
        else{
            performance_value=false;
        }
      db1.strCommand = "insert into DUT_info(Report_info_ID,Barcode_ID,Serial_No,Biomedical_ID,Supply,Power_Rating,Location,Condition_of_item,ElectricalSafety,Performance) values('" + reportid + "','" + txtbarcode.Text + "','" + txtserialno.Text + "','" + txtbiomedical.Text + "','" + txtsupply.Text + "','" + txtpower.Text + "','" + txtlocation.Text + "','" + txtcondition.Text + "','"+electrical_value+"','"+performance_value+"')";
      db1.insertqry();
    }

    public void product_info()
    {
        db1.strCommand = "insert into Product(ProductName,Company,Model,Device_Type,Device_Classification,Report_info_ID)values('" + txtproductname.Text + "','" + txtmanuf.Text + "','" + txtmodel.Text + "','" + txtdevicetype.Text + "','" + txtdeviceclass.Text + "','" + reportid + "')";
        db1.insertqry();
    }

    public void calibrationstatus()
    {
        bool manuspeci=false;
        bool userspeci=false;
        bool withinspeci=false;
        bool outofspeci=false;
        bool calibrationspeci=false;
        bool electricalspeci=false;
        bool performspeci=false;
        if(chkmanu.Checked==true)
            manuspeci=true;
        else
            manuspeci=false;
        if(chkuser.Checked==true)
            userspeci=true;
        else
            userspeci=false;
        if(chkwithin.Checked==true)
            withinspeci=true;
        else
            withinspeci=false;
        if(chkout.Checked==true)
            outofspeci=true;
        else
            outofspeci=false;
        if(chkcalib.Checked==true)
            calibrationspeci=true;
        else
            calibrationspeci=false;
        if(chkelctrical.Checked==true)
            electricalspeci=true;
        else
            electricalspeci=false;
        if(chkperform.Checked==true)
            performspeci=true;
        else
            performspeci=false;
        db1.strCommand = "insert into Calibration_Status(Report_info_ID,Manu_Specifi,User_Specifi,within_specifi,outof_specifi,calibration,Electrical_safety,Performance_analysis)values('" + reportid + "','" + manuspeci + "','" + userspeci + "','" + withinspeci + "','" + outofspeci + "','" + calibrationspeci + "','" + electricalspeci + "','" + performspeci + "')";
        db1.insertqry();
    }

    public void populate_performancecategories()
    {
        db1.strCommand = "select CategoryName from Perf_Category where PerfID='" + ddperftestname.SelectedValue+"'";
        DataTable dt;
        dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            performance_list.DataSource = dt;
            performance_list.DataBind();
        }
       
    }
    #endregion

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        InsertReportinfo();
        select_Reportinfo();
        Customerinfo();
        Environmentalcondition();
        product_info();
        DUT_info();
        calibrationstatus();
    }
    protected void ddperftestname_SelectedIndexChanged(object sender, EventArgs e)
    {
        populate_performancecategories();
    }
}