using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_vaccum_suction : System.Web.UI.UserControl
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
    int vaccumid = 0, vaccumtr1 = 0, vaccumtr2 = 0, vaccumtr3 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_vaccum(string sReportid, string sPerfid)
    {

        vaccumid++;
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
                    vaccumtr1++;
                    string[] vaccumarray1 = { };
                    StringBuilder sb_vaccum1 = new StringBuilder();
                    sb_vaccum1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_vaccum1.ToString();
                    vaccumarray1 = perfvalue1.Split(',');
                    if (vaccumarray1.Count() > 0)
                    {
                        if (vaccumarray1[0].ToString() != "")
                            lblvaccum1.Text = vaccumarray1[0].ToString();
                        if (vaccumarray1[1].ToString() != "")
                            lblvaccum2.Text = vaccumarray1[1].ToString();
                        if (vaccumarray1[2].ToString() != "")
                            lblvaccum3.Text = vaccumarray1[2].ToString();
                        if (vaccumarray1[3].ToString() != "")
                            lblvaccum4.Text = vaccumarray1[3].ToString();
                        if (vaccumarray1[4].ToString() != "")
                            lblvaccum5.Text = vaccumarray1[4].ToString();
                        if (vaccumarray1[5].ToString() != "")
                            lblvaccum6.Text = vaccumarray1[5].ToString();


                    }
                }
                if (j == 1)
                {
                    vaccumtr2++;
                    string[] vaccumarray2 = { };
                    StringBuilder sb_vaccum2 = new StringBuilder();
                    sb_vaccum2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue2 = sb_vaccum2.ToString();
                    vaccumarray2 = perfvalue2.Split(',');
                    if (vaccumarray2.Count() > 0)
                    {
                        if (vaccumarray2[0].ToString() != "")
                            lblvaccum7.Text = vaccumarray2[0].ToString();
                        if (vaccumarray2[1].ToString() != "")
                            lblvaccum8.Text = vaccumarray2[1].ToString();
                        if (vaccumarray2[2].ToString() != "")
                            lblvaccum9.Text = vaccumarray2[2].ToString();
                        if (vaccumarray2[3].ToString() != "")
                            lblvaccum10.Text = vaccumarray2[3].ToString();
                        if (vaccumarray2[4].ToString() != "")
                            lblvaccum11.Text = vaccumarray2[4].ToString();
                        if (vaccumarray2[5].ToString() != "")
                            lblvaccum12.Text = vaccumarray2[5].ToString();


                    }
                }
                if (j == 2)
                {
                    vaccumtr3++;
                    string[] vaccumarray3 = { };
                    StringBuilder sb_vaccum3 = new StringBuilder();
                    sb_vaccum3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue3 = sb_vaccum3.ToString();
                    vaccumarray3 = perfvalue3.Split(',');
                    if (vaccumarray3.Count() > 0)
                    {
                        if (vaccumarray3[0].ToString() != "")
                            lblvaccum13.Text = vaccumarray3[0].ToString();
                        if (vaccumarray3[1].ToString() != "")
                            lblvaccum14.Text = vaccumarray3[1].ToString();
                        if (vaccumarray3[2].ToString() != "")
                            lblvaccum15.Text = vaccumarray3[2].ToString();
                        if (vaccumarray3[3].ToString() != "")
                            lblvaccum16.Text = vaccumarray3[3].ToString();
                        if (vaccumarray3[4].ToString() != "")
                            lblvaccum17.Text = vaccumarray3[4].ToString();
                        if (vaccumarray3[5].ToString() != "")
                            lblvaccum18.Text = vaccumarray3[5].ToString();

                    }
                }

            }
        }
    }

    public void Hide_perftable()
    {
        if (vaccumid == 0)
            vaccumdiv.Visible = false;
        else
            lblvaccum.Text = "Vaccum Measurement";
        if (vaccumtr1 == 0)
        {
            tr_vaccum1.Visible = false;
        }
        if (vaccumtr2 == 0)
        {
            tr_vaccum2.Visible = false;
        }
        if (vaccumtr3 == 0)
        {
            tr_vaccum3.Visible = false;
        }

    }
    public void showdiv_tr()
    {
        vaccumdiv.Visible = true;
        tr_vaccum1.Visible = true;
        tr_vaccum2.Visible = true;
        tr_vaccum3.Visible = true;

    }

}