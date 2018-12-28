using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Perf_Control_Views_View_Perf_micropipetteNew : System.Web.UI.UserControl
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
    int microPiptId = 0, microPiptTr1 = 0, microPiptTr2 = 0, microPiptTr3 = 0, microPiptTr4 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void Bind_MicroPipetteData(string sReportid, string sPerfid)
    {

        microPiptId++;
        db1.strCommand = "select Perf_Value from Performance_Values where " +
            "Report_info_ID='" + sReportid + "' and PerfID='" + sPerfid + "'";
        DataTable dt_value = db1.selecttable();

        if (dt_value.Rows.Count > 0)
        {
            for (int j = 0; j < dt_value.Rows.Count; j++)
            {
                if (j == 0)
                {
                    microPiptTr1++;
                    string[] microPiptArray1 = { };
                    StringBuilder sb_MicroPipt1 = new StringBuilder();
                    sb_MicroPipt1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_MicroPipt1.ToString();
                    microPiptArray1 = perfvalue1.Split(',');
                    if (microPiptArray1.Count() > 0)
                    {
                        if (microPiptArray1[0].ToString() != "")
                            lbl_micropipt1_1.Text = microPiptArray1[0].ToString();
                        if (microPiptArray1[1].ToString() != "")
                            lbl_micropipt1_2.Text = microPiptArray1[1].ToString();
                        if (microPiptArray1[2].ToString() != "")
                            lbl_micropipt1_3.Text = microPiptArray1[2].ToString();
                        if (microPiptArray1[3].ToString() != "")
                            lbl_micropipt1_4.Text = microPiptArray1[3].ToString();
                        if (microPiptArray1[4].ToString() != "")
                            lbl_micropipt1_5.Text = microPiptArray1[4].ToString();
                        if (microPiptArray1[5].ToString() != "")
                            lbl_micropipt1_6.Text = microPiptArray1[5].ToString();
                    }
                }
                if (j == 1)
                {
                    microPiptTr2++;
                    string[] microPiptArray2 = { };
                    StringBuilder sb_MicroPipt2 = new StringBuilder();
                    sb_MicroPipt2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_MicroPipt2.ToString();
                    microPiptArray2 = perfvalue1.Split(',');
                    if (microPiptArray2.Count() > 0)
                    {
                        if (microPiptArray2[0].ToString() != "")
                            lbl_micropipt2_1.Text = microPiptArray2[0].ToString();
                        if (microPiptArray2[1].ToString() != "")
                            lbl_micropipt2_2.Text = microPiptArray2[1].ToString();
                        if (microPiptArray2[2].ToString() != "")
                            lbl_micropipt2_3.Text = microPiptArray2[2].ToString();
                        if (microPiptArray2[3].ToString() != "")
                            lbl_micropipt2_4.Text = microPiptArray2[3].ToString();
                        if (microPiptArray2[4].ToString() != "")
                            lbl_micropipt2_5.Text = microPiptArray2[4].ToString();
                        if (microPiptArray2[5].ToString() != "")
                            lbl_micropipt2_6.Text = microPiptArray2[5].ToString();
                    }
                }
                if (j == 2)
                {
                    microPiptTr3++;
                    string[] microPiptArray3 = { };
                    StringBuilder sb_MicroPipt3 = new StringBuilder();
                    sb_MicroPipt3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_MicroPipt3.ToString();
                    microPiptArray3 = perfvalue1.Split(',');
                    if (microPiptArray3.Count() > 0)
                    {
                        if (microPiptArray3[0].ToString() != "")
                            lbl_micropipt3_1.Text = microPiptArray3[0].ToString();
                        if (microPiptArray3[1].ToString() != "")
                            lbl_micropipt3_2.Text = microPiptArray3[1].ToString();
                        if (microPiptArray3[2].ToString() != "")
                            lbl_micropipt3_3.Text = microPiptArray3[2].ToString();
                        if (microPiptArray3[3].ToString() != "")
                            lbl_micropipt3_4.Text = microPiptArray3[3].ToString();
                        if (microPiptArray3[4].ToString() != "")
                            lbl_micropipt3_5.Text = microPiptArray3[4].ToString();
                        if (microPiptArray3[5].ToString() != "")
                            lbl_micropipt3_6.Text = microPiptArray3[5].ToString();
                    }
                }
                if (j == 3)
                {
                    microPiptTr4++;
                    string[] microPiptArray4 = { };
                    StringBuilder sb_MicroPipt4 = new StringBuilder();
                    sb_MicroPipt4.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_MicroPipt4.ToString();
                    microPiptArray4 = perfvalue1.Split(',');
                    if (microPiptArray4.Count() > 0)
                    {
                        if (microPiptArray4[0].ToString() != "")
                            lbl_micropipt4_1.Text = microPiptArray4[0].ToString();
                        if (microPiptArray4[1].ToString() != "")
                            lbl_micropipt4_2.Text = microPiptArray4[1].ToString();
                        if (microPiptArray4[2].ToString() != "")
                            lbl_micropipt4_3.Text = microPiptArray4[2].ToString();
                        if (microPiptArray4[3].ToString() != "")
                            lbl_micropipt4_4.Text = microPiptArray4[3].ToString();
                        if (microPiptArray4[4].ToString() != "")
                            lbl_micropipt4_5.Text = microPiptArray4[4].ToString();
                        if (microPiptArray4[5].ToString() != "")
                            lbl_micropipt4_6.Text = microPiptArray4[5].ToString();
                    }
                }
            }
        }

    }

    public void showdiv_tr()
    {
        perfholterdiv.Visible = true;
        tr_microPipt1.Visible = true;
        tr_microPipt2.Visible = true;
        tr_microPipt3.Visible = true;
        tr_microPipt4.Visible = true;
    }
    public void Hide_perftable()
    {
        if (microPiptId == 0)
            perfholterdiv.Visible = false;
        else
            lblperfholter.Text = "Performance Analysis Micropipette";
        if (microPiptTr1 == 0)
            tr_microPipt1.Visible = false;
        if (microPiptTr2 == 0)
            tr_microPipt2.Visible = false;
        if (microPiptTr3 == 0)
            tr_microPipt3.Visible = false;
        if (microPiptTr4 == 0)
            tr_microPipt4.Visible = false;


    }
}