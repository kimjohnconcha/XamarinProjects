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

            this.Children.Add(new Views.ActivityPage(){ Title="Activity" });
            this.Children.Add(new ReadingPage() {Title="Water Reading"});
            this.Children.Add(new Views.SettingsPage() { Title = "Settings" });
        }
    }
}
