using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentScheduler.Interfaces
{
    public interface ICustomerDashboardView
    {
        string SelectedCustomerId { get; }

        string SelectedCustomerName { set; }
        string SelectedCustomerPhone { set; }
        string SelectedCustomerAddressLine1 { set; }
        string SelectedCustomerAddressLine2 { set; }
        string SelectedCustomerPostal { set; }
        string SelectedCustomerCity { set; }
        string SelectedCustomerCountry { set; }
        bool SelectedCustomerActive { set; }


        event EventHandler AddCustomer;
        event EventHandler EditCustomer;
        event EventHandler DeleteCustomer;
        event EventHandler DisplayCustomerDetails;
        event EventHandler GoHome;

        void SetCustomerListBindingSource(BindingSource binding);
        void Show();
    }
}
