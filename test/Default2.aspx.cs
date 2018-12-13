using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class test_Default2 : System.Web.UI.Page
{
    Dbclass db1 = new Dbclass();
    string sqlcon = ConfigurationManager.ConnectionStrings["surgchemcon"].ToString();
    int rowCount = 0;
    protected void Page_load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //Remove the session when first time page loads.
            Session.Remove("clicks");
            addtextbox();
        }

      
    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {

        addtextbox();

    }

    public void addtextbox()
    {

        rowCount = Convert.ToInt32(Session["clicks"]);

        rowCount++;

        //In each button clic save the numbers into the session.
        Session["clicks"] = rowCount;

        //Create the textboxes and labels each time the button is clicked.
        for (int i = 0; i < rowCount; i++)
        {
            TextBox TxtBoxU = new TextBox();
            Label lblU = new Label();
            TxtBoxU.ID = "TextBoxU" + i.ToString();
            lblU.ID = "LabelU" + i.ToString();
            lblU.Text = "Category Name " + (i + 1).ToString() + " : ";

            //Add the labels and textboxes to the Panel.
            Panel1.Controls.Add(lblU);
            Panel1.Controls.Add(TxtBoxU);
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int count = Convert.ToInt32(Session["clicks"]);
        SqlConnection con = new SqlConnection(sqlcon);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        for (int i = 0; i < count; i++)
        {
            TextBox tb = new TextBox();
            string OptionID = "TextBoxU" + i;
             tb = (TextBox)Panel1.FindControl(OptionID);
            //TextBox tb = Panel1.FindControl("TextBoxU0") as TextBox;
            cmd.CommandText = "insert into Category(CategoryName)values('" + tb.Text + "')";
            cmd.ExecuteNonQuery();


            //TextBox txt;

            //foreach (Control c in Panel1.Controls)
            //{
            //    if (c.GetType() == typeof(TextBox))
            //    {
            //        txt = (TextBox)c;
            //        String str = txt.Text;
            //    }
            //}
        }
       
    }
}