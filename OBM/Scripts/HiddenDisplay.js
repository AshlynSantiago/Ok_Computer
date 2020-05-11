var interval = 1000 * 5;

var ajax_match = function () {
    var tournamentID = $('#tournamentID').val();
    //console.log(eventID);
    $.ajax({
        type: 'GET',
        dataType: 'json',
        url: '/Events/HiddenList?id=' + tournamentID,
        success: MatchList,
        complete: setTimeout(ajax_match_update, interval),
        error: errorOnAjax
    });
}

var ajax_match_update = function () {
    var eventID = $("#eventID").val();
    $.ajax({
        type: 'GET',
        dataType: 'json',
        url: '/Events/MatchUpdate?id=' + eventID,
        complete: setTimeout(ajax_match, 0),
        error: errorOnAjax
    });
}

function ResetMatch(mymatch) {
    console.log(mymatch);
    //if (mymatch["PrereqMatch1ID"] == null && mymatch["PrereqMatch1ID"] == null) {
    //MAKE REQUEST TO START MATCH

    $.ajax({
        type: 'POST',
        url: '/Events/ResetMatch/',
        data: (mymatch),
        success: ajax_call,
        error: errorOnAjax
    });

    alert("Match Reset");
}


function MatchList(data) {
    $('#Matches').html(data["matchTable"]);
}

function errorOnAjax() {
    console.log("ERROR in ajax request.");
}

window.setTimeout(ajax_match_update, 0);