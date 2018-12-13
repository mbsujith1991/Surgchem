using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_Pressure : System.Web.UI.UserControl
{
    Dbclass db1 = new Dbclass();
    private string _Reportid;
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
    int pressureid = 0, pretr1 = 0, pretr2 = 0, pretr3 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Pressure(string sReportid, string sPerfid)
    {
        
        pressureid++;
        db1.strCommand = "select Perf_Value from Performance_Values where " +
            "Report_info_ID='" + sReportid + "' and PerfID='" + sPerfid + "'";
        DataTable dt_value = db1.selecttable();

        if (dt_value.Rows.Count > 0)
        {
            //object[] valarray=new object[dt_value.Rows.Count];
            for (int j = 0; j < dt_value.Rows.Count; j++)
            {
                if (j == 0)
                {
                    pretr1++;
                    string[] perfpressure1array = { };
                    StringBuilder sb_pre1 = new StringBuilder();
                    sb_pre1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_pre1.ToString();
                    perfpressure1array = perfvalue1.Split(',');
                    if (perfpressure1array.Count() > 0)
                    {
                        if (perfpressure1array[0].ToString() != "")
                            lbpre1.Text = perfpressure1array[0].ToString();
                        if (perfpressure1array[1].ToString() != "")
                            lbpre2.Text = perfpressure1array[1].ToString();
                        if (perfpressure1array[2].ToString() != "")
                            lbpre3.Text = perfpressure1array[2].ToString();
                        if (perfpressure1array[3].ToString() != "")
                            lbpre4.Text = perfpressure1array[3].ToString();
                        if (perfpressure1array[4].ToString() != "")
                            lbpre5.Text = perfpressure1array[4].ToString();
                        if (perfpressure1array[5].ToString() != "")
                            lbpre6.Text = perfpressure1array[5].ToString();
                        if (perfpressure1array[6].ToString() != "")
                            lbpre7.Text = perfpressure1array[6].ToString();

                    }
                }
                if (j == 1)
                {
                    pretr2++;
                    string[] perfpressure2array = { };
                    StringBuilder sb_pre2 = new StringBuilder();
                    sb_pre2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue2 = sb_pre2.ToString();
                    perfpressure2array = perfvalue2.Split(',');
                    if (perfpressure2array.Count() > 0)
                    {
                        if (perfpressure2array[0].ToString() != "")
                            lbpre8.Text = perfpressure2array[0].ToString();
                        if (perfpressure2array[1].ToString() != "")
                            lbpre9.Text = perfpressure2array[1].ToString();
                        if (perfpressure2array[2].ToString() != "")
                            lbpre10.Text = perfpressure2array[2].ToString();
                        if (perfpressure2array[3].ToString() != "")
                            lbpre11.Text = perfpressure2array[3].ToString();
                        if (perfpressure2array[4].ToString() != "")
                            lbpre12.Text = perfpressure2array[4].ToString();
                        if (perfpressure2array[5].ToString() != "")
                            lbpre13.Text = perfpressure2array[5].ToString();
                        if (perfpressure2array[6].ToString() != "")
                            lbpre14.Text = perfpressure2array[6].ToString();

                    }
                }
                if (j == 2)
                {
                    pretr3++;
                    string[] perfpressure3array = { };
                    StringBuilder sb_pre3 = new StringBuilder();
                    sb_pre3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue3 = sb_pre3.ToString();
                    perfpressure3array = perfvalue3.Split(',');
                    if (perfpressure3array.Count() > 0)
                    {
                        if (perfpressure3array[0].ToString() != "")
                            lbpre15.Text = perfpressure3array[0].ToString();
                        if (perfpressure3array[1].ToString() != "")
                            lbpre16.Text = perfpressure3array[1].ToString();
                        if (perfpressure3array[2].ToString() != "")
                            lbpre17.Text = perfpressure3array[2].ToString();
                        if (perfpressure3array[3].ToString() != "")
                            lbpre18.Text = perfpressure3array[3].ToString();
                        if (perfpressure3array[4].ToString() != "")
                            lbpre19.Text = perfpressure3array[4].ToString();
                        if (perfpressure3array[5].ToString() != "")
                            lbpre20.Text = perfpressure3array[5].ToString();
                        if (perfpressure3array[6].ToString() != "")
                            lbpre21.Text = perfpressure3array[6].ToString();

                    }
                }
               
               
            }


        }
    }

    public void Hide_perftable()
    {
        if (pressureid == 0)
            pressurediv.Visible = false;
        else
            lblperformancename4.Text = "Pressure";
        if (pretr1 == 0)
            pressure_1.Visible = false;
        if (pretr2 == 0)
            pressure_2.Visible = false;
        if (pretr3 == 0)
            pressure_3.Visible = false;
       
    }
    public void showdiv_tr()
    {
        pressurediv.Visible = true;
        pressure_1.Visible = true;
        pressure_2.Visible = true;
        pressure_3.Visible = true;
    }
}