using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_Temphotair : System.Web.UI.UserControl
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
    int temphotairid = 0, temphotairtr1 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Temphotair(string sReportid, string sPerfid)
    {
         
        temphotairid++;
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
                    temphotairtr1++;
                    string[] temphotairarray1 = { };
                    StringBuilder sb_temphotair1 = new StringBuilder();
                    sb_temphotair1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_temphotair1.ToString();
                    temphotairarray1 = perfvalue1.Split(',');
                    if (temphotairarray1.Count() > 0)
                    {
                        if (temphotairarray1[0].ToString() != "")
                            lblhot1.Text = temphotairarray1[0].ToString();
                        if (temphotairarray1[1].ToString() != "")
                            lblhot2.Text = temphotairarray1[1].ToString();
                        if (temphotairarray1[2].ToString() != "")
                            lblhot3.Text = temphotairarray1[2].ToString();
                        if (temphotairarray1[3].ToString() != "")
                            lblhot4.Text = temphotairarray1[3].ToString();
                        if (temphotairarray1[4].ToString() != "")
                            lblhot5.Text = temphotairarray1[4].ToString();
                        if (temphotairarray1[5].ToString() != "")
                            lblhot6.Text = temphotairarray1[5].ToString();
                        if (temphotairarray1[6].ToString() != "")
                            lblhot7.Text = temphotairarray1[6].ToString();
                        if (temphotairarray1[7].ToString() != "")
                            lblhot8.Text = temphotairarray1[7].ToString();
                        if (temphotairarray1[8].ToString() != "")
                            lblhot9.Text = temphotairarray1[8].ToString();
                        if (temphotairarray1[9].ToString() != "")
                            lblhot10.Text = temphotairarray1[9].ToString();
                        if (temphotairarray1[10].ToString() != "")
                            lblhot11.Text = temphotairarray1[10].ToString();
                        if (temphotairarray1[11].ToString() != "")
                            lblhot12.Text = temphotairarray1[11].ToString();
                    }
                }
            }
        }
    }

    public void showdiv_tr()
    {
        temphotairdiv.Visible = true;
        tr_temphotair.Visible = true;
        
    }
    public void Hide_perftable()
    {
        if (temphotairid == 0)
            temphotairdiv.Visible = false;
        else
            lblhotair.Text = "Temperature Measurement of Hot Air Oven";
        if (temphotairtr1 == 0)
            tr_temphotair.Visible = false;
       
    }
}