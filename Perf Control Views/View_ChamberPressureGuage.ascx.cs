using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_ChamberPressureGuage : System.Web.UI.UserControl
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
    int flowid = 0, flowtr1 = 0, flowtr2 = 0;
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
                            lblflow1.Text = flowarray1[0].ToString();
                        if (flowarray1[1].ToString() != "")
                            lblflow2.Text = flowarray1[1].ToString();
                        if (flowarray1[2].ToString() != "")
                            lblflow3.Text = flowarray1[2].ToString();
                        if (flowarray1[3].ToString() != "")
                            lblflow4.Text = flowarray1[3].ToString();
                        if (flowarray1[4].ToString() != "")
                            lblflow5.Text = flowarray1[4].ToString();
                        if (flowarray1[5].ToString() != "")
                            lblflow6.Text = flowarray1[5].ToString();


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
            lblflow.Text = "Chamber Pressure Guage";
        if (flowtr1 == 0)
        {
            tr_flow1.Visible = false;
        }

    }
    public void showdiv_tr()
    {
        flowdiv.Visible = true;
        tr_flow1.Visible = true;
    }
}