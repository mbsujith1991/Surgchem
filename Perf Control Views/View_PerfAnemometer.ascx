<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_PerfAnemometer.ascx.cs" Inherits="Perf_Control_Views_View_PerfAnemometer" %>

<%--Perf Anemometer div starts--%>
        <div id="perf_anemometerdiv" runat="server">
            <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label41" runat="server"  Width="30px"></asp:Label>
                <asp:Label ID="lblperfanemometer" runat="server"></asp:Label></h4>
         </div>
            <div class="clear"></div>
            <div class="align_middle" style="font-weight:bold;width:6.27in;">
                <table border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
                    <tr>
        <th>Sl No</th>
        <th>SET AIR FLOW</th>
        <th>AIR FLOW ON STANDARD TEST EQUIPMENT</th>
        <th>AIR FLOW ON DUT</th>
        <th>DEVIATION+/- 5%</th>
        <th>REMARKS</th>
    </tr>
                     <tr id="tr_anemo1" runat="server">
                   <td>
                       <asp:Label ID="lblanemo1" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblanemo2" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblanemo3" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblanemo4" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblanemo5" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblanemo6" runat="server" Text=""></asp:Label>
                   </td>
                  
               </tr>
                     <tr id="tr_anemo2" runat="server">
                   <td>
                       <asp:Label ID="lblanemo7" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblanemo8" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblanemo9" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblanemo10" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblanemo11" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblanemo12" runat="server" Text=""></asp:Label>
                   </td>
                  
               </tr>
                </table>
                </div>
            </div>