using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class controls_PressMeas_Endoflator : System.Web.UI.UserControl
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
        edit_Reportid = Session["Editreportid46"];
    }

    //insert function to save performance testname to databasee
    string perfname = "";
    string perfid = "";
    public void save_performancetest()
    {
        db1.strCommand = "insert into check_perftest(PerfID,Perf_TestName) values('" + Session["Perfid46"].ToString() + "','" + Session["performancename46"].ToString() + "')";
        db1.insertqry();
        perfname = Session["performancename46"].ToString();

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
                        acctest_stringehidden.Value = txtslno1.Text.Trim().Replace("'", "''") + "," + txtstddut1.Text.Trim().Replace("'", "''") + "," +
                            txtinstnt1.Text.Trim().Replace("'", "''") + "," + txtinstnt2.Text.Trim().Replace("'", "''") + "," +
                            txtinstnt3.Text.Trim().Replace("'", "''") + "," + txtinstnt4.Text.Trim().Replace("'", "''") + "," +
                            txtinstnt5.Text.Trim().Replace("'", "''") + "," + txtmean1.Text.Trim().Replace("'", "''") + "," +
                            txtdevml1.Text.Trim().Replace("'", "''") + "," +
                            txtspec1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid46"].ToString() + "','" + acctest_stringehidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                    if (i == 1)
                    {
                        acctest_stringehidden.Value = txtslno2.Text.Trim().Replace("'", "''") + "," + txtdutstd2.Text.Trim().Replace("'", "''") + "," +
                            txtinstnt6.Text.Trim().Replace("'", "''") + "," + txtinstnt7.Text.Trim().Replace("'", "''") + "," +
                            txtinstnt8.Text.Trim().Replace("'", "''") + "," + txtinstnt9.Text.Trim().Replace("'", "''") + "," +
                            txtinstnt10.Text.Trim().Replace("'", "''") + "," + txtmean2.Text.Trim().Replace("'", "''") + "," +
                            txtdevml2.Text.Trim().Replace("'", "''") + "," +
                            txtspec2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid46"].ToString() + "','" + acctest_stringehidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                    if (i == 2)
                    {
                        acctest_stringehidden.Value = txtslno3.Text.Trim().Replace("'", "''") + "," + txtstddut3.Text.Trim().Replace("'", "''") + "," +
                            txtinstnt11.Text.Trim().Replace("'", "''") + "," + txtinstnt12.Text.Trim().Replace("'", "''") + "," +
                            txtinstnt13.Text.Trim().Replace("'", "''") + "," + txtinstnt14.Text.Trim().Replace("'", "''") + "," +
                            txtinstnt15.Text.Trim().Replace("'", "''") + "," + txtmean3.Text.Trim().Replace("'", "''") + "," +
                            txtdevml3.Text.Trim().Replace("'", "''") + "," +
                            txtspec3.Text.Trim().Replace("'", "''") + "," + txtrem3.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid46"].ToString() + "','" + acctest_stringehidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                }

                db1.strCommand = "select Top 3 ValueID from Performance_Values order by ValueID desc";
                DataTable dt_valueid = db1.selecttable();

                if (dt_valueid.Rows.Count > 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid46"].ToString() + "','" + dt_valueid.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }

                }
                lblmsg.Text = "Data Inserted Successfully";
                lblmsg.Style.Add("color", "green");
            }
            else
            {
                save_performancetest();
                db1.strCommand = "select ValueID from Performance_Values where Report_info_ID='" + edit_Reportid + "' and PerfID='46'";
                DataTable dt_valueid = db1.selecttable();
                if (dt_valueid.Rows.Count > 0)
                {
                    for (int i = 0; i < dt_valueid.Rows.Count; i++)
                    {

                        if (i == 0)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            acctest_stringehidden.Value = txtslno1.Text.Trim().Replace("'", "''") + "," + txtstddut1.Text.Trim().Replace("'", "''") + "," +
                                txtinstnt1.Text.Trim().Replace("'", "''") + "," + txtinstnt2.Text.Trim().Replace("'", "''") + "," +
                                txtinstnt3.Text.Trim().Replace("'", "''") + "," + txtinstnt4.Text.Trim().Replace("'", "''") + "," +
                                txtinstnt5.Text.Trim().Replace("'", "''") + "," + txtmean1.Text.Trim().Replace("'", "''") + "," +
                                txtdevml1.Text.Trim().Replace("'", "''") + "," +
                                txtspec1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");

                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid46"].ToString() + "',Perf_Value='" + acctest_stringehidden.Value + "'" +
                            //    " where Report_info_ID='" + edit_Reportid + "' and ValueID='"+dt_valueid.Rows[i]["ValueID"].ToString()+"'";
                            //db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid46"].ToString() + "','" + acctest_stringehidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 1)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            acctest_stringehidden.Value = txtslno2.Text.Trim().Replace("'", "''") + "," + txtdutstd2.Text.Trim().Replace("'", "''") + "," +
                                txtinstnt6.Text.Trim().Replace("'", "''") + "," + txtinstnt7.Text.Trim().Replace("'", "''") + "," +
                                txtinstnt8.Text.Trim().Replace("'", "''") + "," + txtinstnt9.Text.Trim().Replace("'", "''") + "," +
                                txtinstnt10.Text.Trim().Replace("'", "''") + "," + txtmean2.Text.Trim().Replace("'", "''") + "," +
                                txtdevml2.Text.Trim().Replace("'", "''") + "," +
                                txtspec2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");
                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid46"].ToString() + "',Perf_Value='" + acctest_stringehidden.Value + "'" +
                            //    " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid46"].ToString() + "','" + acctest_stringehidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 2)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            acctest_stringehidden.Value = txtslno3.Text.Trim().Replace("'", "''") + "," + txtstddut3.Text.Trim().Replace("'", "''") + "," +
                                txtinstnt11.Text.Trim().Replace("'", "''") + "," + txtinstnt12.Text.Trim().Replace("'", "''") + "," +
                                txtinstnt13.Text.Trim().Replace("'", "''") + "," + txtinstnt14.Text.Trim().Replace("'", "''") + "," +
                                txtinstnt15.Text.Trim().Replace("'", "''") + "," + txtmean3.Text.Trim().Replace("'", "''") + "," +
                                txtdevml3.Text.Trim().Replace("'", "''") + "," +
                                txtspec3.Text.Trim().Replace("'", "''") + "," + txtrem3.Text.Trim().Replace("'", "''");
                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid46"].ToString() + "',Perf_Value='" + acctest_stringehidden.Value + "'" +
                            //    " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid46"].ToString() + "','" + acctest_stringehidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                    }
                    if (dt_valueid.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt_valueid.Rows.Count; i++)
                        {
                            db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid46"].ToString() + "','" + dt_valueid.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
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
                            acctest_stringehidden.Value = txtslno1.Text.Trim().Replace("'", "''") + "," + txtstddut1.Text.Trim().Replace("'", "''") + "," +
                                txtinstnt1.Text.Trim().Replace("'", "''") + "," + txtinstnt2.Text.Trim().Replace("'", "''") + "," +
                                txtinstnt3.Text.Trim().Replace("'", "''") + "," + txtinstnt4.Text.Trim().Replace("'", "''") + "," +
                                txtinstnt5.Text.Trim().Replace("'", "''") + "," + txtmean1.Text.Trim().Replace("'", "''") + "," +
                                txtdevml1.Text.Trim().Replace("'", "''") + "," +
                                txtspec1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid46"].ToString() + "','" + acctest_stringehidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 1)
                        {
                            acctest_stringehidden.Value = txtslno2.Text.Trim().Replace("'", "''") + "," + txtdutstd2.Text.Trim().Replace("'", "''") + "," +
                                txtinstnt6.Text.Trim().Replace("'", "''") + "," + txtinstnt7.Text.Trim().Replace("'", "''") + "," +
                                txtinstnt8.Text.Trim().Replace("'", "''") + "," + txtinstnt9.Text.Trim().Replace("'", "''") + "," +
                                txtinstnt10.Text.Trim().Replace("'", "''") + "," + txtmean2.Text.Trim().Replace("'", "''") + "," +
                                txtdevml2.Text.Trim().Replace("'", "''") + "," +
                                txtspec2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid46"].ToString() + "','" + acctest_stringehidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 2)
                        {
                            acctest_stringehidden.Value = txtslno3.Text.Trim().Replace("'", "''") + "," + txtstddut3.Text.Trim().Replace("'", "''") + "," +
                                txtinstnt11.Text.Trim().Replace("'", "''") + "," + txtinstnt12.Text.Trim().Replace("'", "''") + "," +
                                txtinstnt13.Text.Trim().Replace("'", "''") + "," + txtinstnt14.Text.Trim().Replace("'", "''") + "," +
                                txtinstnt15.Text.Trim().Replace("'", "''") + "," + txtmean3.Text.Trim().Replace("'", "''") + "," +
                                txtdevml3.Text.Trim().Replace("'", "''") + "," +
                                txtspec3.Text.Trim().Replace("'", "''") + "," + txtrem3.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid46"].ToString() + "','" + acctest_stringehidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                    }

                    db1.strCommand = "select Top 3 ValueID from Performance_Values order by ValueID desc";
                    DataTable dt_valueidupdate = db1.selecttable();

                    if (dt_valueidupdate.Rows.Count > 0)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID,ReportNo)values('" + Session["Perfid46"].ToString() + "','" + dt_valueidupdate.Rows[i]["ValueID"].ToString() + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }

                    }
                }
                //db1.strCommand = "select ValueID from Performance_Values where Report_info_ID='"+edit_Reportid+"'";
                //DataTable dt_valueid = db1.selecttable();


                lblmsg.Text = "Data Updated Successfully";
                lblmsg.Style.Add("color", "green");
            }
        }
        catch
        {
            lblmsg.Text = "Data not Inserted Correctly";
            lblmsg.Style.Add("color", "red");
        }
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {

    }
}