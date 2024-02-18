using AppointmentScheduler.Model;
using AppointmentScheduler.View;
using Data.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationCore.Interfaces;
using AppointmentScheduler.Interfaces;
using ApplicationCore.Services;

namespace AppointmentScheduler.Presenter
{
    public class CustomerDashboardPresenter : BasePresenter
    {
        private ICustomerDashboardView _dashboardView;
        private ICustomerService _customerService;

        private List<Customer> _customerList;
        private BindingSource _customerListBindingSource = new BindingSource();

        public CustomerDashboardPresenter(ICustomerDashboardView dashboardView, ICustomerService customerService)
        {
            _dashboardView = dashboardView;
            _customerService = customerService;

            _dashboardView.EditCustomer += EditCustomer;
            _dashboardView.AddCustomer += AddCustomer;
            _dashboardView.DeleteCustomer += DeleteCustomer;
            _dashboardView.DisplayCustomerDetails += DisplayCustomerDetails;
            _dashboardView.GoHome += GoHome;

            LoadAllClients();
            _dashboardView.SetCustomerListBindingSource(_customerListBindingSource);

            _dashboardView.Show();
        }

        private void DisplayCustomerDetails(object sender, EventArgs e)
        {
            var customer = FindCustomer();

            _dashboardView.SelectedCustomerName = customer.CustomerName;
            _dashboardView.SelectedCustomerPhone = customer.Address.Phone;
            _dashboardView.SelectedCustomerPostal = customer.Address.PostalCode;
            _dashboardView.SelectedCustomerAddressLine1 = customer.Address.AddressLine;
            _dashboardView.SelectedCustomerAddressLine2 = customer.Address.AddressLine2;
            _dashboardView.SelectedCustomerCity = customer.Address.City.CityName;
            _dashboardView.SelectedCustomerCountry = customer.Address.City.Country.CountryName;
            _dashboardView.SelectedCustomerActive = customer.Active;
        }

        public void LoadAllClients(object sender = null, EventArgs e = null)
        {
            _customerList = _customerService.GetAllCustomers();
            _customerListBindingSource.DataSource = _customerList;
        }

        private void AddCustomer(object sender, EventArgs e)
        {
            var customerPresenter = Program.ServiceProvider.GetRequiredService<CustomerPresenter>();

            customerPresenter.RefreshCustomerList += LoadAllClients;
        }

        private void EditCustomer(object sender, EventArgs e)
        {
            var customer = FindCustomer();

            if (customer != null)
            {
                var customerPresenter = new CustomerPresenter(new CustomerView()
                {
                    CustomerId = customer.CustomerId,
                    CustomerName = customer.CustomerName,
                    CustomerAddress1 = customer.Address.AddressLine,
                    CustomerAddress2 = customer.Address.AddressLine2,
                    CustomerPhone = customer.Address.Phone,
                    CustomerPostal = customer.Address.PostalCode,
                    CustomerCity = customer.Address.City.CityName,
                    CustomerCountry = customer.Address.City.Country.CountryName,
                    CustomerActive = customer.Active
                }, Program.ServiceProvider.GetRequiredService<ICustomerService>());

                customerPresenter.RefreshCustomerList += LoadAllClients;
            }
        }

        private void DeleteCustomer(object sender, EventArgs e)
        {
            var canParse = int.TryParse(_dashboardView.SelectedCustomerId, out var parsedId);

            if (canParse)
            {
                var result = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    _customerService.DeleteCustomer(parsedId);

                    MessageBox.Show("Success");

                    LoadAllClients();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Could not find appointment to delete");
            }
        }

        public Customer FindCustomer()
        {
            var canParse = int.TryParse(_dashboardView.SelectedCustomerId, out var customerId);

            if (canParse)
            {
                var customer = _customerList.Find(c => c.CustomerId == customerId);

                return customer;
            }

            MessageBox.Show("Cannot find customer to edit");
            return null;
        }

    }
}
