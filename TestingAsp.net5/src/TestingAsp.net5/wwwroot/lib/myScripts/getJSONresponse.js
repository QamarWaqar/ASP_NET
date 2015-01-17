$("#btnGetMovies").click(function () {
    var actionUrl = "http://" + location.host + "/Waqar/Movies/";
    $.getJSON(actionUrl, displayData);
});

    function displayData(response) {
        if (response != null) {
            for (var i = 0; i < response.length; i++) {
                $("#movieList").append("<li>" + response[i].Title + " " + response[i].Genre + " " + response[i].Year + "</li>")
            }
        }
    }