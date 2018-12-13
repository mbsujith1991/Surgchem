using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class controls_Link_Taceability : System.Web.UI.UserControl
{
    Dbclass db1 = new Dbclass();
    protected void Page_Load(object sender, EventArgs e)
    {

        
            BindProduct();
            BindTraceability();
            GridBind();
    }

    public void BindProduct()
    {
        db1.strCommand = "select * from Product order by ProductName Asc";
        DataTable dt = db1.selecttable();
        drpproduct.Items.Clear();
        if (dt.Rows.Count > 0)
        {
            drpproduct.DataSource = dt;
            drpproduct.DataTextField = "ProductName";
            drpproduct.DataValueField = "ProductID";
            drpproduct.DataBind();
        }
        drpproduct.Items.Insert(0, "--Select Product--");
    }

    public void BindTraceability()
    {
        db1.strCommand = "select * from Traceability_Info order by Instrument Asc";
        DataTable dt = db1.selecttable();
        lsttrace.Items.Clear();
        if (dt.Rows.Count > 0)
        {
            lsttrace.DataSource = dt;
            lsttrace.DataTextField = "Instrument";
            lsttrace.DataValueField = "Tracibility_ID";
            lsttrace.DataBind();
        }
      
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        string traceid = "";
        foreach (ListItem li in lsttrace.Items)
        {
            if (li.Selected==true)
            {
                tracehidden.Value = li.Text;
                traceid = li.Value;
                db1.strCommand = "insert into Link_Product_Trace(Instrument,ProductName,Tracibility_ID) values('" + tracehidden.Value + "','" + drpproduct.SelectedItem.Text + "','"+Convert.ToInt32(traceid)+"')";
                db1.insertqry();
            }
        }
       
        lblmsg.Text = "Data Inserted Successfully";
        BindProduct();
        BindTraceability();
        GridBind();

    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        BindTraceability();
        BindProduct();
        GridBind();
    }
    protected void drpproduct_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    public void GridBind()
    {
        db1.strCommand = "select * from Link_Product_Trace";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        GridBind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int linkid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["Linkid"].ToString());
        db1.strCommand = "delete from Link_Product_Trace where Linkid=" + linkid;
        db1.insertqry();
        GridBind();
        lblresult.ForeColor = Color.Red;
        lblresult.Text = " Details deleted successfully";
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        GridBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridBind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int linkid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
        //string username = GridView1.DataKeys[e.RowIndex].Values["UserName"].ToString();
        TextBox txtproduct = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtproduct");
        TextBox txtinstrument = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtinstrument");

        db1.strCommand = "update Link_Product_Trace set ProductName='" + txtproduct.Text.Trim() + "',Instrument='" + txtinstrument.Text.Trim() + "'" +
            " where Linkid=" + linkid;
        db1.insertqry();
        GridView1.EditIndex = -1;
        GridBind();
        lblresult.ForeColor = Color.Green;
        lblresult.Text = " Details Updated successfully";

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
}