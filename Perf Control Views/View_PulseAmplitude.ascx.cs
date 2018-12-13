using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_PulseAmplitude : System.Web.UI.UserControl
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
    int pulseampliid = 0, pulseamplitr1 = 0, pulseamplitr2 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Pulseamplitude(string sReportid, string sPerfid)
    {
        
        pulseampliid++;
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
                    pulseamplitr1++;
                    string[] pulseampliarray1 = { };
                    StringBuilder sb_pulseampli1 = new StringBuilder();
                    sb_pulseampli1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_pulseampli1.ToString();
                    pulseampliarray1 = perfvalue1.Split(',');
                    if (pulseampliarray1.Count() > 0)
                    {
                        if (pulseampliarray1[0].ToString() != "")
                            lblpulseampli1.Text = pulseampliarray1[0].ToString();
                        if (pulseampliarray1[1].ToString() != "")
                            lblpulseampli2.Text = pulseampliarray1[1].ToString();
                        if (pulseampliarray1[2].ToString() != "")
                            lblpulseampli3.Text = pulseampliarray1[2].ToString();
                        if (pulseampliarray1[3].ToString() != "")
                            lblpulseampli4.Text = pulseampliarray1[3].ToString();
                        if (pulseampliarray1[4].ToString() != "")
                            lblpulseampli5.Text = pulseampliarray1[4].ToString();
                        if (pulseampliarray1[5].ToString() != "")
                            lblpulseampli6.Text = pulseampliarray1[5].ToString();
                        if (pulseampliarray1[6].ToString() != "")
                            lblpulseampli7.Text = pulseampliarray1[6].ToString();

                    }
                }
                if (j == 1)
                {
                    pulseamplitr2++;
                    string[] pulseampliarray2 = { };
                    StringBuilder sb_pulseampli2 = new StringBuilder();
                    sb_pulseampli2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue2 = sb_pulseampli2.ToString();
                    pulseampliarray2 = perfvalue2.Split(',');
                    if (pulseampliarray2.Count() > 0)
                    {
                        if (pulseampliarray2[0].ToString() != "")
                            lblpulseampli8.Text = pulseampliarray2[0].ToString();
                        if (pulseampliarray2[1].ToString() != "")
                            lblpulseampli9.Text = pulseampliarray2[1].ToString();
                        if (pulseampliarray2[2].ToString() != "")
                            lblpulseampli10.Text = pulseampliarray2[2].ToString();
                        if (pulseampliarray2[3].ToString() != "")
                            lblpulseampli11.Text = pulseampliarray2[3].ToString();
                        if (pulseampliarray2[4].ToString() != "")
                            lblpulseampli12.Text = pulseampliarray2[4].ToString();
                        if (pulseampliarray2[5].ToString() != "")
                            lblpulseampli13.Text = pulseampliarray2[5].ToString();
                        if (pulseampliarray2[6].ToString() != "")
                            lblpulseampli14.Text = pulseampliarray2[6].ToString();

                    }
                }
            }
        }
    }

    public void showdiv_tr()
    {
        pulseamplitudediv.Visible = true;
        tr_pulseampli1.Visible = true;
        tr_pulseampli2.Visible = true;
      
    }
    public void Hide_perftable()
    {
        if (pulseampliid == 0)
            pulseamplitudediv.Visible = false;
        else
            lblpulseampli.Text = "Pulse Amplitude Measurement of Pacemaker";
        if (pulseamplitr1 == 0)
            tr_pulseampli1.Visible = false;
        if (pulseamplitr2 == 0)
            tr_pulseampli2.Visible = false;
       
    }
}