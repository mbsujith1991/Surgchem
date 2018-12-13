using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Perf_Control_Views_View_RPMmeasure : System.Web.UI.UserControl
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
    int rpmid = 0, rpmtr1 = 0, rpmtr2 = 0, rpmtr3 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Bind_RPM(string sReportid, string sPerfid)
    {

        rpmid++;
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
                    rpmtr1++;
                    string[] rpmarray1 = { };
                    StringBuilder sb_rpm1 = new StringBuilder();
                    sb_rpm1.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue1 = sb_rpm1.ToString();
                    rpmarray1 = perfvalue1.Split(',');
                    if (rpmarray1.Count() > 0)
                    {
                        if (rpmarray1[0].ToString() != "")
                            lblrpm1.Text = rpmarray1[0].ToString();
                        if (rpmarray1[1].ToString() != "")
                            lblrpm2.Text = rpmarray1[1].ToString();
                        if (rpmarray1[2].ToString() != "")
                            lblrpm3.Text = rpmarray1[2].ToString();
                        if (rpmarray1[3].ToString() != "")
                            lblrpm4.Text = rpmarray1[3].ToString();
                        if (rpmarray1[4].ToString() != "")
                            lblrpm5.Text = rpmarray1[4].ToString();
                        if (rpmarray1[5].ToString() != "")
                            lblrpm6.Text = rpmarray1[5].ToString();
                        if (rpmarray1[6].ToString() != "")
                            lblrpm7.Text = rpmarray1[6].ToString();
                        if (rpmarray1[7].ToString() != "")
                            lblrpm8.Text = rpmarray1[7].ToString();
                        if (rpmarray1[8].ToString() != "")
                            lblrpm9.Text = rpmarray1[8].ToString();
                        
                        if (rpmarray1[9].ToString() != "")
                            lblrpm11.Text = rpmarray1[9].ToString();
                        if (rpmarray1[10].ToString() != "")
                            lblrpm12.Text = rpmarray1[10].ToString();
                    }
                }
                if (j == 1)
                {
                    rpmtr2++;
                    string[] rpmarray2 = { };
                    StringBuilder sb_rpm2 = new StringBuilder();
                    sb_rpm2.Append(dt_value.Rows[j]["Perf_Value"].ToString());
                    string perfvalue2 = sb_rpm2.ToString();
                    rpmarray2 = perfvalue2.Split(',');
                    if (rpmarray2.Count() > 0)
                    {
                        if (rpmarray2[0].ToString() != "")
                            lblrpm13.Text = rpmarray2[0].ToString();
                        if (rpmarray2[1].ToString() != "")
                            lblrpm14.Text = rpmarray2[1].ToString();
                        if (rpmarray2[2].ToString() != "")
                            lblrpm15.Text = rpmarray2[2].ToString();
                        if (rpmarray2[3].ToString() != "")
                            lblrpm16.Text = rpmarray2[3].ToString();
                        if (rpmarray2[4].ToString() != "")
                            lblrpm17.Text = rpmarray2[4].ToString();
                        if (rpmarray2[5].ToString() != "")
                            lblrpm18.Text = rpmarray2[5].ToString();
                        if (rpmarray2[6].ToString() != "")
                            lblrpm19.Text = rpmarray2[6].ToString();
                        if (rpmarray2[7].ToString() != "")
                            lblrpm20.Text = rpmarray2[7].ToString();
                        if (rpmarray2[8].ToString() != "")
                            lblrpm21.Text = rpmarray2[8].ToString();
                        
                        if (rpmarray2[9].ToString() != "")
                            lblrpm23.Text = rpmarray2[9].ToString();
                        if (rpmarray2[10].ToString() != "")
                            lblrpm24.Text = rpmarray2[10].ToString();

                    }
                }
               

            }


        }
    }

    public void showdiv_tr()
    {
        rpmdiv.Visible = true;
        tr_rpm1.Visible = true;
        tr_rpm2.Visible = true;
       
    }
    public void Hide_perftable()
    {
        if (rpmid == 0)
            rpmdiv.Visible = false;
        else
            lblrpm.Text = "RPM Measurement of Centrifuge";
        if (rpmtr1 == 0)
            tr_rpm1.Visible = false;
        if (rpmtr2 == 0)
            tr_rpm2.Visible = false;
        
    }
}