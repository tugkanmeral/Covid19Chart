var raw_data = [];
var chart_date_as_label = [];
var chart_case_data = [];
Chart.defaults.global.defaultFontFamily = "Lato";
Chart.defaults.global.defaultFontSize = 18;

getRawData();

function getRawData() {
    $.ajax({
        url: 'Dashboard/RawChart/1',
        dataType: "json",
        type: "GET",
        error: function (xhr, status, error) {
            var err = eval("(" + xhr.responseText + ")");
            toastr.error(err.message);
        },
        success: function (data) {
            raw_data = data;
            plotChart();
        }
    });
}
function plotChart() {
    buildChartData();
    buildChart();
}
function buildChartData() {
    for (var i = 0; i < raw_data.length; i++) {
        chart_date_as_label.push(raw_data[i].date.split("T")[0]);
        chart_case_data.push(raw_data[i].case);
    }
}
function buildChart() {
    var ctx = document.getElementById('raw_chart');
    var myChart = new Chart(ctx, {
        type: 'line',
        data: {
            labels: chart_date_as_label,
            datasets: [{
                label: "Vaka",
                data: chart_case_data
            }]
        },
        options: {
            legend: {
                display: true,
                position: 'top'
            }
        }
    });
}