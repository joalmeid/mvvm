using System.Collections.Generic;
using System.Collections.ObjectModel;
using AdvancedSample.Models;
using AdvancedSample.Services;
using GalaSoft.MvvmLight;
using PropertyChanged;

namespace AdvancedSample.ViewModels
{
    [ImplementPropertyChanged]
    public class MainViewModel: ViewModelBase
    {
        public ObservableCollection<Person> People { get; set; }

        public MainViewModel(IDataService dataService)
        {
            IEnumerable<Person> people = dataService.GetItems();
            People = new ObservableCollection<Person>(people);
        }
    }
}
