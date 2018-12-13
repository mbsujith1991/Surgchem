using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_HumidityHygro : System.Web.UI.UserControl
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
    int humidityid1 = 0, humiditytr1 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_humidity(string sReportid, string sPerfid)
    {

        humidityid1++;
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
                    humiditytr1++;
                    string[] humidityarray1 = { };
                    StringBuilder sb_humidity1 = new StringBuilder();
                    sb_humidity1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_humidity1.ToString();
                    humidityarray1 = perfvalue1.Split(',');
                    if (humidityarray1.Count() > 0)
                    {
                        if (humidityarray1[0].ToString() != "")
                            lblhumidity1.Text = humidityarray1[0].ToString();
                        if (humidityarray1[1].ToString() != "")
                            lblhumidity2.Text = humidityarray1[1].ToString();
                        if (humidityarray1[2].ToString() != "")
                            lblhumidity3.Text = humidityarray1[2].ToString();
                        if (humidityarray1[3].ToString() != "")
                            lblhumidity4.Text = humidityarray1[3].ToString();
                        if (humidityarray1[4].ToString() != "")
                            lblhumidity5.Text = humidityarray1[4].ToString();
                        if (humidityarray1[5].ToString() != "")
                            lblhumidity6.Text = humidityarray1[5].ToString();


                    }
                }

            }
        }
    }

    public void Hide_perftable()
    {
        if (humidityid1 == 0)
            humiditydiv.Visible = false;
        else
            lblhumidity.Text = "Humidity of Hygrometer";
        if (humiditytr1 == 0)
        {
            tr_humidity1.Visible = false;
        }


    }
    public void showdiv_tr()
    {
        humiditydiv.Visible = true;
        tr_humidity1.Visible = true;


    }
}