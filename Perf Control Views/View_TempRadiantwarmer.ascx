<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_TempRadiantwarmer.ascx.cs" Inherits="Perf_Control_Views_View_TempRadiantwarmer" %>

<%--perf Temp measure fluid warmer  div starts--%>
        <div id="radiantwarmerdiv" runat="server">
            <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label41" runat="server"  Width="30px"></asp:Label>
                <asp:Label ID="lblradiant" runat="server"></asp:Label></h4>
         </div>
            <div class="clear"></div>
            <div class="align_middle" style="font-weight:bold;width:6.27in;">
                <table border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
                    <tr>
        <th rowspan="2">Sl No</th>
            <th rowspan="2">Temp set on DUT</th>
            <th rowspan="2">Temp Displayed on DUT</th>
            <th rowspan="2">Temp Measured on STD</th>
            <th colspan="2">Deviation</th>
            <th>Specified limit as per Mfr. Spec.</th>
            <th rowspan="2">Remarks</th>
    </tr>
     <tr>
            <th>w.r.t Temp set on DUT</th>
            <th>w.r.t Temp Display on DUT</th>
           <th>Display</th>
        </tr>
                    <tr id="tr_tempradiant1" runat="server">
        <td>
            <asp:Label ID="lbltemp_radiant1" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_radiant2" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_radiant3" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_radiant4" runat="server"></asp:Label></td>
        <td>
           <asp:Label ID="lbltemp_radiant5" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_radiant6" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_radiant7" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_radiant8" runat="server"></asp:Label>
        </td>
       
    </tr>
                     <tr id="tr_tempradiant2" runat="server">
        <td>
            <asp:Label ID="lbltemp_radiant9" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_radiant10" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbltemp_radiant11" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_radiant12" runat="server"></asp:Label></td>
        <td>
           <asp:Label ID="lbltemp_radiant13" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_radiant14" runat="server"></asp:Label></td>
        <td>
            <asp:Label ID="lbltemp_radiant15" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label ID="lbltemp_radiant16" runat="server"></asp:Label>
        </td>
        
    </tr>
                </table>
                </div>
            </div>