<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_PerfBiPap.ascx.cs" Inherits="Perf_Control_Views_View_PerfBiPap" %>

<%--perf Bipap div starts--%>
        <div id="bipapdiv" runat="server">
            <div  class="align_middle" style="width:6.27in">
            <h4>
                <asp:Label ID="Label41" runat="server" Text="" Width="30px"></asp:Label>
                <asp:Label ID="lblbipapname" runat="server"></asp:Label></h4>
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
                    <tr id="tr_bipap1" runat="server">
        <td>
            <asp:Label ID="lblbipap1" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblbipap2" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblbipap3" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblbipap4" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblbipap5" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblbipap6" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblbipap7" runat="server"></asp:Label>
        </td>
    </tr>
                    <tr id="tr_bipap2" runat="server">
        <td>
            <asp:Label ID="lblbipap8" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblbipap9" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblbipap10" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblbipap11" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblbipap12" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblbipap13" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblbipap14" runat="server"></asp:Label>
        </td>
    </tr>
                    <tr id="tr_bipap3" runat="server">
        <td>
            <asp:Label ID="lblbipap15" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblbipap16" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblbipap17" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblbipap18" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblbipap19" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblbipap20" runat="server"></asp:Label>
        </td>
        <td>
             <asp:Label ID="lblbipap21" runat="server"></asp:Label>
        </td>
    </tr>
                </table>
                </div>
            </div>