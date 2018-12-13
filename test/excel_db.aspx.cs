using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;
using System.IO;
using System.Xml;
using System.Globalization;

public partial class test_excel_db : System.Web.UI.Page
{
    Dbclass db1 = new Dbclass();
    string sqlcon = ConfigurationManager.ConnectionStrings["surgchemcon"].ToString();
    string datafile, fileExtension, fileName;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnupload_Click(object sender, EventArgs e)
    {

        upload();
       
    }
    public void upload()
    {
        string filelocation = Server.MapPath(FileUpload1.FileName);
       FileUpload1.SaveAs(Server.MapPath("~/test/"+FileUpload1.FileName));
        //initialising a StreamReader type variable and will pass the file location
       StreamReader oStreamReader = new StreamReader(Server.MapPath("~/test/" + FileUpload1.FileName));

        DataTable oDataTable = null;
        int RowCount = 0;
        string[] ColumnNames = null;
        string[] oStreamDataValues = null;
        //using while loop read the stream data till end
        while (!oStreamReader.EndOfStream)
        {
            String oStreamRowData = oStreamReader.ReadLine().Trim();
            if (oStreamRowData.Length > 0)
            {
                oStreamDataValues = oStreamRowData.Split(',');
                //Bcoz the first row contains column names, we will poluate 
                //the column name by
                //reading the first row and RowCount-0 will be true only once
                if (RowCount == 0)
                {
                    RowCount = 1;
                    ColumnNames = oStreamRowData.Split(',');
                    oDataTable = new DataTable();

                    //using foreach looping through all the column names
                    foreach (string csvcolumn in ColumnNames)
                    {
                        DataColumn oDataColumn = new DataColumn(csvcolumn.ToUpper(), typeof(string));

                        //setting the default value of empty.string to newly created column
                        oDataColumn.DefaultValue = string.Empty;

                        //adding the newly created column to the table
                        oDataTable.Columns.Add(oDataColumn);
                    }
                }
                else
                {
                    //creates a new DataRow with the same schema as of the oDataTable            
                    DataRow oDataRow = oDataTable.NewRow();

                    //using foreach looping through all the column names
                    for (int i = 0; i < ColumnNames.Length; i++)
                    {
                        oDataRow[ColumnNames[i]] = oStreamDataValues[i] == null ? string.Empty : oStreamDataValues[i].ToString();
                    }

                    //adding the newly created row with data to the oDataTable       
                    oDataTable.Rows.Add(oDataRow);
                }
            }
        }
        //close the oStreamReader object
        oStreamReader.Close();
        //release all the resources used by the oStreamReader object
        oStreamReader.Dispose();

        //Looping through all the rows in the Datatable
        foreach (DataRow oDataRow in oDataTable.Rows)
        {

            string RowValues = string.Empty;

            //Looping through all the columns in a row

            foreach (string csvcolumn in ColumnNames)
            {
                //concatenating the values for display purpose
                RowValues += csvcolumn + "=" + oDataRow[csvcolumn].ToString() + ";  ";
            }
            //Displaying the result on the console window
            Console.WriteLine(RowValues);
        }
    }
   // ,[PublishingPoint],[HLS],[Streamer],[Stream]

    static DataTable GetDataTableFromCsv(string path, bool isFirstRowHeader)
    {
        string header = isFirstRowHeader ? "Yes" : "No";

        string pathOnly = Path.GetDirectoryName(path);
        string fileName = Path.GetFileName(path);

        string sql = @"SELECT * FROM [" + fileName + "]";

        using (OleDbConnection connection = new OleDbConnection(
                  @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathOnly +
                  ";Extended Properties=\"Text;HDR=" + header + "\""))
        using (OleDbCommand command = new OleDbCommand(sql, connection))
        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
        {
            string sqlcon = ConfigurationManager.ConnectionStrings["surgchemcon"].ToString();
            DataTable dataTable = new DataTable();
            dataTable.Locale = CultureInfo.CurrentCulture;
            adapter.Fill(dataTable);
            SqlBulkCopy sqlBulk = new SqlBulkCopy(sqlcon);
            sqlBulk.DestinationTableName = "ElectricalSafety";
            sqlBulk.WriteToServer(dataTable);
            connection.Close();
           
            return dataTable;
        }
    }
}