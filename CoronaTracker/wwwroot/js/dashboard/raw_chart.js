var chart_case_data = [];
var chart_death_data = [];
var chart_recovered_data = [];

function plotRawChart() {
    buildRawChartData();
    buildRawChart();
}

function buildRawChartData() {
    for (var i = 0; i < raw_data.length; i++) {
        chart_case_data.push(raw_data[i].case);
        chart_death_data.push(raw_data[i].death);
        chart_recovered_data.push(raw_data[i].recovered);
    }
}

function buildRawChart() {
    var rc = document.getElementById('raw_chart');
    var rawChart = new Chart(rc, {
        type: 'line',
        data: {
            labels: chart_date_as_label,
            datasets: [{
                label: "Vaka",
                data: chart_case_data,
                borderColor: "#A0A0A0",
                fill: false
            },
            {
                label: "Ölüm",
                data: chart_death_data,
                borderColor: "#BE3232",
                fill: false
            },
            {
                label: "İyileşme",
                data: chart_recovered_data,
                borderColor: "#00B505",
                fill: false
            }]
        },
        options: {
            legend: {
                display: true,
                position: 'top'
            },
            title: {
                display: true,
                text: 'Türkiye COVID-19 (kümülatif)'
            }
        }
    });
}