<%@ Page Language="C#" AutoEventWireup="true" CodeFile="excel_db.aspx.cs" Inherits="test_excel_db" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" /><asp:Button ID="btnupload" runat="server" Text="Upload" OnClick="btnupload_Click" />
    </div>
    </form>
</body>
</html>
