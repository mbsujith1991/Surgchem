using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_Flowmeter : System.Web.UI.UserControl
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
    int synctimeid = 0, syntr1 = 0, syntr2 = 0, syntr3 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_flowmeter(string sReportid, string sPerfid)
    {

        synctimeid++;
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
                    syntr1++;
                    string[] synarray1 = { };
                    StringBuilder sb_syn1 = new StringBuilder();
                    sb_syn1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_syn1.ToString();
                    synarray1 = perfvalue1.Split(',');
                    if (synarray1.Count() > 0)
                    {
                        if (synarray1[0].ToString() != "")
                            lblsyn1.Text = synarray1[0].ToString();
                        if (synarray1[1].ToString() != "")
                            lblsyn2.Text = synarray1[1].ToString();
                        if (synarray1[2].ToString() != "")
                            lblsyn3.Text = synarray1[2].ToString();
                        //if (synarray1[3].ToString() != "")
                        //    lblsyn4.Text = synarray1[3].ToString();



                    }
                }
                if (j == 1)
                {
                    syntr2++;
                    string[] synarray2 = { };
                    StringBuilder sb_syn2 = new StringBuilder();
                    sb_syn2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_syn2.ToString();
                    synarray2 = perfvalue1.Split(',');
                    if (synarray2.Count() > 0)
                    {
                        if (synarray2[0].ToString() != "")
                            lblsyn5.Text = synarray2[0].ToString();
                        if (synarray2[1].ToString() != "")
                            lblsyn6.Text = synarray2[1].ToString();
                        if (synarray2[2].ToString() != "")
                            lblsyn7.Text = synarray2[2].ToString();
                        //if (synarray2[3].ToString() != "")
                        //    lblsyn8.Text = synarray2[3].ToString();

                    }
                }
                if (j == 2)
                {
                    syntr3++;
                    string[] synarray3 = { };
                    StringBuilder sb_syn3 = new StringBuilder();
                    sb_syn3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_syn3.ToString();
                    synarray3 = perfvalue1.Split(',');
                    if (synarray3.Count() > 0)
                    {
                        if (synarray3[0].ToString() != "")
                            lblsyn9.Text = synarray3[0].ToString();
                        if (synarray3[1].ToString() != "")
                            lblsyn10.Text = synarray3[1].ToString();
                        if (synarray3[2].ToString() != "")
                            lblsyn11.Text = synarray3[2].ToString();
                        //if (synarray3[3].ToString() != "")
                        //    lblsyn12.Text = synarray3[3].ToString();


                    }
                }
            }
        }
    }


    public void Hide_perftable()
    {
        if (synctimeid == 0)
            flowmeterdiv.Visible = false;
        else
            lblflowmeter.Text = "Flow Meter";
        if (syntr1 == 0)
            tr_syn1.Visible = false;
        if (syntr2 == 0)
            tr_syn2.Visible = false;
        if (syntr3 == 0)
            tr_syn3.Visible = false;
    }
    public void showdiv_tr()
    {
        flowmeterdiv.Visible = true;
        tr_syn1.Visible = true;
        tr_syn2.Visible = true;
        tr_syn3.Visible = true;
    }
}