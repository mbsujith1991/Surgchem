<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AddTestCase.aspx.cs" Inherits="AddTestCase" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:HiddenField ID="utypeid_hidden" runat="server" />
    <asp:HiddenField ID="testidhidden" runat="server" />
    <asp:HiddenField ID="hospidhidden" runat="server" />
    <div>
        <asp:Button ID="btnviewreport" runat="server" Text="View Report" CssClass="button"
            OnClick="btnviewreport_Click" Font-Size="Small" BackColor="#D8D8D8" ForeColor="Black" />&nbsp;
         <asp:Button ID="btnprodview" runat="server" Text="Product View" CssClass="button" Font-Size="Small" BackColor="#D8D8D8"
             OnClick="btnprodview_Click" ForeColor="Black" />&nbsp;

         <asp:Button ID="btnaddtestcases" runat="server" Text="Calibration Test" CssClass="button"
             OnClick="btnaddtestcases_Click" Font-Size="Small" BackColor="#003366" ForeColor="Yellow" />&nbsp;

         <asp:Button ID="btnprevent" runat="server" Text="Preventive Maintenance" CssClass="button"
             OnClick="btnprevent_Click" Font-Size="Small" BackColor="#D8D8D8" ForeColor="Black" />&nbsp;
         
    </div>
    <div class="clear"></div>
    <h3><b><span style="color:white;">Calibration Test</span> </b></h3>
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="1">
        <asp:View ID="addtest" runat="server">
            
            <div style="padding-bottom:10px;text-align:right">
                <asp:Button ID="btnviewtest" runat="server" Text="View Test" CssClass="button" OnClick="btnviewtest_Click" />
            </div>
            <div style="width: 100%; background-color: white; padding-left: 100px; padding-bottom: 50px;">
                <table>
                    <tr>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <th colspan="2">
                            <h3>Add Calibration Test</h3>
                        </th>
                    </tr>
                    <tr>
                        <td>Enter Test Name
                        </td>
                        <td>
                            <asp:TextBox ID="txttestname" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Description</td>
                        <td>
                            <asp:TextBox ID="txtdescrption" TextMode="MultiLine" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="btnsave" runat="server" Text="Save" CssClass="button" OnClick="btnsave_Click" />&nbsp;&nbsp;
                    <asp:Button ID="btncancel" runat="server" Text="Cancel" CssClass="button" OnClick="btncancel_Click" />
                        </td>
                    </tr>
                </table>
            </div>
            <div class="clear"></div>
        </asp:View>
        <asp:View ID="viewtest" runat="server">
            <div style="padding-bottom:10px;text-align:right">
                <asp:Button ID="btnaddtest" runat="server" Text="Add Test" CssClass="button" OnClick="btnaddtest_Click" />
            </div>
            <div style="width: 100%; background-color: white; padding-left: 100px;padding-top:10px;">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" Width="90%"
                    EmptyDataText="No Records Found" EmptyDataRowStyle-ForeColor="Red" GridLines="None" OnRowCommand="GridView1_RowCommand">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="TestName" HeaderText="Test Name">
                            <ItemStyle Width="30%" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Description" HeaderText="Description">
                            <ItemStyle Width="30%" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Edit/Delete">
                            <ItemStyle Width="10%" />
                            <ItemTemplate>
                                <asp:ImageButton ID="lbedit" runat="server" CssClass="mgridlink"
                                    CommandName="U" ImageUrl="~/images/edit.png"
                                    ToolTip="Edit Test" CommandArgument='<%# Eval("TestID") %>'></asp:ImageButton>
                                <asp:ImageButton ID="lbdelete" runat="server" CssClass="mgridlink" CommandName="D"
                                    OnClientClick="return confirm('Are you sure you want to delete this Test Case?')"
                                    ToolTip="Delete Test" ImageUrl="~/images/del-icon.gif" CommandArgument='<%# Eval("TestID") %>'></asp:ImageButton>
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
    </asp:MultiView>
</asp:Content>

