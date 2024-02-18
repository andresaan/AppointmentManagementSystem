using ApplicationCore.Interfaces;
using Data.Models;
using System;
using Infrastructure.Repositories;
using System.Collections.Generic;
using Infrastructure.Interfaces;

namespace ApplicationCore.Services
{
    public class CustomerService : ICustomerService
    {
        private IUnitOfWorkFactory _unitOfWorkFactory;
        public  CustomerService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public List<Customer> GetAllCustomers()
        {
            var unit = _unitOfWorkFactory.CreateUnitOfWork();
            var customerRepository = unit.CustomerRepository;

            var customers = customerRepository.GetAllCustomers();

            unit.Dispose();

            return customers;
        }

        public void SaveCustomerData(Customer customer)
        {
            var unit = _unitOfWorkFactory.CreateUnitOfWork();
            var customerRepository = unit.CustomerRepository;

            if (customer.CustomerId == -1)
            {
                customerRepository.AddCustomer(customer);
            }
            else
            {
                if (customer.CustomerId > 0)
                {
                    customerRepository.EditCustomer(customer);
                }
            }

            unit.Dispose();
        }

        public void DeleteCustomer(int id)
        {
            var unit = _unitOfWorkFactory.CreateUnitOfWork();
            var customerRepository = unit.CustomerRepository;

            customerRepository.DeleteCustomer(id);

            unit.Dispose();
        }
    }
}
