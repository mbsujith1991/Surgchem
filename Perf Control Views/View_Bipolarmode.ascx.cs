using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_Bipolarmode : System.Web.UI.UserControl
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
    int bipolarid = 0, bipolartr1 = 0, bipolartr2 = 0, bipolartr3 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Bipolarmode(string sReportid, string sPerfid)
    {
        
        bipolarid++;
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
                    bipolartr1++;
                    string[] bipolararray = { };
                    StringBuilder sb_bipol1 = new StringBuilder();
                    sb_bipol1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_bipol1.ToString();
                    bipolararray = perfvalue1.Split(',');
                    if (bipolararray.Count() > 0)
                    {
                        if (bipolararray[0].ToString() != "")
                            lblbipol1.Text = bipolararray[0].ToString();
                        if (bipolararray[1].ToString() != "")
                            lblbipol2.Text = bipolararray[1].ToString();
                        if (bipolararray[2].ToString() != "")
                            lblbipol3.Text = bipolararray[2].ToString();
                        if (bipolararray[3].ToString() != "")
                            lblbipol4.Text = bipolararray[3].ToString();
                        if (bipolararray[4].ToString() != "")
                            lblbipol5.Text = bipolararray[4].ToString();
                        if (bipolararray[5].ToString() != "")
                            lblbipol6.Text = bipolararray[5].ToString();
                        if (bipolararray[6].ToString() != "")
                            lblbipol7.Text = bipolararray[6].ToString();

                    }
                }
                if (j == 1)
                {
                    bipolartr2++;
                    string[] bipolar2array = { };
                    StringBuilder sb_bipol2 = new StringBuilder();
                    sb_bipol2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue2 = sb_bipol2.ToString();
                    bipolar2array = perfvalue2.Split(',');
                    if (bipolar2array.Count() > 0)
                    {
                        if (bipolar2array[0].ToString() != "")
                            lblbipol8.Text = bipolar2array[0].ToString();
                        if (bipolar2array[1].ToString() != "")
                            lblbipol9.Text = bipolar2array[1].ToString();
                        if (bipolar2array[2].ToString() != "")
                            lblbipol10.Text = bipolar2array[2].ToString();
                        if (bipolar2array[3].ToString() != "")
                            lblbipol11.Text = bipolar2array[3].ToString();
                        if (bipolar2array[4].ToString() != "")
                            lblbipol12.Text = bipolar2array[4].ToString();
                        if (bipolar2array[5].ToString() != "")
                            lblbipol13.Text = bipolar2array[5].ToString();
                        if (bipolar2array[6].ToString() != "")
                            lblbipol14.Text = bipolar2array[6].ToString();

                    }
                }
                if (j == 2)
                {
                    bipolartr3++;
                    string[] bipolar3array = { };
                    StringBuilder sb_bipol3 = new StringBuilder();
                    sb_bipol3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue3 = sb_bipol3.ToString();
                    bipolar3array = perfvalue3.Split(',');
                    if (bipolar3array.Count() > 0)
                    {
                        if (bipolar3array[0].ToString() != "")
                            lblbipol15.Text = bipolar3array[0].ToString();
                        if (bipolar3array[1].ToString() != "")
                            lblbipol16.Text = bipolar3array[1].ToString();
                        if (bipolar3array[2].ToString() != "")
                            lblbipol17.Text = bipolar3array[2].ToString();
                        if (bipolar3array[3].ToString() != "")
                            lblbipol18.Text = bipolar3array[3].ToString();
                        if (bipolar3array[4].ToString() != "")
                            lblbipol19.Text = bipolar3array[4].ToString();
                        if (bipolar3array[5].ToString() != "")
                            lblbipol20.Text = bipolar3array[5].ToString();
                        if (bipolar3array[6].ToString() != "")
                            lblbipol21.Text = bipolar3array[6].ToString();

                    }
                }
            }
        }
    }

    public void Hide_perftable()
    {
        if (bipolarid == 0)
            bipolardiv.Visible = false;
        else
            lblbipolarmode.Text = "BiPloar Mode";
        if (bipolartr1 == 0)
        {
            tr_bipolar_1.Visible = false;
        }
        if (bipolartr2 == 0)
        {
            tr_bipolar_2.Visible = false;
        }
        if (bipolartr3 == 0)
        {
            tr_bipolar_3.Visible = false;
        }
    }
    public void showdiv_tr()
    {
        bipolardiv.Visible = true;
        tr_bipolar_1.Visible = true;
        tr_bipolar_2.Visible = true;
        tr_bipolar_3.Visible = true;
    }
}