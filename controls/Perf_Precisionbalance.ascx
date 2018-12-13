<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Perf_Precisionbalance.ascx.cs" Inherits="controls_Perf_Precisionbalance" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>
<asp:HiddenField ID="precision_hidden" runat="server" />
<h3>Performance Analysis of Precision Balance</h3>

<table style="width:100%;" border="1">
    <tr>
        <th>Sl No</th>
        <th>Standard Weight (STD) in Grams</th>
        <th>DUT Under Comparison in Grams</th>
        <th>Deviation</th>
        <th>Specified Limit as per Mfr’s Spec</th>
        <th>Remarks</th>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstd1" runat="server" CssClass="textbox" Text="20"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtdev1" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec1" runat="server" CssClass="textbox" Text="± .05g"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstd2" runat="server" CssClass="textbox" Text="50"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut2" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtdev2" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec2" runat="server" CssClass="textbox" Text="± .05g"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtsl3" runat="server" CssClass="textbox" Text="3"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstd3" runat="server" CssClass="textbox" Text="100"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut3" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtdev3" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec3" runat="server" CssClass="textbox" Text="± .05g"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem3" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtsl4" runat="server" CssClass="textbox" Text="4"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstd4" runat="server" CssClass="textbox" Text="150"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut4" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtdev4" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec4" runat="server" CssClass="textbox" Text="± .05g"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem4" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td><asp:TextBox ID="txtsl5" runat="server" CssClass="textbox" Text="5"></asp:TextBox></td>
        <td><asp:TextBox ID="txtstd5" runat="server" CssClass="textbox" Text="200"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdut5" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtdev5" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec5" runat="server" CssClass="textbox" Text="± .05g"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem5" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox>
            </td>
    </tr>
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>