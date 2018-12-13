using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_BloodPressure : System.Web.UI.UserControl
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
    int bloodid = 0, bptr1 = 0, bptr2 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_BloodPressure(string sReportid, string sPerfid)
    {
        bloodid++;
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
                    bptr1++;
                    string[] bp1array = { };
                    StringBuilder sb_bp1 = new StringBuilder();
                    sb_bp1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_bp1.ToString();
                    bp1array = perfvalue1.Split(',');
                    if (bp1array.Count() > 0)
                    {
                        if (bp1array[0].ToString() != "")
                            lbbp1.Text = bp1array[0].ToString();
                        if (bp1array[1].ToString() != "")
                            lbbp2.Text = bp1array[1].ToString();
                        if (bp1array[2].ToString() != "")
                            lbbp3.Text = bp1array[2].ToString();
                        if (bp1array[3].ToString() != "")
                            lbbp4.Text = bp1array[3].ToString();
                        if (bp1array[4].ToString() != "")
                            lbbp5.Text = bp1array[4].ToString();
                        if (bp1array[5].ToString() != "")
                            lbbp6.Text = bp1array[5].ToString();
                        if (bp1array[6].ToString() != "")
                            lbbp7.Text = bp1array[6].ToString();
                        if (bp1array[7].ToString() != "")
                            lbbp8.Text = bp1array[7].ToString();
                        if (bp1array[8].ToString() != "")
                            lbbp9.Text = bp1array[8].ToString();
                        if (bp1array[9].ToString() != "")
                            lbbp10.Text = bp1array[9].ToString();
                        if (bp1array[10].ToString() != "")
                            lbbp11.Text = bp1array[10].ToString();
                        if (bp1array[11].ToString() != "")
                            lbbp12.Text = bp1array[11].ToString();
                        if (bp1array[12].ToString() != "")
                            lbbp13.Text = bp1array[12].ToString();
                        if (bp1array[13].ToString() != "")
                            lbbp14.Text = bp1array[13].ToString();

                    }
                }
                if (j == 1)
                {
                    bptr2++;
                    string[] bp2array = { };
                    StringBuilder sb_bp2 = new StringBuilder();
                    sb_bp2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_bp2.ToString();
                    bp2array = perfvalue1.Split(',');
                    if (bp2array.Count() > 0)
                    {
                        if (bp2array[0].ToString() != "")
                            lbbp15.Text = bp2array[0].ToString();
                        if (bp2array[1].ToString() != "")
                            lbbp16.Text = bp2array[1].ToString();
                        if (bp2array[2].ToString() != "")
                            lbbp17.Text = bp2array[2].ToString();
                        if (bp2array[3].ToString() != "")
                            lbbp18.Text = bp2array[3].ToString();
                        if (bp2array[4].ToString() != "")
                            lbbp19.Text = bp2array[4].ToString();
                        if (bp2array[5].ToString() != "")
                            lbbp20.Text = bp2array[5].ToString();
                        if (bp2array[6].ToString() != "")
                            lbbp21.Text = bp2array[6].ToString();
                        if (bp2array[7].ToString() != "")
                            lbbp22.Text = bp2array[7].ToString();
                        if (bp2array[8].ToString() != "")
                            lbbp23.Text = bp2array[8].ToString();
                        if (bp2array[9].ToString() != "")
                            lbbp24.Text = bp2array[9].ToString();
                        if (bp2array[10].ToString() != "")
                            lbbp25.Text = bp2array[10].ToString();
                        if (bp2array[11].ToString() != "")
                            lbbp26.Text = bp2array[11].ToString();
                        if (bp2array[12].ToString() != "")
                            lbbp27.Text = bp2array[12].ToString();
                        if (bp2array[13].ToString() != "")
                            lbbp28.Text = bp2array[13].ToString();

                    }
                }
               
                
                }

            }

        }

    public void Hide_perftable()
    {
        if (bloodid == 0)
            bloodpressurediv.Visible = false;
        else
            lblperformancename2.Text = "Blood Pressure";
        if (bptr1 == 0)
            bp_1.Visible = false;
        if (bptr2 == 0)
            bp_2.Visible = false;
        
    }

    public void showdiv_tr()
    {
        bloodpressurediv.Visible = true;
        bp_1.Visible = true;
        bp_2.Visible = true;
       
    }
}