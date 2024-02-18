using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentScheduler.Interfaces
{
    public interface IAppointmentDashboardView
    {
        string CalendarFilterType { get; }
        DateTime SelectedDate { get; }
        string SelectedAppointmentId { get; }
        string CalendarFilterResultDisplay { set; }

        event EventHandler FilterAppointments;
        event EventHandler AddAppointment;
        event EventHandler EditAppointment;
        event EventHandler DeleteAppointment;
        event EventHandler GoHome;
        void SetAppointmentListBindingSource(BindingSource source);
        void UpdateCalendarFilterResultDisplay();
        void Show();
        void Close();
    }
}
