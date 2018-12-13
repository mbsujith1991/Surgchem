using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.IO;

public partial class testfolder_perf_table : System.Web.UI.Page
{
    Dbclass db1 = new Dbclass();
    int valid_outer_count = 0;
    string valueid_outer = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindValue();
        }
    }
    public void BindValue()
    {
        db1.strCommand = "select * from Performance_Values where PerfID='5'";
        DataTable dt = db1.selecttable();
        int count = dt.Rows.Count;
        StringBuilder sb = new StringBuilder();
        StringBuilder sbid = new StringBuilder();
        string val = "", valid = ""; ;
        string[] value = { }, valueid = { } ;
        string[] splitarray = { };
        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < count; i++)
            {
                
                sb.Append(dt.Rows[i]["Perf_Value"].ToString()+" ");
                sbid.Append(dt.Rows[i]["ValueID"].ToString() + " ");
            }


            val = sb.ToString();
            valid = sbid.ToString();
            value = val.Split();
            valueid = valid.Split();
            int validcount = valueid.Count();
            int valcount = value.Count();
            for (int i = 0; i < valcount - 1; i++)
            {
                if (i == 0)
                {
                    string value_1 = value[i].ToString();
                    string valueid_1 = valueid[i].ToString();
                    string[] value_1array = value_1.Split(',');
                    int valid_1count = value_1array.Count();
                    for(int j=0;j<valid_1count-1;j++)
                    {
                        db1.strCommand = "insert into perfvaluesplit(splitvalues,ValueID)values('" + value_1array[j].ToString() + "','" + valueid_1 + "')";
                        db1.insertqry();
                    }
                }
                if (i == 1)
                {
                    string value_2 = value[i].ToString();
                    string valueid_2 = valueid[i].ToString();
                    string[] value_2array = value_2.Split(',');
                    int valid_2count = value_2array.Count();
                    for (int j = 0; j < valid_2count - 1; j++)
                    {
                        db1.strCommand = "insert into perfvaluesplit(splitvalues,ValueID)values('" + value_2array[j].ToString() + "','" + valueid_2 + "')";
                        db1.insertqry();
                    }
                }
                if (i == 2)
                {
                    string value_3 = value[i].ToString();
                    string valueid_3 = valueid[i].ToString();
                    string[] value_3array = value_3.Split(',');
                    int valid_3count = value_3array.Count();
                    for (int j = 0; j < valid_3count - 1; j++)
                    {
                        db1.strCommand = "insert into perfvaluesplit(splitvalues,ValueID)values('" + value_3array[j].ToString() + "','" + valueid_3 + "')";
                        db1.insertqry();
                    }
                }
                if (i == 3)
                {
                    string value_4 = value[i].ToString();
                    string valueid_4 = valueid[i].ToString();
                    string[] value_4array = value_4.Split(',');
                    int valid_4count = value_4array.Count();
                    for (int j = 0; j < valid_4count - 1; j++)
                    {
                        db1.strCommand = "insert into perfvaluesplit(splitvalues,ValueID)values('" + value_4array[j].ToString() + "','" + valueid_4 + "')";
                        db1.insertqry();
                    }
                }
                if (i == 4)
                {
                    string value_5 = value[i].ToString();
                    string valueid_5 = valueid[i].ToString();
                    string[] value_5array = value_5.Split(',');
                    int valid_5count = value_5array.Count();
                    for (int j = 0; j < valid_5count - 1; j++)
                    {
                        db1.strCommand = "insert into perfvaluesplit(splitvalues,ValueID)values('" + value_5array[j].ToString() + "','" + valueid_5 + "')";
                        db1.insertqry();
                    }
                }
                
            }
        }
    }

    public void Populate_perftable()
    {
        db1.strCommand = "select ValueID from Performance_Values where pv.PerfID='5'";  
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                db1.strCommand = "select splitvalue from perfvaluesplit where ValueID='" + dt.Rows[i]["splitvalue"].ToString() + "'";
            }
        }
    }
}