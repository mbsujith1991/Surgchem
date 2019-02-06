using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class controls_Perfanalysis_micropipette2019 : System.Web.UI.UserControl
{
    Dbclass db1 = new Dbclass();
    private string _Reportid;
    object edit_Reportid = "";
    public string Reportid
    {
        get
        {
            return _Reportid;
        }
        set
        {
            _Reportid = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        edit_Reportid = Session["Editreportid63"];
    }

    string perfname = "";
    string perfid = "";
    public void save_performancetest()
    {
        db1.strCommand = "insert into check_perftest(PerfID,Perf_TestName) values('" + Session["Perfid63"].ToString() + "','" + Session["performancename63"].ToString() + "')";
        db1.insertqry();
        perfname = Session["performancename63"].ToString();

    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            if (edit_Reportid == "" || edit_Reportid == null)
            {
                save_performancetest();
                for (int i = 0; i < 3; i++)
                {
                    if (i == 0)
                    {
                        Perfanalysis_Holtermachine_hidden.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtDevRead1.Text.Trim().Replace("'", "''") + "," +
                           txtMean1.Text.Trim().Replace("'", "''") + "," + txtCorrection1.Text.Trim().Replace("'", "''") + "," + txtAccuracy1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid63"].ToString() + "','" + Perfanalysis_Holtermachine_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();

                    }
                    if (i == 1)
                    {
                        Perfanalysis_Holtermachine_hidden.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtDevRead2.Text.Trim().Replace("'", "''") + "," +
                           txtMean2.Text.Trim().Replace("'", "''") + "," + txtCorrection2.Text.Trim().Replace("'", "''") + "," + txtAccuracy2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid63"].ToString() + "','" + Perfanalysis_Holtermachine_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();

                    }
                    if (i == 2)
                    {
                        Perfanalysis_Holtermachine_hidden.Value = txtsl3.Text.Trim().Replace("'", "''") + "," + txtDevRead3.Text.Trim().Replace("'", "''") + "," +
                           txtMean3.Text.Trim().Replace("'", "''") + "," + txtCorrection3.Text.Trim().Replace("'", "''") + "," + txtAccuracy3.Text.Trim().Replace("'", "''") + "," + txtrem3.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid63"].ToString() + "','" + Perfanalysis_Holtermachine_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();

                    }                    
                }
                db1.strCommand = "select Top 3 ValueID from Performance_Values order by ValueID desc";
                DataTable dt_valueid = db1.selecttable();

                if (dt_valueid.Rows.Count > 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid63"].ToString() + "','" + dt_valueid.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }

                }
                lblmsg.Text = "Data Inserted Successfully";
                lblmsg.Style.Add("color", "green");
            }
            else
            {
                save_performancetest();
                db1.strCommand = "select ValueID from Performance_Values where Report_info_ID='" + edit_Reportid + "' and PerfID='63'";
                DataTable dt_valueid = db1.selecttable();
                if (dt_valueid.Rows.Count > 0)
                {
                    for (int i = 0; i < dt_valueid.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            Perfanalysis_Holtermachine_hidden.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtDevRead1.Text.Trim().Replace("'", "''") + "," +
                           txtMean1.Text.Trim().Replace("'", "''") + "," + txtCorrection1.Text.Trim().Replace("'", "''") + "," + txtAccuracy1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");

                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid63"].ToString() + "','" + Perfanalysis_Holtermachine_hidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();

                        }
                        if (i == 1)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            Perfanalysis_Holtermachine_hidden.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtDevRead2.Text.Trim().Replace("'", "''") + "," +
                           txtMean2.Text.Trim().Replace("'", "''") + "," + txtCorrection2.Text.Trim().Replace("'", "''") + "," + txtAccuracy2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid63"].ToString() + "','" + Perfanalysis_Holtermachine_hidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();

                        }
                        if (i == 2)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            Perfanalysis_Holtermachine_hidden.Value = txtsl3.Text.Trim().Replace("'", "''") + "," + txtDevRead3.Text.Trim().Replace("'", "''") + "," +
                           txtMean3.Text.Trim().Replace("'", "''") + "," + txtCorrection3.Text.Trim().Replace("'", "''") + "," + txtAccuracy3.Text.Trim().Replace("'", "''") + "," + txtrem3.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid63"].ToString() + "','" + Perfanalysis_Holtermachine_hidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();

                        }                        
                    }
                    if (dt_valueid.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt_valueid.Rows.Count; i++)
                        {
                            db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid63"].ToString() + "','" + dt_valueid.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }

                    }
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (i == 0)
                        {
                            Perfanalysis_Holtermachine_hidden.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtDevRead1.Text.Trim().Replace("'", "''") + "," +
                               txtMean1.Text.Trim().Replace("'", "''") + "," + txtCorrection1.Text.Trim().Replace("'", "''") + "," + txtAccuracy1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid63"].ToString() + "','" + Perfanalysis_Holtermachine_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();

                        }
                        if (i == 1)
                        {
                            Perfanalysis_Holtermachine_hidden.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtDevRead2.Text.Trim().Replace("'", "''") + "," +
                               txtMean2.Text.Trim().Replace("'", "''") + "," + txtCorrection2.Text.Trim().Replace("'", "''") + "," + txtAccuracy2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid63"].ToString() + "','" + Perfanalysis_Holtermachine_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();

                        }
                        if (i == 2)
                        {
                            Perfanalysis_Holtermachine_hidden.Value = txtsl3.Text.Trim().Replace("'", "''") + "," + txtDevRead3.Text.Trim().Replace("'", "''") + "," +
                               txtMean3.Text.Trim().Replace("'", "''") + "," + txtCorrection3.Text.Trim().Replace("'", "''") + "," + txtAccuracy3.Text.Trim().Replace("'", "''") + "," + txtrem3.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid63"].ToString() + "','" + Perfanalysis_Holtermachine_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();

                        }
                    }
                    db1.strCommand = "select Top 3 ValueID from Performance_Values order by ValueID desc";
                    DataTable dt_valueidupdate = db1.selecttable();

                    if (dt_valueidupdate.Rows.Count > 0)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid63"].ToString() + "','" + dt_valueidupdate.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }

                    }
                }

                lblmsg.Text = "Data Updated Successfully";
                lblmsg.Style.Add("color", "green");
            }
        }
        catch
        {
            lblmsg.Text = "Data not Inserted Successfully";
            lblmsg.Style.Add("color", "red");
        }
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {

    }
}