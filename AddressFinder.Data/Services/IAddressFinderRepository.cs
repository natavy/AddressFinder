using AddressFinder.Model;


namespace AddressFinder.Data.Services
{
    public interface IAddressFinderRepository
    {
        List<Address> GetAll();
       
    }
}
