using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Data.Models;
using ApplicationCore.Interfaces;
using System.Collections.Generic;

namespace AppointmentScheduler.Model
{
    public class CustomerModel
    {
        public int Id { get; set; }

        [Display(Name = "Customer Name")]
        [Required(ErrorMessage = "Customer Name: cannot be empty")]
        public string Name { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number: cannot be empty")]
        [RegularExpression("^[0-9-]*$", ErrorMessage = "Phone number: must be numbers and dashes only")]
        //[RegularExpression("^(\\+\\d{1,2}\\s?)?\\(?\\d{3}\\)?[\\s.-]?\\d{3}[\\s.-]?\\d{4}$", ErrorMessage = "Phone number must be numbers and dashes only")]
        public string Phone { get; set; }

        [Display(Name = "Address Line One")]
        [Required(ErrorMessage = "Address: cannot be empty")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        [Display(Name = "City Name")]
        [Required(ErrorMessage = "City: cannot be empty")]
        public string City { get; set; }

        [Display(Name = "Country Name")]
        [Required(ErrorMessage = "Country Name: cannot be empty")]
        public string Country { get; set; }

        [Display(Name = "Zip Code")]
        [Required(ErrorMessage = "Zip Code: cannot be empty")]
        public string PostalCode { get; set; }

        public bool IsActive { get; set; }

        public CustomerModel()
        {
            
        }

        public CustomerModel(int customerId, string name, string phone, string addressLine1, string addressLine2, string city, string country, string postalCode, bool isActive)
        {
            Id = customerId;
            Name = name;
            Phone = phone;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            Country = country;
            PostalCode = postalCode;
            IsActive = isActive;
        }

        public List<CustomerModel> FormatCustomer(List<Customer> customers)
        {
            var formattedCustomers = new List<CustomerModel>();

            foreach (Customer customer in customers)
            {
                var customerModel = new CustomerModel(customer.CustomerId, customer.CustomerName, customer.Address.Phone, customer.Address.AddressLine, customer.Address.AddressLine2, customer.Address.City.CityName, customer.Address.City.Country.CountryName, customer.Address.PostalCode, customer.Active);

                formattedCustomers.Add(customerModel);
            }

            return formattedCustomers;
        }
    }
}
