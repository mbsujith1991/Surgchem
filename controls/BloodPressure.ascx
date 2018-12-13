<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BloodPressure.ascx.cs" Inherits="testfolder_BloodPressure" %>

<style type="text/css">
    .textbox {
        width: 100%;
    }
</style>

<asp:HiddenField ID="bloodpressure_hidden" runat="server" />
<h3>Blood Pressure</h3>


    <table  border="1" style="width:100%;">
        <tr>
            <th>Sl No</th>
    <th colspan="3">Reading set on std(mmHg)</th>
    <th colspan="3">Reading measured on  DUT(mmHg)</th>
    <th colspan="3" width="25%">Deviation(bpm)</th>
    <th colspan="3">Specified limit as per mfr specification (mm.Hg) </th>
    <th rowspan="2">Remarks</th>
        </tr>
        <tr>
            <th>
                Test
            </th>
            <th>Syst</th>
            <th>Dyst</th>
            <th>MAP</th>
            <th>Syst</th>
            <th>Dyst</th>
            <th>MAP</th>
            <th>Syst</th>
            <th>Dyst</th>
            <th>MAP</th>
            <th>Syst</th>
            <th>Dyst</th>
            <th>MAP</th>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
            <td><asp:TextBox ID="txtstdsyst1" runat="server" CssClass="textbox" Text="120"></asp:TextBox></td>
            <td><asp:TextBox ID="txtstddyst1" runat="server" CssClass="textbox" Text="80"></asp:TextBox></td>
            <td><asp:TextBox ID="txtstdmap1" runat="server" CssClass="textbox" Text="90"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdutsyst1" runat="server" CssClass="textbox" Text="121"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdutdyst1" runat="server" CssClass="textbox" Text="82"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdutmap1" runat="server" CssClass="textbox" Text="88"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdevsyst1" runat="server" CssClass="textbox" Text="1"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdevdyst1" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdevmap1" runat="server" CssClass="textbox" Text="-2"></asp:TextBox></td>
            <td><asp:TextBox ID="txtspecsyst1" runat="server" CssClass="textbox" Text="±5"></asp:TextBox></td>
            <td><asp:TextBox ID="txtspecdyst1" runat="server" CssClass="textbox" Text="±5"></asp:TextBox></td>
            <td><asp:TextBox ID="txtspecmap1" runat="server" CssClass="textbox" Text="±5"></asp:TextBox></td>
            <td><asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="2"></asp:TextBox></td>
            <td><asp:TextBox ID="txtstdsyst2" runat="server" CssClass="textbox" Text="150"></asp:TextBox></td>
            <td><asp:TextBox ID="txtstddyst2" runat="server" CssClass="textbox" Text="100"></asp:TextBox></td>
            <td><asp:TextBox ID="txtstdmap2" runat="server" CssClass="textbox" Text="115"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdutsyst2" runat="server" CssClass="textbox" Text="148"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdutdyst2" runat="server" CssClass="textbox" Text="98"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdutmap2" runat="server" CssClass="textbox" Text="112"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdevsyst2" runat="server" CssClass="textbox" Text="-2"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdevdyst2" runat="server" CssClass="textbox" Text="-2"></asp:TextBox></td>
            <td><asp:TextBox ID="txtdevmap2" runat="server" CssClass="textbox" Text="-3"></asp:TextBox></td>
            <td><asp:TextBox ID="txtspecsyst2" runat="server" CssClass="textbox" Text="±5"></asp:TextBox></td>
            <td><asp:TextBox ID="txtspecdyst2" runat="server" CssClass="textbox" Text="±5"></asp:TextBox></td>
            <td><asp:TextBox ID="txtspecmap2" runat="server" CssClass="textbox" Text="±5"></asp:TextBox></td>
            <td><asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
        </tr>
    </table>
<br />
  <div>
      <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click1" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click1" CssClass="button-link"/>
</div>