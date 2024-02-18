using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface ICustomerRepository
    {

        List<Customer> GetAllCustomers();

        void AddCustomer(Customer customer);

        void EditCustomer(Customer customer);

        void DeleteCustomer(int id);
    }
}
