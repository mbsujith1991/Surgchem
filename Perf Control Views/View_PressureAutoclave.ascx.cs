using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_PressureAutoclave : System.Web.UI.UserControl
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
    int pressure_atclaveid = 0, pratclavetr1 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_PressureAutoclave(string sReportid,string sPerfid)
    {
        
         pressure_atclaveid++;
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
                    pratclavetr1++;
                    string[] pratclavearray1 = { };
                    StringBuilder sb_pratclave1 = new StringBuilder();
                    sb_pratclave1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_pratclave1.ToString();
                    pratclavearray1 = perfvalue1.Split(',');
                    if (pratclavearray1.Count() > 0)
                    {
                        if (pratclavearray1[0].ToString() != "")
                            lblpratclave1.Text = pratclavearray1[0].ToString();
                        if (pratclavearray1[1].ToString() != "")
                            lblpratclave2.Text = pratclavearray1[1].ToString();
                        if (pratclavearray1[2].ToString() != "")
                            lblpratclave3.Text = pratclavearray1[2].ToString();
                        if (pratclavearray1[3].ToString() != "")
                            lblpratclave4.Text = pratclavearray1[3].ToString();
                        if (pratclavearray1[4].ToString() != "")
                            lblpratclave5.Text = pratclavearray1[4].ToString();
                        if (pratclavearray1[5].ToString() != "")
                            lblpratclave6.Text = pratclavearray1[5].ToString();

                    }
                }
            }

        }
    }

    public void Hide_perftable()
    {
        if (pressure_atclaveid == 0)
            pressure_atclavediv.Visible = false;
        else
            lblpr_atclave.Text = "Pressure Measurement of Autoclave";
        if (pratclavetr1 == 0)
            tr_autoclave1.Visible = false;
       
    }
    public void showdiv_tr()
    {
        pressure_atclavediv.Visible = true;
        tr_autoclave1.Visible = true;
    }
}