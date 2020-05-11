var interval = 1000 * 5;

var ajax_call = function () {
    var tournamentID = $('#tournamentID').val();
    //console.log(eventID);
    $.ajax({
        type: 'GET',
        dataType: 'json',
        url: '/Events/HiddenList?id=' + tournamentID,
        success: MatchList,
        complete: setTimeout(ajax_call, interval),
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

window.setTimeout(ajax_call, 0);