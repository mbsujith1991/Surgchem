<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_amplitudeHolter.ascx.cs" Inherits="Perf_Control_Views_View_amplitudeHolter" %>

<%--ampli Holtermachine  div starts--%>
        <div id="amplitudeholterdiv" runat="server">
            <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label41" runat="server"  Width="30px"></asp:Label>
                <asp:Label ID="lblamplitudeholter" runat="server"></asp:Label></h4>
         </div>
            <div class="clear"></div>
            <div class="align_middle" style="font-weight:bold;width:6.27in;">
                <table border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
                    <tr>
        <th>Sl No</th>
        <th>Parameter</th>
        <th colspan="2">Value set on STD </th>
        <th>Value measured on DUT (mm)</th>
        <th>Specified limit as per mfr. Specification(+/-5%)</th>
        <th>Remarks</th>
    </tr>
                      <tr id="tr_ampliholter1" runat="server">
                   <td>
                       <asp:Label ID="lblampliholter1" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblampliholter2" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblampliholter3" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblampliholter4" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblampliholter5" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblampliholter6" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblampliholter7" runat="server" Text=""></asp:Label>
                   </td>
               </tr>

                </table>
                </div>
            </div>