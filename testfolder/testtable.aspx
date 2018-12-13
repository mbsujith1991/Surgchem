<%@ Page Language="C#" AutoEventWireup="true" CodeFile="testtable.aspx.cs" Inherits="testfolder_testtable" %>

<%@ Register Src="~/testfolder/Performancepage.ascx" TagPrefix="uc1" TagName="Performancepage" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    
</head>
<body>
    <form id="form1" runat="server">
    <div class="hovertable">
        <uc1:Performancepage runat="server" ID="Performancepage" />
    </div>
    </form>
</body>
</html>
