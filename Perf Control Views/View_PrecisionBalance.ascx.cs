using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_PrecisionBalance : System.Web.UI.UserControl
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
    int precisionid = 0, precisiontr1 = 0, precisiontr2 = 0, precisiontr3 = 0, precisiontr4 = 0, precisiontr5 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Precision(string sReportid, string sPerfid)
    {
       
        precisionid++;
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
                    precisiontr1++;
                    string[] precisionarray1 = { };
                    StringBuilder sb_precision1 = new StringBuilder();
                    sb_precision1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_precision1.ToString();
                    precisionarray1 = perfvalue1.Split(',');
                    if (precisionarray1.Count() > 0)
                    {
                        if (precisionarray1[0].ToString() != "")
                            lblpreci1.Text = precisionarray1[0].ToString();
                        if (precisionarray1[1].ToString() != "")
                            lblpreci2.Text = precisionarray1[1].ToString();
                        if (precisionarray1[2].ToString() != "")
                            lblpreci3.Text = precisionarray1[2].ToString();
                        if (precisionarray1[3].ToString() != "")
                            lblpreci4.Text = precisionarray1[3].ToString();
                        if (precisionarray1[4].ToString() != "")
                            lblpreci5.Text = precisionarray1[4].ToString();
                        if (precisionarray1[5].ToString() != "")
                            lblpreci6.Text = precisionarray1[5].ToString();
                        
                    }
                }
                if (j == 1)
                {
                    precisiontr2++;
                    string[] pulseratearray2 = { };
                    StringBuilder sb_pulserate2 = new StringBuilder();
                    sb_pulserate2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue2 = sb_pulserate2.ToString();
                    pulseratearray2 = perfvalue2.Split(',');
                    if (pulseratearray2.Count() > 0)
                    {
                        if (pulseratearray2[0].ToString() != "")
                            lblpreci7.Text = pulseratearray2[0].ToString();
                        if (pulseratearray2[1].ToString() != "")
                            lblpreci8.Text = pulseratearray2[1].ToString();
                        if (pulseratearray2[2].ToString() != "")
                            lblpreci9.Text = pulseratearray2[2].ToString();
                        if (pulseratearray2[3].ToString() != "")
                            lblpreci10.Text = pulseratearray2[3].ToString();
                        if (pulseratearray2[4].ToString() != "")
                            lblpreci11.Text = pulseratearray2[4].ToString();
                        if (pulseratearray2[5].ToString() != "")
                            lblpreci12.Text = pulseratearray2[5].ToString();
                       
                    }
                }
               
                if (j == 2)
                {
                    precisiontr3++;
                    string[] pulseratearray3 = { };
                    StringBuilder sb_pulserate3 = new StringBuilder();
                    sb_pulserate3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue2 = sb_pulserate3.ToString();
                    pulseratearray3 = perfvalue2.Split(',');
                    if (pulseratearray3.Count() > 0)
                    {
                        if (pulseratearray3[0].ToString() != "")
                            lblpreci13.Text = pulseratearray3[0].ToString();
                        if (pulseratearray3[1].ToString() != "")
                            lblpreci14.Text = pulseratearray3[1].ToString();
                        if (pulseratearray3[2].ToString() != "")
                            lblpreci15.Text = pulseratearray3[2].ToString();
                        if (pulseratearray3[3].ToString() != "")
                            lblpreci16.Text = pulseratearray3[3].ToString();
                        if (pulseratearray3[4].ToString() != "")
                            lblpreci17.Text = pulseratearray3[4].ToString();
                        if (pulseratearray3[5].ToString() != "")
                            lblpreci18.Text = pulseratearray3[5].ToString();

                    }
                }
                if (j == 3)
                {
                    precisiontr4++;
                    string[] pulseratearray4 = { };
                    StringBuilder sb_pulserate4 = new StringBuilder();
                    sb_pulserate4.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue2 = sb_pulserate4.ToString();
                    pulseratearray4 = perfvalue2.Split(',');
                    if (pulseratearray4.Count() > 0)
                    {
                        if (pulseratearray4[0].ToString() != "")
                            lblpreci19.Text = pulseratearray4[0].ToString();
                        if (pulseratearray4[1].ToString() != "")
                            lblpreci20.Text = pulseratearray4[1].ToString();
                        if (pulseratearray4[2].ToString() != "")
                            lblpreci21.Text = pulseratearray4[2].ToString();
                        if (pulseratearray4[3].ToString() != "")
                            lblpreci22.Text = pulseratearray4[3].ToString();
                        if (pulseratearray4[4].ToString() != "")
                            lblpreci23.Text = pulseratearray4[4].ToString();
                        if (pulseratearray4[5].ToString() != "")
                            lblpreci24.Text = pulseratearray4[5].ToString();

                    }
                }
                if (j == 4)
                {
                    precisiontr5++;
                    string[] pulseratearray5 = { };
                    StringBuilder sb_pulserate5 = new StringBuilder();
                    sb_pulserate5.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue2 = sb_pulserate5.ToString();
                    pulseratearray5 = perfvalue2.Split(',');
                    if (pulseratearray5.Count() > 0)
                    {
                        if (pulseratearray5[0].ToString() != "")
                            lblpreci25.Text = pulseratearray5[0].ToString();
                        if (pulseratearray5[1].ToString() != "")
                            lblpreci26.Text = pulseratearray5[1].ToString();
                        if (pulseratearray5[2].ToString() != "")
                            lblpreci27.Text = pulseratearray5[2].ToString();
                        if (pulseratearray5[3].ToString() != "")
                            lblpreci28.Text = pulseratearray5[3].ToString();
                        if (pulseratearray5[4].ToString() != "")
                            lblpreci29.Text = pulseratearray5[4].ToString();
                        if (pulseratearray5[5].ToString() != "")
                            lblpreci30.Text = pulseratearray5[5].ToString();

                    }
                }
            }
        }
    }

    public void showdiv_tr()
    {
        pulseratediv.Visible = true;
        tr_preci1.Visible = true;
        tr_preci2.Visible = true;
        tr_preci3.Visible = true;
        tr_preci4.Visible = true;
        tr_preci5.Visible = true;
    }
    public void Hide_perftable()
    {
        if (precisionid == 0)
            pulseratediv.Visible = false;
        else
            lblpulseratepacemaker.Text = "Performance Analysis Precision Balance";
        if (precisiontr1 == 0)
            tr_preci1.Visible = false;
        if (precisiontr2 == 0)
            tr_preci2.Visible = false;
        if (precisiontr3 == 0)
            tr_preci3.Visible = false;
        if (precisiontr4 == 0)
            tr_preci4.Visible = false;
        if (precisiontr5 == 0)
            tr_preci5.Visible = false;

    }
}