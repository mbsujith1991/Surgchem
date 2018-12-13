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

public partial class controls_AddTraceability : System.Web.UI.UserControl
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
        db1.strCommand = "select * from Traceability_Info";
        DataSet ds = db1.selectqry();
        if (ds.Tables[0].Rows.Count > 0)
        {
            GridViewaddtrace.DataSource = ds;
            GridViewaddtrace.DataBind();
        }
        else
        {
            ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
            GridViewaddtrace.DataSource = ds;
            GridViewaddtrace.DataBind();
            int columncount = GridViewaddtrace.Rows[0].Cells.Count;
            GridViewaddtrace.Rows[0].Cells.Clear();
            GridViewaddtrace.Rows[0].Cells.Add(new TableCell());
            GridViewaddtrace.Rows[0].Cells[0].ColumnSpan = columncount;
            GridViewaddtrace.Rows[0].Cells[0].Text = "No Records Found";
        }
    }

    protected void GridViewaddtrace_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridViewaddtrace.EditIndex = -1;
        Gridbind();
    }
    protected void GridViewaddtrace_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridViewaddtrace.EditIndex = e.NewEditIndex;
        Gridbind();
    }

    protected void GridViewaddtrace_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        traceidhidden.Value = (GridViewaddtrace.DataKeys[e.RowIndex].Value.ToString());
        //string username = GridView1.DataKeys[e.RowIndex].Values["UserName"].ToString();
        TextBox txtInstrument = (TextBox)GridViewaddtrace.Rows[e.RowIndex].FindControl("txtInstrument");
        TextBox txtMake = (TextBox)GridViewaddtrace.Rows[e.RowIndex].FindControl("txtMake");
        TextBox txtModel = (TextBox)GridViewaddtrace.Rows[e.RowIndex].FindControl("txtModel");
        TextBox txtSerial_No = (TextBox)GridViewaddtrace.Rows[e.RowIndex].FindControl("txtSerial_No");
        TextBox txttracecall = (TextBox)GridViewaddtrace.Rows[e.RowIndex].FindControl("txttracecall");
        TextBox txtReference = (TextBox)GridViewaddtrace.Rows[e.RowIndex].FindControl("txtReference");

        db1.strCommand = "update Traceability_Info set Instrument='" + txtInstrument.Text.Trim() + "',Make='" + txtMake.Text.Trim() + "'," +
            "Model='" + txtModel.Text.Trim() + "',Serial_No='" + txtSerial_No.Text.Trim() + "',Traceability_call_due='" + txttracecall.Text.Trim() + "',"+
            "Reference='" + txtReference.Text.Trim() + "' where Tracibility_ID='"+Convert.ToInt32(traceidhidden.Value)+"'";

        db1.insertqry();

        lblresult.ForeColor = Color.Green;
        lblresult.Text = " Details Updated successfully";
        GridViewaddtrace.EditIndex = -1;
        Gridbind();
    }

    protected void GridViewaddtrace_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int traceid = Convert.ToInt32(GridViewaddtrace.DataKeys[e.RowIndex].Values["Tracibility_ID"].ToString());
        db1.strCommand = "delete from Traceability_Info where Tracibility_ID=" + traceid;
        db1.insertqry();
        Gridbind();
        lblresult.ForeColor = Color.Red;
        lblresult.Text = " Details deleted successfully";
    }

    protected void GridViewaddtrace_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("AddNew"))
        {
            TextBox txtInstrumentfooter = (TextBox)GridViewaddtrace.FooterRow.FindControl("txtInstrumentfooter");
            TextBox txtMakefooter = (TextBox)GridViewaddtrace.FooterRow.FindControl("txtMakefooter");
            TextBox txtModelfooter = (TextBox)GridViewaddtrace.FooterRow.FindControl("txtModelfooter");
            TextBox txSerial_Nofooter = (TextBox)GridViewaddtrace.FooterRow.FindControl("txSerial_Nofooter");
            TextBox txttracecallfooter = (TextBox)GridViewaddtrace.FooterRow.FindControl("txttracecallfooter");
            TextBox txtReferencefooter = (TextBox)GridViewaddtrace.FooterRow.FindControl("txtReferencefooter");


            db1.strCommand = "insert into Traceability_Info(Instrument,Make,Model,Serial_No,Traceability_call_due,Reference)values " +
                "('" + txtInstrumentfooter.Text.Trim() + "','" + txtMakefooter.Text + "','" + txtModelfooter.Text + "',"+
            "'" + txSerial_Nofooter.Text.Trim()+ "','"+txttracecallfooter.Text.Trim()+"','"+txtReferencefooter.Text.Trim()+"')";
            db1.insertqry();
            Gridbind();
            lblresult.ForeColor = Color.Green;
            lblresult.Text = " Details inserted successfully";
        }
    }
    protected void GridViewaddtrace_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridViewaddtrace.PageIndex = e.NewPageIndex;
        Gridbind();
    }
    protected void GridViewaddtrace_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //getting username from particular row
            string prodname = Convert.ToString(DataBinder.Eval(e.Row.DataItem, "Instrument"));
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