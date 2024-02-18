using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentScheduler.Interfaces
{
    public interface IMainView
    {
        string UpcomingAppointments { set; }


        event EventHandler ShowCustomerDashboard;
        event EventHandler ShowAppointmentDashboard;
        event EventHandler ShowReports;
        event EventHandler ExitApplication;

        void Show();
        void Close();
    }
}
