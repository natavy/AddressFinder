
using AddressFinder.Model;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;


namespace AddressFinder.UI.WithDb.ViewModel
{
    public class AddressViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Address>? _addresses;
        private Address? _selectedAddress;
        private int id;
        private string? name;

        public AddressViewModel()
        {

            GetData();

        }

        public event NotifyCollectionChangedEventHandler? CollectionChanged;
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value; OnPropertyChanged("Id");

            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }

        }


        public ObservableCollection<Address> Addresses
        {
            get
            {
                return _addresses;
            }
            set
            {
                if (value != null)
                {
                    _addresses = value;
                    OnPropertyChanged("Addresses");
                }

            }
        }

        public Address SelectedAddress
        {

            get
            {
                return _selectedAddress;
            }
            set
            {
                if (value != null)
                {
                    _selectedAddress = value;
                    OnPropertyChanged("SelectedAddress");
                }

            }
        }
        public void GetData()
        {

            Addresses = new ObservableCollection<Address>()
                {
                    new Address{Name="Ulitsa Sofia, 1320, kv Izgrev, Bankya, Sofia, Sofia-grad"},
                    new Address{Name="Ulitsa Sofia, 1257, Kubratovo, Sofia, Sofia-grad"},
                    new Address{Name="Ulitsa Sofia, 1225, kv. Orlandovtsi, Serdika, Sofia, Sofia-grad"},
                    new Address{Name="Ulitsa Sveta Sofia, 1000, Tsentar, Triaditsa, Sofia, Sofia-grad"},
                    new Address{Name="Sofia, Stolichna Obshtina, Sofia-Capital"}

                };

        }


    }
}
