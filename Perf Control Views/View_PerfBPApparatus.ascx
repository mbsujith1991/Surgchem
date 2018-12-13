<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_PerfBPApparatus.ascx.cs" Inherits="Perf_Control_Views_View_PerfBPApparatus" %>

<%--ampli Holtermachine  div starts--%>
        <div id="perfbpapparatusdiv" runat="server">
            <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label41" runat="server"  Width="30px"></asp:Label>
                <asp:Label ID="lblbpapparatus" runat="server"></asp:Label></h4>
         </div>
            <div class="clear"></div>
            <div class="align_middle" style="font-weight:bold;width:6.27in;">
                <table border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
                    <tr>
        <th>Sl No</th>
        <th>Value Set on Device Under Test (DUT) in mmHg</th>
        <th>Readings taken on prosim4 (mmHg)</th>
        <th>Deviation (mmHg)</th>
        <th>Standard Deviation</th>
        <th>Remarks</th>
    </tr>

                     <tr id="tr_perfbpapparatus1" runat="server">
                         <td><asp:Label ID="lblbpapp1" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblbpapp2" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblbpapp3" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblbpapp4" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblbpapp5" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblbpapp6" runat="server"></asp:Label></td>
                     </tr>
                     <tr id="tr_perfbpapparatus2" runat="server">
                         <td><asp:Label ID="lblbpapp7" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblbpapp8" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblbpapp9" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblbpapp10" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblbpapp11" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblbpapp12" runat="server"></asp:Label></td>
                     </tr>
                     <tr id="tr_perfbpapparatus3" runat="server">
                         <td><asp:Label ID="lblbpapp13" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblbpapp14" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblbpapp15" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblbpapp16" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblbpapp17" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblbpapp18" runat="server"></asp:Label></td>
                     </tr>
                </table>
                </div>
            </div>