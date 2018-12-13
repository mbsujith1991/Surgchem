using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;

public partial class Perf_Control_Views_View_Temp_Atflashcycle : System.Web.UI.UserControl
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
    int temp_flashcycleid = 0, flashtr1 = 0, flashtr2 = 0, flashtr3 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Temptest_flashcycle(string sReportid,string sPerfid)
    {
        
         temp_flashcycleid++;
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
                    flashtr1++;
                    string[] flasharray1 = { };
                    StringBuilder sb_flash1 = new StringBuilder();
                    sb_flash1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_flash1.ToString();
                    flasharray1 = perfvalue1.Split(',');
                    if (flasharray1.Count() > 0)
                    {
                        if (flasharray1[0].ToString() != "")
                            lblflash1.Text = flasharray1[0].ToString();
                        if (flasharray1[1].ToString() != "")
                            lblflash2.Text = flasharray1[1].ToString();
                        if (flasharray1[2].ToString() != "")
                            lblflash3.Text = flasharray1[2].ToString();
                        if (flasharray1[3].ToString() != "")
                            lblflash4.Text = flasharray1[3].ToString();
                        if (flasharray1[4].ToString() != "")
                            lblflash5.Text = flasharray1[4].ToString();
                        if (flasharray1[5].ToString() != "")
                            lblflash6.Text = flasharray1[5].ToString();
                        if (flasharray1[6].ToString() != "")
                            lblflash7.Text = flasharray1[6].ToString();
                        if (flasharray1[7].ToString() != "")
                            lblflash8.Text = flasharray1[7].ToString();
                        if (flasharray1[8].ToString() != "")
                            lblflash9.Text = flasharray1[8].ToString();
                        if (flasharray1[9].ToString() != "")
                            lblflash10.Text = flasharray1[9].ToString();
                        if (flasharray1[10].ToString() != "")
                            lblflash11.Text = flasharray1[10].ToString();




                    }
                }
                if (j == 1)
                {
                    flashtr2++;
                    string[] flasharray2 = { };
                    StringBuilder sb_flash2 = new StringBuilder();
                    sb_flash2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_flash2.ToString();
                    flasharray2 = perfvalue1.Split(',');
                    if (flasharray2.Count() > 0)
                    {
                        if (flasharray2[0].ToString() != "")
                            lblflash12.Text = flasharray2[0].ToString();
                        if (flasharray2[1].ToString() != "")
                            lblflash13.Text = flasharray2[1].ToString();
                        if (flasharray2[2].ToString() != "")
                            lblflash14.Text = flasharray2[2].ToString();
                        if (flasharray2[3].ToString() != "")
                            lblflash15.Text = flasharray2[3].ToString();
                        if (flasharray2[4].ToString() != "")
                            lblflash16.Text = flasharray2[4].ToString();
                        if (flasharray2[5].ToString() != "")
                            lblflash17.Text = flasharray2[5].ToString();
                        if (flasharray2[6].ToString() != "")
                            lblflash18.Text = flasharray2[6].ToString();
                        if (flasharray2[7].ToString() != "")
                            lblflash19.Text = flasharray2[7].ToString();
                        if (flasharray2[8].ToString() != "")
                            lblflash20.Text = flasharray2[8].ToString();
                        if (flasharray2[9].ToString() != "")
                            lblflash21.Text = flasharray2[9].ToString();
                        if (flasharray2[10].ToString() != "")
                            lblflash22.Text = flasharray2[10].ToString();


                    }
                }
                if (j == 2)
                {
                    flashtr3++;
                    string[] flasharray3 = { };
                    StringBuilder sb_flash3 = new StringBuilder();
                    sb_flash3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_flash3.ToString();
                    flasharray3 = perfvalue1.Split(',');
                    if (flasharray3.Count() > 0)
                    {
                        if (flasharray3[0].ToString() != "")
                            lblflash23.Text = flasharray3[0].ToString();
                        if (flasharray3[1].ToString() != "")
                            lblflash24.Text = flasharray3[1].ToString();
                        if (flasharray3[2].ToString() != "")
                            lblflash25.Text = flasharray3[2].ToString();
                        if (flasharray3[3].ToString() != "")
                            lblflash26.Text = flasharray3[3].ToString();
                        if (flasharray3[4].ToString() != "")
                            lblflash27.Text = flasharray3[4].ToString();
                        if (flasharray3[5].ToString() != "")
                            lblflash28.Text = flasharray3[5].ToString();
                        if (flasharray3[6].ToString() != "")
                            lblflash29.Text = flasharray3[6].ToString();
                        if (flasharray3[7].ToString() != "")
                            lblflash30.Text = flasharray3[7].ToString();
                        if (flasharray3[8].ToString() != "")
                            lblflash31.Text = flasharray3[8].ToString();
                        if (flasharray3[9].ToString() != "")
                            lblflash32.Text = flasharray3[9].ToString();
                        if (flasharray3[10].ToString() != "")
                            lblflash33.Text = flasharray3[10].ToString();


                    }
                }
            }
        }
    }

    public void showdiv_tr()
    {
        Flashcyclediv.Visible = true;
        tr_flash1.Visible = true;
        tr_flash2.Visible = true;
        tr_flash3.Visible = true;
    }
    public void Hide_perftable()
    {
        if (temp_flashcycleid == 0)
            Flashcyclediv.Visible = false;
        else
            lblflashcycle.Text = "Temperature Test for Autoclative Flash Cycle";
        if (flashtr1 == 0)
            tr_flash1.Visible = false;
        if (flashtr2 == 0)
            tr_flash2.Visible = false;
        if (flashtr3 == 0)
            tr_flash3.Visible = false;

    }
}