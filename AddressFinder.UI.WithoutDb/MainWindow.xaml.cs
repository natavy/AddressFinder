using AddressFinder.UI.WithDb.ViewModel;
using System;
using System.Collections.Generic;

using System.Windows;


namespace AddressFinder.UI.WithoutDb
{

    public partial class MainWindow : Window
    {
        AddressViewModel model = new AddressViewModel();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = model; 
        }
    }
}
