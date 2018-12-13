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

public partial class controls_AddTemperature : System.Web.UI.UserControl
{
    Dbclass db1 = new Dbclass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Gridbind();
        }
    }

    public void Gridbind()
    {
        db1.strCommand = "select * from Environ_condition";
        DataSet ds = db1.selectqry();
        if (ds.Tables[0].Rows.Count > 0)
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        else
        {
            ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
            GridView1.DataSource = ds;
            GridView1.DataBind();
            int columncount = GridView1.Rows[0].Cells.Count;
            GridView1.Rows[0].Cells.Clear();
            GridView1.Rows[0].Cells.Add(new TableCell());
            GridView1.Rows[0].Cells[0].ColumnSpan = columncount;
            GridView1.Rows[0].Cells[0].Text = "No Records Found";
        }
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        Gridbind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        Gridbind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int ecmid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
        //string username = GridView1.DataKeys[e.RowIndex].Values["UserName"].ToString();
        TextBox txttemperature = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txttemperature");
        TextBox txtRelative_Humidity = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtRelative_Humidity");
        TextBox txtambient = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtambient");

        db1.strCommand = "update Environ_condition set Temperature='" + txttemperature.Text.Trim() + "',Relative_Humidity='" + txtRelative_Humidity.Text.Trim() + "'," +
            "Ambient_Barometric_measure='" + txtambient.Text.Trim() + "' where ECM_ID=" + ecmid;

        db1.insertqry();

        lblresult.ForeColor = Color.Green;
        lblresult.Text = " Details Updated successfully";
        GridView1.EditIndex = -1;
        Gridbind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int prodid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["ECM_ID"].ToString());
        db1.strCommand = "delete from Environ_condition where ECM_ID=" + prodid;
        db1.insertqry();
        Gridbind();
        lblresult.ForeColor = Color.Red;
        lblresult.Text = " Details deleted successfully";
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("AddNew"))
        {
            TextBox txttempfooter = (TextBox)GridView1.FooterRow.FindControl("txttempfooter");
            TextBox txtRelative_Humidityfooter = (TextBox)GridView1.FooterRow.FindControl("txtRelative_Humidityfooter");
            TextBox txtambientfooter = (TextBox)GridView1.FooterRow.FindControl("txtambientfooter");


            db1.strCommand = "insert into Environ_condition(Temperature,Relative_Humidity,Ambient_Barometric_measure)values " +
                "('" + txttempfooter.Text.Trim() + "','" + txtRelative_Humidityfooter.Text + "','" + txtambientfooter.Text + "')";
            db1.insertqry();
            Gridbind();
            lblresult.ForeColor = Color.Green;
            lblresult.Text = " Details inserted successfully";
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //getting username from particular row
            string prodname = Convert.ToString(DataBinder.Eval(e.Row.DataItem, "Temperature"));
            //identifying the control in gridview
            ImageButton lnkbtnresult = (ImageButton)e.Row.FindControl("imgbtnDelete");
            //raising javascript confirmationbox whenver user clicks on link button
            if (lnkbtnresult != null)
            {
                lnkbtnresult.Attributes.Add("onclick", "javascript:return ConfirmationBox('" + prodname + "')");
            }

        }
    }
}