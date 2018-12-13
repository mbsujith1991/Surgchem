<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AddTraceability.aspx.cs" Inherits="AddTraceability" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Styles_ecom/ecom.css" rel="stylesheet" />
    <link href="Styles_ecom/bomtv.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:HiddenField ID="utypeid_hidden" runat="server" />
     <div>
         <asp:Button ID="btnaddpro" runat="server" Text="Add Product" CssClass="button" Font-Size="Small" BackColor="#D8D8D8"
             OnClick="btnaddpro_Click" ForeColor="Black"/>&nbsp;
         <asp:Button ID="btnaddtrace" runat="server" Text="Add Traceability" CssClass="button" Font-Size="Small"
             OnClick="btnaddtrace_Click" BackColor="#003366" ForeColor="Yellow"/>&nbsp;
         <asp:Button ID="btnlink" runat="server" Text="Link Traceability" CssClass="button" Font-Size="Small"
             OnClick="btnlink_Click" BackColor="#D8D8D8" ForeColor="Black"/>&nbsp;
          <asp:Button ID="btnlinkperformance" runat="server" Text="Link Performance" CssClass="button" Font-Size="Small"
             OnClick="btnlinkperformance_Click" BackColor="#D8D8D8" ForeColor="Black"/>&nbsp;
         <asp:Button ID="btnenviron" runat="server" Text="Environmental Condition" CssClass="button" Font-Size="Small"
             OnClick="btnenviron_Click" BackColor="#D8D8D8" ForeColor="Black"/>
     </div>
    <div class="clear"></div>
  <asp:HiddenField ID="traceidhidden" runat="server" />
<div class="align_middle colwidth975">
    <asp:GridView ID="GridViewaddtrace" runat="server" AutoGenerateColumns="False" DataKeyNames="Tracibility_ID"
        OnRowCancelingEdit="GridViewaddtrace_RowCancelingEdit" ShowFooter="True" CellPadding="1"
        OnRowEditing="GridViewaddtrace_RowEditing" AllowPaging="true" PageSize="10"
        OnRowUpdating="GridViewaddtrace_RowUpdating"
        OnRowCommand="GridViewaddtrace_RowCommand" OnPageIndexChanging="GridViewaddtrace_PageIndexChanging"
        OnRowDataBound="GridViewaddtrace_RowDataBound" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" Width="100%"/>
        <Columns>
            <asp:TemplateField>
<EditItemTemplate>
<asp:ImageButton ID="imgbtnUpdate" CommandName="Update" runat="server" ImageUrl="~/images/update.jpg" ToolTip="Update" Height="20px" Width="20px" />
<asp:ImageButton ID="imgbtnCancel" runat="server" CommandName="Cancel" ImageUrl="~/images/Cancel.jpg" ToolTip="Cancel" Height="20px" Width="20px" />

</EditItemTemplate>
<ItemTemplate>
<asp:ImageButton ID="imgbtnEdit" CommandName="Edit" runat="server" ImageUrl="~/images/Edit.jpg" ToolTip="Edit" Height="20px" Width="20px" />
<%--<asp:ImageButton ID="imgbtnDelete" CommandName="Delete" Text="Edit" runat="server" ImageUrl="~/images/delete.jpg" ToolTip="Delete" Height="20px" Width="20px" />--%>
</ItemTemplate>
<FooterTemplate>
<asp:ImageButton ID="imgbtnAdd" runat="server" ImageUrl="~/images/AddNewitem.jpg" CommandName="AddNew" Width="30px" Height="30px" ToolTip="Add new User" ValidationGroup="trace" />

</FooterTemplate>
 </asp:TemplateField>

             <asp:TemplateField>
                     <HeaderStyle Height="30px" />
                     <HeaderTemplate>Instrument</HeaderTemplate>
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblinstrument" runat="server" Text='<%# Eval("Instrument") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                          <asp:TextBox ID="txtInstrument" runat="server" Text='<%# Eval("Instrument") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <FooterTemplate>
                         <asp:TextBox ID="txtInstrumentfooter" runat="server" Text='<%# Eval("Instrument") %>'></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvproduct" runat="server" ControlToValidate="txtInstrumentfooter" Text="*" ValidationGroup="trace"/>
                     </FooterTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Make">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblMake" runat="server" Text='<%# Eval("Make") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                          <asp:TextBox ID="txtMake" runat="server" Text='<%# Eval("Make") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <FooterTemplate>
                         <asp:TextBox ID="txtMakefooter" runat="server" Text='<%# Eval("Make") %>'></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvmanuf" runat="server" ControlToValidate="txtMakefooter" Text="*" ValidationGroup="trace"/>

                     </FooterTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Model">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblModel" runat="server" Text='<%# Eval("Model") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                         <asp:TextBox ID="txtModel" runat="server" Text='<%# Eval("Model") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <FooterTemplate>
                         <asp:TextBox ID="txtModelfooter" runat="server" Text='<%# Eval("Model") %>'></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvmodel" runat="server" ControlToValidate="txtModelfooter" Text="*" ValidationGroup="trace"/>

                     </FooterTemplate>
                 </asp:TemplateField>
            <asp:TemplateField HeaderText="Serial No">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblSerial_No" runat="server" Text='<%# Eval("Serial_No") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                         <asp:TextBox ID="txtSerial_No" runat="server" Text='<%# Eval("Serial_No") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <FooterTemplate>
                         <asp:TextBox ID="txSerial_Nofooter" runat="server" Text='<%# Eval("Serial_No") %>'></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvslno" runat="server" ControlToValidate="txSerial_Nofooter" Text="*" ValidationGroup="trace"/>

                     </FooterTemplate>
                 </asp:TemplateField>
            <asp:TemplateField HeaderText="Traceability Call Ddue">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lbltracecall" runat="server" Text='<%# Eval("Traceability_call_due") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                         <asp:TextBox ID="txttracecall" runat="server" Text='<%# Eval("Traceability_call_due") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <FooterTemplate>
                         <asp:TextBox ID="txttracecallfooter" runat="server" Text='<%# Eval("Traceability_call_due") %>'></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvtracecall" runat="server" ControlToValidate="txttracecallfooter" Text="*" ValidationGroup="trace"/>

                     </FooterTemplate>
                 </asp:TemplateField>
            <asp:TemplateField HeaderText="Reference">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblReference" runat="server" Text='<%# Eval("Reference") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                         <asp:TextBox ID="txtReference" runat="server" Text='<%# Eval("Reference") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <FooterTemplate>
                         <asp:TextBox ID="txtReferencefooter" runat="server" Text='<%# Eval("Reference") %>'></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvrefer" runat="server" ControlToValidate="txtReferencefooter" Text="*" ValidationGroup="trace"/>

                     </FooterTemplate>
                 </asp:TemplateField>
        </Columns>

        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />

    </asp:GridView>

    <asp:Label ID="lblresult" runat="server" Text=""></asp:Label>
</div>
</asp:Content>
