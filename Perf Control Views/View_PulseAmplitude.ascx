<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_PulseAmplitude.ascx.cs" Inherits="Perf_Control_Views_View_PulseAmplitude" %>

<div id="pulseamplitudediv" runat="server">
         <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label34" runat="server" Text="" Width="30px"></asp:Label>
                <asp:Label ID="lblpulseampli" runat="server"></asp:Label></h4>
         </div>
    <div class="clear"></div>
       <div class="align_middle" style="font-weight:bold;width:6.27in;">
           <table  border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
                <tr>
        <th>Sl No</th>
        <th width="20%">Parameter</th>
        <th>Value set on DUT (V)</th>
        <th >Value measured on STD (V)</th>
        <th >Deviation(V)</th>
        <th >Specified limit as per mfr. Specification(+/-5%)</th>
        <th >Remarks</th>
    </tr>
                <tr id="tr_pulseampli1" runat="server">
            <td>
                <asp:Label ID="lblpulseampli1" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulseampli2" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulseampli3" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulseampli4" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulseampli5" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulseampli6" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulseampli7" runat="server" ></asp:Label></td>
        </tr>
                <tr id="tr_pulseampli2" runat="server">
            <td>
                <asp:Label ID="lblpulseampli8" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulseampli9" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulseampli10" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulseampli11" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulseampli12" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulseampli13" runat="server" ></asp:Label></td>
            <td><asp:Label ID="lblpulseampli14" runat="server" ></asp:Label></td>
        </tr>
           </table>
           </div>
    </div>