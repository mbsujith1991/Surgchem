﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class controls_Temperatureguage : System.Web.UI.UserControl
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
    string perfname = "";
    string perfid = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        edit_Reportid = Session["Editreportid54"];
    }


    protected void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            if (edit_Reportid == "" || edit_Reportid == null)
            {

                for (int i = 0; i < 3; i++)
                {
                    if (i == 0)
                    {
                        flow_hidden.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtdut1.Text.Trim().Replace("'", "''") + "," +
                            txtstd1.Text.Trim().Replace("'", "''") + "," + txtval1.Text.Trim().Replace("'", "''") + "," +
                            txtalodev1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid54"].ToString() + "','" + flow_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                    if (i == 1)
                    {
                        flow_hidden.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtdut2.Text.Trim().Replace("'", "''") + "," +
                            txtstd2.Text.Trim().Replace("'", "''") + "," + txtval2.Text.Trim().Replace("'", "''") + "," +
                            txtalodev2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid54"].ToString() + "','" + flow_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }

                }

                lblmsg.Text = "Data Inserted Successfully";
                lblmsg.Style.Add("color", "green");
            }
            else
            {

                db1.strCommand = "select ValueID from Performance_Values where Report_info_ID='" + edit_Reportid + "' and PerfID='54'";
                DataTable dt_valueid = db1.selecttable();
                if (dt_valueid.Rows.Count > 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (i == 0)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            flow_hidden.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtdut1.Text.Trim().Replace("'", "''") + "," +
                                txtstd1.Text.Trim().Replace("'", "''") + "," + txtval1.Text.Trim().Replace("'", "''") + "," +
                                txtalodev1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");

                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid54"].ToString() + "','" + flow_hidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }

                        if (i == 1)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            flow_hidden.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtdut2.Text.Trim().Replace("'", "''") + "," +
                                txtstd2.Text.Trim().Replace("'", "''") + "," + txtval2.Text.Trim().Replace("'", "''") + "," +
                                txtalodev2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");

                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid54"].ToString() + "','" + flow_hidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
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
                            flow_hidden.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtdut1.Text.Trim().Replace("'", "''") + "," +
                                txtstd1.Text.Trim().Replace("'", "''") + "," + txtval1.Text.Trim().Replace("'", "''") + "," +
                                txtalodev1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid54"].ToString() + "','" + flow_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 1)
                        {
                            flow_hidden.Value = txtsl2.Text.Trim().Replace("'", "''") + "," + txtdut2.Text.Trim().Replace("'", "''") + "," +
                                txtstd2.Text.Trim().Replace("'", "''") + "," + txtval2.Text.Trim().Replace("'", "''") + "," +
                                txtalodev2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid54"].ToString() + "','" + flow_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
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
            lblmsg.Text = "Data not Inserted Successfully " + ex;
            lblmsg.Style.Add("color", "red");
        }

    }
    protected void btncancel_Click(object sender, EventArgs e)
    {

    }
}