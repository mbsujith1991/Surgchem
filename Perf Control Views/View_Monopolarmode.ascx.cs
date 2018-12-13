using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_Monopolarmode : System.Web.UI.UserControl
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
    int monopolarid = 0, monopolartr1 = 0, monopolartr2 = 0, monopolartr3 = 0, monopolartr4 = 0, monopolartr5 = 0, monopolartr6 = 0, monopolartr7 = 0, monopolartr8=0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_MonopolarMode(string sReportid, string sPerfid)
    {
        
         monopolarid++;
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
                            monopolartr1++;
                            string[] monoarray1 = { };
                            StringBuilder sb_mono1 = new StringBuilder();
                            sb_mono1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                            string perfvalue1 = sb_mono1.ToString();
                            monoarray1 = perfvalue1.Split(',');
                            if (monoarray1.Count() > 0)
                            {
                                if (monoarray1[0].ToString() != "")
                                    lblmon1.Text = monoarray1[0].ToString();
                                if (monoarray1[1].ToString() != "")
                                    lblmon2.Text = monoarray1[1].ToString();
                                if (monoarray1[2].ToString() != "")
                                    lblmon3.Text = monoarray1[2].ToString();
                                if (monoarray1[3].ToString() != "")
                                    lblmon4.Text = monoarray1[3].ToString();
                                if (monoarray1[4].ToString() != "")
                                    lblmon5.Text = monoarray1[4].ToString();
                                if (monoarray1[5].ToString() != "")
                                    lblmon6.Text = monoarray1[5].ToString();
                                if (monoarray1[6].ToString() != "")
                                    lblmon7.Text = monoarray1[6].ToString();

                            }
                        }
                        if (j == 1)
                        {
                            monopolartr2++;
                            string[] monoarray2 = { };
                            StringBuilder sb_mono2 = new StringBuilder();
                            sb_mono2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                            string perfvalue1 = sb_mono2.ToString();
                            monoarray2 = perfvalue1.Split(',');
                            if (monoarray2.Count() > 0)
                            {
                                if (monoarray2[0].ToString() != "")
                                    lblmon8.Text = monoarray2[0].ToString();
                                if (monoarray2[1].ToString() != "")
                                    lblmon9.Text = monoarray2[1].ToString();
                                if (monoarray2[2].ToString() != "")
                                    lblmon10.Text = monoarray2[2].ToString();
                                if (monoarray2[3].ToString() != "")
                                    lblmon11.Text = monoarray2[3].ToString();
                                if (monoarray2[4].ToString() != "")
                                    lblmon12.Text = monoarray2[4].ToString();
                                if (monoarray2[5].ToString() != "")
                                    lblmon13.Text = monoarray2[5].ToString();
                                if (monoarray2[6].ToString() != "")
                                    lblmon14.Text = monoarray2[6].ToString();

                            }
                        }
                        if (j == 2)
                        {
                            monopolartr3++;
                            string[] monoarray3 = { };
                            StringBuilder sb_mono3 = new StringBuilder();
                            sb_mono3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                            string perfvalue1 = sb_mono3.ToString();
                            monoarray3 = perfvalue1.Split(',');
                            if (monoarray3.Count() > 0)
                            {
                                if (monoarray3[0].ToString() != "")
                                    lblmon15.Text = monoarray3[0].ToString();
                                if (monoarray3[1].ToString() != "")
                                    lblmon16.Text = monoarray3[1].ToString();
                                if (monoarray3[2].ToString() != "")
                                    lblmon17.Text = monoarray3[2].ToString();
                                if (monoarray3[3].ToString() != "")
                                    lblmon18.Text = monoarray3[3].ToString();
                                if (monoarray3[4].ToString() != "")
                                    lblmon19.Text = monoarray3[4].ToString();
                                if (monoarray3[5].ToString() != "")
                                    lblmon20.Text = monoarray3[5].ToString();
                                if (monoarray3[6].ToString() != "")
                                    lblmon21.Text = monoarray3[6].ToString();
                            }
                        }
                        if (j == 3)
                        {
                            monopolartr4++;
                            string[] monoarray4 = { };
                            StringBuilder sb_mono4 = new StringBuilder();
                            sb_mono4.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                            string perfvalue1 = sb_mono4.ToString();
                            monoarray4 = perfvalue1.Split(',');
                            if (monoarray4.Count() > 0)
                            {
                                if (monoarray4[0].ToString() != "")
                                    lblmon22.Text = monoarray4[0].ToString();
                                if (monoarray4[1].ToString() != "")
                                    lblmon23.Text = monoarray4[1].ToString();
                                if (monoarray4[2].ToString() != "")
                                    lblmon24.Text = monoarray4[2].ToString();
                                if (monoarray4[3].ToString() != "")
                                    lblmon25.Text = monoarray4[3].ToString();
                                if (monoarray4[4].ToString() != "")
                                    lblmon26.Text = monoarray4[4].ToString();
                                if (monoarray4[5].ToString() != "")
                                    lblmon27.Text = monoarray4[5].ToString();
                                if (monoarray4[6].ToString() != "")
                                    lblmon28.Text = monoarray4[6].ToString();
                            }
                        }
                        if (j == 4)
                        {
                            monopolartr5++;
                            string[] monoarray5 = { };
                            StringBuilder sb_mono5 = new StringBuilder();
                            sb_mono5.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                            string perfvalue1 = sb_mono5.ToString();
                            monoarray5 = perfvalue1.Split(',');
                            if (monoarray5.Count() > 0)
                            {
                                if (monoarray5[0].ToString() != "")
                                    lblmon29.Text = monoarray5[0].ToString();
                                if (monoarray5[1].ToString() != "")
                                    lblmon30.Text = monoarray5[1].ToString();
                                if (monoarray5[2].ToString() != "")
                                    lblmon31.Text = monoarray5[2].ToString();
                                if (monoarray5[3].ToString() != "")
                                    lblmon32.Text = monoarray5[3].ToString();
                                if (monoarray5[4].ToString() != "")
                                    lblmon33.Text = monoarray5[4].ToString();
                                if (monoarray5[5].ToString() != "")
                                    lblmon34.Text = monoarray5[5].ToString();
                                if (monoarray5[6].ToString() != "")
                                    lblmon35.Text = monoarray5[6].ToString();
                            }
                        }
                        if (j == 5)
                        {
                            monopolartr6++;
                            string[] monoarray6 = { };
                            StringBuilder sb_mono6 = new StringBuilder();
                            sb_mono6.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                            string perfvalue1 = sb_mono6.ToString();
                            monoarray6 = perfvalue1.Split(',');
                            if (monoarray6.Count() > 0)
                            {
                                if (monoarray6[0].ToString() != "")
                                    lblmon36.Text = monoarray6[0].ToString();
                                if (monoarray6[1].ToString() != "")
                                    lblmon37.Text = monoarray6[1].ToString();
                                if (monoarray6[2].ToString() != "")
                                    lblmon38.Text = monoarray6[2].ToString();
                                if (monoarray6[3].ToString() != "")
                                    lblmon39.Text = monoarray6[3].ToString();
                                if (monoarray6[4].ToString() != "")
                                    lblmon40.Text = monoarray6[4].ToString();
                                if (monoarray6[5].ToString() != "")
                                    lblmon41.Text = monoarray6[5].ToString();
                                if (monoarray6[6].ToString() != "")
                                    lblmon42.Text = monoarray6[6].ToString();
                            }
                        }
                        if (j == 6)
                        {
                            monopolartr7++;
                            string[] monoarray7 = { };
                            StringBuilder sb_mono7 = new StringBuilder();
                            sb_mono7.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                            string perfvalue1 = sb_mono7.ToString();
                            monoarray7 = perfvalue1.Split(',');
                            if (monoarray7.Count() > 0)
                            {
                                if (monoarray7[0].ToString() != "")
                                    lblmon43.Text = monoarray7[0].ToString();
                                if (monoarray7[1].ToString() != "")
                                    lblmon44.Text = monoarray7[1].ToString();
                                if (monoarray7[2].ToString() != "")
                                    lblmon45.Text = monoarray7[2].ToString();
                                if (monoarray7[3].ToString() != "")
                                    lblmon46.Text = monoarray7[3].ToString();
                                if (monoarray7[4].ToString() != "")
                                    lblmon47.Text = monoarray7[4].ToString();
                                if (monoarray7[5].ToString() != "")
                                    lblmon48.Text = monoarray7[5].ToString();
                                if (monoarray7[6].ToString() != "")
                                    lblmon49.Text = monoarray7[6].ToString();
                            }
                        }
                        if (j == 7)
                        {
                            monopolartr8++;
                            string[] monoarray8 = { };
                            StringBuilder sb_mono8 = new StringBuilder();
                            sb_mono8.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                            string perfvalue1 = sb_mono8.ToString();
                            monoarray8 = perfvalue1.Split(',');
                            if (monoarray8.Count() > 0)
                            {
                                if (monoarray8[0].ToString() != "")
                                    lblmon50.Text = monoarray8[0].ToString();
                                if (monoarray8[1].ToString() != "")
                                    lblmon51.Text = monoarray8[1].ToString();
                                if (monoarray8[2].ToString() != "")
                                    lblmon52.Text = monoarray8[2].ToString();
                                if (monoarray8[3].ToString() != "")
                                    lblmon53.Text = monoarray8[3].ToString();
                                if (monoarray8[4].ToString() != "")
                                    lblmon54.Text = monoarray8[4].ToString();
                                if (monoarray8[5].ToString() != "")
                                    lblmon55.Text = monoarray8[5].ToString();
                                if (monoarray8[6].ToString() != "")
                                    lblmon56.Text = monoarray8[6].ToString();
                            }
                        }
                    }
                }
            
    }

    public void Hide_perftable()
    {
        if (monopolarid == 0)
            monopolardiv.Visible = false;
        else
            lblmonopolar.Text = "Monoploar Mode";
        if (monopolartr1 == 0)
            tr_mono1.Visible = false;
        if (monopolartr2 == 0)
            tr_mono2.Visible = false;
        if (monopolartr3 == 0)
            tr_mono3.Visible = false;
        if (monopolartr4 == 0)
            tr_mono4.Visible = false;
        if (monopolartr5 == 0)
            tr_mono5.Visible = false;
        if (monopolartr6 == 0)
            tr_mono6.Visible = false;
        if (monopolartr7 == 0)
            tr_mono7.Visible = false;
        if (monopolartr8 == 0)
            tr_mono8.Visible = false;
    }

    public void showdiv_tr()
    {
        monopolardiv.Visible = true;
        tr_mono1.Visible = true;
        tr_mono2.Visible = true;
        tr_mono3.Visible = true;
        tr_mono4.Visible = true;
        tr_mono5.Visible = true;
        tr_mono6.Visible = true;
        tr_mono7.Visible = true;
        tr_mono8.Visible = true;
    }
}