using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;
using PropertyChanged;
using Template10.Mvvm;

namespace Template10Sample.ViewModels
{
    [ImplementPropertyChanged]
    public class DetailViewModel : ViewModelBase
    {
        public string FullName { get; set; }

        public string Notes { get; set; }

        public override void OnNavigatedTo(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            FullName = parameter.ToString();
            //if (state.Any())
            //{
            //    Notes = state["Notes"].ToString();
            //    state.Clear();
            //}
        }

        public override Task OnNavigatedFromAsync(IDictionary<string, object> state, bool suspending)
        {
            //if (suspending)
            //{
            //    state.Add("Notes", Notes);
            //}

            return base.OnNavigatedFromAsync(state, suspending);
        }
    }
}
