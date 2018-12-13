using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_PerfVentilator : System.Web.UI.UserControl
{
    Dbclass db1=new Dbclass();
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
    int perf_ventid = 0, venttr1 = 0, venttr2 = 0, venttr3 = 0, venttr4 = 0, venttr5 = 0, venttr6 = 0, venttr7 = 0, venttr8 = 0, venttr9 = 0, venttr10 = 0;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    
    public void Bind_Perf_Ventilator(string sReportid,string sPerfid)
    {
        perf_ventid++;
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
                    venttr1++;
                    string[] ventarray1 = { };
                    StringBuilder sb_vent1 = new StringBuilder();
                    sb_vent1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_vent1.ToString();
                    ventarray1 = perfvalue1.Split(',');
                    if (ventarray1.Count() > 0)
                    {
                        if (ventarray1[0].ToString() != "")
                            lblvent1.Text = ventarray1[0].ToString();
                        if (ventarray1[1].ToString() != "")
                            lblvent2.Text = ventarray1[1].ToString();
                        if (ventarray1[2].ToString() != "")
                            lblvent3.Text = ventarray1[2].ToString();
                        if (ventarray1[3].ToString() != "")
                            lblvent4.Text = ventarray1[3].ToString();
                        if (ventarray1[4].ToString() != "")
                            lblvent5.Text = ventarray1[4].ToString();
                        if (ventarray1[5].ToString() != "")
                            lblvent6.Text = ventarray1[5].ToString();
                        if (ventarray1[6].ToString() != "")
                            lblvent7.Text = ventarray1[6].ToString();


                    }
                }
                if (j == 1)
                {
                    venttr2++;
                    string[] ventarray2 = { };
                    StringBuilder sb_vent1 = new StringBuilder();
                    sb_vent1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_vent1.ToString();
                    ventarray2 = perfvalue1.Split(',');
                    if (ventarray2.Count() > 0)
                    {
                        if (ventarray2[0].ToString() != "")
                            lblvent8.Text = ventarray2[0].ToString();
                        if (ventarray2[1].ToString() != "")
                            lblvent9.Text = ventarray2[1].ToString();
                        if (ventarray2[2].ToString() != "")
                            lblvent10.Text = ventarray2[2].ToString();
                        if (ventarray2[3].ToString() != "")
                            lblvent11.Text = ventarray2[3].ToString();
                        if (ventarray2[4].ToString() != "")
                            lblvent13.Text = ventarray2[4].ToString();
                        if (ventarray2[5].ToString() != "")
                            lblvent13.Text = ventarray2[5].ToString();
                        if (ventarray2[6].ToString() != "")
                            lblvent14.Text = ventarray2[6].ToString();

                    }
                }
                if (j == 2)
                {
                    venttr3++;
                    string[] ventarray3 = { };
                    StringBuilder sb_vent3 = new StringBuilder();
                    sb_vent3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_vent3.ToString();
                    ventarray3 = perfvalue1.Split(',');
                    if (ventarray3.Count() > 0)
                    {
                        if (ventarray3[0].ToString() != "")
                            lblvent15.Text = ventarray3[0].ToString();
                        if (ventarray3[1].ToString() != "")
                            lblvent16.Text = ventarray3[1].ToString();
                        if (ventarray3[2].ToString() != "")
                            lblvent17.Text = ventarray3[2].ToString();
                        if (ventarray3[3].ToString() != "")
                            lblvent18.Text = ventarray3[3].ToString();
                        if (ventarray3[4].ToString() != "")
                            lblvent19.Text = ventarray3[4].ToString();
                        if (ventarray3[5].ToString() != "")
                            lblvent20.Text = ventarray3[5].ToString();
                        if (ventarray3[6].ToString() != "")
                            lblvent21.Text = ventarray3[6].ToString();

                    }
                }
                if (j == 3)
                {
                    venttr4++;
                    string[] ventarray4 = { };
                    StringBuilder sb_vent4 = new StringBuilder();
                    sb_vent4.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_vent4.ToString();
                    ventarray4 = perfvalue1.Split(',');
                    if (ventarray4.Count() > 0)
                    {
                        if (ventarray4[0].ToString() != "")
                            lblvent22.Text = ventarray4[0].ToString();
                        if (ventarray4[1].ToString() != "")
                            lblvent23.Text = ventarray4[1].ToString();
                        if (ventarray4[2].ToString() != "")
                            lblvent24.Text = ventarray4[2].ToString();
                        if (ventarray4[3].ToString() != "")
                            lblvent25.Text = ventarray4[3].ToString();
                        if (ventarray4[4].ToString() != "")
                            lblvent26.Text = ventarray4[4].ToString();
                        if (ventarray4[5].ToString() != "")
                            lblvent27.Text = ventarray4[5].ToString();
                        if (ventarray4[6].ToString() != "")
                            lblvent28.Text = ventarray4[6].ToString();

                    }
                }
                if (j == 4)
                {
                    venttr5++;
                    string[] ventarray5 = { };
                    StringBuilder sb_vent5 = new StringBuilder();
                    sb_vent5.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_vent5.ToString();
                    ventarray5 = perfvalue1.Split(',');
                    if (ventarray5.Count() > 0)
                    {
                        if (ventarray5[0].ToString() != "")
                            lblvent29.Text = ventarray5[0].ToString();
                        if (ventarray5[1].ToString() != "")
                            lblvent30.Text = ventarray5[1].ToString();
                        if (ventarray5[2].ToString() != "")
                            lblvent31.Text = ventarray5[2].ToString();
                        if (ventarray5[3].ToString() != "")
                            lblvent32.Text = ventarray5[3].ToString();
                        if (ventarray5[4].ToString() != "")
                            lblvent33.Text = ventarray5[4].ToString();
                        if (ventarray5[5].ToString() != "")
                            lblvent34.Text = ventarray5[5].ToString();
                        if (ventarray5[6].ToString() != "")
                            lblvent35.Text = ventarray5[6].ToString();

                    }
                }
                if (j == 5)
                {
                    venttr6++;
                    string[] ventarray6 = { };
                    StringBuilder sb_vent6 = new StringBuilder();
                    sb_vent6.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_vent6.ToString();
                    ventarray6 = perfvalue1.Split(',');
                    if (ventarray6.Count() > 0)
                    {
                        if (ventarray6[0].ToString() != "")
                            lblvent36.Text = ventarray6[0].ToString();
                        if (ventarray6[1].ToString() != "")
                            lblvent37.Text = ventarray6[1].ToString();
                        if (ventarray6[2].ToString() != "")
                            lblvent38.Text = ventarray6[2].ToString();
                        if (ventarray6[3].ToString() != "")
                            lblvent39.Text = ventarray6[3].ToString();
                        if (ventarray6[4].ToString() != "")
                            lblvent40.Text = ventarray6[4].ToString();
                        if (ventarray6[5].ToString() != "")
                            lblvent41.Text = ventarray6[5].ToString();
                        if (ventarray6[6].ToString() != "")
                            lblvent42.Text = ventarray6[6].ToString();

                    }
                }
                if (j == 6)
                {
                    venttr7++;
                    string[] ventarray7 = { };
                    StringBuilder sb_vent7 = new StringBuilder();
                    sb_vent7.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_vent7.ToString();
                    ventarray7 = perfvalue1.Split(',');
                    if (ventarray7.Count() > 0)
                    {
                        if (ventarray7[0].ToString() != "")
                            lblvent43.Text = ventarray7[0].ToString();
                        if (ventarray7[1].ToString() != "")
                            lblvent44.Text = ventarray7[1].ToString();
                        if (ventarray7[2].ToString() != "")
                            lblvent45.Text = ventarray7[2].ToString();
                        if (ventarray7[3].ToString() != "")
                            lblvent46.Text = ventarray7[3].ToString();
                        if (ventarray7[4].ToString() != "")
                            lblvent47.Text = ventarray7[4].ToString();
                        if (ventarray7[5].ToString() != "")
                            lblvent48.Text = ventarray7[5].ToString();
                        if (ventarray7[6].ToString() != "")
                            lblvent49.Text = ventarray7[6].ToString();

                    }
                }
                if (j == 7)
                {
                    venttr8++;
                    string[] ventarray8 = { };
                    StringBuilder sb_vent8 = new StringBuilder();
                    sb_vent8.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_vent8.ToString();
                    ventarray8 = perfvalue1.Split(',');
                    if (ventarray8.Count() > 0)
                    {
                        if (ventarray8[0].ToString() != "")
                            lblvent50.Text = ventarray8[0].ToString();
                        if (ventarray8[1].ToString() != "")
                            lblvent51.Text = ventarray8[1].ToString();
                        if (ventarray8[2].ToString() != "")
                            lblvent52.Text = ventarray8[2].ToString();
                        if (ventarray8[3].ToString() != "")
                            lblvent53.Text = ventarray8[3].ToString();
                        if (ventarray8[4].ToString() != "")
                            lblvent54.Text = ventarray8[4].ToString();
                        if (ventarray8[5].ToString() != "")
                            lblvent55.Text = ventarray8[5].ToString();
                        if (ventarray8[6].ToString() != "")
                            lblvent56.Text = ventarray8[6].ToString();

                    }
                }
                if (j == 8)
                {
                    venttr9++;
                    string[] ventarray9 = { };
                    StringBuilder sb_vent9 = new StringBuilder();
                    sb_vent9.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_vent9.ToString();
                    ventarray9 = perfvalue1.Split(',');
                    if (ventarray9.Count() > 0)
                    {
                        if (ventarray9[0].ToString() != "")
                            lblvent57.Text = ventarray9[0].ToString();
                        if (ventarray9[1].ToString() != "")
                            lblvent58.Text = ventarray9[1].ToString();
                        if (ventarray9[2].ToString() != "")
                            lblvent59.Text = ventarray9[2].ToString();
                        if (ventarray9[3].ToString() != "")
                            lblvent60.Text = ventarray9[3].ToString();
                        if (ventarray9[4].ToString() != "")
                            lblvent61.Text = ventarray9[4].ToString();
                        if (ventarray9[5].ToString() != "")
                            lblvent62.Text = ventarray9[5].ToString();
                        if (ventarray9[6].ToString() != "")
                            lblvent63.Text = ventarray9[6].ToString();

                    }
                }
                if (j == 9)
                {
                    venttr10++;
                    string[] ventarray10 = { };
                    StringBuilder sb_vent10 = new StringBuilder();
                    sb_vent10.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_vent10.ToString();
                    ventarray10 = perfvalue1.Split(',');
                    if (ventarray10.Count() > 0)
                    {
                        if (ventarray10[0].ToString() != "")
                            lblvent64.Text = ventarray10[0].ToString();
                        if (ventarray10[1].ToString() != "")
                            lblvent65.Text = ventarray10[1].ToString();
                        if (ventarray10[2].ToString() != "")
                            lblvent66.Text = ventarray10[2].ToString();
                        if (ventarray10[3].ToString() != "")
                            lblvent67.Text = ventarray10[3].ToString();
                        if (ventarray10[4].ToString() != "")
                            lblvent68.Text = ventarray10[4].ToString();
                        if (ventarray10[5].ToString() != "")
                            lblvent69.Text = ventarray10[5].ToString();
                        if (ventarray10[6].ToString() != "")
                            lblvent70.Text = ventarray10[6].ToString();

                    }
                }
            }
        }
     
    }
    public void Hide_perftable()
    {
        if (perf_ventid == 0)
            ventilatordiv.Visible = false;
        else
            lblperfventilator.Text = "Performance Analysis of Ventilator";
        if (venttr1 == 0)
            tr_vent1.Visible = false;
        if (venttr2 == 0)
            tr_vent2.Visible = false;
        if (venttr3 == 0)
            tr_vent3.Visible = false;
        if (venttr4 == 0)
            tr_vent4.Visible = false;
        if (venttr5 == 0)
            tr_vent5.Visible = false;
       
        if (venttr6 == 0)
            tr_vent6.Visible = false;
        if (venttr7 == 0)
            tr_vent7.Visible = false;
        if (venttr8 == 0)
            tr_vent8.Visible = false;
        if (venttr9 == 0)
            tr_vent9.Visible = false;
        if (venttr10 == 0)
            tr_vent10.Visible = false;
    }

    public void showdiv_tr()
    {
        ventilatordiv.Visible = true;
        tr_vent1.Visible = true;
        tr_vent2.Visible = true;
        tr_vent3.Visible = true;
        tr_vent4.Visible = true;
        tr_vent5.Visible = true;
        tr_vent6.Visible = true;
        tr_vent7.Visible = true;
        tr_vent8.Visible = true;
        tr_vent9.Visible = true;
        tr_vent10.Visible = true;
    }
}