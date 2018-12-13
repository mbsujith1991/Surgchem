using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

public partial class Perf_Control_Views_View_Tempincubator : System.Web.UI.UserControl
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
    int tempincubatorid = 0, tempincubatortr1 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_TempIncubator(string sReportid, string sPerfid)
    {
       
        tempincubatorid++;
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
                    tempincubatortr1++;
                    string[] tempincuarray1 = { };
                    StringBuilder sb_tempincu1 = new StringBuilder();
                    sb_tempincu1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_tempincu1.ToString();
                    tempincuarray1 = perfvalue1.Split(',');
                    if (tempincuarray1.Count() > 0)
                    {
                        if (tempincuarray1[0].ToString() != "")
                            lbltempincu1.Text = tempincuarray1[0].ToString();
                        if (tempincuarray1[1].ToString() != "")
                            lbltempincu2.Text = tempincuarray1[1].ToString();
                        if (tempincuarray1[2].ToString() != "")
                            lbltempincu3.Text = tempincuarray1[2].ToString();
                        if (tempincuarray1[3].ToString() != "")
                            lbltempincu4.Text = tempincuarray1[3].ToString();
                        if (tempincuarray1[4].ToString() != "")
                            lbltempincu5.Text = tempincuarray1[4].ToString();
                        if (tempincuarray1[5].ToString() != "")
                            lbltempincu6.Text = tempincuarray1[5].ToString();
                        if (tempincuarray1[6].ToString() != "")
                            lbltempincu7.Text = tempincuarray1[6].ToString();
                        if (tempincuarray1[7].ToString() != "")
                            lbltempincu8.Text = tempincuarray1[7].ToString();
                        if (tempincuarray1[8].ToString() != "")
                            lbltempincu9.Text = tempincuarray1[8].ToString();
                        if (tempincuarray1[9].ToString() != "")
                            lbltempincu10.Text = tempincuarray1[9].ToString();
                        if (tempincuarray1[10].ToString() != "")
                            lbltempincu11.Text = tempincuarray1[10].ToString();
                        if (tempincuarray1[11].ToString() != "")
                            lbltempincu12.Text = tempincuarray1[11].ToString();
                    }
                }
            }
        }
    }

    public void showdiv_tr()
    {
        tempincubatordiv.Visible = true;
        tr_tempincubator1.Visible = true;
        
    }
    public void Hide_perftable()
    {
        if (tempincubatorid == 0)
            tempincubatordiv.Visible = false;
        else
            lbltempincubator.Text = "Temperature Measurement of Incubator";
        if (tempincubatortr1 == 0)
            tr_tempincubator1.Visible = false;
       

    }
}