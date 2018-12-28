<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="EditReport.aspx.cs" Inherits="EditReport" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Src="~/Perf Control Views/View_Perf_AnasthesiaMachine.ascx" TagPrefix="uc1" TagName="View_Perf_AnasthesiaMachine" %>
<%@ Register Src="~/Perf Control Views/View_Monopolarmode.ascx" TagPrefix="uc1" TagName="View_Monopolarmode" %>
<%@ Register Src="~/Perf Control Views/View_Energyoutput.ascx" TagPrefix="uc1" TagName="View_Energyoutput" %>
<%@ Register Src="~/Perf Control Views/View_Bipolarmode.ascx" TagPrefix="uc1" TagName="View_Bipolarmode" %>
<%@ Register Src="~/Perf Control Views/View_ECG_Deferibrillator.ascx" TagPrefix="uc1" TagName="View_ECG_Deferibrillator" %>
<%@ Register Src="~/Perf Control Views/View_Spo2.ascx" TagPrefix="uc1" TagName="View_Spo2" %>
<%@ Register Src="~/Perf Control Views/View_BloodPressure.ascx" TagPrefix="uc1" TagName="View_BloodPressure" %>
<%@ Register Src="~/Perf Control Views/View_Accuracytest.ascx" TagPrefix="uc1" TagName="View_Accuracytest" %>
<%@ Register Src="~/Perf Control Views/View_Pressure.ascx" TagPrefix="uc1" TagName="View_Pressure" %>
<%@ Register Src="~/Perf Control Views/View_TempMeasure.ascx" TagPrefix="uc1" TagName="View_TempMeasure" %>
<%@ Register Src="~/Perf Control Views/View_Volume.ascx" TagPrefix="uc1" TagName="View_Volume" %>
<%@ Register Src="~/Perf Control Views/View_PerfBiPap.ascx" TagPrefix="uc1" TagName="View_PerfBiPap" %>
<%@ Register Src="~/Perf Control Views/View_PerfVentilator.ascx" TagPrefix="uc1" TagName="View_PerfVentilator" %>
<%@ Register Src="~/Perf Control Views/View_PressureAutoclave.ascx" TagPrefix="uc1" TagName="View_PressureAutoclave" %>
<%@ Register Src="~/Perf Control Views/View_Synctime.ascx" TagPrefix="uc1" TagName="View_Synctime" %>
<%@ Register Src="~/Perf Control Views/View_Temp_Atflashcycle.ascx" TagPrefix="uc1" TagName="View_Temp_Atflashcycle" %>
<%@ Register Src="~/Perf Control Views/View_Temptest_autoclave.ascx" TagPrefix="uc1" TagName="View_Temptest_autoclave" %>
<%@ Register Src="~/Perf Control Views/View_TempFluidwarmer.ascx" TagPrefix="uc1" TagName="View_TempFluidwarmer" %>
<%@ Register Src="~/Perf Control Views/View_TempRadiantwarmer.ascx" TagPrefix="uc1" TagName="View_TempRadiantwarmer" %>

