using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Perf_Control_Views_View_Temperaturemeasurement : System.Web.UI.UserControl
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
    int deepfreeid = 0, deepfreezertr1 = 0,deepfreezertr2 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void Bind_Tempmeasure(string sReportid, string sPerfid)
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
                            lblsetdut1.Text = deepfreezerarray1[1].ToString();
                        if (deepfreezerarray1[2].ToString() != "")
                            lbldeep2.Text = deepfreezerarray1[2].ToString();
                        if (deepfreezerarray1[3].ToString() != "")
                            lbldeep3.Text = deepfreezerarray1[3].ToString();
                        if (deepfreezerarray1[4].ToString() != "")
                            lbldeep4.Text = deepfreezerarray1[4].ToString();
                        if (deepfreezerarray1[5].ToString() != "")
                            lbldeep5.Text = deepfreezerarray1[5].ToString();
                        if (deepfreezerarray1[6].ToString() != "")
                            lbldeep6.Text = deepfreezerarray1[6].ToString();

                        if (deepfreezerarray1[7].ToString() != "")
                            lbldeep7.Text = deepfreezerarray1[7].ToString();
                        if (deepfreezerarray1[8].ToString() != "")
                            lbldeep8.Text = deepfreezerarray1[8].ToString();
                        
                    }
                }
                if (j == 1)
                {
                    deepfreezertr2++;
                    string[] deepfreezerarray2 = { };
                    StringBuilder sb_accu2 = new StringBuilder();
                    sb_accu2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_accu2.ToString();
                    deepfreezerarray2 = perfvalue1.Split(',');
                    if (deepfreezerarray2.Count() > 0)
                    {
                        if (deepfreezerarray2[0].ToString() != "")
                            lbldeep9.Text = deepfreezerarray2[0].ToString();
                        if (deepfreezerarray2[1].ToString() != "")
                            lblsetdut2.Text = deepfreezerarray2[1].ToString();
                        if (deepfreezerarray2[2].ToString() != "")
                            lbldeep10.Text = deepfreezerarray2[2].ToString();
                        if (deepfreezerarray2[3].ToString() != "")
                            lbldeep11.Text = deepfreezerarray2[3].ToString();
                        if (deepfreezerarray2[4].ToString() != "")
                            lbldeep12.Text = deepfreezerarray2[4].ToString();
                        if (deepfreezerarray2[5].ToString() != "")
                            lbldeep13.Text = deepfreezerarray2[5].ToString();
                        if (deepfreezerarray2[6].ToString() != "")
                            lbldeep14.Text = deepfreezerarray2[6].ToString();

                        if (deepfreezerarray2[7].ToString() != "")
                            lbldeep15.Text = deepfreezerarray2[7].ToString();
                        if (deepfreezerarray2[8].ToString() != "")
                            lbldeep16.Text = deepfreezerarray2[8].ToString();
                        
                    }
                }
            }
        }
    }

    public void showdiv_tr()
    {
        tempdeepfreezerdiv.Visible = true;
        tr_deepfreezer1.Visible = true;
        tr_deepfreezer2.Visible = true;

    }
    public void Hide_perftable()
    {
        if (deepfreeid == 0)
            tempdeepfreezerdiv.Visible = false;
        else
            lbldeepfreezer.Text = "Temperature Measurement";
        if (deepfreezertr1 == 0)
            tr_deepfreezer1.Visible = false;
        else if(deepfreezertr2==0)
        {
            tr_deepfreezer2.Visible = false;
        }


    }
}