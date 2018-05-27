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
            _activityList.Add(new Reading() {ActivityReading = "Tomorrow's forecast in Oakland is Chance of Rain.", 
                ActivityReadingDate = DateTime.Now.ToString()});
        }

        public ObservableCollection<Reading> ActivityList
        {
            get { return _activityList; }
            set { SetProperty(ref _activityList, value); }
        }
        private ObservableCollection<Reading> _activityList;
    }
}
