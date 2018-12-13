<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Preventmain.ascx.cs" Inherits="controls_Preventmain" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<style type="text/css">
    .hosp_class {
        Width: 200px;
    }

    .comp_class {
        width: 200px;
    }

    .mod_class {
        width: 200px;
    }

    .prod_class {
        width: 200px;
    }

    .dev_class {
        width: 200px;
    }
    .txtwidth {
        width: 200px;
    }

    .padtop {
        padding-top: 20px;
    }
</style>

<asp:HiddenField ID="hospitalidhidden" runat="server" />
<asp:HiddenField ID="preventid_hidden" runat="server" />
<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
        <div style="padding-bottom: 10px; padding-top: 10px; padding-right: 10px; text-align: right;">
            <asp:Button ID="btnviewtest" runat="server" Text="" CssClass="button" OnClick="btnviewtest_Click" />
        </div>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="viewprevent" runat="server">
                <div style="width: 90%; background-color: white; padding-left: 10px; padding-top: 10px;">
                    <asp:GridView ID="grdPrevention" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" 
                        OnRowCommand="grdPrevention_RowCommand" OnRowDataBound="grdPrevention_RowDataBound" OnPageIndexChanging="grdPrevention_PageIndexChanging"
                        EmptyDataText="No Records Found" EmptyDataRowStyle-ForeColor="Red" Width="100%">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" CssClass="padtop"/>
                        <Columns>
                            <asp:BoundField DataField="ProductName" HeaderText="Product Name">
                                
                            </asp:BoundField>
                            <asp:BoundField DataField="Manufacture" HeaderText="Manufacture">
                                
                            </asp:BoundField>
                            <asp:BoundField DataField="Model" HeaderText="Model">
                                
                            </asp:BoundField>
                            <asp:BoundField DataField="DeviceType" HeaderText="DeviceType">
                                
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="Calibration Test">                                
                                <ItemTemplate>
                                    <asp:HiddenField ID="HiddenFieldPreventID" Value='<%# Eval("PreventID") %>' runat="server" />
                                    <asp:ListBox ID="lstcalibration" runat="server" CssClass="hosp_class"></asp:ListBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Edit/Delete">
                                
                                <ItemTemplate>
                                    <asp:ImageButton ID="lbedit" runat="server" CssClass="mgridlink"
                                        CommandName="U" ImageUrl="~/images/edit.png"
                                        ToolTip="Edit Test" CommandArgument='<%# Eval("PreventID") %>'></asp:ImageButton>
                                    <asp:ImageButton ID="lbdelete" runat="server" CssClass="mgridlink" CommandName="D"
                                        OnClientClick="return confirm('Are you sure you want to delete this Test Case?')"
                                        ToolTip="Delete Test" ImageUrl="~/images/del-icon.gif" CommandArgument='<%# Eval("PreventID") %>'></asp:ImageButton>
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
            </asp:View>
            <asp:View ID="addprevent" runat="server">
                <div class="content_box align_left shadow round_corner5 colwidth975" style="min-height: 600px;">
                    <table class=colwidth975>
                        <tr>
                            <th>
                                Preventive Maintenance Information
                            </th>
                        </tr>
                    </table>
                    <table cellpadding="5" cellspacing="5" style="width:75%;">
                        
                        <tr>
                            <td><span style="color: red;"></span>Hospital Name </td>
                            <td>
                                <asp:Label ID="lblHospitalName" runat="server" CssClass="hosp_class"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td><span style="color: red;"></span>Address </td>

                            <td>
                                <asp:Label ID="lblAddress" runat="server" CssClass="hosp_class"></asp:Label>
                            </td>
                        </tr>
                    </table>
                    <div class="clear"></div>
                    <table cellpadding="5" cellspacing="5" style="width:75%;">
                        <tr>
                            <td class="txtwidth">Product Name</td>
                            <td>
                                <asp:TextBox ID="txtproname" runat="server" CssClass="txtwidth" ></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Product Name Required" Display="Dynamic" ForeColor="Red"
                                    ControlToValidate="txtproname" ValidationGroup="pre"></asp:RequiredFieldValidator>
                                <ajaxToolkit:AutoCompleteExtender ID="txtproname_AutoCompleteExtender"
                                    runat="server"
                                    ServiceMethod="GetProductName"
                                    ServicePath="~/SurgchemService.asmx"
                                    TargetControlID="txtproname"
                                    EnableCaching="false"
                                    CompletionSetCount="1"
                                    MinimumPrefixLength="2"
                                    FirstRowSelected="false">
                                </ajaxToolkit:AutoCompleteExtender>

                            </td>
                        </tr>
                        <tr>
                            <td><span style="color: red;">*</span>Manufactured by</td>
                            <td>
                                <asp:TextBox ID="txtmanufact" runat="server" CssClass="hosp_class">
                                </asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" Display="Dynamic" ForeColor="Red"
                                    ErrorMessage="Manufacture Name required" ValidationGroup="pre" ControlToValidate="txtmanufact" />
                            </td>
                        </tr>
                        <tr>
                            <td><span style="color: red;">*</span>Model</td>
                            <td>
                                <asp:TextBox ID="txtModel" runat="server" CssClass="hosp_class">
                                </asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" Display="Dynamic" ForeColor="Red"
                                    ErrorMessage="Model Name required" ValidationGroup="pre" ControlToValidate="txtModel" />
                            </td>
                        </tr>
                        <tr>
                            <td><span style="color: red;">*</span>Device Type</td>
                            <td>
                                <asp:TextBox ID="txtdevicetype" runat="server" CssClass="hosp_class"></asp:TextBox>
                                
                            </td>
                        </tr>
                        <tr>
                            <td><span style="color: red;">*</span>Device Classification</td>
                            <td>
                                <asp:TextBox ID="txtdeviceclass" runat="server" CssClass="hosp_class"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Supply</td>
                            <td>
                                <asp:TextBox ID="txtsupply" runat="server" CssClass="hosp_class"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>Power Rating</td>
                            <td>
                                <asp:TextBox ID="txtpower" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td><span style="color: red;">*</span>Serial No</td>
                            <td>
                                <asp:TextBox ID="txtserialno" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td><span style="color: red;">*</span>Biomedical Product ID</td>
                            <td>
                                <asp:TextBox ID="txtbiomedical" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox>
                            </td>
                        </tr>


                        <tr>
                            <td><span style="color: red;">*</span>Location</td>
                            <td>
                                <asp:TextBox ID="txtlocation" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td><span style="color: red;">*</span>Condition of Item</td>
                            <td>
                                <asp:DropDownList ID="ddlcondition" runat="server" CssClass="hosp_class" ClientIDMode="Static">
                                    <asp:ListItem Text="No Visible Damage"></asp:ListItem>
                                    <asp:ListItem Text="Damage"></asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td><span style="color:red;">*</span>Description</td>
                            <td>
                                <asp:TextBox ID="txtdescrption" runat="server" CssClass="hosp_class" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="txtwidth">Calibration Test to be Done
                                
                            </td>
                            <td>
                                <asp:CheckBoxList ID="chktest" runat="server" RepeatDirection="Vertical"></asp:CheckBoxList>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                               <asp:Button ID="btnsave" runat="server" Text="Save" CssClass="button" OnClick="btnsave_Click" ValidationGroup="pre"/>&nbsp;
                               <asp:Button ID="btncancel" runat="server" Text="Cancel" CssClass="button" OnClick="btncancel_Click"/>

                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                    </table>
                </div>
            </asp:View>
        </asp:MultiView>
    </ContentTemplate>
</asp:UpdatePanel>
