using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FixReportNumberIssue : System.Web.UI.Page
{
    Dbclass connectionClass = new Dbclass();
    string sqlcon = ConfigurationManager.ConnectionStrings["surgchemcon"].ToString();
    
    private string _reportNo;
    public string ReportNo
    {
        get
        {
            return _reportNo;
        }
        set
        {
            _reportNo = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtReportNo.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

    }

    protected void btnGetReportNo_Click(object sender, EventArgs e)
    {
        try
        {
            connectionClass.strCommand = "Select top 1 * from Report_Info order by Report_info_ID desc";
            var outputDataTable = new DataTable();
            outputDataTable = connectionClass.selecttable();
            if (outputDataTable != null)
            {
                hdnReportId.Value = outputDataTable.Rows[0]["Report_info_ID"].ToString();
                ReportNo = outputDataTable.Rows[0]["ReportNo"].ToString();
                if (!string.IsNullOrEmpty(hdnReportId.Value) && !string.IsNullOrEmpty(ReportNo))
                {
                    txtReportNo.Text = ReportNo;
                    lblMessage.Text = string.Empty;
                }
            }
        }
        catch (Exception ex)
        {
            lblMessage.Text = "Some error Occured \n" + ex.Message;
            lblMessage.ForeColor = System.Drawing.Color.Red;
        }
    }

    protected void btnUpdateReportNumber_Click(object sender, EventArgs e)
    {
        try
        {
            if (!string.IsNullOrEmpty(hdnReportId.Value) && !string.IsNullOrEmpty(txtReportNo.Text))
            {
                connectionClass.strCommand = "Update Report_Info Set ReportNo='" + txtReportNo.Text.Trim() + "',Barcode_ID='" + txtReportNo.Text.Trim() + "' Where Report_info_ID=" + hdnReportId.Value;
                connectionClass.insertqry();
                txtReportNo.Text = string.Empty;
                hdnReportId.Value = string.Empty;
                ReportNo = string.Empty;
                lblMessage.Text = "Report number updated successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
        }
        catch(Exception ex)
        {
            lblMessage.Text = "Some error Occured \n"+ex.Message;
            lblMessage.ForeColor = System.Drawing.Color.Red;
        }
    }
}