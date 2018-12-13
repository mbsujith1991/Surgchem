using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_Temptest_autoclave : System.Web.UI.UserControl
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
    int temp_autoclaveid = 0, temp_autoclavetr1 = 0, temp_autoclavetr2 = 0, temp_autoclavetr3 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Temptest_autoclave(string sReportid,string sPerfid)
    {
       
         temp_autoclaveid++;
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
                    temp_autoclavetr1++;
                    string[] temp_autoclavearray1 = { };
                    StringBuilder sb_autocl1 = new StringBuilder();
                    sb_autocl1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_autocl1.ToString();
                    temp_autoclavearray1 = perfvalue1.Split(',');
                    if (temp_autoclavearray1.Count() > 0)
                    {
                        if (temp_autoclavearray1[0].ToString() != "")
                            lbltemp_auto1.Text = temp_autoclavearray1[0].ToString();
                        if (temp_autoclavearray1[1].ToString() != "")
                            lbltemp_auto2.Text = temp_autoclavearray1[1].ToString();
                        if (temp_autoclavearray1[2].ToString() != "")
                            lbltemp_auto3.Text = temp_autoclavearray1[2].ToString();
                        if (temp_autoclavearray1[3].ToString() != "")
                            lbltemp_auto4.Text = temp_autoclavearray1[3].ToString();
                        if (temp_autoclavearray1[4].ToString() != "")
                            lbltemp_auto5.Text = temp_autoclavearray1[4].ToString();
                        if (temp_autoclavearray1[5].ToString() != "")
                            lbltemp_auto6.Text = temp_autoclavearray1[5].ToString();
                        if (temp_autoclavearray1[6].ToString() != "")
                            lbltemp_auto7.Text = temp_autoclavearray1[6].ToString();
                        if (temp_autoclavearray1[7].ToString() != "")
                            lbltemp_auto8.Text = temp_autoclavearray1[7].ToString();
                        if (temp_autoclavearray1[8].ToString() != "")
                            lbltemp_auto9.Text = temp_autoclavearray1[8].ToString();
                        if (temp_autoclavearray1[9].ToString() != "")
                            lbltemp_auto10.Text = temp_autoclavearray1[9].ToString();
                        if (temp_autoclavearray1[10].ToString() != "")
                            lbltemp_auto11.Text = temp_autoclavearray1[10].ToString();




                    }
                }
                if (j == 1)
                {
                    temp_autoclavetr2++;
                    string[] temp_autoclavearray2 = { };
                    StringBuilder sb_auto2 = new StringBuilder();
                    sb_auto2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_auto2.ToString();
                    temp_autoclavearray2 = perfvalue1.Split(',');
                    if (temp_autoclavearray2.Count() > 0)
                    {
                        if (temp_autoclavearray2[0].ToString() != "")
                            lbltemp_auto12.Text = temp_autoclavearray2[0].ToString();
                        if (temp_autoclavearray2[1].ToString() != "")
                            lbltemp_auto13.Text = temp_autoclavearray2[1].ToString();
                        if (temp_autoclavearray2[2].ToString() != "")
                            lbltemp_auto14.Text = temp_autoclavearray2[2].ToString();
                        if (temp_autoclavearray2[3].ToString() != "")
                            lbltemp_auto15.Text = temp_autoclavearray2[3].ToString();
                        if (temp_autoclavearray2[4].ToString() != "")
                            lbltemp_auto16.Text = temp_autoclavearray2[4].ToString();
                        if (temp_autoclavearray2[5].ToString() != "")
                            lbltemp_auto17.Text = temp_autoclavearray2[5].ToString();
                        if (temp_autoclavearray2[6].ToString() != "")
                            lbltemp_auto18.Text = temp_autoclavearray2[6].ToString();
                        if (temp_autoclavearray2[7].ToString() != "")
                            lbltemp_auto19.Text = temp_autoclavearray2[7].ToString();
                        if (temp_autoclavearray2[8].ToString() != "")
                            lbltemp_auto20.Text = temp_autoclavearray2[8].ToString();
                        if (temp_autoclavearray2[9].ToString() != "")
                            lbltemp_auto21.Text = temp_autoclavearray2[9].ToString();
                        if (temp_autoclavearray2[10].ToString() != "")
                            lbltemp_auto22.Text = temp_autoclavearray2[10].ToString();


                    }
                }
                if (j == 2)
                {
                    temp_autoclavetr3++;
                    string[] temp_autoclavearray3 = { };
                    StringBuilder sb_auto3 = new StringBuilder();
                    sb_auto3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_auto3.ToString();
                    temp_autoclavearray3 = perfvalue1.Split(',');
                    if (temp_autoclavearray3.Count() > 0)
                    {
                        if (temp_autoclavearray3[0].ToString() != "")
                            lbltemp_auto23.Text = temp_autoclavearray3[0].ToString();
                        if (temp_autoclavearray3[1].ToString() != "")
                            lbltemp_auto24.Text = temp_autoclavearray3[1].ToString();
                        if (temp_autoclavearray3[2].ToString() != "")
                            lbltemp_auto25.Text = temp_autoclavearray3[2].ToString();
                        if (temp_autoclavearray3[3].ToString() != "")
                            lbltemp_auto26.Text = temp_autoclavearray3[3].ToString();
                        if (temp_autoclavearray3[4].ToString() != "")
                            lbltemp_auto27.Text = temp_autoclavearray3[4].ToString();
                        if (temp_autoclavearray3[5].ToString() != "")
                            lbltemp_auto28.Text = temp_autoclavearray3[5].ToString();
                        if (temp_autoclavearray3[6].ToString() != "")
                            lbltemp_auto29.Text = temp_autoclavearray3[6].ToString();
                        if (temp_autoclavearray3[7].ToString() != "")
                            lbltemp_auto30.Text = temp_autoclavearray3[7].ToString();
                        if (temp_autoclavearray3[8].ToString() != "")
                            lbltemp_auto31.Text = temp_autoclavearray3[8].ToString();
                        if (temp_autoclavearray3[9].ToString() != "")
                            lbltemp_auto32.Text = temp_autoclavearray3[9].ToString();
                        if (temp_autoclavearray3[10].ToString() != "")
                            lbltemp_auto33.Text = temp_autoclavearray3[10].ToString();


                    }
                }
            }
        }
    }

    public void showdiv_tr()
    {
        temp_autoclavediv.Visible = true;
        tr_tempautoclave1.Visible = true;
        tr_tempautoclave2.Visible = true;
        tr_tempautoclave3.Visible = true;
    }
    public void Hide_perftable()
    {
        if (temp_autoclaveid == 0)
            temp_autoclavediv.Visible = false;
        else
            lbltempautoclave.Text = "Temperature Test for Autoclave";
        if (temp_autoclavetr1 == 0)
            tr_tempautoclave1.Visible = false;
        if (temp_autoclavetr2 == 0)
            tr_tempautoclave2.Visible = false;
        if (temp_autoclavetr3 == 0)
            tr_tempautoclave3.Visible = false;

    }
}