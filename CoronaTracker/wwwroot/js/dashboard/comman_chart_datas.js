var raw_data = [];
var chart_date_as_label = [];
Chart.defaults.global.defaultFontFamily = "Lato";
Chart.defaults.global.defaultFontSize = 18;

$.ajax({
    url: '/Dashboard/GetRawDataByCountryId/1', // id = 1 is for Turkey and hardcoded for now
    dataType: "json",
    type: "GET",
    error: function (xhr, status, error) {
        var err = eval("(" + xhr.responseText + ")");
        toastr.error(err.message);
    },
    success: function (data) {
        raw_data = data;
        buildLabel();
        plotCharts();
    }
});

function buildLabel() {
    for (var i = 0; i < raw_data.length; i++) {
        chart_date_as_label.push(buildDateString(raw_data[i]));
    }
}

function plotCharts() {
    plotRawChart();
    plotDailyChart();
    plotCaseTestChart();
}

function buildDateString(_date) {
    var clearDate = _date.date.split("T")[0];
    clearDate = clearDate.replace("2020-", "")
    clearDate = clearDate.replace("-", "/")
    return clearDate;
}