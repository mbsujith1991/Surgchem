<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Productviewforcustomer.ascx.cs" Inherits="controls_Productviewforcustomer" %>


<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%--<script type="text/javascript">
    $(document).keypress(function (e) {
        var code = (e.keyCode ? e.keyCode : e.which);
        if (code == 13) {
            $('#<%= btnSearchproduct.ClientID %>').click();
        }
    });
</script>--%>


<link href="../Styles_ecom/ecom.css" rel="stylesheet" />
<asp:HiddenField ID="hospid" runat="server" />
<asp:HiddenField ID="hospnamehidden" runat="server" />
  <div id="Div1" class="content_wrap" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblsearchtype" runat="server" Text="Search Type " ForeColor="Black"/>
                   
                </td>
                <td>
                    <asp:DropDownList ID="drpsearchtype" runat="server" OnSelectedIndexChanged="drpsearchtype_SelectedIndexChanged"
                        RepeatDirection="Horizontal" AutoPostBack="true" ForeColor="black">
                        
                        <asp:ListItem Value="0" >Product Name</asp:ListItem>
                        <asp:ListItem Value="1">Location</asp:ListItem>
                        <asp:ListItem Value="2">Calibration Date</asp:ListItem>
                        <asp:ListItem Value="3">Serial No</asp:ListItem>
                        <asp:ListItem Value="4">Biomedical ID</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblsearchvalue" runat="server" Text="Values : " ForeColor="Black"/></td>
                
                <td> <asp:TextBox ID="txtProductname" runat="server" CssClass="text" ></asp:TextBox>
                    <asp:TextBox ID="txtdateofcalib" runat="server" CssClass="text" Visible="false" ></asp:TextBox>
                    <cc1:CalendarExtender ID="txtdateofcalib_CalendarExtender" runat="server" Format="dd/MM/yyyy" Enabled="True" TargetControlID="txtdateofcalib">
                    </cc1:CalendarExtender>
                    <asp:TextBox ID="txtsearchlocation" CssClass="text" runat="server" Visible="false"></asp:TextBox>
                    <asp:TextBox ID="txtSearchBiomed" CssClass="text" runat="server" Visible="false"></asp:TextBox>
                    <asp:TextBox ID="txtSearchSerialNo" CssClass="text" runat="server" Visible="false"></asp:TextBox>
                   
                    <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender2" runat="server" WatermarkText="Enter Location" Enabled="True" 
                       WatermarkCssClass="watermarked" TargetControlID="txtsearchlocation">
                    </cc1:TextBoxWatermarkExtender>
                    <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" WatermarkText="Enter Product Name" runat="server" Enabled="True"
                        WatermarkCssClass="watermarked" TargetControlID="txtProductname">
                    </cc1:TextBoxWatermarkExtender>
                    <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender3" WatermarkText="Enter Biomedical ID" runat="server" Enabled="True"
                        WatermarkCssClass="watermarked" TargetControlID="txtSearchBiomed">
                    </cc1:TextBoxWatermarkExtender>
                    <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender4" WatermarkText="Enter Serial No" runat="server" Enabled="True"
                        WatermarkCssClass="watermarked" TargetControlID="txtSearchSerialNo">
                    </cc1:TextBoxWatermarkExtender>
                    
                   <cc1:AutoCompleteExtender ServiceMethod="GetProductName" MinimumPrefixLength="1"   ServicePath="~/SurgchemService.asmx"
                    CompletionInterval="10" EnableCaching="false" CompletionSetCount="1" TargetControlID="txtProductname"  
                    ID="AutoCompleteExtender1" runat="server" FirstRowSelected="false">  
                </cc1:AutoCompleteExtender> 

                    <cc1:AutoCompleteExtender ServiceMethod="GetLocation" MinimumPrefixLength="1"   ServicePath="~/SurgchemService.asmx"
                    CompletionInterval="10" EnableCaching="false" CompletionSetCount="1" TargetControlID="txtsearchlocation"  
                    ID="AutoCompleteExtender2" runat="server" FirstRowSelected="false">  
                </cc1:AutoCompleteExtender>
                    <cc1:AutoCompleteExtender ServiceMethod="GetBiomedicalID" MinimumPrefixLength="1"   ServicePath="~/SurgchemService.asmx"
                    CompletionInterval="10" EnableCaching="false" CompletionSetCount="1" TargetControlID="txtSearchBiomed"  
                    ID="AutoCompleteExtender3" runat="server" FirstRowSelected="false">  
                </cc1:AutoCompleteExtender>
                    <cc1:AutoCompleteExtender ServiceMethod="GetSerialNo" MinimumPrefixLength="1"   ServicePath="~/SurgchemService.asmx"
                    CompletionInterval="10" EnableCaching="false" CompletionSetCount="1" TargetControlID="txtSearchSerialNo"  
                    ID="AutoCompleteExtender4" runat="server" FirstRowSelected="false">  
                </cc1:AutoCompleteExtender>
                </td>
                <td>
                    <asp:Button ID="btnSearchreport" runat="server" CssClass="button-link" OnClick="btnSearchreport_Click" Text="Search" />
                    &nbsp;
                    
                </td> 
            </tr>
        </table>
