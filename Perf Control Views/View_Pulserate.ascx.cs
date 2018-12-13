using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_Pulserate : System.Web.UI.UserControl
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
    int pulserateid = 0, pulseratetr1 = 0, pulseratetr2 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Pulserate(string sReportid, string sPerfid)
    {
        
        pulserateid++;
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
                    pulseratetr1++;
                    string[] pulseratearray1 = { };
                    StringBuilder sb_pulserate1 = new StringBuilder();
                    sb_pulserate1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_pulserate1.ToString();
                    pulseratearray1 = perfvalue1.Split(',');
                    if (pulseratearray1.Count() > 0)
                    {
                        if (pulseratearray1[0].ToString() != "")
                            lblpulserate1.Text = pulseratearray1[0].ToString();
                        if (pulseratearray1[1].ToString() != "")
                            lblpulserate2.Text = pulseratearray1[1].ToString();
                        if (pulseratearray1[2].ToString() != "")
                            lblpulserate3.Text = pulseratearray1[2].ToString();
                        if (pulseratearray1[3].ToString() != "")
                            lblpulserate4.Text = pulseratearray1[3].ToString();
                        if (pulseratearray1[4].ToString() != "")
                            lblpulserate5.Text = pulseratearray1[4].ToString();
                        if (pulseratearray1[5].ToString() != "")
                            lblpulserate6.Text = pulseratearray1[5].ToString();
                        if (pulseratearray1[6].ToString() != "")
                            lblpulserate7.Text = pulseratearray1[6].ToString();
                      
                    }
                }
                if (j == 1)
                {
                    pulseratetr2++;
                    string[] pulseratearray2 = { };
                    StringBuilder sb_pulserate2 = new StringBuilder();
                    sb_pulserate2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue2 = sb_pulserate2.ToString();
                    pulseratearray2 = perfvalue2.Split(',');
                    if (pulseratearray2.Count() > 0)
                    {
                        if (pulseratearray2[0].ToString() != "")
                            lblpulserate8.Text = pulseratearray2[0].ToString();
                        if (pulseratearray2[1].ToString() != "")
                            lblpulserate9.Text = pulseratearray2[1].ToString();
                        if (pulseratearray2[2].ToString() != "")
                            lblpulserate10.Text = pulseratearray2[2].ToString();
                        if (pulseratearray2[3].ToString() != "")
                            lblpulserate11.Text = pulseratearray2[3].ToString();
                        if (pulseratearray2[4].ToString() != "")
                            lblpulserate12.Text = pulseratearray2[4].ToString();
                        if (pulseratearray2[5].ToString() != "")
                            lblpulserate13.Text = pulseratearray2[5].ToString();
                        if (pulseratearray2[6].ToString() != "")
                            lblpulserate14.Text = pulseratearray2[6].ToString();
                      

                    }
                }
            }
        }
    }

    public void showdiv_tr()
    {
        pulseratediv.Visible = true;
        tr_pulserate1.Visible = true;
        tr_pulserate2.Visible = true;
        
    }
    public void Hide_perftable()
    {
        if (pulserateid == 0)
            pulseratediv.Visible = false;
        else
            lblpulseratepacemaker.Text = "Pulse rate Measurement of Pacemaker";
        if (pulseratetr1 == 0)
            tr_pulserate1.Visible = false;
        if (pulseratetr2 == 0)
            tr_pulserate2.Visible = false;
       

    }
}