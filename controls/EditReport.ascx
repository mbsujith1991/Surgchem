<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditReport.ascx.cs" Inherits="controls_EditReport" %>


<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="ReportNo" HeaderText="Report No" />
        <asp:BoundField HeaderText="Date of Calib" DataField="Date_of_calibration" />
        <asp:BoundField DataField="Calibration_Due_on" HeaderText="Calib Due Date" />
        <asp:BoundField DataField="HospitalName" HeaderText="Hospital Name" />
        <asp:BoundField DataField="Instrument" HeaderText="Trace Equipment" />
        <asp:BoundField DataField="Perf_TestName" HeaderText="Performance Naame" />
    </Columns>

</asp:GridView>

<asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False">
    <Columns>
       
        <asp:BoundField DataField="Instrument" HeaderText="Trace Equipment" />
    </Columns>

</asp:GridView>

<asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False">
    <Columns>
       
        <asp:BoundField DataField="Perf_TestName" HeaderText="Performance Name" />
    </Columns>

</asp:GridView>

<asp:DataList ID="DataList1" runat="server" OnItemCommand="DataList1_ItemCommand" OnItemDataBound="DataList1_ItemDataBound">
    <ItemTemplate>
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblreptno" runat="server" Text='<%# Eval("ReportNo") %>'></asp:Label>
                </td>
                 <td>
                    <asp:Label ID="lblcalibdate" runat="server" Text='<%# Eval("Date_of_calibration") %>'></asp:Label>
                </td>
                 <td>
                    <asp:Label ID="lblcalibdue" runat="server" Text='<%# Eval("Calibration_Due_on") %>'></asp:Label>
                </td>
                 <td>
                    <asp:Label ID="lblhospital" runat="server" Text='<%# Eval("HospitalName") %>'></asp:Label>
                </td>
                 <td>
                    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                </td>
                 <td>
                     <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                </td>
            </tr>
        </table>
    </ItemTemplate>
</asp:DataList>
