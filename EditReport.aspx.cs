using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using System.Data;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Web.Services;
using System.Collections;
using System.Text;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.Net;

public partial class EditReport : System.Web.UI.Page
{
    Dbclass db1 = new Dbclass();
    string[] perfname = { };
    string[] performanceid = { };
    int performanceid_count = 0;
    string usertype = "", hospid = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.IsAuthenticated && Session["Usertype"] != null)
        {
            usertype = Session["Usertype"].ToString();

            if (usertype == "")
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                remarks.InnerHtml = string.Empty;
                HtmlGenericControl listreport = (HtmlGenericControl)this.Master.FindControl("lireport");
                listreport.Style.Add("background-color", "#195A7F");
                string Barcodeid = (Request.QueryString["ReportNoid"]).Replace("'","");
                if (Barcodeid != "")
                {
                    ShowPerftable();
                    btnprint.Visible = true;
                    pnlprint.Visible = true;
                    PopulateHospitalId();
                    retreiveReportID(Barcodeid);
                    Bind_ReportInfo();
                    CustomerInfo();
                    Populate_productinfo();
                    Populate_DUTinfo();
                    Bind_Environ();
                    Bind_Calib();
                    Bind_Traceability();
                    Populate_perftable();
                    Populate_ElectricalReport();
                    Hideperftable();
                    Bind_Issueofficer();
                    Bind_Calibrationofficer();
                    if (elect_hidden.Value == "" || elect_hidden.Value=="0")
                    {
                        electricaltestdiv.Visible = false;
                        electricaltestcontentdiv.Visible = false;
                    }
                    if (perfid_hidden.Value == "" || perfid_hidden.Value == "0")
                    {
                        perfiddiv.Visible = false;
                    }
                }

            }
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }

    #region Functions

    public void PopulateHospitalId()
    {
        if (usertype == "2")
        {
            db1.strCommand = "select HospitalID from Hospital hp " +
                            "inner join LoginTb lg on lg.LoginID=hp.LoginID where lg.Username='" + Page.User.Identity.Name + "' ";
            hospid = db1.executescalar();
        }
    }
    public void retreiveReportID(string Barcodeid)
    {
        if (usertype == "2")
        {
            db1.strCommand = "select rp.Report_info_ID from Report_Info as rp inner join " +
            "Customer_Info as cu on cu.Report_info_ID=rp.Report_info_ID where rp.ReportNo='" + Barcodeid + "'" +
                "and cu.HospitalID='" + hospid + "'";
            DataTable dt = new DataTable();
            dt = db1.selecttable();
            if (dt.Rows.Count > 0)
            {
                reportid_hidden.Value = (dt.Rows[0]["Report_info_ID"].ToString());
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Invalid Report Number ');", true);
            }
        }
        else
        {
            db1.strCommand = "select Report_info_ID from Report_Info where ReportNo='"+Barcodeid+"'";
            DataTable dt = new DataTable();
            dt = db1.selecttable();
            if (dt.Rows.Count > 0)
            {
                reportid_hidden.Value = (dt.Rows[0]["Report_info_ID"].ToString());
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Invalid Barcode ID!');", true);

            }
        }
    }
    public void Bind_ReportInfo()
    {
        if (reportid_hidden.Value != "")
        {
            db1.strCommand = "select * from Report_Info where Report_info_ID=" + reportid_hidden.Value;
            //db1.strCommand = "select ReportNo,Date_of_calibration,Calibration_Due_on from Report_Info inner join DUT_info on Report_Info.Report_info_ID=DUT_info.Report_info_ID where DUT_info.Barcode_ID='" + txtSearchString.Text.Trim().Replace("'", "''") + "'";
            DataTable dt = new DataTable();
            dt = db1.selecttable();
            if (dt.Rows.Count > 0)
            {
                lblreportno.Text = dt.Rows[0]["ReportNo"].ToString();
                lblreportnopage2.Text = dt.Rows[0]["ReportNo"].ToString();
                lblcalibdate.Text = dt.Rows[0]["Date_of_calibration"].ToString();
                lblduedate.Text = dt.Rows[0]["Calibration_Due_on"].ToString();
                //lblreportno2.Text = dt.Rows[0]["ReportNo"].ToString();
                //lblcalibdate2.Text = dt.Rows[0]["Date_of_calibration"].ToString();
                //lblduedate2.Text = dt.Rows[0]["Calibration_Due_on"].ToString();
                lblpgno1.Text = dt.Rows[0]["Barcode_ID"].ToString();
                //lblpgno2.Text = dt.Rows[0]["Barcode_ID"].ToString();
                productidhidden.Value = dt.Rows[0]["ProductID"].ToString();
                elect_hidden.Value = dt.Rows[0]["ElectID"].ToString();
                perfid_hidden.Value = dt.Rows[0]["PerfID"].ToString();
                Ecm_hidden.Value = dt.Rows[0]["ECM_ID"].ToString();
                tracehidden.Value = dt.Rows[0]["Tracibility_ID"].ToString();
                performanceid = perfid_hidden.Value.Split(',');
                performanceid_count = performanceid.Count();
                //remarks.InnerHtml = dt.Rows[0]["Remarks"].ToString();
                string s_remarks = dt.Rows[0]["Remarks"].ToString();
                string[] rem1 = s_remarks.Split('@');
                for (int i = 0; i < rem1.Count() - 1; i++)
                {
                    remarks.InnerHtml += rem1[i].ToString() + "<br/>";
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Report Information not exists!');", true);
            }

        }
        else
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Invalid BarcodeID! ');", true);
        }
    }
    public void CustomerInfo()
    {
        db1.strCommand = "select Hospital.HospitalName,Hospital.Address,Customer_Info.Reference_Date," +
            "Customer_Info.Date_Receipt from Customer_Info inner join Hospital on Hospital.HospitalID=Customer_Info.HospitalID " +
            " where Customer_Info.Report_info_ID='" + reportid_hidden.Value + "'";
        DataTable dt = new DataTable();
        dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            lblhospitalname.Text = dt.Rows[0]["HospitalName"].ToString();
            lblhospaddress.Text = dt.Rows[0]["Address"].ToString();
            lblreferencedate.Text = dt.Rows[0]["Reference_Date"].ToString();
            lbldateofreceipt.Text = dt.Rows[0]["Date_Receipt"].ToString();
        }
    }


    public void conditionofitem()
    {
        db1.strCommand = "select Condition_of_item from DUT_info where Report_info_ID=" + reportid_hidden.Value;
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count>0)
        {
            lblconditionofitem.Text = dt.Rows[0]["Condition_of_item"].ToString();            
        }
    }
    public void Populate_productinfo()
    {
        db1.strCommand = "select * from Product where ProductID='" + productidhidden.Value + "'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count>0)
        {
            lblnomenclature.Text = dt.Rows[0]["ProductName"].ToString().ToUpper(); ;
            lblmanufacture.Text = dt.Rows[0]["Company"].ToString();
            lblmodel.Text = dt.Rows[0]["Model"].ToString();
            lbltype.Text = dt.Rows[0]["Device_Type"].ToString();
            lblclassification.Text = dt.Rows[0]["Device_Classification"].ToString();
            lblsupply.Text = dt.Rows[0]["Supply"].ToString();
            lblpowerrating.Text = dt.Rows[0]["PowerRating"].ToString();
            lblproductname.Text = dt.Rows[0]["ProductName"].ToString().ToUpper();
            lblproductname1.Text = dt.Rows[0]["ProductName"].ToString().ToUpper();            
        }
    }
    public void Populate_DUTinfo()
    {
        db1.strCommand = "select * from DUT_info where Report_info_ID='" + reportid_hidden.Value + "'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            lblserialno.Text = dt.Rows[0]["Serial_No"].ToString();
            lblbiomedicalID.Text = dt.Rows[0]["Biomedical_ID"].ToString();
            lblconditionofitem.Text = dt.Rows[0]["Condition_of_item"].ToString();
            lbllocation.Text = dt.Rows[0]["Location"].ToString();
        }
    }
    public void Bind_Environ()
    {
        db1.strCommand = "select * from Environ_condition where ECM_ID='" + Ecm_hidden.Value + "'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            lbltemperature.Text = dt.Rows[0]["Temperature"].ToString();
            lblhumidity.Text = dt.Rows[0]["Relative_Humidity"].ToString();
            lblambient.Text = dt.Rows[0]["Ambient_Barometric_measure"].ToString();
        }
    }
    public void Bind_Traceability()
    {
        string[] tracearray = { };
        DataTable dt = new DataTable();
        int rowindex = 0;
        tracearray = tracehidden.Value.Split(',');
        dt.Columns.Add("Tracibility_ID", typeof(int));
        dt.Columns.Add("Instrument", typeof(string));
        dt.Columns.Add("Make", typeof(string));
        dt.Columns.Add("Model", typeof(string));
        dt.Columns.Add("Serial_No", typeof(string));
        dt.Columns.Add("Traceability_call_due", typeof(string));
        dt.Columns.Add("Reference", typeof(string));
        dt.Columns.Add("Rowindex", typeof(string));
        for (int i = 0; i < tracearray.Count() - 1; i++)
        {
            db1.strCommand = "select * from Traceability_Info where Tracibility_ID='" + tracearray[i] + "'";
            DataTable dt1 = db1.selecttable();
            if (dt1.Rows.Count > 0)
            {
                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    rowindex++;

                    //dt.Rows[j]["Rowindex"] = rowindex;
                    dt.Rows.Add(dt1.Rows[j]["Tracibility_ID"].ToString(), dt1.Rows[j]["Instrument"].ToString(), dt1.Rows[j]["Make"].ToString(),
                                dt1.Rows[j]["Model"].ToString(), dt1.Rows[j]["Serial_No"].ToString(),
                                dt1.Rows[j]["Traceability_call_due"].ToString(), dt1.Rows[j]["Reference"].ToString(), rowindex);

                }

            }


        }

        if (dt.Rows.Count > 3)
        {
            space1.Visible = false;
            space2.Visible = false;
            space3.Visible = false;
            space4.Visible = false;
        }
        if (dt.Rows.Count <= 2)
        {
            space6.Visible = true;
            space7.Visible = true;
        }
        gridtrace.DataSource = dt;
        gridtrace.DataBind();

    }
    public void Bind_Calib()
    {
        db1.strCommand = "select * from Calibration_Status where Report_info_ID='" + reportid_hidden.Value + "'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count>0)
        {
            if (Convert.ToInt32(dt.Rows[0]["Manu_Specifi"]) == 1)
            {
                //lblmanspec.Text = "yes";
                Image1.Visible = true;
            }
            else
            {
                lblmanspec.Text = "-";
            }
            if (Convert.ToInt32(dt.Rows[0]["User_Specifi"]) == 1)
            {
                //lbluserspec.Text = "yes";
                Image2.Visible = true;
            }
            else
            {
                lbluserspec.Text = "-";
            }
            if (Convert.ToInt32(dt.Rows[0]["within_specifi"]) == 1)
            {
                //lblwithinspec.Text = "yes";
                Image3.Visible = true;
            }
            else
            {
                lblwithinspec.Text = "-";
            }
            if (Convert.ToInt32(dt.Rows[0]["outof_specifi"]) == 1)
            {
                //lbloutofspec.Text = "yes";
                Image4.Visible = true;
            }
            else
            {
                lbloutofspec.Text = "-";
            }
            if (Convert.ToInt32(dt.Rows[0]["calibration"]) == 1)
            {
                //lblcalib.Text = "yes";
                Image5.Visible = true;
            }
            else
            {
                lblcalib.Text = "-";
            }
            if (Convert.ToInt32(dt.Rows[0]["Electrical_safety"]) == 1)
            {
                //lblelctrical.Text = "yes";
                Image6.Visible = true;
            }
            else
            {
                lblelctrical.Text = "-";
            }
            if (Convert.ToInt32(dt.Rows[0]["Performance_analysis"]) == 1)
            {
                //lblperformance.Text = "yes";
                Image7.Visible = true;
            }
            else
            {
                lblperformance.Text = "-";
            }
        }
    }

    public void Populate_ElectricalReport()
    {
        db1.strCommand = "select * from ElectricalSafety where ElectID='" + elect_hidden.Value + "'";
        DataTable dt_electricalsafty = db1.selecttable();
        if (dt_electricalsafty.Rows.Count > 0)
        {
            lblappliresult.Text = dt_electricalsafty.Rows[0]["Applicable_Spec"].ToString();
            lblstandardrslt.Text = dt_electricalsafty.Rows[0]["Standard"].ToString();
        }
        db1.strCommand = "select * from ElectValues where ElectID='" + elect_hidden.Value + "'";
        DataTable dt_elct = db1.selecttable();
        if (dt_elct.Rows.Count > 0)
        {
            gridelectrical.DataSource = dt_elct;
            gridelectrical.DataBind();
        }
    }

    public void ShowPerftable()
    {
        View_ECG_Deferibrillator.showdiv_tr();
        View_Spo2.showdiv_tr();
        View_BloodPressure.showdiv_tr();
        View_Accuracytest.showdiv_tr();
        View_RPMmeasure.showdiv_tr();
        View_vaccum_suction.showdiv_tr();
        View_flow.showdiv_tr();
        View_Bipolarmode.showdiv_tr();
        View_Energyoutput.showdiv_tr();
        View_Monopolarmode.showdiv_tr();
        View_Perf_AnasthesiaMachine.showdiv_tr();
        View_PerfBiPap.showdiv_tr();
        View_PerfVentilator.showdiv_tr();
        View_PressureAutoclave.showdiv_tr();
        View_Synctime.showdiv_tr();
        View_Temp_Atflashcycle.showdiv_tr();
        View_Temptest_autoclave.showdiv_tr();
        View_TempFluidwarmer.showdiv_tr();
        View_TempRadiantwarmer.showdiv_tr();
        View_Perf_micropipette.showdiv_tr();
        View_ECGHolter.showdiv_tr();
        View_amplitudeHolter.showdiv_tr();
        View_PerfBPApparatus.showdiv_tr();
        View_PerfWeighmachine.showdiv_tr();
        View_PerfAnemometer.showdiv_tr();
        View_TempDigitalthermo.showdiv_tr();
        View_TempWaterbath.showdiv_tr();
        View_TempDeepfreezer.showdiv_tr();
        View_Luxmeasure.showdiv_tr();
        View_Pulserate.showdiv_tr();
        View_PulseAmplitude.showdiv_tr();
        View_PrecisionBalance.showdiv_tr();
        View_Temphotair.showdiv_tr();
        View_Tempincubator.showdiv_tr();
        View_Tempmeasure_freezer.showdiv_tr();
        View_Tempmeasure_middlechamber.showdiv_tr();
        View_Temp_Hygrometer.showdiv_tr();
        View_HumidityHygro.showdiv_tr();
        View_TidalVolume.showdiv_tr();
        View_Peep.showdiv_tr();
        View_Flowmeter.showdiv_tr();
        View_Nebuliser.showdiv_tr();
        View_PerformCpap.showdiv_tr();
        View_TempEtoSteriliser.showdiv_tr();
        View_PressureMeas_Eto.showdiv_tr();
        View_PresMeas_Endoflator.showdiv_tr();
        View_Glucometer.showdiv_tr();
        View_flowrate_heparin.showdiv_tr();
        View_flowrate_dialysis.showdiv_tr();
        View_TempMeasmicrotome.showdiv_tr();
        View_Autoinjector_boiler.showdiv_tr();
        View_JacketPressureGuage.showdiv_tr();
        View_ChamberPressureGuage.showdiv_tr();
        View_Temperatureguage.showdiv_tr();
        View_CompressionGuage.showdiv_tr();
        View_LaminarFlow.showdiv_tr();
        View_Temperaturemeasurement.showdiv_tr();
        View_Temperaturemeasure_constant.showdiv_tr();
        View_FiO2.showdiv_tr();
        //View_FiO2_New.showdiv_tr();
        View_RPMMeasurement_4_28_18.showdiv_tr();
        View_PressureAutoclave132.showdiv_tr();
        View_Perf_micropipetteNew.showdiv_tr();
        View_Perf_micropipette2019.showdiv_tr();
    }

    public void Hideperftable()
    {
        View_ECG_Deferibrillator.Hidetable();
        View_Spo2.Hide_perftable();
        View_BloodPressure.Hide_perftable();
        View_Accuracytest.Hide_perftable();
        View_RPMmeasure.Hide_perftable();
        View_vaccum_suction.Hide_perftable();
        View_flow.Hide_perftable();
        View_Bipolarmode.Hide_perftable();
        View_Energyoutput.Hide_perftable();
        View_Monopolarmode.Hide_perftable();
        View_Perf_AnasthesiaMachine.Hide_perftable();
        View_PerfBiPap.Hide_perftable();
        View_PerfVentilator.Hide_perftable();
        View_PressureAutoclave.Hide_perftable();
        View_Synctime.Hide_perftable();
        View_Temp_Atflashcycle.Hide_perftable();
        View_Temptest_autoclave.Hide_perftable();
        View_TempFluidwarmer.Hide_perftable();
        View_TempRadiantwarmer.Hide_perftable();
        View_Perf_micropipette.Hide_perftable();
        View_ECGHolter.Hide_perftable();
        View_amplitudeHolter.Hide_perftable();
        View_PerfBPApparatus.Hide_perftable();
        View_PerfWeighmachine.Hide_perftable();
        View_PerfAnemometer.Hide_perftable();
        View_TempDigitalthermo.Hide_perftable();
        View_TempWaterbath.Hide_perftable();
        View_TempDeepfreezer.Hide_perftable();
        View_Luxmeasure.Hide_perftable();
        View_Pulserate.Hide_perftable();
        View_PulseAmplitude.Hide_perftable();
        View_PrecisionBalance.Hide_perftable();
        View_Temphotair.Hide_perftable();
        View_Tempincubator.Hide_perftable();
        View_Tempmeasure_freezer.Hide_perftable();
        View_Tempmeasure_freezer.Hide_perftable();
        View_Tempmeasure_middlechamber.Hide_perftable();
        View_Temp_Hygrometer.Hide_perftable();
        View_HumidityHygro.Hide_perftable();
        View_TidalVolume.Hide_perftable();
        View_Peep.Hide_perftable();
        View_Flowmeter.Hide_perftable();
        View_Nebuliser.Hide_perftable();
        View_PerformCpap.Hide_perftable();
        View_TempEtoSteriliser.Hide_perftable();
        View_PressureMeas_Eto.Hide_perftable();
        View_PresMeas_Endoflator.Hide_perftable();
        View_Glucometer.Hide_perftable();
        View_flowrate_heparin.Hide_perftable();
        View_flowrate_dialysis.Hide_perftable();
        View_TempMeasmicrotome.Hide_perftable();
        View_Autoinjector_boiler.Hide_perftable();
        View_JacketPressureGuage.Hide_perftable();
        View_ChamberPressureGuage.Hide_perftable();
        View_Temperatureguage.Hide_perftable();
        View_CompressionGuage.Hide_perftable();
        View_LaminarFlow.Hide_perftable();
        View_Temperaturemeasurement.Hide_perftable();
        View_Temperaturemeasure_constant.Hide_perftable();
        View_FiO2.Hide_perftable();
        //View_FiO2_New.Hide_perftable();
        View_RPMMeasurement_4_28_18.Hide_perftable();
        View_PressureAutoclave132.Hide_perftable();
        View_Perf_micropipetteNew.Hide_perftable();
        View_Perf_micropipette2019.Hide_perftable();
    }

    public void Populate_perftable()
    {

        for (int i = 0; i < performanceid_count - 1; i++)
        {
            if (performanceid[i].ToString() == "1")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_ECG_Deferibrillator.Bind_Ecgdefribrillator(sReportid, sPerfid);

            }
            //perf 1 ends
            if (performanceid[i].ToString() == "2")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Spo2.Bind_Spo2(sReportid, sPerfid);

            }
            //perf2end

            if (performanceid[i].ToString() == "3")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_BloodPressure.Bind_BloodPressure(sReportid, sPerfid);
            }
            //perf3 ends

            if (performanceid[i].ToString() == "4")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Accuracytest.Bind_Accuracytest(sReportid, sPerfid);
            }

            //perf page4 ends
            if (performanceid[i].ToString() == "5")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_vaccum_suction.Bind_vaccum(sReportid, sPerfid);

            }
            //perf page5 ends

            if (performanceid[i].ToString() == "6")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_RPMmeasure.Bind_RPM(sReportid, sPerfid);
            }
            //  perf6 ends

            if (performanceid[i].ToString() == "7")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_flow.Bind_flow(sReportid, sPerfid);

            }
            // perf7 ends


            if (performanceid[i].ToString() == "8")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Bipolarmode.Bind_Bipolarmode(sReportid, sPerfid);
            }

            //perfcount bipolarmode ends

            if (performanceid[i].ToString() == "9")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Energyoutput.Bind_EnergyOutput(sReportid, sPerfid);
            }

            //perf energy output ends

            //Monopolar mode starts

            if (performanceid[i].ToString() == "10")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Monopolarmode.Bind_MonopolarMode(sReportid, sPerfid);
            }
            //Monopolar mode ends

            //PerfAnasthesia  starts

            if (performanceid[i].ToString() == "11")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();

                View_Perf_AnasthesiaMachine.Bind_Perf_Anasthesia(sReportid, sPerfid);
            }
            //PerfAnasthesia  ends

            //PerfAnalysis of BiPap starts
            if (performanceid[i].ToString() == "12")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();

                View_PerfBiPap.Bind_Perf_Bipap(sReportid, sPerfid);
            }
            //PerfAnalysis of BiPap ends

            //PerfAnalysis of Ventilator starts
            if (performanceid[i].ToString() == "13")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();

                View_PerfVentilator.Bind_Perf_Ventilator(sReportid, sPerfid);
            }
            //PerfAnalysis of Ventilator ends

            //Pressure Measurement of Autoclave starts
            if (performanceid[i].ToString() == "14")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();

                View_PressureAutoclave.Bind_PressureAutoclave(sReportid, sPerfid);
            }
            //Pressure Measurement of Autoclave ends

            //Sync Time starts
            if (performanceid[i].ToString() == "15")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Synctime.Bind_Synctime(sReportid, sPerfid);

            }
            //Sync Time ends

            //Temperature Test for Autoclative Flash Cycle starts
            if (performanceid[i].ToString() == "16")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Temp_Atflashcycle.Bind_Temptest_flashcycle(sReportid, sPerfid);

            }
            //Temperature Test for Autoclative Flash Cycle ends

            //Temperature Test for Autoclave starts
            if (performanceid[i].ToString() == "17")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Temptest_autoclave.Bind_Temptest_autoclave(sReportid, sPerfid);
            }
            //Temperature Test for Autoclave ends

            //Temperature Measurement of Fluid warmer starts
            if (performanceid[i].ToString() == "18")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_TempFluidwarmer.Bind_Temptest_fluidwarmer(sReportid, sPerfid);
            }
            //Temperature Measurement of Fluid warmer ends

            //Temperature Measurement of Radiant Warmer starts
            if (performanceid[i].ToString() == "19")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_TempRadiantwarmer.Bind_Temptest_radiantwarmer(sReportid, sPerfid);
            }
            //Temperature Measurement of Radiant Warmer ends

            //Performance Analysis Holter Machine starts
            if (performanceid[i].ToString() == "20")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Perf_micropipette.Bind_PerfHolter(sReportid, sPerfid);
            }
            //Performance Analysis Holter Machine ends

            //<%--ECG of Holter Machine starts--%>
            if (performanceid[i].ToString() == "21")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_ECGHolter.Bind_ecgHolter(sReportid, sPerfid);
            }
            //<%--ECG of Holter Machine ends--%>

            //Amplitude Holter Machine starts
            if (performanceid[i].ToString() == "22")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_amplitudeHolter.Bind_ampliHolter(sReportid, sPerfid);
            }
            //Amplitude Holter Machine ends

            //Perform Analysis BP Apparatus starts
            if (performanceid[i].ToString() == "23")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_PerfBPApparatus.Bind_PerfBPapparatusr(sReportid, sPerfid);
            }
            //Perform Analysis BP Apparatus ends

            //Perform Analysis of Weighing Machine starts
            if (performanceid[i].ToString() == "24")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_PerfWeighmachine.Bind_perfweigh(sReportid, sPerfid);
            }
            //Perform Analysis of Weighing Machine ends

            //Performance Study of Anemometer starts
            if (performanceid[i].ToString() == "25")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_PerfAnemometer.Bind_perfanemo(sReportid, sPerfid);
            }
            //Performance Study of Anemometer ends

            //Temperature Measurement Digital Thermometer starts
            if (performanceid[i].ToString() == "26")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_TempDigitalthermo.Bind_Temptest_digital(sReportid, sPerfid);
            }
            //Temperature Measurement Digital Thermometer ends

            //Temperature Measurement WaterBath starts
            if (performanceid[i].ToString() == "27")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_TempWaterbath.Bind_Tempwaterbath(sReportid, sPerfid);
            }
            //Temperature Measurement WaterBath ends

            //Temperature Measurement Deep Freezer starts
            if (performanceid[i].ToString() == "28")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_TempDeepfreezer.Bind_TempDeepFreezer(sReportid, sPerfid);
            }
            //Temperature Measurement Deep Freezer ends

            //Lux Measurement of OT Light starts
            if (performanceid[i].ToString() == "29")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Luxmeasure.Bind_Luxmeasure(sReportid, sPerfid);
            }
            //Lux Measurement of OT Light ends

            //Pulse rate Measurement of Pacemaker starts
            if (performanceid[i].ToString() == "30")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Pulserate.Bind_Pulserate(sReportid, sPerfid);
            }
            //Pulse rate Measurement of Pacemaker ends

            //Pulse Amplitude Measurement of Pacemaker starts
            if (performanceid[i].ToString() == "31")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_PulseAmplitude.Bind_Pulseamplitude(sReportid, sPerfid);
            }
            //Pulse Amplitude Measurement of Pacemaker ends

            //Performance Analysis Precision Balance starts
            if (performanceid[i].ToString() == "32")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_PrecisionBalance.Bind_Precision(sReportid, sPerfid);
            }
            //Performance Analysis Precision Balance ends

            //Temperature Measurement of Hot Air Oven starts
            if (performanceid[i].ToString() == "33")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Temphotair.Bind_Temphotair(sReportid, sPerfid);
            }
            //Temperature Measurement of Hot Air Oven ends

            //Temperature Measurement of Incubator starts
            if (performanceid[i].ToString() == "34")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Tempincubator.Bind_TempIncubator(sReportid, sPerfid);
            }
            //Temperature Measurement of Incubator ends

            //Temperature Measurement of freezer starts
            if (performanceid[i].ToString() == "35")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Tempmeasure_freezer.Bind_Temp_freezer(sReportid, sPerfid);
            }
            //Temperature Measurement of freezer ends

            //Temperature Measurement of middlechamber starts
            if (performanceid[i].ToString() == "36")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Tempmeasure_middlechamber.Bind_Temp_middlechamber(sReportid, sPerfid);
            }
            //Temperature Measurement of middlechamber ends

            //Temperature of hygrometer starts
            if (performanceid[i].ToString() == "37")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Temp_Hygrometer.Bind_temphygro(sReportid, sPerfid);
            }
            //Temperature of hygrometer ends

            //Humidity of hygrometer starts
            if (performanceid[i].ToString() == "38")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_HumidityHygro.Bind_humidity(sReportid, sPerfid);
            }
            //Humidity of hygrometer ends

            //Tidal volume starts
            if (performanceid[i].ToString() == "39")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_TidalVolume.Bind_tidal(sReportid, sPerfid);
            }
            //Tidal volume ends

            //Peep starts
            if (performanceid[i].ToString() == "40")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Peep.Bind_Peep(sReportid, sPerfid);
            }
            //Peep ends

            //flowmeter starts
            if (performanceid[i].ToString() == "41")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Flowmeter.Bind_flowmeter(sReportid, sPerfid);
            }
            //flowmeter ends

            //Nebuliser starts
            if (performanceid[i].ToString() == "42")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Nebuliser.Bind_nebu(sReportid, sPerfid);
            }
            //Nebuliser ends

            //cpap starts
            if (performanceid[i].ToString() == "43")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_PerformCpap.Bind_Perf_cpap(sReportid, sPerfid);
            }
            //cpap ends

            //eto starts
            if (performanceid[i].ToString() == "44")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_TempEtoSteriliser.Bind_Temptest_eto(sReportid, sPerfid);
            }
            //eto ends

            //pressure eto starts
            if (performanceid[i].ToString() == "45")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_PressureMeas_Eto.Bind_Temptest_eto(sReportid, sPerfid);
            }
            //pressure eto ends

            //pressure endo starts
            if (performanceid[i].ToString() == "46")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_PresMeas_Endoflator.Bind_Accuracytest(sReportid, sPerfid);
            }
            //pressure eendoto ends

            //gluco starts
            if (performanceid[i].ToString() == "47")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Glucometer.Bind_flow(sReportid, sPerfid);
            }
            //gluco ends

            //heparin starts
            if (performanceid[i].ToString() == "48")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_flowrate_heparin.Bind_flow(sReportid, sPerfid);
            }
            //heparin ends

            //dialysis starts
            if (performanceid[i].ToString() == "49")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_flowrate_dialysis.Bind_flow(sReportid, sPerfid);
            }
            //dialysis ends

            //microtome starts
            if (performanceid[i].ToString() == "50")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_TempMeasmicrotome.Bind_TempDeepFreezer(sReportid, sPerfid);
            }
            //microtome ends

            //autoinjector starts
            if (performanceid[i].ToString() == "51")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Autoinjector_boiler.Bind_Peep(sReportid, sPerfid);
            }
            //autoinjector ends

            //jacketpressure starts
            if (performanceid[i].ToString() == "52")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_JacketPressureGuage.Bind_Peep(sReportid, sPerfid);
            }
            //jacketpressure ends

            //chamberpressure starts
            if (performanceid[i].ToString() == "53")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_ChamberPressureGuage.Bind_Peep(sReportid, sPerfid);
            }
            //chamberpressure ends

            //tempguage starts
            if (performanceid[i].ToString() == "54")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Temperatureguage.Bind_Peep(sReportid, sPerfid);
            }
            //tempguage ends

            //compressureguage starts
            if (performanceid[i].ToString() == "55")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_CompressionGuage.Bind_Peep(sReportid, sPerfid);
            }
            //compressureguage ends

            //laminarflow starts
            if (performanceid[i].ToString() == "56")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_LaminarFlow.Bind_Peep(sReportid, sPerfid);
            }
            //laminarflow ends

            //tempmeasure starts
            if (performanceid[i].ToString() == "57")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Temperaturemeasurement.Bind_Tempmeasure(sReportid, sPerfid);
            }
            //tempmeasure ends

            //tempmeasure_constant starts
            if (performanceid[i].ToString() == "58")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_Temperaturemeasure_constant.Bind_Tempmeasure(sReportid, sPerfid);
            }
            //tempmeasure_constant ends

            //Fio2 starts
            if (performanceid[i].ToString() == "59")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_FiO2.Bind_flow(sReportid, sPerfid);
                //View_FiO2_New.Bind_flow(sReportid, sPerfid);
            }
            //fio2 ends

            //Rpm new starts
            if (performanceid[i].ToString() == "60")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();
                View_RPMMeasurement_4_28_18.Bind_RpmMeasurement(sReportid, sPerfid);
            }
            //Rpm new ends

            //Pressure Measurement of Autoclave 132 starts
            if (performanceid[i].ToString() == "61")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();

                View_PressureAutoclave132.Bind_PressureAutoclave(sReportid, sPerfid);
            }
            //Pressure Measurement of Autoclave 132 ends

            //Micro Pipette New starts
            if (performanceid[i].ToString() == "62")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();

                View_Perf_micropipetteNew.Bind_MicroPipetteData(sReportid, sPerfid);
            }
            //Micro Pipette New ends

            //Micro Pipette New starts
            if (performanceid[i].ToString() == "63")
            {
                string sReportid = reportid_hidden.Value;
                string sPerfid = performanceid[i].ToString();

                View_Perf_micropipette2019.Bind_MicroPipetteData(sReportid, sPerfid);
            }
            //Micro Pipette New ends
        }


    }


    #endregion


    protected void btnadd_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddReport.aspx");
    }
    protected void gridtrace_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }
    protected void gridelectrical_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }
    protected void btnedit_Click(object sender, EventArgs e)
    {
       
        Response.Redirect("AddReport.aspx?editreport=1");
    }

    public void Bind_Calibrationofficer()
    {
        db1.strCommand = "select * from LoginTb where Usertype='3'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            lblcalibofficer.Text = dt.Rows[0]["Username"].ToString();
        }
    }
    public void Bind_Issueofficer()
    {
        db1.strCommand = "select * from LoginTb where Usertype='4'";
        DataTable dt = db1.selecttable();
        if (dt.Rows.Count > 0)
        {
            lblissueofficer.Text = dt.Rows[0]["Username"].ToString();
        }
    }
}