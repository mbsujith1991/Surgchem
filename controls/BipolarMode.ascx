<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BipolarMode.ascx.cs" Inherits="BipolarMode" %>
<style type="text/css">
    .perftest table {
        width: 100%;
       
        font-size: 9pt;
    }

    .perftest th, td {
        font-size: 9pt;
    }

    .autowidth {
    }
</style>
<asp:HiddenField ID="BiPolar_mode" runat="server" />
<h3>BiPolar Mode</h3>
<table class="perftest" border="1" style="width:100%;">
    <tr>
        <th width="10%">Mode</th>
        <th width="10%">Value as Set on DUT( W )</th>
        <th width="8%">Standard Load resistance( Ω )</th>
        <th width="8%">Average Value as on STD( W )</th>
        <th width="8%">Deviation in Watts</th>
        <th width="10%">Allowed Deviation ±15%</th>
        <th width="12%">Remarks</th>
    </tr>
    
  <tr>
        <td>
            <asp:TextBox ID="txtmod1" runat="server" Text="Coagulation" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtsetval1" runat="server" Text="100" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtstdres1" runat="server" Text="100" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd1" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev1" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev1" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem1" runat="server" Text="Pass" Width="100%"></asp:TextBox>
        </td>
    </tr>
  <tr>
        <td>
            <asp:TextBox ID="txtmod2" runat="server" Text="Coagulation" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtsetval2" runat="server" Text="75" Width="100%" ></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtstdres2" runat="server" Text="100" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd2" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev2" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev2" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
      <td>
            <asp:TextBox ID="txtrem2" runat="server" Text="Pass" Width="100%"></asp:TextBox>
        </td>
    </tr>
  <tr>
        <td>
            <asp:TextBox ID="txtmod3" runat="server" Text="Coagulation" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtsetval3" runat="server" Text="50" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtstdres3" runat="server" Text="100" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd3" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev3" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev3" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
      <td>
            <asp:TextBox ID="txtrem3" runat="server" Text="Pass" Width="100%"></asp:TextBox>
        </td>
    </tr>
  <tr>
        <td>
            <asp:TextBox ID="txtmod4" runat="server" Text="Coagulation" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtsetval4" runat="server" Text="25" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtstdres4" runat="server" Text="100" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd4" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev4" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev4" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
      <td>
            <asp:TextBox ID="txtrem4" runat="server" Text="Pass" Width="100%"></asp:TextBox>
        </td>
    </tr>

</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>