<%@ Register Src="~/Perf Control Views/View_ECGHolter.ascx" TagPrefix="uc1" TagName="View_ECGHolter" %>
<%@ Register Src="~/Perf Control Views/View_amplitudeHolter.ascx" TagPrefix="uc1" TagName="View_amplitudeHolter" %>
<%@ Register Src="~/Perf Control Views/View_PerfBPApparatus.ascx" TagPrefix="uc1" TagName="View_PerfBPApparatus" %>
<%@ Register Src="~/Perf Control Views/View_PerfWeighmachine.ascx" TagPrefix="uc1" TagName="View_PerfWeighmachine" %>
<%@ Register Src="~/Perf Control Views/View_PerfAnemometer.ascx" TagPrefix="uc1" TagName="View_PerfAnemometer" %>
<%@ Register Src="~/Perf Control Views/View_TempDigitalthermo.ascx" TagPrefix="uc1" TagName="View_TempDigitalthermo" %>
<%@ Register Src="~/Perf Control Views/View_TempWaterbath.ascx" TagPrefix="uc1" TagName="View_TempWaterbath" %>
<%@ Register Src="~/Perf Control Views/View_TempDeepfreezer.ascx" TagPrefix="uc1" TagName="View_TempDeepfreezer" %>
<%@ Register Src="~/Perf Control Views/View_Luxmeasure.ascx" TagPrefix="uc1" TagName="View_Luxmeasure" %>
<%@ Register Src="~/Perf Control Views/View_Pulserate.ascx" TagPrefix="uc1" TagName="View_Pulserate" %>
<%@ Register Src="~/Perf Control Views/View_PulseAmplitude.ascx" TagPrefix="uc1" TagName="View_PulseAmplitude" %>
<%@ Register Src="~/Perf Control Views/View_PrecisionBalance.ascx" TagPrefix="uc1" TagName="View_PrecisionBalance" %>
<%@ Register Src="~/Perf Control Views/View_Temphotair.ascx" TagPrefix="uc1" TagName="View_Temphotair" %>
<%@ Register Src="~/Perf Control Views/View_Tempincubator.ascx" TagPrefix="uc1" TagName="View_Tempincubator" %>
<%@ Register Src="~/Perf Control Views/View_Tempmeasure_freezer.ascx" TagPrefix="uc1" TagName="View_Tempmeasure_freezer" %>
<%@ Register Src="~/Perf Control Views/View_Tempmeasure_middlechamber.ascx" TagPrefix="uc1" TagName="View_Tempmeasure_middlechamber" %>
<%@ Register Src="~/Perf Control Views/View_flow.ascx" TagPrefix="uc1" TagName="View_flow" %>
<%@ Register Src="~/Perf Control Views/View_vaccum_suction.ascx" TagPrefix="uc1" TagName="View_vaccum_suction" %>
<%@ Register Src="~/Perf Control Views/View_RPMmeasure.ascx" TagPrefix="uc1" TagName="View_RPMmeasure" %>
<%@ Register Src="~/Perf Control Views/View_Temp_Hygrometer.ascx" TagPrefix="uc1" TagName="View_Temp_Hygrometer" %>
<%@ Register Src="~/Perf Control Views/View_HumidityHygro.ascx" TagPrefix="uc1" TagName="View_HumidityHygro" %>
<%@ Register Src="~/Perf Control Views/View_Perf_micropipette.ascx" TagPrefix="uc1" TagName="View_Perf_micropipette" %>
<%@ Register Src="~/Perf Control Views/View_TidalVolume.ascx" TagPrefix="uc1" TagName="View_TidalVolume" %>
<%@ Register Src="~/Perf Control Views/View_Peep.ascx" TagPrefix="uc1" TagName="View_Peep" %>
<%@ Register Src="~/Perf Control Views/View_Flowmeter.ascx" TagPrefix="uc1" TagName="View_Flowmeter" %>
<%@ Register Src="~/Perf Control Views/View_Nebuliser.ascx" TagPrefix="uc1" TagName="View_Nebuliser" %>
<%@ Register Src="~/Perf Control Views/View_PerformCpap.ascx" TagPrefix="uc1" TagName="View_PerformCpap" %>
<%@ Register Src="~/Perf Control Views/View_TempEtoSteriliser.ascx" TagPrefix="uc1" TagName="View_TempEtoSteriliser" %>
<%@ Register Src="~/Perf Control Views/View_PressureMeas_Eto.ascx" TagPrefix="uc1" TagName="View_PressureMeas_Eto" %>
<%@ Register Src="~/Perf Control Views/View_PresMeas_Endoflator.ascx" TagPrefix="uc1" TagName="View_PresMeas_Endoflator" %>
<%@ Register Src="~/Perf Control Views/View_Glucometer.ascx" TagPrefix="uc1" TagName="View_Glucometer" %>
<%@ Register Src="~/Perf Control Views/View_flowrate_heparin.ascx" TagPrefix="uc1" TagName="View_flowrate_heparin" %>
<%@ Register Src="~/Perf Control Views/View_flowrate_dialysis.ascx" TagPrefix="uc1" TagName="View_flowrate_dialysis" %>
<%@ Register Src="~/Perf Control Views/View_TempMeasmicrotome.ascx" TagPrefix="uc1" TagName="View_TempMeasmicrotome" %>
<%@ Register Src="~/Perf Control Views/View_Autoinjector_boiler.ascx" TagPrefix="uc1" TagName="View_Autoinjector_boiler" %>
<%@ Register Src="~/Perf Control Views/View_JacketPressureGuage.ascx" TagPrefix="uc1" TagName="View_JacketPressureGuage" %>
<%@ Register Src="~/Perf Control Views/View_ChamberPressureGuage.ascx" TagPrefix="uc1" TagName="View_ChamberPressureGuage" %>
<%@ Register Src="~/Perf Control Views/View_Temperatureguage.ascx" TagPrefix="uc1" TagName="View_Temperatureguage" %>
<%@ Register Src="~/Perf Control Views/View_CompressionGuage.ascx" TagPrefix="uc1" TagName="View_CompressionGuage" %>
<%@ Register Src="~/Perf Control Views/View_LaminarFlow.ascx" TagPrefix="uc1" TagName="View_LaminarFlow" %>
<%@ Register Src="~/Perf Control Views/View_Temperaturemeasurement.ascx" TagPrefix="uc1" TagName="View_Temperaturemeasurement" %>
<%@ Register Src="~/Perf Control Views/View_Temperaturemeasure_constant.ascx" TagPrefix="uc1" TagName="View_Temperaturemeasure_constant" %>
<%@ Register Src="~/Perf Control Views/View_FiO2.ascx" TagPrefix="uc1" TagName="View_FiO2" %>

<%@ Register Src="~/Perf Control Views/View_RPMMeasurement_4_28_18.ascx" TagPrefix="uc1" TagName="View_RPMMeasurement_4_28_18" %>
<%@ Register Src="~/Perf Control Views/View_PressureAutoclave132.ascx" TagPrefix="uc1" TagName="View_PressureAutoclave132" %>
<%@ Register Src="~/Perf Control Views/View_Perf_micropipetteNew.ascx" TagPrefix="uc1" TagName="View_Perf_micropipetteNew" %>


<%--<%@ Register Src="~/Perf Control Views/View_FiO2_New.ascx" TagPrefix="uc1" TagName="View_FiO2_New" %>--%>




