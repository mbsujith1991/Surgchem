<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_PerformCpap.ascx.cs" Inherits="Perf_Control_Views_View_PerformCpap" %>

<%--perf cpap div starts--%>
        <div id="cpapdiv" runat="server">
            <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label41" runat="server" Text="" Width="30px"></asp:Label>
                <asp:Label ID="lblcpapname" runat="server"></asp:Label></h4>
         </div>
            <div class="clear"></div>
            <div class="align_middle" style="font-weight:bold;width:6.27in;">
                <table border="1" cellspacing="0" cellpadding="0" style="height:30px;text-align:center;font-size:8pt;width:100%;">
                    <tr>
       <th width="5%">Sl No</th>
        <th width="30%">Parameter Range</th>
        <th>Value as Set on DUT</th>
        <th>Average Value as on STD</th>
        <th>Deviation</th>
        <th>Allowed Deviation</th>
        <th>Remarks</th>
    </tr>
                    <tr id="tr_cpap1" runat="server">
        <td>
            <asp:Label ID="lblcpap1" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblcpap2" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblcpap3" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblcpap4" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblcpap5" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblcpap6" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblcpap7" runat="server"></asp:Label>
        </td>
    </tr>
                    <tr id="tr_cpap2" runat="server">
        <td>
            <asp:Label ID="lblcpap8" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblcpap9" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblcpap10" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblcpap11" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblcpap12" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblcpap13" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblcpap14" runat="server"></asp:Label>
        </td>
    </tr>
                    <tr id="tr_cpap3" runat="server">
        <td>
            <asp:Label ID="lblcpap15" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblcpap16" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblcpap17" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblcpap18" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblcpap19" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblcpap20" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblcpap21" runat="server"></asp:Label>
        </td>
    </tr>
                </table>
                </div>
            </div>