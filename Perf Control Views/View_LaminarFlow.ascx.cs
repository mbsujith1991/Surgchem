using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_LaminarFlow : System.Web.UI.UserControl
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
    int flowid = 0, flowtr1 = 0, flowtr2 = 0, flowtr3 = 0, flowtr4 = 0, flowtr5 = 0, flowtr6 = 0, flowtr7 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Peep(string sReportid, string sPerfid)
    {

        flowid++;
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
                    flowtr1++;
                    string[] flowarray1 = { };
                    StringBuilder sb_flow1 = new StringBuilder();
                    sb_flow1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_flow1.ToString();
                    flowarray1 = perfvalue1.Split(',');
                    if (flowarray1.Count() > 0)
                    {
                        if (flowarray1[0].ToString() != "")
                            txtlam1.Text = flowarray1[0].ToString();
                       
                    }
                }
                if (j == 1)
                {
                    flowtr2++;
                    string[] flowarray2 = { };
                    StringBuilder sb_flow2 = new StringBuilder();
                    sb_flow2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue2 = sb_flow2.ToString();
                    flowarray2 = perfvalue2.Split(',');
                    if (flowarray2.Count() > 0)
                    {
                        if (flowarray2[0].ToString() != "")
                            txtlam2.Text = flowarray2[0].ToString();
                        
                    }
                }
                if(j==2)
                {
                    flowtr3++;
                    string[] flowarray3 = { };
                    StringBuilder sb_flow3 = new StringBuilder();
                    sb_flow3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_flow3.ToString();
                    flowarray3 = perfvalue1.Split(',');
                    if (flowarray3.Count() > 0)
                    {
                        if (flowarray3[0].ToString() != "")
                            txtlam3.Text = flowarray3[0].ToString();

                    }
                }
                if (j == 3)
                {
                    flowtr4++;
                    string[] flowarray4 = { };
                    StringBuilder sb_flow4 = new StringBuilder();
                    sb_flow4.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_flow4.ToString();
                    flowarray4 = perfvalue1.Split(',');
                    if (flowarray4.Count() > 0)
                    {
                        if (flowarray4[0].ToString() != "")
                            txtlam4.Text = flowarray4[0].ToString();

                    }
                }
                if (j == 4)
                {
                    flowtr5++;
                    string[] flowarray5 = { };
                    StringBuilder sb_flow5 = new StringBuilder();
                    sb_flow5.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_flow5.ToString();
                    flowarray5 = perfvalue1.Split(',');
                    if (flowarray5.Count() > 0)
                    {
                        if (flowarray5[0].ToString() != "")
                            txtlam5.Text = flowarray5[0].ToString();

                    }
                }
                if (j == 5)
                {
                    flowtr6++;
                    string[] flowarray6 = { };
                    StringBuilder sb_flow6 = new StringBuilder();
                    sb_flow6.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_flow6.ToString();
                    flowarray6 = perfvalue1.Split(',');
                    if (flowarray6.Count() > 0)
                    {
                        if (flowarray6[0].ToString() != "")
                            txtlam6.Text = flowarray6[0].ToString();

                    }
                }
                if (j == 6)
                {
                    flowtr7++;
                    string[] flowarray7 = { };
                    StringBuilder sb_flow7 = new StringBuilder();
                    sb_flow7.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_flow7.ToString();
                    flowarray7 = perfvalue1.Split(',');
                    if (flowarray7.Count() > 0)
                    {
                        if (flowarray7[0].ToString() != "")
                            txtlam7.Text = flowarray7[0].ToString();

                    }
                }


            }
        }
    }

    public void Hide_perftable()
    {
        if (flowid == 0)
            flowdiv.Visible = false;
        else
            lblflow.Text = "Quality Assurance of Laminar Flow";
        if (flowtr1 == 0)
        {
            tr_flow1.Visible = false;
        }
        if (flowtr2 == 0)
        {
            tr_flow2.Visible = false;
        }
        if (flowtr3 == 0)
        {
            tr_flow3.Visible = false;
        }
        if (flowtr4 == 0)
        {
            tr_flow4.Visible = false;
        }
        if (flowtr5== 0)
        {
            tr_flow5.Visible = false;
        }
        if (flowtr6== 0)
        {
            tr_flow6.Visible = false;
        }
        if (flowtr7 == 0)
        {
            tr_flow7.Visible = false;
        }


    }
    public void showdiv_tr()
    {
        flowdiv.Visible = true;
        tr_flow1.Visible = true;
        tr_flow2.Visible = true;
        tr_flow3.Visible = true;
        tr_flow4.Visible = true;
        tr_flow5.Visible = true;
        tr_flow6.Visible = true;
        tr_flow7.Visible = true;

    }
}