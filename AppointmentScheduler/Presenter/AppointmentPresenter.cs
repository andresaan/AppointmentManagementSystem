using ApplicationCore.Interfaces;
using ApplicationCore.Validation;
using AppointmentScheduler.Interfaces;
using AppointmentScheduler.Model;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentScheduler.Presenter
{
    public class AppointmentPresenter : BasePresenter
    {
        private IAppointmentView _appointmentView;
        private ICustomerService _customerService;
        private IUserService _userService;
        private IAppointmentService _appointmentService;

        private BindingSource _customerListBindingSource = new BindingSource();
        private BindingSource _userListBindingSource = new BindingSource();

        private List<User> _userList;
        private List<Customer> _customerList;

        public AppointmentPresenter(IAppointmentView appointmentView, IAppointmentService appointmentService, ICustomerService customerService, IUserService userService)
        {
            _appointmentView = appointmentView;
            _appointmentService = appointmentService;
            _customerService = customerService;
            _userService = userService;

            _appointmentView.SaveAppointmentData += SaveAppointmentData;

            LoadCustomersAndUsers();
            _appointmentView.SetBindingLists(_customerListBindingSource, _userListBindingSource);


            _appointmentView.Show();
        }

        public event EventHandler RefreshAppointmentList;


        private void LoadCustomersAndUsers()
        {
            _customerList = _customerService.GetAllCustomers();
            _customerListBindingSource.DataSource = _customerList;

            _userList = _userService.GetAllUsers();
            _userListBindingSource.DataSource = _userList;
        }

        private void SaveAppointmentData(object sender, EventArgs e)
        {
            var canParse = int.TryParse(_appointmentView.AppointmentId, out var parsedAppointmentId);

            var appointmentModel = new AppointmentModel()
            {
                AppointmentId = canParse ? parsedAppointmentId : -1,
                CustomerId = _appointmentView.CustomerId,
                UserId = _appointmentView.UserId,
                CustomerName = _appointmentView.CustomerName,
                Title = _appointmentView.Title,
                Description = _appointmentView.Description,
                Location = _appointmentView.Location,
                Contact = _appointmentView.Contact,
                Type = _appointmentView.Type,
                Url = _appointmentView.Url,
                StartTime = _appointmentView.StartTime,
                EndTime = _appointmentView.EndTime
            };

            var error = new ModelDataValidator().Validate(appointmentModel); ;
            
            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            var user = Properties.Settings.Default.UserInformation.Username;
            var appointment = new Appointment()
            {
                AppointmentId = appointmentModel.AppointmentId,
                CustomerId = appointmentModel.CustomerId,
                UserId = appointmentModel.UserId,
                Title = appointmentModel.Title,
                Description = appointmentModel.Description,
                Location = appointmentModel.Location,
                Contact = appointmentModel.Contact,
                Type = appointmentModel.Type,
                Url = appointmentModel.Url,
                Start = appointmentModel.StartTime.ToUniversalTime(),
                End = appointmentModel.EndTime.ToUniversalTime(),
                LastUpdate = DateTime.Now.ToUniversalTime(),
                LastUpdateBy = user
            };

            error = _appointmentService.SaveAppointment(appointment);

            if (error == null)
            {
                MessageBox.Show("Success!");
                _appointmentView.Close();

                RefreshAppointmentList?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        public void SetAppointmentToEdit(Appointment appointment)
        {
            _appointmentView.AppointmentId = appointment.AppointmentId.ToString();
            _appointmentView.CustomerId = appointment.CustomerId;
            _appointmentView.UserId = appointment.UserId;
            _appointmentView.CustomerName = appointment.Customer.CustomerName;
            _appointmentView.Title = appointment.Title;
            _appointmentView.Description = appointment.Description;
            _appointmentView.Location = appointment.Location;
            _appointmentView.Contact = appointment.Contact;
            _appointmentView.Type = appointment.Type;
            _appointmentView.Url = appointment.Url;
            _appointmentView.StartTime = appointment.Start;
            _appointmentView.EndTime = appointment.End;

            _appointmentView.SetCustomerAndUserSelections();

            _appointmentView.IsEdit = true;
        }
    }
}
