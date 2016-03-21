using Windows.UI.Xaml.Controls;
using Template10Sample.ViewModels;

namespace Template10Sample.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            ViewModel = this.DataContext as MainViewModel;
        }
    }
}
