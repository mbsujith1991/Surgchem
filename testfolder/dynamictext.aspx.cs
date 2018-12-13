using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class testfolder_dynamictext : System.Web.UI.Page
{
    int count = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void addnewtext_Click(object sender, EventArgs e)
    {
       
    }
    protected void addControlTB()
    {
        Table tbldynamic = new Table();
        TableCell tc = new TableCell();
        TableRow tr = new TableRow();
        TextBox NewProdTB = new TextBox();
        NewProdTB.EnableViewState = false;
        NewProdTB.ID = "DynamicTextBox";
        NewProdTB.Text = "";
        tc.Controls.Add(NewProdTB);
        tr.Cells.Add(tc);
        tbldynamic.Rows.Add(tr);
        DynamicControlsHolder.Controls.Add(tbldynamic);
    }
    protected void addexProductBTN_Click(object sender, EventArgs e)
    {
        count++;
        addControlTB();
    }
}