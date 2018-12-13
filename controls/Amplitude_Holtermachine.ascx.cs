using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class controls_Amplitude_Holtermachine : System.Web.UI.UserControl
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
        edit_Reportid = Session["Editreportid22"];
    }

    //insert function to save performance testname to databasee
    string perfname = "";
    string perfid = "";
    public void save_performancetest()
    {
        db1.strCommand = "insert into check_perftest(PerfID,Perf_TestName) values('" + Session["Perfid22"].ToString() + "','" + Session["performancename22"].ToString() + "')";
        db1.insertqry();
        perfname = Session["performancename22"].ToString();

    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            if (edit_Reportid == "" || edit_Reportid == null)
            {
                save_performancetest();
                for (int i = 0; i < 1; i++)
                {
                    if (i == 0)
                    {
                        amplitude_hidden.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtpara.Text.Trim().Replace("'", "''") + "," +
                            txtsetstd1.Text.Trim().Replace("'", "''") + "," + txtsetstd2.Text.Trim().Replace("'", "''") + "," +
                            txtdut.Text.Trim().Replace("'", "''") + "," + txtspec.Text.Trim().Replace("'", "''") + "," +
                            txtrem.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid22"].ToString() + "','" + amplitude_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }

                }

                db1.strCommand = "select Top 1 ValueID from Performance_Values order by ValueID desc";
                DataTable dt_valueid = db1.selecttable();

                if (dt_valueid.Rows.Count > 0)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid22"].ToString() + "','" + dt_valueid.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }

                }
                lblmsg.Text = "Data Inserted Successfully";
                lblmsg.Style.Add("color", "green");
            }
            else
            {
               save_performancetest();
               db1.strCommand = "select ValueID from Performance_Values where Report_info_ID='" + edit_Reportid + "' and PerfID='22'";
                DataTable dt_valueid = db1.selecttable();
                if (dt_valueid.Rows.Count > 0)
                {
                    for (int i = 0; i < dt_valueid.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            amplitude_hidden.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtpara.Text.Trim().Replace("'", "''") + "," +
                                txtsetstd1.Text.Trim().Replace("'", "''") + "," + txtsetstd2.Text.Trim().Replace("'", "''") + "," +
                                txtdut.Text.Trim().Replace("'", "''") + "," + txtspec.Text.Trim().Replace("'", "''") + "," +
                                txtrem.Text.Trim().Replace("'", "''");
                            //db1.strCommand="Update Performance_Values set PerfID='"+Session["Perfid22"].ToString()+"',Perf_Value='" + amplitude_hidden.Value + "'"+
                            //    " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid22"].ToString() + "','" + amplitude_hidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }

                    }
                    if (dt_valueid.Rows.Count > 0)
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid22"].ToString() + "','" + dt_valueid.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }

                    }
                }
                else
                {
                    for (int i = 0; i < 1; i++)
                    {
                        if (i == 0)
                        {
                            amplitude_hidden.Value = txtsl1.Text.Trim().Replace("'", "''") + "," + txtpara.Text.Trim().Replace("'", "''") + "," +
                                txtsetstd1.Text.Trim().Replace("'", "''") + "," + txtsetstd2.Text.Trim().Replace("'", "''") + "," +
                                txtdut.Text.Trim().Replace("'", "''") + "," + txtspec.Text.Trim().Replace("'", "''") + "," +
                                txtrem.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid22"].ToString() + "','" + amplitude_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }

                    }

                    db1.strCommand = "select Top 1 ValueID from Performance_Values order by ValueID desc";
                    DataTable dt_valueidupdate = db1.selecttable();

                    if (dt_valueidupdate.Rows.Count > 0)
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid22"].ToString() + "','" + dt_valueidupdate.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
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
            lblmsg.Text = "Data Not Inserted";
        }
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {

    }
}