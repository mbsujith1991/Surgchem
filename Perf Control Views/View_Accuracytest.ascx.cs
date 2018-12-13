using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_Accuracytest : System.Web.UI.UserControl
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
    int accuracyid = 0, accuracytr1 = 0, accuracytr2 = 0, accuracytr3 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Accuracytest(string sReportid, string sPerfid)
    {
        
        accuracyid++;
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
                    accuracytr1++;
                    string[] perfaccuracy1array = { };
                    StringBuilder sb_accu1 = new StringBuilder();
                    sb_accu1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_accu1.ToString();
                    perfaccuracy1array = perfvalue1.Split(',');
                    if (perfaccuracy1array.Count() > 0)
                    {
                        if (perfaccuracy1array[0].ToString() != "")
                            lbaccu1.Text = perfaccuracy1array[0].ToString();
                        if (perfaccuracy1array[1].ToString() != "")
                            lbaccu2.Text = perfaccuracy1array[1].ToString();
                        if (perfaccuracy1array[2].ToString() != "")
                            lbaccu3.Text = perfaccuracy1array[2].ToString();
                        if (perfaccuracy1array[3].ToString() != "")
                            lbaccu4.Text = perfaccuracy1array[3].ToString();
                        if (perfaccuracy1array[4].ToString() != "")
                            lbaccu5.Text = perfaccuracy1array[4].ToString();
                        if (perfaccuracy1array[5].ToString() != "")
                            lbaccu6.Text = perfaccuracy1array[5].ToString();
                        if (perfaccuracy1array[6].ToString() != "")
                            lbaccu7.Text = perfaccuracy1array[6].ToString();
                        if (perfaccuracy1array[7].ToString() != "")
                            lbaccu8.Text = perfaccuracy1array[7].ToString();
                        if (perfaccuracy1array[8].ToString() != "")
                            lbaccu9.Text = perfaccuracy1array[8].ToString();
                       
                        if (perfaccuracy1array[9].ToString() != "")
                            lbaccu11.Text = perfaccuracy1array[9].ToString();
                        if (perfaccuracy1array[10].ToString() != "")
                            lbaccu12.Text = perfaccuracy1array[10].ToString();
                    }
                }
                if (j == 1)
                {
                    accuracytr2++;
                    string[] perfaccuracy2array = { };
                    StringBuilder sb_accu2 = new StringBuilder();
                    sb_accu2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue2 = sb_accu2.ToString();
                    perfaccuracy2array = perfvalue2.Split(',');
                    if (perfaccuracy2array.Count() > 0)
                    {
                        if (perfaccuracy2array[0].ToString() != "")
                            lbaccu13.Text = perfaccuracy2array[0].ToString();
                        if (perfaccuracy2array[1].ToString() != "")
                            lbaccu14.Text = perfaccuracy2array[1].ToString();
                        if (perfaccuracy2array[2].ToString() != "")
                            lbaccu15.Text = perfaccuracy2array[2].ToString();
                        if (perfaccuracy2array[3].ToString() != "")
                            lbaccu16.Text = perfaccuracy2array[3].ToString();
                        if (perfaccuracy2array[4].ToString() != "")
                            lbaccu17.Text = perfaccuracy2array[4].ToString();
                        if (perfaccuracy2array[5].ToString() != "")
                            lbaccu18.Text = perfaccuracy2array[5].ToString();
                        if (perfaccuracy2array[6].ToString() != "")
                            lbaccu19.Text = perfaccuracy2array[6].ToString();
                        if (perfaccuracy2array[7].ToString() != "")
                            lbaccu20.Text = perfaccuracy2array[7].ToString();
                        if (perfaccuracy2array[8].ToString() != "")
                            lblaccu21.Text = perfaccuracy2array[8].ToString();
                        
                        if (perfaccuracy2array[9].ToString() != "")
                            lblaccu23.Text = perfaccuracy2array[9].ToString();
                        if (perfaccuracy2array[10].ToString() != "")
                            lblaccu24.Text = perfaccuracy2array[10].ToString();

                    }
                }
                if (j == 2)
                {
                    accuracytr3++;
                    string[] perfaccuracy3array = { };
                    StringBuilder sb_accu3 = new StringBuilder();
                    sb_accu3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue3 = sb_accu3.ToString();
                    perfaccuracy3array = perfvalue3.Split(',');
                    if (perfaccuracy3array.Count() > 0)
                    {
                        if (perfaccuracy3array[0].ToString() != "")
                            lbaccu25.Text = perfaccuracy3array[0].ToString();
                        if (perfaccuracy3array[1].ToString() != "")
                            lbaccu26.Text = perfaccuracy3array[1].ToString();
                        if (perfaccuracy3array[2].ToString() != "")
                            lbaccu27.Text = perfaccuracy3array[2].ToString();
                        if (perfaccuracy3array[3].ToString() != "")
                            lbaccu28.Text = perfaccuracy3array[3].ToString();
                        if (perfaccuracy3array[4].ToString() != "")
                            lbaccu29.Text = perfaccuracy3array[4].ToString();
                        if (perfaccuracy3array[5].ToString() != "")
                            lbaccu30.Text = perfaccuracy3array[5].ToString();
                        if (perfaccuracy3array[6].ToString() != "")
                            lbaccu31.Text = perfaccuracy3array[6].ToString();
                        if (perfaccuracy3array[7].ToString() != "")
                            lbaccu32.Text = perfaccuracy3array[7].ToString();
                        if (perfaccuracy3array[8].ToString() != "")
                            lbaccu33.Text = perfaccuracy3array[8].ToString();
                        
                        if (perfaccuracy3array[9].ToString() != "")
                            lbaccu35.Text = perfaccuracy3array[9].ToString();
                        if (perfaccuracy3array[10].ToString() != "")
                            lbaccu36.Text = perfaccuracy3array[10].ToString();

                    }
                }


            }


        }
    }

    public void showdiv_tr()
    {
        accuracytestdiv.Visible = true;
        accuracy_1.Visible = true;
        accuracy_2.Visible = true;
        accuracy_3.Visible = true;
    }
    public void Hide_perftable()
    {
        if (accuracyid == 0)
            accuracytestdiv.Visible = false;
        else
            lblperformancename3.Text = "Accuracy Test";
        if (accuracytr1 == 0)
            accuracy_1.Visible = false;
        if (accuracytr2 == 0)
            accuracy_2.Visible = false;
        if (accuracytr3 == 0)
            accuracy_3.Visible = false;
        
    }
}