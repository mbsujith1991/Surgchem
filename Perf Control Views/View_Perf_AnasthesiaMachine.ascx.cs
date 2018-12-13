using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_Perf_AnasthesiaMachine : System.Web.UI.UserControl
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
    int perf_anasid = 0, anastr1 = 0, anastr2 = 0, anastr3 = 0, anastr4 = 0, anastr5 = 0, anastr6 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Perf_Anasthesia(string sReportid,string sPerfid)
    {
       
        perf_anasid++;
        db1.strCommand = "select Perf_Value from Performance_Values where " +
            "Report_info_ID='" + sReportid + "' and PerfID='" + sPerfid + "'";
        DataTable dt_value = db1.selecttable();
        if (dt_value.Rows.Count > 0)
        {
            //object[] valarray=new object[dt_value.Rows.Count];
            for (int j = 0; j < dt_value.Rows.Count; j++)
            {


                // View_Perf_AnasthesiaMachine.Bind_Perf_Anasthesia();

                if (j == 0)
                {
                    anastr1++;
                    string[] anasarray1 = { };
                    StringBuilder sb_anas1 = new StringBuilder();
                    sb_anas1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_anas1.ToString();
                    anasarray1 = perfvalue1.Split(',');
                    if (anasarray1.Count() > 0)
                    {
                        if (anasarray1[0].ToString() != "")
                            lblanas1.Text = anasarray1[0].ToString();
                        if (anasarray1[1].ToString() != "")
                            lblanas2.Text = anasarray1[1].ToString();
                        if (anasarray1[2].ToString() != "")
                            lblanas3.Text = anasarray1[2].ToString();
                        if (anasarray1[3].ToString() != "")
                            lblanas4.Text = anasarray1[3].ToString();
                        if (anasarray1[4].ToString() != "")
                            lblanas5.Text = anasarray1[4].ToString();
                        if (anasarray1[5].ToString() != "")
                            lblanas6.Text = anasarray1[5].ToString();
                        if (anasarray1[6].ToString() != "")
                            lblanas7.Text = anasarray1[6].ToString();


                    }
                }
                if (j == 1)
                {
                    anastr2++;
                    string[] anasarray2 = { };
                    StringBuilder sb_anas1 = new StringBuilder();
                    sb_anas1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_anas1.ToString();
                    anasarray2 = perfvalue1.Split(',');
                    if (anasarray2.Count() > 0)
                    {
                        if (anasarray2[0].ToString() != "")
                            lblanas8.Text = anasarray2[0].ToString();
                        if (anasarray2[1].ToString() != "")
                            lblanas9.Text = anasarray2[1].ToString();
                        if (anasarray2[2].ToString() != "")
                            lblanas10.Text = anasarray2[2].ToString();
                        if (anasarray2[3].ToString() != "")
                            lblanas11.Text = anasarray2[3].ToString();
                        if (anasarray2[4].ToString() != "")
                            lblanas12.Text = anasarray2[4].ToString();
                        if (anasarray2[5].ToString() != "")
                            lblanas13.Text = anasarray2[5].ToString();
                        if (anasarray2[6].ToString() != "")
                            lblanas14.Text = anasarray2[6].ToString();

                    }
                }
                if (j == 2)
                {
                    anastr3++;
                    string[] anasarray3 = { };
                    StringBuilder sb_anas3 = new StringBuilder();
                    sb_anas3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_anas3.ToString();
                    anasarray3 = perfvalue1.Split(',');
                    if (anasarray3.Count() > 0)
                    {
                        if (anasarray3[0].ToString() != "")
                            lblanas15.Text = anasarray3[0].ToString();
                        if (anasarray3[1].ToString() != "")
                            lblanas16.Text = anasarray3[1].ToString();
                        if (anasarray3[2].ToString() != "")
                            lblanas17.Text = anasarray3[2].ToString();
                        if (anasarray3[3].ToString() != "")
                            lblanas18.Text = anasarray3[3].ToString();
                        if (anasarray3[4].ToString() != "")
                            lblanas19.Text = anasarray3[4].ToString();
                        if (anasarray3[5].ToString() != "")
                            lblanas20.Text = anasarray3[5].ToString();
                        if (anasarray3[6].ToString() != "")
                            lblanas21.Text = anasarray3[6].ToString();

                    }
                }
                if (j == 3)
                {
                    anastr4++;
                    string[] anasrarray4 = { };
                    StringBuilder sb_anas4 = new StringBuilder();
                    sb_anas4.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_anas4.ToString();
                    anasrarray4 = perfvalue1.Split(',');
                    if (anasrarray4.Count() > 0)
                    {
                        if (anasrarray4[0].ToString() != "")
                            lblanas22.Text = anasrarray4[0].ToString();
                        if (anasrarray4[1].ToString() != "")
                            lblanas23.Text = anasrarray4[1].ToString();
                        if (anasrarray4[2].ToString() != "")
                            lblanas24.Text = anasrarray4[2].ToString();
                        if (anasrarray4[3].ToString() != "")
                            lblanas25.Text = anasrarray4[3].ToString();
                        if (anasrarray4[4].ToString() != "")
                            lblanas26.Text = anasrarray4[4].ToString();
                        if (anasrarray4[5].ToString() != "")
                            lblanas27.Text = anasrarray4[5].ToString();
                        if (anasrarray4[6].ToString() != "")
                            lblanas28.Text = anasrarray4[6].ToString();

                    }
                }
                if (j == 4)
                {
                    anastr5++;
                    string[] anasarray5 = { };
                    StringBuilder sb_anas5 = new StringBuilder();
                    sb_anas5.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_anas5.ToString();
                    anasarray5 = perfvalue1.Split(',');
                    if (anasarray5.Count() > 0)
                    {
                        if (anasarray5[0].ToString() != "")
                            lblanas29.Text = anasarray5[0].ToString();
                        if (anasarray5[1].ToString() != "")
                            lblanas30.Text = anasarray5[1].ToString();
                        if (anasarray5[2].ToString() != "")
                            lblanas31.Text = anasarray5[2].ToString();
                        if (anasarray5[3].ToString() != "")
                            lblanas32.Text = anasarray5[3].ToString();
                        if (anasarray5[4].ToString() != "")
                            lblanas33.Text = anasarray5[4].ToString();
                        if (anasarray5[5].ToString() != "")
                            lblanas34.Text = anasarray5[5].ToString();
                        if (anasarray5[6].ToString() != "")
                            lblanas35.Text = anasarray5[6].ToString();

                    }
                }
                if (j == 5)
                {
                    anastr6++;
                    string[] anasarray6 = { };
                    StringBuilder sb_anas6 = new StringBuilder();
                    sb_anas6.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_anas6.ToString();
                    anasarray6 = perfvalue1.Split(',');
                    if (anasarray6.Count() > 0)
                    {
                        if (anasarray6[0].ToString() != "")
                            lblanas36.Text = anasarray6[0].ToString();
                        if (anasarray6[1].ToString() != "")
                            lblanas37.Text = anasarray6[1].ToString();
                        if (anasarray6[2].ToString() != "")
                            lblanas38.Text = anasarray6[2].ToString();
                        if (anasarray6[3].ToString() != "")
                            lblanas39.Text = anasarray6[3].ToString();
                        if (anasarray6[4].ToString() != "")
                            lblanas40.Text = anasarray6[4].ToString();
                        if (anasarray6[5].ToString() != "")
                            lblanas41.Text = anasarray6[5].ToString();
                        if (anasarray6[6].ToString() != "")
                            lblanas42.Text = anasarray6[6].ToString();

                    }
                }
            }
        }
    }
    public void Hide_perftable()
    {
        if (perf_anasid == 0)
            anasthesiadiv.Visible = false;
        else
            lblperfanasthesia.Text = "Performance Analysis of Anasthesia Machine";
        if (anastr1 == 0)
            tr_anas1.Visible = false;
        if (anastr2 == 0)
            tr_anas2.Visible = false;
        if (anastr3 == 0)
            tr_anas3.Visible = false;
        if (anastr4 == 0)
            tr_anas4.Visible = false;
        if (anastr5 == 0)
            tr_anas5.Visible = false;
        if (anastr6 == 0)
            tr_anas6.Visible = false;
    }

    public void showdiv_tr()
    {
        anasthesiadiv.Visible = true;
        tr_anas1.Visible = true;
        tr_anas2.Visible = true;
        tr_anas3.Visible = true;
        tr_anas4.Visible = true;
        tr_anas5.Visible = true;
        tr_anas6.Visible = true;
    }
}