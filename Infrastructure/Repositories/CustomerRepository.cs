using Data.Models;
using Infrastructure.Interfaces;
using Infrastructure.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private ClientScheduleDbContext _dbContext;
        public CustomerRepository(ClientScheduleDbContext clientScheduleDbContext)
        {
            _dbContext = clientScheduleDbContext;
        }

        public List<Customer> GetAllCustomers()
        {
            return _dbContext.Customer.Include("Address.City.Country").ToList();
        }

        public void AddCustomer(Customer customer)
        {
            customer.Address = RemoveDuplicateAddressRefrences(customer.Address);
            _dbContext.Customer.Add(customer);

            _dbContext.SaveChanges();
        }

        public void EditCustomer(Customer customer)
        {
            var address = RemoveDuplicateAddressRefrences(customer.Address);

            var existingCustomer = _dbContext.Customer.Include("Address.City.Country").FirstOrDefault(c => c.CustomerId == customer.CustomerId);

            existingCustomer.CustomerName = customer.CustomerName;
            existingCustomer.AddressId = existingCustomer.AddressId;
            existingCustomer.LastUpdate = customer.LastUpdate;
            existingCustomer.LastUpdateBy = customer.LastUpdateBy;
            existingCustomer.Active = customer.Active;

            var existingCustomerAddress = _dbContext.Entry(existingCustomer.Address);

            address.AddressId = existingCustomer.AddressId;
            existingCustomerAddress.CurrentValues.SetValues(address);

            _dbContext.SaveChanges();
        }

        public Address RemoveDuplicateAddressRefrences(Address address)
        {
            var existingCountry = _dbContext.Country.FirstOrDefault(c => c.CountryName.ToLower() == address.City.Country.CountryName.ToLower());

            if (existingCountry == null)
            {
                return address;
            }
            else
            {
                var existingCityCountry = _dbContext.City.FirstOrDefault(c => c.CityName.ToLower() == address.City.CityName.ToLower() && c.Country.CountryName.ToLower() == address.City.Country.CountryName.ToLower());

                address.City.Country = null;
                address.City.CountryId = existingCountry.CountryId;

                if (existingCityCountry != null)
                {
                    address.City = null;
                    address.CityId = existingCityCountry.CityId;
                }

                return address;
            }
        }

        public void DeleteCustomer(int id)
        {
            var customer = _dbContext.Customer.Include("Appointment").Include("Address").SingleOrDefault(c => c.CustomerId == id);

            if (customer != null)
            {
                _dbContext.Appointment.RemoveRange(customer.Appointment);

                _dbContext.Address.Remove(customer.Address);

                _dbContext.Customer.Remove(customer);
            }

            _dbContext.SaveChanges();
        }
    }
}
