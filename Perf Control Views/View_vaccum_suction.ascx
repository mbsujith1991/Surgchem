<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_vaccum_suction.ascx.cs" Inherits="Perf_Control_Views_View_vaccum_suction" %>

<div id="vaccumdiv" runat="server">
         <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label34" runat="server" Text="" Width="30px"></asp:Label>
                <asp:Label ID="lblvaccum" runat="server"></asp:Label></h4>
         </div>
    <div class="clear"></div>
       <div class="align_middle" style="font-weight:bold;width:6.27in;">
           <table  border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
                <tr>
        <th>Sl No</th>
        <th>Value Set on DUT (mmHg)</th>
        <th>Average Value as on STD (mmHg)</th>
        <th>Deviation</th>
        <th>Allowed Deviation</th>
        <th>Remarks</th>
    </tr>
                <tr id="tr_vaccum1" runat="server">
                         <td><asp:Label ID="lblvaccum1" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblvaccum2" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblvaccum3" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblvaccum4" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblvaccum5" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblvaccum6" runat="server"></asp:Label></td>
                     </tr>
                     <tr id="tr_vaccum2" runat="server">
                         <td><asp:Label ID="lblvaccum7" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblvaccum8" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblvaccum9" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblvaccum10" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblvaccum11" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblvaccum12" runat="server"></asp:Label></td>
                     </tr>
                     <tr id="tr_vaccum3" runat="server">
                         <td><asp:Label ID="lblvaccum13" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblvaccum14" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblvaccum15" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblvaccum16" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblvaccum17" runat="server"></asp:Label></td>
                         <td><asp:Label ID="lblvaccum18" runat="server"></asp:Label></td>
                     </tr>
           </table>
           </div>
    </div>
