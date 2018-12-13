using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_TempMeasure : System.Web.UI.UserControl
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
    int tempid = 0, temptr1 = 0, temptr2 = 0, temptr3 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_TempMeasure(string sReportid, string sPerfid)
    {
        
        tempid++;
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
                    temptr1++;
                    string[] perftemp1array = { };
                    StringBuilder sb_temp1 = new StringBuilder();
                    sb_temp1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_temp1.ToString();
                    perftemp1array = perfvalue1.Split(',');
                    if (perftemp1array.Count() > 0)
                    {
                        if (perftemp1array[0].ToString() != "")
                            lbtemp1.Text = perftemp1array[0].ToString();
                        if (perftemp1array[1].ToString() != "")
                            lbtemp2.Text = perftemp1array[1].ToString();
                        if (perftemp1array[2].ToString() != "")
                            lbtemp3.Text = perftemp1array[2].ToString();
                        if (perftemp1array[3].ToString() != "")
                            lbtemp4.Text = perftemp1array[3].ToString();
                        if (perftemp1array[4].ToString() != "")
                            lbtemp5.Text = perftemp1array[4].ToString();
                        if (perftemp1array[5].ToString() != "")
                            lbtemp6.Text = perftemp1array[5].ToString();
                        if (perftemp1array[6].ToString() != "")
                            lbtemp7.Text = perftemp1array[6].ToString();
                        if (perftemp1array[7].ToString() != "")
                            lbtemp8.Text = perftemp1array[7].ToString();
                        if (perftemp1array[8].ToString() != "")
                            lbtemp9.Text = perftemp1array[8].ToString();

                    }
                }
                if (j == 1)
                {
                    temptr2++;
                    string[] perftemp2array = { };
                    StringBuilder sb_temp2 = new StringBuilder();
                    sb_temp2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue2 = sb_temp2.ToString();
                    perftemp2array = perfvalue2.Split(',');
                    if (perftemp2array.Count() > 0)
                    {

                        if (perftemp2array[0].ToString() != "")
                            lbtemp10.Text = perftemp2array[0].ToString();
                        if (perftemp2array[1].ToString() != "")
                            lbtemp11.Text = perftemp2array[1].ToString();
                        if (perftemp2array[2].ToString() != "")
                            lbtemp12.Text = perftemp2array[2].ToString();
                        if (perftemp2array[3].ToString() != "")
                            lbtemp13.Text = perftemp2array[3].ToString();
                        if (perftemp2array[4].ToString() != "")
                            lbtemp14.Text = perftemp2array[4].ToString();
                        if (perftemp2array[5].ToString() != "")
                            lbtemp15.Text = perftemp2array[5].ToString();
                        if (perftemp2array[6].ToString() != "")
                            lbtemp16.Text = perftemp2array[6].ToString();
                        if (perftemp2array[7].ToString() != "")
                            lbtemp17.Text = perftemp2array[7].ToString();
                        if (perftemp2array[8].ToString() != "")
                            lbtemp18.Text = perftemp2array[8].ToString();
                    }
                }
                if (j == 2)
                {
                    temptr3++;
                    string[] perftemp3array = { };
                    StringBuilder sb_temp3 = new StringBuilder();
                    sb_temp3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue3 = sb_temp3.ToString();
                    perftemp3array = perfvalue3.Split(',');
                    if (perftemp3array.Count() > 0)
                    {
                        if (perftemp3array[0].ToString() != "")
                            lbtemp19.Text = perftemp3array[0].ToString();
                        if (perftemp3array[1].ToString() != "")
                            lbtemp20.Text = perftemp3array[1].ToString();
                        if (perftemp3array[2].ToString() != "")
                            lbtemp21.Text = perftemp3array[2].ToString();
                        if (perftemp3array[3].ToString() != "")
                            lbtemp22.Text = perftemp3array[3].ToString();
                        if (perftemp3array[4].ToString() != "")
                            lbtemp23.Text = perftemp3array[4].ToString();
                        if (perftemp3array[5].ToString() != "")
                            lbtemp24.Text = perftemp3array[5].ToString();
                        if (perftemp3array[6].ToString() != "")
                            lbtemp25.Text = perftemp3array[6].ToString();
                        if (perftemp3array[7].ToString() != "")
                            lbtemp26.Text = perftemp3array[7].ToString();
                        if (perftemp3array[8].ToString() != "")
                            lbtemp27.Text = perftemp3array[8].ToString();

                    }
                }
             

            }


        }
    }
    public void Hide_perftable()
    {
        if (tempid == 0)
            tempmeasurediv.Visible = false;
        else
            lblperformancename6.Text = "Temperature Measurement";
        if (temptr1 == 0)
            temp_1.Visible = false;
        if (temptr2 == 0)
            temp_2.Visible = false;
        if (temptr3 == 0)
            temp_3.Visible = false;
       
    }
    public void showdiv_tr()
    {
        tempmeasurediv.Visible = true;
        temp_1.Visible = true;
        temp_2.Visible = true;
        temp_3.Visible = true;
        
    }
}