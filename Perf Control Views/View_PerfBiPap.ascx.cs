using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_PerfBiPap : System.Web.UI.UserControl
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
    int perf_bipapid = 0, bipaptr1 = 0, bipaptr2 = 0, bipaptr3 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Perf_Bipap(string sReportid,string sPerfid)
    {
        
        perf_bipapid++;
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
                    bipaptr1++;
                    string[] bipaparray1 = { };
                    StringBuilder sb_bipap1 = new StringBuilder();
                    sb_bipap1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_bipap1.ToString();
                    bipaparray1 = perfvalue1.Split(',');
                    if (bipaparray1.Count() > 0)
                    {
                        if (bipaparray1[0].ToString() != "")
                            lblbipap1.Text = bipaparray1[0].ToString();
                        if (bipaparray1[1].ToString() != "")
                            lblbipap2.Text = bipaparray1[1].ToString();
                        if (bipaparray1[2].ToString() != "")
                            lblbipap3.Text = bipaparray1[2].ToString();
                        if (bipaparray1[3].ToString() != "")
                            lblbipap4.Text = bipaparray1[3].ToString();
                        if (bipaparray1[4].ToString() != "")
                            lblbipap5.Text = bipaparray1[4].ToString();
                        if (bipaparray1[5].ToString() != "")
                            lblbipap6.Text = bipaparray1[5].ToString();
                        if (bipaparray1[6].ToString() != "")
                            lblbipap7.Text = bipaparray1[6].ToString();


                    }
                }
                if (j == 1)
                {
                    bipaptr2++;
                    string[] bipaparray2 = { };
                    StringBuilder sb_bipap2 = new StringBuilder();
                    sb_bipap2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_bipap2.ToString();
                    bipaparray2 = perfvalue1.Split(',');
                    if (bipaparray2.Count() > 0)
                    {
                        if (bipaparray2[0].ToString() != "")
                            lblbipap8.Text = bipaparray2[0].ToString();
                        if (bipaparray2[1].ToString() != "")
                            lblbipap9.Text = bipaparray2[1].ToString();
                        if (bipaparray2[2].ToString() != "")
                            lblbipap10.Text = bipaparray2[2].ToString();
                        if (bipaparray2[3].ToString() != "")
                            lblbipap11.Text = bipaparray2[3].ToString();
                        if (bipaparray2[4].ToString() != "")
                            lblbipap12.Text = bipaparray2[4].ToString();
                        if (bipaparray2[5].ToString() != "")
                            lblbipap13.Text = bipaparray2[5].ToString();
                        if (bipaparray2[6].ToString() != "")
                            lblbipap14.Text = bipaparray2[6].ToString();

                    }
                }
                if (j == 2)
                {
                    bipaptr3++;
                    string[] bipaparray3 = { };
                    StringBuilder sb_bipap3 = new StringBuilder();
                    sb_bipap3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_bipap3.ToString();
                    bipaparray3 = perfvalue1.Split(',');
                    if (bipaparray3.Count() > 0)
                    {
                        if (bipaparray3[0].ToString() != "")
                            lblbipap15.Text = bipaparray3[0].ToString();
                        if (bipaparray3[1].ToString() != "")
                            lblbipap16.Text = bipaparray3[1].ToString();
                        if (bipaparray3[2].ToString() != "")
                            lblbipap17.Text = bipaparray3[2].ToString();
                        if (bipaparray3[3].ToString() != "")
                            lblbipap18.Text = bipaparray3[3].ToString();
                        if (bipaparray3[4].ToString() != "")
                            lblbipap19.Text = bipaparray3[4].ToString();
                        if (bipaparray3[5].ToString() != "")
                            lblbipap20.Text = bipaparray3[5].ToString();
                        if (bipaparray3[6].ToString() != "")
                            lblbipap21.Text = bipaparray3[6].ToString();

                    }
                }
            }
        }
    }
    public void Hide_perftable()
    {
        if (perf_bipapid == 0)
            bipapdiv.Visible = false;
        else
            lblbipapname.Text = "Performance Analysis of BiPap";
        if (bipaptr1 == 0)
            tr_bipap1.Visible = false;
        if (bipaptr2 == 0)
            tr_bipap2.Visible = false;
        if (bipaptr3 == 0)
            tr_bipap3.Visible = false;
    }

    public void showdiv_tr()
    {
        bipapdiv.Visible = true;
        tr_bipap1.Visible = true;
        tr_bipap2.Visible = true;
        tr_bipap3.Visible = true;
    }
}