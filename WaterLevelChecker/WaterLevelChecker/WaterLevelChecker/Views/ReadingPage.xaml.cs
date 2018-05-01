using System;
using System.Collections.Generic;
using SkiaSharp;
using Xamarin.Forms;
using Microcharts;

namespace WaterLevelChecker
{
    public partial class ReadingPage : ContentPage
    {
        public ReadingPage()
        {
            InitializeComponent();

            var entries = new[]
            {
                new Microcharts.Entry(150)
                {
                    Label = "January",
                    ValueLabel = "150",
                    Color = SKColor.Parse("#266489")
                },
                new Microcharts.Entry(200)
                {
                    Label = "February",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#68B9C0")
                },
                new Microcharts.Entry(250)
                {
                    Label = "March",
                    ValueLabel = "250",
                    Color = SKColor.Parse("#90D585")
                },

                new Microcharts.Entry(50)
                {
                    Label = "March",
                    ValueLabel = "50",
                    Color = SKColor.Parse("#c47094")
                }
            };

            var chart = new BarChart() { Entries = entries };
            var lineChart = new LineChart() { Entries = entries };
            var pieChart = new RadarChart { Entries = entries };

            this.chartView.Chart = chart;
            this.lineChartView.Chart = lineChart;
            this.pieChartView.Chart = pieChart;
        }
    }
}
