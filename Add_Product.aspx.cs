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
using Microsoft.VisualBasic.FileIO;
using System.Web.Services;
using System.Collections.Generic;




public partial class Add_Product : System.Web.UI.Page
{
    Dbclass db1 = new Dbclass();
    
    public string listFilter = null;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.IsAuthenticated && Session["Usertype"] != null)
        {
            
            utypeid_hidden.Value = Session["Usertype"].ToString();
            if (utypeid_hidden.Value == null)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    HtmlGenericControl listproduct = (HtmlGenericControl)this.Master.FindControl("liproduct");
                    listproduct.Style.Add("background-color", "#195A7F");
                    GridProductBind();
                }
            }
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
        
    }


    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> SearchProduct(string prefixText, int count)
    {
        using (SqlConnection conn = new SqlConnection())
        {
            conn.ConnectionString = ConfigurationManager
                    .ConnectionStrings["surgchemcon"].ConnectionString;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "select distinct ProductName from Product where " +
                "ProductName like @SearchText + '%'";
                cmd.Parameters.AddWithValue("@SearchText", prefixText);
                cmd.Connection = conn;
                conn.Open();
                List<string> customers = new List<string>();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        customers.Add(sdr["ProductName"].ToString());
                    }
                }
                conn.Close();
                return customers;
            }
        }
    }
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> Searchcompany(string prefixText, int count)
    {
        using (SqlConnection conn = new SqlConnection())
        {
            conn.ConnectionString = ConfigurationManager
                    .ConnectionStrings["surgchemcon"].ConnectionString;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "select distinct Company from Product where " +
                "Company like @SearchText + '%'";
                cmd.Parameters.AddWithValue("@SearchText", prefixText);
                cmd.Connection = conn;
                conn.Open();
                List<string> customers = new List<string>();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        customers.Add(sdr["Company"].ToString());
                    }
                }
                conn.Close();
                return customers;
            }
        }
    }

    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> Searchmodel(string prefixText, int count)
    {
        using (SqlConnection conn = new SqlConnection())
        {
            conn.ConnectionString = ConfigurationManager
                    .ConnectionStrings["surgchemcon"].ConnectionString;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "select distinct Model from Product where " +
                "Model like @SearchText + '%'";
                cmd.Parameters.AddWithValue("@SearchText", prefixText);
                cmd.Connection = conn;
                conn.Open();
                List<string> customers = new List<string>();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        customers.Add(sdr["Model"].ToString());
                    }
                }
                conn.Close();
                return customers;
            }
        }
    }

    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> Searchdevtype(string prefixText, int count)
    {
        using (SqlConnection conn = new SqlConnection())
        {
            conn.ConnectionString = ConfigurationManager
                    .ConnectionStrings["surgchemcon"].ConnectionString;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "select distinct Device_Type from Product where " +
                "Device_Type like @SearchText + '%'";
                cmd.Parameters.AddWithValue("@SearchText", prefixText);
                cmd.Connection = conn;
                conn.Open();
                List<string> customers = new List<string>();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        customers.Add(sdr["Device_Type"].ToString());
                    }
                }
                conn.Close();
                return customers;
            }
        }
    }
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> Searchdevclassi(string prefixText, int count)
    {
        using (SqlConnection conn = new SqlConnection())
        {
            conn.ConnectionString = ConfigurationManager
                    .ConnectionStrings["surgchemcon"].ConnectionString;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "select distinct Device_Classification from Product where " +
                "Device_Classification like @SearchText + '%'";
                cmd.Parameters.AddWithValue("@SearchText", prefixText);
                cmd.Connection = conn;
                conn.Open();
                List<string> customers = new List<string>();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        customers.Add(sdr["Device_Classification"].ToString());
                    }
                }
                conn.Close();
                return customers;
            }
        }
    }
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> Searchsupply(string prefixText, int count)
    {
        using (SqlConnection conn = new SqlConnection())
        {
            conn.ConnectionString = ConfigurationManager
                    .ConnectionStrings["surgchemcon"].ConnectionString;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "select distinct Supply from Product where " +
                "Supply like @SearchText + '%'";
                cmd.Parameters.AddWithValue("@SearchText", prefixText);
                cmd.Connection = conn;
                conn.Open();
                List<string> customers = new List<string>();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        customers.Add(sdr["Supply"].ToString());
                    }
                }
                conn.Close();
                return customers;
            }
        }
    }
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> Searchpower(string prefixText, int count)
    {
        using (SqlConnection conn = new SqlConnection())
        {
            conn.ConnectionString = ConfigurationManager
                    .ConnectionStrings["surgchemcon"].ConnectionString;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "select distinct PowerRating from Product where " +
                "PowerRating like @SearchText + '%'";
                cmd.Parameters.AddWithValue("@SearchText", prefixText);
                cmd.Connection = conn;
                conn.Open();
                List<string> customers = new List<string>();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        customers.Add(sdr["PowerRating"].ToString());
                    }
                }
                conn.Close();
                return customers;
            }
        }
    }

    public void GridProductBind()
    {
        db1.strCommand = "select * from Product  order by ProductName Asc";
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
    //protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    //{
    //    GridView1.EditIndex = e.NewEditIndex;
    //    GridProductBind();
    //}
    //protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    //{
    //    if (e.CommandName.Equals("AddNew"))
    //    {
    //        TextBox txtproductfooter = (TextBox)GridView1.FooterRow.FindControl("txtproductfooter");
    //        TextBox txtmanufacturefooter = (TextBox)GridView1.FooterRow.FindControl("txtmanufacturefooter");
    //        TextBox txtmodelfooter = (TextBox)GridView1.FooterRow.FindControl("txtmodelfooter");
    //        TextBox txtdevtypefooter = (TextBox)GridView1.FooterRow.FindControl("txtdevtypefooter");
    //        TextBox txtdevclassifooter = (TextBox)GridView1.FooterRow.FindControl("txtdevclassifooter");
    //        TextBox txtsupplyfooter = (TextBox)GridView1.FooterRow.FindControl("txtsupplyfooter");
    //        TextBox txtpowerfooter = (TextBox)GridView1.FooterRow.FindControl("txtpowerfooter");

    //        db1.strCommand = "insert into Product(ProductName,Company,Model,Device_Type,Device_Classification,Supply,PowerRating)values " +
    //            "('" + txtproductfooter.Text.Trim() + "','" + txtmanufacturefooter.Text + "','" + txtmodelfooter.Text + "'," +
    //            "'" + txtdevtypefooter.Text.Trim() + "','" + txtdevclassifooter.Text.Trim() + "','" + txtsupplyfooter.Text.Trim() + "','" + txtpowerfooter.Text.Trim() + "')";
    //        db1.insertqry();
    //        GridProductBind();
    //        lblresult.ForeColor = Color.Green;
    //        lblresult.Text = " Details inserted successfully";
    //    }
    //    //else
    //    //{
    //    //    lblresult.ForeColor = Color.Red;
    //    //    lblresult.Text = " Details not inserted"; 
    //    //}
    //}
    //protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    //{
    //    productidhidden.Value = (GridView1.DataKeys[e.RowIndex].Values["ProductID"].ToString());

    //    db1.strCommand = "delete  from Product where ProductID='" + productidhidden.Value + "'";
    //    db1.insertqry();

    //    GridProductBind();

    //}
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridProductBind();
    }
    //protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    //{
    //    int prodid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
    //    //string username = GridView1.DataKeys[e.RowIndex].Values["UserName"].ToString();
    //    TextBox txtproductname = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtproduct");
    //    TextBox txtmanufacture = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtmanufacture");
    //    TextBox txtmodel = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtmodel");
    //    TextBox txtdevtype = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtdevtype");
    //    TextBox txtdevclassi = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtdevclassi");
    //    TextBox txtsupply = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtsupply");
    //    TextBox txtpower = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtpower");

    //    db1.strCommand = "update Product set ProductName='" + txtproductname.Text.Trim() + "',Company='" + txtmanufacture.Text.Trim() + "'," +
    //        "Model='" + txtmodel.Text.Trim() + "',Device_Type='" + txtdevtype.Text.Trim() + "',Device_Classification='" + txtdevclassi.Text.Trim() + "'," +
    //        "Supply='" + txtsupply.Text.Trim() + "',PowerRating='" + txtpower.Text.Trim() + "' where ProductID=" + prodid;

    //    db1.insertqry();

    //    lblresult.ForeColor = Color.Green;
    //    lblresult.Text = " Details Updated successfully";
    //    GridView1.EditIndex = -1;
    //    GridProductBind();
    //}

    //protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    //{
    //    if (e.Row.RowType == DataControlRowType.DataRow)
    //    {
    //        //getting username from particular row
    //        string prodname = Convert.ToString(DataBinder.Eval(e.Row.DataItem, "ProductName"));
    //        //identifying the control in gridview
    //        ImageButton lnkbtnresult = (ImageButton)e.Row.FindControl("imgbtnDelete");
    //        //raising javascript confirmationbox whenver user clicks on link button
    //        if (lnkbtnresult != null)
    //        {
    //            lnkbtnresult.Attributes.Add("onclick", "javascript:return ConfirmationBox('" + prodname + "')");
    //        }

    //    }
    //}
    //protected void imgadd_Click(object sender, ImageClickEventArgs e)
    //{

    //}


    protected void btnaddpro_Click(object sender, EventArgs e)
    {
        Response.Redirect("Add_Product.aspx");
    }
    protected void btnaddtrace_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddTraceability.aspx");
    }
    protected void btnlink_Click(object sender, EventArgs e)
    {
        Response.Redirect("Linktrace.aspx");
    }
    protected void btnenviron_Click(object sender, EventArgs e)
    {
        Response.Redirect("Environ.aspx");
    }
    protected void btnlinkperformance_Click(object sender, EventArgs e)
    {
        Response.Redirect("Link_Performance_product.aspx");
    }
    protected void btnsearchproduct_Click(object sender, EventArgs e)
    {
        db1.strCommand = "select * from Product where ProductName like '" + txtSearchString1.Text.Trim() + "%'";
        DataSet ds = db1.selectqry();
        if (ds.Tables[0].Rows.Count > 0)
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        txtSearchString1.Text = "";
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        clearfield();
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
       
        if (btnsave.Text == "Save")
        {
            db1.strCommand = "select Model from Product where ProductName like '" + txtproname.Text.Trim() + "' and " +
           "Company like '" + txtmanu.Text.Trim() + "' and Model like '" + txtmodel.Text.Trim() + "'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count <= 0)
        {
            db1.strCommand = "insert into Product(ProductName,Company,Model,Device_Type,Device_Classification,Supply,PowerRating)values " +
                    "('" + txtproname.Text.Trim().Replace("'", "''") + "','" + txtmanu.Text.Trim().Replace("'", "''") + "','" + txtmodel.Text.Trim().Replace("'", "''") + "'," +
                    "'" + txtdevtype.Text.Trim().Replace("'", "''") + "','" + txtdevclassification.Text.Trim().Replace("'", "''") + "','" + txtsupplydata.Text.Trim().Replace("'", "''") + "'," +
            "'" + txtpower.Text.Trim().Replace("'", "''") + "')";
            db1.insertqry();
            GridProductBind();
            clearfield();
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Model Name already exists !');", true);
        }
        }

        else if (btnsave.Text == "Update")
        {
            db1.strCommand = "update Product set ProductName='" + txtproname.Text.Trim().Replace("'", "''") + "'," +
                "Company='" + txtmanu.Text.Trim().Replace("'", "''") + "',Model='" + txtmodel.Text.Trim().Replace("'", "''") + "'," +
                "Device_Type='" + txtdevtype.Text.Trim().Replace("'", "''") + "',Device_Classification='" + txtdevclassification.Text.Trim().Replace("'", "''") + "'," +
                "Supply='" + txtsupplydata.Text.Trim().Replace("'", "''") + "',PowerRating='" + txtpower.Text.Trim().Replace("'", "''") + "'" +
                " where ProductID='" + productidhidden.Value + "'";
            db1.insertqry();
            GridProductBind();
            btnsave.Text = "Save";
            clearfield();
        }
    }

    public void clearfield()
    {
        txtproname.Text = "";
        txtmanu.Text = "";
        txtmodel.Text = "";
        txtdevtype.Text = "";
        txtdevclassification.Text = "";
        txtsupplydata.Text = "";
        txtpower.Text = "";
        btnsave.Text = "Save";
    }
    protected void imgbtnEdit_Click(object sender, ImageClickEventArgs e)
    {
        GridViewRow gvrow = (GridViewRow)((ImageButton)sender).NamingContainer;
        productidhidden.Value = (GridView1.DataKeys[gvrow.RowIndex].Values["ProductID"].ToString());
        btnsave.Text = "Update";

        db1.strCommand = "select * from Product where ProductID='" + productidhidden.Value + "'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            txtproname.Text = dt.Rows[0]["ProductName"].ToString();
            txtmanu.Text = dt.Rows[0]["Company"].ToString();
            txtmodel.Text = dt.Rows[0]["Model"].ToString();
            txtdevtype.Text = dt.Rows[0]["Device_Type"].ToString();
            txtdevclassification.Text = dt.Rows[0]["Device_Classification"].ToString();
            txtsupplydata.Text = dt.Rows[0]["Supply"].ToString();
            txtpower.Text = dt.Rows[0]["PowerRating"].ToString();
            txtproname.Focus();

        }
    }


    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        productidhidden.Value = (GridView1.DataKeys[e.RowIndex].Values["ProductID"].ToString());
        db1.strCommand = "Delete from Product where ProductID='" + productidhidden.Value + "'";
        db1.insertqry();
        GridProductBind();
    }
}