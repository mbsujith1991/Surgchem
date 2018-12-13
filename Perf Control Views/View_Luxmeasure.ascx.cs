using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_Luxmeasure : System.Web.UI.UserControl
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
    int luxid = 0, luxmeastr1 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Luxmeasure(string sReportid, string sPerfid)
    {
        
        luxid++;
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
                    luxmeastr1++;
                    string[] luxarray1 = { };
                    StringBuilder sb_lux1 = new StringBuilder();
                    sb_lux1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_lux1.ToString();
                    luxarray1 = perfvalue1.Split(',');
                    if (luxarray1.Count() > 0)
                    {
                        if (luxarray1[0].ToString() != "")
                            lbllux1.Text = luxarray1[0].ToString();
                        if (luxarray1[1].ToString() != "")
                            lbllux2.Text = luxarray1[1].ToString();
                        if (luxarray1[2].ToString() != "")
                            lbllux3.Text = luxarray1[2].ToString();
                        if (luxarray1[3].ToString() != "")
                            lbllux4.Text = luxarray1[3].ToString();
                        if (luxarray1[4].ToString() != "")
                            lbllux5.Text = luxarray1[4].ToString();
                        if (luxarray1[5].ToString() != "")
                            lbllux6.Text = luxarray1[5].ToString();
                       
                    }
                }
            }
        }
    }
    public void showdiv_tr()
    {
        luxmeasurediv.Visible = true;
        tr_luxmeasure.Visible = true;
        
    }
    public void Hide_perftable()
    {
        if (luxid == 0)
            luxmeasurediv.Visible = false;
        else
            lblluxmeasure.Text = "Lux Measurement of OT Light";
        if (luxmeastr1 == 0)
            tr_luxmeasure.Visible = false;
       

    }
}