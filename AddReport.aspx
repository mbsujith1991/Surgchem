<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AddReport.aspx.cs" Inherits="AddReport" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<%@ Register Src="~/controls/AccTest_SyringePump.ascx" TagPrefix="uc1" TagName="AccTest_SyringePump" %>
<%@ Register Src="~/controls/BipolarMode.ascx" TagPrefix="uc1" TagName="BipolarMode" %>
<%@ Register Src="~/controls/BloodPressure.ascx" TagPrefix="uc1" TagName="BloodPressure" %>
<%@ Register Src="~/controls/ECG_defibrillator.ascx" TagPrefix="uc1" TagName="ECG_defibrillator" %>
<%@ Register Src="~/controls/EnergyOutput.ascx" TagPrefix="uc1" TagName="EnergyOutput" %>
<%@ Register Src="~/controls/MonoPolarMode.ascx" TagPrefix="uc1" TagName="MonoPolarMode" %>
<%@ Register Src="~/controls/PerfAnalysis_Anasthesiamachine.ascx" TagPrefix="uc1" TagName="PerfAnalysis_Anasthesiamachine" %>
<%@ Register Src="~/controls/PerfAnalysis_BiPap.ascx" TagPrefix="uc1" TagName="PerfAnalysis_BiPap" %>
<%@ Register Src="~/controls/PerformanceAnalysisOfVentilator.ascx" TagPrefix="uc1" TagName="PerformanceAnalysisOfVentilator" %>
<%@ Register Src="~/controls/PressureMeasurementForAutoclave.ascx" TagPrefix="uc1" TagName="PressureMeasurementForAutoclave" %>
<%@ Register Src="~/controls/SyncTime.ascx" TagPrefix="uc1" TagName="SyncTime" %>
<%@ Register Src="~/controls/TemperatureTestForAutoclative_FlashCycle.ascx" TagPrefix="uc1" TagName="TemperatureTestForAutoclative_FlashCycle" %>
<%@ Register Src="~/controls/TemperatureTestForAutoclave.ascx" TagPrefix="uc1" TagName="TemperatureTestForAutoclave" %>
<%@ Register Src="~/controls/TempMeasure_fluidwarmer.ascx" TagPrefix="uc1" TagName="TempMeasure_fluidwarmer" %>
<%@ Register Src="~/controls/SpO2usercontrol.ascx" TagPrefix="uc1" TagName="SpO2usercontrol" %>

<%--<%@ Register Src="~/controls/Temp_Measure.ascx" TagPrefix="uc1" TagName="Temp_Measure" %>--%>
<%@ Register Src="~/controls/TempMeasure_RadiantWarmer.ascx" TagPrefix="uc1" TagName="TempMeasure_RadiantWarmer" %>

<%@ Register Src="~/controls/ECG_Holtermachine.ascx" TagPrefix="uc1" TagName="ECG_Holtermachine" %>
<%@ Register Src="~/controls/PerfStudy_Anemometer.ascx" TagPrefix="uc1" TagName="PerfStudy_Anemometer" %>
<%@ Register Src="~/controls/TempMeasure_DigThermometer.ascx" TagPrefix="uc1" TagName="TempMeasure_DigThermometer" %>
<%@ Register Src="~/controls/Amplitude_Holtermachine.ascx" TagPrefix="uc1" TagName="Amplitude_Holtermachine" %>
<%@ Register Src="~/controls/PerfAnalysis_BPApparatus.ascx" TagPrefix="uc1" TagName="PerfAnalysis_BPApparatus" %>
<%@ Register Src="~/controls/Perfanalysis_weighingmachn.ascx" TagPrefix="uc1" TagName="Perfanalysis_weighingmachn" %>

