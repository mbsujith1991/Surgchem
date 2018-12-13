<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_FiO2_New.ascx.cs" Inherits="Perf_Control_Views_View_FiO2_New" %>

<div id="flowdiv" runat="server">
    <div class="align_middle" style="width: 6.27in">
        <h4>
            <asp:Label ID="Label34" runat="server" Text="" Width="30px"></asp:Label>
            <asp:Label ID="lblflow" runat="server"></asp:Label></h4>
    </div>
    <div class="clear"></div>
    <div class="align_middle" style="font-weight: bold; width: 6.27in;">
        <table border="1" cellspacing="0" cellpadding="0" style="height: 30px; text-align: center; font-size: 8pt; width: 100%;">
            <tr>
                <th>Sl No</th>
                <th>Observed on DUT </th>
                <th>Range</th>
                <th>Remarks</th>
            </tr>
            <tr id="tr_flow1" runat="server">
                <td>
                    <asp:Label ID="lblflow1" runat="server"></asp:Label></td>
                <td>
                    <asp:Label ID="lblflow2" runat="server"></asp:Label></td>
                <td>
                    <asp:Label ID="lblflow5" runat="server"></asp:Label></td>
                <td>
                    <asp:Label ID="lblflow6" runat="server"></asp:Label></td>
            </tr>
        </table>
        <br />
        <div>
            <asp:Label ID="lblTestTime" runat="server" Text="Test Time"></asp:Label>
        </div>
        <div>
            <asp:Label ID="lblInMinute" runat="server" Text="In Minute "></asp:Label>: 10 min
        </div>
    </div>
</div>
