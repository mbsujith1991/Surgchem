<%@ Page Language="C#" AutoEventWireup="true" CodeFile="print.aspx.cs" Inherits="test_print" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <script type = "text/javascript">
        function PrintPanel() {
            var panel = document.getElementById("<%=pnlContents.ClientID %>");
            var printWindow = window.open('', '', 'height=400,width=800');
            printWindow.document.write('<html><head><title>DIV Contents</title>');
            printWindow.document.write('</head><body >');
            printWindow.document.write(panel.innerHTML);
            printWindow.document.write('</body></html>');
            printWindow.document.close();
            setTimeout(function () {
                printWindow.print();
            }, 500);
            return false;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Panel id="pnlContents" runat = "server">
        <span style="font-size: 10pt; font-weight:bold; font-family: Arial">Hello,
            <br />
            This is <span style="color: #18B5F0">Mudassar Khan</span>.<br />
            Hoping that you are enjoying my articles!</span>
    </asp:Panel>
    <br />
    <asp:Button ID="btnPrint" runat="server" Text="Print" OnClientClick = "return PrintPanel();" />
    </form>
</body>
</html>
