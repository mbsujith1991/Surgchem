<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Product.ascx.cs" Inherits="controls_Product" %>

<link href="../Styles_ecom/ecom.css" rel="stylesheet" />

<div style="width:90%;">
<asp:GridView ID="GridView1" runat="server" OnRowCancelingEdit="GridView1_RowCancelingEdit"
    OnRowEditing="GridView1_RowEditing" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting"
    OnPageIndexChanging="GridView1_PageIndexChanging" OnRowUpdating="GridView1_RowUpdating"
    AllowPaging="True" DataKeyNames="ProductID" AutoGenerateColumns="False"
    OnRowDataBound="GridView1_RowDataBound" ShowFooter="True" ForeColor="#333333" GridLines="None">

    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />

    <Columns>
        <asp:TemplateField ControlStyle-Width="20px">
<EditItemTemplate>
<asp:ImageButton ID="imgbtnUpdate" CommandName="Update" runat="server" ImageUrl="~/images/update.jpg" ToolTip="Update" Height="20px" Width="20px" />
<asp:ImageButton ID="imgbtnCancel" runat="server" CommandName="Cancel" ImageUrl="~/images/Cancel.jpg" ToolTip="Cancel" Height="20px" Width="20px" />

</EditItemTemplate>
<ItemTemplate>
<asp:ImageButton ID="imgbtnEdit" CommandName="Edit" runat="server" ImageUrl="~/images/Edit.jpg" ToolTip="Edit" Height="20px" Width="20px" />
<asp:ImageButton ID="imgbtnDelete" CommandName="Delete" Text="Edit" runat="server" ImageUrl="~/images/delete.jpg" ToolTip="Delete" Height="20px" Width="20px" />
</ItemTemplate>
<FooterTemplate>
<asp:ImageButton ID="imgbtnAdd" runat="server" ImageUrl="~/images/AddNewitem.jpg" CommandName="AddNew" Width="30px" Height="30px" ToolTip="Add new User" ValidationGroup="addproduct" />

</FooterTemplate>
 </asp:TemplateField>
                 
                 <asp:TemplateField>
                     <HeaderStyle Height="30px" />
                     <HeaderTemplate>Product Name</HeaderTemplate>
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblproduct" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                          <asp:TextBox ID="txtproduct" runat="server" Text='<%# Eval("ProductName") %>' Width="140px"></asp:TextBox>
                     </EditItemTemplate>
                     <FooterTemplate>
                         <asp:TextBox ID="txtproductfooter" runat="server" Text='<%# Eval("ProductName") %>' Width="140px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvproduct" runat="server" ControlToValidate="txtproductfooter" Text="*" ValidationGroup="addproduct"/>
                     </FooterTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Manufacture">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblmanufacture" runat="server" Text='<%# Eval("Company") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                          <asp:TextBox ID="txtmanufacture" runat="server" Text='<%# Eval("Company") %>' Width="140px"></asp:TextBox>
                     </EditItemTemplate>
                     <FooterTemplate>
                         <asp:TextBox ID="txtmanufacturefooter" runat="server" Text='<%# Eval("Company") %>' Width="140px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvmanuf" runat="server" ControlToValidate="txtmanufacturefooter" Text="*" ValidationGroup="addproduct"/>

                     </FooterTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Model Name">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblmodel" runat="server" Text='<%# Eval("Model") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                         <asp:TextBox ID="txtmodel" runat="server" Text='<%# Eval("Model") %>' Width="140px"></asp:TextBox>
                     </EditItemTemplate>
                     <FooterTemplate>
                         <asp:TextBox ID="txtmodelfooter" runat="server" Text='<%# Eval("Model") %>' Width="140px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvmodel" runat="server" ControlToValidate="txtmodelfooter" Text="*" ValidationGroup="addproduct"/>

                     </FooterTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Device Type">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lbldevtype" runat="server" Text='<%# Eval("Device_Type") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                         <asp:TextBox ID="txtdevtype" runat="server" Text='<%# Eval("Device_Type") %>' Width="140px"></asp:TextBox>
                     </EditItemTemplate>
                     <FooterTemplate>
                         <asp:TextBox ID="txtdevtypefooter" runat="server" Text='<%# Eval("Device_Type") %>' Width="140px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvdevtype" runat="server" ControlToValidate="txtdevtypefooter" Text="*" ValidationGroup="addproduct"/>
                     </FooterTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Device Classification">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lbldevclassi" runat="server" Text='<%# Eval("Device_Classification") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                         <asp:TextBox ID="txtdevclassi" runat="server" Text='<%# Eval("Device_Classification") %>' Width="140px"></asp:TextBox>
                     </EditItemTemplate>
                     <FooterTemplate>
                          <asp:TextBox ID="txtdevclassifooter" runat="server" Text='<%# Eval("Device_Classification") %>' Width="140px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvdevclassi" runat="server" ControlToValidate="txtdevclassifooter" Text="*" ValidationGroup="addproduct"/>
                     </FooterTemplate>
                 </asp:TemplateField>
        <asp:TemplateField HeaderText="Supply">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblsupply" runat="server" Text='<%# Eval("Supply") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                         <asp:TextBox ID="txtsupply" runat="server" Text='<%# Eval("Supply") %>' Width="140px"></asp:TextBox>
                     </EditItemTemplate>
                     <FooterTemplate>
                          <asp:TextBox ID="txtsupplyfooter" runat="server" Text='<%# Eval("Supply") %>' Width="140px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvsupply" runat="server" ControlToValidate="txtsupplyfooter" Text="*" ValidationGroup="addproduct"/>
                     </FooterTemplate>
                 </asp:TemplateField>
        <asp:TemplateField HeaderText="Power Rating">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblpower" runat="server" Text='<%# Eval("PowerRating") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                         <asp:TextBox ID="txtpower" runat="server" Text='<%# Eval("PowerRating") %>' Width="140px"></asp:TextBox>
                     </EditItemTemplate>
                     <FooterTemplate>
                          <asp:TextBox ID="txtpowerfooter" runat="server" Text='<%# Eval("PowerRating") %>' Width="140px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvpower" runat="server" ControlToValidate="txtpowerfooter" Text="*" ValidationGroup="addproduct"/>
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
