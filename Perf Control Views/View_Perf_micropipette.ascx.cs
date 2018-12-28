using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_Perf_micropipette : System.Web.UI.UserControl
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
    int perf_holterid = 0, perf_holtertr1 = 0, perf_holtertr2 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_PerfHolter(string sReportid, string sPerfid)
    {

        perf_holterid++;
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
                    perf_holtertr1++;
                    string[] perf_holterarray1 = { };
                    StringBuilder sb_holter1 = new StringBuilder();
                    sb_holter1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_holter1.ToString();
                    perf_holterarray1 = perfvalue1.Split(',');
                    if (perf_holterarray1.Count() > 0)
                    {
                        if (perf_holterarray1[0].ToString() != "")
                            lblperf_holter1.Text = perf_holterarray1[0].ToString();
                        if (perf_holterarray1[1].ToString() != "")
                            lblperf_holter2.Text = perf_holterarray1[1].ToString();
                        if (perf_holterarray1[2].ToString() != "")
                            lblperf_holter3_1.Text = perf_holterarray1[2].ToString();
                        if (perf_holterarray1[3].ToString() != "")
                            lblperf_holter3_2.Text = perf_holterarray1[3].ToString();
                        if (perf_holterarray1[4].ToString() != "")
                            lblperf_holter3_3.Text = perf_holterarray1[4].ToString();
                        if (perf_holterarray1[5].ToString() != "")
                            lblperf_holter3_4.Text = perf_holterarray1[5].ToString();
                        if (perf_holterarray1[6].ToString() != "")
                            lblperf_holter4.Text = perf_holterarray1[6].ToString();
                        if (perf_holterarray1[7].ToString() != "")
                            lblperf_holter5.Text = perf_holterarray1[7].ToString();
                        if (perf_holterarray1[8].ToString() != "")
                            lblperf_holter6.Text = perf_holterarray1[8].ToString();



                    }
                }
                if (j == 1)
                {
                    perf_holtertr2++;
                    string[] perf_holterarray2 = { };
                    StringBuilder sb_holter2 = new StringBuilder();
                    sb_holter2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_holter2.ToString();
                    perf_holterarray2 = perfvalue1.Split(',');
                    if (perf_holterarray2.Count() > 0)
                    {
                        if (perf_holterarray2[0].ToString() != "")
                            lblperf_holter7.Text = perf_holterarray2[0].ToString();
                        if (perf_holterarray2[1].ToString() != "")
                            lblperf_holter8.Text = perf_holterarray2[1].ToString();
                        if (perf_holterarray2[2].ToString() != "")
                            lblperf_holter9_1.Text = perf_holterarray2[2].ToString();
                        if (perf_holterarray2[3].ToString() != "")
                            lblperf_holter9_2.Text = perf_holterarray2[3].ToString();
                        if (perf_holterarray2[4].ToString() != "")
                            lblperf_holter9_3.Text = perf_holterarray2[4].ToString();
                        if (perf_holterarray2[5].ToString() != "")
                            lblperf_holter9_4.Text = perf_holterarray2[5].ToString();
                        if (perf_holterarray2[6].ToString() != "")
                            lblperf_holter10.Text = perf_holterarray2[6].ToString();
                        if (perf_holterarray2[7].ToString() != "")
                            lblperf_holter11.Text = perf_holterarray2[7].ToString();
                        if (perf_holterarray2[8].ToString() != "")
                            lblperf_holter12.Text = perf_holterarray2[8].ToString();

                    }
                }
            }
        }

    }

    public void showdiv_tr()
    {
        perfholterdiv.Visible = true;
        tr_perfholter1.Visible = true;
        tr_perfholter2.Visible = true;

    }
    public void Hide_perftable()
    {
        if (perf_holterid == 0)
            perfholterdiv.Visible = false;
        else
            lblperfholter.Text = "Performance Analysis Micropipette";
        if (perf_holtertr1 == 0)
            tr_perfholter1.Visible = false;
        if (perf_holtertr2 == 0)
            tr_perfholter2.Visible = false;


    }
}