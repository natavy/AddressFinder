

using AddressFinder.Model;

namespace AddressFinder.Data.Services
{
    public class AddressFinderRepository : IAddressFinderRepository
    {
        private  AddressFinderDbContext? _db;
        public AddressFinderRepository()
        {
            _db = new AddressFinderDbContext();
        }
        public List<Address> GetAll()
        {
            return _db.Addresses.ToList();
        }
    }
}
