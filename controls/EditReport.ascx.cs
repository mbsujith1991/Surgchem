using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.IO;


public partial class controls_EditReport : System.Web.UI.UserControl
{
    Dbclass db1 = new Dbclass();
    DataTable dt_result = new DataTable();
    DataTable dt_trace = new DataTable();
    DataTable dt = new DataTable();
    DataTable dt_perf = new DataTable();
    string[] traceidarray = { };
    string[] perfidarray = { };
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GridBind();
            TraceBind();
            PerfID();
        }
    }

    public void GridBind()
    {
        dt_result.Columns.Add("ReportNo", typeof(string));
        dt_result.Columns.Add("Date_of_calibration", typeof(string));
        dt_result.Columns.Add("Calibration_Due_on", typeof(string));
        dt_result.Columns.Add("HospitalName", typeof(string));
        dt_result.Columns.Add("Instrument", typeof(string));
        dt_result.Columns.Add("Perf_TestName", typeof(string));
        dt_trace.Columns.Add("Instrument", typeof(string));
        dt_perf.Columns.Add("Perf_TestName", typeof(string));

        db1.strCommand = "select rp.ReportNo,rp.Date_of_calibration,rp.Calibration_Due_on,hp.HospitalName,rp.Tracibility_ID, " +
            "rp.PerfID from Report_Info rp inner join Hospital hp on rp.HospitalID=hp.HospitalID";
            
         dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TraceBind();
                PerfID();
                dt_result.Rows.Add(dt.Rows[i]["ReportNo"].ToString(), dt.Rows[i]["Date_of_calibration"].ToString(),
                    dt.Rows[i]["Calibration_Due_on"].ToString(), dt.Rows[i]["HospitalName"].ToString(),
                    dt_trace, dt_perf);
            }
            GridView1.DataSource = dt_result;
            GridView1.DataBind();
            DataList1.DataSource = dt_result;
            DataList1.DataBind();

        }
    }

    public void TraceBind()
    {
       
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            string traceidedit = dt.Rows[i]["Tracibility_ID"].ToString();
            traceidarray = traceidedit.Split(',');
            
            //int count = perfidarray.Count();
            for (int j = 0; j < traceidarray.Count() - 1; j++)
            {
                db1.strCommand = "select * from Traceability_Info where Tracibility_ID='" + traceidarray[j] + "'";
                DataTable dt_tracesub = db1.selecttable();
                if (dt_tracesub.Rows.Count > 0)
                {
                    for (int k = 0; k < dt_tracesub.Rows.Count; k++)
                    {
                        dt_trace.Rows.Add(dt_tracesub.Rows[k]["Instrument"].ToString());
                    }
                    GridView2.DataSource = dt_trace;
                    GridView2.DataBind();
                }
            }
        }
    }

    public void PerfID()
    {
        
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            string perfidedit = dt.Rows[i]["PerfID"].ToString();
            perfidarray = perfidedit.Split(',');
            for (int j = 0; j < perfidarray.Count() - 1; j++)
            {
                db1.strCommand = "select * from PerformanceTest where PerfID='" + perfidarray[j] + "'";
                DataTable dt_perfsub = db1.selecttable();
                if (dt_perfsub.Rows.Count > 0)
                {
                    for (int k = 0; k < dt_perfsub.Rows.Count; k++)
                    {
                        dt_perf.Rows.Add(dt_perfsub.Rows[k]["Perf_TestName"].ToString());
                    }
                    GridView3.DataSource = dt_perf;
                    GridView3.DataBind();
                }
            }
        }
    }

    public void Populate_ReportDetails()
    {
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        
    }
    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        DropDownList drp = (DropDownList)DataList1.FindControl("DropDownList1");
        drp.DataSource = dt_trace;
        drp.DataTextField = "Instrument";
        drp.DataValueField = "Instrument";
        drp.DataBind();

        DropDownList drp_perf = (DropDownList)DataList1.FindControl("DropDownList2");
        drp_perf.DataSource = dt_perf;
        drp_perf.DataTextField = "Perf_TestName";
        drp_perf.DataValueField = "Perf_TestName";
        drp_perf.DataBind();
    }
}