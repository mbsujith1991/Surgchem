using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_PerformCpap : System.Web.UI.UserControl
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
    int perf_cpapid = 0, cpaptr1 = 0, cpaptr2 = 0, cpaptr3 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Perf_cpap(string sReportid, string sPerfid)
    {

        perf_cpapid++;
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
                    cpaptr1++;
                    string[] cpaparray1 = { };
                    StringBuilder sb_cpap1 = new StringBuilder();
                    sb_cpap1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_cpap1.ToString();
                    cpaparray1 = perfvalue1.Split(',');
                    if (cpaparray1.Count() > 0)
                    {
                        if (cpaparray1[0].ToString() != "")
                            lblcpap1.Text = cpaparray1[0].ToString();
                        if (cpaparray1[1].ToString() != "")
                            lblcpap2.Text = cpaparray1[1].ToString();
                        if (cpaparray1[2].ToString() != "")
                            lblcpap3.Text = cpaparray1[2].ToString();
                        if (cpaparray1[3].ToString() != "")
                            lblcpap4.Text = cpaparray1[3].ToString();
                        if (cpaparray1[4].ToString() != "")
                            lblcpap5.Text = cpaparray1[4].ToString();
                        if (cpaparray1[5].ToString() != "")
                            lblcpap6.Text = cpaparray1[5].ToString();
                        if (cpaparray1[6].ToString() != "")
                            lblcpap7.Text = cpaparray1[6].ToString();


                    }
                }
                if (j == 1)
                {
                    cpaptr2++;
                    string[] cpaparray2 = { };
                    StringBuilder sb_cpap2 = new StringBuilder();
                    sb_cpap2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_cpap2.ToString();
                    cpaparray2 = perfvalue1.Split(',');
                    if (cpaparray2.Count() > 0)
                    {
                        if (cpaparray2[0].ToString() != "")
                            lblcpap8.Text = cpaparray2[0].ToString();
                        if (cpaparray2[1].ToString() != "")
                            lblcpap9.Text = cpaparray2[1].ToString();
                        if (cpaparray2[2].ToString() != "")
                            lblcpap10.Text = cpaparray2[2].ToString();
                        if (cpaparray2[3].ToString() != "")
                            lblcpap11.Text = cpaparray2[3].ToString();
                        if (cpaparray2[4].ToString() != "")
                            lblcpap12.Text = cpaparray2[4].ToString();
                        if (cpaparray2[5].ToString() != "")
                            lblcpap13.Text = cpaparray2[5].ToString();
                        if (cpaparray2[6].ToString() != "")
                            lblcpap14.Text = cpaparray2[6].ToString();

                    }
                }
                if (j == 2)
                {
                    cpaptr3++;
                    string[] cpaparray3 = { };
                    StringBuilder sb_cpap3 = new StringBuilder();
                    sb_cpap3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_cpap3.ToString();
                    cpaparray3 = perfvalue1.Split(',');
                    if (cpaparray3.Count() > 0)
                    {
                        if (cpaparray3[0].ToString() != "")
                            lblcpap15.Text = cpaparray3[0].ToString();
                        if (cpaparray3[1].ToString() != "")
                            lblcpap16.Text = cpaparray3[1].ToString();
                        if (cpaparray3[2].ToString() != "")
                            lblcpap17.Text = cpaparray3[2].ToString();
                        if (cpaparray3[3].ToString() != "")
                            lblcpap18.Text = cpaparray3[3].ToString();
                        if (cpaparray3[4].ToString() != "")
                            lblcpap19.Text = cpaparray3[4].ToString();
                        if (cpaparray3[5].ToString() != "")
                            lblcpap20.Text = cpaparray3[5].ToString();
                        if (cpaparray3[6].ToString() != "")
                            lblcpap21.Text = cpaparray3[6].ToString();

                    }
                }
            }
        }
    }
    public void Hide_perftable()
    {
        if (perf_cpapid == 0)
            cpapdiv.Visible = false;
        else
            lblcpapname.Text = "Performance Analysis of CPAP";
        if (cpaptr1 == 0)
            tr_cpap1.Visible = false;
        if (cpaptr2 == 0)
            tr_cpap2.Visible = false;
        if (cpaptr3 == 0)
            tr_cpap3.Visible = false;
    }

    public void showdiv_tr()
    {
        cpapdiv.Visible = true;
        tr_cpap1.Visible = true;
        tr_cpap2.Visible = true;
        tr_cpap3.Visible = true;
    }
}