using Data.Models;
using System.Collections.Generic;

namespace ApplicationCore.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();
        void SaveCustomerData(Customer customer);
        void DeleteCustomer(int id);
    }
}
