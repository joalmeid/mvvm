using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using PropertyChanged;
using Template10.Mvvm;
using Template10Sample.Models;
using Template10Sample.Services;
using Template10Sample.Views;

namespace Template10Sample.ViewModels
{
    [ImplementPropertyChanged]
    public class MainViewModel: ViewModelBase
    {
        private readonly IDataService _dataService;
        public ObservableCollection<Person> People { get; set; }

        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }

        public override void OnNavigatedTo(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            IEnumerable<Person> people = _dataService.GetItems();
            People = new ObservableCollection<Person>(people);
        }

        public void GoToDetail(object sender, ItemClickEventArgs e)
        {
            Person person = e.ClickedItem as Person;
            string fullName = $"{person.Name} {person.Surname}";
            NavigationService.Navigate(typeof (DetailPage), fullName);
        }
    }
}
