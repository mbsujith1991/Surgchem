using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class controls_Pulseampli_measure : System.Web.UI.UserControl
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
        edit_Reportid = Session["Editreportid31"];
    }

    //insert function to save performance testname to databasee
    string perfname = "";
    string perfid = "";
    
    protected void btnsave_Click(object sender, EventArgs e)
    {
        try
        {
            if (edit_Reportid == "" || edit_Reportid == null)
            {
                
                for (int i = 0; i < 2; i++)
                {
                    if (i == 0)
                    {
                        pulseampli_hidden.Value = txtslno1.Text.Trim().Replace("'", "''") + "," + txtpara1.Text.Trim().Replace("'", "''") + "," +
                            txtsetdut1.Text.Trim().Replace("'", "''") + "," + txtvalmeas1.Text.Trim().Replace("'", "''") + "," +
                            txtdev1.Text.Trim().Replace("'", "''") + "," + txtspec1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid31"].ToString() + "','" + pulseampli_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }
                    if (i == 1)
                    {
                        pulseampli_hidden.Value = txtslno2.Text.Trim().Replace("'", "''") + "," + txtpara2.Text.Trim().Replace("'", "''") + "," +
                           txtsetdut2.Text.Trim().Replace("'", "''") + "," + txtvalmeas2.Text.Trim().Replace("'", "''") + "," +
                           txtdev2.Text.Trim().Replace("'", "''") + "," + txtspec2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");
                        db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid31"].ToString() + "','" + pulseampli_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                        db1.insertqry();
                    }

                }

                
                lblmsg.Text = "Data Inserted Successfully";
                lblmsg.Style.Add("color", "green");
            }
            else
            {
                
                db1.strCommand = "select ValueID from Performance_Values where Report_info_ID='" + edit_Reportid + "' and PerfID='31'";
                DataTable dt_valueid = db1.selecttable();
                if (dt_valueid.Rows.Count > 0)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (i == 0)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            pulseampli_hidden.Value = txtslno1.Text.Trim().Replace("'", "''") + "," + txtpara1.Text.Trim().Replace("'", "''") + "," +
                                txtsetdut1.Text.Trim().Replace("'", "''") + "," + txtvalmeas1.Text.Trim().Replace("'", "''") + "," +
                                txtdev1.Text.Trim().Replace("'", "''") + "," + txtspec1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");
                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid31"].ToString() + "',Perf_Value='" + pulseampli_hidden.Value + "'" +
                            //    " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid31"].ToString() + "','" + pulseampli_hidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 1)
                        {
                            db1.strCommand = "delete from Performance_Values where ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "' and Report_info_ID='" + edit_Reportid + "'";
                            db1.insertqry();
                            pulseampli_hidden.Value = txtslno2.Text.Trim().Replace("'", "''") + "," + txtpara2.Text.Trim().Replace("'", "''") + "," +
                               txtsetdut2.Text.Trim().Replace("'", "''") + "," + txtvalmeas2.Text.Trim().Replace("'", "''") + "," +
                               txtdev2.Text.Trim().Replace("'", "''") + "," + txtspec2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");
                            //db1.strCommand = "Update Performance_Values set PerfID='" + Session["Perfid31"].ToString() + "',Perf_Value='" + pulseampli_hidden.Value + "'" +
                            //     " where Report_info_ID='" + edit_Reportid + "' and ValueID='" + dt_valueid.Rows[i]["ValueID"].ToString() + "'";
                            //db1.insertqry();
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,Report_info_ID,ReportNo) values('" + Session["Perfid31"].ToString() + "','" + pulseampli_hidden.Value + "','" + edit_Reportid + "','" + Session["ReportNo"].ToString() + "')";
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
                            pulseampli_hidden.Value = txtslno1.Text.Trim().Replace("'", "''") + "," + txtpara1.Text.Trim().Replace("'", "''") + "," +
                                txtsetdut1.Text.Trim().Replace("'", "''") + "," + txtvalmeas1.Text.Trim().Replace("'", "''") + "," +
                                txtdev1.Text.Trim().Replace("'", "''") + "," + txtspec1.Text.Trim().Replace("'", "''") + "," + txtrem1.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid31"].ToString() + "','" + pulseampli_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
                            db1.insertqry();
                        }
                        if (i == 1)
                        {
                            pulseampli_hidden.Value = txtslno2.Text.Trim().Replace("'", "''") + "," + txtpara2.Text.Trim().Replace("'", "''") + "," +
                               txtsetdut2.Text.Trim().Replace("'", "''") + "," + txtvalmeas2.Text.Trim().Replace("'", "''") + "," +
                               txtdev2.Text.Trim().Replace("'", "''") + "," + txtspec2.Text.Trim().Replace("'", "''") + "," + txtrem2.Text.Trim().Replace("'", "''");
                            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value,ReportNo) values('" + Session["Perfid31"].ToString() + "','" + pulseampli_hidden.Value + "','" + Session["ReportNo"].ToString() + "')";
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
            lblmsg.Text = "Data not Inserted Successfully "+ex;
            lblmsg.Style.Add("color", "red");
        }

    }
    protected void btncancel_Click(object sender, EventArgs e)
    {

    }
}