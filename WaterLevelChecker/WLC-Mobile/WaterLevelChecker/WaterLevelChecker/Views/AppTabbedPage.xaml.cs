using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WaterLevelChecker
{
    public partial class AppTabbedPage : TabbedPage
    {
        public AppTabbedPage()
        {
            InitializeComponent();

            this.Children.Add(
                new Views.ActivityPage(){}
            );

            this.Children.Add(
                new ReadingPage()
            );

            this.Children.Add(
                new Views.SettingsPage()
             );
        }
    }
}
