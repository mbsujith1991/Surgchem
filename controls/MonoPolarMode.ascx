<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MonoPolarMode.ascx.cs" Inherits="MonoPolarMode" %>
<style type="text/css">
    .perftest table {
        width: 100%;
       
    }

    .perftest th, td {
        font-size: 9pt;
    }

    .autowidth {
    }
</style>
<asp:HiddenField ID="MonoPolar_Mode" runat="server" />
<h3>MonoPolar Mode</h3>

<table class="perftest" border="1">
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
            <asp:TextBox ID="txtmod1" runat="server" Text="Cut" Width="100%" Height="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtsetdut1" runat="server" Text="400" Width="100%"></asp:TextBox>
        </td>

        <td>
            <asp:TextBox ID="txtstdres1" runat="server" Text="500" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd1" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev1" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev1" runat="server" Text="60" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem1" runat="server" Text="Pass" Width="100%"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtmod2" runat="server" Text="Cut" Width="100%" Height="100%"></asp:TextBox>
        </td>
          <td>
            <asp:TextBox ID="txtsetdut2" runat="server" Text="300" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtstdres2" runat="server" Text="500" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd2" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev2" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev2" runat="server" Text="45" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem2" runat="server" Text="Pass" Width="100%"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtmod3" runat="server" Text="Cut" Width="100%" Height="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtsetdut3" runat="server" Text="200" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtstdres3" runat="server" Text="500" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd3" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev3" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev3" runat="server" Text="30" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem3" runat="server" Text="Pass" Width="100%"></asp:TextBox>
        </td>
    </tr>
      <tr>
          <td>
              <asp:TextBox ID="txtmod4" runat="server" Text="Cut" Width="100%" Height="100%"></asp:TextBox>
          </td>
         <td>
            <asp:TextBox ID="txtsetdut4" runat="server" Text="100" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtstdres4" runat="server" Text="500" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd4" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev4" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev4" runat="server" Text="15" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem4" runat="server" Text="Pass" Width="100%"></asp:TextBox>
        </td>
    </tr>
  <tr>
      <td>
          <asp:TextBox ID="txtmod5" runat="server" Text="Cut" Width="100%" Height="100%"></asp:TextBox>
      </td>
       <td>
            <asp:TextBox ID="txtsetdut5" runat="server" Text="50" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtstdres5" runat="server" Text="500" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd5" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev5" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev5" runat="server" Text="7.5" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem5" runat="server" Text="Pass" Width="100%"></asp:TextBox>
        </td>
    </tr>
  <tr>
        <td>
            <asp:TextBox ID="txtmod6" runat="server" Text="Coagulation" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtsetdut6" runat="server" Text="100" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtstdres6" runat="server" Text="500" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd6" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev6" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev6" runat="server" Text="15" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem6" runat="server" Text="Pass" Width="100%"></asp:TextBox>
        </td>
    </tr>
  <tr>
      <td>
           <asp:TextBox ID="txtmod7" runat="server" Text="Coagulation" Width="100%"></asp:TextBox>
      </td>
        <td>
            <asp:TextBox ID="txtsetdut7" runat="server" Text="80" Width="100%" ></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtstdres7" runat="server" Text="500" Width="100%" ></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd7" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev7" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev7" runat="server" Text="12" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem7" runat="server" Text="Pass" Width="100%"></asp:TextBox>
        </td>
    </tr>
  <tr>
      <td>
           <asp:TextBox ID="txtmod8" runat="server" Text="Coagulation" Width="100%"></asp:TextBox>
      </td>
        <td>
            <asp:TextBox ID="txtsetdut8" runat="server" Text="50" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtstdres8" runat="server" Text="500" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd8" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev8" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev8" runat="server" Text="7.5" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem8" runat="server" Text="Pass" Width="100%"></asp:TextBox>
        </td>
    </tr>
  <tr>
      <td>
           <asp:TextBox ID="txtmod9" runat="server" Text="Coagulation" Width="100%"></asp:TextBox>
      </td>
        <td>
            <asp:TextBox ID="txtsetdut9" runat="server" Text="20" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtstdres9" runat="server" Text="500" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd9" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev9" runat="server" Text="" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev9" runat="server" Text="3" Width="100%"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem9" runat="server" Text="Pass" Width="100%"></asp:TextBox>
        </td>
    </tr>

</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link" />
</div>
