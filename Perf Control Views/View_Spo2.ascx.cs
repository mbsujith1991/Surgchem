using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_Spo2 : System.Web.UI.UserControl
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
    int spo2id = 0, spotr1 = 0, spotr2 = 0, spotr3 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void Bind_Spo2(string sReportid, string sPerfid)
    {
        
        spo2id++;
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
                    spotr1++;
                    string[] spo21array = { };
                    StringBuilder sb_spo1 = new StringBuilder();
                    sb_spo1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_spo1.ToString();
                    spo21array = perfvalue1.Split(',');
                    if (spo21array.Count() > 0)
                    {
                        if (spo21array[0].ToString() != "")
                            lbspo2_1.Text = spo21array[0].ToString();
                        if (spo21array[1].ToString() != "")
                            lbspo2_2.Text = spo21array[1].ToString();
                        if (spo21array[2].ToString() != "")
                            lbspo2_3.Text = spo21array[2].ToString();
                        if (spo21array[3].ToString() != "")
                            lbspo2_4.Text = spo21array[3].ToString();
                        if (spo21array[4].ToString() != "")
                            lbspo2_5.Text = spo21array[4].ToString();
                        if (spo21array[5].ToString() != "")
                            lbspo2_6.Text = spo21array[5].ToString();
                        if (spo21array[6].ToString() != "")
                            lbspo2_7.Text = spo21array[6].ToString();
                        if (spo21array[7].ToString() != "")
                            lbspo2_8.Text = spo21array[7].ToString();
                        if (spo21array[8].ToString() != "")
                            lbspo2_9.Text = spo21array[8].ToString();
                        if (spo21array[9].ToString() != "")
                            lbspo2_10.Text = spo21array[9].ToString();

                    }
                }
                if (j == 1)
                {
                    spotr2++;
                    string[] spo22array = { };
                    StringBuilder sb_spo2 = new StringBuilder();
                    sb_spo2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_spo2.ToString();
                    spo22array = perfvalue1.Split(',');
                    if (spo22array.Count() > 0)
                    {
                        if (spo22array[0].ToString() != "")
                            lbspo2_11.Text = spo22array[0].ToString();
                        if (spo22array[1].ToString() != "")
                            lbspo2_12.Text = spo22array[1].ToString();
                        if (spo22array[2].ToString() != "")
                            lbspo2_13.Text = spo22array[2].ToString();
                        if (spo22array[3].ToString() != "")
                            lbspo2_14.Text = spo22array[3].ToString();
                        if (spo22array[4].ToString() != "")
                            lbspo2_15.Text = spo22array[4].ToString();
                        if (spo22array[5].ToString() != "")
                            lbspo2_16.Text = spo22array[5].ToString();
                        if (spo22array[6].ToString() != "")
                            lbspo2_17.Text = spo22array[6].ToString();
                        if (spo22array[7].ToString() != "")
                            lbspo2_18.Text = spo22array[7].ToString();
                        if (spo22array[8].ToString() != "")
                            lbspo2_19.Text = spo22array[8].ToString();
                        if (spo22array[9].ToString() != "")
                            lbspo2_20.Text = spo22array[9].ToString();

                    }
                }
                if (j == 2)
                {
                    spotr3++;
                    string[] spo23array = { };
                    StringBuilder sb_spo3 = new StringBuilder();
                    sb_spo3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_spo3.ToString();
                    spo23array = perfvalue1.Split(',');
                    if (spo23array.Count() > 0)
                    {
                        if (spo23array[0].ToString() != "")
                            lbspo2_21.Text = spo23array[0].ToString();
                        if (spo23array[1].ToString() != "")
                            lbspo2_22.Text = spo23array[1].ToString();
                        if (spo23array[2].ToString() != "")
                            lbspo2_23.Text = spo23array[2].ToString();
                        if (spo23array[3].ToString() != "")
                            lbspo2_24.Text = spo23array[3].ToString();
                        if (spo23array[4].ToString() != "")
                            lbspo2_25.Text = spo23array[4].ToString();
                        if (spo23array[5].ToString() != "")
                            lbspo2_26.Text = spo23array[5].ToString();
                        if (spo23array[6].ToString() != "")
                            lbspo2_27.Text = spo23array[6].ToString();
                        if (spo23array[7].ToString() != "")
                            lbspo2_28.Text = spo23array[7].ToString();
                        if (spo23array[8].ToString() != "")
                            lbspo2_29.Text = spo23array[8].ToString();
                        if (spo23array[9].ToString() != "")
                            lbspo2_30.Text = spo23array[9].ToString();

                    }
                }


            }
        }

    }

    public void Hide_perftable()
    {
        if (spo2id == 0)
            spo2div.Visible = false;
        else
            lblperformancename1.Text = "SpO2";

        if (spotr1 == 0)
            spo2_1.Visible = false;
        if (spotr2 == 0)
            spo2_2.Visible = false;
        if (spotr3 == 0)
            spo2_3.Visible = false;
       

    }
    public void showdiv_tr()
    {
        spo2div.Visible = true;
        spo2_1.Visible = true;
        spo2_2.Visible = true;
        spo2_3.Visible = true;
        
    }

}