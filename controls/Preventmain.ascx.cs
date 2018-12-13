using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class controls_Preventmain : System.Web.UI.UserControl
{
    Dbclass db = new Dbclass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            btnsave.Text = "Save";
            if (MultiView1.ActiveViewIndex == 0)
            {
                BindHospitalDetails();
                BindPrevention();
                btnviewtest.Text = "Add Preventive Maintenance";
            }
        }
    }
    protected void btnviewtest_Click(object sender, EventArgs e)
    {
        if (MultiView1.ActiveViewIndex == 0)
        {
            MultiView1.ActiveViewIndex = 1;
            BindCalibrationTest();
            btnviewtest.Text = "View Preventive Maintenance";
        }
        else if (MultiView1.ActiveViewIndex == 1)
        {
            MultiView1.ActiveViewIndex = 0;
            BindHospitalDetails();
            BindPrevention();
            btnviewtest.Text = "Add Preventive Maintenance";
        }
    }

    #region Methods

    public void BindHospitalDetails()
    {
        string username = Page.User.Identity.Name;
        db.strCommand = "select h.HospitalName,h.Address,h.HospitalID from LoginTb l inner join Hospital h  on l.LoginID=h.LoginID "+
                        " where l.Username='" + username + "'";
        DataTable dt= db.selecttable();
        if (dt.Rows.Count > 0)
        {
            lblHospitalName.Text = dt.Rows[0]["HospitalName"].ToString();
            lblAddress.Text = dt.Rows[0]["Address"].ToString();
            hospitalidhidden.Value = dt.Rows[0]["HospitalID"].ToString();
        }
    }

    public void BindCalibrationTest()
    {
        db.strCommand = "Select * from AddCalibrationTest where HospitalID='"+hospitalidhidden.Value+"' and ActiveStatus=1";
        DataTable dt = db.selecttable();
        if (dt.Rows.Count > 0)
        {
            chktest.DataSource = dt;
            chktest.DataTextField = "TestName";
            chktest.DataValueField = "TestID";
            chktest.DataBind();
        }
    }

    public void InsertPreMaintenance()
    {
        string productname="",Manufacture="",Model="",Devicetype="",Deviceclassi="",supply="",power="",serialno="",biomedicalid="",
               location="",description="";
        productname = txtproname.Text.Trim();
        Manufacture = txtmanufact.Text.Trim();
        Model = txtModel.Text.Trim();
        Devicetype = txtdevicetype.Text.Trim();
        Deviceclassi = txtdeviceclass.Text.Trim();
        supply = txtsupply.Text.Trim();
        power = txtpower.Text.Trim();
        serialno = txtserialno.Text.Trim();
        biomedicalid = txtbiomedical.Text.Trim();
        location = txtlocation.Text.Trim();
        description = txtdescrption.Text.Trim();
        string query = "Insert into Prevention(ProductName,Manufacture,Model,DeviceType,DeviceClassi,Supply,Power,Serial_No," +
                      "BiomedicalID,Location,Description,HospitalID) values('" + productname + "','" + Manufacture + "','" + Model + "','" + Devicetype + "'," +
                      "'" + Deviceclassi + "','" + supply + "','" + power + "','" + serialno + "','" + biomedicalid + "','" + location + "','" + description + "','" + hospitalidhidden.Value + "')";
        int s=db.executeQuery(query);
        if (s > 0)
        {
            int preventid = 0;
            db.strCommand = "Select max(PreventID) as PreventID from Prevention where ActiveStatus=1";
            DataTable dt = db.selecttable();
            if (dt.Rows.Count > 0)
            {
                preventid = Convert.ToInt32(dt.Rows[0]["PreventID"]);
            }
            for (int i = 0; i < chktest.Items.Count; i++)
            {
                if (chktest.Items[i].Selected == true)
                {
                    int testid = Convert.ToInt32(chktest.Items[i].Value);
                    string qry = "Insert into Prevent_Join_Calibration(PreventID,TestID,ActiveStatus) values('"+preventid+"','"+testid+"',1)";
                    db.executeQuery(qry);
                }
            }
        }
        else
        {
            lblMsg.Text = "Insertion Failed";
        }
        
    }

    public void UpdatePrevention(int preventid)
    {
        try
        {
            string productname = "", Manufacture = "", Model = "", Devicetype = "", Deviceclassi = "", supply = "", power = "", serialno = "", biomedicalid = "",
               location = "", description = "";
            productname = txtproname.Text.Trim();
            Manufacture = txtmanufact.Text.Trim();
            Model = txtModel.Text.Trim();
            Devicetype = txtdevicetype.Text.Trim();
            Deviceclassi = txtdeviceclass.Text.Trim();
            supply = txtsupply.Text.Trim();
            power = txtpower.Text.Trim();
            serialno = txtserialno.Text.Trim();
            biomedicalid = txtbiomedical.Text.Trim();
            location = txtlocation.Text.Trim();
            description = txtdescrption.Text.Trim();
            string str = "Update Prevention set ProductName='" + productname + "'," +
                         "Manufacture='" + Manufacture + "',Model='" + Model + "',DeviceType='" + Devicetype + "'," +
                         "DeviceClassi='" + Deviceclassi + "',Supply='" + supply + "',Power='" + power + "'," +
                         "Serial_No='" + serialno + "',BiomedicalID='" + biomedicalid + "',Location='" + location + "'," +
                         "Description='" + description + "' where PreventID='" + preventid + "' and ActiveStatus=1";
            int s = db.executeQuery(str);
            if (s > 0)
            {
                string s1 = "Delete from Prevent_Join_Calibration where PreventID='" + preventid + "' and ActiveStatus=1";
                int d = db.executeQuery(s1);
                if (d > 0)
                {
                    for (int i = 0; i < chktest.Items.Count; i++)
                    {
                        if (chktest.Items[i].Selected == true)
                        {
                            int testid = Convert.ToInt32(chktest.Items[i].Value);
                            string qry = "Insert into Prevent_Join_Calibration(PreventID,TestID,ActiveStatus) values('" + preventid + "','" + testid + "',1)";
                            db.executeQuery(qry);
                        }
                    }
                }
            }
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }

    public void Clear()
    {
        txtproname.Text = "";
        txtmanufact.Text = "";
        txtModel.Text = "";
        txtdevicetype.Text = "";
        txtdeviceclass.Text = "";
        txtsupply.Text = "";
        txtpower.Text = "";
        txtserialno.Text = "";
        txtbiomedical.Text = "";
        txtlocation.Text = "";
        txtdescrption.Text = "";
        BindCalibrationTest();
        btnsave.Text = "Save";
        lblMsg.Text = "";
    }

    public void BindPrevention()
    {
        if (!string.IsNullOrEmpty(hospitalidhidden.Value))
        {
            db.strCommand = "Select * from Prevention where HospitalID='" + hospitalidhidden.Value + "' and ActiveStatus=1";
            DataTable dt = db.selecttable();
            grdPrevention.DataSource = dt;
            grdPrevention.DataBind();
        }
        
    }

    #endregion
    
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (btnsave.Text == "Save")
        {
            InsertPreMaintenance();
            //MultiView1.ActiveViewIndex = 0;
            Clear();
            lblMsg.Text = "Inserted Successfully";
            lblMsg.Style.Add("color", "Green");
        }
        else if (btnsave.Text == "Update")
        {
            int preventid = Convert.ToInt32(Session["preventid"].ToString());
            UpdatePrevention(preventid);
            Clear();
            btnsave.Text = "Save";
            lblMsg.Text = "Updated Successfully";
            lblMsg.Style.Add("color", "Green");
        }
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Prevent.aspx");
    }
    protected void grdPrevention_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "U")
        {
            int preventid = Convert.ToInt32(e.CommandArgument.ToString());
            
            MultiView1.ActiveViewIndex = 1;
            btnsave.Text = "Update";
            BindHospitalDetails();
            BindCalibrationTest();
            db.strCommand = "Select * from Prevention where PreventID='" + preventid + "'";
            DataTable dt = db.selecttable();
            if (dt.Rows.Count > 0)
            {
                txtproname.Text = dt.Rows[0]["ProductName"].ToString();
                txtmanufact.Text = dt.Rows[0]["Manufacture"].ToString();
                txtModel.Text = dt.Rows[0]["Model"].ToString();
                txtdevicetype.Text = dt.Rows[0]["DeviceType"].ToString();
                txtdeviceclass.Text = dt.Rows[0]["DeviceClassi"].ToString();
                txtpower.Text = dt.Rows[0]["Power"].ToString();
                txtsupply.Text = dt.Rows[0]["Supply"].ToString();
                txtserialno.Text = dt.Rows[0]["Serial_No"].ToString();
                txtbiomedical.Text = dt.Rows[0]["BiomedicalID"].ToString();
                txtdescrption.Text = dt.Rows[0]["Description"].ToString();
                txtlocation.Text = dt.Rows[0]["Location"].ToString();

                db.strCommand = "Select TestID from Prevent_Join_Calibration where PreventID='" + preventid + "' and ActiveStatus=1";
                DataTable dt_p = db.selecttable();
                if (dt_p.Rows.Count > 0)
                {
                    try
                    {
                        for (int i = 0; i < dt_p.Rows.Count; i++)
                        {

                            for (int j = 0; j < chktest.Items.Count; j++)
                            {
                                if (chktest.Items[j].Value == dt_p.Rows[i]["TestID"].ToString())
                                {
                                    chktest.Items[j].Selected = true;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    
                }
                
            }
            Session["preventid"] = preventid.ToString();
        }
        else if (e.CommandName == "D")
        {
            int preventid = Convert.ToInt32(e.CommandArgument.ToString());
            string str = "Update Prevention set ActiveStatus=0 where PreventID='" + preventid + "'";
            int i = db.executeQuery(str);
            if (i > 0)
            {
                string qry = "Update Prevent_Join_Calibration set ActiveStatus=0 where PreventID='" + preventid + "'";
                db.executeQuery(qry);
            }
            BindPrevention();
        }
    }
    protected void grdPrevention_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            ListBox lstcalibration = (ListBox)e.Row.FindControl("lstcalibration");
            HiddenField HiddenFieldPreventID = (HiddenField)e.Row.FindControl("HiddenFieldPreventID");
            int preventid = Convert.ToInt32(HiddenFieldPreventID.Value);
            db.strCommand = "Select ct.TestID,ct.TestName from AddCalibrationTest ct inner join Prevent_Join_Calibration pjc on " +
                       " ct.TestID=pjc.TestID where pjc.PreventID='" + preventid + "' and ct.ActiveStatus=1";
            DataTable dt = db.selecttable();
            lstcalibration.DataSource = dt;
            lstcalibration.DataTextField = "TestName";
            lstcalibration.DataValueField = "TestID";
            lstcalibration.DataBind();
        }
    }
    protected void grdPrevention_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdPrevention.PageIndex = e.NewPageIndex;
        BindPrevention();
    }
}