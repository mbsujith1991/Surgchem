using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

public partial class Perf_Control_Views_View_TempFluidwarmer : System.Web.UI.UserControl
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
    int temp_fluidid = 0, temp_fluidtr1 = 0, temp_fluidtr2 = 0, temp_fluidtr3 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Temptest_fluidwarmer(string sReportid,string sPerfid)
    {
       
        temp_fluidid++;
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
                    temp_fluidtr1++;
                    string[] temp_fluidarray1 = { };
                    StringBuilder sb_fluid1 = new StringBuilder();
                    sb_fluid1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_fluid1.ToString();
                    temp_fluidarray1 = perfvalue1.Split(',');
                    if (temp_fluidarray1.Count() > 0)
                    {
                        if (temp_fluidarray1[0].ToString() != "")
                            lbltemp_fluid1.Text = temp_fluidarray1[0].ToString();
                        if (temp_fluidarray1[1].ToString() != "")
                            lbltemp_fluid2.Text = temp_fluidarray1[1].ToString();
                        if (temp_fluidarray1[2].ToString() != "")
                            lbltemp_fluid3.Text = temp_fluidarray1[2].ToString();
                        if (temp_fluidarray1[3].ToString() != "")
                            lbltemp_fluid4.Text = temp_fluidarray1[3].ToString();
                        if (temp_fluidarray1[4].ToString() != "")
                            lbltemp_fluid5.Text = temp_fluidarray1[4].ToString();
                        if (temp_fluidarray1[5].ToString() != "")
                            lbltemp_fluid6.Text = temp_fluidarray1[5].ToString();
                        if (temp_fluidarray1[6].ToString() != "")
                            lbltemp_fluid7.Text = temp_fluidarray1[6].ToString();
                        if (temp_fluidarray1[7].ToString() != "")
                            lbltemp_fluid8.Text = temp_fluidarray1[7].ToString();
                        if (temp_fluidarray1[8].ToString() != "")
                            lbltemp_fluid9.Text = temp_fluidarray1[8].ToString();
                        if (temp_fluidarray1[9].ToString() != "")
                            lbltemp_fluid10.Text = temp_fluidarray1[9].ToString();
                        if (temp_fluidarray1[10].ToString() != "")
                            lbltemp_fluid11.Text = temp_fluidarray1[10].ToString();




                    }
                }
                if (j == 1)
                {
                    temp_fluidtr2++;
                    string[] temp_fluidarray2 = { };
                    StringBuilder sb_fluid2 = new StringBuilder();
                    sb_fluid2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_fluid2.ToString();
                    temp_fluidarray2 = perfvalue1.Split(',');
                    if (temp_fluidarray2.Count() > 0)
                    {
                        if (temp_fluidarray2[0].ToString() != "")
                            lbltemp_fluid12.Text = temp_fluidarray2[0].ToString();
                        if (temp_fluidarray2[1].ToString() != "")
                            lbltemp_fluid13.Text = temp_fluidarray2[1].ToString();
                        if (temp_fluidarray2[2].ToString() != "")
                            lbltemp_fluid14.Text = temp_fluidarray2[2].ToString();
                        if (temp_fluidarray2[3].ToString() != "")
                            lbltemp_fluid15.Text = temp_fluidarray2[3].ToString();
                        if (temp_fluidarray2[4].ToString() != "")
                            lbltemp_fluid16.Text = temp_fluidarray2[4].ToString();
                        if (temp_fluidarray2[5].ToString() != "")
                            lbltemp_fluid17.Text = temp_fluidarray2[5].ToString();
                        if (temp_fluidarray2[6].ToString() != "")
                            lbltemp_fluid18.Text = temp_fluidarray2[6].ToString();
                        if (temp_fluidarray2[7].ToString() != "")
                            lbltemp_fluid19.Text = temp_fluidarray2[7].ToString();
                        if (temp_fluidarray2[8].ToString() != "")
                            lbltemp_fluid20.Text = temp_fluidarray2[8].ToString();
                        if (temp_fluidarray2[9].ToString() != "")
                            lbltemp_fluid21.Text = temp_fluidarray2[9].ToString();
                        if (temp_fluidarray2[10].ToString() != "")
                            lbltemp_fluid22.Text = temp_fluidarray2[10].ToString();


                    }
                }
                if (j == 2)
                {
                    temp_fluidtr3++;
                    string[] temp_fluidarray3 = { };
                    StringBuilder sb_fluid3 = new StringBuilder();
                    sb_fluid3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_fluid3.ToString();
                    temp_fluidarray3 = perfvalue1.Split(',');
                    if (temp_fluidarray3.Count() > 0)
                    {
                        if (temp_fluidarray3[0].ToString() != "")
                            lbltemp_fluid23.Text = temp_fluidarray3[0].ToString();
                        if (temp_fluidarray3[1].ToString() != "")
                            lbltemp_fluid24.Text = temp_fluidarray3[1].ToString();
                        if (temp_fluidarray3[2].ToString() != "")
                            lbltemp_fluid25.Text = temp_fluidarray3[2].ToString();
                        if (temp_fluidarray3[3].ToString() != "")
                            lbltemp_fluid26.Text = temp_fluidarray3[3].ToString();
                        if (temp_fluidarray3[4].ToString() != "")
                            lbltemp_fluid27.Text = temp_fluidarray3[4].ToString();
                        if (temp_fluidarray3[5].ToString() != "")
                            lbltemp_fluid28.Text = temp_fluidarray3[5].ToString();
                        if (temp_fluidarray3[6].ToString() != "")
                            lbltemp_fluid29.Text = temp_fluidarray3[6].ToString();
                        if (temp_fluidarray3[7].ToString() != "")
                            lbltemp_fluid30.Text = temp_fluidarray3[7].ToString();
                        if (temp_fluidarray3[8].ToString() != "")
                            lbltemp_fluid31.Text = temp_fluidarray3[8].ToString();
                        if (temp_fluidarray3[9].ToString() != "")
                            lbltemp_fluid32.Text = temp_fluidarray3[9].ToString();
                        if (temp_fluidarray3[10].ToString() != "")
                            lbltemp_fluid33.Text = temp_fluidarray3[10].ToString();


                    }
                }
            }
        }
    }

    public void showdiv_tr()
    {
        fluidwarmerdiv.Visible = true;
        tr_tempfluid1.Visible = true;
        tr_tempfluid2.Visible = true;
        tr_tempfluid3.Visible = true;
    }
    public void Hide_perftable()
    {
        if (temp_fluidid == 0)
            fluidwarmerdiv.Visible = false;
        else
            lblfluid.Text = "Temperature Measurement of Fluid warmer";
        if (temp_fluidtr1 == 0)
            tr_tempfluid1.Visible = false;
        if (temp_fluidtr2 == 0)
            tr_tempfluid2.Visible = false;
        if (temp_fluidtr3 == 0)
            tr_tempfluid3.Visible = false;

    }
}