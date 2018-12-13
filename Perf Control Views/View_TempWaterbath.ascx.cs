using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_TempWaterbath : System.Web.UI.UserControl
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
    int temp_waterid = 0, temp_watertr1 = 0, temp_watertr2 = 0, temp_watertr3 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void Bind_Tempwaterbath(string sReportid, string sPerfid)
    {
        temp_waterid++;
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
                    temp_watertr1++;
                    string[] temp_waterarray1 = { };
                    StringBuilder sb_water1 = new StringBuilder();
                    sb_water1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_water1.ToString();
                    temp_waterarray1 = perfvalue1.Split(',');
                    if (temp_waterarray1.Count() > 0)
                    {
                        if (temp_waterarray1[0].ToString() != "")
                            lblwater1.Text = temp_waterarray1[0].ToString();
                        if (temp_waterarray1[1].ToString() != "")
                            lblwater2.Text = temp_waterarray1[1].ToString();
                        if (temp_waterarray1[2].ToString() != "")
                            lblwater3.Text = temp_waterarray1[2].ToString();
                        if (temp_waterarray1[3].ToString() != "")
                            lblwater4.Text = temp_waterarray1[3].ToString();
                        if (temp_waterarray1[4].ToString() != "")
                            lblwater5.Text = temp_waterarray1[4].ToString();
                        if (temp_waterarray1[5].ToString() != "")
                            lblwater6.Text = temp_waterarray1[5].ToString();
                        if (temp_waterarray1[6].ToString() != "")
                            lblwater7.Text = temp_waterarray1[6].ToString();
                        if (temp_waterarray1[7].ToString() != "")
                            lblwater8.Text = temp_waterarray1[7].ToString();
                        if (temp_waterarray1[8].ToString() != "")
                            lblwater9.Text = temp_waterarray1[8].ToString();
                        if (temp_waterarray1[9].ToString() != "")
                            lblwater10.Text = temp_waterarray1[9].ToString();
                        if (temp_waterarray1[10].ToString() != "")
                            lblwater11.Text = temp_waterarray1[10].ToString();




                    }
                }
                if (j == 1)
                {
                    temp_watertr2++;
                    string[] temp_waterarray2 = { };
                    StringBuilder sb_water2 = new StringBuilder();
                    sb_water2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_water2.ToString();
                    temp_waterarray2 = perfvalue1.Split(',');
                    if (temp_waterarray2.Count() > 0)
                    {
                        if (temp_waterarray2[0].ToString() != "")
                            lblwater12.Text = temp_waterarray2[0].ToString();
                        if (temp_waterarray2[1].ToString() != "")
                            lblwater13.Text = temp_waterarray2[1].ToString();
                        if (temp_waterarray2[2].ToString() != "")
                            lblwater14.Text = temp_waterarray2[2].ToString();
                        if (temp_waterarray2[3].ToString() != "")
                            lblwater15.Text = temp_waterarray2[3].ToString();
                        if (temp_waterarray2[4].ToString() != "")
                            lblwater16.Text = temp_waterarray2[4].ToString();
                        if (temp_waterarray2[5].ToString() != "")
                            lblwater17.Text = temp_waterarray2[5].ToString();
                        if (temp_waterarray2[6].ToString() != "")
                            lblwater18.Text = temp_waterarray2[6].ToString();
                        if (temp_waterarray2[7].ToString() != "")
                            lblwater19.Text = temp_waterarray2[7].ToString();
                        if (temp_waterarray2[8].ToString() != "")
                            lblwater20.Text = temp_waterarray2[8].ToString();
                        if (temp_waterarray2[9].ToString() != "")
                            lblwater21.Text = temp_waterarray2[9].ToString();
                        if (temp_waterarray2[10].ToString() != "")
                            lblwater22.Text = temp_waterarray2[10].ToString();


                    }
                }
                if (j == 2)
                {
                    temp_watertr3++;
                    string[] temp_waterarray3 = { };
                    StringBuilder sb_water3 = new StringBuilder();
                    sb_water3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_water3.ToString();
                    temp_waterarray3 = perfvalue1.Split(',');
                    if (temp_waterarray3.Count() > 0)
                    {
                        if (temp_waterarray3[0].ToString() != "")
                            lblwater23.Text = temp_waterarray3[0].ToString();
                        if (temp_waterarray3[1].ToString() != "")
                            lblwater24.Text = temp_waterarray3[1].ToString();
                        if (temp_waterarray3[2].ToString() != "")
                            lblwater25.Text = temp_waterarray3[2].ToString();
                        if (temp_waterarray3[3].ToString() != "")
                            lblwater26.Text = temp_waterarray3[3].ToString();
                        if (temp_waterarray3[4].ToString() != "")
                            lblwater27.Text = temp_waterarray3[4].ToString();
                        if (temp_waterarray3[5].ToString() != "")
                            lblwater28.Text = temp_waterarray3[5].ToString();
                        if (temp_waterarray3[6].ToString() != "")
                            lblwater29.Text = temp_waterarray3[6].ToString();
                        if (temp_waterarray3[7].ToString() != "")
                            lblwater30.Text = temp_waterarray3[7].ToString();
                        if (temp_waterarray3[8].ToString() != "")
                            lblwater31.Text = temp_waterarray3[8].ToString();
                        if (temp_waterarray3[9].ToString() != "")
                            lblwater32.Text = temp_waterarray3[9].ToString();
                        if (temp_waterarray3[10].ToString() != "")
                            lblwater33.Text = temp_waterarray3[10].ToString();


                    }
                }
            }
        }
    }

    public void showdiv_tr()
    {
        temp_waterdiv.Visible = true;
        tr_tempwater1.Visible = true;
        tr_tempwater2.Visible = true;
        tr_tempwater3.Visible = true;
    }
    public void Hide_perftable()
    {
        if (temp_waterid == 0)
            temp_waterdiv.Visible = false;
        else
            lbltempwater.Text = "Temperature Measurement WaterBath";
        if (temp_watertr1 == 0)
            tr_tempwater1.Visible = false;
        if (temp_watertr2 == 0)
            tr_tempwater2.Visible = false;
        if (temp_watertr3 == 0)
            tr_tempwater3.Visible = false;

    }
}