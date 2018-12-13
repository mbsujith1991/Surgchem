<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TempMeasure_fluidwarmer.ascx.cs" Inherits="controls_TempMeasure_fluidwarmer" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>

<asp:HiddenField ID="temp_fluidwarmer_hidden" runat="server" />
<h3>Temperature Measurement of Fluid Warmer</h3>

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
            <asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtdut1" runat="server" CssClass="textbox" Text="36.2"></asp:TextBox>
        </td>
        <td><asp:TextBox ID="txttp1_1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txttp2_1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txttp3_1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txttp4_1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txttp5_1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        
        <td><asp:TextBox ID="txtmean1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtdev1" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec1" runat="server" CssClass="textbox" Text="± 0.3 ºC"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
     <tr>
        <td>
            <asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtdut2" runat="server" CssClass="textbox" Text="40"></asp:TextBox>
        </td>
        <td><asp:TextBox ID="txttp1_2" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txttp2_2" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txttp3_2" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txttp4_2" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txttp5_2" runat="server" CssClass="textbox"></asp:TextBox></td>
        
        <td><asp:TextBox ID="txtmean2" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdev2" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec2" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox"></asp:TextBox></td>
    </tr>
     <tr>
        <td>
            <asp:TextBox ID="txtsl3" runat="server" CssClass="textbox" Text="3"></asp:TextBox></td>
        <td>
            <asp:TextBox ID="txtdut3" runat="server" CssClass="textbox" Text="44"></asp:TextBox>
        </td>
        <td><asp:TextBox ID="txttp1_3" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txttp2_3" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txttp3_3" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txttp4_3" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txttp5_3" runat="server" CssClass="textbox"></asp:TextBox></td>
        
        <td><asp:TextBox ID="txtmean3" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtdev3" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtspec3" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td><asp:TextBox ID="txtrem3" runat="server" CssClass="textbox"></asp:TextBox></td>
    </tr>
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link" />
</div>