<%@ Register Src="~/controls/TempMeasure_Waterbath.ascx" TagPrefix="uc1" TagName="TempMeasure_Waterbath" %>
<%@ Register Src="~/controls/Tempmeasure_deepfreezer.ascx" TagPrefix="uc1" TagName="Tempmeasure_deepfreezer" %>
<%@ Register Src="~/controls/LuxMeas_Otlight.ascx" TagPrefix="uc1" TagName="LuxMeas_Otlight" %>
<%@ Register Src="~/controls/Pulserate_measu_Pacemaker.ascx" TagPrefix="uc1" TagName="Pulserate_measu_Pacemaker" %>
<%@ Register Src="~/controls/Pulseampli_measure.ascx" TagPrefix="uc1" TagName="Pulseampli_measure" %>
<%@ Register Src="~/controls/Perf_Precisionbalance.ascx" TagPrefix="uc1" TagName="Perf_Precisionbalance" %>
<%@ Register Src="~/controls/TempMeasure_hotairover.ascx" TagPrefix="uc1" TagName="TempMeasure_hotairover" %>
<%@ Register Src="~/controls/TempMeasure_Incubator.ascx" TagPrefix="uc1" TagName="TempMeasure_Incubator" %>
<%@ Register Src="~/controls/Vaccummeasure_suctionapparatus.ascx" TagPrefix="uc1" TagName="Vaccummeasure_suctionapparatus" %>
<%@ Register Src="~/controls/RPM_measurement.ascx" TagPrefix="uc1" TagName="RPM_measurement" %>
<%@ Register Src="~/controls/Flow.ascx" TagPrefix="uc1" TagName="Flow" %>
<%@ Register Src="~/controls/Perfanalysis_micropipette.ascx" TagPrefix="uc1" TagName="Perfanalysis_micropipette" %>
<%@ Register Src="~/controls/Tempmeasure_freezer.ascx" TagPrefix="uc1" TagName="Tempmeasure_freezer" %>
<%@ Register Src="~/controls/Tempmeasure_middlechamber.ascx" TagPrefix="uc1" TagName="Tempmeasure_middlechamber" %>
<%@ Register Src="~/controls/Temp_hygrometer.ascx" TagPrefix="uc1" TagName="Temp_hygrometer" %>
<%@ Register Src="~/controls/Temp_Humidity.ascx" TagPrefix="uc1" TagName="Temp_Humidity" %>
<%@ Register Src="~/controls/TidalVolume.ascx" TagPrefix="uc1" TagName="TidalVolume" %>
<%@ Register Src="~/controls/Peep.ascx" TagPrefix="uc1" TagName="Peep" %>
<%@ Register Src="~/controls/PerfAnalysis_Flowmeter.ascx" TagPrefix="uc1" TagName="PerfAnalysis_Flowmeter" %>
<%@ Register Src="~/controls/Pressure_Nebuliser.ascx" TagPrefix="uc1" TagName="Pressure_Nebuliser" %>
<%@ Register Src="~/controls/Performance_CPAP.ascx" TagPrefix="uc1" TagName="Performance_CPAP" %>
<%@ Register Src="~/controls/TempMeasure_etosteriliser.ascx" TagPrefix="uc1" TagName="TempMeasure_etosteriliser" %>
<%@ Register Src="~/controls/PressureMeasure_ETO.ascx" TagPrefix="uc1" TagName="PressureMeasure_ETO" %>
<%@ Register Src="~/controls/PressMeas_Endoflator.ascx" TagPrefix="uc1" TagName="PressMeas_Endoflator" %>
<%@ Register Src="~/controls/Glucometer.ascx" TagPrefix="uc1" TagName="Glucometer" %>
<%@ Register Src="~/controls/flowrate_heparin.ascx" TagPrefix="uc1" TagName="flowrate_heparin" %>
<%@ Register Src="~/controls/flowrate_dialysismachine.ascx" TagPrefix="uc1" TagName="flowrate_dialysismachine" %>
<%@ Register Src="~/controls/TempMeasureMicrotome.ascx" TagPrefix="uc1" TagName="TempMeasureMicrotome" %>
<%@ Register Src="~/controls/Autoinjector_Boiler.ascx" TagPrefix="uc1" TagName="Autoinjector_Boiler" %>
<%@ Register Src="~/controls/JacketPressureGuage.ascx" TagPrefix="uc1" TagName="JacketPressureGuage" %>
<%@ Register Src="~/controls/ChamberPressureguage.ascx" TagPrefix="uc1" TagName="ChamberPressureguage" %>
<%@ Register Src="~/controls/Temperatureguage.ascx" TagPrefix="uc1" TagName="Temperatureguage" %>
<%@ Register Src="~/controls/CompressionPressureGuage.ascx" TagPrefix="uc1" TagName="CompressionPressureGuage" %>
<%@ Register Src="~/controls/Laminarflow.ascx" TagPrefix="uc1" TagName="Laminarflow" %>
<%@ Register Src="~/controls/Temperaturemeasurement.ascx" TagPrefix="uc1" TagName="Temperaturemeasurement" %>
<%@ Register Src="~/controls/Temperaturemeasure_Constant.ascx" TagPrefix="uc1" TagName="Temperaturemeasure_Constant" %>
<%@ Register Src="~/controls/Fio2test.ascx" TagPrefix="uc1" TagName="Fio2test" %>

<%@ Register Src="~/controls/RPMMeasurement_4_28_18.ascx" TagPrefix="uc1" TagName="RPMMeasurement_4_28_18" %>
<%@ Register Src="~/controls/PressureMeasurementForAutoclave132.ascx" TagPrefix="uc1" TagName="PressureMeasurementForAutoclave132" %>
<%@ Register Src="~/controls/Perfanalysis_micropipetteNew.ascx" TagPrefix="uc1" TagName="Perfanalysis_micropipetteNew" %>


<%--<%@ Register Src="~/controls/Fio2test_New.ascx" TagPrefix="uc1" TagName="Fio2test_New" %>--%>








<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Styles_ecom/bomtv.css" rel="stylesheet" />
    <link href="Styles_ecom/ecom.css" rel="stylesheet" />
    <script src="js/jquery-1.8.3.js"></script>
    <script src="js/jquery-ui-1.9.2.js"></script>
    <link href="css/jquery-ui.css" rel="stylesheet" />
   <link type="text/css" href="css/ui-lightness/jquery-ui-1.8.19.custom.css" rel="stylesheet" />
    <style type="text/css">
        .multiline {
        
        }
    </style>
    <script type="text/javascript">
        function Showalert() {
            alert('Call JavaScript function from codebehind');
        }
</script>
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
   <%-- <script type="text/javascript">
        $(function () {
            $("#<%=txttracebility.ClientID%>").datepicker();
            txtreferencedate
             });
</script>--%>
    <script type="text/javascript">
        $(function () {
            $("#<%=txtreferencedate.ClientID%>").datepicker();
            
        });
</script>
   
<style type="text/css">
.ui-datepicker { font-size:8pt !important}
    
