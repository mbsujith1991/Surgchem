using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_TempDigitalthermo : System.Web.UI.UserControl
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
    int temp_digitalid = 0, temp_digitaltr1 = 0, temp_digitaltr2 = 0;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_Temptest_digital(string sReportid,string sPerfid)
    {
       
         temp_digitalid++;
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
                    temp_digitaltr1++;
                    string[] temp_digitalarray1 = { };
                    StringBuilder sb_digital1 = new StringBuilder();
                    sb_digital1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_digital1.ToString();
                    temp_digitalarray1 = perfvalue1.Split(',');
                    if (temp_digitalarray1.Count() > 0)
                    {
                        if (temp_digitalarray1[0].ToString() != "")
                            lbltemp_digital1.Text = temp_digitalarray1[0].ToString();
                        if (temp_digitalarray1[1].ToString() != "")
                            lbltemp_digital2.Text = temp_digitalarray1[1].ToString();
                        if (temp_digitalarray1[2].ToString() != "")
                            lbltemp_digital3.Text = temp_digitalarray1[2].ToString();
                        if (temp_digitalarray1[3].ToString() != "")
                            lbltemp_digital4.Text = temp_digitalarray1[3].ToString();
                        if (temp_digitalarray1[4].ToString() != "")
                            lbltemp_digital5.Text = temp_digitalarray1[4].ToString();
                        if (temp_digitalarray1[5].ToString() != "")
                            lbltemp_digital6.Text = temp_digitalarray1[5].ToString();
                        if (temp_digitalarray1[6].ToString() != "")
                            lbltemp_digital7.Text = temp_digitalarray1[6].ToString();
                        if (temp_digitalarray1[7].ToString() != "")
                            lbltemp_digital8.Text = temp_digitalarray1[7].ToString();
                        if (temp_digitalarray1[8].ToString() != "")
                            lbltemp_digital9.Text = temp_digitalarray1[8].ToString();
                        if (temp_digitalarray1[9].ToString() != "")
                            lbltemp_digital10.Text = temp_digitalarray1[9].ToString();
                        if (temp_digitalarray1[10].ToString() != "")
                            lbltemp_digital11.Text = temp_digitalarray1[10].ToString();




                    }
                }
                if (j == 1)
                {
                    temp_digitaltr2++;
                    string[] temp_digitalarray2 = { };
                    StringBuilder sb_digital2 = new StringBuilder();
                    sb_digital2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_digital2.ToString();
                    temp_digitalarray2 = perfvalue1.Split(',');
                    if (temp_digitalarray2.Count() > 0)
                    {
                        if (temp_digitalarray2[0].ToString() != "")
                            lbltemp_digital12.Text = temp_digitalarray2[0].ToString();
                        if (temp_digitalarray2[1].ToString() != "")
                            lbltemp_digital13.Text = temp_digitalarray2[1].ToString();
                        if (temp_digitalarray2[2].ToString() != "")
                            lbltemp_digital14.Text = temp_digitalarray2[2].ToString();
                        if (temp_digitalarray2[3].ToString() != "")
                            lbltemp_digital15.Text = temp_digitalarray2[3].ToString();
                        if (temp_digitalarray2[4].ToString() != "")
                            lbltemp_digital16.Text = temp_digitalarray2[4].ToString();
                        if (temp_digitalarray2[5].ToString() != "")
                            lbltemp_digital17.Text = temp_digitalarray2[5].ToString();
                        if (temp_digitalarray2[6].ToString() != "")
                            lbltemp_digital18.Text = temp_digitalarray2[6].ToString();
                        if (temp_digitalarray2[7].ToString() != "")
                            lbltemp_digital19.Text = temp_digitalarray2[7].ToString();
                        if (temp_digitalarray2[8].ToString() != "")
                            lbltemp_digital20.Text = temp_digitalarray2[8].ToString();
                        if (temp_digitalarray2[9].ToString() != "")
                            lbltemp_digital21.Text = temp_digitalarray2[9].ToString();
                        if (temp_digitalarray2[10].ToString() != "")
                            lbltemp_digital22.Text = temp_digitalarray2[10].ToString();


                    }
                }
            }
        }
    }
    public void showdiv_tr()
    {
        temp_digitaldiv.Visible = true;
        tr_tempdigthermo1.Visible = true;
        tr_tempdigthermo2.Visible = true;
       
    }
    public void Hide_perftable()
    {
        if (temp_digitalid == 0)
            temp_digitaldiv.Visible = false;
        else
            lbltempdigital.Text = "Temperature Measurement Digital Thermometer";
        if (temp_digitaltr1 == 0)
            tr_tempdigthermo1.Visible = false;
        if (temp_digitaltr1 == 0)
            tr_tempdigthermo2.Visible = false;
        
    }
}