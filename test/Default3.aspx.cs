using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class test_Default3 : System.Web.UI.Page
{
    Dbclass db1 = new Dbclass();
    string sqlcon = ConfigurationManager.ConnectionStrings["surgchemcon"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //Remove the session when first time page loads.
            Session.Remove("clicks");
        }
    }
     int rowCount = 0;
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(sqlcon);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        var textboxValues = new List<string>();
        if (Request.Form.HasKeys())
        {
            Request.Form.AllKeys.Where(i => i.Contains("Textbox")).ToList().ForEach(i =>
            {
                textboxValues.Add(Request.Form[i]);
                cmd.CommandText = "insert into Category(CategoryName)values('" + Request.Form[i] + "')";
            });
            
        }

        //Do something with the textbox values
        textboxValues.ForEach(i => Response.Write(i + "<br />"));
        container.Visible = false;
        cmd.ExecuteNonQuery();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
       

        //initialize a session.
        rowCount = Convert.ToInt32(Session["clicks"]);

        rowCount++;

        //In each button clic save the numbers into the session.
        Session["clicks"] = rowCount;
        //int numOfTxt = Convert.ToInt32(ddlTextBoxes.SelectedItem.Value);
        var table = new Table();

        for (int i = 0; i < rowCount; i++)
        {
            var row = new TableRow();
            var cell = new TableCell();

            TextBox textbox = new TextBox();
            textbox.ID = "Textbox" + i;
            textbox.Width = new Unit(180);

            cell.Controls.Add(textbox);
            row.Cells.Add(cell);
            table.Rows.Add(row);
        }

        container.Controls.AddAt(0, table);
        container.Visible = true;
    }
}