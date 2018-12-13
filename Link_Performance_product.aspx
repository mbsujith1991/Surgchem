<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Link_Performance_product.aspx.cs" Inherits="Link_Performance_product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
         <asp:Button ID="btnaddpro" runat="server" Text="Add Product" CssClass="button" Font-Size="Small"
             OnClick="btnaddpro_Click" BackColor="#D8D8D8" ForeColor="Black"/>&nbsp;
         <asp:Button ID="btnaddtrace" runat="server" Text="Add Traceability" CssClass="button" Font-Size="Small"
             OnClick="btnaddtrace_Click" BackColor="#D8D8D8" ForeColor="Black"/>&nbsp;
         <asp:Button ID="btnlink" runat="server" Text="Link Traceability" CssClass="button" Font-Size="Small"
             OnClick="btnlink_Click" BackColor="#D8D8D8" ForeColor="Black"/>&nbsp;
         <asp:Button ID="btnlinkperformance" runat="server" Text="Link Performance" CssClass="button" Font-Size="Small"
             OnClick="btnlinkperformance_Click" BackColor="#003366" ForeColor="Yellow"/>&nbsp;
         <asp:Button ID="btnenviron" runat="server" Text="Environmental Condition" CssClass="button" Font-Size="Small"
             OnClick="btnenviron_Click" BackColor="#D8D8D8" ForeColor="Black"/>
         
     </div>
    <div class="clear"></div>

    <asp:HiddenField ID="lnk_perf_hidden" runat="server" />
    <asp:HiddenField ID="perfname_hidden" runat="server" />
    <asp:HiddenField ID="productname_hidden" runat="server" />
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
                Select Performance Test
                </td>
            </tr>
        <tr>
            <td>
                <asp:ListBox ID="lstperformance" runat="server" Rows="10" Width="300px" SelectionMode="Multiple"
                    AppendDataBoundItems="false"></asp:ListBox>
            </td>
            
        </tr>
        <tr>
             <td width="200px">
                <asp:Button ID="btnsave" runat="server" OnClick="btnsave_Click" Text="Save" CssClass="button-link"/>&nbsp;
                <asp:Button ID="btncancel" runat="server" OnClick="btncancel_Click" Text="Cancel" CssClass="button-link"/>
                <br />
                <asp:Label ID="lblmsg" runat="server" Text="" ForeColor="Green"></asp:Label>
            </td>
        </tr>
       
    </table>
</div>
        <div class="colwidth45 align_left">
            <br />
    <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False"
         AllowPaging="true" PageSize="10" OnPageIndexChanging="GridView1_PageIndexChanging1"
         CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
             <%--<asp:TemplateField ControlStyle-Width="20px">
<EditItemTemplate>
<asp:ImageButton ID="imgbtnUpdate" CommandName="Update" runat="server" ImageUrl="~/images/update.jpg" ToolTip="Update" Height="20px" Width="20px" />
<asp:ImageButton ID="imgbtnCancel" runat="server" CommandName="Cancel" ImageUrl="~/images/Cancel.jpg" ToolTip="Cancel" Height="20px" Width="20px" />

</EditItemTemplate>
<ItemTemplate>
<asp:ImageButton ID="imgbtnEdit" CommandName="Edit" runat="server" ImageUrl="~/images/Edit.jpg" ToolTip="Edit" Height="20px" Width="20px" />
<asp:ImageButton ID="imgbtnDelete" CommandName="Delete" Text="Edit" runat="server" ImageUrl="~/images/delete.jpg" ToolTip="Delete" Height="20px" Width="20px" />
</ItemTemplate>

<ControlStyle Width="20px"></ControlStyle>
                 </asp:TemplateField>--%>
            <asp:TemplateField HeaderText="Product">
                <ItemStyle Width="40%" />
                <ItemTemplate>
                    <asp:Label ID="lblproduct" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtproduct" runat="server" Text='<%# Eval("ProductName") %>'>></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Performance">
                <ItemTemplate>
                    <asp:Label ID="lblinstrument" runat="server" Text='<%# Eval("Perf_TestName") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtinstrument" runat="server" Text='<%# Eval("Perf_TestName") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" HorizontalAlign="Left"/>
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
    
</asp:Content>

