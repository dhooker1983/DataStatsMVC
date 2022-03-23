////// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
////// for details on configuring this project to bundle and minify static web assets.

////// Write your JavaScript code.

var graph =

    fetch('/home/getjson')
        .then(response => {
            return response.json();
        })
        .then(data => {
            graph = data;
            return graph;
        });

const showGraph = () => {

Highcharts.chart('container', {
    chart: {
        zoomType: 'xy'
    },
    title: {
        text: 'Total Monthly Calls and Average Handling Time'
    },
    subtitle: {
        text: 'Source: DataStats SQL'
    },
    xAxis: [{
        categories: graph['dateRange'],
        crosshair: true
    }],
    yAxis: [{ // Primary yAxis
        labels: {
            format: '{value} secs',
            style: {
                color: Highcharts.getOptions().colors[1]
            }
        },
        title: {
            text: 'AHT',
            style: {
                color: Highcharts.getOptions().colors[1]
            }
        }
    }, { // Secondary yAxis
        title: {
            text: 'Calls',
            style: {
                color: Highcharts.getOptions().colors[0]
            }
        },
        labels: {
            format: '{value} call(s)',
            style: {
                color: Highcharts.getOptions().colors[0]
            }
        },
        opposite: true
    }],
    tooltip: {
        shared: true
    },
    legend: {
        layout: 'vertical',
        align: 'left',
        x: 120,
        verticalAlign: 'top',
        y: 100,
        floating: true,
        backgroundColor:
            Highcharts.defaultOptions.legend.backgroundColor || // theme
            'rgba(255,255,255,0.25)'
    },
    series: [{
        name: 'Calls',
        type: 'column',
        yAxis: 1,
        data: graph['graphData'],
        tooltip: {
            valueSuffix: ''
        }

    }, {
        name: 'AHT',
        type: 'spline',
        data: [305, 230, 310, 184],
        tooltip: {
            valueSuffix: ' secs'
        }
    }]
});
}

setTimeout(showGraph, 200);

const toggleView = () => {
    var graph = document.getElementById('callGraph');
    var table = document.getElementById('callTable');


    graph.classList.toggle('hide');
    table.classList.toggle('hide');
}
