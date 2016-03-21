using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace NoMvvmSample.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void OnSayHelloClicked(object sender, RoutedEventArgs e)
        {
            string result = $"Hello {Username.Text}";
            Message.Text = result;
        }
    }
}
