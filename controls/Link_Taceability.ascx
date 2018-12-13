<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Link_Taceability.ascx.cs" Inherits="controls_Link_Taceability" %>

<link href="../Styles_ecom/ecom.css" rel="stylesheet" />

<asp:HiddenField ID="tracehidden" runat="server" />
<div style="width:100%;">

<div class="content_box colwidth45 round_corner5 shadow align_left">
    <table>
        <tr>
            <th colspan="2">
                Relate Product and Traceability
            </th>
            </tr>
        <tr>
            <td>Select Product&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="drpproduct" runat="server" 
      AppendDataBoundItems="true"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                Select Traceability
                </td>
            </tr>
        <tr>
            <td>
                <asp:ListBox ID="lsttrace" runat="server" Rows="10" Width="200px" SelectionMode="Multiple"
                    AppendDataBoundItems="false"></asp:ListBox>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnsave" runat="server" OnClick="btnsave_Click" Text="Save" CssClass="button-link"/>&nbsp;
                <asp:Button ID="btncancel" runat="server" OnClick="btncancel_Click" Text="Cancel" CssClass="button-link"/>
                <br />
                <asp:Label ID="lblmsg" runat="server" Text="" ForeColor="Green"></asp:Label>
            </td>
        </tr>
    </table>
</div>
        <div class="colwidth45 align_left">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" PageSize="10" AutoGenerateColumns="False"
        OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="Linkid"
    OnRowEditing="GridView1_RowEditing"  OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCommand="GridView1_RowCommand"
         CellPadding="4" ForeColor="#333333" GridLines="None" OnRowUpdating="GridView1_RowUpdating">
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

<ControlStyle Width="20px"></ControlStyle>
                 </asp:TemplateField>
            <asp:TemplateField HeaderText="Product">
                <ItemTemplate>
                    <asp:Label ID="lblproduct" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtproduct" runat="server" Text='<%# Eval("ProductName") %>'>></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Instrument">
                <ItemTemplate>
                    <asp:Label ID="lblinstrument" runat="server" Text='<%# Eval("Instrument") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtinstrument" runat="server" Text='<%# Eval("Instrument") %>'></asp:TextBox>
                </EditItemTemplate>
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
    </div>
<div class="clear"></div>

