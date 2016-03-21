using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Template10.Common;
using Template10Sample.Views;

namespace Template10Sample
{
    /// Documentation on APIs used in this page:
    /// https://github.com/Windows-XAML/Template10/wiki

    sealed partial class App : BootStrapper
    {
        public App()
        {
            InitializeComponent();
        }

        public override async Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            NavigationService.Navigate(typeof(MainPage));
            await Task.Yield();
        }
    }
}

