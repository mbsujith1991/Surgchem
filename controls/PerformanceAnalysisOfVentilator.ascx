<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PerformanceAnalysisOfVentilator.ascx.cs" Inherits="PerformanceAnalysisOfVentilator" %>
<style type="text/css">
    .textbox {
        width:100%;
    }
</style>

<asp:HiddenField ID="perf_ventilator" runat="server" />
<h3>PERFORMANCE ANALYSIS OF VENTILATOR</h3>

<table style="width:100%;" border="1">
    <tr>
        <th>Sl No.</th>
        <th>Parameter Range</th>
        <th>Value as Set on DUT</th>
        <th>Average Value as on STD</th>
        <th>Deviation</th>
        <th>Allowed Deviation</th>
        <th>Remarks</th>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtslno1" runat="server" Text="1" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtpara1" runat="server" Text="Breath rate (IE)" CssClass="textbox"></asp:TextBox>
        </td>

        <td>
            <asp:TextBox ID="txtdut1" runat="server" Text="15" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd1" runat="server" Text="15" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev1" runat="server" Text="0" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev1" runat="server" Text="± 1BPM" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem1" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtslno2" runat="server" Text="2" CssClass="textbox" ></asp:TextBox>
        </td>
          <td>
            <asp:TextBox ID="txtpara2" runat="server" Text="Breath rate (IE)" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdut2" runat="server" Text="20" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd2" runat="server" Text="20" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev2" runat="server" Text="0" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev2" runat="server" Text="± 1BPM" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem2" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtslno3" runat="server" Text="3" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtpara3" runat="server" Text="I:E Ratio (IE)" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdut3" runat="server" Text="1:1.5" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd3" runat="server" Text="1:1.5" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev3" runat="server" Text="0:0" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev3" runat="server" Text="± 0.5" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem3" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
      <tr>
          <td>
            <asp:TextBox ID="txtslno4" runat="server" Text="4" CssClass="textbox"></asp:TextBox>
        </td>
         <td>
            <asp:TextBox ID="txtpara4" runat="server" Text="I:E Ratio (IE)" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdut4" runat="server" Text="2:1" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd4" runat="server" Text="2:1" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev4" runat="server" Text="0" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev4" runat="server" Text="± 0.5" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem4" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
  <tr>
      <td>
            <asp:TextBox ID="txtslno5" runat="server" Text="5" CssClass="textbox"></asp:TextBox>
        </td>
       <td>
            <asp:TextBox ID="txtpara5" runat="server" Text="Tidal Volume (TVe) in ml" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdut5" runat="server" Text="400" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd5" runat="server" Text="407" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev5" runat="server" Text="7" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev5" runat="server" Text="± 10%" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem5" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
  <tr>
              <td>
            <asp:TextBox ID="txtslno6" runat="server" Text="6" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtpara6" runat="server" Text="Minute volume (MVe) in ml" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdut6" runat="server" Text="5.3" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd6" runat="server" Text="5.4" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev6" runat="server" Text="0.1" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev6" runat="server" Text="± 10%" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem6" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
  <tr>
      <td>
            <asp:TextBox ID="txtslno7" runat="server" Text="7" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtpara7" runat="server" Text="Positive End Expiratory Pressure in cm H2O" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdut7" runat="server" Text="5" CssClass="textbox" ></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd7" runat="server" Text="5" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev7" runat="server" Text="0" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev7" runat="server" Text="± 2 cm H2O" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem7" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
  <tr>
      <td>
            <asp:TextBox ID="txtslno8" runat="server" Text="8" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtpara8" runat="server" Text="Positive End Expiratory Pressure in cm H2O" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdut8" runat="server" Text="3" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd8" runat="server" Text="3" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev8" runat="server" Text="0" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev8" runat="server" Text="± 2 cm H2O" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem8" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
  <tr>
      <td>
            <asp:TextBox ID="txtslno9" runat="server" Text="9" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtpara9" runat="server" Text="PIP IN PRESURE CONTROL MODE" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdut9" runat="server" Text="20" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd9" runat="server" Text="20" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev9" runat="server" Text="0" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev9" runat="server" Text="± 2 cm H2O" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem9" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>
     <tr>
      <td>
            <asp:TextBox ID="txtslno10" runat="server" Text="10" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtpara10" runat="server" Text="Plateau pressure in volume mode" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdut10" runat="server" Text="17" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtavgstd10" runat="server" Text="17" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtdev10" runat="server" Text="0" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtalodev10" runat="server" Text="± 2 cm H2O" CssClass="textbox"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtrem10" runat="server" Text="Pass" CssClass="textbox"></asp:TextBox>
        </td>
    </tr>

</table>
<br />
<div>
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="button-link"/>&nbsp;
    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="button-link"/>
</div>


