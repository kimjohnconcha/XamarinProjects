using System;
using System.Collections.ObjectModel;
using Prism.Navigation;

namespace WaterLevelChecker.ViewModels
{
    public class ActivityPageViewModel : ViewModelBase
    {

        public ActivityPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _activityList = new ObservableCollection<Reading>();
            _activityList.Add(new Reading() {ActivityReading = "Water Level below 3ft!", 
                ActivityReadingDate = DateTime.Now.AddDays(-6).ToString()});
            _activityList.Add(new Reading() {ActivityReading = "Water Level very high!", 
                ActivityReadingDate = DateTime.Now.AddDays(-7).ToString()});
            _activityList.Add(new Reading() {ActivityReading = "Water Level above 5ft!", 
                ActivityReadingDate = DateTime.Now.AddDays(-2).ToString()});
        }

        public ObservableCollection<Reading> ActivityList
        {
            get { return _activityList; }
            set { SetProperty(ref _activityList, value); }
        }
        private ObservableCollection<Reading> _activityList;
    }
}
