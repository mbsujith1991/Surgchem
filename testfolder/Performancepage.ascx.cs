using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;

public partial class testfolder_Performancepage : System.Web.UI.UserControl
{
    Dbclass db1 = new Dbclass();
    string[] perfname_split = { },perfidarray={},perfcatarray1={},perfcatarray2={},perfcatarray3={},perfcatarray4={};
    StringBuilder perfid_builder = new StringBuilder();
    string perfid = "",perfcheck1="",perfcheck2="",perfcheck3="",perfcheck4="";
    string perfcatecheck1 = "", perfcatecheck2 = "", perfcatecheck3 = "", perfcatecheck4 = "";
    string[] perfsubcatarray = { };
    protected void Page_Load(object sender, EventArgs e)
    {
        BindPerformanceTest();
        BindPerfID();
        Bind_PerfCategory();
       //// BindCategory();
       // BindSubcategory();
        //BindSubcategory2();
       // BindSubcategory2();
       // BindSubcategory3();
       // BindPerfValue0();
       // BindPerfValue();
       // BindPerfValue1();
    }
    public void BindPerformanceTest()
    {
        db1.strCommand="select Perf_TestName from Report_Info where Report_info_ID='46'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            StringBuilder perf_builder = new StringBuilder();
            perf_builder.Append(dt.Rows[0]["Perf_TestName"].ToString());
            string perfname = perf_builder.ToString();
            perfname_split=perfname.Split(',');
        }
    }
    public void BindPerfID()
    {
        int perfcount = perfname_split.Count();
        for (int i = 0; i < perfcount - 1; i++)
        {
            db1.strCommand = "select PerfID from PerformanceTest where Perf_TestName='" + perfname_split[i].ToString() + "'";
            DataTable dt = db1.selecttable();
            if (dt.Rows.Count > 0)
            {
                perfid_builder.Append(dt.Rows[0]["PerfID"].ToString() + " ");
                perfid = perfid_builder.ToString();
                perfidarray = perfid.Split();
            }
        }
    }
    public void Bind_PerfCategory()
    {
        int perfidcount = perfidarray.Count();
        for (int i = 0; i < perfidcount - 1; i++)
        {
            if(i==0)
            BindCategory1(perfidarray[i].ToString());
            if (i == 1)
                BindCategory2(perfidarray[i].ToString());
            if (i == 2)
                BindCategory3(perfidarray[i].ToString());
            if (i == 3)
                BindCategory4(perfidarray[i].ToString());
        }
        if (perfcheck1 == "")
            perf1.Visible = false;
        if (perfcheck2 == "")
            perf2.Visible = false;
        if (perfcheck3 == "")
            perf3.Visible = false;
        if (perfcheck4 == "")
            perf4.Visible = false;
    }
    public void BindCategory1(string id)
    {
        db1.strCommand = "select * from Perf_Category where PerfID="+id;
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            StringBuilder cat1builder = new StringBuilder();
            perfcheck1 = "1";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i == 0)
                {
                    lblcat1.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat1builder.Append(dt.Rows[i]["CategoryID"].ToString()+" ");
                }
                if (i == 1)
                {
                    lblcat2.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat1builder.Append(dt.Rows[i]["CategoryID"].ToString()+" ");
                }
                if (i == 2)
                {
                    lblcat3.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat1builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 3)
                {
                    lblcat4.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat1builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 4)
                {
                    lblcat5.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat1builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 5)
                {
                    lblcat6.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat1builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 6)
                {
                    lblcat7.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat1builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 7)
                {
                    lblcat8.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat1builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 8)
                {
                    lblcat9.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat1builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
               
            }
            string category1id = cat1builder.ToString();
            perfcatarray1 = category1id.Split();
            if (lblcat1.Text == "")
                tdcat1_1.Visible = false;
            if (lblcat2.Text == "")
                tdcat1_2.Visible = false;
            if (lblcat3.Text == "")
                tdcat1_3.Visible = false;
            if (lblcat4.Text == "")
                tdcat1_4.Visible = false;
            if (lblcat5.Text == "")
                tdcat1_5.Visible = false;
            if (lblcat6.Text == "")
                tdcat1_6.Visible = false;
            if (lblcat7.Text == "")
                tdcat1_7.Visible = false;
            if (lblcat8.Text == "")
                tdcat1_8.Visible = false;
            if (lblcat9.Text == "")
                tdcat1_9.Visible = false;
        }
    }
    public void BindCategory2(string id)
    {
        db1.strCommand = "select * from Perf_Category where PerfID=" + id;
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            StringBuilder cat2builder = new StringBuilder();
            perfcheck2 = "1";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i == 0)
                {
                    lblcat2_1.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat2builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 1)
                {
                    lblcat2_2.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat2builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                   
                }
                if (i == 2)
                {
                    lblcat2_3.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat2builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 3)
                {
                    lblcat2_4.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat2builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 4)
                {
                    lblcat2_5.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat2builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 5)
                {
                    lblcat2_6.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat2builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 6)
                {
                    lblcat2_7.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat2builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 7)
                {
                    lblcat2_8.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat2builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 8)
                {
                    lblcat2_9.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat2builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }

            }
            string category2id = cat2builder.ToString();
            perfcatarray2 = category2id.Split();
            if (lblcat2_1.Text == "")
                tdcat2_1.Visible = false;
            if (lblcat2_2.Text == "")
                tdcat2_2.Visible = false;
            if (lblcat3.Text == "")
                tdcat2_3.Visible = false;
            if (lblcat2_4.Text == "")
                tdcat2_4.Visible = false;
            if (lblcat2_5.Text == "")
                tdcat2_5.Visible = false;
            if (lblcat2_6.Text == "")
                tdcat2_6.Visible = false;
            if (lblcat2_7.Text == "")
                tdcat2_7.Visible = false;
            if (lblcat2_8.Text == "")
                tdcat2_8.Visible = false;
            if (lblcat2_9.Text == "")
                tdcat2_9.Visible = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(i==0)
                    BindSubcategory2_1(perfcatarray2[i].ToString());
                if (i == 1)
                {
                    BindSubcategory2_2(perfcatarray2[i].ToString());
                }
            }
                
        }
    }
    public void BindCategory3(string id)
    {
        db1.strCommand = "select * from Perf_Category where PerfID=" + id;
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            StringBuilder cat3builder = new StringBuilder();
            perfcheck3 = "1";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i == 0)
                {
                    lblcat3_1.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat3builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 1)
                {
                    lblcat3_2.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat3builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 2)
                {
                    lblcat3_3.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat3builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 3)
                {
                    lblcat3_4.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat3builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 4)
                {
                    lblcat3_5.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat3builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 5)
                {
                    lblcat3_6.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat3builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 6)
                {
                    lblcat3_7.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat3builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 7)
                {
                    lblcat3_8.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat3builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 8)
                {
                    lblcat3_9.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat3builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }

            }
            string category3id = cat3builder.ToString();
            perfcatarray3 = category3id.Split();
            if (lblcat3_1.Text == "")
                tdcat3_1.Visible = false;
            if (lblcat3_2.Text == "")
                tdcat3_2.Visible = false;
            if (lblcat3_3.Text == "")
                tdcat3_3.Visible = false;
            if (lblcat3_4.Text == "")
                tdcat3_4.Visible = false;
            if (lblcat3_5.Text == "")
                tdcat3_5.Visible = false;
            if (lblcat3_6.Text == "")
                tdcat3_6.Visible = false;
            if (lblcat3_7.Text == "")
                tdcat3_7.Visible = false;
            if (lblcat3_8.Text == "")
                tdcat3_8.Visible = false;
            if (lblcat3_9.Text == "")
                tdcat3_9.Visible = false;
        }
    }
    public void BindCategory4(string id)
    {
        db1.strCommand = "select * from Perf_Category where PerfID=" + id;
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            StringBuilder cat4builder = new StringBuilder();
            perfcheck4 = "1";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i == 0)
                {
                    lblcat4_1.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat4builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 1)
                {
                    lblcat4_2.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat4builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 2)
                {
                    lblcat4_3.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat4builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 3)
                {
                    lblcat4_4.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat4builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 4)
                {
                    lblcat4_5.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat4builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 5)
                {
                    lblcat4_6.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat4builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 6)
                {
                    lblcat4_7.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat4builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 7)
                {
                    lblcat4_8.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat4builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }
                if (i == 8)
                {
                    lblcat4_9.Text = dt.Rows[i]["CategoryName"].ToString();
                    cat4builder.Append(dt.Rows[i]["CategoryID"].ToString() + " ");
                }

            }
            string category4id = cat4builder.ToString();
            perfcatarray4 = category4id.Split();
            if (lblcat4_1.Text == "")
                tdcat4_1.Visible = false;
            if (lblcat4_2.Text == "")
                tdcat4_2.Visible = false;
            if (lblcat4_3.Text == "")
                tdcat4_3.Visible = false;
            if (lblcat4_4.Text == "")
                tdcat4_4.Visible = false;
            if (lblcat4_5.Text == "")
                tdcat4_5.Visible = false;
            if (lblcat4_6.Text == "")
                tdcat4_6.Visible = false;
            if (lblcat4_7.Text == "")
                tdcat4_7.Visible = false;
            if (lblcat4_8.Text == "")
                tdcat4_8.Visible = false;
            if (lblcat4_9.Text == "")
                tdcat4_9.Visible = false;
        }
    }
    
    //binding Performance Subcategories//
    public void BindSubcategory2()
    {
        for (int i = 0; i < perfcatarray2.Count() - 1; i++)
        {
            if (i == 0)
            {
                db1.strCommand = "select * from Perf_SubCategory where CategoryID=" + perfcatarray2[0].ToString();
                DataTable dt1 = db1.selecttable();
                if (dt1.Rows.Count > 0)
                {
                    StringBuilder subcatbuilder2_1 = new StringBuilder();
                    perfcatecheck2 = "1";
                    for (int j = 0; i < dt1.Rows.Count; j++)
                    {
                        if (j == 0)
                        {
                            lblsubcat2_1.Text = dt1.Rows[i]["SubCategory_Name"].ToString();
                            subcatbuilder2_1.Append(dt1.Rows[i]["Perf_SubID"].ToString() + " ");
                        }
                        if (j == 1)
                        {
                            lblsubcat2_2.Text = dt1.Rows[i]["SubCategory_Name"].ToString();
                            subcatbuilder2_1.Append(dt1.Rows[i]["Perf_SubID"].ToString() + " ");
                        }
                        if (j == 2)
                        {
                            lblsubcat2_3.Text = dt1.Rows[i]["SubCategory_Name"].ToString();
                            subcatbuilder2_1.Append(dt1.Rows[i]["Perf_SubID"].ToString() + " ");
                        }
                        if (j == 3)
                        {
                            lblsubcat2_4.Text = dt1.Rows[i]["SubCategory_Name"].ToString();
                            subcatbuilder2_1.Append(dt1.Rows[i]["Perf_SubID"].ToString() + " ");
                        }
                    }
                }
            }
            if (i == 1)
            {
                db1.strCommand = "select * from Perf_SubCategory where CategoryID="+perfcatarray2[1].ToString();
                DataTable dt1 = db1.selecttable();
                if (dt1.Rows.Count > 0)
                {
                    StringBuilder subcatbuilder2_2 = new StringBuilder();
                    perfcatecheck2 = "1";
                    for (int j = 0; i < dt1.Rows.Count; j++)
                    {
                        if (j == 0)
                        {
                            lblsubcat2_5.Text = dt1.Rows[i]["SubCategory_Name"].ToString();
                            subcatbuilder2_2.Append(dt1.Rows[i]["Perf_SubID"].ToString() + " ");
                        }
                        if (j == 1)
                        {
                            lblsubcat2_6.Text = dt1.Rows[i]["SubCategory_Name"].ToString();
                            subcatbuilder2_2.Append(dt1.Rows[i]["Perf_SubID"].ToString() + " ");
                        }
                        if (j == 2)
                        {
                            lblsubcat2_7.Text = dt1.Rows[i]["SubCategory_Name"].ToString();
                            subcatbuilder2_2.Append(dt1.Rows[i]["Perf_SubID"].ToString() + " ");
                        }
                        if (j == 3)
                        {
                            lblsubcat2_8.Text = dt1.Rows[i]["SubCategory_Name"].ToString();
                            subcatbuilder2_2.Append(dt1.Rows[i]["Perf_SubID"].ToString() + " ");
                        }
                    }
                    string subcatarray2_2 = subcatbuilder2_2.ToString();
                    perfsubcatarray = subcatarray2_2.Split();
                    
                }
            }
        }

    }
    public void BindSubcategory2_1(string id)
    {
        db1.strCommand = "select * from Perf_SubCategory where CategoryID="+id;
        DataTable dt1 = db1.selecttable();
        if (dt1.Rows.Count > 0)
        {
            StringBuilder subcatbuilder2_1 = new StringBuilder();
            perfcatecheck2 = "1";
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                if (i == 0)
                {
                    lblsubcat2_1.Text = dt1.Rows[i]["SubCategory_Name"].ToString();
                    subcatbuilder2_1.Append(dt1.Rows[i]["Perf_SubID"].ToString() + " ");
                }
                if (i == 1)
                {
                    lblsubcat2_2.Text = dt1.Rows[i]["SubCategory_Name"].ToString();
                    subcatbuilder2_1.Append(dt1.Rows[i]["Perf_SubID"].ToString() + " ");
                }
                if (i == 2)
                {
                    lblsubcat2_3.Text = dt1.Rows[i]["SubCategory_Name"].ToString();
                    subcatbuilder2_1.Append(dt1.Rows[i]["Perf_SubID"].ToString() + " ");
                }
                if (i == 3)
                {
                    lblsubcat2_4.Text = dt1.Rows[i]["SubCategory_Name"].ToString();
                    subcatbuilder2_1.Append(dt1.Rows[i]["Perf_SubID"].ToString() + " ");
                }
            }
        }
    }
    public void BindSubcategory2_2(string id1)
    {
        db1.strCommand = "select * from Perf_SubCategory where CategoryID=" + id1;
        DataTable dt1 = db1.selecttable();
        if (dt1.Rows.Count > 0)
        {
            StringBuilder subcatbuilder2_2 = new StringBuilder();
            perfcatecheck2 = "1";
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                if (i == 0)
                {
                    lblsubcat2_5.Text = dt1.Rows[i]["SubCategory_Name"].ToString();
                    subcatbuilder2_2.Append(dt1.Rows[i]["Perf_SubID"].ToString() + " ");
                }
                if (i == 1)
                {
                    lblsubcat2_6.Text = dt1.Rows[i]["SubCategory_Name"].ToString();
                    subcatbuilder2_2.Append(dt1.Rows[i]["Perf_SubID"].ToString() + " ");
                }
                if (i == 2)
                {
                    lblsubcat2_7.Text = dt1.Rows[i]["SubCategory_Name"].ToString();
                    subcatbuilder2_2.Append(dt1.Rows[i]["Perf_SubID"].ToString() + " ");
                }
                if (i == 3)
                {
                    lblsubcat2_8.Text = dt1.Rows[i]["SubCategory_Name"].ToString();
                    subcatbuilder2_2.Append(dt1.Rows[i]["Perf_SubID"].ToString() + " ");
                }
            }
            string subcatarray2_2=subcatbuilder2_2.ToString();
            perfsubcatarray = subcatarray2_2.Split();
            for (int i = 0; i <dt1.Rows.Count; i++)
            {
                if(i==0)
                BindPerfValue2_2_1(perfcatarray2[1].ToString(), perfsubcatarray[0].ToString());
                if (i == 1)
                BindPerfValue2_2_2(perfcatarray2[1].ToString(), perfsubcatarray[1].ToString());
                   
            }
        }
    }
    public void BindSubcategory3()
    {
        db1.strCommand = "select * from Perf_SubCategory where CategoryID='12'";
        DataTable dt3 = db1.selecttable();
        if (dt3.Rows.Count > 0)
        {
            Label7.Text = dt3.Rows[0]["SubCategory_Name"].ToString();
            Label8.Text = dt3.Rows[1]["SubCategory_Name"].ToString();

        }
    }
    public void BindPerfValue0()
    {
        db1.strCommand = "select * from Perf_Value where CategoryID='8'";
        DataTable dt3 = db1.selecttable();
        if (dt3.Rows.Count > 0)
        {
            DataList3.DataSource = dt3;
            DataList3.DataBind();
        }
    }
    public void BindPerfValue2_2_1(string catid,string subcatid)
    {
        db1.strCommand = "select * from Perf_Value where CategoryID='"+catid+"' and Perf_SubID='"+subcatid+"'";
        DataTable dt3 = db1.selecttable();
        if (dt3.Rows.Count > 0)
        {
            datasubcat2_5.DataSource = dt3;
            datasubcat2_5.DataBind();
        }
    }
    public void BindPerfValue2_2_2(string catid, string subcatid)
    {
        db1.strCommand = "select * from Perf_Value where CategoryID='" + catid + "' and Perf_SubID='" + subcatid + "'";
        DataTable dt3 = db1.selecttable();
        if (dt3.Rows.Count > 0)
        {
            datasubcat2_6.DataSource = dt3;
            datasubcat2_6.DataBind();
        }
    }

}