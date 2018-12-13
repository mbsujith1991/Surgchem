using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_PerfAnemometer : System.Web.UI.UserControl
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
    int perfanemoid = 0, perfanemotr1 = 0, perfanemotr2 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_perfanemo(string sReportid,string sPerfid)
    {
        
         perfanemoid++;
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
                    perfanemotr1++;
                    string[] perf_anemoarray1 = { };
                    StringBuilder sb_perfanemo1 = new StringBuilder();
                    sb_perfanemo1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_perfanemo1.ToString();
                    perf_anemoarray1 = perfvalue1.Split(',');
                    if (perf_anemoarray1.Count() > 0)
                    {
                        if (perf_anemoarray1[0].ToString() != "")
                            lblanemo1.Text = perf_anemoarray1[0].ToString();
                        if (perf_anemoarray1[1].ToString() != "")
                            lblanemo2.Text = perf_anemoarray1[1].ToString();
                        if (perf_anemoarray1[2].ToString() != "")
                            lblanemo3.Text = perf_anemoarray1[2].ToString();
                        if (perf_anemoarray1[3].ToString() != "")
                            lblanemo4.Text = perf_anemoarray1[3].ToString();
                        if (perf_anemoarray1[4].ToString() != "")
                            lblanemo5.Text = perf_anemoarray1[4].ToString();
                        if (perf_anemoarray1[5].ToString() != "")
                            lblanemo6.Text = perf_anemoarray1[5].ToString();

                    }
                }
                if (j == 1)
                {
                    perfanemotr2++;
                    string[] perf_anemoarray2 = { };
                    StringBuilder sb_perfanemo2 = new StringBuilder();
                    sb_perfanemo2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_perfanemo2.ToString();
                    perf_anemoarray2 = perfvalue1.Split(',');
                    if (perf_anemoarray2.Count() > 0)
                    {
                        if (perf_anemoarray2[0].ToString() != "")
                            lblanemo7.Text = perf_anemoarray2[0].ToString();
                        if (perf_anemoarray2[1].ToString() != "")
                            lblanemo8.Text = perf_anemoarray2[1].ToString();
                        if (perf_anemoarray2[2].ToString() != "")
                            lblanemo9.Text = perf_anemoarray2[2].ToString();
                        if (perf_anemoarray2[3].ToString() != "")
                            lblanemo10.Text = perf_anemoarray2[3].ToString();
                        if (perf_anemoarray2[4].ToString() != "")
                            lblanemo11.Text = perf_anemoarray2[4].ToString();
                        if (perf_anemoarray2[5].ToString() != "")
                            lblanemo12.Text = perf_anemoarray2[5].ToString();


                    }
                }
            }
        }
    }
    public void showdiv_tr()
    {
        perf_anemometerdiv.Visible = true;
        tr_anemo1.Visible = true;
        tr_anemo2.Visible = true;
       
    }
    public void Hide_perftable()
    {
        if (perfanemoid == 0)
            perf_anemometerdiv.Visible = false;
        else
            lblperfanemometer.Text = "Performance Study of Anemometer";
        if (perfanemotr1 == 0)
            tr_anemo1.Visible = false;
        if (perfanemotr2 == 0)
            tr_anemo2.Visible = false;
        
    }
}