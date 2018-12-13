using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

public partial class Perf_Control_Views_View_amplitudeHolter : System.Web.UI.UserControl
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
    int amplitude_holterid = 0, amplitudeholtertr1 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_ampliHolter(string sReportid,string sPerfid)
    {
       
         amplitude_holterid++;
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
                    string[] ampliholterarray1 = { };
                    StringBuilder sb_ampliholter1 = new StringBuilder();
                    sb_ampliholter1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_ampliholter1.ToString();
                    ampliholterarray1 = perfvalue1.Split(',');
                    if (ampliholterarray1.Count() > 0)
                    {
                        if (ampliholterarray1[0].ToString() != "")
                            lblampliholter1.Text = ampliholterarray1[0].ToString();
                        if (ampliholterarray1[1].ToString() != "")
                            lblampliholter2.Text = ampliholterarray1[1].ToString();
                        if (ampliholterarray1[2].ToString() != "")
                            lblampliholter3.Text = ampliholterarray1[2].ToString();
                        if (ampliholterarray1[3].ToString() != "")
                            lblampliholter4.Text = ampliholterarray1[3].ToString();
                        if (ampliholterarray1[4].ToString() != "")
                            lblampliholter5.Text = ampliholterarray1[4].ToString();
                        if (ampliholterarray1[5].ToString() != "")
                            lblampliholter6.Text = ampliholterarray1[5].ToString();
                        if (ampliholterarray1[6].ToString() != "")
                            lblampliholter7.Text = ampliholterarray1[6].ToString();


                    }
                }
            }
        }
       
    }
    public void showdiv_tr()
    {
        amplitudeholterdiv.Visible = true;
        tr_ampliholter1.Visible = true;
       
    }
    public void Hide_perftable()
    {
        if (amplitude_holterid == 0)
            amplitudeholterdiv.Visible = false;
        else
            lblamplitudeholter.Text = "Amplitude Holter Machine";
        if (amplitudeholtertr1 == 0)
            tr_ampliholter1.Visible = false;
       
    }
}