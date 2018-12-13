﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class MultipleTextBox : System.Web.UI.Page
{

    protected void Page_load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //Remove the session when first time page loads.
            Session.Remove("clicks");
        }


    }
  
    protected void Button1_Click(object sender, EventArgs e)
    {
        int rowCount = 0;

        //initialize a session.
        rowCount = Convert.ToInt32(Session["clicks"]);

        rowCount++;

        //In each button clic save the numbers into the session.
        Session["clicks"] = rowCount;


        //Create the textboxes and labels each time the button is clicked.
        for (int i = 0; i < rowCount; i++)
        {

            TextBox TxtBoxU = new TextBox();
            
            TextBox TxtBoxE = new TextBox();

            Label lblU = new Label();
            Label lblE = new Label();

            TxtBoxU.ID = "TextBoxU" + i.ToString();
            TxtBoxE.ID = "TextBoxE" + i.ToString();

            lblU.ID = "LabelU" + i.ToString();
            lblE.ID = "LabelE" + i.ToString();


            lblU.Text = "User " + (i + 1).ToString() + " : ";
            lblE.Text = "E-Mail : ";

            //Add the labels and textboxes to the Panel.
            Panel1.Controls.Add(lblU);
            Panel1.Controls.Add(TxtBoxU);

            Panel1.Controls.Add(lblE);
            Panel1.Controls.Add(TxtBoxE);
            

        }


    }

}