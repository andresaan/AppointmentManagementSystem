using ApplicationCore.Interfaces;
using AppointmentScheduler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models;
using AppointmentScheduler.Model;
using AppointmentScheduler.View;

namespace AppointmentScheduler.Presenter
{
    public class ReportPresenter : BasePresenter
    {
        private IReportView _reportView;
        private ICustomerService _customerService;
        private IUserService _userService;
        private IAppointmentService _appointmentService;

        private List<Customer> _customerList;
        private BindingSource _customerListBindingSource = new BindingSource();

        private List<Appointment> _appointmentList;
        private BindingSource _appointmentListBindingSource = new BindingSource();

        public ReportPresenter(IReportView reportView, ICustomerService customerService, IUserService userService, IAppointmentService appointmentService)
        {
            _reportView = reportView;
            _customerService = customerService;
            _userService = userService;
            _appointmentService = appointmentService;

            _reportView.FilterCustomers += FilterCustomers;
            _reportView.FilterAppointments += FilterAppointments;
            _reportView.GoHome += GoHome;

            LoadAllCustomers();
            _reportView.SetCustomerListBindingSource(_customerListBindingSource);

            LoadAllAppointments();
            _reportView.SetAppointmentListBindingSource(_appointmentListBindingSource);

            SetViewUserList();
            SetViewAppointmentTypeList();

            _reportView.Show();
        }

        private void LoadAllCustomers()
        {
            _customerList = _customerService.GetAllCustomers();
            _customerListBindingSource.DataSource = new CustomerModel().FormatCustomer(_customerList);
        }

        private void LoadAllAppointments()
        {
            _appointmentList = _appointmentService.GetAllAppointments();
            _appointmentListBindingSource.DataSource = new AppointmentModel().FormatAppointments(_appointmentList);
        }

        private void SetViewUserList()
        {
            var users = _userService.GetAllUsers();

            var userList = new List<string>();

            foreach (User user in users)
            {
                userList.Add(user.UserName);
            }

            _reportView.SetUserList(userList);
        }

        private void SetViewAppointmentTypeList()
        {
            var appointmentTypes = new HashSet<string>();

            foreach (Appointment appointment in _appointmentList)
            {
                appointmentTypes.Add(appointment.Type);
            }

            _reportView.SetAppoitmetnTypesList(appointmentTypes);
        }

        private void FilterCustomers(object sender, EventArgs e)
        {
            var filteredCustomers = _customerList;

            filteredCustomers = ApplyActivityFilter(filteredCustomers);

            _customerListBindingSource.DataSource = new CustomerModel().FormatCustomer(filteredCustomers); ;
        }

        private List<Customer> ApplyActivityFilter(List<Customer> customers)
        {
            if (_reportView.CustomerActivityFilter == "No Selection")
            {
                return customers;
            }
            else
            {
                if (_reportView.CustomerActivityFilter == "True")
                {
                    return customers.Where(c => c.Active == true).ToList();
                }
                else
                {
                    return customers.Where(c => c.Active == false).ToList();
                }
            }
        }

        private void FilterAppointments(object sender, EventArgs e)
        {
            var filteredAppointments = _appointmentList;

            filteredAppointments = ApplyMonthFilter(filteredAppointments);

            filteredAppointments = ApplyUserFilter(filteredAppointments);

            filteredAppointments = ApplyAppointmentTypeFilter(filteredAppointments);

            _appointmentListBindingSource.DataSource = new AppointmentModel().FormatAppointments(filteredAppointments);
        }

        private List<Appointment> ApplyMonthFilter(List<Appointment> appointments)
        {
            if (_reportView.MonthFilter == 0)
            {
                return appointments;
            }
            else
            {
                return appointments.Where(a => a.Start.Month == _reportView.MonthFilter).ToList();
            }
        }

        private List<Appointment> ApplyUserFilter(List<Appointment> appointments)
        {
            if (_reportView.UserFilter == "No Selection")
            {
                return appointments;
            }
            else
            {
                return appointments.Where(a => a.User.UserName == _reportView.UserFilter).ToList();  
            }
        }

        private List<Appointment> ApplyAppointmentTypeFilter(List<Appointment> appointments)
        {
            if (_reportView.AppointmentTypeFilter == "No Selection")
            {
                return appointments;
            }
            else
            {
                return appointments.Where(a => a.Type == _reportView.AppointmentTypeFilter).ToList();
            }
        }
    }
}
