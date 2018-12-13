using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class controls_AddHospital : System.Web.UI.UserControl
{
    Dbclass db1 = new Dbclass();
    
    private string _usertype;
    public string UsertypeID
    {
        get { return _usertype; }
        set { _usertype = value; }
    }
   
    protected void Page_Load(object sender, EventArgs e)
    {

            if (!IsPostBack)
            {
                txtusername.Text = "";
                txtpswd.Text = "";
                PopulateHospitalInfo();
            }
            if (UsertypeID == "1")
            {
                usertypetr.Visible = false;
            }
            if (UsertypeID == "3")
            {
                usertypetr.Visible = false;
            }
            if (UsertypeID == "4")
            {
                usertypetr.Visible = false;
            }
            if (UsertypeID == "2")
            {
                Response.Redirect("Default.aspx");
            }
      
    }

    //save username, password and usertype to Logintb.
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (btnsave.Text == "Save")
        {
            string query = "select * from LoginTb where Username='" + txtusername.Text.Trim().Replace("'", "''") + "'";
            SqlDataReader dr = db1.getDataReader(query);
            if (dr.HasRows)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Username already exists!');", true);
               
            }
            else
            {
                db1.strCommand = "insert into LoginTb(Username,Password,Usertype) values('" + 
                    txtusername.Text.Trim().Replace("'", "''") + "','" + 
                    txtpswd.Text.Trim().Replace("'", "''") + "','" + 
                    drpusertype.SelectedValue + "')";
                db1.insertqry();
                find_logid();

                clear();
                string path = Page.Request.Url.AbsolutePath;
                Response.Redirect(path);
            }
        }
        else if(btnsave.Text=="Update")
        {
            if (drpusertype.SelectedValue == "2")
            {
                db1.strCommand = "BEGIN TRANSACTION UPDATE LoginTb SET LoginTb.Username = '" +
                    txtusername.Text.Trim().Replace("'", "''") + "' , LoginTb.Password='" +
                    txtpswd.Text.Trim().Replace("'", "''") + "' FROM LoginTb T1, Hospital T2 WHERE T1.LoginID = T2.LoginID and T1.LoginID = '" +
                    logidgrid_hidden.Value + "' UPDATE Hospital SET Hospital.HospitalName = '" +
                    txtname.Text.Trim().Replace("'", "''") + "', Hospital.Address='" +
                    txtaddress.Text.Trim().Replace("'", "''") + "' FROM LoginTb T1, Hospital T2 WHERE T1.LoginID = T2.LoginID and T1.LoginID = '" + logidgrid_hidden.Value + "' COMMIT";
                db1.insertqry();
                PopulateHospitalInfo();
                clear();
            }
            else
            {
                db1.strCommand="Update LoginTb set Username='"+
                    txtusername.Text.Trim().Replace("'","''")+"',Password='"+
                    txtpswd.Text.Trim().Replace("'","''")+"',Usertype='"+
                    drpusertype.SelectedValue+"' where LoginID='"+logidgrid_hidden.Value+"'";
                db1.insertqry();
                PopulateExecutiveInfo();
               
                clear();
               
            }
        }
    }

    //select loginid from logintb based on usertype and username
    public void find_logid()
    {
        try
        {
            if (drpusertype.SelectedValue == "2")
            {
                db1.strCommand = "select max(LoginID) from LoginTb";
                DataTable dt = db1.selecttable();
                if (dt.Rows.Count > 0)
                {
                    logid_hidden.Value = dt.Rows[0][0].ToString();
                }
                
                db1.strCommand = "insert into Hospital(HospitalName,Address,LoginID) values('" + 
                    txtname.Text.Trim().Replace("'","''") + "','" + 
                    txtaddress.Text.Trim().Replace("'","''") + "','" + logid_hidden.Value + "')";
                db1.insertqry();
            }
        }
        catch
        {
            throw;
        }
    }

   
    //clear button
    protected void btncancel_Click(object sender, EventArgs e)
    {
        clear();
       
    }

    // usertype dropdown event to change the views of admin and hospital
    protected void drpusertype_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (drpusertype.SelectedValue == "1")
        {
            hospaddress.Visible = false;
            hospname.Visible = false;
        }
        if (drpusertype.SelectedValue == "3")
        {
            hospaddress.Visible = false;
            hospname.Visible = false;
        }
        if (drpusertype.SelectedValue == "4")
        {
            hospaddress.Visible = false;
            hospname.Visible = false;
        }
        if (drpusertype.SelectedValue == "5")
        {
            hospaddress.Visible = false;
            hospname.Visible = false;
        }
        if (drpusertype.SelectedValue == "6")
        {
            hospaddress.Visible = false;
            hospname.Visible = false;
        }
        
    }


    //clear function
    public void clear()
    {
       
        string pageid = Request.Url.AbsolutePath;
        Response.Redirect(pageid);
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
            if (ddlStatus.SelectedValue == "2")
            {
                if (txtSearchString.Text == "")
                {
                    db1.strCommand = "select LoginTb.LoginID,Username,Password,Usertype,HospitalName,Address from LoginTb inner join Hospital on LoginTb.LoginID=Hospital.LoginID where LoginTb.Usertype=2";
                    DataTable dt_grid = db1.selecttable();
                    if (dt_grid.Rows.Count > 0)
                    {
                        exegrid.Visible = false;
                        CustomersGridView.DataSource = dt_grid;
                        CustomersGridView.DataBind();
                    }
                }
                else if(txtSearchString.Text!="")
                {
                    db1.strCommand = "select LoginTb.LoginID,Username,Password,Usertype,HospitalName,Address from LoginTb inner join Hospital on LoginTb.LoginID=Hospital.LoginID where LoginTb.Usertype=2 and LoginTb.Username like '"+
                        txtSearchString.Text.Trim().Replace("'","''")+"%'";
                    DataTable dt = db1.selecttable();
                    if (dt.Rows.Count > 0)
                    {
                        exegrid.Visible = false;
                        CustomersGridView.DataSource = dt;
                        CustomersGridView.DataBind();
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Hospital Data does not exist');", true);
                    }
                }
               
            }
            if (ddlStatus.SelectedValue == "1")
            {
                if (txtSearchString.Text == "")
                {
                    db1.strCommand = "select LoginID,Username,Password,Usertype from LoginTb where Usertype=1";
                    DataTable dt_grid_exe = db1.selecttable();
                    if (dt_grid_exe.Rows.Count > 0)
                    {
                        CustomersGridView.Visible = false;
                        exegrid.DataSource = dt_grid_exe;
                        exegrid.DataBind();
                    }
                }
                else if (txtSearchString.Text != "")
                {
                    db1.strCommand = "select LoginID, Username,Password,Usertype from LoginTb where Usertype=1 and Username like '"+
                        txtSearchString.Text.Trim().Replace("'","''")+"%'";
                    DataTable dt_grid_exe = db1.selecttable();
                    if (dt_grid_exe.Rows.Count > 0)
                    {
                        CustomersGridView.Visible = false;
                        exegrid.DataSource = dt_grid_exe;
                        exegrid.DataBind();
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Executive Data does not exist');", true);
                    }
                }
                
                
            }
            if (ddlStatus.SelectedValue == "3")
            {
                if (txtSearchString.Text == "")
                {
                    db1.strCommand = "select LoginID,Username,Password,Usertype from LoginTb where Usertype=3";
                    DataTable dt_grid_exe = db1.selecttable();
                    if (dt_grid_exe.Rows.Count > 0)
                    {
                        CustomersGridView.Visible = false;
                        exegrid.DataSource = dt_grid_exe;
                        exegrid.DataBind();
                    }
                }
                else if (txtSearchString.Text != "")
                {
                    db1.strCommand = "select LoginID, Username,Password,Usertype from LoginTb where Usertype=1 and Username like '" +
                        txtSearchString.Text.Trim().Replace("'", "''") + "%'";
                    DataTable dt_grid_exe = db1.selecttable();
                    if (dt_grid_exe.Rows.Count > 0)
                    {
                        CustomersGridView.Visible = false;
                        exegrid.DataSource = dt_grid_exe;
                        exegrid.DataBind();
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Calibration Engr. Data does not exist');", true);
                    }
                }


            }
            if (ddlStatus.SelectedValue == "4")
            {
                if (txtSearchString.Text == "")
                {
                    db1.strCommand = "select LoginID,Username,Password,Usertype from LoginTb where Usertype=4";
                    DataTable dt_grid_exe = db1.selecttable();
                    if (dt_grid_exe.Rows.Count > 0)
                    {
                        CustomersGridView.Visible = false;
                        exegrid.DataSource = dt_grid_exe;
                        exegrid.DataBind();
                    }
                }
                else if (txtSearchString.Text != "")
                {
                    db1.strCommand = "select LoginID, Username,Password,Usertype from LoginTb where Usertype=1 and Username like '" +
                        txtSearchString.Text.Trim().Replace("'", "''") + "%'";
                    DataTable dt_grid_exe = db1.selecttable();
                    if (dt_grid_exe.Rows.Count > 0)
                    {
                        CustomersGridView.Visible = false;
                        exegrid.DataSource = dt_grid_exe;
                        exegrid.DataBind();
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Issuing Officer Data does not exist');", true);
                    }
                }


            }
            if (ddlStatus.SelectedValue == "5")
            {
                if (txtSearchString.Text == "")
                {
                    db1.strCommand = "select LoginID,Username,Password,Usertype from LoginTb where Usertype=5";
                    DataTable dt_grid_exe = db1.selecttable();
                    if (dt_grid_exe.Rows.Count > 0)
                    {
                        CustomersGridView.Visible = false;
                        exegrid.DataSource = dt_grid_exe;
                        exegrid.DataBind();
                    }
                }
                else if (txtSearchString.Text != "")
                {
                    db1.strCommand = "select LoginID, Username,Password,Usertype from LoginTb where Usertype=1 and Username like '" +
                        txtSearchString.Text.Trim().Replace("'", "''") + "%'";
                    DataTable dt_grid_exe = db1.selecttable();
                    if (dt_grid_exe.Rows.Count > 0)
                    {
                        CustomersGridView.Visible = false;
                        exegrid.DataSource = dt_grid_exe;
                        exegrid.DataBind();
                    }
                    //else
                    //{
                    //    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Executive Data does not exist');", true);
                    //}
                }


            }
            if (ddlStatus.SelectedValue == "6")
            {
                if (txtSearchString.Text == "")
                {
                    db1.strCommand = "select LoginID,Username,Password,Usertype from LoginTb where Usertype=6";
                    DataTable dt_grid_exe = db1.selecttable();
                    if (dt_grid_exe.Rows.Count > 0)
                    {
                        CustomersGridView.Visible = false;
                        exegrid.DataSource = dt_grid_exe;
                        exegrid.DataBind();
                    }
                }
                else if (txtSearchString.Text != "")
                {
                    db1.strCommand = "select LoginID, Username,Password,Usertype from LoginTb where Usertype=1 and Username like '" +
                        txtSearchString.Text.Trim().Replace("'", "''") + "%'";
                    DataTable dt_grid_exe = db1.selecttable();
                    if (dt_grid_exe.Rows.Count > 0)
                    {
                        CustomersGridView.Visible = false;
                        exegrid.DataSource = dt_grid_exe;
                        exegrid.DataBind();
                    }
                    //else
                    //{
                    //    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Executive Data does not exist');", true);
                    //}
                }


            }
            txtSearchString.Text = "";
    }
    
    protected void CustomersGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        CustomersGridView.PageIndex = e.NewPageIndex;
        PopulateHospitalInfo();
    }

    public void Populateddlstatus()
    {
        db1.strCommand = "select Usertype from LoginTb";
        DataTable dt_status = db1.selecttable();
        ddlStatus.Items.Clear();
        if (dt_status.Rows.Count > 0)
        {
            ddlStatus.DataSource = dt_status;
            ddlStatus.DataValueField ="Usertype";
            ddlStatus.DataBind();
        }
        ddlStatus.Items.Insert(0, "--select Usertype--");
    }
    public void PopulateHospitalInfo()
    {
        try
        {
            db1.strCommand = "select LoginTb.LoginID,Username,Password,Usertype,HospitalName,Address from LoginTb "+
                "inner join Hospital on LoginTb.LoginID=Hospital.LoginID where LoginTb.Usertype='"+ddlStatus.SelectedValue+"'";
            DataTable dt_grid = db1.selecttable();
            if (dt_grid.Rows.Count > 0)
            {
                CustomersGridView.DataSource = dt_grid;
                CustomersGridView.DataBind();
            }
          
        }
        catch
        {
            throw;
        }
    }

    public void PopulateExecutiveInfo()
    {
        try
        {
            db1.strCommand = "select LoginID,Username,Password,Usertype from LoginTb where Usertype='"+ddlStatus.SelectedValue+"'";
            DataTable dt = db1.selecttable();
            if (dt.Rows.Count > 0)
            {
                exegrid.DataSource = dt;
                exegrid.DataBind();
            }
        }
        catch
        {
            throw;
        }
    }
    public void PopulateissueofficerInfo()
    {
        try
        {
            db1.strCommand = "select LoginID,Username,Password,Usertype from LoginTb where Usertype='" + ddlStatus.SelectedValue + "'";
            DataTable dt = db1.selecttable();
            if (dt.Rows.Count > 0)
            {
                exegrid.DataSource = dt;
                exegrid.DataBind();
            }
        }
        catch
        {
            throw;
        }
    }
    public void PopulateCalibengrInfo()
    {
        try
        {
            db1.strCommand = "select LoginID,Username,Password,Usertype from LoginTb where Usertype='" + ddlStatus.SelectedValue + "'";
            DataTable dt = db1.selecttable();
            if (dt.Rows.Count > 0)
            {
                exegrid.DataSource = dt;
                exegrid.DataBind();
            }
        }
        catch
        {
            throw;
        }
    }

    //Dropdownlist for search button to find the details based on Usertype.
    protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlStatus.SelectedValue == "1")
        {
            exegrid.Visible = true;
            CustomersGridView.Visible = false;
            PopulateExecutiveInfo();
        }
        if (ddlStatus.SelectedValue == "3")
        {
            exegrid.Visible = true;
            CustomersGridView.Visible = false;
            PopulateCalibengrInfo();
        }
        if (ddlStatus.SelectedValue == "4")
        {
            exegrid.Visible = true;
            CustomersGridView.Visible = false;
            PopulateissueofficerInfo();
        }
        if (ddlStatus.SelectedValue == "2")
        {
            CustomersGridView.Visible = true;
            exegrid.Visible = false;
            PopulateHospitalInfo();
        }
    }


   
    protected void CustomersGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        logidgrid_hidden.Value = (CustomersGridView.DataKeys[e.RowIndex].Values["LoginID"].ToString());
        string qry = "delete  from Hospital where LoginID='" + logidgrid_hidden.Value + "'";
        int i = db1.executeQuery(qry);

        db1.strCommand = "delete  from LoginTb where LoginID='" + logidgrid_hidden.Value + "'";
        db1.insertqry();

        PopulateHospitalInfo();
    }
    
    protected void lbedit_Click(object sender, ImageClickEventArgs e)
    {
        GridViewRow gvrow = (GridViewRow)((ImageButton)sender).NamingContainer;
        logidgrid_hidden.Value = (CustomersGridView.DataKeys[gvrow.RowIndex].Values["LoginID"].ToString());
        btnsave.Text = "Update";

        db1.strCommand = "select Username,Password,Usertype,HospitalName,Address from LoginTb inner join Hospital on LoginTb.LoginID=Hospital.LoginID where LoginTb.LoginID='" + logidgrid_hidden.Value + "'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            txtusername.Text = dt.Rows[0]["Username"].ToString();
            txtname.Text = dt.Rows[0]["HospitalName"].ToString();
            txtaddress.Text = dt.Rows[0]["Address"].ToString();
            txtpswd.Text = dt.Rows[0]["Password"].ToString();

        }
    }
    protected void CustomersGridView_RowEditing(object sender, GridViewEditEventArgs e)
    {
       
    }
    protected void exegrid_RowEditing(object sender, GridViewEditEventArgs e)
    {
       
    }
    protected void exegrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        logidgrid_hidden.Value = (exegrid.DataKeys[e.RowIndex].Values["LoginID"].ToString());
        
        db1.strCommand = "delete  from LoginTb where LoginID='" + logidgrid_hidden.Value + "'";
        db1.insertqry();

        PopulateExecutiveInfo();
    }
    protected void exegrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        exegrid.PageIndex = e.NewPageIndex;
        PopulateExecutiveInfo();
    }
    protected void lbedit_Click1(object sender, ImageClickEventArgs e)
    {
        GridViewRow gvrow = (GridViewRow)((ImageButton)sender).NamingContainer;
        logidgrid_hidden.Value = (exegrid.DataKeys[gvrow.RowIndex].Values["LoginID"].ToString());
        btnsave.Text = "Update";
        db1.strCommand = "select LoginID,Username,Password,Usertype from LoginTb where LoginID='" + logidgrid_hidden.Value + "'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            txtusername.Text = dt.Rows[0]["Username"].ToString();
            drpusertype.SelectedValue = dt.Rows[0]["Usertype"].ToString();
            if (dt.Rows[0]["Usertype"].ToString() == "1")
            {
                drpusertype.SelectedItem.Text = "Executive";
            }
            else if (dt.Rows[0]["Usertype"].ToString() == "3")
            {
                drpusertype.SelectedItem.Text = "Calibration Engr";
            }
            else if (dt.Rows[0]["Usertype"].ToString() == "4")
            {
                drpusertype.SelectedItem.Text = "Issuing Officer";
            }
            
            txtpswd.Text = dt.Rows[0]["Password"].ToString();
            if (drpusertype.SelectedValue == "1")
            {
                hospaddress.Visible = false;
                hospname.Visible = false;
            }
            if (drpusertype.SelectedValue == "3")
            {
                hospaddress.Visible = false;
                hospname.Visible = false;
            }
            if (drpusertype.SelectedValue == "4")
            {
                hospaddress.Visible = false;
                hospname.Visible = false;
            }

        }
    }
}