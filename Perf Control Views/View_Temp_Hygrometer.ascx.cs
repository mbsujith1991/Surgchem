using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_Temp_Hygrometer : System.Web.UI.UserControl
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
     int temphygroid1 = 0, temphygrotr1 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_temphygro(string sReportid, string sPerfid)
    {

        temphygroid1++;
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
                    temphygrotr1++;
                    string[] temphygroarray1 = { };
                    StringBuilder sb_temphygro1 = new StringBuilder();
                    sb_temphygro1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_temphygro1.ToString();
                    temphygroarray1 = perfvalue1.Split(',');
                    if (temphygroarray1.Count() > 0)
                    {
                        if (temphygroarray1[0].ToString() != "")
                            lbltemphygro1.Text = temphygroarray1[0].ToString();
                        if (temphygroarray1[1].ToString() != "")
                            lbltemphygro2.Text = temphygroarray1[1].ToString();
                        if (temphygroarray1[2].ToString() != "")
                            lbltemphygro3.Text = temphygroarray1[2].ToString();
                        if (temphygroarray1[3].ToString() != "")
                            lbltemphygro4.Text = temphygroarray1[3].ToString();
                        if (temphygroarray1[4].ToString() != "")
                            lbltemphygro5.Text = temphygroarray1[4].ToString();
                        if (temphygroarray1[5].ToString() != "")
                            lbltemphygro6.Text = temphygroarray1[5].ToString();


                    }
                }
                
            }
        }
    }

    public void Hide_perftable()
    {
        if (temphygroid1 == 0)
            temphygrodiv.Visible = false;
        else
            lbltemphygro.Text = "Temperature of Hygrometer";
        if (temphygrotr1 == 0)
        {
            tr_temphygro1.Visible = false;
        }
       

    }
    public void showdiv_tr()
    {
        temphygrodiv.Visible = true;
        tr_temphygro1.Visible = true;
       

    }
}