using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_Volume : System.Web.UI.UserControl
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
    int volumeid = 0, voltr1 = 0, voltr2 = 0, voltr3 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Volume(string sReportid, string sPerfid)
    {
        
        volumeid++;
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
                    voltr1++;
                    string[] prefvolume1array = { };
                    StringBuilder sb_vol1 = new StringBuilder();
                    sb_vol1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_vol1.ToString();
                    prefvolume1array = perfvalue1.Split(',');
                    if (prefvolume1array.Count() > 0)
                    {
                        if (prefvolume1array[0].ToString() != "")
                            lbvol1.Text = prefvolume1array[0].ToString();
                        if (prefvolume1array[1].ToString() != "")
                            lbvol2.Text = prefvolume1array[1].ToString();
                        if (prefvolume1array[2].ToString() != "")
                            lbvol3.Text = prefvolume1array[2].ToString();
                        if (prefvolume1array[3].ToString() != "")
                            lbvol4.Text = prefvolume1array[3].ToString();
                        if (prefvolume1array[4].ToString() != "")
                            lbvol5.Text = prefvolume1array[4].ToString();
                        if (prefvolume1array[5].ToString() != "")
                            lbvol6.Text = prefvolume1array[5].ToString();
                        if (prefvolume1array[6].ToString() != "")
                            lbvol7.Text = prefvolume1array[6].ToString();

                    }
                }
                if (j == 1)
                {
                    voltr2++;
                    string[] prefvolume2array = { };
                    StringBuilder sb_vol2 = new StringBuilder();
                    sb_vol2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue2 = sb_vol2.ToString();
                    prefvolume2array = perfvalue2.Split(',');
                    if (prefvolume2array.Count() > 0)
                    {
                        if (prefvolume2array[0].ToString() != "")
                            lbvol8.Text = prefvolume2array[0].ToString();
                        if (prefvolume2array[1].ToString() != "")
                            lbvol9.Text = prefvolume2array[1].ToString();
                        if (prefvolume2array[2].ToString() != "")
                            lbvol10.Text = prefvolume2array[2].ToString();
                        if (prefvolume2array[3].ToString() != "")
                            lbvol11.Text = prefvolume2array[3].ToString();
                        if (prefvolume2array[4].ToString() != "")
                            lbvol12.Text = prefvolume2array[4].ToString();
                        if (prefvolume2array[5].ToString() != "")
                            lbvol13.Text = prefvolume2array[5].ToString();
                        if (prefvolume2array[6].ToString() != "")
                            lbvol14.Text = prefvolume2array[6].ToString();

                    }
                }
                if (j == 2)
                {
                    voltr3++;
                    string[] prefvolume3array = { };
                    StringBuilder sb_vol3 = new StringBuilder();
                    sb_vol3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue3 = sb_vol3.ToString();
                    prefvolume3array = perfvalue3.Split(',');
                    if (prefvolume3array.Count() > 0)
                    {
                        if (prefvolume3array[0].ToString() != "")
                            lbvol15.Text = prefvolume3array[0].ToString();
                        if (prefvolume3array[1].ToString() != "")
                            lbvol16.Text = prefvolume3array[1].ToString();
                        if (prefvolume3array[2].ToString() != "")
                            lbvol17.Text = prefvolume3array[2].ToString();
                        if (prefvolume3array[3].ToString() != "")
                            lbvol18.Text = prefvolume3array[3].ToString();
                        if (prefvolume3array[4].ToString() != "")
                            lbvol19.Text = prefvolume3array[4].ToString();
                        if (prefvolume3array[5].ToString() != "")
                            lbvol20.Text = prefvolume3array[5].ToString();
                        if (prefvolume3array[6].ToString() != "")
                            lbvol21.Text = prefvolume3array[6].ToString();

                    }
                }
              

            }


        }
    }

    public void showdiv_tr()
    {
        volumediv.Visible = true;
        volume_1.Visible = true;
        volume_2.Visible = true;
        volume_3.Visible = true;
    }
    public void Hide_perftable()
    {
        if (volumeid == 0)
            volumediv.Visible = false;
        else
            lblperformancename5.Text = "Volume";
        if (voltr1 == 0)
            volume_1.Visible = false;
        if (voltr2 == 0)
            volume_2.Visible = false;
        if (voltr3 == 0)
            volume_3.Visible = false;
        
    }
}