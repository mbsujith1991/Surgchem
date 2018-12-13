using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_Nebuliser : System.Web.UI.UserControl
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
    int nebuid = 0, nebutr1 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_nebu(string sReportid, string sPerfid)
    {

        nebuid++;
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
                    nebutr1++;
                    string[] nebuarray1 = { };
                    StringBuilder sb_nebu1 = new StringBuilder();
                    sb_nebu1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_nebu1.ToString();
                    nebuarray1 = perfvalue1.Split(',');
                    if (nebuarray1.Count() > 0)
                    {
                        if (nebuarray1[0].ToString() != "")
                            lblnebu1.Text = nebuarray1[0].ToString();
                        if (nebuarray1[1].ToString() != "")
                            lblnebu2.Text = nebuarray1[1].ToString();
                        if (nebuarray1[2].ToString() != "")
                            lblnebu3.Text = nebuarray1[2].ToString();
                        if (nebuarray1[3].ToString() != "")
                            lblnebu4.Text = nebuarray1[3].ToString();
                        if (nebuarray1[4].ToString() != "")
                            lblnebu5.Text = nebuarray1[4].ToString();
                        
                    }
                }
               

            }
        }
    }

    public void Hide_perftable()
    {
        if (nebuid == 0)
            nebudiv.Visible = false;
        else
            lblnebu.Text = "Pressure";
        if (nebutr1 == 0)
        {
            tr_nebu1.Visible = false;
        }
       


    }
    public void showdiv_tr()
    {
        nebudiv.Visible = true;
        tr_nebu1.Visible = true;

    }
}