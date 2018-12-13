using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class BipolarMode : System.Web.UI.UserControl
{
    Dbclass db = new Dbclass();
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
        edit_Reportid = Session["Editreportid8"];
    }

    //insert function to save performance testname to databasee
    string perfname = "";
    string perfid = "";
    public void save_performancetest()
    {
        db.strCommand = "insert into check_perftest(PerfID,Perf_TestName) values('" + Session["Perfid8"].ToString() + "','" + Session["performancename8"].ToString() + "')";
        db.insertqry();
        perfname = Session["performancename8"].ToString();

    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            if (edit_Reportid == "" || edit_Reportid == null)
            {
                save_performancetest();
                for (int i = 0; i < 4; i++)
                {
                    if (i == 0)
                    {
                        BiPolar_mode.Value = txtmod1.Text.Trim().Replace("'", "''") + "," + txtsetval1.Text.Trim().Replace("'", "''") + "," +
                            txtstdres1.Text.Trim().Replace("'", "''") + "," + txtavgstd1.Text.Trim().Replace("'", "''") + "," +
                            txtdev1.Text.Trim().Replace("'", "''") + "," + txtalodev1.Text.Trim().Replace("'", "''") + "," +
                            txtrem1.Text.Trim().Replace("'", "''");
                        db.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid8"].ToString() + "','" + BiPolar_mode.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db.insertqry();
                        
                    }
                    if (i == 1)
                    {
                        BiPolar_mode.Value = txtmod2.Text.Trim().Replace("'", "''") + "," + txtsetval2.Text.Trim().Replace("'", "''") + "," +
                            txtstdres2.Text.Trim().Replace("'", "''") + "," + txtavgstd2.Text.Trim().Replace("'", "''") + "," +
                            txtdev2.Text.Trim().Replace("'", "''") + "," + txtalodev2.Text.Trim().Replace("'", "''") + "," +
                            txtrem2.Text.Trim().Replace("'", "''");
                        db.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid8"].ToString() + "','" + BiPolar_mode.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db.insertqry();
                        
                    }
                    if (i == 2)
                    {
                        BiPolar_mode.Value = txtmod3.Text.Trim().Replace("'", "''") + "," + txtsetval3.Text.Trim().Replace("'", "''") + "," +
                           txtstdres3.Text.Trim().Replace("'", "''") + "," + txtavgstd3.Text.Trim().Replace("'", "''") + "," +
                           txtdev3.Text.Trim().Replace("'", "''") + "," + txtalodev3.Text.Trim().Replace("'", "''") + "," +
                           txtrem3.Text.Trim().Replace("'", "''");
                        db.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid8"].ToString() + "','" + BiPolar_mode.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db.insertqry();
                        
                    }
                    if (i == 3)
                    {
                        BiPolar_mode.Value = txtmod4.Text.Trim().Replace("'", "''") + "," + txtsetval4.Text.Trim().Replace("'", "''") + "," +
                           txtstdres4.Text.Trim().Replace("'", "''") + "," + txtavgstd4.Text.Trim().Replace("'", "''") + "," +
                           txtdev4.Text.Trim().Replace("'", "''") + "," + txtalodev4.Text.Trim().Replace("'", "''") + "," +
                           txtrem4.Text.Trim().Replace("'", "''");
                        db.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid8"].ToString() + "','" + BiPolar_mode.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db.insertqry();
                        
                    }

                }

                db.strCommand = "select Top 4 ValueID from Performance_Values order by ValueID desc";
                DataTable dt_valueid = db.selecttable();

                if (dt_valueid.Rows.Count > 0)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        db.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid8"].ToString() + "','" + dt_valueid.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
                        db.insertqry();
                    }

                }
                lblmsg.Text = "Data Inserted Successfully";
                lblmsg.Style.Add("color", "green");
            }
            else
            {
                 save_performancetest();
                 db.strCommand = "select ValueID from Performance_Values where Report_info_ID='" + edit_Reportid + "' and PerfID='8'";
                DataTable dt_valueid = db.selecttable();
                if (dt_valueid.Rows.Count > 0)
                {
                    for (int i = 0; i < dt_valueid.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            db.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db.insertqry();
                            BiPolar_mode.Value = txtmod1.Text.Trim().Replace("'", "''") + "," + txtsetval1.Text.Trim().Replace("'", "''") + "," +
                                txtstdres1.Text.Trim().Replace("'", "''") + "," + txtavgstd1.Text.Trim().Replace("'", "''") + "," +
                                txtdev1.Text.Trim().Replace("'", "''") + "," + txtalodev1.Text.Trim().Replace("'", "''") + "," +
                                txtrem1.Text.Trim().Replace("'", "''");
                            //db.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid8"].ToString() + "',Perf_Value='" + BiPolar_mode.Value + "'" +
                            //    " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db.insertqry();
                            db.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid8"].ToString() + "','" + BiPolar_mode.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db.insertqry();
                        }
                        if (i == 1)
                        {
                            db.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db.insertqry();
                            BiPolar_mode.Value = txtmod2.Text.Trim().Replace("'", "''") + "," + txtsetval2.Text.Trim().Replace("'", "''") + "," +
                                txtstdres2.Text.Trim().Replace("'", "''") + "," + txtavgstd2.Text.Trim().Replace("'", "''") + "," +
                                txtdev2.Text.Trim().Replace("'", "''") + "," + txtalodev2.Text.Trim().Replace("'", "''") + "," +
                                txtrem2.Text.Trim().Replace("'", "''");
                            //db.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid8"].ToString() + "',Perf_Value='" + BiPolar_mode.Value + "'" +
                            //    " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db.insertqry();
                            db.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid8"].ToString() + "','" + BiPolar_mode.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db.insertqry();
                        }
                        if (i == 2)
                        {
                            db.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db.insertqry();
                            BiPolar_mode.Value = txtmod3.Text.Trim().Replace("'", "''") + "," + txtsetval3.Text.Trim().Replace("'", "''") + "," +
                               txtstdres3.Text.Trim().Replace("'", "''") + "," + txtavgstd3.Text.Trim().Replace("'", "''") + "," +
                               txtdev3.Text.Trim().Replace("'", "''") + "," + txtalodev3.Text.Trim().Replace("'", "''") + "," +
                               txtrem3.Text.Trim().Replace("'", "''");
                            //db.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid8"].ToString() + "',Perf_Value='" + BiPolar_mode.Value + "'" +
                            //    " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db.insertqry();
                            db.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid8"].ToString() + "','" + BiPolar_mode.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db.insertqry();
                        }
                        if (i == 3)
                        {
                            db.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db.insertqry();
                            BiPolar_mode.Value = txtmod4.Text.Trim().Replace("'", "''") + "," + txtsetval4.Text.Trim().Replace("'", "''") + "," +
                               txtstdres4.Text.Trim().Replace("'", "''") + "," + txtavgstd4.Text.Trim().Replace("'", "''") + "," +
                               txtdev4.Text.Trim().Replace("'", "''") + "," + txtalodev4.Text.Trim().Replace("'", "''") + "," +
                               txtrem4.Text.Trim().Replace("'", "''");
                            //db.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid8"].ToString() + "',Perf_Value='" + BiPolar_mode.Value + "'" +
                            //    " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db.insertqry();
                            db.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid8"].ToString() + "','" + BiPolar_mode.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db.insertqry();
                        }
                    }
                    if (dt_valueid.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt_valueid.Rows.Count; i++)
                        {
                            db.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid8"].ToString() + "','" + dt_valueid.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
                            db.insertqry();
                        }

                    }
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (i == 0)
                        {
                            BiPolar_mode.Value = txtmod1.Text.Trim().Replace("'", "''") + "," + txtsetval1.Text.Trim().Replace("'", "''") + "," +
                                txtstdres1.Text.Trim().Replace("'", "''") + "," + txtavgstd1.Text.Trim().Replace("'", "''") + "," +
                                txtdev1.Text.Trim().Replace("'", "''") + "," + txtalodev1.Text.Trim().Replace("'", "''") + "," +
                                txtrem1.Text.Trim().Replace("'", "''");
                            db.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid8"].ToString() + "','" + BiPolar_mode.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db.insertqry();
                        }
                        if (i == 1)
                        {
                            BiPolar_mode.Value = txtmod2.Text.Trim().Replace("'", "''") + "," + txtsetval2.Text.Trim().Replace("'", "''") + "," +
                                txtstdres2.Text.Trim().Replace("'", "''") + "," + txtavgstd2.Text.Trim().Replace("'", "''") + "," +
                                txtdev2.Text.Trim().Replace("'", "''") + "," + txtalodev2.Text.Trim().Replace("'", "''") + "," +
                                txtrem2.Text.Trim().Replace("'", "''");
                            db.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid8"].ToString() + "','" + BiPolar_mode.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db.insertqry();
                        }
                        if (i == 2)
                        {
                            BiPolar_mode.Value = txtmod3.Text.Trim().Replace("'", "''") + "," + txtsetval3.Text.Trim().Replace("'", "''") + "," +
                               txtstdres3.Text.Trim().Replace("'", "''") + "," + txtavgstd3.Text.Trim().Replace("'", "''") + "," +
                               txtdev3.Text.Trim().Replace("'", "''") + "," + txtalodev3.Text.Trim().Replace("'", "''") + "," +
                               txtrem3.Text.Trim().Replace("'", "''");
                            db.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid8"].ToString() + "','" + BiPolar_mode.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db.insertqry();
                        }
                        if (i == 3)
                        {
                            BiPolar_mode.Value = txtmod4.Text.Trim().Replace("'", "''") + "," + txtsetval4.Text.Trim().Replace("'", "''") + "," +
                               txtstdres4.Text.Trim().Replace("'", "''") + "," + txtavgstd4.Text.Trim().Replace("'", "''") + "," +
                               txtdev4.Text.Trim().Replace("'", "''") + "," + txtalodev4.Text.Trim().Replace("'", "''") + "," +
                               txtrem4.Text.Trim().Replace("'", "''");
                            db.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid8"].ToString() + "','" + BiPolar_mode.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db.insertqry();
                        }

                    }

                    db.strCommand = "select Top 4 ValueID from Performance_Values order by ValueID desc";
                    DataTable dt_valueidupdate = db.selecttable();

                    if (dt_valueidupdate.Rows.Count > 0)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            db.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid8"].ToString() + "','" + dt_valueidupdate.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
                            db.insertqry();
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