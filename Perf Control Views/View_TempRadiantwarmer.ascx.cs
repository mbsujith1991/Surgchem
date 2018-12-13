using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_TempRadiantwarmer : System.Web.UI.UserControl
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
    int temp_radiantid = 0, temp_radianttr1 = 0, temp_radianttr2 = 0;
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Temptest_radiantwarmer(string sReportid,string sPerfid)
    {
       
         temp_radiantid++;
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
                    temp_radianttr1++;
                    string[] temp_radiantarray1 = { };
                    StringBuilder sb_radiant1 = new StringBuilder();
                    sb_radiant1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_radiant1.ToString();
                    temp_radiantarray1 = perfvalue1.Split(',');
                    if (temp_radiantarray1.Count() > 0)
                    {
                        if (temp_radiantarray1[0].ToString() != "")
                            lbltemp_radiant1.Text = temp_radiantarray1[0].ToString();
                        if (temp_radiantarray1[1].ToString() != "")
                            lbltemp_radiant2.Text = temp_radiantarray1[1].ToString();
                        if (temp_radiantarray1[2].ToString() != "")
                            lbltemp_radiant3.Text = temp_radiantarray1[2].ToString();
                        if (temp_radiantarray1[3].ToString() != "")
                            lbltemp_radiant4.Text = temp_radiantarray1[3].ToString();
                        if (temp_radiantarray1[4].ToString() != "")
                            lbltemp_radiant5.Text = temp_radiantarray1[4].ToString();
                        if (temp_radiantarray1[5].ToString() != "")
                            lbltemp_radiant6.Text = temp_radiantarray1[5].ToString();
                        if (temp_radiantarray1[6].ToString() != "")
                            lbltemp_radiant7.Text = temp_radiantarray1[6].ToString();
                        if (temp_radiantarray1[7].ToString() != "")
                            lbltemp_radiant8.Text = temp_radiantarray1[7].ToString();





                    }
                }
                if (j == 1)
                {
                    temp_radianttr2++;
                    string[] temp_radiantarray2 = { };
                    StringBuilder sb_radiant2 = new StringBuilder();
                    sb_radiant2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_radiant2.ToString();
                    temp_radiantarray2 = perfvalue1.Split(',');
                    if (temp_radiantarray2.Count() > 0)
                    {
                        if (temp_radiantarray2[0].ToString() != "")
                            lbltemp_radiant9.Text = temp_radiantarray2[0].ToString();
                        if (temp_radiantarray2[1].ToString() != "")
                            lbltemp_radiant10.Text = temp_radiantarray2[1].ToString();
                        if (temp_radiantarray2[2].ToString() != "")
                            lbltemp_radiant11.Text = temp_radiantarray2[2].ToString();
                        if (temp_radiantarray2[3].ToString() != "")
                            lbltemp_radiant12.Text = temp_radiantarray2[3].ToString();
                        if (temp_radiantarray2[4].ToString() != "")
                            lbltemp_radiant13.Text = temp_radiantarray2[4].ToString();
                        if (temp_radiantarray2[5].ToString() != "")
                            lbltemp_radiant14.Text = temp_radiantarray2[5].ToString();
                        if (temp_radiantarray2[6].ToString() != "")
                            lbltemp_radiant15.Text = temp_radiantarray2[6].ToString();
                        if (temp_radiantarray2[7].ToString() != "")
                            lbltemp_radiant16.Text = temp_radiantarray2[7].ToString();


                    }
                }
            }
        }
        
    }

    public void showdiv_tr()
    {
        radiantwarmerdiv.Visible = true;
        tr_tempradiant1.Visible = true;
        tr_tempradiant1.Visible = true;
    }
       
    public void Hide_perftable()
    {
        if (temp_radiantid == 0)
            radiantwarmerdiv.Visible = false;
        else
            lblradiant.Text = "Temperature Measurement of Radiant Warmer";
        if (temp_radianttr1 == 0)
            tr_tempradiant1.Visible = false;
        if (temp_radianttr2 == 0)
            tr_tempradiant2.Visible = false;
       

    }
}