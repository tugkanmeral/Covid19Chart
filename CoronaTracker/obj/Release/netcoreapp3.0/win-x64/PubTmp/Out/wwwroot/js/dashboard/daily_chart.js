var chart_daily_case_data = [];
var chart_daily_death_data = [];
var chart_daily_recovered_data = [];

function plotDailyChart() {
    buildDailyChartData();
    buildDailyChart();
}

function buildDailyChartData() {
    for (var i = 1; i < raw_data.length; i++) {
        chart_daily_case_data.push(raw_data[i].case - raw_data[i-1].case);
        chart_daily_death_data.push(raw_data[i].death - raw_data[i-1].death);
        chart_daily_recovered_data.push(raw_data[i].recovered - raw_data[i-1].recovered);
    }
}

function buildDailyChart() {
    var dc = document.getElementById('daily_chart');
    var dailyChart = new Chart(dc, {
        type: 'bar',
        data: {
            labels: chart_date_as_label,
            datasets: [{
                label: "Vaka",
                data: chart_daily_case_data,
                borderColor: "#A0A0A0",
                backgroundColor: "#A0A0A0",
                fill: true
            },
            {
                label: "Ölüm",
                data: chart_daily_death_data,
                borderColor: "#BE3232",
                backgroundColor: "#BE3232",
                fill: true
            },
            {
                label: "İyileşme",
                data: chart_daily_recovered_data,
                borderColor: "#00B505",
                backgroundColor: "#00B505",
                fill: true
            }]
        },
        options: {
            legend: {
                display: true,
                position: 'top'
            },
            title: {
                display: true,
                text: 'Türkiye COVID-19 günlük artış değerleri'
            }
        }
    });
}