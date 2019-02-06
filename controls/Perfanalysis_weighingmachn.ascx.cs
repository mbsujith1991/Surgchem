using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class controls_Perfanalysis_weighingmachn : System.Web.UI.UserControl
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
        edit_Reportid = Session["Editreportid24"];
    }

    //insert function to save performance testname to databasee
    string perfname = "";
    string perfid = "";
    public void save_performancetest()
    {
        db1.strCommand = "insert into check_perftest(PerfID,Perf_TestName) values('" + Session["Perfid24"].ToString() + "','" + Session["performancename24"].ToString() + "')";
        db1.insertqry();
        perfname = Session["performancename24"].ToString();

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
                        perf_weighmachn_hidden.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtstdw1.Text.Trim().Replace("'", "''") + "," +
                            txtdut1.Text.Trim().Replace("'", "''") + "," + txtvaldut1.Text.Trim().Replace("'", "''") + "," +
                            txtspec1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");

                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid24"].ToString() + "','" + perf_weighmachn_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                    if (i == 1)
                    {
                        perf_weighmachn_hidden.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtstdw2.Text.Trim().Replace("'", "''") + "," +
                            txtdut2.Text.Trim().Replace("'", "''") + "," + txtvaldut2.Text.Trim().Replace("'", "''") + "," +
                            txtspec2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");

                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid24"].ToString() + "','" + perf_weighmachn_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                    if (i == 2)
                    {
                        perf_weighmachn_hidden.Value = txtsl3.Text.Trim().Replace("'", "''") + "," + txtstdw3.Text.Trim().Replace("'", "''") + "," +
                           txtdut3.Text.Trim().Replace("'", "''") + "," + txtvaldut3.Text.Trim().Replace("'", "''") + "," +
                           txtspec3.Text.Trim().Replace("'", "''") + "," + txtrem3.Text.Trim().Replace("'", "''");

                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid24"].ToString() + "','" + perf_weighmachn_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                    if (i == 3)
                    {
                        perf_weighmachn_hidden.Value = txtsl4.Text.Trim().Replace("'", "''") + "," + txtstdw4.Text.Trim().Replace("'", "''") + "," +
                           txtdut4.Text.Trim().Replace("'", "''") + "," + txtvaldut4.Text.Trim().Replace("'", "''") + "," +
                           txtspec4.Text.Trim().Replace("'", "''") + "," + txtrem4.Text.Trim().Replace("'", "''");

                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid24"].ToString() + "','" + perf_weighmachn_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                    if (i == 4)
                    {
                        perf_weighmachn_hidden.Value = txtsl5.Text.Trim().Replace("'", "''") + "," + txtstdw5.Text.Trim().Replace("'", "''") + "," +
                           txtdut5.Text.Trim().Replace("'", "''") + "," + txtvaldut5.Text.Trim().Replace("'", "''") + "," +
                           txtspec5.Text.Trim().Replace("'", "''") + "," + txtrem5.Text.Trim().Replace("'", "''");

                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid24"].ToString() + "','" + perf_weighmachn_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                    if (i == 5)
                    {
                        perf_weighmachn_hidden.Value = txtsl6.Text.Trim().Replace("'", "''") + "," + txtstdw6.Text.Trim().Replace("'", "''") + "," +
                           txtdut6.Text.Trim().Replace("'", "''") + "," + txtvaldut6.Text.Trim().Replace("'", "''") + "," +
                           txtspec6.Text.Trim().Replace("'", "''") + "," + txtrem6.Text.Trim().Replace("'", "''");

                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid24"].ToString() + "','" + perf_weighmachn_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                }
                db1.strCommand = "select Top 6 ValueID from Performance_Values order by ValueID desc";
                DataTable dt_valueid = db1.selecttable();

                if (dt_valueid.Rows.Count > 0)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid24"].ToString() + "','" + dt_valueid.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }

                }
                lblmsg.Text = "Data Inserted Successfully";
                lblmsg.Style.Add("color", "green");
            }
            else
            {
                save_performancetest();
                db1.strCommand = "select ValueID from Performance_Values where Report_info_ID='" + edit_Reportid + "' and PerfID='24'";
                DataTable dt_valueid = db1.selecttable();
                if (dt_valueid.Rows.Count > 0)
                {
                    for (int i = 0; i <6; i++)
                    {
                        if (i == 0)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            perf_weighmachn_hidden.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtstdw1.Text.Trim().Replace("'", "''") + "," +
                                txtdut1.Text.Trim().Replace("'", "''") + "," + txtvaldut1.Text.Trim().Replace("'", "''") + "," +
                                txtspec1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");

                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid24"].ToString() + "',Perf_Value='" + perf_weighmachn_hidden.Value + "'" +
                            //    " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid24"].ToString() + "','" + perf_weighmachn_hidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 1)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            perf_weighmachn_hidden.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtstdw2.Text.Trim().Replace("'", "''") + "," +
                                txtdut2.Text.Trim().Replace("'", "''") + "," + txtvaldut2.Text.Trim().Replace("'", "''") + "," +
                                txtspec2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");

                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid24"].ToString() + "',Perf_Value='" + perf_weighmachn_hidden.Value + "'" +
                            //    " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid24"].ToString() + "','" + perf_weighmachn_hidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 2)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            perf_weighmachn_hidden.Value = txtsl3.Text.Trim().Replace("'", "''") + "," + txtstdw3.Text.Trim().Replace("'", "''") + "," +
                               txtdut3.Text.Trim().Replace("'", "''") + "," + txtvaldut3.Text.Trim().Replace("'", "''") + "," +
                               txtspec3.Text.Trim().Replace("'", "''") + "," + txtrem3.Text.Trim().Replace("'", "''");

                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid24"].ToString() + "',Perf_Value='" + perf_weighmachn_hidden.Value + "'" +
                            //    " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid24"].ToString() + "','" + perf_weighmachn_hidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 3)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            perf_weighmachn_hidden.Value = txtsl4.Text.Trim().Replace("'", "''") + "," + txtstdw4.Text.Trim().Replace("'", "''") + "," +
                               txtdut4.Text.Trim().Replace("'", "''") + "," + txtvaldut4.Text.Trim().Replace("'", "''") + "," +
                               txtspec4.Text.Trim().Replace("'", "''") + "," + txtrem4.Text.Trim().Replace("'", "''");

                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid24"].ToString() + "',Perf_Value='" + perf_weighmachn_hidden.Value + "'" +
                            //    " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid24"].ToString() + "','" + perf_weighmachn_hidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 4)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            perf_weighmachn_hidden.Value = txtsl5.Text.Trim().Replace("'", "''") + "," + txtstdw5.Text.Trim().Replace("'", "''") + "," +
                               txtdut5.Text.Trim().Replace("'", "''") + "," + txtvaldut5.Text.Trim().Replace("'", "''") + "," +
                               txtspec5.Text.Trim().Replace("'", "''") + "," + txtrem5.Text.Trim().Replace("'", "''");

                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid24"].ToString() + "',Perf_Value='" + perf_weighmachn_hidden.Value + "'" +
                            //    " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid24"].ToString() + "','" + perf_weighmachn_hidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 5)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            perf_weighmachn_hidden.Value = txtsl6.Text.Trim().Replace("'", "''") + "," + txtstdw6.Text.Trim().Replace("'", "''") + "," +
                               txtdut6.Text.Trim().Replace("'", "''") + "," + txtvaldut6.Text.Trim().Replace("'", "''") + "," +
                               txtspec6.Text.Trim().Replace("'", "''") + "," + txtrem6.Text.Trim().Replace("'", "''");

                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid24"].ToString() + "',Perf_Value='" + perf_weighmachn_hidden.Value + "'" +
                            //    " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid24"].ToString() + "','" + perf_weighmachn_hidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                    }
                    if (dt_valueid.Rows.Count > 0)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid24"].ToString() + "','" + dt_valueid.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
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
                            perf_weighmachn_hidden.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtstdw1.Text.Trim().Replace("'", "''") + "," +
                                txtdut1.Text.Trim().Replace("'", "''") + "," + txtvaldut1.Text.Trim().Replace("'", "''") + "," +
                                txtspec1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");

                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid24"].ToString() + "','" + perf_weighmachn_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 1)
                        {
                            perf_weighmachn_hidden.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtstdw2.Text.Trim().Replace("'", "''") + "," +
                                txtdut2.Text.Trim().Replace("'", "''") + "," + txtvaldut2.Text.Trim().Replace("'", "''") + "," +
                                txtspec2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");

                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid24"].ToString() + "','" + perf_weighmachn_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 2)
                        {
                            perf_weighmachn_hidden.Value = txtsl3.Text.Trim().Replace("'", "''") + "," + txtstdw3.Text.Trim().Replace("'", "''") + "," +
                               txtdut3.Text.Trim().Replace("'", "''") + "," + txtvaldut3.Text.Trim().Replace("'", "''") + "," +
                               txtspec3.Text.Trim().Replace("'", "''") + "," + txtrem3.Text.Trim().Replace("'", "''");

                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid24"].ToString() + "','" + perf_weighmachn_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 3)
                        {
                            perf_weighmachn_hidden.Value = txtsl4.Text.Trim().Replace("'", "''") + "," + txtstdw4.Text.Trim().Replace("'", "''") + "," +
                               txtdut4.Text.Trim().Replace("'", "''") + "," + txtvaldut4.Text.Trim().Replace("'", "''") + "," +
                               txtspec4.Text.Trim().Replace("'", "''") + "," + txtrem4.Text.Trim().Replace("'", "''");

                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid24"].ToString() + "','" + perf_weighmachn_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 4)
                        {
                            perf_weighmachn_hidden.Value = txtsl5.Text.Trim().Replace("'", "''") + "," + txtstdw5.Text.Trim().Replace("'", "''") + "," +
                               txtdut5.Text.Trim().Replace("'", "''") + "," + txtvaldut5.Text.Trim().Replace("'", "''") + "," +
                               txtspec5.Text.Trim().Replace("'", "''") + "," + txtrem5.Text.Trim().Replace("'", "''");

                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid24"].ToString() + "','" + perf_weighmachn_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 5)
                        {
                            perf_weighmachn_hidden.Value = txtsl6.Text.Trim().Replace("'", "''") + "," + txtstdw6.Text.Trim().Replace("'", "''") + "," +
                               txtdut6.Text.Trim().Replace("'", "''") + "," + txtvaldut6.Text.Trim().Replace("'", "''") + "," +
                               txtspec6.Text.Trim().Replace("'", "''") + "," + txtrem6.Text.Trim().Replace("'", "''");

                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid24"].ToString() + "','" + perf_weighmachn_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                    }
                    db1.strCommand = "select Top 6 ValueID from Performance_Values order by ValueID desc";
                    DataTable dt_valueidupdate = db1.selecttable();

                    if (dt_valueidupdate.Rows.Count > 0)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid24"].ToString() + "','" + dt_valueidupdate.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }

                    }
                }
               
                lblmsg.Text = "Data Updated Successfully";
                lblmsg.Style.Add("color", "green");
            }
        }
        catch(Exception ex)
        {
            lblmsg.Text = "Data not Inserted Successfully"+ex;
            lblmsg.Style.Add("color", "red");
        }

    }
    protected void btncancel_Click(object sender, EventArgs e)
    {

    }
}