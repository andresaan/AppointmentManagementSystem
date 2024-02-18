using AppointmentScheduler.Model;
using Data;
using System;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using ApplicationCore.Validation;
using System.Resources;
using Data.Models;
using System.Xml.Linq;
using ApplicationCore.Interfaces;
using AppointmentScheduler.Interfaces;

namespace AppointmentScheduler.Presenter
{
    public class CustomerPresenter : BasePresenter
    {
        private ICustomerView _customerView;
        private ICustomerService _customerService;

        public event EventHandler RefreshCustomerList;

        public CustomerPresenter(ICustomerView customerView, ICustomerService customerService)
        {
            _customerView = customerView;
            _customerService = customerService;

            _customerView.SaveCustomerData += SaveCustomerData;
            _customerView.Cancel += Cancel;

            _customerView.Show();
        }

        private void SaveCustomerData(object sender, EventArgs e)
        {
            var customerModel = new CustomerModel(_customerView.CustomerId, _customerView.CustomerName, _customerView.CustomerPhone, _customerView.CustomerAddress1, _customerView.CustomerAddress2, _customerView.CustomerCity, _customerView.CustomerCountry, _customerView.CustomerPostal, _customerView.CustomerActive);
            var errorMessage = new ModelDataValidator().Validate(customerModel);

            if (errorMessage == null)
            {
                var user = Properties.Settings.Default.UserInformation.Username;
                var customer = new Customer()
                {
                    CustomerId = customerModel.Id,
                    CustomerName = customerModel.Name.Trim(),
                    Active = customerModel.IsActive,
                    CreateDate = DateTime.Now,
                    CreatedBy = user,
                    LastUpdate = DateTime.Now,
                    LastUpdateBy = user,

                    Address = new Address()
                    {
                        AddressLine = customerModel.AddressLine1.Trim(),
                        AddressLine2 = customerModel.AddressLine2.Trim(),
                        PostalCode = customerModel.PostalCode.Trim(),
                        Phone = customerModel.Phone.Trim(),
                        CreateDate = DateTime.Now,
                        CreatedBy = user,
                        LastUpdateBy = user,
                        LastUpdate = DateTime.Now,
                        City = new City()
                        {
                            CityName = customerModel.City.Trim(),
                            CreateDate = DateTime.Now,
                            CreatedBy = user,
                            LastUpdateBy = user,
                            LastUpdate = DateTime.Now,
                            Country = new Country()
                            {
                                CountryName = customerModel.Country.Trim(),
                                CreateDate = DateTime.Now,
                                CreatedBy = user,
                                LastUpdateBy = user,
                                LastUpdate = DateTime.Now,
                            }

                        }
                    }
                };

                _customerService.SaveCustomerData(customer);

                _customerView.Close();
                MessageBox.Show("Success!");

                RefreshCustomerList?.Invoke(this, EventArgs.Empty);
                return;
            }

            MessageBox.Show(errorMessage);
        }

        private void Cancel(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _customerView.Close();
            }
        }
    }
}
