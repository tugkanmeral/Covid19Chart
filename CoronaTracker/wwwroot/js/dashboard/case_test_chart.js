var chart_case_test_ratio_data = [];

function plotCaseTestChart() {
    buildTestCaseChartData();
    buildTestCaseChart();
}

function buildTestCaseChartData() {
    for (var i = 0; i < raw_data.length; i++) {
        if (raw_data[i].testAmount != null) {
            chart_case_test_ratio_data.push((raw_data[i].case - raw_data[i - 1].case) / raw_data[i].testAmount);
        }
        else {
            chart_case_test_ratio_data.push(0);
        }
    }
}

function buildTestCaseChart() {
    var ctc = document.getElementById('case_test_chart');
    var casetestChart = new Chart(ctc, {
        type: 'bar',
        data: {
            labels: chart_date_as_label,
            datasets: [{
                label: "Vaka/Test",
                data: chart_case_test_ratio_data,
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
                text: 'Türkiye COVID-19 Vaka-Test Oranı (vaka/test)'
            }
        }
    });
}