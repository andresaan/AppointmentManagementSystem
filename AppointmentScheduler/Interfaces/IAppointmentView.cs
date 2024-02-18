using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentScheduler.Interfaces
{
    public interface IAppointmentView
    {
        bool IsEdit { get; set; }
        string AppointmentId { get; set; }
        int CustomerId { get; set; }
        int UserId { get; set; }
        string CustomerName { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        string Location { get; set; }
        string Contact { get; set; }
        string Type { get; set; }
        string Url { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }


        event EventHandler SaveAppointmentData;


        void SetBindingLists(BindingSource customerBindingSource, BindingSource userBindingSource);
        void SetCustomerAndUserSelections();
        void Show();
        void Close();
    }
}
