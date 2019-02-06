<%@ Page Title="" Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin.master" CodeFile="Add_Product.aspx.cs" Inherits="Add_Product" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<%@ Register Src="~/controls/Product.ascx" TagPrefix="uc1" TagName="Product" %>
<%@ Register Src="~/controls/AddTemperature.ascx" TagPrefix="uc1" TagName="AddTemperature" %>
<%@ Register Src="~/controls/Productviewforcustomer.ascx" TagPrefix="uc1" TagName="Productviewforcustomer" %>
<%@ Register Src="~/controls/AddTraceability.ascx" TagPrefix="uc1" TagName="AddTraceability" %>
<%@ Register Src="~/controls/Link_Taceability.ascx" TagPrefix="uc1" TagName="Link_Taceability" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <style type="text/css">
        .text, .text1, .text2, .text3, .text4 {
            width: 200px;
        }
    </style>
    <link href="Styles_ecom/ecom.css" rel="stylesheet" />
    <link href="Styles_ecom/bomtv.css" rel="stylesheet" />

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:HiddenField ID="productidhidden" runat="server" />
    <asp:HiddenField ID="utypeid_hidden" runat="server" />

    <div>
        <asp:Button ID="btnaddpro" runat="server" Text="Add Product" CssClass="button" Font-Size="Small" BackColor="#003366"
            OnClick="btnaddpro_Click" ForeColor="Yellow" />&nbsp;
         <asp:Button ID="btnaddtrace" runat="server" Text="Add Traceability" CssClass="button"
             OnClick="btnaddtrace_Click" Font-Size="Small" BackColor="#D8D8D8" ForeColor="Black" />&nbsp;
         <asp:Button ID="btnlink" runat="server" Text="Link Traceability" CssClass="button"
             OnClick="btnlink_Click" Font-Size="Small" BackColor="#D8D8D8" ForeColor="Black" />&nbsp;
          <asp:Button ID="btnlinkperformance" runat="server" Text="Link Performance" CssClass="button" Font-Size="Small"
              OnClick="btnlinkperformance_Click" BackColor="#D8D8D8" ForeColor="Black" />&nbsp;
         <asp:Button ID="btnenviron" runat="server" Text="Environmental Condition"
             OnClick="btnenviron_Click" CssClass="button" Font-Size="Small" BackColor="#D8D8D8" ForeColor="Black" />
    </div>
    <div class="clear"></div>
    <div class="content_box align_left shadow  round_corner5 colwidth975">
        <table width="100%">
            <tr>
                <th colspan="4">Add Product</th>
            </tr>
            <tr>
                <td>Product Name</td>
                <td>
                    <asp:TextBox ID="txtproname" runat="server" CssClass="text"></asp:TextBox>
                    <cc1:AutoCompleteExtender ID="txtproname_AutoCompleteExtender" runat="server" DelimiterCharacters="" Enabled="True"
                        ServiceMethod="SearchProduct" TargetControlID="txtproname">
                    </cc1:AutoCompleteExtender>
                </td>
                <td>Manufacture</td>
                <td>
                    <asp:TextBox ID="txtmanu" runat="server" CssClass="text"></asp:TextBox>
                    <cc1:AutoCompleteExtender ID="txtmanu_AutoCompleteExtender" runat="server" DelimiterCharacters="" Enabled="True" ServiceMethod="Searchcompany" TargetControlID="txtmanu">
                    </cc1:AutoCompleteExtender>
                </td>
            </tr>
            <tr>
                <td>Model</td>
                <td>
                    <asp:TextBox ID="txtmodel" runat="server" CssClass="text"></asp:TextBox>
                    <cc1:AutoCompleteExtender ID="txtmodel_AutoCompleteExtender" runat="server" DelimiterCharacters="" Enabled="True" ServiceMethod="Searchmodel" TargetControlID="txtmodel">
                    </cc1:AutoCompleteExtender>
                </td>
                <td>Device Type</td>
                <td>
                    <asp:TextBox ID="txtdevtype" runat="server" CssClass="text"></asp:TextBox>
                    <cc1:AutoCompleteExtender ID="txtdevtype_AutoCompleteExtender" runat="server" DelimiterCharacters="" Enabled="True" ServiceMethod="Searchdevtype" TargetControlID="txtdevtype">
                    </cc1:AutoCompleteExtender>
                </td>
            </tr>
            <tr>
                <td>Device Classification</td>
                <td>
                    <asp:TextBox ID="txtdevclassification" runat="server" CssClass="text"></asp:TextBox>
                    <cc1:AutoCompleteExtender ID="txtdevclassification_AutoCompleteExtender" runat="server" DelimiterCharacters="" Enabled="True" ServiceMethod="Searchdevclassi" TargetControlID="txtdevclassification">
                    </cc1:AutoCompleteExtender>
                </td>
                <td>Supply</td>
                <td>
                    <asp:TextBox ID="txtsupplydata" runat="server" CssClass="text"></asp:TextBox>
                    <cc1:AutoCompleteExtender ID="txtsupplydata_AutoCompleteExtender" runat="server" DelimiterCharacters="" Enabled="True" ServiceMethod="Searchsupply" TargetControlID="txtsupplydata">
                    </cc1:AutoCompleteExtender>
                </td>
            </tr>
            <tr>
                <td>Power rating</td>
                <td>
                    <asp:TextBox ID="txtpower" runat="server" CssClass="text"></asp:TextBox>
                    <cc1:AutoCompleteExtender ID="txtpower_AutoCompleteExtender" runat="server" DelimiterCharacters="" Enabled="True" ServiceMethod="Searchpower" TargetControlID="txtpower">
                    </cc1:AutoCompleteExtender>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Button ID="btnsave" runat="server" Text="Save" CssClass="button" OnClick="btnsave_Click" />&nbsp;
                     <asp:Button ID="btncancel" runat="server" Text="Cancel" CssClass="button" OnClick="btncancel_Click" />
                </td>
            </tr>
        </table>
    </div>
    <div class="clear"></div>
    <div id="Div1" class="content_wrap" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblsearchby" runat="server" Text="Search by: " ForeColor="White" /></td>
                <td></td>
                <td>
                    <asp:TextBox ID="txtSearchString1" runat="server" CssClass="text"></asp:TextBox>

                    <cc1:TextBoxWatermarkExtender ID="txtSearchString1_TextBoxWatermarkExtender" WatermarkText="Enter Product Name" runat="server" Enabled="True" TargetControlID="txtSearchString1"></cc1:TextBoxWatermarkExtender>
                    <cc1:AutoCompleteExtender ID="txtSearchString1_AutoCompleteExtender" runat="server" DelimiterCharacters="" Enabled="True"
                        ServiceMethod="SearchProduct" MinimumPrefixLength="2" CompletionInterval="100" EnableCaching="false" CompletionSetCount="10"
                        TargetControlID="txtSearchString1">
                    </cc1:AutoCompleteExtender>

                </td>
                <td>
                    <asp:Button ID="btnsearchproduct" runat="server" CssClass="button" OnClick="btnsearchproduct_Click" Text="Search" />
                    &nbsp;
                    
                </td>
            </tr>
        </table>
    </div>
    <div class="clear"></div>
    <div class="colwidth975">
        <asp:GridView ID="GridView1" runat="server" OnRowCancelingEdit="GridView1_RowCancelingEdit"
            OnRowDeleting="GridView1_RowDeleting" DataKeyNames="ProductID" AutoGenerateColumns="False" PageSize="50" ShowFooter="True" ForeColor="#333333" GridLines="None" Width="100%">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField ControlStyle-Width="25px">
                    <ItemTemplate>
                        <asp:ImageButton ID="imgbtnEdit" runat="server" ImageUrl="~/images/Edit.jpg" ToolTip="Edit"
                            CommandArgument='<%# Eval("ProductID") %>' Height="20px" Width="20px" OnClick="imgbtnEdit_Click" />
                        <asp:ImageButton ID="imgbtnDelete" CommandName="Delete" Text="Edit" runat="server" ImageUrl="~/images/delete.jpg"
                            OnClientClick="return confirm('Are you sure you want to delete this Product?')" ToolTip="Delete" Height="20px" Width="20px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderStyle Height="30px" />
                    <HeaderTemplate>Product Name</HeaderTemplate>
                    <ItemStyle HorizontalAlign="Center" />

                    <ItemTemplate>
                        <asp:Label ID="lblproduct" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                    </ItemTemplate>


                </asp:TemplateField>
                <asp:TemplateField HeaderText="Manufacture">
                    <ItemStyle HorizontalAlign="Center" />

                    <ItemTemplate>
                        <asp:Label ID="lblmanufacture" runat="server" Text='<%# Eval("Company") %>'></asp:Label>
                    </ItemTemplate>


                </asp:TemplateField>
                <asp:TemplateField HeaderText="Model Name">
                    <ItemStyle HorizontalAlign="Center" />

                    <ItemTemplate>
                        <asp:Label ID="lblmodel" runat="server" Text='<%# Eval("Model") %>'></asp:Label>
                    </ItemTemplate>


                </asp:TemplateField>
                <asp:TemplateField HeaderText="Device Type">
                    <ItemStyle HorizontalAlign="Center" />

                    <ItemTemplate>
                        <asp:Label ID="lbldevtype" runat="server" Text='<%# Eval("Device_Type") %>'></asp:Label>
                    </ItemTemplate>


                </asp:TemplateField>
                <asp:TemplateField HeaderText="Device Classification">
                    <ItemStyle HorizontalAlign="Center" />

                    <ItemTemplate>
                        <asp:Label ID="lbldevclassi" runat="server" Text='<%# Eval("Device_Classification") %>'></asp:Label>
                    </ItemTemplate>


                </asp:TemplateField>
                <asp:TemplateField HeaderText="Supply">
                    <ItemStyle HorizontalAlign="Center" />

                    <ItemTemplate>
                        <asp:Label ID="lblsupply" runat="server" Text='<%# Eval("Supply") %>'></asp:Label>
                    </ItemTemplate>


                </asp:TemplateField>
                <asp:TemplateField HeaderText="Power Rating">
                    <ItemStyle HorizontalAlign="Center" />

                    <ItemTemplate>
                        <asp:Label ID="lblpower" runat="server" Text='<%# Eval("PowerRating") %>'></asp:Label>
                    </ItemTemplate>


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
        <div style="text-align: center;">
            <asp:Repeater ID="rptPager" runat="server">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkPage" runat="server" Text='<%#Eval("Text") %>' CommandArgument='<%# Eval("Value") %>' Enabled='<%# Eval("Enabled") %>' OnClick="Page_Changed" Style="background-color: #284775; color: white"></asp:LinkButton>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <asp:Label ID="lblresult" runat="server" Text=""></asp:Label>
    </div>


</asp:Content>


