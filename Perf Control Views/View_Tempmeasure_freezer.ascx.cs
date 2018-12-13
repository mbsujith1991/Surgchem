using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_Tempmeasure_freezer : System.Web.UI.UserControl
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
     int temp_freezerid = 0, temp_freezertr1 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Temp_freezer(string sReportid, string sPerfid)
    {

        temp_freezerid++;
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
                    temp_freezertr1++;
                    string[] temp_freezerarray1 = { };
                    StringBuilder sb_freezer1 = new StringBuilder();
                    sb_freezer1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_freezer1.ToString();
                    temp_freezerarray1 = perfvalue1.Split(',');
                    if (temp_freezerarray1.Count() > 0)
                    {
                        if (temp_freezerarray1[0].ToString() != "")
                            lbltemp_freezer1.Text = temp_freezerarray1[0].ToString();
                        if (temp_freezerarray1[1].ToString() != "")
                            lbltemp_freezer2.Text = temp_freezerarray1[1].ToString();
                        if (temp_freezerarray1[2].ToString() != "")
                            lbltemp_freezer3.Text = temp_freezerarray1[2].ToString();
                        if (temp_freezerarray1[3].ToString() != "")
                            lbltemp_freezer4.Text = temp_freezerarray1[3].ToString();
                        if (temp_freezerarray1[4].ToString() != "")
                            lbltemp_freezer5.Text = temp_freezerarray1[4].ToString();
                        if (temp_freezerarray1[5].ToString() != "")
                            lbltemp_freezer6.Text = temp_freezerarray1[5].ToString();
                        if (temp_freezerarray1[6].ToString() != "")
                            lbltemp_freezer7.Text = temp_freezerarray1[6].ToString();
                        if (temp_freezerarray1[7].ToString() != "")
                            lbltemp_freezer8.Text = temp_freezerarray1[7].ToString();
                        if (temp_freezerarray1[8].ToString() != "")
                            lbltemp_freezer9.Text = temp_freezerarray1[8].ToString();
                      
                    }
                }
               
            }
        }
    }

    public void showdiv_tr()
    {
        temp_freezerdiv.Visible = true;
        tr_tempfreezer1.Visible = true;
       
    }
    public void Hide_perftable()
    {
        if (temp_freezerid == 0)
            temp_freezerdiv.Visible = false;
        else
            lbltempfreezer.Text = "Temperature Measurement of Freezer";
        if (temp_freezertr1 == 0)
            tr_tempfreezer1.Visible = false;
       
    }
}