</style>
    <style type="text/css">
            .hosp_class{Width:200px} 
            .comp_class{width:200px;}
            .mod_class{width:200px;}
            .prod_class{width:200px;}
            .dev_class{width:200px;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>--%>
    <asp:HiddenField ID="elect_hidden" runat="server" />
    <asp:HiddenField ID="hospitalid_hidden" runat="server" />
    <asp:HiddenField ID="perfid_hidden" runat="server" />
    <asp:HiddenField ID="reportid_hidden" runat="server" />
    <asp:HiddenField ID="utypeid_hidden" runat="server" />
    <asp:HiddenField ID="reportidmax_hidden" runat="server" />
    <asp:HiddenField ID="productidhidden" runat="server" />
    <asp:HiddenField ID="ecmidhidden" runat="server" />
    <asp:HiddenField ID="tracename" runat="server" />
    <asp:HiddenField ID="traceid_hidden" runat="server" />
    <asp:HiddenField ID="calibstatus_hidden" runat="server" />
    <asp:HiddenField ID="editreport_hidden" runat="server" />
    <asp:HiddenField ID="maxelectid" runat="server" />
    <asp:HiddenField ID="hospitalname" runat="server" />
    <asp:HiddenField ID="productname_hidden" runat="server" />
    <asp:HiddenField ID="checkboxelectrical" runat="server" />
    <asp:HiddenField ID="checkboxperform" runat="server" />
    <asp:HiddenField ID="perfidtesthidden" runat="server" />

    <div class="align_ight" style="width:300px;">
        <asp:Button ID="btneditreport" runat="server" Text="Edit Report" OnClick="btneditreport_Click" CssClass="button"/>&nbsp;
        <asp:Button ID="btnaddreport" runat="server" Text="Add Report" OnClick="btnaddreport_Click" CssClass="button"/>
    </div>
    <asp:MultiView ID="multiviewreport" runat="server" ActiveViewIndex="0">
        <asp:View ID="addreport" runat="server">
             <div class="content_box align_left shadow round_corner5 colwidth975">
        
        <table cellpadding="5" cellspacing="5">
            <tr>
                <th colspan="4">Report Information</th>
            </tr>
            <tr>
                <td><span style="color:red;">*</span>Report No:</td>
                <td>
                    <asp:TextBox ID="txtreportno" runat="server" CssClass="hosp_class" ClientIDMode="Static" 
                       AutoPostBack="true" OnTextChanged="txtreportno_TextChanged"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtreportno" ForeColor="Red"
                       Display="Dynamic" ErrorMessage="Report No required" ValidationGroup="report"></asp:RequiredFieldValidator>
                    <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtenderReportNo" TargetControlID="txtreportno" ValidChars="/" FilterType="Numbers, Custom, UppercaseLetters, LowercaseLetters" runat="server" />
                </td>
                <td><span style="color:red;">*</span>Date of Calibration</td>
                <td>
                    <asp:TextBox ID="txtdateofcalib" runat="server" CssClass="hosp_class" ClientIDMode="Static"
                        AutoPostBack="true" OnTextChanged="txtdateofcalib_TextChanged"></asp:TextBox>
                    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ForeColor="Red"
                        ControlToValidate="txtdateofcalib" ErrorMessage="Calibration Date required" ValidationGroup="report"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td><span style="color:red;">*</span>Barcode ID</td>

                <td><asp:TextBox ID="txtbarcode" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" Display="Dynamic" ForeColor="Red"
                             ErrorMessage="Barcode ID required" ValidationGroup="report" ControlToValidate="txtbarcode"/>
                    <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" TargetControlID="txtbarcode" ValidChars="/" FilterType="Numbers, Custom, UppercaseLetters, LowercaseLetters" runat="server" />
                     </td>
                
               
                <td><span style="color:red;">*</span>Calibration Due Date</td>
                <td>
                    <asp:TextBox ID="txtduedate" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox>
                    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="Dynamic" ForeColor="Red"
                        ErrorMessage="Calibration Due Date required" ValidationGroup="report" ControlToValidate="txtduedate"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
    </div>
    <div class="clear"></div>
    <div class="content_box align_left shadow  round_corner5 colwidth45">
        <table cellpadding="5" cellspacing="5">
            <tr>
                <th colspan="2">Customer Details</th>
            </tr>
            <tr>
                <td><span style="color:red;">*</span>Customer Name</td>
                <td>
                    <asp:DropDownList ID="ddhospitalname" Width="200px" runat="server" OnSelectedIndexChanged="ddhospitalname_SelectedIndexChanged" AutoPostBack="true">
                            
                    </asp:DropDownList>
                </td>
            </tr>
           
            <tr>
                <td><span style="color:red;">*</span>Customer Address</td>
                <td>
                    <asp:TextBox ID="txtaddress" runat="server" CssClass="hosp_class"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Display="Dynamic" ForeColor="Red"
                           ErrorMessage="Customer Address required" ValidationGroup="report" ControlToValidate="txtaddress">
                       </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td><span style="color:red;">*</span>Reference and Date</td>
                <td>
                    <asp:TextBox ID="txtreferencedate" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Display="Dynamic" ForeColor="Red"
                        ErrorMessage="Reference and Date required" ValidationGroup="report" ControlToValidate="txtreferencedate"/>
                </td>
            </tr>
            <tr>
                <td><span style="color:red;">*</span>Date of Receipt of Item</td>
                <td>
                    <asp:TextBox ID="txtdateofreceipt" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox>
                    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Display="Dynamic" ForeColor="Red"
                        ErrorMessage="Date of receipt of Item required" ValidationGroup="report" ControlToValidate="txtdateofreceipt"/>
                </td>
            </tr>
        </table>
    </div>
    <div class="content_box align_ight shadow round_corner5 colwidth45">
        <table cellpadding="5" cellspacing="5" style="height:205px;">
            <tr>
                <th colspan="2">Environmental Conditions of Measurements</th>
            </tr>
            <tr>
                <td><span style="color:red;">*</span>Temperature</td>
                <td>
                    <asp:TextBox ID="txttemperature" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" Display="Dynamic" ForeColor="Red"
                        ErrorMessage="Temperature required" ValidationGroup="report" ControlToValidate="txttemperature"/>
                </td>
            </tr>
            <tr>
                <td><span style="color:red;">*</span>Relative Humidity</td>
                <td>
                    <asp:TextBox ID="txtrelative" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" Display="Dynamic" ForeColor="Red"
                        ErrorMessage="Relative Humidity required" ValidationGroup="report" ControlToValidate="txtrelative"/>
                </td>
            </tr>
            <tr>
                <td><span style="color:red;">*</span>Ambient Barometric Pressure</td>
                <td>
                    <asp:TextBox ID="txtambient" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" Display="Dynamic" ForeColor="Red"
                        ErrorMessage="Ambient Pressure required" ValidationGroup="report" ControlToValidate="txtambient"/>
                </td>
            </tr>
        </table>
    </div>
    <div class="clear"></div>
    <div class="content_box align_left shadow round_corner5 colwidth45">
        <table cellpadding="5" cellspacing="5" style="height:650px;">
            <tr>
                <th colspan="2">Description of Device under Test</th>
            </tr>
            <tr>
                     <td><span style="color:red;">*</span>Product Name</td>
                     <td><asp:DropDownList ID="ddlproductname" runat="server" CssClass="hosp_class"
                         OnSelectedIndexChanged="ddlproductname_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" Display="Dynamic" ForeColor="Red"
                         ErrorMessage="Product Name required" ValidationGroup="report" ControlToValidate="ddlproductname" InitialValue="--Select ProductName--"/>
                     </td>
                 </tr>
                 <tr>
                     <td><span style="color:red;">*</span>Manufactured by</td>
                     <td><asp:DropDownList ID="ddlmanuf" runat="server" CssClass="hosp_class"
                         OnSelectedIndexChanged="ddlmanuf_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" Display="Dynamic" ForeColor="Red"
                        ErrorMessage="Manufacture Name required" ValidationGroup="report" ControlToValidate="ddlmanuf" InitialValue="--Select Company--"/>
                     </td>
                 </tr>
                 <tr>
                     <td><span style="color:red;">*</span>Model</td>
                     <td><asp:DropDownList ID="ddlmodel" runat="server" CssClass="hosp_class" ClientIDMode="Static"
                         OnSelectedIndexChanged="ddlmodel_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" Display="Dynamic" ForeColor="Red"
                             ErrorMessage="Model Name required" ValidationGroup="report" ControlToValidate="ddlmodel" InitialValue="--Select Model--"/>
                     </td>
                 </tr>
            <tr>
                     <td><span style="color:red;">*</span>Device Type</td>
                     <td><asp:DropDownList ID="ddlevicetype" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:DropDownList>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" Display="Dynamic" ForeColor="Red"
                             ErrorMessage="Device Type required" ValidationGroup="report" ControlToValidate="ddlevicetype" InitialValue="--Select Device Type"/>
                     </td>
                 </tr>
                 <tr>
                     <td><span style="color:red;">*</span>Device Classification</td>
                     <td><asp:DropDownList ID="ddldeviceclass" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:DropDownList>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" Display="Dynamic" ForeColor="Red"
                             ErrorMessage="Device Classification required" ValidationGroup="report" ControlToValidate="ddldeviceclass" InitialValue="--Select Classification--"/>
                     </td>
                 </tr>
             <tr>
                     <td>Supply</td>
                     <td><asp:TextBox ID="txtsupply" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox>

                     </td>
                 </tr>
                 <tr>
                     <td>Power Rating</td>
                     <td><asp:TextBox ID="txtpower" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox>

                     </td>
                 </tr>
                 <tr>
                     <td><span style="color:red;">*</span>Serial No</td>
                     <td><asp:TextBox ID="txtserialno" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" Display="Dynamic" ForeColor="Red"
                             ErrorMessage="Serial No required" ValidationGroup="report" ControlToValidate="txtserialno"/>
                     </td>
                 </tr>
                
                 <tr>
                     <td><span style="color:red;">*</span>Biomedical Product ID</td>
                     <td><asp:TextBox ID="txtbiomedical" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" Display="Dynamic" ForeColor="Red"
                             ErrorMessage="Biomedical Product ID required" ValidationGroup="report" ControlToValidate="txtbiomedical"/>
                     </td>
                 </tr>
                
                 
                 <tr>
                     <td><span style="color:red;">*</span>Location</td>
                     <td><asp:TextBox ID="txtlocation" runat="server" CssClass="hosp_class" ClientIDMode="Static"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" Display="Dynamic" ForeColor="Red"
                             ErrorMessage="Location required" ValidationGroup="report" ControlToValidate="txtlocation"/>
                     </td>
                 </tr>
                 <tr>
                     <td><span style="color:red;">*</span>Condition of Item</td>
                     <td><asp:DropDownList ID="ddlcondition" runat="server" CssClass="hosp_class" ClientIDMode="Static">
                         <asp:ListItem Text="No Visible Damage"></asp:ListItem>
                         <asp:ListItem Text="Damage"></asp:ListItem>
                         </asp:DropDownList>
                     </td>
                 </tr>
            
                 <tr>
                     <td>Test Done</td>
                     <td><asp:CheckBox ID="ch_elect" runat="server" Text="Electrical Safety" 
                        AutoPostBack="true" OnCheckedChanged="ch_elect_CheckedChanged" /><br />
                         <asp:CheckBox ID="ch_perf" runat="server" Text="Performance Analysis" 
                            AutoPostBack="true" OnCheckedChanged="ch_perf_CheckedChanged"/>
                     </td>
                 </tr>
        </table>
    </div>
            <div class="content_box align_ight shadow round_corner5 colwidth45">
                <table>
                    <tr>
                        <th colspan="2">Product Details</th>
                    </tr>
                    <tr>
                        <td>Product Name</td>
                        <td>
                            <asp:TextBox ID="txtproname" runat="server" CssClass="hosp_class"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Manufacture</td>
                        <td>
                            <asp:TextBox ID="txtmanu" runat="server" CssClass="hosp_class"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Model</td>
                        <td>
                            <asp:TextBox ID="txtmodel" runat="server" CssClass="hosp_class"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Device Type</td>
                        <td>
                            <asp:TextBox ID="txtdevtype" runat="server" CssClass="hosp_class"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Device Classification</td>
                        <td>
                            <asp:TextBox ID="txtdevclassification" runat="server" CssClass="hosp_class"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Supply</td>
                        <td>
                            <asp:TextBox ID="txtsupplydata" runat="server" CssClass="hosp_class"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Power Rating</td>
                        <td>
                            <asp:TextBox ID="txtpowerdate" runat="server" CssClass="hosp_class"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                 <td>
                     <asp:Button ID="btnsave" runat="server" Text="Save" CssClass="button" OnClick="btnsave_Click"/>&nbsp;
                     <asp:Button ID="btncancelproduct" runat="server" Text="Cancel" CssClass="button" OnClick="btncancelproduct_Click"/>
                 </td>
             </tr>
                </table>
            </div>
    <div class="content_box align_ight shadow round_corner5 colwidth45">
        <table cellpadding="5" cellspacing="5">
            <tr>
                <th colspan="2">Calibration Status</th>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="chkmanu" runat="server" Text="Manufacture Specification" />
                </td>
                <td>
                    <asp:CheckBox ID="chkuser" runat="server" Text="User Specification" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="chkwithin" runat="server" Text="Within Specification" />
                </td>
                <td>
                    <asp:CheckBox ID="chkout" runat="server" Text="Out of Specification" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="chkcalib" runat="server" Text="Calibration" />
                </td>
                <td>
                     <asp:CheckBox ID="chkelctrical" runat="server" Text="Electrical Safety" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:CheckBox ID="chkperform" runat="server" Text="Performance Analysis" />
                </td>
            </tr>
        </table>
    </div>
    <div class="content_box align_ight shadow round_corner5 colwidth45">
        <table>
            <tr>
                <th colspan="2">Tracaebility Details</th>
            </tr>
            <tr>
                <td colspan="2">
                     <asp:ListBox ID="lsttrace" SelectionMode="Multiple" runat="server" Rows="5" Width="250px" Font-Bold="true">

        </asp:ListBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ControlToValidate="lsttrace" InitialValue="--Select--"
            ErrorMessage="Please select Tracibility details" Display="Dynamic" ValidationGroup="report" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:Label ID="lblValues" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
       
      
    </div>
    <div class="clear"></div>
    <div class="align_left shadow round_corner5 colwidth975" id="safetydiv" runat="server" style="background-color:white;margin-left:1%;">

                 <table cellpadding="5" cellspacing="5" id="perf_table" runat="server">
            <tr>
                <th colspan="2">Performance Analysis</th>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblperf" runat="server" Text="Select Performance Test" Width="250px"></asp:Label>
                    
                    <asp:DropDownList ID="ddlperformance" runat="server" OnSelectedIndexChanged="ddlperformance_SelectedIndexChanged" AutoPostBack="true">
                       
                    </asp:DropDownList>
                    </td>
               
            </tr>
              <tr>
                  <td colspan="2">
                      <asp:UpdatePanel ID="updateperf" runat="server">
                          <ContentTemplate>

                          
                      <asp:MultiView ID="perfmulti" runat="server">
                          <asp:View ID="View19" runat="server"></asp:View>
                          <asp:View ID="View1" runat="server">
                              <uc1:ECG_defibrillator runat="server" ID="ECG_defibrillator" />
                          </asp:View>
                          <asp:View ID="View2" runat="server">
                              <uc1:SpO2usercontrol runat="server" ID="SpO2usercontrol" />
                          </asp:View>
                          <asp:View ID="View3" runat="server">
                              <uc1:BloodPressure runat="server" ID="BloodPressure" />
                          </asp:View>
                          <asp:View ID="View4" runat="server">
                             <uc1:AccTest_SyringePump runat="server" ID="AccTest_SyringePump" /> 
                          </asp:View>
                          <asp:View ID="View5" runat="server">
                              <uc1:Vaccummeasure_suctionapparatus runat="server" id="Vaccummeasure_suctionapparatus" />
                          </asp:View>
                          <asp:View ID="View6" runat="server">
                              <uc1:RPM_measurement runat="server" id="RPM_measurement" />
                          </asp:View>
                          <asp:View ID="View7" runat="server">
                              <uc1:Flow runat="server" id="Flow" />
                          </asp:View>
                          <asp:View ID="View8" runat="server">
                               <uc1:BipolarMode runat="server" ID="BipolarMode" />
                          </asp:View>
                          <asp:View ID="View9" runat="server">
                             <uc1:EnergyOutput runat="server" ID="EnergyOutput" />
                          </asp:View>
                          <asp:View ID="View10" runat="server">
                               <uc1:MonoPolarMode runat="server" ID="MonoPolarMode" />
                          </asp:View>
                          <asp:View ID="View11" runat="server">
                             <uc1:PerfAnalysis_Anasthesiamachine runat="server" ID="PerfAnalysis_Anasthesiamachine" />
                          </asp:View>
                          <asp:View ID="View12" runat="server">
                              <uc1:PerfAnalysis_BiPap runat="server" ID="PerfAnalysis_BiPap" />
                          </asp:View>
                          <asp:View ID="View13" runat="server">
                              <uc1:PerformanceAnalysisOfVentilator runat="server" ID="PerformanceAnalysisOfVentilator" />
                          </asp:View>
                          <asp:View ID="View14" runat="server">
                              <uc1:PressureMeasurementForAutoclave runat="server" ID="PressureMeasurementForAutoclave" />
                          </asp:View>
                          <asp:View ID="View15" runat="server">
                              <uc1:SyncTime runat="server" ID="SyncTime" />
                          </asp:View>
                          <asp:View ID="View16" runat="server">
                              <uc1:TemperatureTestForAutoclative_FlashCycle runat="server" ID="TemperatureTestForAutoclative_FlashCycle" />
                          </asp:View>
                          <asp:View ID="View17" runat="server">
                              <uc1:TemperatureTestForAutoclave runat="server" ID="TemperatureTestForAutoclave" />
                          </asp:View>
                          <asp:View ID="View18" runat="server">
                              <uc1:TempMeasure_fluidwarmer runat="server" ID="TempMeasure_fluidwarmer" />
                          </asp:View>
                          <asp:View ID="View20" runat="server">
                              <uc1:TempMeasure_RadiantWarmer runat="server" id="TempMeasure_RadiantWarmer" />
                          </asp:View>
                          <asp:View ID="View21" runat="server">
                              <uc1:Perfanalysis_micropipette runat="server" ID="Perfanalysis_micropipette" />
                          </asp:View>
                          <asp:View ID="View22" runat="server">
                              <uc1:ECG_Holtermachine runat="server" id="ECG_Holtermachine" />
                          </asp:View>
                          <asp:View ID="View23" runat="server">
                              <uc1:Amplitude_Holtermachine runat="server" ID="Amplitude_Holtermachine" />
                            
                          </asp:View>
                          <asp:View ID="View24" runat="server">
                              <uc1:PerfAnalysis_BPApparatus runat="server" ID="PerfAnalysis_BPApparatus" />
                          </asp:View>
                          <asp:View ID="View25" runat="server">
                              <uc1:Perfanalysis_weighingmachn runat="server" ID="Perfanalysis_weighingmachn" />
                          </asp:View>
                          <asp:View ID="View26" runat="server">
                              <uc1:PerfStudy_Anemometer runat="server" id="PerfStudy_Anemometer" />
                          </asp:View>
                          <asp:View ID="View27" runat="server">
                              <uc1:TempMeasure_DigThermometer runat="server" id="TempMeasure_DigThermometer" />
                          </asp:View>
                           <asp:View ID="View28" runat="server">
                               <uc1:TempMeasure_Waterbath runat="server" id="TempMeasure_Waterbath" />
                          </asp:View>
                           <asp:View ID="View29" runat="server">
                               <uc1:Tempmeasure_deepfreezer runat="server" id="Tempmeasure_deepfreezer" />
                          </asp:View>
                           <asp:View ID="View30" runat="server">
                               <uc1:LuxMeas_Otlight runat="server" id="LuxMeas_Otlight" />
                          </asp:View>
                           <asp:View ID="View31" runat="server">
                               <uc1:Pulserate_measu_Pacemaker runat="server" id="Pulserate_measu_Pacemaker" />
                          </asp:View>
                           <asp:View ID="View32" runat="server">
                               <uc1:Pulseampli_measure runat="server" id="Pulseampli_measure" />
                          </asp:View>
                           <asp:View ID="View33" runat="server">
                               <uc1:Perf_Precisionbalance runat="server" id="Perf_Precisionbalance" />
                          </asp:View>
                           <asp:View ID="View34" runat="server">
                               <uc1:TempMeasure_hotairover runat="server" id="TempMeasure_hotairover" />
                          </asp:View>
                          <asp:View ID="View35" runat="server">
                              <uc1:TempMeasure_Incubator runat="server" id="TempMeasure_Incubator" />
                          </asp:View>
                          <asp:View ID="View36" runat="server">
                              <uc1:Tempmeasure_freezer runat="server" ID="Tempmeasure_freezer" />
                          </asp:View>
                          <asp:View ID="View37" runat="server">
                              <uc1:Tempmeasure_middlechamber runat="server" ID="Tempmeasure_middlechamber" />
                          </asp:View>
                           <asp:View ID="View38" runat="server">
                               <uc1:Temp_hygrometer runat="server" ID="Temp_hygrometer" />
                          </asp:View>
                           <asp:View ID="View39" runat="server">
                               <uc1:Temp_Humidity runat="server" ID="Temp_Humidity" />
                          </asp:View>
                          <asp:View ID="View40" runat="server">
                              <uc1:TidalVolume runat="server" ID="TidalVolume" />
                          </asp:View>
                          <asp:View ID="View41" runat="server">
                              <uc1:Peep runat="server" ID="Peep" />
                          </asp:View>
                          <asp:View ID="View42" runat="server">
                              <uc1:PerfAnalysis_Flowmeter runat="server" ID="PerfAnalysis_Flowmeter" />
                          </asp:View>
                          <asp:View ID="View43" runat="server">
                              <uc1:Pressure_Nebuliser runat="server" id="Pressure_Nebuliser" />
                          </asp:View>
                          <asp:View ID="View44" runat="server">
                              <uc1:Performance_CPAP runat="server" ID="Performance_CPAP" />
                          </asp:View>
                          <asp:View ID="View45" runat="server">
                              <uc1:TempMeasure_etosteriliser runat="server" ID="TempMeasure_etosteriliser" />
                          </asp:View>
                          <asp:View ID="View46" runat="server">
                              <uc1:PressureMeasure_ETO runat="server" ID="PressureMeasure_ETO" />
                          </asp:View>
                          <asp:View ID="View47" runat="server">
                              <uc1:PressMeas_Endoflator runat="server" ID="PressMeas_Endoflator" />
                          </asp:View>
                          <asp:View ID="View48" runat="server">
                              <uc1:Glucometer runat="server" ID="Glucometer" />
                          </asp:View>
                          <asp:View ID="View49" runat="server">
                              <uc1:flowrate_heparin runat="server" id="flowrate_heparin" />
                          </asp:View>
                          <asp:View ID="View50" runat="server">
                              <uc1:flowrate_dialysismachine runat="server" ID="flowrate_dialysismachine" />
                          </asp:View>

                          <asp:View ID="View51" runat="server">
                              <uc1:TempMeasureMicrotome runat="server" ID="TempMeasureMicrotome" />
                          </asp:View>

                          <asp:View ID="View52" runat="server">
                              <uc1:Autoinjector_Boiler runat="server" ID="Autoinjector_Boiler" />
                          </asp:View>

                          <asp:View ID="View53" runat="server">
                              <uc1:JacketPressureGuage runat="server" ID="JacketPressureGuage" />
                          </asp:View>

                          <asp:View ID="View54" runat="server">
                              <uc1:ChamberPressureguage runat="server" ID="ChamberPressureguage" />
                          </asp:View>

                          <asp:View ID="View55" runat="server">
                              <uc1:Temperatureguage runat="server" ID="Temperatureguage" />
                          </asp:View>
                          <asp:View ID="View56" runat="server">
                              <uc1:CompressionPressureGuage runat="server" ID="CompressionPressureGuage" />
                          </asp:View>
                          <asp:View ID="View57" runat="server">
                              <uc1:Laminarflow runat="server" ID="Laminarflow" />
                          </asp:View>
                          <asp:View ID="View58" runat="server">
                              <uc1:Temperaturemeasurement runat="server" ID="Temperaturemeasurement" />
                          </asp:View>
                          <asp:View ID="View59" runat="server">
                              <uc1:Temperaturemeasure_Constant runat="server" ID="Temperaturemeasure_Constant" />
                          </asp:View>
                          <asp:View ID="View60" runat="server">
                              <uc1:Fio2test runat="server" ID="Fio2test" />
                              <%--<uc1:Fio2test_New runat="server" ID="Fio2test_New" />--%>
                          </asp:View>
                          <asp:View ID="View61" runat="server">
                              <uc1:RPMMeasurement_4_28_18 runat="server" ID="RPMMeasurement_4_28_18" />
                          </asp:View>
                          <asp:View ID="View62" runat="server">
                              <uc1:PressureMeasurementForAutoclave132 runat="server" ID="PressureMeasurementForAutoclave132" />
                          </asp:View>
                          <asp:View ID="View63" runat="server">
                              <uc1:Perfanalysis_micropipetteNew runat="server" ID="Perfanalysis_micropipetteNew" />
                          </asp:View>
                      </asp:MultiView>

                              </ContentTemplate>
                      </asp:UpdatePanel>
                  </td>
              </tr>
           </table>
                 <table cellpadding="5" cellspacing="5" id="elect_table" runat="server">
                     <tr>
                <th colspan="2">Electrical Safety Test</th>
            </tr>
            <tr id="trapplicable_speci" runat="server">
                <td colspan="2">
                    <asp:Label ID="lblapplicable" runat="server" Text="Applicable Specification" Width="250px"></asp:Label>
                    <asp:TextBox ID="txt_applicablespeci" runat="server" CssClass="hosp_class"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ErrorMessage="Enter Applicable specification"
                        Display="Dynamic" ControlToValidate="txt_applicablespeci" ValidationGroup="elect" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                </tr>
            <tr id="tr_standard" runat="server">
                <td>
                    <asp:Label ID="lblstnd" runat="server" Text="Standard" Width="250px"></asp:Label>
                    <asp:TextBox ID="txtstandard" runat="server" CssClass="hosp_class"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ErrorMessage="Enter Standard"
                        ControlToValidate="txtstandard" ValidationGroup="elect" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblelect" runat="server" Text="Select Electrical Safety Report" Width="250px"></asp:Label>
                    <asp:FileUpload ID="elctrical_upload" runat="server" Font-Bold="true" ForeColor="Black" />

                </td>
                
            </tr>
            
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblblank" runat="server" Text="" Width="250px"></asp:Label>
                    <asp:Button ID="btnupload" runat="server" OnClick="btnupload_Click"  
                                             Text="Upload" ValidationGroup="elect" CssClass="button-link"  />
                </td>
                
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
       
    </div>
    <div class="clear"></div>
            <div class="align_left shadow round_corner5 colwidth975" style="background-color:white;margin-left:1%;">
                <table  Width="100%">
                    <tr>
                        
                        <td>
                            Remarks<br />
                            <asp:TextBox id="txtremarks" runat="server" TextMode="MultiLine" Width="100%"  Height="200px" CssClass="multiline"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="clear"></div>
     <div class="content_wrap">
    <center>
        <table>
            <tr>
                
                <td>
                    <asp:Button ID="btnsavereport" runat="server" CssClass="button-link" OnClick="btnsavereport_Click" Text="Save Report" ValidationGroup="report" />
                </td> 
                <td>
                    <asp:Button ID="btncancel" runat="server" CssClass="button-link" OnClick="btncancel_Click" Text="Cancel" />
                </td>
            </tr>
        </table>
    </center>
</div>
        </asp:View>

        <asp:View ID="editreport" runat="server">
           
            <div class="clear" style="height:30px;"></div>
            <div id="Div1" class="content_wrap" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblsearchtype" runat="server" Text="Search Type " ForeColor="White"/>
                   
                </td>
                <td>
                    <asp:RadioButtonList ID="radiosearchtype" runat="server" OnSelectedIndexChanged="radiosearchtype_SelectedIndexChanged"
                        RepeatDirection="Horizontal" AutoPostBack="true" ForeColor="White">
                        <asp:ListItem Value="0" Selected="True">Report No</asp:ListItem>
                        <asp:ListItem Value="1">Hospital Name</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblsearchvalue" runat="server" Text="Values : " ForeColor="White"/></td>
                
                <td> <asp:TextBox ID="txtSearchString1" runat="server" CssClass="text" ></asp:TextBox>
                    <asp:TextBox ID="txtsearchcompany" CssClass="text" runat="server" Visible="false"></asp:TextBox>
                    <cc1:AutoCompleteExtender ID="txtsearchcompany_AutoCompleteExtender" runat="server" DelimiterCharacters="" Enabled="True" ServiceMethod="SearchHospital" TargetControlID="txtsearchcompany">
                    </cc1:AutoCompleteExtender>
                    <cc1:TextBoxWatermarkExtender ID="txtsearchcompany_TextBoxWatermarkExtender" runat="server" WatermarkText="Enter Hospital Name" Enabled="True" TargetControlID="txtsearchcompany">
                    </cc1:TextBoxWatermarkExtender>
                    <cc1:TextBoxWatermarkExtender ID="txtSearchString1_TextBoxWatermarkExtender" WatermarkText="Enter Report No" runat="server" Enabled="True" TargetControlID="txtSearchString1">
                    </cc1:TextBoxWatermarkExtender>
                    <cc1:AutoCompleteExtender ID="txtSearchString1_AutoCompleteExtender" runat="server" DelimiterCharacters="" Enabled="True" 
                       ServiceMethod="SearchCustomers" MinimumPrefixLength="2" CompletionInterval="100" EnableCaching="false" CompletionSetCount="10"
                         TargetControlID="txtSearchString1">
                    </cc1:AutoCompleteExtender>
                   
                </td>
                <td>
                    <asp:Button ID="btnSearchreport" runat="server" CssClass="button-link" OnClick="btnSearchreport_Click" Text="Search" />
                    &nbsp;
                    
                </td> 
            </tr>
        </table>
</div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" AllowPaging="True"
                 GridLines="None" DataKeyNames="Report_info_ID" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="50">

                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                
                <Columns>
                     <asp:TemplateField ControlStyle-Width="20px">
                    <ItemTemplate>
<asp:ImageButton ID="imgbtnEdit"  runat="server" ImageUrl="~/images/Edit.jpg"
    CommandArgument='<%# Bind("Report_info_ID") %>' ToolTip="Edit" Height="20px" Width="20px" OnClick="imgbtnEdit_Click"/>
<%--<asp:ImageButton ID="imgbtnDelete"  Text="Edit" runat="server" ImageUrl="~/images/delete.jpg" 
   CommandArgument='<%# Bind("EditReportid") %>' ToolTip="Delete" Height="20px" Width="20px" />--%>
</ItemTemplate>
                         </asp:TemplateField>
                    <asp:BoundField DataField="ReportNo" HeaderText="Report No."/>
                    <%--<asp:BoundField DataField="BarcodeNo" HeaderText="Barcode No" />--%>
                    <asp:BoundField DataField="Date_of_calibration" HeaderText="Calibration Date" />
                    <asp:BoundField DataField="Calibration_Due_on" HeaderText="Due Date" />
                    <asp:BoundField DataField="HospitalName" HeaderText="Hospital" />
                    <asp:BoundField DataField="Temperature" HeaderText="Temperature" />
                    <asp:BoundField DataField="Relative_Humidity" HeaderText="Relative Humidity" />
                    <asp:BoundField DataField="Ambient_Barometric_measure" HeaderText="Ambient Pressure" />
                    <asp:BoundField DataField="Productname" HeaderText="Product" />
                    <%--<asp:BoundField DataField="Company" HeaderText="Company" />--%>
                    <%--<asp:BoundField DataField="Model" HeaderText="Model" />--%>
                    <asp:BoundField DataField="Biomedical_ID" HeaderText="BiomedicalID" />
                    <asp:BoundField DataField="Serial_No" HeaderText="Serial No" />
                    
                    <%--<asp:BoundField DataField="Perf_TestName" HeaderText="PerformanceName" />--%>
                   
                </Columns>

                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Center"/>
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />

            </asp:GridView>
        </asp:View>
    </asp:MultiView>
   

    


</asp:Content>

