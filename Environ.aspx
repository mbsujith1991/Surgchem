<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Environ.aspx.cs" Inherits="Environ" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Styles_ecom/bomtv.css" rel="stylesheet" />
    <link href="Styles_ecom/ecom.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:HiddenField ID="utypeid_hidden" runat="server" />
     <div>
         <asp:Button ID="btnaddpro" runat="server" Text="Add Product" CssClass="button" Font-Size="Small" BackColor="#D8D8D8"
             OnClick="btnaddpro_Click" ForeColor="Black"/>&nbsp;
         <asp:Button ID="btnaddtrace" runat="server" Text="Add Traceability" CssClass="button" Font-Size="Small" BackColor="#D8D8D8"
             OnClick="btnaddtrace_Click" ForeColor="Black"/>&nbsp;
         <asp:Button ID="btnlink" runat="server" Text="Link Traceability" CssClass="button" Font-Size="Small" BackColor="#D8D8D8"
             OnClick="btnlink_Click" ForeColor="Black"/>&nbsp;
          <asp:Button ID="btnlinkperformance" runat="server" Text="Link Performance" CssClass="button" Font-Size="Small"
             OnClick="btnlinkperformance_Click" BackColor="#D8D8D8" ForeColor="Black"/>&nbsp;
         <asp:Button ID="btnenviron" runat="server" Text="Environmental Condition" CssClass="button" Font-Size="Small" 
            OnClick="btnenviron_Click" BackColor="#003366" ForeColor="Yellow"/>
     </div>
    <div class="clear"></div>
    <div class="align_middle">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ECM_ID"
        OnRowCancelingEdit="GridView1_RowCancelingEdit" ShowFooter="True" CellPadding="4"
        OnRowEditing="GridView1_RowEditing"
        OnRowUpdating="GridView1_RowUpdating"
        OnRowDeleting="GridView1_RowDeleting"
        OnRowCommand="GridView1_RowCommand"
        OnRowDataBound="GridView1_RowDataBound" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:TemplateField>
<EditItemTemplate>
<asp:ImageButton ID="imgbtnUpdate" CommandName="Update" runat="server" ImageUrl="~/images/update.jpg" ToolTip="Update" Height="20px" Width="20px" />
<asp:ImageButton ID="imgbtnCancel" runat="server" CommandName="Cancel" ImageUrl="~/images/Cancel.jpg" ToolTip="Cancel" Height="20px" Width="20px" />

</EditItemTemplate>
<ItemTemplate>
<asp:ImageButton ID="imgbtnEdit" CommandName="Edit" runat="server" ImageUrl="~/images/Edit.jpg" ToolTip="Edit" Height="20px" Width="20px" />
<asp:ImageButton ID="imgbtnDelete" CommandName="Delete" Text="Edit" runat="server" ImageUrl="~/images/delete.jpg" ToolTip="Delete" Height="20px" Width="20px" />
</ItemTemplate>
<FooterTemplate>
<asp:ImageButton ID="imgbtnAdd" runat="server" ImageUrl="~/images/AddNewitem.jpg" CommandName="AddNew" Width="30px" Height="30px" ToolTip="Add new User" ValidationGroup="validaiton" />

</FooterTemplate>
 </asp:TemplateField>

             <asp:TemplateField>
                     <HeaderStyle Height="30px" />
                     <HeaderTemplate>Temperature</HeaderTemplate>
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lbltemperature" runat="server" Text='<%# Eval("Temperature") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                          <asp:TextBox ID="txttemperature" runat="server" Text='<%# Eval("Temperature") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <FooterTemplate>
                         <asp:TextBox ID="txttempfooter" runat="server" Text='<%# Eval("Temperature") %>'></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvproduct" runat="server" ControlToValidate="txttempfooter" Text="*" ValidationGroup="validaiton"/>
                     </FooterTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Relative Humidity">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblRelative_Humidity" runat="server" Text='<%# Eval("Relative_Humidity") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                          <asp:TextBox ID="txtRelative_Humidity" runat="server" Text='<%# Eval("Relative_Humidity") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <FooterTemplate>
                         <asp:TextBox ID="txtRelative_Humidityfooter" runat="server" Text='<%# Eval("Relative_Humidity") %>'></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvmanuf" runat="server" ControlToValidate="txtRelative_Humidityfooter" Text="*" ValidationGroup="validaiton"/>

                     </FooterTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Ambient Pressure">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblambient" runat="server" Text='<%# Eval("Ambient_Barometric_measure") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                         <asp:TextBox ID="txtambient" runat="server" Text='<%# Eval("Ambient_Barometric_measure") %>'></asp:TextBox>
                     </EditItemTemplate>
                     <FooterTemplate>
                         <asp:TextBox ID="txtambientfooter" runat="server" Text='<%# Eval("Ambient_Barometric_measure") %>'></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvmodel" runat="server" ControlToValidate="txtambientfooter" Text="*" ValidationGroup="validaiton"/>

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

