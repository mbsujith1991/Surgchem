using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;

public partial class testfolder_AccuracyTest : System.Web.UI.UserControl
{
    Dbclass db1 = new Dbclass();
    string  _perfvalue;
    public string PerfValueid
    {
        get { return _perfvalue; }
        set { _perfvalue = value; }
    }
    
    protected int NumberOfControls1
    {
        get { return Convert.ToInt32(Session["noCon1"]); }
        set { Session["noCon1"] = value.ToString(); }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //Initiate the counter of dynamically added controls
            this.NumberOfControls1 = 0;
           

        }
        else
        {
            //Controls must be repeatedly be created on postback
            this.createControls1();

        }
    }
    private void createControls1()
    {
        int count1 = this.NumberOfControls1;


        for (int i = 0; i < count1; i++)
        {
            //Label lb = new Label();
            TextBox txcat = new TextBox();
            TextBox txsubcat = new TextBox();
            TextBox txsubcat1 = new TextBox();
            TextBox txsubcat2 = new TextBox();
            TextBox txsubcat3 = new TextBox();
            TextBox txsubcat4 = new TextBox();
            TextBox txsubcat5 = new TextBox();
            TextBox txsubcat6 = new TextBox();
            
            txcat.ID = "txtData" + i.ToString();
            txcat.Width = 117;
            PlaceHolder1.Controls.Add(txcat);

            txsubcat.ID = "txtsubData" + i.ToString();
            txsubcat.Width = 124;
            PlaceHolder1.Controls.Add(txsubcat);

            txsubcat1.ID = "txtsubData_1" + i.ToString();
            txsubcat1.Width = 134;
            PlaceHolder1.Controls.Add(txsubcat1);

            txsubcat2.ID = "txtsubData_2" + i.ToString();
            txsubcat2.Width = 124;
            PlaceHolder1.Controls.Add(txsubcat2);

            txsubcat3.ID = "txtsubData_3" + i.ToString();
            txsubcat3.Width = 133;
            PlaceHolder1.Controls.Add(txsubcat3);

            txsubcat4.ID = "txtsubData_4" + i.ToString();
            txsubcat4.Width = 133;
            PlaceHolder1.Controls.Add(txsubcat4);

            txsubcat5.ID = "txtsubData_5" + i.ToString();
            txsubcat5.Width = 137;
            PlaceHolder1.Controls.Add(txsubcat5);

            txsubcat6.ID = "txtsubData_6" + i.ToString();
            txsubcat6.Width = 132;
            PlaceHolder1.Controls.Add(txsubcat6);

            
        }


    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        TextBox tbxcat = new TextBox();
        tbxcat.ID = "txtData" + NumberOfControls1;
        tbxcat.Width = 117;
        tbxcat.Attributes.Add("onfocus", "if(this.value=='Category Name')this.style.color='red'");



        TextBox tbxsubcat = new TextBox();
        tbxsubcat.ID = "txtsubData" + NumberOfControls1;
        tbxsubcat.Width = 124;
        tbxsubcat.Attributes.Add("onfocus", "if(this.value=='Category Name')this.style.color='red'");


        TextBox tbxsubcat1 = new TextBox();
        tbxsubcat1.ID = "txtsubData_1" + NumberOfControls1;
        tbxsubcat1.Width = 134;
        tbxsubcat1.Attributes.Add("onfocus", "if(this.value=='Category Name')this.style.color='red'");


        TextBox tbxsubcat2 = new TextBox();
        tbxsubcat2.ID = "txtsubData_2" + NumberOfControls1;
        tbxsubcat2.Width = 124;
        tbxsubcat2.Attributes.Add("onfocus", "if(this.value=='Category Name')this.style.color='red'");


        TextBox tbxsubcat3 = new TextBox();
        tbxsubcat3.ID = "txtsubData_3" + NumberOfControls1;
        tbxsubcat3.Width = 133;
        tbxsubcat3.Attributes.Add("onfocus", "if(this.value=='Category Name')this.style.color='red'");


        TextBox tbxsubcat4 = new TextBox();
        tbxsubcat4.ID = "txtsubData_4" + NumberOfControls1;
        tbxsubcat4.Width = 133;
        tbxsubcat4.Attributes.Add("onfocus", "if(this.value=='Category Name')this.style.color='red'");


        TextBox tbxsubcat5 = new TextBox();
        tbxsubcat5.ID = "txtsubData_5" + NumberOfControls1;
        tbxsubcat5.Width = 137;
        tbxsubcat5.Attributes.Add("onfocus", "if(this.value=='Category Name')this.style.color='red'");


        TextBox tbxsubcat6 = new TextBox();
        tbxsubcat6.ID = "txtsubData_6" + NumberOfControls1;
        tbxsubcat6.Width = 132;
        tbxsubcat6.Attributes.Add("onfocus", "if(this.value=='Category Name')this.style.color='red'");


        

        NumberOfControls1++;


        PlaceHolder1.Controls.Add(tbxcat);
        PlaceHolder1.Controls.Add(tbxsubcat);
        PlaceHolder1.Controls.Add(tbxsubcat1);
        PlaceHolder1.Controls.Add(tbxsubcat2);
        PlaceHolder1.Controls.Add(tbxsubcat3);
        PlaceHolder1.Controls.Add(tbxsubcat4);
        PlaceHolder1.Controls.Add(tbxsubcat5);
        PlaceHolder1.Controls.Add(tbxsubcat6);
        btnsave.Focus();
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        save_performancetest();
        int count = this.NumberOfControls1;

        for (int i = 0; i < count; i++)
        {
            TextBox txcat = (TextBox)PlaceHolder1.FindControl("txtData" + i.ToString());
            TextBox txsubcat = (TextBox)PlaceHolder1.FindControl("txtsubData" + i.ToString());
            TextBox txsubcat1 = (TextBox)PlaceHolder1.FindControl("txtsubData_1" + i.ToString());
            TextBox txsubcat2 = (TextBox)PlaceHolder1.FindControl("txtsubData_2" + i.ToString());
            TextBox txsubcat3 = (TextBox)PlaceHolder1.FindControl("txtsubData_3" + i.ToString());
            TextBox txsubcat4 = (TextBox)PlaceHolder1.FindControl("txtsubData_4" + i.ToString());
            TextBox txsubcat5 = (TextBox)PlaceHolder1.FindControl("txtsubData_5" + i.ToString());
            TextBox txsubcat6 = (TextBox)PlaceHolder1.FindControl("txtsubData_6" + i.ToString());


            //Add the Controls to the container of your choice


            perf_valueHidden.Value = txcat.Text.Trim().Replace("'", "''") + "," + txsubcat.Text.Trim().Replace("'", "''") + "," +
                txsubcat1.Text.Trim().Replace("'", "''") + "," + txsubcat2.Text.Trim().Replace("'", "''") + "," +
                txsubcat3.Text.Trim().Replace("'", "''") + "," + txsubcat4.Text.Trim().Replace("'", "''") + "," +
                txsubcat5.Text.Trim().Replace("'", "''") + "," + txsubcat6.Text.Trim().Replace("'", "''") + ",";
            db1.strCommand = "insert into Performance_Values(PerfID,Perf_Value) values('" + Session["perfid"].ToString() + "','" + perf_valueHidden.Value + "')";
            db1.insertqry();
            txcat.Text = "";
            txsubcat.Text = "";
            txsubcat1.Text = "";
            txsubcat2.Text = "";
            txsubcat3.Text = "";
            txsubcat4.Text = "";
            txsubcat5.Text = "";
            txsubcat6.Text = "";

        }

        db1.strCommand = "select Top " + count + " ValueID from Performance_Values order by ValueID desc";
        DataTable dt_valueid = db1.selecttable();
      
        if (dt_valueid.Rows.Count > 0)
        {
            for (int i = 0; i < count; i++)
            {
                db1.strCommand = "insert into perfvaluesplit(PerfID,ValueID)values('" + Session["PerfID"].ToString() + "','" + dt_valueid.Rows[i]["ValueID"].ToString() + "')";
                db1.insertqry();
            }

        }
        Removetextbox();
        btnadd.Focus();
    }

    public void Removetextbox()
    {
        int count = this.NumberOfControls1;

        for (int i = 0; i < count; i++)
        {
            TextBox txcat = (TextBox)PlaceHolder1.FindControl("txtData" + i.ToString());
            TextBox txsubcat = (TextBox)PlaceHolder1.FindControl("txtsubData" + i.ToString());
            TextBox txsubcat1 = (TextBox)PlaceHolder1.FindControl("txtsubData_1" + i.ToString());
            TextBox txsubcat2 = (TextBox)PlaceHolder1.FindControl("txtsubData_2" + i.ToString());
            TextBox txsubcat3 = (TextBox)PlaceHolder1.FindControl("txtsubData_3" + i.ToString());
            TextBox txsubcat4 = (TextBox)PlaceHolder1.FindControl("txtsubData_4" + i.ToString());
            TextBox txsubcat5 = (TextBox)PlaceHolder1.FindControl("txtsubData_5" + i.ToString());
            TextBox txsubcat6 = (TextBox)PlaceHolder1.FindControl("txtsubData_6" + i.ToString());
            

            PlaceHolder1.Controls.Remove(txcat);
            PlaceHolder1.Controls.Remove(txsubcat);
            PlaceHolder1.Controls.Remove(txsubcat1);
            PlaceHolder1.Controls.Remove(txsubcat2);
            PlaceHolder1.Controls.Remove(txsubcat3);
            PlaceHolder1.Controls.Remove(txsubcat4);
            PlaceHolder1.Controls.Remove(txsubcat5);
            PlaceHolder1.Controls.Remove(txsubcat6);
            
        }
    }
    //insert function to save performance testname to databasee
    
    public void save_performancetest()
    {
        db1.strCommand = "insert into check_perftest(PerfID,Perf_TestName) values('" + Session["perfid"].ToString() + "','" + Session["performancename"].ToString() + "')";
        db1.insertqry();
       

    }
    //function to select performance test ID
    public void retrieve_performancename()
    {
        db1.strCommand = "select max(ValueID) from Performance_Values";
        perfvalueid_hidden.Value = db1.executescalar();
        
        db1.strCommand = "select Perf_TestName from PerformanceTest   inner join Performance_Values "+
            " on PerformanceTest.PerfID=Performance_Values.PerfID where Performance_Values.ValueID='"+perfvalueid_hidden.Value+"' ";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            perf_namehidden.Value = dt.Rows[0]["Perf_TestName"].ToString();
        }
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        Removetextbox();
    }
}