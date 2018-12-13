<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Add_Report.ascx.cs" Inherits="controls_Add_Report" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>
<link rel="stylesheet" href="http://code.jquery.com/ui/1.9.2/themes/base/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.8.3.js" type="text/javascript"></script>
    <script src="http://code.jquery.com/ui/1.9.2/jquery-ui.js" type="text/javascript"></script>
 <link href="css/jquery-autocomplete.css" rel="stylesheet" />
   
    <script src="Scripts/jquery-1.4.2.min.js"></script>
    <script src="Scripts/jquery-1.8.1.min.js"></script>
<script type="text/javascript">
    $(document).ready(function () {
        searchhospital();
    });
    function searchhospital() {
        $(".hosp_class").autocomplete({
            source:function(request,response){
            $.ajax({
                type:"POST",
                contenttype:"application/json;charset=utf-8",
                url:"CreateReport.aspx/AutocompleteHospital",
                data:"{'HospitalName':'"+document.getElementById('txthospitalname').value+"'}",
                datatype:"json",
                success:function(data){
                    response(data.d);
                },
                error:function(result){
                    alert("Error");
                }
            });
    }
    });
    }
    
</script>
 <div>
     <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <h2>Add Report</h2>
        <table class="auto-style1">
            <tr>
                <td>Name and Address of Organization</td>
                <td><asp:TextBox ID="txthospitalname" runat="server" CssClass="hosp_class"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Barcode No.</td>
                <td>
                    <asp:TextBox ID="txtbarcode" runat="server"></asp:TextBox>
                    
                </td>
                 <td>Product Serial No.</td>
                <td>
                    <asp:TextBox ID="txtserialno" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>Product Name</td>
                <td>
                    <asp:DropDownList ID="drpproduct" runat="server"></asp:DropDownList>

                </td>
                 <td>Company</td>
                <td>
                    <asp:DropDownList ID="drpcompany" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
               <td>Model Name</td>
                <td>
                    <asp:DropDownList ID="drpmodel" runat="server"></asp:DropDownList>
                </td>
                <td>Device Classification</td>
                <td>
                    <asp:DropDownList ID="drpclassification" runat="server"></asp:DropDownList>
                    </td>
            </tr>
            <tr>
                 <td>BioMedical ID</td>
                <td>
                    <asp:TextBox ID="txtbiomedicalid" runat="server"></asp:TextBox>

                 </td>
                 <td>Location</td>
                <td>
                    <asp:TextBox ID="txtlocation" runat="server"></asp:TextBox>

                 </td>
            </tr>
            <tr>
                <td>
                    Tests Done
                </td>
                <td>
                    <asp:CheckBox ID="chkelectricaltest" runat="server" Text="Electrical Safety" />
                    <asp:CheckBox ID="chkperformancetest" runat="server" Text="Performance Test" />
                </td>
            </tr>
            </table>
    <div class="elect">
        <table>
            <tr>
                <td>
                    Select Electrical safety Report
                </td>
                <td>
                    <asp:FileUpload ID="flupld_electrical" runat="server" />
                </td>
            </tr>
        </table>
    </div>
    </div>