using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Services;
using System.Web.UI.HtmlControls;

public partial class Add_PerfTest : System.Web.UI.Page
{

    Dbclass db1 = new Dbclass();
   
    string sqlcon = ConfigurationManager.ConnectionStrings["surgchemcon"].ToString();

    /*functions to give number of controls to be dynamically display textbox*/
    protected int NumberOfControls
    {
        get { return Convert.ToInt32(Session["noCon"]); }
        set { Session["noCon"] = value.ToString(); }
    }
    protected int NumberOfControls1
    {
        get { return Convert.ToInt32(Session["noCon1"]); }
        set { Session["noCon1"] = value.ToString(); }
    }

    /* Numberofcontrol function for dynamic textbox ends*/

   

    /* createcontrol function to add dynamic textbox to placeholder*/
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
    private void createControls1()
    {
        int count = this.NumberOfControls1;

        for (int i = 0; i < count; i++)
        {
            //Label lb = new Label();
            TextBox txsub = new TextBox();
            //lb.ID = "lbldata" + i.ToString();
            txsub.ID = "txtDatasub" + i.ToString();

            //lb.Text = "Cat Name";
            //Add the Controls to the container of your choice
            // PlaceHolder1.Controls.Add(lb);
            PlaceHolder2.Controls.Add(txsub);

        }

    }

    /*createcontrol for dynamic textbox to add to placeholder ends*/

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.IsAuthenticated && Session["Usertype"] != null)
        {
            string usertype = Session["Usertype"].ToString();
            if (usertype == "")
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                HtmlGenericControl listperformance = (HtmlGenericControl)this.Master.FindControl("liperformance");
                listperformance.Style.Add("background-color", "#195A7F");

                if (!Page.IsPostBack)
                {
                    //Initiate the counter of dynamically added controls
                    this.NumberOfControls = 0;
                    this.NumberOfControls1 = 0;
                    select_perftest_name();
                }
                else
                {
                    //Controls must be repeatedly be created on postback
                    this.createControls();
                    this.createControls1();
                }
            }

        }
        else
        {
            Response.Redirect("Default.aspx");
        }
       
    }

    //create dynamic textbox for categories
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        
        TextBox tbx = new TextBox();
        tbx.ID = "txtData" + NumberOfControls;
        tbx.Attributes.Add("onfocus", "if(this.value=='Category Name')this.style.color='red'");
        NumberOfControls++;

        PlaceHolder1.Controls.Add(tbx);
    }

    //save dynamic values of categories to database
    protected void btnRead_Click(object sender, EventArgs e)
    {
        db1.strCommand = "insert into PerformanceTest values('" + txtperfname.Text.Trim().Replace("'","''") + "')";
        db1.insertqry();
        retrieve_performancetest();
        int count = this.NumberOfControls;

        for (int i = 0; i < count; i++)
        {
            TextBox tx = (TextBox)PlaceHolder1.FindControl("txtData" + i.ToString());
            //Add the Controls to the container of your choice

            SqlConnection con = new SqlConnection(sqlcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Perf_Category(PerfID,CategoryName)values('" + perfid + "','" + tx.Text.Trim().Replace("'","''") + "')", con);
            cmd.ExecuteNonQuery();
            tx.Text = "";
            txtperfname.Text = "";
            select_perftest_name();
            
        }
        string path = Page.Request.Url.AbsolutePath;
        Response.Redirect(path);
    }


    //insert function to save performance testname to databasee
    string perfname = "";
    string perfid = "";
    public void save_performancetest()
    {
        ViewState["perfname"] = txtperfname.Text;

        db1.strCommand = "insert into PerformanceTest values('" + txtperfname.Text.Trim().Replace("'","''") + "')";
        db1.insertqry();
        perfname = ViewState["perfname"].ToString();

    }
    //function to select performance test ID
    public void retrieve_performancetest()
    {

        db1.strCommand = "select max(PerfID) from PerformanceTest ";
        perfid = db1.executescalar();
    }

   
    //select perfid and test name from table for binding dropdownlist of performance test.
    public void select_perftest_name()
    {
        db1.strCommand = "select PerfID,Perf_TestName from PerformanceTest";
        DataTable dt = db1.selecttable();
        ddperftest.Items.Clear();
       if(dt.Rows.Count>0)
        {
            
            ddperftest.DataSource = dt;
            ddperftest.DataTextField ="Perf_TestName";
            ddperftest.DataValueField ="PerfID";
            ddperftest.DataBind();
            
        }
       ddperftest.Items.Insert(0, "--select Performance Test--");
    }

    //event to bind dropdown for categories based on performance test.
    protected void ddperftest_SelectedIndexChanged(object sender, EventArgs e)
    {
        db1.strCommand = "select CategoryID,CategoryName from Perf_Category where PerfID='"+ddperftest.SelectedValue+"'";
        DataTable dt_cat = db1.selecttable();
        ddperfcategory.Items.Clear();
       if(dt_cat.Rows.Count>0)
        {
            
            ddperfcategory.DataSource = dt_cat;
            ddperfcategory.DataTextField = "CategoryName";
            ddperfcategory.DataValueField = "CategoryID";
            ddperfcategory.DataBind();
           
        }
       ddperfcategory.Items.Insert(0, "--select Performance Test Category--");
    }

    //create dynamic textbox for sub categories
    protected void btncreatesub_Click(object sender, EventArgs e)
    {
        
        TextBox tbxsub = new TextBox();
        tbxsub.ID = "txtDatasub" + NumberOfControls1;
        
        tbxsub.Attributes.Add("onfocus", "if(this.value=='SubCategory Name')this.style.color='red'");
        NumberOfControls1++;

        PlaceHolder2.Controls.Add(tbxsub);
    }

    //save dynamic values of sucategories
    protected void btnreadsub_Click(object sender, EventArgs e)
    {
        //save_performancetest();
        //retrieve_performancetest();
        int count = this.NumberOfControls1;
        int id = Convert.ToInt32(ddperfcategory.SelectedValue);
        for (int i = 0; i < count; i++)
        {
            TextBox txsub = (TextBox)PlaceHolder2.FindControl("txtDatasub" + i.ToString());
            //Add the Controls to the container of your choice

            SqlConnection con = new SqlConnection(sqlcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Perf_SubCategory(CategoryID,SubCategory_Name)values('" + id + "','" + txsub.Text.Trim().Replace("'","''") + "')", con);
            cmd.ExecuteNonQuery();
            txsub.Text = "";
            ddperfcategory.Items.Clear();
        }
        string path1 = Page.Request.Url.AbsolutePath;
        Response.Redirect(path1);
    }

   
}