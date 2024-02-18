using AppointmentScheduler.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentScheduler.View
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();

            btnShowCustDash.Click += delegate { ShowCustomerDashboard?.Invoke(this, EventArgs.Empty); };
            btnShowApptDash.Click += delegate { ShowAppointmentDashboard?.Invoke(this, EventArgs.Empty); };
            btnShowReports.Click += delegate { ShowReports?.Invoke(this, EventArgs.Empty); };
            btnExitApp.Click += delegate { ExitApplication?.Invoke(this, EventArgs.Empty); };
        }

        public string UpcomingAppointments { set => lblUpcomingAppt.Text = value; }

        public event EventHandler ShowCustomerDashboard;
        public event EventHandler ShowAppointmentDashboard;
        public event EventHandler ShowReports;
        public event EventHandler ExitApplication;
    }
}
