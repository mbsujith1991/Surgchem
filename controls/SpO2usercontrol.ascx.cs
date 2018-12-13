using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class testfolder_SpO2usercontrol : System.Web.UI.UserControl
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
        edit_Reportid = Session["Editreportid2"];
    }


    //insert function to save performance testname to databasee
    string perfname = "";
    string perfid = "";
    public void save_performancetest()
    {
        db1.strCommand = "insert into check_perftest(PerfID,Perf_TestName) values('" + Session["Perfid2"].ToString() + "','" + Session["performancename2"].ToString() + "')";
        db1.insertqry();
        perfname = Session["performancename2"].ToString();

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
                        perf_valueHidden.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtstdspo2_1.Text.Trim().Replace("'", "''") + "," +
                            txtstdhrate1.Text.Trim().Replace("'", "''") + "," + txtdutspo2_1.Text.Trim().Replace("'", "''") + "," +
                            txtduthrate1.Text.Trim().Replace("'", "''") + "," + txtdevspo2_1.Text.Trim().Replace("'", "''") + "," +
                            txtdevhrate1.Text.Trim().Replace("'", "''") + "," + txtspecspo2_1.Text.Trim().Replace("'", "''") + "," +
                            txtspechrate1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid2"].ToString() + "','" + perf_valueHidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                    if (i == 1)
                    {
                        perf_valueHidden.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtstdspo2_2.Text.Trim().Replace("'", "''") + "," +
                            txtstdhrate2.Text.Trim().Replace("'", "''") + "," + txtdutspo2_2.Text.Trim().Replace("'", "''") + "," +
                            txtduthrate2.Text.Trim().Replace("'", "''") + "," + txtdevspo2_2.Text.Trim().Replace("'", "''") + "," +
                            txtdevhrate2.Text.Trim().Replace("'", "''") + "," + txtspecspo2_2.Text.Trim().Replace("'", "''") + "," +
                            txtspechrate2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid2"].ToString() + "','" + perf_valueHidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                    if (i == 2)
                    {
                        perf_valueHidden.Value = txtsl3.Text.Trim().Replace("'", "''") + "," + txtstdspo2_3.Text.Trim().Replace("'", "''") + "," +
                            txtstdhrate3.Text.Trim().Replace("'", "''") + "," + txtdutspo2_3.Text.Trim().Replace("'", "''") + "," +
                            txtduthrate3.Text.Trim().Replace("'", "''") + "," + txtdevspo2_3.Text.Trim().Replace("'", "''") + "," +
                            txtdevhrate3.Text.Trim().Replace("'", "''") + "," + txtspecspo2_3.Text.Trim().Replace("'", "''") + "," +
                            txtspechrate3.Text.Trim().Replace("'", "''") + "," + txtrem3.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid2"].ToString() + "','" + perf_valueHidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                }
                db1.strCommand = "select Top 3 ValueID from Performance_Values order by ValueID desc";
                DataTable dt_valueid = db1.selecttable();

                if (dt_valueid.Rows.Count > 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid2"].ToString() + "','" + dt_valueid.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }

                }
                lblmsg.Text = "Data Inserted Successfully";
                lblmsg.Style.Add("color", "green");
            }
            else
            {
                save_performancetest();
                db1.strCommand = "select ValueID from Performance_Values where Report_info_ID='" + edit_Reportid + "' and PerfID='2'";
                DataTable dt_valueid = db1.selecttable();
                if (dt_valueid.Rows.Count > 0)
                {
                    for (int i = 0; i < dt_valueid.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            perf_valueHidden.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtstdspo2_1.Text.Trim().Replace("'", "''") + "," +
                                txtstdhrate1.Text.Trim().Replace("'", "''") + "," + txtdutspo2_1.Text.Trim().Replace("'", "''") + "," +
                                txtduthrate1.Text.Trim().Replace("'", "''") + "," + txtdevspo2_1.Text.Trim().Replace("'", "''") + "," +
                                txtdevhrate1.Text.Trim().Replace("'", "''") + "," + txtspecspo2_1.Text.Trim().Replace("'", "''") + "," +
                                txtspechrate1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");
                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid2"].ToString() + "',Perf_Value='" + perf_valueHidden.Value + "'" +
                            //     " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid2"].ToString() + "','" + perf_valueHidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 1)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            perf_valueHidden.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtstdspo2_2.Text.Trim().Replace("'", "''") + "," +
                                txtstdhrate2.Text.Trim().Replace("'", "''") + "," + txtdutspo2_2.Text.Trim().Replace("'", "''") + "," +
                                txtduthrate2.Text.Trim().Replace("'", "''") + "," + txtdevspo2_2.Text.Trim().Replace("'", "''") + "," +
                                txtdevhrate2.Text.Trim().Replace("'", "''") + "," + txtspecspo2_2.Text.Trim().Replace("'", "''") + "," +
                                txtspechrate2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");
                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid2"].ToString() + "',Perf_Value='" + perf_valueHidden.Value + "'" +
                            //     " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid2"].ToString() + "','" + perf_valueHidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 2)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            perf_valueHidden.Value = txtsl3.Text.Trim().Replace("'", "''") + "," + txtstdspo2_3.Text.Trim().Replace("'", "''") + "," +
                                txtstdhrate3.Text.Trim().Replace("'", "''") + "," + txtdutspo2_3.Text.Trim().Replace("'", "''") + "," +
                                txtduthrate3.Text.Trim().Replace("'", "''") + "," + txtdevspo2_3.Text.Trim().Replace("'", "''") + "," +
                                txtdevhrate3.Text.Trim().Replace("'", "''") + "," + txtspecspo2_3.Text.Trim().Replace("'", "''") + "," +
                                txtspechrate3.Text.Trim().Replace("'", "''") + "," + txtrem3.Text.Trim().Replace("'", "''");
                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid2"].ToString() + "',Perf_Value='" + perf_valueHidden.Value + "'" +
                            //     " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid2"].ToString() + "','" + perf_valueHidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                    }
                    if (dt_valueid.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt_valueid.Rows.Count; i++)
                        {
                            db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid2"].ToString() + "','" + dt_valueid.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
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
                            perf_valueHidden.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtstdspo2_1.Text.Trim().Replace("'", "''") + "," +
                                txtstdhrate1.Text.Trim().Replace("'", "''") + "," + txtdutspo2_1.Text.Trim().Replace("'", "''") + "," +
                                txtduthrate1.Text.Trim().Replace("'", "''") + "," + txtdevspo2_1.Text.Trim().Replace("'", "''") + "," +
                                txtdevhrate1.Text.Trim().Replace("'", "''") + "," + txtspecspo2_1.Text.Trim().Replace("'", "''") + "," +
                                txtspechrate1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid2"].ToString() + "','" + perf_valueHidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 1)
                        {
                            perf_valueHidden.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtstdspo2_2.Text.Trim().Replace("'", "''") + "," +
                                txtstdhrate2.Text.Trim().Replace("'", "''") + "," + txtdutspo2_2.Text.Trim().Replace("'", "''") + "," +
                                txtduthrate2.Text.Trim().Replace("'", "''") + "," + txtdevspo2_2.Text.Trim().Replace("'", "''") + "," +
                                txtdevhrate2.Text.Trim().Replace("'", "''") + "," + txtspecspo2_2.Text.Trim().Replace("'", "''") + "," +
                                txtspechrate2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid2"].ToString() + "','" + perf_valueHidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 2)
                        {
                            perf_valueHidden.Value = txtsl3.Text.Trim().Replace("'", "''") + "," + txtstdspo2_3.Text.Trim().Replace("'", "''") + "," +
                                txtstdhrate3.Text.Trim().Replace("'", "''") + "," + txtdutspo2_3.Text.Trim().Replace("'", "''") + "," +
                                txtduthrate3.Text.Trim().Replace("'", "''") + "," + txtdevspo2_3.Text.Trim().Replace("'", "''") + "," +
                                txtdevhrate3.Text.Trim().Replace("'", "''") + "," + txtspecspo2_3.Text.Trim().Replace("'", "''") + "," +
                                txtspechrate3.Text.Trim().Replace("'", "''") + "," + txtrem3.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid2"].ToString() + "','" + perf_valueHidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                    }
                    db1.strCommand = "select Top 3 ValueID from Performance_Values order by ValueID desc";
                    DataTable dt_valueidupdate = db1.selecttable();

                    if (dt_valueidupdate.Rows.Count > 0)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid2"].ToString() + "','" + dt_valueidupdate.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
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