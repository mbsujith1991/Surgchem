<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MultipleTextBox.aspx.cs" Inherits="MultipleTextBox" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
 
            
        <table style="width: 35%;" id = "mainTable">
            <tr>
                <td>
                   <asp:Panel ID="Panel1" runat="server">
                
                    </asp:Panel>
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                Text="Add Another User" ViewStateMode="Enabled"/>

    
                </td>
                <td>
                    &nbsp;
                                
    
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>


                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>    
    
    

    </form>
</body>
</html>
