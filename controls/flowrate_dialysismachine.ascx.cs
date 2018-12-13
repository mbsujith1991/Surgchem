using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class controls_flowrate_dialysismachine : System.Web.UI.UserControl
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
        edit_Reportid = Session["Editreportid49"];
        string perfname = Reportid;
    }

    //insert function to save performance testname to databasee
    string perfname = "";
    string perfid = "";
    public void save_performancetest()
    {
        db1.strCommand = "insert into check_perftest(PerfID,Perf_TestName) values('" + Session["perfid49"].ToString() + "','" + Session["performancename49"].ToString() + "')";
        db1.insertqry();
        perfname = Session["performancename49"].ToString();

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
                        Defibrillation.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtstd1.Text.Trim().Replace("'", "''") + "," + txtinst1.Text.Trim().Replace("'", "''") + "," +
                            txtinst2.Text.Trim().Replace("'", "''") + "," + txtinst3.Text.Trim().Replace("'", "''") + "," + txtmean1.Text.Trim().Replace("'", "''") + "," +
                            txtdev1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["perfid49"].ToString() + "','" + Defibrillation.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                    if (i == 1)
                    {
                        Defibrillation.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtstd2.Text.Trim().Replace("'", "''") + "," + txtinst4.Text.Trim().Replace("'", "''") + "," +
                            txtinst5.Text.Trim().Replace("'", "''") + "," + txtinst6.Text.Trim().Replace("'", "''") + "," + txtmean2.Text.Trim().Replace("'", "''") + "," +
                            txtdev2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["perfid49"].ToString() + "','" + Defibrillation.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                    if (i == 2)
                    {
                        Defibrillation.Value = txtsl3.Text.Trim().Replace("'", "''") + "," + txtstd3.Text.Trim().Replace("'", "''") + "," + txtinst7.Text.Trim().Replace("'", "''") + "," +
                         txtinst8.Text.Trim().Replace("'", "''") + "," + txtinst9.Text.Trim().Replace("'", "''") + "," + txtmean3.Text.Trim().Replace("'", "''") + "," +
                         txtdev3.Text.Trim().Replace("'", "''") + "," + txtrem3.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["perfid49"].ToString() + "','" + Defibrillation.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }

                }
                lblmsg.Text = "Data Inserted Successfully";
                lblmsg.Style.Add("color", "green");
            }
            else
            {
                save_performancetest();
                db1.strCommand = "select ValueID from Performance_Values where Report_info_ID='" + edit_Reportid + "' and PerfID='49'";
                DataTable dt_valueid = db1.selecttable();
                if (dt_valueid.Rows.Count > 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (i == 0)
                        {
                            string valid = dt_valueid.Rows[i]["ValueID"].ToString();
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            Defibrillation.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtstd1.Text.Trim().Replace("'", "''") + "," + txtinst1.Text.Trim().Replace("'", "''") + "," +
                           txtinst2.Text.Trim().Replace("'", "''") + "," + txtinst3.Text.Trim().Replace("'", "''") + "," + txtmean1.Text.Trim().Replace("'", "''") + "," +
                           txtdev1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");

                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["perfid49"].ToString() + "','" + Defibrillation.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 1)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            Defibrillation.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtstd2.Text.Trim().Replace("'", "''") + "," + txtinst4.Text.Trim().Replace("'", "''") + "," +
                            txtinst5.Text.Trim().Replace("'", "''") + "," + txtinst6.Text.Trim().Replace("'", "''") + "," + txtmean2.Text.Trim().Replace("'", "''") + "," +
                            txtdev2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");

                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["perfid49"].ToString() + "','" + Defibrillation.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 2)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            Defibrillation.Value = txtsl3.Text.Trim().Replace("'", "''") + "," + txtstd3.Text.Trim().Replace("'", "''") + "," + txtinst7.Text.Trim().Replace("'", "''") + "," +
                             txtinst8.Text.Trim().Replace("'", "''") + "," + txtinst9.Text.Trim().Replace("'", "''") + "," + txtmean3.Text.Trim().Replace("'", "''") + "," +
                             txtdev3.Text.Trim().Replace("'", "''") + "," + txtrem3.Text.Trim().Replace("'", "''");

                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["perfid49"].ToString() + "','" + Defibrillation.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
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
                            Defibrillation.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtstd1.Text.Trim().Replace("'", "''") + "," + txtinst1.Text.Trim().Replace("'", "''") + "," +
                           txtinst2.Text.Trim().Replace("'", "''") + "," + txtinst3.Text.Trim().Replace("'", "''") + "," + txtmean1.Text.Trim().Replace("'", "''") + "," +
                           txtdev1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["perfid49"].ToString() + "','" + Defibrillation.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 1)
                        {
                            Defibrillation.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtstd2.Text.Trim().Replace("'", "''") + "," + txtinst4.Text.Trim().Replace("'", "''") + "," +
                             txtinst5.Text.Trim().Replace("'", "''") + "," + txtinst6.Text.Trim().Replace("'", "''") + "," + txtmean2.Text.Trim().Replace("'", "''") + "," +
                             txtdev2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["perfid49"].ToString() + "','" + Defibrillation.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 2)
                        {
                            Defibrillation.Value = txtsl3.Text.Trim().Replace("'", "''") + "," + txtstd3.Text.Trim().Replace("'", "''") + "," + txtinst7.Text.Trim().Replace("'", "''") + "," +
                             txtinst8.Text.Trim().Replace("'", "''") + "," + txtinst9.Text.Trim().Replace("'", "''") + "," + txtmean3.Text.Trim().Replace("'", "''") + "," +
                             txtdev3.Text.Trim().Replace("'", "''") + "," + txtrem3.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["perfid49"].ToString() + "','" + Defibrillation.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }

                    }

                }

                lblmsg.Text = "Data Updated Successfully";
                lblmsg.Style.Add("color", "green");
            }
        }
        catch (Exception ex)
        {
            lblmsg.Text = "Data not Inserted Successfully" + ex;
            lblmsg.Style.Add("color", "red");
        }

    }
    protected void btncancel_Click(object sender, EventArgs e)
    {

    }
}