</div>
<div style="width:95%;">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="Report_info_ID" 
        AllowPaging="true" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="50" 
        OnSelectedIndexChanged="GridView1_SelectedIndexChanged">

        <Columns>
             <asp:TemplateField>
                     <HeaderStyle Height="30px" />
                     <HeaderTemplate>Hospital Name</HeaderTemplate>
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblhospname" runat="server" Text='<%# Eval("HospitalName") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                          <asp:TextBox ID="txthospname" runat="server" Text='<%# Eval("HospitalName") %>' Width="140px"></asp:TextBox>
                     </EditItemTemplate>
                     <FooterTemplate>
                         <asp:TextBox ID="txthospnamefooter" runat="server" Text='<%# Eval("HospitalName") %>' Width="140px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvproduct" runat="server" ControlToValidate="txtproductfooter" Text="*" ValidationGroup="addproduct"/>
                     </FooterTemplate>
                 </asp:TemplateField>
            <asp:TemplateField>
                     <HeaderStyle Height="30px" />
                     <HeaderTemplate>Report No</HeaderTemplate>
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:LinkButton ID="lnkreportno" runat="server" Text='<%# Eval("Barcode_ID") %>' CommandName="Select"></asp:LinkButton>
<%--                         <asp:Label ID="lblreportno" runat="server" Text='<%# Eval("ReportNo") %>'></asp:Label>--%>
                     </ItemTemplate>
                     
                 </asp:TemplateField>
              <asp:TemplateField>
                     <HeaderStyle Height="30px" />
                     <HeaderTemplate>Product Name</HeaderTemplate>
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblproduct" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                     </ItemTemplate>
                   
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Manufacture">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblmanufacture" runat="server" Text='<%# Eval("Company") %>'></asp:Label>
                     </ItemTemplate>
                     
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Model Name">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblmodel" runat="server" Text='<%# Eval("Model") %>'></asp:Label>
                     </ItemTemplate>
                     
                 </asp:TemplateField>
                 <%--<asp:TemplateField HeaderText="Device Type">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lbldevtype" runat="server" Text='<%# Eval("Device_Type") %>'></asp:Label>
                     </ItemTemplate>
                    
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Device Classification">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lbldevclassi" runat="server" Text='<%# Eval("Device_Classification") %>'></asp:Label>
                     </ItemTemplate>
                    
                 </asp:TemplateField>
        <asp:TemplateField HeaderText="Supply">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblsupply" runat="server" Text='<%# Eval("Supply") %>'></asp:Label>
                     </ItemTemplate>
                    
                 </asp:TemplateField>--%>
             <asp:TemplateField HeaderText="Biomedical ID">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblsupply" runat="server" Text='<%# Eval("Biomedical_ID") %>'></asp:Label>
                     </ItemTemplate>
                    
                 </asp:TemplateField>
             <asp:TemplateField HeaderText="Calibration Date">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblcalibdate" runat="server" Text='<%# Eval("Date_of_calibration") %>'></asp:Label>
                     </ItemTemplate>
                     <%--<EditItemTemplate>
                         <asp:TextBox ID="txtsupply" runat="server" Text='<%# Eval("Supply") %>' Width="140px"></asp:TextBox>
                     </EditItemTemplate>
                     <FooterTemplate>
                          <asp:TextBox ID="txtsupplyfooter" runat="server" Text='<%# Eval("Supply") %>' Width="140px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvsupply" runat="server" ControlToValidate="txtsupplyfooter" Text="*" ValidationGroup="addproduct"/>
                     </FooterTemplate>--%>
                 </asp:TemplateField>
        <asp:TemplateField HeaderText="Serial No">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lblslno" runat="server" Text='<%# Eval("Serial_No") %>'></asp:Label>
                     </ItemTemplate>
                     
                 </asp:TemplateField>
            <asp:TemplateField HeaderText="Location">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Label ID="lbllocation" runat="server" Text='<%# Eval("Location") %>'></asp:Label>
                     </ItemTemplate>
                     
                 </asp:TemplateField>
            <asp:TemplateField HeaderText="Prevent Maintenance">
                     <ItemStyle  HorizontalAlign="Center" />
                     <ItemTemplate>
                         <asp:Button ID="lnkprevent" runat="server" CommandArgument='<%# Eval("Report_info_ID") %>' Text="Add" OnClick="lnkprevent_Click"></asp:Button>
                     </ItemTemplate>
                     
                 </asp:TemplateField>
            
        </Columns>
        <EmptyDataTemplate>No Records Found</EmptyDataTemplate>
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    <asp:Label ID="lblerror" runat="server" Text="" Visible="false"></asp:Label>
</div>
