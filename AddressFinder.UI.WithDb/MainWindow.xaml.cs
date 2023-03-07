
using AddressFinder.UI.WithDb.ViewModel;
using System.Windows;


namespace AddressFinder.UI.WithDb
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new AddressViewModel();
        }
    }
}
