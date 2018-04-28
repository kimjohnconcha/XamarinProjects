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
                new Microcharts.Entry(200)
                {
                    Label = "January",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#266489")
                },
                new Microcharts.Entry(400)
                {
                    Label = "February",
                    ValueLabel = "400",
                    Color = SKColor.Parse("#68B9C0")
                },
                new Microcharts.Entry(-100)
                {
                    Label = "March",
                    ValueLabel = "-100",
                    Color = SKColor.Parse("#90D585")
                }
            };

            var chart = new BarChart() { Entries = entries };
            this.chartView.Chart = chart;
        }
    }
}
