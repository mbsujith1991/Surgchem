<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FixReportNumberIssue.aspx.cs" Inherits="FixReportNumberIssue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h3>Fix Report Number Issues</h3>
    <div>
        <asp:HiddenField ID="hdnReportId" runat="server" />
        <asp:TextBox ID="txtReportNo" runat="server" Width="200"></asp:TextBox>
        <asp:Button ID="btnGetReportNo" runat="server" Text="Get Report Number" OnClick="btnGetReportNo_Click" />&nbsp;&nbsp;
        <asp:Button ID="btnUpdateReportNumber" runat="server" Text="Update Report Number" OnClick="btnUpdateReportNumber_Click" />
        <br />
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