<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="Styles_ecom/ecom.css" rel="stylesheet" />
    <link href="Styles_ecom/bomtv.css" rel="stylesheet" />
    <script type="text/javascript">
        function PrintPanel() {
            var panel = document.getElementById("<%=pnlprint.ClientID %>");
            var printWindow = window.open('', '', 'height=400,width=800');
            printWindow.document.write('<html><head><title></title>');
            printWindow.document.write('</head><body>');
            printWindow.document.write(panel.innerHTML);
            printWindow.document.write('</body></html>');
            printWindow.document.close();
            setTimeout(function () {
                printWindow.print();
            }, 500);
            return false;

        }
    </script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:HiddenField ID="reportid_hidden" runat="server" />
    <asp:HiddenField ID="perfid_hidden" runat="server" />
    <asp:HiddenField ID="category_hidden" runat="server" />
    <asp:HiddenField ID="productidhidden" runat="server" />
    <asp:HiddenField ID="Ecm_hidden" runat="server" />
    <asp:HiddenField ID="tracehidden" runat="server" />
    <asp:HiddenField ID="elect_hidden" runat="server" />
    <div id="Div1" class="align_ight" style="width: 400px; height: auto;" runat="server">
        <asp:Button ID="btnadd" runat="server" CssClass="button" Text="Add Report" OnClick="btnadd_Click" />
        &nbsp;
         <asp:Button ID="btnedit" runat="server" CssClass="button" Text="Edit Report" OnClick="btnedit_Click" />
        &nbsp;
         <asp:Button ID="btnprint" runat="server" Text="Print" CssClass="button" Visible="false"
             OnClientClick="return PrintPanel();"></asp:Button>


    </div>
    <div class="clear"></div>



    <asp:Panel ID="pnlprint" runat="server" CssClass="Section1" BackColor="White">
        <%-- print page1 div starts--%>


        <div style="width: 6.27in; padding-left: 10%; padding-right: 10%; padding-bottom: 5%;">
            <%--padding-top:1%;--%>
            <div class="content_box align_middle" style="font-weight: bold; width: 100%">
                <h3 align="center"><span>Report<br />
                    On<br />
                    <span style="text-decoration: underline;">Electrical Safety Test/Performance Analysis/Calibration
                    </span>
                </span></h3>
            </div>

            <div class="clear"></div>
            <div class="content_box round_corner5 align_middle " style="font-weight: bold; width: 100%; font-size: 8pt;">
                <table style="border: 1px #ccc solid; width: 100%;">

                    <tr>
                        <td>Report No:<asp:Label ID="lblreportno" runat="server"></asp:Label></td>

                        <td>Date of Calibration:
                    <br />
                            <br />
                            Calibration Due Date:
                        </td>
                        <td>
                            <asp:Label ID="lblcalibdate" runat="server"></asp:Label>
                            <br />
                            <br />
                            <asp:Label ID="lblduedate" runat="server"></asp:Label>
                        </td>
                        <td>Barcode ID:<asp:Label ID="lblpgno1" runat="server"></asp:Label></td>

                    </tr>

                </table>
            </div>
            <div class="clear"></div>
            <div style="height: 10px;"></div>
            <div class="clear"></div>
            <div class="content_box round_corner5 align_middle" style="font-weight: bold; font-size: 8pt; width: 100%">
                <span style="font-size: 11pt; font-weight: bold;">1.1</span> &nbsp;&nbsp;
        <span style="font-size: 11pt; font-weight: bold;">CUSTOMER DETAILS</span>
                <table width="100%">

                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Width="30px" />Name of Organization
                    <br />
                            <asp:Label ID="Label3" runat="server" Width="30px"></asp:Label>Addresss</td>
                        <td></td>
                        <td>
                            <asp:Label ID="lblhospitalname" runat="server"></asp:Label><br />
                            <asp:Label ID="lblhospaddress" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Width="30px" />Reference and Date<br />
                            <asp:Label ID="Label5" runat="server" Width="30px" />Date of Receipt of Item
                        </td>
                        <td></td>
                        <td>
                            <asp:Label ID="lblreferencedate" runat="server"></asp:Label><br />
                            <asp:Label ID="lbldateofreceipt" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="clear"></div>
            <div style="height: 10px;"></div>
            <div class="clear"></div>
            <div class="align_middle" style="width: 100%; font-weight: bold;">
                <span style="font-size: 11pt; font-weight: bold;">1.2</span> &nbsp;&nbsp;
        <span style="font-size: 11pt; font-weight: bold;">DESCRIPTION OF DEVICE UNDER TEST(DUT)</span><br />
                <br />
                <%--<h4>
                    <asp:Label ID="Label1" runat="server" Text="1.2" Width="30px"></asp:Label>DESCRIPTION OF DEVICE UNDER TEST(DUT)</h4>--%>
                <asp:Label ID="Label7" runat="server" Width="30px" /><b>Nomenclature</b>
                <asp:Label ID="Label6" runat="server" Width="100px"></asp:Label>
                <asp:Label ID="lblnomenclature" runat="server" />
                <br />
            </div>
            <div class="clear"></div>
            <div class="content_box align_middle round_corner5" style="font-weight: bold; font-size: 8pt; border: 1px #ccc solid; width: 100%;">
                <table width="0" border="1" style="height: 30px; width: 100%;">
                    <tr>
                        <td style="width: 50px;">
                            <asp:Label ID="Label8" runat="server" Width="30px" />A</td>
                        <td>Manufactured by</td>
                        <td>
                            <asp:Label ID="lblmanufacture" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 50px;">
                            <asp:Label ID="Label10" runat="server" Width="30px" />B</td>
                        <td>Model</td>
                        <td>
                            <asp:Label ID="lblmodel" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 50px;">
                            <asp:Label ID="Label12" runat="server" Width="30px" />C</td>
                        <td>SerialNo</td>
                        <td>
                            <asp:Label ID="lblserialno" runat="server"></asp:Label></td>
                    </tr>

                    <tr>
                        <td style="width: 50px;">
                            <asp:Label ID="Label14" runat="server" Width="30px" />D</td>
                        <td>Biomedical Product ID</td>
                        <td>
                            <asp:Label ID="lblbiomedicalID" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 50px;">
                            <asp:Label ID="Label11" runat="server" Width="30px" />E</td>
                        <td>Supply</td>
                        <td>
                            <asp:Label ID="lblsupply" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 50px;">
                            <asp:Label ID="Label15" runat="server" Width="30px" />F</td>
                        <td>Device Type</td>
                        <td>
                            <asp:Label ID="lbltype" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 50px;">
                            <asp:Label ID="Label17" runat="server" Width="30px" />G</td>
                        <td>Device Classification</td>
                        <td>
                            <asp:Label ID="lblclassification" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 50px;">
                            <asp:Label ID="Label19" runat="server" Width="30px" />H</td>
                        <td>Power Rating</td>
                        <td>
                            <asp:Label ID="lblpowerrating" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 50px;">
                            <asp:Label ID="Label13" runat="server" Width="30px" />I</td>
                        <td>Location</td>
                        <td>
                            <asp:Label ID="lbllocation" runat="server"></asp:Label></td>
                    </tr>
                </table>
            </div>
            <div class="clear"></div>
            <div style="height: 10px;"></div>
            <div class="clear"></div>
            <div class="align_middle" style="width: 100%;">
                <span style="font-size: 11pt; font-weight: bold;">1.3</span> &nbsp;&nbsp;
        <span style="font-size: 11pt; font-weight: bold;">CONDITION OF ITEM WHEN RECEIVED</span><br />
                <br />

                <%--<h4>
                    <asp:Label ID="Label16" runat="server" Text="1.3" Width="30px"></asp:Label>CONDITION OF ITEM WHEN RECEIVED</h4>--%>
                <asp:Label ID="Label20" runat="server" Width="100px"></asp:Label>
                <asp:Label ID="lblconditionofitem" runat="server" />
            </div>
            <div class="clear"></div>
            <div style="height: 10px;"></div>
            <div class="clear"></div>
            <div class="align_middle" style="width: 100%; font-size: 8pt; font-weight: bold;">
                <span style="font-size: 11pt; font-weight: bold;">1.4</span> &nbsp;&nbsp;
        <span style="font-size: 11pt; font-weight: bold;">ENVIRONMENTAL CONDITION OF MEASUREMENTS</span><br />
                <br />
                <%--<h4>
                    <asp:Label ID="Label18" runat="server" Text="1.4" Width="30px"></asp:Label>ENVIRONMENTAL CONDITION OF MEASUREMENTS</h4>--%>
                <asp:Label ID="Label22" runat="server" Width="100px"></asp:Label>
                <asp:Label ID="Label23" runat="server" Text="a. Temperature" Width="250px" />
                <asp:Label ID="lbltemperature" runat="server" />
                <br />
                <asp:Label ID="Label21" runat="server" Width="100px"></asp:Label>
                <asp:Label ID="Label24" runat="server" Text="b. Relative Humidity" Width="250px" />
                <asp:Label ID="lblhumidity" runat="server" />
                <br />
                <asp:Label ID="Label26" runat="server" Width="100px"></asp:Label>
                <asp:Label ID="Label27" runat="server" Text="c. Ambient Barometric Pressure" Width="250px" />
                <asp:Label ID="lblambient" runat="server" />
            </div>
            <div class="clear"></div>
            <div style="height: 10px;"></div>
            <div class="clear"></div>

            <div class="content_box align_middle round_corner5 trace" style="font-weight: bold; font-size: 8pt; border: 1px #ccc solid;">
                <span style="font-size: 11pt; font-weight: bold;">1.5</span> &nbsp;&nbsp;
        <span style="font-size: 11pt; font-weight: bold;">CALIBRATION STATUS</span><br />
                <table width="100%" border="1" style="height: 30px; text-align: center;">
                    <tr>
                        <td>Manufacture's Specification</td>
                        <td>User's Specification</td>
                        <td>Within Specification</td>
                        <td>Out of Specification</td>
                        <td>Calibration</td>
                        <td>Electrical Safety Test</td>
                        <td>Performance Analysis</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblmanspec" runat="server"></asp:Label>
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/images/16_black.png" Visible="false" />
                        </td>
                        <td>
                            <asp:Label ID="lbluserspec" runat="server"></asp:Label>
                            <asp:Image ID="Image2" runat="server" ImageUrl="~/images/16_black.png" Visible="false" />
                        </td>
                        <td>
                            <asp:Label ID="lblwithinspec" runat="server"></asp:Label>
                            <asp:Image ID="Image3" runat="server" ImageUrl="~/images/16_black.png" Visible="false" />
                        </td>
                        <td>
                            <asp:Label ID="lbloutofspec" runat="server"></asp:Label>
                            <asp:Image ID="Image4" runat="server" ImageUrl="~/images/16_black.png" Visible="false" />
                        </td>
                        <td>
                            <asp:Label ID="lblcalib" runat="server"></asp:Label>
                            <asp:Image ID="Image5" runat="server" ImageUrl="~/images/16_black.png" Visible="false" />
                        </td>
                        <td>
                            <asp:Label ID="lblelctrical" runat="server"></asp:Label>
                            <asp:Image ID="Image6" runat="server" ImageUrl="~/images/16_black.png" Visible="false" />
                        </td>
                        <td>
                            <asp:Label ID="lblperformance" runat="server"></asp:Label>
                            <asp:Image ID="Image7" runat="server" ImageUrl="~/images/16_black.png" Visible="false" />
                        </td>
                    </tr>
                </table>
            </div>
            <div class="clear"></div>
            <div style="height: 10px;"></div>
            <div style="height: 10px;"></div>
            <div class="clear"></div>



            <%--<div class="clear"></div>--%>
            <div class="align_middle  trace" style="font-weight: bold; font-size: 8pt; border: 1px #ccc solid; width: 100%">
                <span style="font-size: 11pt; font-weight: bold;">1.6</span> &nbsp;&nbsp;
        <span style="font-size: 11pt; font-weight: bold;">TRACEABILITY DETAILS OF INSTRUMENT USED FOR TESTING</span>
                <asp:GridView ID="gridtrace" runat="server" AutoGenerateColumns="False" Width="100%" Font-Size="8pt"
                    OnRowDataBound="gridtrace_RowDataBound">
                    <Columns>

                        <asp:BoundField DataField="Rowindex" HeaderText="Sl No" />
                        <asp:BoundField DataField="Instrument" HeaderText="Name of Instrument" />
                        <asp:BoundField DataField="Make" HeaderText="Make" />
                        <asp:BoundField DataField="Model" HeaderText="Model" />
                        <asp:BoundField DataField="Serial_No" HeaderText="Serial No" />
                        <asp:BoundField DataField="Traceability_call_due" HeaderText="Traceability Call Due" />
                        <asp:BoundField DataField="Reference" HeaderText="Reference" />
                    </Columns>

                </asp:GridView>
            </div>
            <div class="clear"></div>
            <div style="height: 10px;" id="space5" runat="server" visible="true"></div>
            <div style="height: 10px;" id="space6" runat="server" visible="false"></div>
        </div>
        <div class="clear"></div>
        <div style="width: 6.27in; padding-top: 1%; padding-left: 10%; padding-right: 10%; padding-bottom: 5%;">
            <div style="height: 10px;" id="space1" runat="server"></div>
            <div style="height: 10px;" id="space2" runat="server"></div>
            <div class="align_middle" style="font-weight: bold; width: 100%;">
                <div style="height: 10px;" id="space3" runat="server"></div>
                <div style="height: 10px;" id="space4" runat="server"></div>
                <div style="height: 20px;" id="space7" runat="server" visible="false"></div>
                Report No:<asp:Label ID="lblreportnopage2" runat="server"></asp:Label>
                <center><h3>SAFETY TEST/ PERFORMANCE ANALYSIS/ CALIBRATION</h3></center>
            </div>

            <div class="align_middle" style="font-weight: bold; width: 100%;" id="perfiddiv" runat="server">
                <span style="font-size: 11pt; font-weight: bold;">2.0</span> &nbsp;&nbsp;
        <span style="font-size: 11pt; font-weight: bold;">PERFORMANCE ANALYSIS OF
            <asp:Label ID="lblproductname" runat="server"></asp:Label></span><br />
            </div>
            <div class="clear"></div>
            <%-- Ecg defribrillator starts--%>
            <uc1:View_ECG_Deferibrillator runat="server" ID="View_ECG_Deferibrillator" />
            <div class="clear"></div>
            <%-- Ecg defribrillator ends--%>

            <%--SPO2 performancetest table and datalist starts--%>
            <uc1:View_Spo2 runat="server" ID="View_Spo2" />
            <div class="clear"></div>
            <%--SPO2 performancetest table and datalist ends--%>

            <%-- performance category Blood Pressure starts--%>
            <uc1:View_BloodPressure runat="server" ID="View_BloodPressure" />
            <div class="clear"></div>
            <%-- Blood Pressure ends--%>

            <%-- performance category accuracy test set starts--%>
            <uc1:View_Accuracytest runat="server" ID="View_Accuracytest" />
            <div class="clear"></div>
            <%-- performance category accuracy test set ends--%>

            <%-- performance category vaccum set starts--%>
            <uc1:View_vaccum_suction runat="server" ID="View_vaccum_suction" />
            <div class="clear"></div>
            <%-- performance category vaccum set ends--%>


            <%-- performance category rpm set starts--%>
            <uc1:View_RPMmeasure runat="server" ID="View_RPMmeasure" />
            <div class="clear"></div>
            <%-- performance category rpm set ends--%>

            <%-- performance category flow set starts--%>

            <uc1:View_flow runat="server" ID="View_flow" />
            <div class="clear"></div>
            <%-- performance category flow set ends--%>

            <%--  Bipolarmode  starts--%>
            <uc1:View_Bipolarmode runat="server" ID="View_Bipolarmode" />
            <div class="clear"></div>

            <%--bipolar performance end--%>

            <%--energy output div starts--%>
            <uc1:View_Energyoutput runat="server" ID="View_Energyoutput" />
            <div class="clear"></div>
            <%--energy output div ends--%>
            <%--mono polar div starts--%>
            <uc1:View_Monopolarmode runat="server" ID="View_Monopolarmode" />
            <div class="clear"></div>
            <%--mono polar div ends--%>

            <%--Perf Anasthesia starts--%>
            <uc1:View_Perf_AnasthesiaMachine runat="server" ID="View_Perf_AnasthesiaMachine" />
            <div class="clear"></div>
            <%--Perf Anasthesia ends--%>

            <%-- PerfAnalysis of BiPap starts--%>
            <uc1:View_PerfBiPap runat="server" ID="View_PerfBiPap" />
            <div class="clear"></div>
            <%-- PerfAnalysis of BiPap ends--%>

            <%-- PerfAnalysis of Ventilator starts--%>
            <uc1:View_PerfVentilator runat="server" ID="View_PerfVentilator" />
            <div class="clear"></div>
            <%-- PerfAnalysis of Ventilator ends--%>

            <%--Pressure Measurement of Autoclave starts--%>
            <uc1:View_PressureAutoclave runat="server" ID="View_PressureAutoclave" />
            <div class="clear"></div>
            <%--Pressure Measurement of Autoclave ends--%>

            <%--Sync Time starts--%>
            <uc1:View_Synctime runat="server" ID="View_Synctime" />
            <div class="clear"></div>
            <%--Sync Time ends--%>

            <%-- Temperature Test for Autoclative Flash Cycle starts--%>
            <uc1:View_Temp_Atflashcycle runat="server" ID="View_Temp_Atflashcycle" />
            <div class="clear"></div>
            <%--Temperature Test for Autoclative Flash Cycle ends--%>

            <%--Temperature Test for Autoclave starts--%>
            <uc1:View_Temptest_autoclave runat="server" ID="View_Temptest_autoclave" />
            <div class="clear"></div>
            <%--Temperature Test for Autoclave ends--%>

            <%--Temperature Measurement of Fluid warmer starts--%>
            <uc1:View_TempFluidwarmer runat="server" ID="View_TempFluidwarmer" />
            <div class="clear"></div>
            <%--Temperature Measurement of Fluid warmer ends--%>

            <%--Temperature Measurement of Radiant Warmer starts--%>
            <uc1:View_TempRadiantwarmer runat="server" ID="View_TempRadiantwarmer" />
            <div class="clear"></div>
            <%--Temperature Measurement of Radiant Warmer ends--%>

            <%-- Performance Analysis Holter Machine starts--%>
            <uc1:View_Perf_micropipette runat="server" ID="View_Perf_micropipette" />
            <div class="clear"></div>
            <%--Performance Analysis Holter Machine ends--%>

            <%--ECG of Holter Machine starts--%>
            <uc1:View_ECGHolter runat="server" ID="View_ECGHolter" />
            <div class="clear"></div>
            <%--ECG of Holter Machine ends--%>

            <%--Amplitude Holter Machine starts--%>
            <uc1:View_amplitudeHolter runat="server" ID="View_amplitudeHolter" />
            <div class="clear"></div>
            <%--Amplitude Holter Machine ends--%>

            <%--Perform Analysis BP Apparatus starts--%>
            <uc1:View_PerfBPApparatus runat="server" ID="View_PerfBPApparatus" />
            <div class="clear"></div>
            <%--Perform Analysis BP Apparatus ends--%>

            <%-- Perform Analysis of Weighing Machine starts--%>
            <uc1:View_PerfWeighmachine runat="server" ID="View_PerfWeighmachine" />
            <div class="clear"></div>
            <%-- Perform Analysis of Weighing Machine ends--%>

            <%-- Performance Study of Anemometer starts--%>
            <uc1:View_PerfAnemometer runat="server" ID="View_PerfAnemometer" />
            <div class="clear"></div>
            <%--Performance Study of Anemometer ends--%>

            <%-- Temperature Measurement Digital Thermometer starts--%>
            <uc1:View_TempDigitalthermo runat="server" ID="View_TempDigitalthermo" />
            <div class="clear"></div>
            <%--Temperature Measurement Digital Thermometer ends--%>

            <%--Temperature Measurement WaterBath starts--%>
            <uc1:View_TempWaterbath runat="server" ID="View_TempWaterbath" />
            <div class="clear"></div>
            <%--Temperature Measurement WaterBath ends--%>

            <%--Temperature Measurement Deep Freezer starts--%>
            <uc1:View_TempDeepfreezer runat="server" ID="View_TempDeepfreezer" />
            <div class="clear"></div>
            <%--Temperature Measurement Deep Freezer ends--%>

            <%--Lux Measurement of OT Light starts--%>
            <uc1:View_Luxmeasure runat="server" ID="View_Luxmeasure" />
            <div class="clear"></div>
            <%--Lux Measurement of OT Light ends--%>

            <%-- Pulse rate Measurement of Pacemaker starts--%>
            <uc1:View_Pulserate runat="server" ID="View_Pulserate" />
            <div class="clear"></div>
            <%--Pulse rate Measurement of Pacemaker ends--%>

            <%--Pulse Amplitude Measurement of Pacemaker starts--%>
            <uc1:View_PulseAmplitude runat="server" ID="View_PulseAmplitude" />
            <div class="clear"></div>
            <%--Pulse Amplitude Measurement of Pacemaker ends--%>

            <%--Performance Analysis Precision Balance starts--%>
            <uc1:View_PrecisionBalance runat="server" ID="View_PrecisionBalance" />
            <div class="clear"></div>
            <%--Performance Analysis Precision Balance ends--%>

            <%--Temperature Measurement of Hot Air Oven starts--%>
            <uc1:View_Temphotair runat="server" ID="View_Temphotair" />
            <div class="clear"></div>
            <%--Temperature Measurement of Hot Air Oven ends--%>

            <%--Temperature Measurement of Incubator starts--%>
            <uc1:View_Tempincubator runat="server" ID="View_Tempincubator" />
            <div class="clear"></div>
            <%--Temperature Measurement of Incubator ends--%>

            <%--Temperature Measurement of Freezer starts--%>
            <uc1:View_Tempmeasure_freezer runat="server" ID="View_Tempmeasure_freezer" />
            <div class="clear"></div>
            <%--Temperature Measurement of Freezer ends--%>

            <%--Temperature Measurement of Middle chamber starts--%>
            <uc1:View_Tempmeasure_middlechamber runat="server" ID="View_Tempmeasure_middlechamber" />
            <div class="clear"></div>
            <%--Temperature Measurement of Middle chamber ends--%>

            <%--Temperature of hygrometer starts--%>
            <uc1:View_Temp_Hygrometer runat="server" ID="View_Temp_Hygrometer" />
            <div class="clear"></div>
            <%--Temperature of hygrometer ends--%>

            <%--Humidity  of hygrometer starts--%>
            <uc1:View_HumidityHygro runat="server" ID="View_HumidityHygro" />
            <div class="clear"></div>
            <%--Humidity  of hygrometer ends--%>

            <%--Tidal volume starts--%>
            <uc1:View_TidalVolume runat="server" ID="View_TidalVolume" />
            <div class="clear"></div>
            <%--Tidal volume ends--%>

            <%--Peep starts--%>
            <uc1:View_Peep runat="server" ID="View_Peep" />
            <div class="clear"></div>
            <%--Peep ends--%>

            <%--flowmeter starts--%>
            <uc1:View_Flowmeter runat="server" ID="View_Flowmeter" />
            <div class="clear"></div>
            <%--flowmeter ends--%>

            <%--Nebuliser starts--%>
            <uc1:View_Nebuliser runat="server" ID="View_Nebuliser" />
            <div class="clear"></div>
            <%--Nebuliser ends--%>

            <%--cpap starts--%>
            <uc1:View_PerformCpap runat="server" ID="View_PerformCpap" />
            <div class="clear"></div>
            <%--cpap ends--%>

            <%--eto starts--%>
            <uc1:View_TempEtoSteriliser runat="server" ID="View_TempEtoSteriliser" />
            <div class="clear"></div>
            <%--eto ends--%>

            <%--pressure eto starts--%>
            <uc1:View_PressureMeas_Eto runat="server" ID="View_PressureMeas_Eto" />
            <div class="clear"></div>
            <%--eto ends--%>

            <%--pressure endo starts--%>
            <uc1:View_PresMeas_Endoflator runat="server" ID="View_PresMeas_Endoflator" />
            <div class="clear"></div>
            <%--endo ends--%>

            <%--gluco  starts--%>
            <uc1:View_Glucometer runat="server" ID="View_Glucometer" />
            <div class="clear"></div>
            <%--gluco ends--%>

            <%--heparin  starts--%>
            <uc1:View_flowrate_heparin runat="server" ID="View_flowrate_heparin" />
            <div class="clear"></div>
            <%--heparin ends--%>

            <%--dialysis  starts--%>
            <uc1:View_flowrate_dialysis runat="server" ID="View_flowrate_dialysis" />
            <div class="clear"></div>
            <%--dialysis ends--%>

            <%--microtome  starts--%>
            <uc1:View_TempMeasmicrotome runat="server" ID="View_TempMeasmicrotome" />
            <div class="clear"></div>
            <%--microtome ends--%>

            <%--autoinjector  starts--%>
            <uc1:View_Autoinjector_boiler runat="server" ID="View_Autoinjector_boiler" />
            <div class="clear"></div>
            <%--autoinjector ends--%>

            <%--Jacketpressure  starts--%>
            <uc1:View_JacketPressureGuage runat="server" ID="View_JacketPressureGuage" />
            <div class="clear"></div>
            <%--Jacketpressure ends--%>

            <%--chamberpressure  starts--%>
            <uc1:View_ChamberPressureGuage runat="server" ID="View_ChamberPressureGuage" />
            <div class="clear"></div>
            <%--chamberpressure ends--%>

            <%--tempguage  starts--%>
            <uc1:View_Temperatureguage runat="server" ID="View_Temperatureguage" />
            <div class="clear"></div>
            <%--tempguage ends--%>

            <%--compressureguage  starts--%>
            <uc1:View_CompressionGuage runat="server" ID="View_CompressionGuage" />
            <div class="clear"></div>
            <%--compressureguage ends--%>

            <%--laminarflow  starts--%>
            <uc1:View_LaminarFlow runat="server" ID="View_LaminarFlow" />
            <div class="clear"></div>
            <%--laminarflow ends--%>

            <%--tempmeasure  starts--%>
            <uc1:View_Temperaturemeasurement runat="server" ID="View_Temperaturemeasurement" />
            <div class="clear"></div>
            <%--tempmeasure ends--%>

            <%--tempmeasure constant  starts--%>
            <uc1:View_Temperaturemeasure_constant runat="server" ID="View_Temperaturemeasure_constant" />
            <div class="clear"></div>
            <%--tempmeasure constant  ends--%>

            <%--Fio2test  starts--%>
            <uc1:View_FiO2 runat="server" ID="View_FiO2" />
            <%--<uc1:View_FiO2_New runat="server" ID="View_FiO2_New" />--%>
            <div class="clear"></div>
            <%--Fio2test  ends--%>

            <%--Rpm new starts--%>
            <uc1:View_RPMMeasurement_4_28_18 runat="server" ID="View_RPMMeasurement_4_28_18" />
            <div class="clear"></div>
            <%--Rpm new ends--%>

            <%--Pressure Measurement of Autoclave 132 starts--%>
            <uc1:View_PressureAutoclave132 runat="server" ID="View_PressureAutoclave132" />
            <div class="clear"></div>
            <%--Pressure Measurement of Autoclave 132 ends--%>

            <%--Micro Pipette New starts--%>
            <uc1:View_Perf_micropipetteNew runat="server" ID="View_Perf_micropipetteNew" />
            <div class="clear"></div>
            <%--Micro Pipette New ends--%>

            <div style="height: 10px;"></div>
            <div class="align_middle" style="font-weight: bold; width: 100%;" id="electricaltestdiv" runat="server">
                <span style="font-size: 11pt; font-weight: bold;">2.1</span> &nbsp;&nbsp;
        <span style="font-size: 11pt; font-weight: bold;">Electrical Safety Report of
            <asp:Label ID="lblproductname1" runat="server"></asp:Label></span><br />
            </div>
            <%--<div class="clear"></div>--%>

            <div class="align_middle  trace" style="font-weight: bold; font-size: 8pt; border: 1px #ccc solid; width: 100%" id="electricaltestcontentdiv" runat="server">

                <asp:Label ID="lblappl" runat="server" Text="Applicable Specification :"></asp:Label>
                <asp:Label ID="lblappliresult" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblstd" runat="server" Text="Standard :"></asp:Label>
                <asp:Label ID="lblstandardrslt" runat="server" Text="Label"></asp:Label>
                <asp:GridView ID="gridelectrical" runat="server" AutoGenerateColumns="False" Width="100%" Font-Size="8pt"
                    OnRowDataBound="gridtrace_RowDataBound">
                    <Columns>

                        <asp:BoundField DataField="TestName" HeaderText="Test Name" />
                        <asp:BoundField DataField="Partsconnected" HeaderText="Parts Connected" />
                        <asp:BoundField DataField="Value" HeaderText="Value" />
                        <asp:BoundField DataField="HighLimits" HeaderText="High Limits" />
                        <asp:BoundField DataField="Status" HeaderText="Status" />
                    </Columns>

                </asp:GridView>
            </div>
            <div class="clear"></div>
            <div style="height: 10px;"></div>
            <div class="align_middle" style="width: 100%">
                <%--<h4><asp:Label ID="Label31" runat="server" Text="" Width="30px"></asp:Label>Remarks</h4>--%>
                <span style="font-size: 11pt; font-weight: bold;">3.0</span> &nbsp;&nbsp;
        <span style="font-size: 11pt; font-weight: bold;">REMARKS</span>

                <div id="remarks" runat="server" style="width: 100%; border: 1px solid black; padding: 1%; font-size: 8pt;">
                </div>
            </div>
            <div class="clear"></div>
            <div style="width: 100%; font-size: 8pt;">
                <table width="100%">
                    <tr>
                        <td align="left">Done By

                        </td>
                        <td align="right">ISSUED BY
                            <br />

                        </td>
                    </tr>
                </table>
                <div style="height: 50px;"></div>
                <table width="100%">
                    <tr>
                        <td>
                            <asp:Label ID="lblcalibofficer" runat="server" Text=""></asp:Label>
                            <br />
                            Calibration Engineer
                        </td>
                        <td align="right">
                            <asp:Label ID="lblissueofficer" runat="server" Text=""></asp:Label>
                            <br />
                            Officer - in - Charge<br />
                            Testing & Analysis
                        </td>
                    </tr>


                </table>

            </div>
            <div class="clear"></div>

        </div>

    </asp:Panel>
</asp:Content>

