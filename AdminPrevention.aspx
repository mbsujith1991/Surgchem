<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminPrevention.aspx.cs" Inherits="AdminPrevention" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:HiddenField ID="hospitalidhidden" runat="server" />
    <asp:HiddenField ID="preventid_hidden" runat="server" />
    <asp:HiddenField ID="utypeid_hidden" runat="server" />
    <div style="width: 90%; background-color: white; padding-left: 10px; padding-top: 10px;">
        <h3><b>Preventive Maintenance</b></h3>
        <asp:GridView ID="grdPrevention" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None"
            OnRowDataBound="grdPrevention_RowDataBound" OnPageIndexChanging="grdPrevention_PageIndexChanging"
            EmptyDataText="No Records Found" EmptyDataRowStyle-ForeColor="Red" Width="100%">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" CssClass="padtop" />
            <Columns>
                <asp:BoundField DataField="HospitalName" HeaderText="Hospital Name"></asp:BoundField>
                <asp:BoundField DataField="ProductName" HeaderText="Product Name"></asp:BoundField>
                <asp:BoundField DataField="Manufacture" HeaderText="Manufacture"></asp:BoundField>
                <asp:BoundField DataField="Model" HeaderText="Model"></asp:BoundField>
                <asp:BoundField DataField="DeviceType" HeaderText="DeviceType"></asp:BoundField>
                <asp:TemplateField HeaderText="Calibration Test">
                    <ItemTemplate>
                        <asp:HiddenField ID="HiddenFieldPreventID" Value='<%# Eval("PreventID") %>' runat="server" />
                        <asp:ListBox ID="lstcalibration" runat="server" CssClass="hosp_class"></asp:ListBox>
                    </ItemTemplate>
                </asp:TemplateField>
                
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" HorizontalAlign="Left" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </div>
</asp:Content>

