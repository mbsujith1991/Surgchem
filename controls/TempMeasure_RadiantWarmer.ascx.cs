using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class controls_TempMeasure_RadiantWarmer : System.Web.UI.UserControl
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
        edit_Reportid = Session["Editreportid19"];
    }

    //insert function to save performance testname to databasee
    string perfname = "";
    string perfid = "";
    public void save_performancetest()
    {
        db1.strCommand = "insert into check_perftest(PerfID,Perf_TestName) values('" + Session["Perfid19"].ToString() + "','" + Session["performancename19"].ToString() + "')";
        db1.insertqry();
        perfname = Session["performancename19"].ToString();

    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            if (edit_Reportid == "" || edit_Reportid == null)
            {
                save_performancetest();
                for (int i = 0; i < 2; i++)
                {
                    if (i == 0)
                    {

                        temp_measure_radiantwarmer.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtsettemp1.Text.Trim().Replace("'", "''") + "," +
                            txtdispdut1.Text.Trim().Replace("'", "''") + "," + txttempstd1.Text.Trim().Replace("'", "''") + "," +
                            txtdevsetdut1.Text.Trim().Replace("'", "''") + "," + txttempdispdut1.Text.Trim().Replace("'", "''") + "," +
                            txtspecdisp1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid19"].ToString() + "','" + temp_measure_radiantwarmer.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                    if (i == 1)
                    {
                        temp_measure_radiantwarmer.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtsettemp2.Text.Trim().Replace("'", "''") + "," +
                            txtdispdut2.Text.Trim().Replace("'", "''") + "," + txttempstd2.Text.Trim().Replace("'", "''") + "," +
                            txtdevsetdut2.Text.Trim().Replace("'", "''") + "," + txttempdispdut2.Text.Trim().Replace("'", "''") + "," +
                            txtspecdisp2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid19"].ToString() + "','" + temp_measure_radiantwarmer.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                }

                db1.strCommand = "select Top 2 ValueID from Performance_Values order by ValueID desc";
                DataTable dt_valueid = db1.selecttable();

                if (dt_valueid.Rows.Count > 0)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid19"].ToString() + "','" + dt_valueid.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }

                }
                lblmsg.Text = "Data Inserted Successfully";
                lblmsg.Style.Add("color", "green");
            }
            else
            {
                save_performancetest();
                db1.strCommand = "select ValueID from Performance_Values where Report_info_ID='" + edit_Reportid + "' and PerfID='19'";
                DataTable dt_valueid = db1.selecttable();
                if (dt_valueid.Rows.Count > 0)
                {
                    for (int i = 0; i < dt_valueid.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            temp_measure_radiantwarmer.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtsettemp1.Text.Trim().Replace("'", "''") + "," +
                                txtdispdut1.Text.Trim().Replace("'", "''") + "," + txttempstd1.Text.Trim().Replace("'", "''") + "," +
                                txtdevsetdut1.Text.Trim().Replace("'", "''") + "," + txttempdispdut1.Text.Trim().Replace("'", "''") + "," +
                                txtspecdisp1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");
                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid19"].ToString() + "',Perf_Value='" + temp_measure_radiantwarmer.Value + "'" +
                            //     " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid19"].ToString() + "','" + temp_measure_radiantwarmer.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 1)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            temp_measure_radiantwarmer.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtsettemp2.Text.Trim().Replace("'", "''") + "," +
                                txtdispdut2.Text.Trim().Replace("'", "''") + "," + txttempstd2.Text.Trim().Replace("'", "''") + "," +
                                txtdevsetdut2.Text.Trim().Replace("'", "''") + "," + txttempdispdut2.Text.Trim().Replace("'", "''") + "," +
                                txtspecdisp2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");
                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid19"].ToString() + "',Perf_Value='" + temp_measure_radiantwarmer.Value + "'" +
                            //     " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid19"].ToString() + "','" + temp_measure_radiantwarmer.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                    }
                    if (dt_valueid.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt_valueid.Rows.Count; i++)
                        {
                            db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid19"].ToString() + "','" + dt_valueid.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }

                    }
                }
                else
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (i == 0)
                        {

                            temp_measure_radiantwarmer.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtsettemp1.Text.Trim().Replace("'", "''") + "," +
                                txtdispdut1.Text.Trim().Replace("'", "''") + "," + txttempstd1.Text.Trim().Replace("'", "''") + "," +
                                txtdevsetdut1.Text.Trim().Replace("'", "''") + "," + txttempdispdut1.Text.Trim().Replace("'", "''") + "," +
                                txtspecdisp1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid19"].ToString() + "','" + temp_measure_radiantwarmer.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 1)
                        {
                            temp_measure_radiantwarmer.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtsettemp2.Text.Trim().Replace("'", "''") + "," +
                                txtdispdut2.Text.Trim().Replace("'", "''") + "," + txttempstd2.Text.Trim().Replace("'", "''") + "," +
                                txtdevsetdut2.Text.Trim().Replace("'", "''") + "," + txttempdispdut2.Text.Trim().Replace("'", "''") + "," +
                                txtspecdisp2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid19"].ToString() + "','" + temp_measure_radiantwarmer.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                    }

                    db1.strCommand = "select Top 2 ValueID from Performance_Values order by ValueID desc";
                    DataTable dt_valueidupdate = db1.selecttable();

                    if (dt_valueidupdate.Rows.Count > 0)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid19"].ToString() + "','" + dt_valueidupdate.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
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