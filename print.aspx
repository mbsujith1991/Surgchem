<%@ Page Language="C#" AutoEventWireup="true" CodeFile="print.aspx.cs" Inherits="print" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <div>

            <asp:Button ID="btnPrint" runat="server" Text="Print" OnClick="btnPrint_Click" /><br />

            <asp:Panel ID="pnl1" runat="server">

                <table cellpadding="4" cellspacing="4" width="50%" align="center">

                    <tr>

                        <td align="center">

                            Fill all information

                        </td>

                    </tr>

                    <tr>

                        <td>

                            <asp:Label ID="Label1" runat="server" Text="Email" Width="130px"></asp:Label>

                            <asp:TextBox runat="server"></asp:TextBox>

                        </td>

                    </tr>

                    <tr>

                        <td>

                            <asp:Label ID="Label2" runat="server" Text="Name" Width="130px"></asp:Label>

                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                        </td>

                    </tr>

                    <tr>

                        <td>

                            <asp:Label ID="Label6" runat="server" Text="Country" Width="130px"></asp:Label>

                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

                        </td>

                    </tr>

                    <tr>

                        <td>

                            <asp:Label ID="Label3" runat="server" Text="Mobile" Width="130px"></asp:Label>

                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                        </td>

                    </tr>

                </table>

            </asp:Panel>

        </div>
    </form>
</body>
</html>
