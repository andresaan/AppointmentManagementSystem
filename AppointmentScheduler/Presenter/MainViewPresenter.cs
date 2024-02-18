using ApplicationCore.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using System.Windows.Forms;
using System.Data.Entity.ModelConfiguration.Configuration;
using AppointmentScheduler.Interfaces;

namespace AppointmentScheduler.Presenter
{
    public class MainViewPresenter : BasePresenter
    {
        private IMainView _mainView;

        private IAppointmentService _appointmentService;
        private List<Appointment> _appointmentList;

        public MainViewPresenter(IMainView mainView, IAppointmentService appointmentService)
        {
            _mainView = mainView;
            _appointmentService = appointmentService;
            _appointmentList = _appointmentService.GetAllAppointments();


            _mainView.ExitApplication += ExitApplication;
            _mainView.ShowCustomerDashboard += (sender, e) =>
            {
                Program.ServiceProvider.GetRequiredService<CustomerDashboardPresenter>();
                _mainView.Close();
            };
            _mainView.ShowAppointmentDashboard += (sender, e) =>
            {
                Program.ServiceProvider.GetRequiredService<AppointmentDashboardPresenter>();
                _mainView.Close();
            };
            _mainView.ShowReports += (sender, e) =>
            {
                Program.ServiceProvider.GetRequiredService<ReportPresenter>();
                _mainView.Close();
            };

            GetReminder();

            _mainView.Show();
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit the application?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void GetReminder()
        {
            var userId = Properties.Settings.Default.UserInformation.Id;

            var appointments = _appointmentList.FindAll(a => a.UserId == userId && a.Start <= DateTime.Now.AddMinutes(15) && a.Start >= DateTime.Now);

            var reminderMessage = "";

            foreach (Appointment appointment in appointments)
            {
                reminderMessage += $"Upcoming appointment with {appointment.Customer.CustomerName} at {appointment.Location} from {appointment.Start} to {appointment.End} \n";
            }


            if (!string.IsNullOrEmpty(reminderMessage))
            {
                _mainView.UpcomingAppointments = reminderMessage;
            }
        }
    }
}
