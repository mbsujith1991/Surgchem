<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PerfAnalysis_Anasthesiamachine.ascx.cs" Inherits="controls_PerfAnalysis_Anasthesiamachine" %>

<style type="text/css">
    .textbox {
    width:100%;
    }
</style>
<asp:HiddenField ID="PerformanceAnalysisAnasthesia" runat="server" />
<h3>PERFORMANCE ANALYSIS OF ANASTHESIA MACHINE</h3>
<table style="width:100%;border:1px solid black;">
    <tr>
        <th width="5%">Sl No</th>
        <th width="30%">Parameter Range</th>
        <th>Value as Set on DUT</th>
        <th>Average Value as on STD</th>
        <th>Deviation</th>
        <th>Allowed Deviation</th>
        <th>Remarks</th>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtsl1" runat="server" CssClass="textbox" Text="1"></asp:TextBox>
        </td>
        <td>
             <asp:TextBox ID="txtpara1" runat="server" CssClass="textbox" Text="Breath rate (IE)"></asp:TextBox>
        </td>
        <td>
             <asp:TextBox ID="txtstddut1" runat="server" CssClass="textbox" Text="15"></asp:TextBox>
        </td>
        <td>
             <asp:TextBox ID="txtavgstd1" runat="server" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
             <asp:TextBox ID="txtdev1" runat="server" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
             <asp:TextBox ID="txtalodev1" runat="server" CssClass="textbox" Text="±2%"></asp:TextBox>
        </td>
        <td>
             <asp:TextBox ID="txtrem1" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
             <asp:TextBox ID="txtsl2" runat="server" CssClass="textbox" Text="2"></asp:TextBox>
        </td>
        <td>
             <asp:TextBox ID="txtpara2" runat="server" CssClass="textbox" Text="I:E Ratio (IE)"></asp:TextBox>
        </td>
        <td>
             <asp:TextBox ID="txtstddut2" runat="server" CssClass="textbox" Text="1:2"></asp:TextBox>
        </td>
        <td>
             <asp:TextBox ID="txtavgstd2" runat="server" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
             <asp:TextBox ID="txtdev2" runat="server" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
             <asp:TextBox ID="txtalodev2" runat="server" CssClass="textbox" Text="±2%"></asp:TextBox>
        </td>
        <td>
             <asp:TextBox ID="txtrem2" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td> <asp:TextBox ID="txtsl3" runat="server" CssClass="textbox" Text="3"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtpara3" runat="server" CssClass="textbox" Text="Tidal Volume (TVe) in ml"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtstddut3" runat="server" CssClass="textbox" Text="400"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtavgstd3" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td> <asp:TextBox ID="txtdev3" runat="server" CssClass="textbox" Text=""></asp:TextBox></td>
        <td> <asp:TextBox ID="txtalodev3" runat="server" CssClass="textbox" Text="±5%"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtrem3" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
    <tr>
        <td> <asp:TextBox ID="txtsl4" runat="server" CssClass="textbox" Text="4"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtpara4" runat="server" CssClass="textbox" Text="Minute volume (MVe) in ml"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtstddut4" runat="server" CssClass="textbox" Text="5"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtavgstd4" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtdev4" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtalodev4" runat="server" CssClass="textbox" Text="±5%"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtrem4" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
    <tr>
        <td> <asp:TextBox ID="txtsl5" runat="server" CssClass="textbox" Text="5"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtpara5" runat="server" CssClass="textbox" Text="Positive End Expiratory Pressure in cm H2O"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtstddut5" runat="server" CssClass="textbox" Text="6"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtavgstd5" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtdev5" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtalodev5" runat="server" CssClass="textbox" Text="± 2 cm H2O"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtrem5" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
    <tr>
        <td> <asp:TextBox ID="txtsl6" runat="server" CssClass="textbox" Text="6"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtpara6" runat="server" CssClass="textbox" Text="PIP IN PRESURE CONTROL MODE"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtstddut6" runat="server" CssClass="textbox" Text="20"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtavgstd6" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtdev6" runat="server" CssClass="textbox"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtalodev6" runat="server" CssClass="textbox" Text="± 2 cm H2O"></asp:TextBox></td>
        <td> <asp:TextBox ID="txtrem6" runat="server" CssClass="textbox" Text="Pass"></asp:TextBox></td>
    </tr>
</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>