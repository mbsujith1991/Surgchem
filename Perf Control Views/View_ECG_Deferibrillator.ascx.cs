using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_ECG_Deferibrillator : System.Web.UI.UserControl
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
    int ecgid = 0, ecgtr1 = 0, ecgtr2 = 0, ecgtr3 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Ecgdefribrillator(string sReportid, string sPerfid)
    {
        
        ecgid++;
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
                    ecgtr1++;
                    string[] perfecg1array = { };
                    StringBuilder sb_ecg1 = new StringBuilder();
                    sb_ecg1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_ecg1.ToString();
                    perfecg1array = perfvalue1.Split(',');
                    if (perfecg1array.Count() > 0)
                    {
                        if (perfecg1array[0].ToString() != "")
                            ecg1.Text = perfecg1array[0].ToString();
                        if (perfecg1array[1].ToString() != "")
                            ecg2.Text = perfecg1array[1].ToString();
                        if (perfecg1array[2].ToString() != "")
                            ecg3.Text = perfecg1array[2].ToString();
                        if (perfecg1array[3].ToString() != "")
                            ecg4.Text = perfecg1array[3].ToString();
                        if (perfecg1array[4].ToString() != "")
                            ecg5.Text = perfecg1array[4].ToString();
                        if (perfecg1array[5].ToString() != "")
                            ecg6.Text = perfecg1array[5].ToString();
                        if (perfecg1array[6].ToString() != "")
                            ecg7.Text = perfecg1array[6].ToString();

                    }
                }
                if (j == 1)
                {
                    ecgtr2++;
                    string[] perfecg2array = { };
                    StringBuilder sb_ecg2 = new StringBuilder();
                    sb_ecg2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue2 = sb_ecg2.ToString();
                    perfecg2array = perfvalue2.Split(',');
                    if (perfecg2array.Count() > 0)
                    {
                        if (perfecg2array[0].ToString() != "")
                            ecg8.Text = perfecg2array[0].ToString();
                        if (perfecg2array[1].ToString() != "")
                            ecg9.Text = perfecg2array[1].ToString();
                        if (perfecg2array[2].ToString() != "")
                            ecg10.Text = perfecg2array[2].ToString();
                        if (perfecg2array[3].ToString() != "")
                            ecg11.Text = perfecg2array[3].ToString();
                        if (perfecg2array[4].ToString() != "")
                            ecg12.Text = perfecg2array[4].ToString();
                        if (perfecg2array[5].ToString() != "")
                            ecg13.Text = perfecg2array[5].ToString();
                        if (perfecg2array[6].ToString() != "")
                            ecg14.Text = perfecg2array[6].ToString();

                    }
                }
                if (j == 2)
                {
                    ecgtr3++;
                    string[] perfecg3array = { };
                    StringBuilder sb_ecg3 = new StringBuilder();
                    sb_ecg3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue3 = sb_ecg3.ToString();
                    perfecg3array = perfvalue3.Split(',');
                    if (perfecg3array.Count() > 0)
                    {
                        if (perfecg3array[0].ToString() != "")
                            ecg15.Text = perfecg3array[0].ToString();
                        if (perfecg3array[1].ToString() != "")
                            ecg16.Text = perfecg3array[1].ToString();
                        if (perfecg3array[2].ToString() != "")
                            ecg17.Text = perfecg3array[2].ToString();
                        if (perfecg3array[3].ToString() != "")
                            ecg18.Text = perfecg3array[3].ToString();
                        if (perfecg3array[4].ToString() != "")
                            ecg19.Text = perfecg3array[4].ToString();
                        if (perfecg3array[5].ToString() != "")
                            ecg20.Text = perfecg3array[5].ToString();
                        if (perfecg3array[6].ToString() != "")
                            ecg21.Text = perfecg3array[6].ToString();

                    }
                }

            }


        }
    }

    public void Hidetable()
    {
        if (ecgid == 0)
            ecgdiv.Visible = false;
        else
            lblperformancename.Text = "ECG";
        if (ecgtr1 == 0)
            ecg_1.Visible = false;
        if (ecgtr2 == 0)
            ecg_2.Visible = false;
        if (ecgtr3 == 0)
            ecg_3.Visible = false;
       
    }
    public void showdiv_tr()
    {
        ecgdiv.Visible = true;
        ecg_1.Visible = true;
        ecg_2.Visible = true;
        ecg_3.Visible = true;
       
    }
}