using SQLiteDemo.Model;

namespace SQLiteDemo.Data
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(long id);
        void SaveCustomer(Customer customer);
    }
}