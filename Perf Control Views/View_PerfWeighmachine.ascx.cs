using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_PerfWeighmachine : System.Web.UI.UserControl
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
    int perfweighid = 0, perfweightr1 = 0, perfweightr2 = 0, perfweightr3 = 0, perfweightr4 = 0, perfweightr5 = 0, perfweightr6 = 0;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_perfweigh( string sReportid,string sPerfid)
    {
         perfweighid++;
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
                    perfweightr1++;
                    string[] perf_weigharray1 = { };
                    StringBuilder sb_perfweigh1 = new StringBuilder();
                    sb_perfweigh1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_perfweigh1.ToString();
                    perf_weigharray1 = perfvalue1.Split(',');
                    if (perf_weigharray1.Count() > 0)
                    {
                        if (perf_weigharray1[0].ToString() != "")
                            lblperfweigh1.Text = perf_weigharray1[0].ToString();
                        if (perf_weigharray1[1].ToString() != "")
                            lblperfweigh2.Text = perf_weigharray1[1].ToString();
                        if (perf_weigharray1[2].ToString() != "")
                            lblperfweigh3.Text = perf_weigharray1[2].ToString();
                        if (perf_weigharray1[3].ToString() != "")
                            lblperfweigh4.Text = perf_weigharray1[3].ToString();
                        if (perf_weigharray1[4].ToString() != "")
                            lblperfweigh5.Text = perf_weigharray1[4].ToString();
                        if (perf_weigharray1[5].ToString() != "")
                            lblperfweigh6.Text = perf_weigharray1[5].ToString();

                    }
                }
                if (j == 1)
                {
                    perfweightr2++;
                    string[] perf_weigharray2 = { };
                    StringBuilder sb_perfweigh2 = new StringBuilder();
                    sb_perfweigh2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_perfweigh2.ToString();
                    perf_weigharray2 = perfvalue1.Split(',');
                    if (perf_weigharray2.Count() > 0)
                    {
                        if (perf_weigharray2[0].ToString() != "")
                            lblperfweigh7.Text = perf_weigharray2[0].ToString();
                        if (perf_weigharray2[1].ToString() != "")
                            lblperfweigh8.Text = perf_weigharray2[1].ToString();
                        if (perf_weigharray2[2].ToString() != "")
                            lblperfweigh9.Text = perf_weigharray2[2].ToString();
                        if (perf_weigharray2[3].ToString() != "")
                            lblperfweigh10.Text = perf_weigharray2[3].ToString();
                        if (perf_weigharray2[4].ToString() != "")
                            lblperfweigh11.Text = perf_weigharray2[4].ToString();
                        if (perf_weigharray2[5].ToString() != "")
                            lblperfweigh12.Text = perf_weigharray2[5].ToString();


                    }
                }
                if (j == 2)
                {
                    perfweightr3++;
                    string[] perf_weigharray3 = { };
                    StringBuilder sb_perfweigh3 = new StringBuilder();
                    sb_perfweigh3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_perfweigh3.ToString();
                    perf_weigharray3 = perfvalue1.Split(',');
                    if (perf_weigharray3.Count() > 0)
                    {
                        if (perf_weigharray3[0].ToString() != "")
                            lblperfweigh13.Text = perf_weigharray3[0].ToString();
                        if (perf_weigharray3[1].ToString() != "")
                            lblperfweigh14.Text = perf_weigharray3[1].ToString();
                        if (perf_weigharray3[2].ToString() != "")
                            lblperfweigh15.Text = perf_weigharray3[2].ToString();
                        if (perf_weigharray3[3].ToString() != "")
                            lblperfweigh16.Text = perf_weigharray3[3].ToString();
                        if (perf_weigharray3[4].ToString() != "")
                            lblperfweigh17.Text = perf_weigharray3[4].ToString();
                        if (perf_weigharray3[5].ToString() != "")
                            lblperfweigh18.Text = perf_weigharray3[5].ToString();

                    }
                }
                if (j == 3)
                {
                    perfweightr4++;
                    string[] perf_weigharray4 = { };
                    StringBuilder sb_perfweigh4 = new StringBuilder();
                    sb_perfweigh4.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_perfweigh4.ToString();
                    perf_weigharray4 = perfvalue1.Split(',');
                    if (perf_weigharray4.Count() > 0)
                    {
                        if (perf_weigharray4[0].ToString() != "")
                            lblperfweigh19.Text = perf_weigharray4[0].ToString();
                        if (perf_weigharray4[1].ToString() != "")
                            lblperfweigh20.Text = perf_weigharray4[1].ToString();
                        if (perf_weigharray4[2].ToString() != "")
                            lblperfweigh21.Text = perf_weigharray4[2].ToString();
                        if (perf_weigharray4[3].ToString() != "")
                            lblperfweigh22.Text = perf_weigharray4[3].ToString();
                        if (perf_weigharray4[4].ToString() != "")
                            lblperfweigh23.Text = perf_weigharray4[4].ToString();
                        if (perf_weigharray4[5].ToString() != "")
                            lblperfweigh24.Text = perf_weigharray4[5].ToString();

                    }
                }
                if (j == 4)
                {
                    perfweightr5++;
                    string[] perf_weigharray5 = { };
                    StringBuilder sb_perfweigh5 = new StringBuilder();
                    sb_perfweigh5.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_perfweigh5.ToString();
                    perf_weigharray5 = perfvalue1.Split(',');
                    if (perf_weigharray5.Count() > 0)
                    {
                        if (perf_weigharray5[0].ToString() != "")
                            lblperfweigh25.Text = perf_weigharray5[0].ToString();
                        if (perf_weigharray5[1].ToString() != "")
                            lblperfweigh26.Text = perf_weigharray5[1].ToString();
                        if (perf_weigharray5[2].ToString() != "")
                            lblperfweigh27.Text = perf_weigharray5[2].ToString();
                        if (perf_weigharray5[3].ToString() != "")
                            lblperfweigh28.Text = perf_weigharray5[3].ToString();
                        if (perf_weigharray5[4].ToString() != "")
                            lblperfweigh29.Text = perf_weigharray5[4].ToString();
                        if (perf_weigharray5[5].ToString() != "")
                            lblperfweigh30.Text = perf_weigharray5[5].ToString();

                    }
                }
                if (j == 5)
                {
                    perfweightr1++;
                    string[] perf_weigharray6 = { };
                    StringBuilder sb_perfweigh6 = new StringBuilder();
                    sb_perfweigh6.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_perfweigh6.ToString();
                    perf_weigharray6 = perfvalue1.Split(',');
                    if (perf_weigharray6.Count() > 0)
                    {
                        if (perf_weigharray6[0].ToString() != "")
                            lblperfweigh31.Text = perf_weigharray6[0].ToString();
                        if (perf_weigharray6[1].ToString() != "")
                            lblperfweigh32.Text = perf_weigharray6[1].ToString();
                        if (perf_weigharray6[2].ToString() != "")
                            lblperfweigh33.Text = perf_weigharray6[2].ToString();
                        if (perf_weigharray6[3].ToString() != "")
                            lblperfweigh34.Text = perf_weigharray6[3].ToString();
                        if (perf_weigharray6[4].ToString() != "")
                            lblperfweigh35.Text = perf_weigharray6[4].ToString();
                        if (perf_weigharray6[5].ToString() != "")
                            lblperfweigh36.Text = perf_weigharray6[5].ToString();

                    }
                }
            }
        }

    }

    public void showdiv_tr()
    {
        perf_weighmachdiv.Visible = true;
        tr_weigh1.Visible = true;
        tr_weigh2.Visible = true;
        tr_weigh3.Visible = true;
        tr_weigh4.Visible = true;
        tr_weigh5.Visible = true;
        tr_weigh6.Visible = true;
    }
    public void Hide_perftable()
    {
        if (perfweighid == 0)
            perf_weighmachdiv.Visible = false;
        else
            lblperfweighing.Text = "Perform Analysis of Weighing Machine";
        if (perfweightr1 == 0)
            tr_weigh1.Visible = false;
        if (perfweightr2 == 0)
            tr_weigh2.Visible = false;
        if (perfweightr3 == 0)
            tr_weigh3.Visible = false;
        if (perfweightr4 == 0)
            tr_weigh4.Visible = false;
        if (perfweightr5 == 0)
            tr_weigh5.Visible = false;
        if (perfweightr6 == 0)
            tr_weigh6.Visible = false;

    }
}