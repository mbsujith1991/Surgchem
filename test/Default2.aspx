<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="test_Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server" Width="300px">

        </asp:Panel>
        
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
         <asp:Button ID="Button2" runat="server" Text="Save" OnClick="Button2_Click" />
           
    </div>
    </form>
</body>
</html>
