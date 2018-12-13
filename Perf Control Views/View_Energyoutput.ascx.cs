using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_Energyoutput : System.Web.UI.UserControl
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
    int eneroutputid = 0, enerouttr1 = 0, enerouttr2 = 0, enerouttr3 = 0, enerouttr4 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_EnergyOutput(string sReportid, string sPerfid)
    {
        
        eneroutputid++;
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
                    enerouttr1++;
                    string[] energyarray1 = { };
                    StringBuilder sb_energy1 = new StringBuilder();
                    sb_energy1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_energy1.ToString();
                    energyarray1 = perfvalue1.Split(',');
                    if (energyarray1.Count() > 0)
                    {
                        if (energyarray1[0].ToString() != "")
                            lblenout1.Text = energyarray1[0].ToString();
                        if (energyarray1[1].ToString() != "")
                            lblenout2.Text = energyarray1[1].ToString();
                        if (energyarray1[2].ToString() != "")
                            lblenout3.Text = energyarray1[2].ToString();
                        if (energyarray1[3].ToString() != "")
                            lblenout4.Text = energyarray1[3].ToString();
                        if (energyarray1[4].ToString() != "")
                            lblenout5.Text = energyarray1[4].ToString();
                        if (energyarray1[5].ToString() != "")
                            lblenout6.Text = energyarray1[5].ToString();


                    }
                }
                if (j == 1)
                {
                    enerouttr2++;
                    string[] energyarray2 = { };
                    StringBuilder sb_energy2 = new StringBuilder();
                    sb_energy2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue2 = sb_energy2.ToString();
                    energyarray2 = perfvalue2.Split(',');
                    if (energyarray2.Count() > 0)
                    {
                        if (energyarray2[0].ToString() != "")
                            lblenout7.Text = energyarray2[0].ToString();
                        if (energyarray2[1].ToString() != "")
                            lblenout8.Text = energyarray2[1].ToString();
                        if (energyarray2[2].ToString() != "")
                            lblenout9.Text = energyarray2[2].ToString();
                        if (energyarray2[3].ToString() != "")
                            lblenout10.Text = energyarray2[3].ToString();
                        if (energyarray2[4].ToString() != "")
                            lblenout11.Text = energyarray2[4].ToString();
                        if (energyarray2[5].ToString() != "")
                            lblenout12.Text = energyarray2[5].ToString();


                    }
                }
                if (j == 2)
                {
                    enerouttr3++;
                    string[] energyarray3 = { };
                    StringBuilder sb_energy3 = new StringBuilder();
                    sb_energy3.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue3 = sb_energy3.ToString();
                    energyarray3 = perfvalue3.Split(',');
                    if (energyarray3.Count() > 0)
                    {
                        if (energyarray3[0].ToString() != "")
                            lblenout13.Text = energyarray3[0].ToString();
                        if (energyarray3[1].ToString() != "")
                            lblenout14.Text = energyarray3[1].ToString();
                        if (energyarray3[2].ToString() != "")
                            lblenout15.Text = energyarray3[2].ToString();
                        if (energyarray3[3].ToString() != "")
                            lblenout16.Text = energyarray3[3].ToString();
                        if (energyarray3[4].ToString() != "")
                            lblenout17.Text = energyarray3[4].ToString();
                        if (energyarray3[5].ToString() != "")
                            lblenout18.Text = energyarray3[5].ToString();

                    }
                }
                if (j == 3)
                {
                    enerouttr4++;
                    string[] energyarray4 = { };
                    StringBuilder sb_energy4 = new StringBuilder();
                    sb_energy4.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue3 = sb_energy4.ToString();
                    energyarray4 = perfvalue3.Split(',');
                    if (energyarray4.Count() > 0)
                    {
                        if (energyarray4[0].ToString() != "")
                            lblenout19.Text = energyarray4[0].ToString();
                        if (energyarray4[1].ToString() != "")
                            lblenout20.Text = energyarray4[1].ToString();
                        if (energyarray4[2].ToString() != "")
                            lblenout21.Text = energyarray4[2].ToString();
                        if (energyarray4[3].ToString() != "")
                            lblenout22.Text = energyarray4[3].ToString();
                        if (energyarray4[4].ToString() != "")
                            lblenout23.Text = energyarray4[4].ToString();
                        if (energyarray4[5].ToString() != "")
                            lblenout24.Text = energyarray4[5].ToString();

                    }
                }
            }
        }
    }

    public void Hide_perftable()
    {
        if (eneroutputid == 0)
            energyoutputdiv.Visible = false;
        else
            lblenergyoutput.Text = "Energy Output";
        if (enerouttr1 == 0)
        {
            tr_energy1.Visible = false;
        }
        if (enerouttr2 == 0)
        {
            tr_energy2.Visible = false;
        }
        if (enerouttr3 == 0)
        {
            tr_energy3.Visible = false;
        }
        if (enerouttr4 == 0)
        {
            tr_energy4.Visible = false;
        }
    }
    public void showdiv_tr()
    {
        energyoutputdiv.Visible = true;
        tr_energy1.Visible = true;
        tr_energy2.Visible = true;
        tr_energy3.Visible = true;
        tr_energy4.Visible = true;
    }
}