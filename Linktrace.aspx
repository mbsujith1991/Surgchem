<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Linktrace.aspx.cs" Inherits="Linktrace" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Styles_ecom/bomtv.css" rel="stylesheet" />
    <link href="Styles_ecom/ecom.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:HiddenField ID="traceidhidden" runat="server" />
     <div>
         <asp:Button ID="btnaddpro" runat="server" Text="Add Product" CssClass="button" Font-Size="Small"
             OnClick="btnaddpro_Click" BackColor="#D8D8D8" ForeColor="Black"/>&nbsp;
         <asp:Button ID="btnaddtrace" runat="server" Text="Add Traceability" CssClass="button" Font-Size="Small"
             OnClick="btnaddtrace_Click" BackColor="#D8D8D8" ForeColor="Black"/>&nbsp;
         <asp:Button ID="btnlink" runat="server" Text="Link Traceability" CssClass="button" Font-Size="Small"
             OnClick="btnlink_Click" BackColor="#003366" ForeColor="Yellow"/>&nbsp;
         <asp:Button ID="btnlinkperformance" runat="server" Text="Link Performance" CssClass="button" Font-Size="Small"
             OnClick="btnlinkperformance_Click" BackColor="#D8D8D8" ForeColor="Black"/>&nbsp;
         <asp:Button ID="btnenviron" runat="server" Text="Environmental Condition" CssClass="button" Font-Size="Small"
             OnClick="btnenviron_Click" BackColor="#D8D8D8" ForeColor="Black"/>
         
     </div>
    <div class="clear"></div>

    <asp:HiddenField ID="tracehidden" runat="server" />
    <asp:HiddenField ID="tracename_hidden" runat="server" />
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
                Select Traceability
                </td>
            </tr>
        <tr>
            <td>
                <asp:ListBox ID="lsttrace" runat="server" Rows="10" Width="300px" SelectionMode="Multiple"
                    AppendDataBoundItems="false" OnSelectedIndexChanged="lsttrace_SelectedIndexChanged" AutoPostBack="true"></asp:ListBox>
            </td>
            
        </tr>
       
    </table>
     <asp:Button ID="DevicesPopupButton" runat="server" Text="View Tracibility"  CssClass="button"/>
    <br />
</div>
   
        <div class="colwidth45 align_left">
            <br />
     <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False"
          AllowPaging="true" PageSize="10" OnPageIndexChanging="GridView1_PageIndexChanging1"
         CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <%-- <asp:TemplateField ControlStyle-Width="20px">
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
   
    <div class="align_left shadow round_corner5 colwidth975" style="background-color:white;margin-left:1%;">
                <table width="100%">
                    <tr>
                        
                        <td>Remarks
                            <br />
                            <asp:TextBox id="txtremarks" runat="server" TextMode="MultiLine" Width="100%" Height="200px" CssClass="multiline"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Remarks"
                                ControlToValidate="txtremarks" ValidationGroup="remarks"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                     <tr>
            <td width="200px">
                <asp:Button ID="btnsave" runat="server" OnClick="btnsave_Click" Text="Save" CssClass="button-link" ValidationGroup="remarks"/>&nbsp;
                <asp:Button ID="btncancel" runat="server" OnClick="btncancel_Click" Text="Cancel" CssClass="button-link" CausesValidation="false"/>
                <br />
                <asp:Label ID="lblmsg" runat="server" Text="" ForeColor="Green"></asp:Label>
            </td>
        </tr>
                </table>
            </div>
            <div class="clear"></div>

     <asp:Panel ID="ConfirmationPopupPanel" runat="server" Width="450px" Height="400px"
                Style="display: none;">
                <asp:UpdatePanel ID="UserConfirmUpdatePanel" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:HiddenField ID="UserIDHiddenField" runat="server" Value="0" />
                        <table width="450px" cellpadding="0" cellspacing="0" class="detbox-inner">
                            <tr>
                                <td width="7" height="41" align="left" valign="top">
                                    <img src="images/det-box-top-lft.gif" alt="" width="7" height="41" />
                                </td>
                                <td colspan="2" height="41" class="detbox-top" width="586px">
                                    <table width="100%">
                                        <tr>
                                            <td>
                                                Traceability Details
                                            </td>
                                            <td width="10px">
                                                <asp:ImageButton ID="ConfirmPopupCloseImageButton" AlternateText="Close" runat="server"
                                                    ImageUrl="~/images/del-icon.gif" OnClick="ConfirmPopupCloseImageButton_Click" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                                <td width="7" height="41" align="left" valign="top">
                                    <img src="images/det-box-top-rht.gif" alt="" width="7" height="41" />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                            <%--<div class="packageview shadow">--%>
                            <table class="table-left-right-border" width="100%" cellpadding="0" cellspacing="3"
                                border="0">
                                <tr>
                                    <td>
                                        <table width="100%">
                                            <tr id="traceinfo" runat="server">
                                                <td>
                                                    Instrument
                                                    </td>
                                                <td>
                                                    <asp:Label ID="lblinstrument" runat="server" Text=""></asp:Label>
                                                </td>
                                                </tr>
                                            <tr>
                                                <td>
                                                    Make
                                                </td>
                                                <td>
                                                   <asp:Label ID="lblmake" runat="server" Text=""></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    Model
                                                </td>
                                                <td>
                                                    <asp:Label ID="lblmodel" runat="server" Text=""></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    Serial No
                                                </td>
                                                <td>
                                                    <asp:Label ID="lblserno" runat="server" Text=""></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    Tracibility Call Due
                                                </td>
                                                <td>
                                                    <asp:Label ID="lblcalldue" runat="server" Text=""></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    Reference
                                                </td>
                                                <td>
                                                    <asp:Label ID="lblref" runat="server" Text=""></asp:Label>
                                                </td>
                                            </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                                    </td>
                                
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <table class="table-left-right-border" width="100%" cellpadding="0" cellspacing="3"
                                        border="0">
                                        <tr>
                                            <td>
                                                <strong>
                                                    <asp:Label ID="lblConfirmation" runat="server" Text=""></asp:Label></strong>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                                <asp:Button ID="btnConfirmYes" runat="server" Text="Ok" OnClick="btnConfirmYes_Click"
                                                    CssClass="button-link" />&nbsp;
                                               
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td width="7" height="25" align="left" valign="top">
                                    <img src="images/det-box-btm-lft.gif" alt="" width="7" height="25" />
                                </td>
                                <td align="left" valign="middle" class="detbox-btm" colspan="2">
                                </td>
                                <td width="7" align="right" valign="top">
                                    <img src="images/det-box-btm-rht.gif" alt="" width="7" height="25" />
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:Panel>
            
    
            <cc1:ModalPopupExtender ID="ConfirmationModalPopupExtender" runat="server" PopupControlID="ConfirmationPopupPanel"
                TargetControlID="DevicesPopupButton" BackgroundCssClass="modalBackground" CancelControlID=""
                OkControlID="" X="400" Y="400" Drag="true" PopupDragHandleControlID="ConfirmationPopupPanel" />
   
</asp:Content>

