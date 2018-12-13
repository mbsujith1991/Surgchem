using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_Tempmeasure_middlechamber : System.Web.UI.UserControl
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
    int temp_middlechamberid = 0, temp_middlechambertr1 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Temp_middlechamber(string sReportid, string sPerfid)
    {

        temp_middlechamberid++;
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
                    temp_middlechambertr1++;
                    string[] temp_middlearray1 = { };
                    StringBuilder sb_middle1 = new StringBuilder();
                    sb_middle1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_middle1.ToString();
                    temp_middlearray1 = perfvalue1.Split(',');
                    if (temp_middlearray1.Count() > 0)
                    {
                        if (temp_middlearray1[0].ToString() != "")
                            lbltemp_middlechamber1.Text = temp_middlearray1[0].ToString();
                        if (temp_middlearray1[1].ToString() != "")
                            lbltemp_middlechamber2.Text = temp_middlearray1[1].ToString();
                        if (temp_middlearray1[2].ToString() != "")
                            lbltemp_middlechamber3.Text = temp_middlearray1[2].ToString();
                        if (temp_middlearray1[3].ToString() != "")
                            lbltemp_middlechamber4.Text = temp_middlearray1[3].ToString();
                        if (temp_middlearray1[4].ToString() != "")
                            lbltemp_middlechamber5.Text = temp_middlearray1[4].ToString();
                        if (temp_middlearray1[5].ToString() != "")
                            lbltemp_middlechamber6.Text = temp_middlearray1[5].ToString();
                        if (temp_middlearray1[6].ToString() != "")
                            lbltemp_middlechamber7.Text = temp_middlearray1[6].ToString();
                        if (temp_middlearray1[7].ToString() != "")
                            lbltemp_middlechamber8.Text = temp_middlearray1[7].ToString();
                        if (temp_middlearray1[8].ToString() != "")
                            lbltemp_middlechamber9.Text = temp_middlearray1[8].ToString();

                    }
                }

            }
        }
    }

    public void showdiv_tr()
    {
        temp_middlechamberdiv.Visible = true;
        tr_tempmiddlechamber1.Visible = true;

    }
    public void Hide_perftable()
    {
        if (temp_middlechamberid == 0)
            temp_middlechamberdiv.Visible = false;
        else
            lbltempmiddlechamber.Text = "Temperature Measurement of Middle Chamber";
        if (temp_middlechambertr1 == 0)
            tr_tempmiddlechamber1.Visible = false;

    }
}