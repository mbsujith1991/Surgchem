<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_Temperaturemeasure_constant.ascx.cs" Inherits="Perf_Control_Views_View_Temperaturemeasure_constant" %>

<div id="tempdeepfreezerdiv" runat="server">
    <div class="align_middle" style="width: 6.27in">
        <h4>
            <asp:Label ID="Label34" runat="server" Text="" Width="30px"></asp:Label>
            <asp:Label ID="lbldeepfreezer" runat="server"></asp:Label></h4>
    </div>
    <div class="clear"></div>
    <div class="align_middle" style="font-weight: bold; width: 6.27in;">
        <table border="1" cellspacing="0" cellpadding="0" style="height: 30px; text-align: center; font-size: 8pt; width: 100%;">
            <tr>
                <th rowspan="2">Sl No
                </th>
                <th rowspan="2">Temperature Set on Constant Temp Device</th>
                <th colspan="3">Temperature measured on DUT</th>
                <th rowspan="2">Mean Value</th>
                <th rowspan="2">Deviation</th>
                <th rowspan="2">Deviation Specified limit as per Mfr. Spec.</th>
                <th rowspan="2">Remarks</th>
            </tr>
            <tr>
                <th>TP1</th>
                <th>TP2</th>
                <th>TP3</th>
            </tr>

            <tr id="tr_deepfreezer1" runat="server">
                <td>
                    <asp:Label ID="lbldeep1" runat="server"></asp:Label></td>
                <td>
                    <asp:Label ID="lblsetdut1" runat="server"></asp:Label></td>
                <td>
                    <asp:Label ID="lbldeep2" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbldeep3" runat="server"></asp:Label></td>
                <td>
                    <asp:Label ID="lbldeep4" runat="server"></asp:Label></td>
                <td>
                    <asp:Label ID="lbldeep5" runat="server"></asp:Label></td>
                <td>
                    <asp:Label ID="lbldeep6" runat="server"></asp:Label></td>


                <td>
                    <asp:Label ID="lbldeep7" runat="server"></asp:Label></td>
                <td>
                    <asp:Label ID="lbldeep8" runat="server"></asp:Label></td>

            </tr>
            <tr id="tr_deepfreezer2" runat="server">
                <td>
                    <asp:Label ID="lbldeep9" runat="server"></asp:Label></td>
                <td>
                    <asp:Label ID="lblsetdut2" runat="server"></asp:Label></td>
                <td>
                    <asp:Label ID="lbldeep10" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbldeep11" runat="server"></asp:Label></td>
                <td>
                    <asp:Label ID="lbldeep12" runat="server"></asp:Label></td>
                <td>
                    <asp:Label ID="lbldeep13" runat="server"></asp:Label></td>
                <td>
                    <asp:Label ID="lbldeep14" runat="server"></asp:Label></td>


                <td>
                    <asp:Label ID="lbldeep15" runat="server"></asp:Label></td>
                <td>
                    <asp:Label ID="lbldeep16" runat="server"></asp:Label></td>

            </tr>
        </table>
    </div>
</div>