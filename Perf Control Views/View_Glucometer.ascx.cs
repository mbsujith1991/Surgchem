using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Perf_Control_Views_View_Glucometer : System.Web.UI.UserControl
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
    int flowid = 0, flowtr1 = 0;
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
                            lblglu1.Text = flowarray1[0].ToString();
                        if (flowarray1[1].ToString() != "")
                            lblglu2.Text = flowarray1[1].ToString();
                        if (flowarray1[2].ToString() != "")
                            lblglu3.Text = flowarray1[2].ToString();
                        
                    }
                }
                

            }
        }
    }

    public void Hide_perftable()
    {
        if (flowid == 0)
            gludiv.Visible = false;
        else
            lblglu.Text = "Control Reagent for Glucometer";
        if (flowtr1 == 0)
        {
            tr_glu1.Visible = false;
        }
        
    }
    public void showdiv_tr()
    {
        gludiv.Visible = true;
        tr_glu1.Visible = true;
        
    }
}