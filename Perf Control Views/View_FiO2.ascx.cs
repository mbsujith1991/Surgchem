using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Perf_Control_Views_View_FiO2 : System.Web.UI.UserControl
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
    int flowid = 0, flowtr1 = 0, flowtr2 = 0, flowtr3 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_flow(string sReportid, string sPerfid)
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
                            lblflow1.Text = flowarray1[0].ToString();
                        if (flowarray1[1].ToString() != "")
                            lblflow2.Text = flowarray1[1].ToString();
                        if (flowarray1[2].ToString() != "")
                            lblflow3.Text = flowarray1[2].ToString();
                        if (flowarray1[3].ToString() != "")
                            lblflow5.Text = flowarray1[3].ToString();
                        if (flowarray1[4].ToString() != "")
                            lblflow6.Text = flowarray1[4].ToString();


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
                            lblflow7.Text = flowarray2[0].ToString();
                        if (flowarray2[1].ToString() != "")
                            lblflow8.Text = flowarray2[1].ToString();
                        if (flowarray2[2].ToString() != "")
                            lblflow9.Text = flowarray2[2].ToString();
                        if (flowarray2[3].ToString() != "")
                            lblflow11.Text = flowarray2[3].ToString();
                        if (flowarray2[4].ToString() != "")
                            lblflow12.Text = flowarray2[4].ToString();


                    }
                }
                if (j == 2)
                {
                    flowtr3++;
                    string[] flowarray3 = { };
                    StringBuilder sb_flow3 = new StringBuilder();
                    sb_flow3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue3 = sb_flow3.ToString();
                    flowarray3 = perfvalue3.Split(',');
                    if (flowarray3.Count() > 0)
                    {
                        if (flowarray3[0].ToString() != "")
                            lblflow13.Text = flowarray3[0].ToString();
                        if (flowarray3[1].ToString() != "")
                            lblflow14.Text = flowarray3[1].ToString();
                        if (flowarray3[2].ToString() != "")
                            lblflow15.Text = flowarray3[2].ToString();
                        if (flowarray3[3].ToString() != "")
                            lblflow17.Text = flowarray3[3].ToString();
                        if (flowarray3[4].ToString() != "")
                            lblflow18.Text = flowarray3[4].ToString();

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
            lblflow.Text = "FiO2 Test";
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

    }
    public void showdiv_tr()
    {
        flowdiv.Visible = true;
        tr_flow1.Visible = true;
        tr_flow2.Visible = true;
        tr_flow3.Visible = true;

    }
}