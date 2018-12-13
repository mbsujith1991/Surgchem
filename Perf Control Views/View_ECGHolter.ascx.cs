using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_ECGHolter : System.Web.UI.UserControl
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
    int ecg_holterid = 0, ecgholtertr1 = 0, ecgholtertr2 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_ecgHolter(string sReportid,string sPerfid)
    {
        
         ecg_holterid++;
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
                    ecgholtertr1++;
                    string[] ecgholterarray1 = { };
                    StringBuilder sb_ecgholter1 = new StringBuilder();
                    sb_ecgholter1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_ecgholter1.ToString();
                    ecgholterarray1 = perfvalue1.Split(',');
                    if (ecgholterarray1.Count() > 0)
                    {
                        if (ecgholterarray1[0].ToString() != "")
                            lblecgholter1.Text = ecgholterarray1[0].ToString();
                        if (ecgholterarray1[1].ToString() != "")
                            lblecgholter2.Text = ecgholterarray1[1].ToString();
                        if (ecgholterarray1[2].ToString() != "")
                            lblecgholter3.Text = ecgholterarray1[2].ToString();
                        if (ecgholterarray1[3].ToString() != "")
                            lblecgholter4.Text = ecgholterarray1[3].ToString();
                        if (ecgholterarray1[4].ToString() != "")
                            lblecgholter5.Text = ecgholterarray1[4].ToString();
                        if (ecgholterarray1[5].ToString() != "")
                            lblecgholter6.Text = ecgholterarray1[5].ToString();
                        if (ecgholterarray1[6].ToString() != "")
                            lblecgholter7.Text = ecgholterarray1[6].ToString();


                    }
                }
                if (j == 1)
                {
                    ecgholtertr2++;
                    string[] ecgholterarray2 = { };
                    StringBuilder sb_ecgholter2 = new StringBuilder();
                    sb_ecgholter2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_ecgholter2.ToString();
                    ecgholterarray2 = perfvalue1.Split(',');
                    if (ecgholterarray2.Count() > 0)
                    {
                        if (ecgholterarray2[0].ToString() != "")
                            lblecgholter8.Text = ecgholterarray2[0].ToString();
                        if (ecgholterarray2[1].ToString() != "")
                            lblecgholter9.Text = ecgholterarray2[1].ToString();
                        if (ecgholterarray2[2].ToString() != "")
                            lblecgholter10.Text = ecgholterarray2[2].ToString();
                        if (ecgholterarray2[3].ToString() != "")
                            lblecgholter11.Text = ecgholterarray2[3].ToString();
                        if (ecgholterarray2[4].ToString() != "")
                            lblecgholter12.Text = ecgholterarray2[4].ToString();
                        if (ecgholterarray2[5].ToString() != "")
                            lblecgholter13.Text = ecgholterarray2[5].ToString();
                        if (ecgholterarray2[6].ToString() != "")
                            lblecgholter14.Text = ecgholterarray2[6].ToString();
                    }
                }
            }
        }

    }

    public void showdiv_tr()
    {
        ecgholterdiv.Visible = true;
        tr_ecgholter_1.Visible = true;
        tr_ecgholter_2.Visible = true;
       
    }
    public void Hide_perftable()
    {
        if (ecg_holterid == 0)
            ecgholterdiv.Visible = false;
        else
            lblecgholter.Text = "ECG of Holter Machine";
        if ( ecgholtertr1== 0)
            tr_ecgholter_1.Visible = false;
        if (ecgholtertr2 == 0)
            tr_ecgholter_2.Visible = false;
       

    }
}