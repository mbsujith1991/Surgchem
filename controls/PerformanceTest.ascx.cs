using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class controls_PerformanceTest : System.Web.UI.UserControl
{
    Dbclass db1 = new Dbclass();
    string sqlcon = ConfigurationManager.ConnectionStrings["surgchemcon"].ToString();
    protected int NumberOfControls
    {
        get { return Convert.ToInt32(Session["noCon"]); }
        set { Session["noCon"] = value.ToString(); }
    }
    private void Page_Init(object sender, System.EventArgs e)
    {
        if (!Page.IsPostBack)
            //Initiate the counter of dynamically added controls
            this.NumberOfControls = 0;
        else
            //Controls must be repeatedly be created on postback
            this.createControls();
    }

    private void createControls()
    {
        int count = this.NumberOfControls;

        for (int i = 0; i < count; i++)
        {
            //Label lb = new Label();
            TextBox tx = new TextBox();
            //lb.ID = "lbldata" + i.ToString();
            tx.ID = "txtData" + i.ToString();

            //lb.Text = "Cat Name";
            //Add the Controls to the container of your choice
            // PlaceHolder1.Controls.Add(lb);
            PlaceHolder1.Controls.Add(tx);

        }


    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        TextBox tbx = new TextBox();
        tbx.ID = "txtData" + NumberOfControls;
        tbx.Attributes.Add("onfocus", "if(this.value=='Category Name')this.style.color='red'");
        NumberOfControls++;

        PlaceHolder1.Controls.Add(tbx);
    }
    protected void btnRead_Click(object sender, EventArgs e)
    {
        int count = this.NumberOfControls;

        for (int i = 0; i < count; i++)
        {
            TextBox tx = (TextBox)PlaceHolder1.FindControl("txtData" + i.ToString());
            //Add the Controls to the container of your choice

            SqlConnection con = new SqlConnection(sqlcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Category(CategoryName)values('" + tx.Text + "')", con);
            cmd.ExecuteNonQuery();
            tx.Text = "";
        }
    }
}