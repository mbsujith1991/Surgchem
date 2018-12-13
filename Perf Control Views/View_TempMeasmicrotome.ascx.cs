using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_TempMeasmicrotome : System.Web.UI.UserControl
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
    int deepfreeid = 0, deepfreezertr1 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void Bind_TempDeepFreezer(string sReportid, string sPerfid)
    {

        deepfreeid++;
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
                    deepfreezertr1++;
                    string[] deepfreezerarray1 = { };
                    StringBuilder sb_accu1 = new StringBuilder();
                    sb_accu1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_accu1.ToString();
                    deepfreezerarray1 = perfvalue1.Split(',');
                    if (deepfreezerarray1.Count() > 0)
                    {
                        if (deepfreezerarray1[0].ToString() != "")
                            lbldeep1.Text = deepfreezerarray1[0].ToString();
                        if (deepfreezerarray1[1].ToString() != "")
                            lbldeep2.Text = deepfreezerarray1[1].ToString();
                        if (deepfreezerarray1[2].ToString() != "")
                            lbldeep3.Text = deepfreezerarray1[2].ToString();
                        if (deepfreezerarray1[3].ToString() != "")
                            lbldeep4.Text = deepfreezerarray1[3].ToString();
                        if (deepfreezerarray1[4].ToString() != "")
                            lbldeep5.Text = deepfreezerarray1[4].ToString();
                        if (deepfreezerarray1[5].ToString() != "")
                            lbldeep6.Text = deepfreezerarray1[5].ToString();
                        
                        if (deepfreezerarray1[6].ToString() != "")
                            lbldeep9.Text = deepfreezerarray1[6].ToString();
                        if (deepfreezerarray1[7].ToString() != "")
                            lbldeep10.Text = deepfreezerarray1[7].ToString();
                        if (deepfreezerarray1[8].ToString() != "")
                            lbldeep11.Text = deepfreezerarray1[8].ToString();
                        if (deepfreezerarray1[9].ToString() != "")
                            lbldeep12.Text = deepfreezerarray1[9].ToString();
                    }
                }
            }
        }
    }

    public void showdiv_tr()
    {
        tempdeepfreezerdiv.Visible = true;
        tr_deepfreezer1.Visible = true;

    }
    public void Hide_perftable()
    {
        if (deepfreeid == 0)
            tempdeepfreezerdiv.Visible = false;
        else
            lbldeepfreezer.Text = "Temperature Measurement Microtome";
        if (deepfreezertr1 == 0)
            tr_deepfreezer1.Visible = false;


    }
}