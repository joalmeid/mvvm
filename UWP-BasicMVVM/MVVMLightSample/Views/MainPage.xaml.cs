using Windows.UI.Xaml.Controls;
using BasicSample.ViewModel;

namespace BasicSample.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = new MainViewModel();
        }
    }
}
