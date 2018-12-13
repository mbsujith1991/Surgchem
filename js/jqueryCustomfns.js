$(document).ready(function () {
    $("#TabbedPanels1").tabs();
    $.ajax({
        type: "POST",
        url: "Default.aspx/lawersDetailsList",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            var arrayList = data.d;
            $.each(arrayList, function (i, val) {
                setTimeout(function () {
                    $('#slide-1').fadeOut("slow", function () {
                        $(this).html("<h1>" + val.memberName + "</h1>" + "<p><strong>Enroll No : " + val.enrollno + "</strong></p>" + "<p><strong> Office : </strong>" + val.offAddress + "</p>" + "<p><strong>Mobile : </strong>" + val.mobile + "</p>" + "<p><strong>Email : </strong>" + val.emailid + "</p>" + "<a href='LawyerProfile.aspx?id=" + val.memID + "'><img src='MemPhoto/" + val.imageID + "' height='180px' style='border:4px outset #ddd'  /></a><br />").fadeIn("slow");
                    });
                }, i * 5000);
            });
        }
    });
    var arrayCount = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '10'];
    $.each(arrayCount, function (j, values) {
        setTimeout(function () {
            $.ajax({
                type: "POST",
                url: "Default.aspx/memberProfilesList",
                data: "{}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    var arrayList = data.d;
                    $("#membersProfile").fadeOut("slow");
                    $('#membersProfile').html("");
                    $.each(arrayList, function (i, val) {
                        $('#membersProfile').append("<a href='LawyerProfile.aspx?id=" + val.memID + "'><img  src='MemPhoto/" + val.imageID + "' width='50px' /></a>");
                    });
                    $("#membersProfile").fadeIn("10000");
                }
            });
        }, j * 30000);
    });

    $('#TabbedPanels1').bind('tabsselect', function (event, ui) {
        var callMethod;
        var tabSelected = "#TabbedPanels1" + ui.index + "Selected";
        if ($(tabSelected).text() == "") {
            switch (ui.index) {
                case 1:
                    callMethod = "Default.aspx/DesignatedSeniorsList";
                    break;
                case 2:
                    callMethod = "Default.aspx/MostViewedprofilesList";
                    break;
                case 3:
                    callMethod = "Default.aspx/LastViewedprofilesList";
                    break;
                case 4:
                    callMethod = "Default.aspx/RecentlyUpdatedMembersList";
                    break;

            }

            $.ajax({
                type: "POST",
                url: callMethod,
                data: "{}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: true,
                success: function (data) {
                    var items = data.d;
                    switch (ui.index) {
                        case 1:
                            $('#tabs-DesignatedSeniors').empty().append("");
                            $.each(items, function (i, val) {
                                $('#tabs-DesignatedSeniors').append("<table style='display: inline-block; border: solid 1px gray; width:155px;height:220px;padding:5px;margin:5px'><tr><td><a href='LawyerProfile.aspx?id=" + val.memID + "'><img src='MemPhoto/" + val.imageID + "' height='125px'  style=' display: inline;' /></a></td></tr><tr><td>" + val.memberName + "</td></tr><tr><td>Views :" + val.clickCount + "</td></tr><tr><td>Mobile :" + +val.mobile + "</td></tr></table>");
                            });
                            break;
                        case 2:
                            $('#tabs-MostViewedprofiles').empty().append("");
                            $.each(items, function (i, val) {
                                $('#tabs-MostViewedprofiles').append("<table style='display: inline-block; border: solid 1px gray; width:155px;height:220px;padding:5px;margin:5px'><tr><td><a href='LawyerProfile.aspx?id=" + val.memID + "'><img src='MemPhoto/" + val.imageID + "' height='125px'  style=' display: inline;' /></a></td></tr><tr><td>" + val.memberName + "</td></tr><tr><td>Views :" + val.clickCount + "</td></tr><tr><td>Mobile :" + +val.mobile + "</td></tr></table>");
                            });
                            break;
                        case 3:
                            $('#tabs-LastViewedprofiles').empty().append("");
                            $.each(items, function (i, val) {
                                $('#tabs-LastViewedprofiles').append("<table style='display: inline-block; border: solid 1px gray; width:155px;height:220px;padding:5px;margin:5px'><tr><td><a href='LawyerProfile.aspx?id=" + val.memID + "'><img src='MemPhoto/" + val.imageID + "' height='125px'  style=' display: inline;' /></a></td></tr><tr><td>" + val.memberName + "</td></tr><tr><td>Mobile :" + +val.mobile + "</td></tr></table>");
                            });
                            break;
                        case 4:
                            $('#tabs-RecentlyUpdatedMembers').empty().append("");
                            $.each(items, function (i, val) {
                                $('#tabs-RecentlyUpdatedMembers').append("<table style='display: inline-block; border: solid 1px gray; width:155px;height:220px;padding:5px;margin:5px'><tr><td><a href='LawyerProfile.aspx?id=" + val.memID + "'><img src='MemPhoto/" + val.imageID + "' height='125px'  style=' display: inline;' /></a></td></tr><tr><td>" + val.memberName + "</td></tr><tr><td>Mobile :" + +val.mobile + "</td></tr></table>");
                            });
                            break;
                    }
                }
            });
        }
    });
});