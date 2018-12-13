<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="test_Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:DropDownList ID="ddlTextBoxes" runat="server">
    <asp:ListItem Value="1" Text="1" />
    <asp:ListItem Value="5" Text="5" />
</asp:DropDownList>
<asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" /><br />
<asp:PlaceHolder ID="container" runat="server" Visible="false">
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
</asp:PlaceHolder>
    </div>
    </form>
</body>
</html>
