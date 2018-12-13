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

public partial class controls_Product : System.Web.UI.UserControl
{
    Dbclass db1 = new Dbclass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GridProductBind();
        }
    }

    public void GridProductBind()
    {
        db1.strCommand = "select * from Product  order by ProductID desc";
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
        GridProductBind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        GridProductBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName.Equals("AddNew"))
           {
               TextBox txtproductfooter = (TextBox)GridView1.FooterRow.FindControl("txtproductfooter");
               TextBox txtmanufacturefooter = (TextBox)GridView1.FooterRow.FindControl("txtmanufacturefooter");
               TextBox txtmodelfooter = (TextBox) GridView1.FooterRow.FindControl("txtmodelfooter");
            TextBox txtdevtypefooter = (TextBox) GridView1.FooterRow.FindControl("txtdevtypefooter");
            TextBox txtdevclassifooter = (TextBox) GridView1.FooterRow.FindControl("txtdevclassifooter");
            TextBox txtsupplyfooter = (TextBox)GridView1.FooterRow.FindControl("txtsupplyfooter");
            TextBox txtpowerfooter = (TextBox)GridView1.FooterRow.FindControl("txtpowerfooter");

            db1.strCommand="insert into Product(ProductName,Company,Model,Device_Type,Device_Classification,Supply,PowerRating)values "+
                "('"+txtproductfooter.Text.Trim()+"','"+txtmanufacturefooter.Text+"','"+txtmodelfooter.Text+"',"+
                "'" + txtdevtypefooter.Text.Trim() + "','" + txtdevclassifooter.Text.Trim() + "','" + txtsupplyfooter.Text.Trim() + "','" + txtpowerfooter.Text.Trim()+ "')";
                db1.insertqry();
                   GridProductBind();
                   lblresult.ForeColor = Color.Green;
                   lblresult.Text = " Details inserted successfully";
               }
               //else
               //{
               //    lblresult.ForeColor = Color.Red;
               //    lblresult.Text = " Details not inserted"; 
               //}
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int prodid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["ProductID"].ToString());
        db1.strCommand = "delete from Product where ProductID=" + prodid;
        db1.insertqry();
        GridProductBind();
            lblresult.ForeColor = Color.Red;
            lblresult.Text =" Details deleted successfully";
       
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridProductBind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int prodid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
        //string username = GridView1.DataKeys[e.RowIndex].Values["UserName"].ToString();
        TextBox txtproductname = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtproduct");
        TextBox txtmanufacture = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtmanufacture");
        TextBox txtmodel = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtmodel");
        TextBox txtdevtype = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtdevtype");
        TextBox txtdevclassi = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtdevclassi");
        TextBox txtsupply = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtsupply");
        TextBox txtpower = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtpower");

        db1.strCommand="update Product set ProductName='"+txtproductname.Text.Trim()+"',Company='"+txtmanufacture.Text.Trim()+"',"+
            "Model='" + txtmodel.Text.Trim() + "',Device_Type='" + txtdevtype.Text.Trim() + "',Device_Classification='"+txtdevclassi.Text.Trim()+"',"+
            "Supply='"+txtsupply.Text.Trim()+"',PowerRating='"+txtpower.Text.Trim()+"' where ProductID="+prodid;

        db1.insertqry();
       
        lblresult.ForeColor = Color.Green;
        lblresult.Text =" Details Updated successfully";
        GridView1.EditIndex = -1;
        GridProductBind();
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //getting username from particular row
            string prodname = Convert.ToString(DataBinder.Eval(e.Row.DataItem, "ProductName"));
            //identifying the control in gridview
            ImageButton lnkbtnresult = (ImageButton)e.Row.FindControl("imgbtnDelete");
            //raising javascript confirmationbox whenver user clicks on link button
            if (lnkbtnresult != null)
            {
                lnkbtnresult.Attributes.Add("onclick", "javascript:return ConfirmationBox('" + prodname + "')");
            }

        }
    }
    protected void imgadd_Click(object sender, ImageClickEventArgs e)
    {

    }
}