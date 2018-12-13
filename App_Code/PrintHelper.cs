using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Web.SessionState;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Text;
using System.Web.UI;
using System.Web;

/// <summary>
/// Summary description for PrintHelper
/// </summary>
public class PrintHelper
{
	public PrintHelper()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static void PrintWebControl(Control ctrl)
    {
        PrintWebControl(ctrl, string.Empty);
    }
    public static void PrintWebControl(Control ctrl,string script)
    {
        StringWriter stringwrite = new StringWriter();
       System.Web.UI.HtmlTextWriter htmlwrite = new System.Web.UI.HtmlTextWriter(stringwrite);
        if(ctrl is WebControl)
        {
            Unit w = new Unit(100, UnitType.Percentage); ((WebControl)ctrl).Width = w;

        }
        Page pg = new Page();
        if(script!=string.Empty)
        {
            pg.ClientScript.RegisterStartupScript(pg.GetType(), "PrintJavaScript", script);
        }
        HtmlForm htmlform = new HtmlForm();
        pg.Controls.Add(htmlform);
        htmlform.Attributes.Add("runat", "server");
        htmlform.Controls.Add(ctrl);
        //pg.designerinitialize();
        pg.RenderControl(htmlwrite);
        string strhtml = stringwrite.ToString();
        HttpContext.Current.Response.Clear();

        HttpContext.Current.Response.Write(strhtml);

        HttpContext.Current.Response.Write("<script>window.print();</script>");

        HttpContext.Current.Response.End();
    }

}