using ApplicationCore.Interfaces;
using AppointmentScheduler.Interfaces;
using AppointmentScheduler.Model;
using Data.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
using System.Xml;

namespace AppointmentScheduler.Presenter
{
    public class AppointmentDashboardPresenter : BasePresenter
    {
        private IAppointmentDashboardView _appointmentView;
        private IAppointmentService _appointmentService;

        private BindingSource _appointmentListBindingSource = new BindingSource();
        private List<Appointment> _appointmentList;

        public AppointmentDashboardPresenter(IAppointmentDashboardView appointmentView, IAppointmentService appointmentService)
        {
            _appointmentView = appointmentView;
            _appointmentService = appointmentService;

            _appointmentView.FilterAppointments += FilterAppointments;
            _appointmentView.AddAppointment += AddAppointment;
            _appointmentView.EditAppointment += EditAppointment;
            _appointmentView.DeleteAppointment += DeleteAppointment;
            _appointmentView.GoHome += GoHome;

            LoadAllAppointments();
            _appointmentView.SetAppointmentListBindingSource(_appointmentListBindingSource);

            _appointmentView.Show();
        }

        private void FilterAppointments(object sender, EventArgs e)
        {
            var filterType = _appointmentView.CalendarFilterType;

            if (filterType == "All")
            {
                _appointmentListBindingSource.DataSource = _appointmentList;
                _appointmentView.CalendarFilterResultDisplay = "All Appointments";
            }

            if (filterType == "Day")
            {
                _appointmentListBindingSource.DataSource = _appointmentList.Where(a => a.Start.ToShortDateString() == _appointmentView.SelectedDate.ToShortDateString()).ToList();
                _appointmentView.CalendarFilterResultDisplay = $"Appointments in {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(_appointmentView.SelectedDate.Date.Month)}";
            }

            if (filterType == "Month")
            {
                _appointmentListBindingSource.DataSource = _appointmentList.Where(a => a.Start.Month == _appointmentView.SelectedDate.Month).ToList();
                _appointmentView.CalendarFilterResultDisplay = $"Appointments on {_appointmentView.SelectedDate.ToShortDateString()}";
            }

            _appointmentView.UpdateCalendarFilterResultDisplay();
        }

        private void DeleteAppointment(object sender, EventArgs e)
        {
            var canParse = int.TryParse(_appointmentView.SelectedAppointmentId, out var parsedId);

            if (canParse)
            {
                var result = MessageBox.Show("Are you sure you want to delete this appointment?", "Delete Appointment", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    _appointmentService.DeleteAppointment(parsedId);

                    MessageBox.Show("Success");

                    LoadAllAppointments();
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

        private void EditAppointment(object sender, EventArgs e)
        {
            int.TryParse(_appointmentView.SelectedAppointmentId, out var parsedId);

            var appointment = _appointmentList.Find(a => a.AppointmentId == parsedId);

            if (appointment == null)
            {
                MessageBox.Show("Could not find appointment to edit");
            }
            else
            {
                var presenter = Program.ServiceProvider.GetRequiredService<AppointmentPresenter>();
                presenter.SetAppointmentToEdit(appointment);

                presenter.RefreshAppointmentList += LoadAllAppointments;
            }
        }

        private void AddAppointment(object sender, EventArgs e)
        {
            var presenter = Program.ServiceProvider.GetRequiredService<AppointmentPresenter>();

            presenter.RefreshAppointmentList += LoadAllAppointments;
        }

        private void LoadAllAppointments(object sender = null, EventArgs e = null)
        {
            _appointmentList = _appointmentService.GetAllAppointments();
            _appointmentListBindingSource.DataSource = new AppointmentModel().FormatAppointments(_appointmentList);
        }
    }
}
