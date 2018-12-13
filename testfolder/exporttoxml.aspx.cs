using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;
using System.Web.Script.Services;
using System.IO;

public partial class testfolder_exporttoxml : System.Web.UI.Page
{
    Dbclass db1 = new Dbclass();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
    }
    protected void btnexport_Click(object sender, EventArgs e)
    {
       
        SelectMethod();
       
    }
    public void db_backup()
    {
        db1.strCommand = "select * from LoginTb";
        DataSet ds = new DataSet();
        ds = db1.selectqry();
        //ds.Tables[0].WriteXml(@"D:\resumes\LoginTb.xml");
        ds.Tables[0].WriteXml(Server.MapPath(@"D:\DB_Backup\LoginTb.xml"));

        db1.strCommand = "select * from Hospital";
        DataSet ds_hospital = new DataSet();
        ds_hospital = db1.selectqry();
        //ds_hospital.Tables[0].WriteXml(@"D:\resumes\Hospital.xml");
        ds.Tables[0].WriteXml(Server.MapPath(@"D:\DB_Backup\Hospital.xml"));

        db1.strCommand = "select * from Calibration_Status";
        DataSet ds_calib = new DataSet();
        ds_calib = db1.selectqry();
        //ds_calib.Tables[0].WriteXml(@"D:\resumes\Calibration_Status.xml");
        ds.Tables[0].WriteXml(Server.MapPath(@"D:\DB_Backup\Calibration_Status.xml"));

        db1.strCommand = "select * from Customer_Info";
        DataSet ds_customer = new DataSet();
        ds_customer = db1.selectqry();
        //ds_customer.Tables[0].WriteXml(@"D:\resumes\Customer_Info.xml");
        ds.Tables[0].WriteXml(Server.MapPath(@"D:\DB_Backup\Customer_Info.xml"));

        db1.strCommand = "select * from DUT_info";
        DataSet ds_dut = new DataSet();
        ds_dut = db1.selectqry();
        //ds_dut.Tables[0].WriteXml(@"D:\resumes\DUT_info.xml");
        ds.Tables[0].WriteXml(Server.MapPath(@"D:\DB_Backup\DUT_info.xml"));

        db1.strCommand = "select * from ElectricalSafety";
        DataSet ds_electrical = new DataSet();
        ds_electrical = db1.selectqry();
        //ds_electrical.Tables[0].WriteXml(@"D:\resumes\ElectricalSafety.xml");
        ds.Tables[0].WriteXml(Server.MapPath(@"D:\DB_Backup\ElectricalSafety.xml"));

        db1.strCommand = "select * from Environ_condition";
        DataSet ds_environ = new DataSet();
        ds_environ = db1.selectqry();
        //ds_environ.Tables[0].WriteXml(@"D:\resumes\Environ_condition.xml");
        ds.Tables[0].WriteXml(Server.MapPath(@"D:\DB_Backup\Environ_condition.xml"));

        db1.strCommand = "select * from Perf_Category";
        DataSet ds_perfcategory = new DataSet();
        ds_perfcategory = db1.selectqry();
        //ds_perfcategory.Tables[0].WriteXml(@"D:\resumes\Perf_Category.xml");
        ds.Tables[0].WriteXml(Server.MapPath(@"D:\DB_Backup\Perf_Category.xml"));

        db1.strCommand = "select * from Perf_SubCategory";
        DataSet ds_subcategory = new DataSet();
        ds_subcategory = db1.selectqry();
        //ds_subcategory.Tables[0].WriteXml(@"D:\resumes\Perf_SubCategory.xml");
        ds.Tables[0].WriteXml(Server.MapPath(@"D:\DB_Backup\Perf_SubCategory.xml"));

        db1.strCommand = "select * from Perf_Value";
        DataSet ds_value = new DataSet();
        ds_value = db1.selectqry();
        //ds_value.Tables[0].WriteXml(@"D:\resumes\Perf_Value.xml");
        ds.Tables[0].WriteXml(Server.MapPath(@"D:\DB_Backup\Perf_Value.xml"));

        db1.strCommand = "select * from PerformanceTest";
        DataSet ds_perftest = new DataSet();
        ds_perftest = db1.selectqry();
        //ds_perftest.Tables[0].WriteXml(@"D:\resumes\PerformanceTest.xml");
        ds.Tables[0].WriteXml(Server.MapPath(@"D:\DB_Backup\PerformanceTest.xml"));

        db1.strCommand = "select * from Product";
        DataSet ds_product = new DataSet();
        ds_product = db1.selectqry();
        //ds_product.Tables[0].WriteXml(@"D:\resumes\Product.xml");
        ds.Tables[0].WriteXml(Server.MapPath(@"D:\DB_Backup\Product.xml"));

        db1.strCommand = "select * from Report_Info";
        DataSet ds_report = new DataSet();
        ds_report = db1.selectqry();
        //ds_report.Tables[0].WriteXml(@"D:\resumes\Report_Info.xml");
        ds.Tables[0].WriteXml(Server.MapPath(@"D:\DB_Backup\Report_Info.xml"));

        db1.strCommand = "select * from Traceability_Info";
        DataSet ds_traceability = new DataSet();
        ds_traceability = db1.selectqry();
        //ds_traceability.Tables[0].WriteXml(@"D:\resumes\Traceability_Info.xml");
        ds.Tables[0].WriteXml(Server.MapPath(@"D:\DB_Backup\Traceability_Info.xml"));
    }

   

    [WebMethod]
    public static string SelectMethod()
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Surgchem;Integrated Security=true");
        {
            SqlCommand cmd = new SqlCommand("select * from Calibration_Status", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(@"h:\root\home\sujithbalan-001\www\site1\DB_Backup\Calibration_Status.txt"))
                {
                    writer.WriteLine(test);
                }
               
               
                
            }
            SqlCommand cmd1 = new SqlCommand("select * from check_perftest", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(@"D:\DB_Backup\check_perftest.txt"))
                {
                    writer.WriteLine(test);
                }


               
            }
            SqlCommand cm2 = new SqlCommand("select * from Customer_Info", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(@"D:\DB_Backup\Customer_Info.txt"))
                {
                    writer.WriteLine(test);
                }


                
            }
            SqlCommand cmd3 = new SqlCommand("select * from DUT_info", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(@"D:\DB_Backup\DUT_info.txt"))
                {
                    writer.WriteLine(test);
                }


               
            }
            SqlCommand cmd4 = new SqlCommand("select * from ElectricalSafety", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(@"D:\DB_Backup\ElectricalSafety.txt"))
                {
                    writer.WriteLine(test);
                }


               
            }
            SqlCommand cmd5 = new SqlCommand("select * from Environ_condition", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(@"D:\DB_Backup\Environ_condition.txt"))
                {
                    writer.WriteLine(test);
                }


                
            }
            SqlCommand cmd6 = new SqlCommand("select * from Hospital", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(@"D:\DB_Backup\Hospital.txt"))
                {
                    writer.WriteLine(test);
                }


                
            }
            SqlCommand cmd7 = new SqlCommand("select * from LoginTb", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(@"D:\DB_Backup\LoginTb.txt"))
                {
                    writer.WriteLine(test);
                }


                
            }
            SqlCommand cmd8 = new SqlCommand("select * from Performance_Values", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(@"D:\DB_Backup\Performance_Values.txt"))
                {
                    writer.WriteLine(test);
                }


              
            }
            SqlCommand cmd9 = new SqlCommand("select * from PerformanceTest", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(@"D:\DB_Backup\PerformanceTest.txt"))
                {
                    writer.WriteLine(test);
                }


               
            }
            SqlCommand cmd10 = new SqlCommand("select * from perfvaluesplit", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(@"D:\DB_Backup\perfvaluesplit.txt"))
                {
                    writer.WriteLine(test);
                }


                
            }
            SqlCommand cmd11 = new SqlCommand("select * from Product", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(@"D:\DB_Backup\Product.txt"))
                {
                    writer.WriteLine(test);
                }


               
            }
            SqlCommand cmd12 = new SqlCommand("select * from Report_Info", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(@"D:\DB_Backup\Report_Info.txt"))
                {
                    writer.WriteLine(test);
                }


               
            }
            SqlCommand cmd13 = new SqlCommand("select * from Traceability_Info", con);
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                string test = JsonConvert.SerializeObject(dt); // Serialization
                //JsonConvert.DeserializeObject(test);
                DataTable dtt = (DataTable)JsonConvert.DeserializeObject(test, dt.GetType());

                using (var writer = new StreamWriter(@"D:\DB_Backup\Traceability_Info.txt"))
                {
                    writer.WriteLine(test);
                }


                return test;
            }
        }
    }

 
}