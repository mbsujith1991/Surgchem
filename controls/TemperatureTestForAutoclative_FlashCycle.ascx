<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TemperatureTestForAutoclative_FlashCycle.ascx.cs" Inherits="TemperatureTestForAutoclative_FlashCycle" %>
<style type="text/css">
  
    .textbox {
        width: 100%;
    }
</style>

<asp:HiddenField ID="temp_autoflash_hidden" runat="server" />
<h3>Temperature Test For Autoclave(Flash Cycle)</h3>

<table style="width:100%;" border="1">
    <tr>
        <th rowspan="2">Sl No</th>
        <th rowspan="2">Temp Display on DUT ºC</th>
        <th colspan="5">Temperature measured on STD specific Test Points(TPs)</th>
        <th rowspan="2">Mean Value</th>
        <th rowspan="2">Deviation</th>
        <th rowspan="2">Specified Limit as per Mfr. Spec.</th>
        <th rowspan="2">Remarks</th>
    </tr>
      <tr>
        <th>TP1</th>
        <th>TP2</th>
        <th>TP3</th>
        <th>TP4</th>
        <th>TP5</th>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl1" runat="server" Text="1" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txttempdut1" runat="server" Text="134.2" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txttp1_1" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txttp2_1" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txttp3_1" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txttp4_1" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txttp5_1" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtmean1" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev1" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtspec1" runat="server" Text="± 3 ºC" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem1" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl2" runat="server" Text="2" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txttempdut2" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txttp1_2" runat="server" Text="" CssClass="textbox"></asp:TextBox>
            </td>
        <td>
            <asp:TextBox ID="txttp2_2" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txttp3_2" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txttp4_2" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txttp5_2" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtmean2" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev2" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtspec2" runat="server" Text="± 3 ºC" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem2" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl3" runat="server" Text="3" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txttempdut3" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txttp1_3" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txttp2_3" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txttp3_3" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txttp4_3" runat="server" Text="" CssClass="textbox"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txttp5_3" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtmean3" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev3" runat="server" Text="" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtspec3" runat="server" Text="± 3 ºC" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem3" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" CssClass="button-link" runat="server" Text="Save" onclick="btnsave_Click"/>&nbsp;
    <asp:Button ID="btncancel" CssClass="button-link" runat="server" Text="Cancel" onclick="btncancel_Click"/>
</div>
