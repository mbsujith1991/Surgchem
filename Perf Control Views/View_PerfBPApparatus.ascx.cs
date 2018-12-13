using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_PerfBPApparatus : System.Web.UI.UserControl
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
    int perfbpappid = 0, amplitudeholtertr1 = 0, amplitudeholtertr2 = 0, amplitudeholtertr3 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_PerfBPapparatusr(string sReportid,string sPerfid)
    {
         perfbpappid++;
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
                    amplitudeholtertr1++;
                    string[] amplitudeholterarray1 = { };
                    StringBuilder sb_ampliholter1 = new StringBuilder();
                    sb_ampliholter1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_ampliholter1.ToString();
                    amplitudeholterarray1 = perfvalue1.Split(',');
                    if (amplitudeholterarray1.Count() > 0)
                    {
                        if (amplitudeholterarray1[0].ToString() != "")
                            lblbpapp1.Text = amplitudeholterarray1[0].ToString();
                        if (amplitudeholterarray1[1].ToString() != "")
                            lblbpapp2.Text = amplitudeholterarray1[1].ToString();
                        if (amplitudeholterarray1[2].ToString() != "")
                            lblbpapp3.Text = amplitudeholterarray1[2].ToString();
                        if (amplitudeholterarray1[3].ToString() != "")
                            lblbpapp4.Text = amplitudeholterarray1[3].ToString();
                        if (amplitudeholterarray1[4].ToString() != "")
                            lblbpapp5.Text = amplitudeholterarray1[4].ToString();
                        if (amplitudeholterarray1[5].ToString() != "")
                            lblbpapp6.Text = amplitudeholterarray1[5].ToString();


                    }
                }
                if (j == 1)
                {
                    amplitudeholtertr2++;
                    string[] amplitudeholterarray2 = { };
                    StringBuilder sb_ecgholter2 = new StringBuilder();
                    sb_ecgholter2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_ecgholter2.ToString();
                    amplitudeholterarray2 = perfvalue1.Split(',');
                    if (amplitudeholterarray2.Count() > 0)
                    {
                        if (amplitudeholterarray2[0].ToString() != "")
                            lblbpapp7.Text = amplitudeholterarray2[0].ToString();
                        if (amplitudeholterarray2[1].ToString() != "")
                            lblbpapp8.Text = amplitudeholterarray2[1].ToString();
                        if (amplitudeholterarray2[2].ToString() != "")
                            lblbpapp9.Text = amplitudeholterarray2[2].ToString();
                        if (amplitudeholterarray2[3].ToString() != "")
                            lblbpapp10.Text = amplitudeholterarray2[3].ToString();
                        if (amplitudeholterarray2[4].ToString() != "")
                            lblbpapp11.Text = amplitudeholterarray2[4].ToString();
                        if (amplitudeholterarray2[5].ToString() != "")
                            lblbpapp12.Text = amplitudeholterarray2[5].ToString();

                    }
                }
                if (j == 2)
                {
                    amplitudeholtertr3++;
                    string[] amplitudeholterarray3 = { };
                    StringBuilder sb_ampliholter3 = new StringBuilder();
                    sb_ampliholter3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_ampliholter3.ToString();
                    amplitudeholterarray3 = perfvalue1.Split(',');
                    if (amplitudeholterarray3.Count() > 0)
                    {
                        if (amplitudeholterarray3[0].ToString() != "")
                            lblbpapp13.Text = amplitudeholterarray3[0].ToString();
                        if (amplitudeholterarray3[1].ToString() != "")
                            lblbpapp14.Text = amplitudeholterarray3[1].ToString();
                        if (amplitudeholterarray3[2].ToString() != "")
                            lblbpapp15.Text = amplitudeholterarray3[2].ToString();
                        if (amplitudeholterarray3[3].ToString() != "")
                            lblbpapp16.Text = amplitudeholterarray3[3].ToString();
                        if (amplitudeholterarray3[4].ToString() != "")
                            lblbpapp17.Text = amplitudeholterarray3[4].ToString();
                        if (amplitudeholterarray3[5].ToString() != "")
                            lblbpapp18.Text = amplitudeholterarray3[5].ToString();

                    }
                }
            }
        }

    }

    public void showdiv_tr()
    {
        perfbpapparatusdiv.Visible = true;
        tr_perfbpapparatus1.Visible = true;
        tr_perfbpapparatus2.Visible = true;
        tr_perfbpapparatus3.Visible = true;
    }
    public void Hide_perftable()
    {
        if (perfbpappid == 0)
            perfbpapparatusdiv.Visible = false;
        else
            lblbpapparatus.Text = "Perform Analysis BP Apparatus";
        if (amplitudeholtertr1 == 0)
            tr_perfbpapparatus1.Visible = false;
        if (amplitudeholtertr2 == 0)
            tr_perfbpapparatus2.Visible = false;
        if (amplitudeholtertr3 == 0)
            tr_perfbpapparatus3.Visible = false;

    }
}