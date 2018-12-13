using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;  
using System.Web.Services;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;
using System.Web.Script.Services;
using System.IO;
using System.Web.Security;
using Ionic.Zip;
using System.Text;
//using Microsoft.SqlServer.Management.Smo;
//using Microsoft.SqlServer.Management.Common;
//using System.Data.Odbc;


public partial class Admin : System.Web.UI.MasterPage
{
    Dbclass db1 = new Dbclass();
    SqlConnection con = new SqlConnection();
    SqlCommand sqlcmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataTable dt = new DataTable();  
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void lbLogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();

        FormsAuthentication.SignOut();

        
        if (Request.Path.Contains("AddReport.aspx"))
        {
            Response.Redirect("~/Default.aspx");
        }
        else
        {
            Response.Redirect("~/Default.aspx");
        }
    }

  
    protected void lbreport_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/AddReport.aspx");
    }
    protected void lbperformance_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Add_PerfTest.aspx");
    }
    protected void lbhospital_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Add_Hospital_admin.aspx");
    }
    protected void lbview_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/ViewReport.aspx");
    }
    protected void lbproduct_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Add_Product.aspx");
        
    }

    protected void lnkprevent_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/AdminPrevention.aspx");
    }

    
    private void DeleteDirectory(string path)
    {
        if (Directory.Exists(path))
        {
            //Delete all files from the Directory
            foreach (string file in Directory.GetFiles(path))
            {
                File.Delete(file);
            }
            //Delete all child Directories
            //foreach (string directory in Directory.GetDirectories(path))
            //{
            //    DeleteDirectory(directory);
            //}
            //Delete a Directory
            //Directory.Delete(path);
        }
    }

    DataTable m_Results1 = new DataTable();
    DataTable m_Results2 = new DataTable();
    DataTable m_Results3 = new DataTable();
    DataTable m_Results4 = new DataTable();
    DataTable m_Results5 = new DataTable();
    DataTable m_Results6 = new DataTable();
    DataTable m_Results7 = new DataTable();
    DataTable m_Results8 = new DataTable();
    DataTable m_Results9 = new DataTable();
    DataTable m_Results10 = new DataTable();
    DataTable m_Results11 = new DataTable();
    DataTable m_Results12 = new DataTable();
    DataTable m_Results13 = new DataTable();
    DataTable m_Results14 = new DataTable();
    DataTable m_Results15 = new DataTable();

    public void CalibrationStatus()
    {
        string filename = "~/DB_Backup/";
        db1.strCommand = "select * from Calibration_Status";
        DataTable dt = db1.selecttable();
        Session["DtList1"] = dt;
        m_Results1 = Session["DtList1"] as DataTable;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < m_Results1.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results1.Columns[i].ColumnName);
            sb.Append("\"");
            if (i != (m_Results1.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");

        for (int j = 0; j < m_Results1.Rows.Count; j++)
            AddRow1(j, ref sb);

        string strFileName = "~/DB_Backup/Calibration_Status" + DateTime.Now.Ticks.ToString() + ".csv";

        StreamWriter sw = new StreamWriter(Server.MapPath(strFileName));
        sw.Write(sb.ToString());
        sw.Close();
    }

    public void check_perftest()
    {
        string filename = "~/DB_Backup/";
        db1.strCommand = "select * from check_perftest";
        DataTable dt2 = db1.selecttable();
        Session["DtList1"] = dt2;
        m_Results2 = Session["DtList1"] as DataTable;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < m_Results2.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results2.Columns[i].ColumnName);
            sb.Append("\"");
            if (i != (m_Results2.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");

        for (int j = 0; j < m_Results2.Rows.Count; j++)
            AddRow2(j, ref sb);

        string strFileName = "~/DB_Backup/check_perftest" + DateTime.Now.Ticks.ToString() + ".csv";

        StreamWriter sw = new StreamWriter(Server.MapPath(strFileName));
        sw.Write(sb.ToString());
        sw.Close();
    }

    public void Customer_Info()
    {
        string filename = "~/DB_Backup/";
        db1.strCommand = "select * from Customer_Info";
        DataTable dt2 = db1.selecttable();
        Session["DtList1"] = dt2;
        m_Results3 = Session["DtList1"] as DataTable;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < m_Results3.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results3.Columns[i].ColumnName);
            sb.Append("\"");
            if (i != (m_Results3.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");

        for (int j = 0; j < m_Results3.Rows.Count; j++)
            AddRow3(j, ref sb);

        string strFileName = "~/DB_Backup/Customer_Info" + DateTime.Now.Ticks.ToString() + ".csv";

        StreamWriter sw = new StreamWriter(Server.MapPath(strFileName));
        sw.Write(sb.ToString());
        sw.Close();
    }

    public void DUT_info()
    {
        string filename = "~/DB_Backup/";
        db1.strCommand = "select * from DUT_info";
        DataTable dt2 = db1.selecttable();
        Session["DtList1"] = dt2;
        m_Results4 = Session["DtList1"] as DataTable;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < m_Results4.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results4.Columns[i].ColumnName);
            sb.Append("\"");
            if (i != (m_Results4.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");

        for (int j = 0; j < m_Results4.Rows.Count; j++)
            AddRow4(j, ref sb);

        string strFileName = "~/DB_Backup/DUT_info" + DateTime.Now.Ticks.ToString() + ".csv";

        StreamWriter sw = new StreamWriter(Server.MapPath(strFileName));
        sw.Write(sb.ToString());
        sw.Close();
    }

    public void ElectricalSafety()
    {
        string filename = "~/DB_Backup/";
        db1.strCommand = "select * from ElectricalSafety";
        DataTable dt2 = db1.selecttable();
        Session["DtList1"] = dt2;
        m_Results5 = Session["DtList1"] as DataTable;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < m_Results5.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results5.Columns[i].ColumnName);
            sb.Append("\"");
            if (i != (m_Results5.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");

        for (int j = 0; j < m_Results5.Rows.Count; j++)
            AddRow5(j, ref sb);

        string strFileName = "~/DB_Backup/ElectricalSafety" + DateTime.Now.Ticks.ToString() + ".csv";

        StreamWriter sw = new StreamWriter(Server.MapPath(strFileName));
        sw.Write(sb.ToString());
        sw.Close();
    }

    public void ElectValues()
    {
        string filename = "~/DB_Backup/";
        db1.strCommand = "select * from ElectValues";
        DataTable dt2 = db1.selecttable();
        Session["DtList1"] = dt2;
        m_Results6 = Session["DtList1"] as DataTable;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < m_Results6.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results6.Columns[i].ColumnName);
            sb.Append("\"");
            if (i != (m_Results6.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");

        for (int j = 0; j < m_Results6.Rows.Count; j++)
            AddRow6(j, ref sb);

        string strFileName = "~/DB_Backup/ElectValues" + DateTime.Now.Ticks.ToString() + ".csv";

        StreamWriter sw = new StreamWriter(Server.MapPath(strFileName));
        sw.Write(sb.ToString());
        sw.Close();
    }

    public void Environ_condition()
    {
        string filename = "~/DB_Backup/";
        db1.strCommand = "select * from Environ_condition";
        DataTable dt2 = db1.selecttable();
        Session["DtList1"] = dt2;
        m_Results7 = Session["DtList1"] as DataTable;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < m_Results7.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results7.Columns[i].ColumnName);
            sb.Append("\"");
            if (i != (m_Results7.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");

        for (int j = 0; j < m_Results7.Rows.Count; j++)
            AddRow7(j, ref sb);

        string strFileName = "~/DB_Backup/Environ_condition" + DateTime.Now.Ticks.ToString() + ".csv";

        StreamWriter sw = new StreamWriter(Server.MapPath(strFileName));
        sw.Write(sb.ToString());
        sw.Close();
    }

    public void Hospital()
    {
        string filename = "~/DB_Backup/";
        db1.strCommand = "select * from Hospital";
        DataTable dt2 = db1.selecttable();
        Session["DtList1"] = dt2;
        m_Results8 = Session["DtList1"] as DataTable;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < m_Results8.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results8.Columns[i].ColumnName);
            sb.Append("\"");
            if (i != (m_Results8.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");

        for (int j = 0; j < m_Results8.Rows.Count; j++)
            AddRow8(j, ref sb);

        string strFileName = "~/DB_Backup/Hospital" + DateTime.Now.Ticks.ToString() + ".csv";

        StreamWriter sw = new StreamWriter(Server.MapPath(strFileName));
        sw.Write(sb.ToString());
        sw.Close();
    }

    public void LoginTb()
    {
        string filename = "~/DB_Backup/";
        db1.strCommand = "select * from LoginTb";
        DataTable dt2 = db1.selecttable();
        Session["DtList1"] = dt2;
        m_Results9 = Session["DtList1"] as DataTable;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < m_Results9.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results9.Columns[i].ColumnName);
            sb.Append("\"");
            if (i != (m_Results9.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");

        for (int j = 0; j < m_Results9.Rows.Count; j++)
            AddRow9(j, ref sb);

        string strFileName = "~/DB_Backup/LoginTb" + DateTime.Now.Ticks.ToString() + ".csv";

        StreamWriter sw = new StreamWriter(Server.MapPath(strFileName));
        sw.Write(sb.ToString());
        sw.Close();
    }

    public void Performance_Values()
    {
        string filename = "~/DB_Backup/";
        db1.strCommand = "select * from Performance_Values";
        DataTable dt2 = db1.selecttable();
        Session["DtList1"] = dt2;
        m_Results10 = Session["DtList1"] as DataTable;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < m_Results10.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results10.Columns[i].ColumnName);
            sb.Append("\"");
            if (i != (m_Results10.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");

        for (int j = 0; j < m_Results10.Rows.Count; j++)
            AddRow10(j, ref sb);

        string strFileName = "~/DB_Backup/Performance_Values" + DateTime.Now.Ticks.ToString() + ".csv";

        StreamWriter sw = new StreamWriter(Server.MapPath(strFileName));
        sw.Write(sb.ToString());
        sw.Close();
    }

    public void PerformanceTest()
    {
        string filename = "~/DB_Backup/";
        db1.strCommand = "select * from PerformanceTest";
        DataTable dt2 = db1.selecttable();
        Session["DtList1"] = dt2;
        m_Results11 = Session["DtList1"] as DataTable;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < m_Results11.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results11.Columns[i].ColumnName);
            sb.Append("\"");
            if (i != (m_Results11.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");

        for (int j = 0; j < m_Results11.Rows.Count; j++)
            AddRow11(j, ref sb);

        string strFileName = "~/DB_Backup/PerformanceTest" + DateTime.Now.Ticks.ToString() + ".csv";

        StreamWriter sw = new StreamWriter(Server.MapPath(strFileName));
        sw.Write(sb.ToString());
        sw.Close();
    }

    public void perfvaluesplit()
    {
        string filename = "~/DB_Backup/";
        db1.strCommand = "select * from perfvaluesplit";
        DataTable dt2 = db1.selecttable();
        Session["DtList1"] = dt2;
        m_Results12 = Session["DtList1"] as DataTable;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < m_Results12.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results12.Columns[i].ColumnName);
            sb.Append("\"");
            if (i != (m_Results12.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");

        for (int j = 0; j < m_Results12.Rows.Count; j++)
            AddRow12(j, ref sb);

        string strFileName = "~/DB_Backup/perfvaluesplit" + DateTime.Now.Ticks.ToString() + ".csv";

        StreamWriter sw = new StreamWriter(Server.MapPath(strFileName));
        sw.Write(sb.ToString());
        sw.Close();
    }

    public void Product()
    {
        string filename = "~/DB_Backup/";
        db1.strCommand = "select * from Product";
        DataTable dt2 = db1.selecttable();
        Session["DtList1"] = dt2;
        m_Results13 = Session["DtList1"] as DataTable;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < m_Results13.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results13.Columns[i].ColumnName);
            sb.Append("\"");
            if (i != (m_Results13.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");

        for (int j = 0; j < m_Results13.Rows.Count; j++)
            AddRow13(j, ref sb);

        string strFileName = "~/DB_Backup/Product" + DateTime.Now.Ticks.ToString() + ".csv";

        StreamWriter sw = new StreamWriter(Server.MapPath(strFileName));
        sw.Write(sb.ToString());
        sw.Close();
    }


    public void Report_Info()
    {
        string filename = "~/DB_Backup/";
        db1.strCommand = "select * from Report_Info";
        DataTable dt2 = db1.selecttable();
        Session["DtList1"] = dt2;
        m_Results14 = Session["DtList1"] as DataTable;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < m_Results14.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results14.Columns[i].ColumnName);
            sb.Append("\"");
            if (i != (m_Results14.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");

        for (int j = 0; j < m_Results14.Rows.Count; j++)
            AddRow14(j, ref sb);

        string strFileName = "~/DB_Backup/Report_Info" + DateTime.Now.Ticks.ToString() + ".csv";

        StreamWriter sw = new StreamWriter(Server.MapPath(strFileName));
        sw.Write(sb.ToString());
        sw.Close();
    }

    public void Traceability_Info()
    {
        string filename = "~/DB_Backup/";
        db1.strCommand = "select * from Traceability_Info";
        DataTable dt2 = db1.selecttable();
        Session["DtList1"] = dt2;
        m_Results15 = Session["DtList1"] as DataTable;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < m_Results15.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results15.Columns[i].ColumnName);
            sb.Append("\"");
            if (i != (m_Results15.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");

        for (int j = 0; j < m_Results15.Rows.Count; j++)
            AddRow15(j, ref sb);

        string strFileName = "~/DB_Backup/Traceability_Info" + DateTime.Now.Ticks.ToString() + ".csv";

        StreamWriter sw = new StreamWriter(Server.MapPath(strFileName));
        sw.Write(sb.ToString());
        sw.Close();
    }

    private void AddRow1(int nRow, ref StringBuilder sb)
    {
        for (int i = 0; i < m_Results1.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results1.Rows[nRow][i].ToString());
            sb.Append("\"");
            if (i != (m_Results1.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");
    }
    private void AddRow2(int nRow, ref StringBuilder sb)
    {
        for (int i = 0; i < m_Results2.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results2.Rows[nRow][i].ToString());
            sb.Append("\"");
            if (i != (m_Results2.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");
    }
    private void AddRow3(int nRow, ref StringBuilder sb)
    {
        for (int i = 0; i < m_Results3.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results3.Rows[nRow][i].ToString());
            sb.Append("\"");
            if (i != (m_Results3.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");
    }
    private void AddRow4(int nRow, ref StringBuilder sb)
    {
        for (int i = 0; i < m_Results4.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results4.Rows[nRow][i].ToString());
            sb.Append("\"");
            if (i != (m_Results4.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");
    }
    private void AddRow5(int nRow, ref StringBuilder sb)
    {
        for (int i = 0; i < m_Results5.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results5.Rows[nRow][i].ToString());
            sb.Append("\"");
            if (i != (m_Results5.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");
    }
    private void AddRow6(int nRow, ref StringBuilder sb)
    {
        for (int i = 0; i < m_Results6.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results6.Rows[nRow][i].ToString());
            sb.Append("\"");
            if (i != (m_Results6.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");
    }
    private void AddRow7(int nRow, ref StringBuilder sb)
    {
        for (int i = 0; i < m_Results7.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results7.Rows[nRow][i].ToString());
            sb.Append("\"");
            if (i != (m_Results7.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");
    }
    private void AddRow8(int nRow, ref StringBuilder sb)
    {
        for (int i = 0; i < m_Results8.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results8.Rows[nRow][i].ToString());
            sb.Append("\"");
            if (i != (m_Results8.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");
    }
    private void AddRow9(int nRow, ref StringBuilder sb)
    {
        for (int i = 0; i < m_Results9.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results9.Rows[nRow][i].ToString());
            sb.Append("\"");
            if (i != (m_Results9.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");
    }
    private void AddRow10(int nRow, ref StringBuilder sb)
    {
        for (int i = 0; i < m_Results10.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results10.Rows[nRow][i].ToString());
            sb.Append("\"");
            if (i != (m_Results10.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");
    }
    private void AddRow11(int nRow, ref StringBuilder sb)
    {
        for (int i = 0; i < m_Results11.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results11.Rows[nRow][i].ToString());
            sb.Append("\"");
            if (i != (m_Results11.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");
    }
    private void AddRow12(int nRow, ref StringBuilder sb)
    {
        for (int i = 0; i < m_Results12.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results12.Rows[nRow][i].ToString());
            sb.Append("\"");
            if (i != (m_Results12.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");
    }
    private void AddRow13(int nRow, ref StringBuilder sb)
    {
        for (int i = 0; i < m_Results13.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results13.Rows[nRow][i].ToString());
            sb.Append("\"");
            if (i != (m_Results13.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");
    }
    private void AddRow14(int nRow, ref StringBuilder sb)
    {
        for (int i = 0; i < m_Results14.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results14.Rows[nRow][i].ToString());
            sb.Append("\"");
            if (i != (m_Results14.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");
    }

    private void AddRow15(int nRow, ref StringBuilder sb)
    {
        for (int i = 0; i < m_Results15.Columns.Count; i++)
        {
            sb.Append("\"");
            sb.Append(m_Results15.Rows[nRow][i].ToString());
            sb.Append("\"");
            if (i != (m_Results15.Columns.Count - 1))
                sb.Append(",");
        }
        sb.Append("\n");
    }
   
    public void Dbbackup1()
    {
        string filename = "~/DB_Backup/";

        db1.strCommand = "select * from Calibration_Status";
        DataTable dt1 = db1.selecttable();
        string test1 = JsonConvert.SerializeObject(dt1);
        DataTable dt1_1 = (DataTable)JsonConvert.DeserializeObject(test1, dt1.GetType());
        using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/Calibration_Status.txt")))
        {
            writer.WriteLine(test1);
        }

        db1.strCommand = "select * from check_perftest";
        DataTable dt2 = db1.selecttable();
        string test2 = JsonConvert.SerializeObject(dt2);
        DataTable dt2_1 = (DataTable)JsonConvert.DeserializeObject(test2, dt2.GetType());
        //string filename = "~/DB_Backup/check_perftest.txt";
        using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/check_perftest.txt")))
        {
            writer.WriteLine(test2);
        }

        db1.strCommand = "select * from Customer_Info";
        DataTable dt3 = db1.selecttable();
        string test3 = JsonConvert.SerializeObject(dt3);
        DataTable dt3_1 = (DataTable)JsonConvert.DeserializeObject(test3, dt3.GetType());
        using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/Customer_Info.txt")))
        {
            writer.WriteLine(test3);
        }

        db1.strCommand = "select * from DUT_info";
        DataTable dt4 = db1.selecttable();
        string test4 = JsonConvert.SerializeObject(dt4);
        DataTable dt4_1 = (DataTable)JsonConvert.DeserializeObject(test4, dt4.GetType());
        using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/DUT_info.txt")))
        {
            writer.WriteLine(test4);
        }

        db1.strCommand = "select * from ElectricalSafety";
        DataTable dt5 = db1.selecttable();
        string test5 = JsonConvert.SerializeObject(dt5);
        DataTable dt5_1 = (DataTable)JsonConvert.DeserializeObject(test5, dt5.GetType());
        using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/ElectricalSafety.txt")))
        {
            writer.WriteLine(test5);
        }

        db1.strCommand = "select * from ElectValues";
        DataTable dte = db1.selecttable();
        string teste = JsonConvert.SerializeObject(dte);
        DataTable dte_1 = (DataTable)JsonConvert.DeserializeObject(teste, dte.GetType());
        using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/ElectValues.txt")))
        {
            writer.WriteLine(teste);
        }

        db1.strCommand = "select * from Environ_condition";
        DataTable dt6 = db1.selecttable();
        string test6 = JsonConvert.SerializeObject(dt6);
        DataTable dt6_1 = (DataTable)JsonConvert.DeserializeObject(test6, dt6.GetType());
        using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/Environ_condition.txt")))
        {
            writer.WriteLine(test6);
        }

        db1.strCommand = "select * from Hospital";
        DataTable dt7 = db1.selecttable();
        string test7 = JsonConvert.SerializeObject(dt1);
        DataTable dt7_1 = (DataTable)JsonConvert.DeserializeObject(test7, dt7.GetType());
        using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/Hospital.txt")))
        {
            writer.WriteLine(test7);
        }

        db1.strCommand = "select * from LoginTb";
        DataTable dt8 = db1.selecttable();
        string test8 = JsonConvert.SerializeObject(dt8);
        DataTable dt8_1 = (DataTable)JsonConvert.DeserializeObject(test8, dt8.GetType());
        using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/LoginTb.txt")))
        {
            writer.WriteLine(test8);
        }

        db1.strCommand = "select * from Performance_Values";
        DataTable dt9 = db1.selecttable();
        string test9 = JsonConvert.SerializeObject(dt1);
        DataTable dt9_1 = (DataTable)JsonConvert.DeserializeObject(test9, dt9.GetType());
        using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/Performance_Values.txt")))
        {
            writer.WriteLine(test9);
        }

        db1.strCommand = "select * from PerformanceTest";
        DataTable dt10 = db1.selecttable();
        string test10 = JsonConvert.SerializeObject(dt10);
        DataTable dt10_1 = (DataTable)JsonConvert.DeserializeObject(test10, dt10.GetType());
        using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/PerformanceTest.txt")))
        {
            writer.WriteLine(test10);
        }

        db1.strCommand = "select * from perfvaluesplit";
        DataTable dt11 = db1.selecttable();
        string test11 = JsonConvert.SerializeObject(dt11);
        DataTable dt11_1 = (DataTable)JsonConvert.DeserializeObject(test11, dt11.GetType());
        using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/perfvaluesplit.txt")))
        {
            writer.WriteLine(test11);
        }

        db1.strCommand = "select * from Product";
        DataTable dt12 = db1.selecttable();
        string test12 = JsonConvert.SerializeObject(dt12);
        DataTable dt12_1 = (DataTable)JsonConvert.DeserializeObject(test12, dt12.GetType());
        using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/Product.txt")))
        {
            writer.WriteLine(test12);
        }

        db1.strCommand = "select * from Report_Info";
        DataTable dt13 = db1.selecttable();
        string test13 = JsonConvert.SerializeObject(dt13);
        DataTable dt13_1 = (DataTable)JsonConvert.DeserializeObject(test13, dt13.GetType());
        using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/Report_Info.txt")))
        {
            writer.WriteLine(test13);
        }

        db1.strCommand = "select * from Traceability_Info";
        DataTable dt14 = db1.selecttable();
        string test14 = JsonConvert.SerializeObject(dt14);
        DataTable dt14_1 = (DataTable)JsonConvert.DeserializeObject(test14, dt1.GetType());
        using (var writer = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/DB_Backup/Traceability_Info.txt")))
        {
            writer.WriteLine(test14);
        }

        string pathname = Server.MapPath("~/DB_Backup/");
        string[] filename1 = Directory.GetFiles(pathname);
        ZipFile zip = new ZipFile();
        
            zip.AddFiles(filename1, "file");
            zip.Save(Server.MapPath("~/Surgchembackup.zip"));
            //lbltxt.Text = "Zip File Created";

            Response.ContentType = "application/octet-stream";
            Response.AppendHeader("Content-Disposition", "attachment;filename=Surgchembackup.zip");
            string aaa = Server.MapPath(filename + "Calibration_Status.txt");
            Response.TransmitFile(Server.MapPath("~/Surgchembackup.zip"));
            Response.End();
       
       
    }

    protected void lnkbackup_Click(object sender, EventArgs e)
    {
        string path = Server.MapPath("~/DB_Backup");
        DeleteDirectory(path);
        CalibrationStatus();
        check_perftest();
        Customer_Info();
        DUT_info();
        ElectricalSafety();
        ElectValues();
        Environ_condition();
        Hospital();
        LoginTb();
        Product();
        Performance_Values();
        PerformanceTest();
        perfvaluesplit();
        Report_Info();
        Traceability_Info();
        
        string pathname = Server.MapPath("~/DB_Backup/");
        string[] filename1 = Directory.GetFiles(pathname);
        ZipFile zip = new ZipFile();

        zip.AddFiles(filename1, "file");
        zip.Save(Server.MapPath("~/Surgchembackup.zip"));

        Response.ContentType = "application/octet-stream";
        Response.AppendHeader("Content-Disposition", "attachment;filename=Surgchembackup.zip");
        check_perftest();
        Response.TransmitFile(Server.MapPath("~/Surgchembackup.zip"));
        Response.End();
        
    }
    protected void home_Click(object sender, EventArgs e)
    {
        string usertypeid = Session["Usertype"].ToString();

        if (usertypeid == "0")
        {
            Response.Redirect("Add_Hospital_admin.aspx");

        }
        else if (usertypeid == "1")
        {
            
            Response.Redirect("AddReport.aspx");
        }
    }
    
}
