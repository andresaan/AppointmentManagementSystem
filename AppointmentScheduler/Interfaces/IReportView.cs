using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentScheduler.Interfaces
{
    public interface IReportView
    {
        string CustomerActivityFilter { get; }
        string UserFilter { get; }
        int MonthFilter { get; }
        string AppointmentTypeFilter { get; }

        event EventHandler FilterAppointments;
        event EventHandler FilterCustomers;
        event EventHandler GoHome;

        void SetCustomerListBindingSource(BindingSource source);
        void SetAppointmentListBindingSource(BindingSource source);
        void SetUserList(List<string> userList);
        void SetAppoitmetnTypesList(HashSet<string> appointmentTypes);
        void Show();
        void Close();   
    }
}
