﻿function GeneraPieChart(categoryList) {
    am4core.useTheme(am4themes_animated);

    var chart = am4core.create("chartdiv", am4charts.PieChart3D);
    chart.hiddenState.properties.opacity = 0;

    chart.legend = new am4charts.Legend();

    chart.data = categoryList;


    var series = chart.series.push(new am4charts.PieSeries3D());
    series.dataFields.value = "sumPercentage";
    series.dataFields.category = "nameCategory";    
}