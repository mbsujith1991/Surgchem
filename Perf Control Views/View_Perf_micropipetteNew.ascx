<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_Perf_micropipetteNew.ascx.cs" Inherits="Perf_Control_Views_View_Perf_micropipetteNew" %>
<div id="perfholterdiv" runat="server">
    <div class="align_middle" style="width: 6.27in">
        <h4>
            <asp:Label ID="Label41" runat="server" Width="30px"></asp:Label>
            <asp:Label ID="lblperfholter" runat="server"></asp:Label></h4>
    </div>
    <div class="clear"></div>
    <div class="align_middle" style="font-weight: bold; width: 6.27in;">
        <p style="font-size: 8pt">
            Pipette clinic follows the norms of ISO/IEC  17025 .This is compliance with national/international standards. piston operated device calibration is carried out in gravimetric method with respect to standards/mentioned as per ISO.
        </p>
        <table border="1" cellspacing="0" cellpadding="0" style="height: 30px; text-align: center; font-size: 8pt; width: 100%;">
            <tr>
                <th width="5%">Sl No</th>
                <th width="30%">Device Reading(&#181;l)</th>
                <th>Mean Value(&#181;l)</th>
                <th>Correction(&#181;l)</th>
                <th>Measurement Uncertainity(&#181;l)</th>
                <th>Remarks</th>
            </tr>
            <tr id="tr_microPipt1" runat="server">
                <td>
                    <asp:Label ID="lbl_micropipt1_1" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbl_micropipt1_2" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbl_micropipt1_3" runat="server"></asp:Label>

                </td>
                <td>
                    <asp:Label ID="lbl_micropipt1_4" runat="server"></asp:Label>

                </td>
                <td>
                    <asp:Label ID="lbl_micropipt1_5" runat="server"></asp:Label>

                </td>
                <td>
                    <asp:Label ID="lbl_micropipt1_6" runat="server"></asp:Label>

                </td>

            </tr>
            <tr id="tr_microPipt2" runat="server">
                <td>
                    <asp:Label ID="lbl_micropipt2_1" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbl_micropipt2_2" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbl_micropipt2_3" runat="server"></asp:Label>

                </td>
                <td>
                    <asp:Label ID="lbl_micropipt2_4" runat="server"></asp:Label>

                </td>
                <td>
                    <asp:Label ID="lbl_micropipt2_5" runat="server"></asp:Label>

                </td>
                <td>
                    <asp:Label ID="lbl_micropipt2_6" runat="server"></asp:Label>

                </td>

            </tr>
            <tr id="tr_microPipt3" runat="server">
                <td>
                    <asp:Label ID="lbl_micropipt3_1" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbl_micropipt3_2" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbl_micropipt3_3" runat="server"></asp:Label>

                </td>
                <td>
                    <asp:Label ID="lbl_micropipt3_4" runat="server"></asp:Label>

                </td>
                <td>
                    <asp:Label ID="lbl_micropipt3_5" runat="server"></asp:Label>

                </td>
                <td>
                    <asp:Label ID="lbl_micropipt3_6" runat="server"></asp:Label>

                </td>

            </tr>
            <tr id="tr_microPipt4" runat="server">
                <td>
                    <asp:Label ID="lbl_micropipt4_1" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbl_micropipt4_2" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbl_micropipt4_3" runat="server"></asp:Label>

                </td>
                <td>
                    <asp:Label ID="lbl_micropipt4_4" runat="server"></asp:Label>

                </td>
                <td>
                    <asp:Label ID="lbl_micropipt4_5" runat="server"></asp:Label>

                </td>
                <td>
                    <asp:Label ID="lbl_micropipt4_6" runat="server"></asp:Label>

                </td>

            </tr>
        </table>
        <p style="font-size: 8pt">
            The uncertainity estimated during the calibration is determined with the coverage factor K=2 and at the estimated confident level of 95% in accordance with ISO/TR 20461 .
        </p>
    </div>
</div>
