<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin.master" CodeFile="CreateReport.aspx.cs" Inherits="CreateReport" %>

    <asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
  .hosp_class{Width:200px} 
  .comp_class{width:200px;}
  .mod_class{width:200px;}
  .prod_class{width:200px;}
  .dev_class{width:200px;}
</style>
   
    <script src="js/jquery-1.8.3.js"></script>
    <script src="js/jquery-ui-1.9.2.js"></script>
    <link href="css/jquery-ui.css" rel="stylesheet" />
   <link type="text/css" href="css/ui-lightness/jquery-ui-1.8.19.custom.css" rel="stylesheet" />
<script type="text/javascript">
    $(function () {
        $("#<%=txtdateofcalib.ClientID%>").datepicker();
    });
</script>
        <script type="text/javascript">
            $(function () {
                $("#<%=txtduedate.ClientID%>").datepicker();
    });
</script>
         <script type="text/javascript">
             $(function () {
                 $("#<%=txtdateofreceipt.ClientID%>").datepicker();
            });
</script>
<style type="text/css">
.ui-datepicker { font-size:8pt !important}
    .auto-style1 {
        width: 100%;
    }
  
</style>
        <link href="Styles_ecom/bomtv.css" rel="stylesheet" />
        <link href="Styles_ecom/ecom.css" rel="stylesheet" />
    </asp:Content>


    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       
         <div>
             <table>
                 <tr>
                     <td>
                         <table>
                             <tr>
                     <td><h3>Report Info</h3></td>
                 </tr>
                 <tr>
                     <td>Report No.</td>
                     <td><asp:TextBox ID="txtreportno" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Date of Calibration</td>
                     <td><asp:TextBox ID="txtdateofcalib" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Calibration Due Date</td>
                     <td><asp:TextBox ID="txtduedate" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 
                         </table>
                     </td>
                     <td>
                         <table>
                              <tr>
                     <td><h3>Customer Info</h3></td>
                 </tr>
                 <tr>
                     <td>Name and Address of Organization</td>
                     <td>
                         <asp:DropDownList ID="ddhospitalname" Width="200px" runat="server">
                             <asp:ListItem>--select Hospital Name--</asp:ListItem>
                         </asp:DropDownList></td>
                 </tr>
                 <tr>
                     <td>Reference and Date</td>
                     <td><asp:TextBox ID="txtreferencedate" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Date of Receipt of item</td>
                     <td><asp:TextBox ID="txtdateofreceipt" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                         </table>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style3">
                         <table>
                             <tr>
                     <td><h3>Product Info</h3></td>
                 </tr>
                 <tr>
                     <td>Product Name</td>
                     <td><asp:TextBox ID="txtproductname" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Manufactured by</td>
                     <td><asp:TextBox ID="txtmanuf" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Model</td>
                     <td><asp:TextBox ID="txtmodel" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Serial No</td>
                     <td><asp:TextBox ID="txtserialno" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Barcode ID</td>
                     <td><asp:TextBox ID="txtbarcode" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Biomedical Product ID</td>
                     <td><asp:TextBox ID="txtbiomedical" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Supply</td>
                     <td><asp:TextBox ID="txtsupply" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Power Rating</td>
                     <td><asp:TextBox ID="txtpower" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Device Type</td>
                     <td><asp:TextBox ID="txtdevicetype" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Device Classification</td>
                     <td><asp:TextBox ID="txtdeviceclass" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Location</td>
                     <td><asp:TextBox ID="txtlocation" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Condition of Item</td>
                     <td><asp:TextBox ID="txtcondition" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Test Done</td>
                     <td><asp:CheckBox ID="ch_elect" runat="server" Text="Electrical Safety" />
                         <asp:CheckBox ID="ch_perf" runat="server" Text="Performance Analysis" /></td>
                 </tr>
                         </table>
                     </td>
                     <td>
                         <table>
                             <tr>
                     <td colspan="2"><h3>Environmental Condition of Measurement</h3></td>
                 </tr>
                 <tr>
                     <td>Temperature</td>
                     <td><asp:TextBox ID="txttemperature" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Relative Humidity</td>
                     <td><asp:TextBox ID="txtrelative" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Ambient Barometric Pressure</td>
                     <td><asp:TextBox ID="txtambient" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                         </table>
                          <table>
                             <tr>
                     <td colspan="2"><h3>Traceability Details of Instrument Used for Testing</h3></td>
                 </tr>
                 <tr>
                     <td>Name of Instrument</td>
                     <td><asp:TextBox ID="txtinstrument" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Make</td>
                     <td><asp:TextBox ID="txtmake" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Model</td>
                     <td><asp:TextBox ID="txtmodeltrace" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Serial No.</td>
                     <td><asp:TextBox ID="txtserialnotrace" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Traceability Cal Due</td>
                     <td><asp:TextBox ID="txttracebility" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Reference</td>
                     <td><asp:TextBox ID="txtracerefer" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox></td>
                 </tr>
                        </table>
                     </td>
                 </tr>
                <tr>
                    <td colspan="2">
          <table>
                 <tr>
                     <td><h3>Calibration Status</h3></td>
                 </tr>
                  <tr>
                   
                     <td colspan="6">
                         <asp:CheckBox ID="chkmanu" runat="server" Text="Manufacture Specification" />
                         <asp:CheckBox ID="chkuser" runat="server" Text="User Specification" />
                         <asp:CheckBox ID="chkwithin" runat="server" Text="Within Specification" />
                         <asp:CheckBox ID="chkout" runat="server" Text="Out of Specification" />
                         <asp:CheckBox ID="chkcalib" runat="server" Text="Calibration" />
                          <asp:CheckBox ID="chkelctrical" runat="server" Text="Electrical Safety" />
                         <asp:CheckBox ID="chkperform" runat="server" Text="Performance Analysis" />
                      </td>
                 </tr>
                  
                        </table>
                    </td>
                    
               </tr>
                 
                 <tr>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
                 </tr>
                 <tr>
                     <td colspan="2"><h3>Safety Test/Performance Analysis/Calibration</h3></td>
                     
                 </tr>
                 <tr>
                     <td class="auto-style3">Select Performance Test Name</td>
                     <td>
                         <asp:DropDownList ID="ddperftestname" runat="server" OnSelectedIndexChanged="ddperftestname_SelectedIndexChanged" AutoPostBack="true">
                             <asp:ListItem>--select Performance Test--</asp:ListItem>
                         </asp:DropDownList>
                     </td>
                 </tr>
                 <tr>
                     <td colspan="2">
                         <asp:DataList ID="performance_list" runat="server" BackColor="Gray" BorderColor="#666666"
            BorderStyle="None" BorderWidth="2px" CellPadding="3" CellSpacing="2" 
            Font-Names="Verdana" Font-Size="Small" GridLines="Both"  RepeatDirection="Horizontal">
           
                         <HeaderStyle BackColor="#333333" Font-Bold="True" Font-Size="Large" ForeColor="White"
                HorizontalAlign="Center" VerticalAlign="Middle" />
                             <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                             <ItemStyle BackColor="White" ForeColor="Black" BorderWidth="2px" />
                             <HeaderTemplate>
                                 
                             </HeaderTemplate>
                             <ItemTemplate>
                                 <asp:Label ID="lblcategory" runat="server" Text='<%# Eval("CategoryName") %>'></asp:Label>
                             </ItemTemplate>
                            
                             
                         </asp:DataList>
                         
                     </td>
                     
                 </tr>
                 <tr>
                     <td class="auto-style3">&nbsp;</td>
                     <td>&nbsp;</td>
                 </tr>
             </table>
             <asp:Button ID="btnsubmit" runat="server" Text="Save" OnClick="btnsubmit_Click" />
   
    </div>
        </asp:Content>
   
