<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_ECGHolter.ascx.cs" Inherits="Perf_Control_Views_View_ECGHolter" %>

<%--perf Holtermachine  div starts--%>
        <div id="ecgholterdiv" runat="server">
            <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label41" runat="server"  Width="30px"></asp:Label>
                <asp:Label ID="lblecgholter" runat="server"></asp:Label></h4>
         </div>
            <div class="clear"></div>
            <div class="align_middle" style="font-weight:bold;width:6.27in;">
                <table border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
                    <tr>
            <td>Sl No</td>
    <td>Parameter</td>
    <td>Value set on STD</td>
    <td>Value measured on DUT</td>
    <td>Deviation(bpm)</td>
    <td>Specified limit as per mfr. Specification(+/-5%)</td>
    <td>Remarks</td>
        </tr>

                     <tr id="tr_ecgholter_1" runat="server">
                   <td>
                       <asp:Label ID="lblecgholter1" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblecgholter2" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblecgholter3" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblecgholter4" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblecgholter5" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblecgholter6" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblecgholter7" runat="server" Text=""></asp:Label>
                   </td>
               </tr>
               <tr id="tr_ecgholter_2" runat="server">
                    <td>
                       <asp:Label ID="lblecgholter8" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblecgholter9" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblecgholter10" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblecgholter11" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblecgholter12" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblecgholter13" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblecgholter14" runat="server" Text=""></asp:Label>
                   </td>
               </tr>
                </table>
                </div>
            </div>