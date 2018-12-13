using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class controls_PerfAnalysis_Anasthesiamachine : System.Web.UI.UserControl
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
        edit_Reportid = Session["Editreportid11"];
    }

    //insert function to save performance testname to databasee
    string perfname = "";
    string perfid = "";
    public void save_performancetest()
    {
        db1.strCommand = "insert into check_perftest(PerfID,Perf_TestName) values('" + Session["Perfid11"].ToString() + "','" + Session["performancename11"].ToString() + "')";
        db1.insertqry();
        perfname = Session["performancename11"].ToString();

    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            if (edit_Reportid == "" || edit_Reportid == null)
            {
                save_performancetest();
                for (int i = 0; i < 6; i++)
                {
                    if (i == 0)
                    {
                        PerformanceAnalysisAnasthesia.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtpara1.Text.Trim().Replace("'", "''") + "," +
                            txtstddut1.Text.Trim().Replace("'", "''") + "," + txtavgstd1.Text.Trim().Replace("'", "''") + "," +
                            txtdev1.Text.Trim().Replace("'", "''") + "," + txtalodev1.Text.Trim().Replace("'", "''") + "," +
                            txtrem1.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid11"].ToString() + "','" + PerformanceAnalysisAnasthesia.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                    if (i == 1)
                    {
                        PerformanceAnalysisAnasthesia.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtpara2.Text.Trim().Replace("'", "''") + "," +
                            txtstddut2.Text.Trim().Replace("'", "''") + "," + txtavgstd2.Text.Trim().Replace("'", "''") + "," +
                            txtdev2.Text.Trim().Replace("'", "''") + "," + txtalodev2.Text.Trim().Replace("'", "''") + "," +
                            txtrem2.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid11"].ToString() + "','" + PerformanceAnalysisAnasthesia.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                    if (i == 2)
                    {
                        PerformanceAnalysisAnasthesia.Value = txtsl3.Text.Trim().Replace("'", "''") + "," + txtpara3.Text.Trim().Replace("'", "''") + "," +
                           txtstddut3.Text.Trim().Replace("'", "''") + "," + txtavgstd3.Text.Trim().Replace("'", "''") + "," +
                           txtdev3.Text.Trim().Replace("'", "''") + "," + txtalodev3.Text.Trim().Replace("'", "''") + "," +
                           txtrem3.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid11"].ToString() + "','" + PerformanceAnalysisAnasthesia.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                    if (i == 3)
                    {
                        PerformanceAnalysisAnasthesia.Value = txtsl4.Text.Trim().Replace("'", "''") + "," + txtpara4.Text.Trim().Replace("'", "''") + "," +
                           txtstddut4.Text.Trim().Replace("'", "''") + "," + txtavgstd4.Text.Trim().Replace("'", "''") + "," +
                           txtdev4.Text.Trim().Replace("'", "''") + "," + txtalodev4.Text.Trim().Replace("'", "''") + "," +
                           txtrem4.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid11"].ToString() + "','" + PerformanceAnalysisAnasthesia.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                    if (i == 4)
                    {
                        PerformanceAnalysisAnasthesia.Value = txtsl5.Text.Trim().Replace("'", "''") + "," + txtpara5.Text.Trim().Replace("'", "''") + "," +
                           txtstddut5.Text.Trim().Replace("'", "''") + "," + txtavgstd5.Text.Trim().Replace("'", "''") + "," +
                           txtdev5.Text.Trim().Replace("'", "''") + "," + txtalodev5.Text.Trim().Replace("'", "''") + "," +
                           txtrem5.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid11"].ToString() + "','" + PerformanceAnalysisAnasthesia.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                    if (i == 5)
                    {
                        PerformanceAnalysisAnasthesia.Value = txtsl6.Text.Trim().Replace("'", "''") + "," + txtpara6.Text.Trim().Replace("'", "''") + "," +
                           txtstddut6.Text.Trim().Replace("'", "''") + "," + txtavgstd6.Text.Trim().Replace("'", "''") + "," +
                           txtdev6.Text.Trim().Replace("'", "''") + "," + txtalodev6.Text.Trim().Replace("'", "''") + "," +
                           txtrem6.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid11"].ToString() + "','" + PerformanceAnalysisAnasthesia.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                }
                db1.strCommand = "select Top 6 ValueID from Performance_Values order by ValueID desc";
                DataTable dt_valueid = db1.selecttable();

                if (dt_valueid.Rows.Count > 0)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid11"].ToString() + "','" + dt_valueid.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }

                }
                lblmsg.Text = "Data Inserted Successfully";
                lblmsg.Style.Add("color", "green");
            }
            else
            {
                save_performancetest();
                db1.strCommand = "select ValueID from Performance_Values where Report_info_ID='" + edit_Reportid + "' and PerfID='11'";
                DataTable dt_valueid = db1.selecttable();
                if (dt_valueid.Rows.Count > 0)
                {
                    for (int i = 0; i < dt_valueid.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            PerformanceAnalysisAnasthesia.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtpara1.Text.Trim().Replace("'", "''") + "," +
                                txtstddut1.Text.Trim().Replace("'", "''") + "," + txtavgstd1.Text.Trim().Replace("'", "''") + "," +
                                txtdev1.Text.Trim().Replace("'", "''") + "," + txtalodev1.Text.Trim().Replace("'", "''") + "," +
                                txtrem1.Text.Trim().Replace("'", "''");
                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid11"].ToString() + "',Perf_Value='" + PerformanceAnalysisAnasthesia.Value + "'" +
                            //        " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //    db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid11"].ToString() + "','" + PerformanceAnalysisAnasthesia.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 1)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            PerformanceAnalysisAnasthesia.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtpara2.Text.Trim().Replace("'", "''") + "," +
                                txtstddut2.Text.Trim().Replace("'", "''") + "," + txtavgstd2.Text.Trim().Replace("'", "''") + "," +
                                txtdev2.Text.Trim().Replace("'", "''") + "," + txtalodev2.Text.Trim().Replace("'", "''") + "," +
                                txtrem2.Text.Trim().Replace("'", "''");
                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid11"].ToString() + "',Perf_Value='" + PerformanceAnalysisAnasthesia.Value + "'" +
                            //        " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //    db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid11"].ToString() + "','" + PerformanceAnalysisAnasthesia.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 2)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            PerformanceAnalysisAnasthesia.Value = txtsl3.Text.Trim().Replace("'", "''") + "," + txtpara3.Text.Trim().Replace("'", "''") + "," +
                               txtstddut3.Text.Trim().Replace("'", "''") + "," + txtavgstd3.Text.Trim().Replace("'", "''") + "," +
                               txtdev3.Text.Trim().Replace("'", "''") + "," + txtalodev3.Text.Trim().Replace("'", "''") + "," +
                               txtrem3.Text.Trim().Replace("'", "''");
                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid11"].ToString() + "',Perf_Value='" + PerformanceAnalysisAnasthesia.Value + "'" +
                            //        " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //    db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid11"].ToString() + "','" + PerformanceAnalysisAnasthesia.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 3)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            PerformanceAnalysisAnasthesia.Value = txtsl4.Text.Trim().Replace("'", "''") + "," + txtpara4.Text.Trim().Replace("'", "''") + "," +
                               txtstddut4.Text.Trim().Replace("'", "''") + "," + txtavgstd4.Text.Trim().Replace("'", "''") + "," +
                               txtdev4.Text.Trim().Replace("'", "''") + "," + txtalodev4.Text.Trim().Replace("'", "''") + "," +
                               txtrem4.Text.Trim().Replace("'", "''");
                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid11"].ToString() + "',Perf_Value='" + PerformanceAnalysisAnasthesia.Value + "'" +
                            //        " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //    db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid11"].ToString() + "','" + PerformanceAnalysisAnasthesia.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 4)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            PerformanceAnalysisAnasthesia.Value = txtsl5.Text.Trim().Replace("'", "''") + "," + txtpara5.Text.Trim().Replace("'", "''") + "," +
                               txtstddut5.Text.Trim().Replace("'", "''") + "," + txtavgstd5.Text.Trim().Replace("'", "''") + "," +
                               txtdev5.Text.Trim().Replace("'", "''") + "," + txtalodev5.Text.Trim().Replace("'", "''") + "," +
                               txtrem5.Text.Trim().Replace("'", "''");
                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid11"].ToString() + "',Perf_Value='" + PerformanceAnalysisAnasthesia.Value + "'" +
                            //        " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //    db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid11"].ToString() + "','" + PerformanceAnalysisAnasthesia.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 5)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            PerformanceAnalysisAnasthesia.Value = txtsl6.Text.Trim().Replace("'", "''") + "," + txtpara6.Text.Trim().Replace("'", "''") + "," +
                               txtstddut6.Text.Trim().Replace("'", "''") + "," + txtavgstd6.Text.Trim().Replace("'", "''") + "," +
                               txtdev6.Text.Trim().Replace("'", "''") + "," + txtalodev6.Text.Trim().Replace("'", "''") + "," +
                               txtrem6.Text.Trim().Replace("'", "''");
                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid11"].ToString() + "',Perf_Value='" + PerformanceAnalysisAnasthesia.Value + "'" +
                            //        " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //    db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid11"].ToString() + "','" + PerformanceAnalysisAnasthesia.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }

                    }
                    if (dt_valueid.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt_valueid.Rows.Count; i++)
                        {
                            db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid11"].ToString() + "','" + dt_valueid.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }

                    }
                }
                else
                {
                    for (int i = 0; i < 6; i++)
                    {
                        if (i == 0)
                        {
                            PerformanceAnalysisAnasthesia.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtpara1.Text.Trim().Replace("'", "''") + "," +
                                txtstddut1.Text.Trim().Replace("'", "''") + "," + txtavgstd1.Text.Trim().Replace("'", "''") + "," +
                                txtdev1.Text.Trim().Replace("'", "''") + "," + txtalodev1.Text.Trim().Replace("'", "''") + "," +
                                txtrem1.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid11"].ToString() + "','" + PerformanceAnalysisAnasthesia.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 1)
                        {
                            PerformanceAnalysisAnasthesia.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtpara2.Text.Trim().Replace("'", "''") + "," +
                                txtstddut2.Text.Trim().Replace("'", "''") + "," + txtavgstd2.Text.Trim().Replace("'", "''") + "," +
                                txtdev2.Text.Trim().Replace("'", "''") + "," + txtalodev2.Text.Trim().Replace("'", "''") + "," +
                                txtrem2.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid11"].ToString() + "','" + PerformanceAnalysisAnasthesia.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 2)
                        {
                            PerformanceAnalysisAnasthesia.Value = txtsl3.Text.Trim().Replace("'", "''") + "," + txtpara3.Text.Trim().Replace("'", "''") + "," +
                               txtstddut3.Text.Trim().Replace("'", "''") + "," + txtavgstd3.Text.Trim().Replace("'", "''") + "," +
                               txtdev3.Text.Trim().Replace("'", "''") + "," + txtalodev3.Text.Trim().Replace("'", "''") + "," +
                               txtrem3.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid11"].ToString() + "','" + PerformanceAnalysisAnasthesia.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 3)
                        {
                            PerformanceAnalysisAnasthesia.Value = txtsl4.Text.Trim().Replace("'", "''") + "," + txtpara4.Text.Trim().Replace("'", "''") + "," +
                               txtstddut4.Text.Trim().Replace("'", "''") + "," + txtavgstd4.Text.Trim().Replace("'", "''") + "," +
                               txtdev4.Text.Trim().Replace("'", "''") + "," + txtalodev4.Text.Trim().Replace("'", "''") + "," +
                               txtrem4.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid11"].ToString() + "','" + PerformanceAnalysisAnasthesia.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 4)
                        {
                            PerformanceAnalysisAnasthesia.Value = txtsl5.Text.Trim().Replace("'", "''") + "," + txtpara5.Text.Trim().Replace("'", "''") + "," +
                               txtstddut5.Text.Trim().Replace("'", "''") + "," + txtavgstd5.Text.Trim().Replace("'", "''") + "," +
                               txtdev5.Text.Trim().Replace("'", "''") + "," + txtalodev5.Text.Trim().Replace("'", "''") + "," +
                               txtrem5.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid11"].ToString() + "','" + PerformanceAnalysisAnasthesia.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 5)
                        {
                            PerformanceAnalysisAnasthesia.Value = txtsl6.Text.Trim().Replace("'", "''") + "," + txtpara6.Text.Trim().Replace("'", "''") + "," +
                               txtstddut6.Text.Trim().Replace("'", "''") + "," + txtavgstd6.Text.Trim().Replace("'", "''") + "," +
                               txtdev6.Text.Trim().Replace("'", "''") + "," + txtalodev6.Text.Trim().Replace("'", "''") + "," +
                               txtrem6.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid11"].ToString() + "','" + PerformanceAnalysisAnasthesia.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                    }
                    db1.strCommand = "select Top 6 ValueID from Performance_Values order by ValueID desc";
                    DataTable dt_valueidupdate = db1.selecttable();

                    if (dt_valueidupdate.Rows.Count > 0)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid11"].ToString() + "','" + dt_valueidupdate.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
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