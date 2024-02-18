using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppointmentScheduler.Interfaces;
using Data.Models;

namespace AppointmentScheduler.View
{
    public partial class AppointmentDashboardView : Form, IAppointmentDashboardView
    {
        public string SelectedAppointmentId { get => dataAppointments.RowCount != 0 && dataAppointments.CurrentCell != null ? dataAppointments.CurrentRow.Cells[0].Value.ToString() : null; }
        public string CalendarFilterType { get => comboDayMonth.Text; }
        public DateTime SelectedDate { get => calendarApptPicker.SelectionRange.Start; }
        public string CalendarFilterResultDisplay { set => lblApptFilterResult.Text = value; }



        public AppointmentDashboardView()
        {
            InitializeComponent();

            btnAddAppointment.Click += delegate { AddAppointment?.Invoke(this, EventArgs.Empty); };
            btnEditAppointment.Click += delegate { EditAppointment?.Invoke(this, EventArgs.Empty); };
            btnDeleteAppointment.Click += delegate { DeleteAppointment?.Invoke(this, EventArgs.Empty); };
            comboDayMonth.SelectedValueChanged += delegate { FilterAppointments?.Invoke(this, EventArgs.Empty); };
            calendarApptPicker.DateSelected += delegate { FilterAppointments?.Invoke(this, EventArgs.Empty); };
            btnGoHome.Click += delegate { GoHome?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler FilterAppointments;
        public event EventHandler AddAppointment;
        public event EventHandler EditAppointment;
        public event EventHandler DeleteAppointment;
        public event EventHandler GoHome;

        public void SetAppointmentListBindingSource(BindingSource source)
        {
            dataAppointments.DataSource = source;

            dataAppointments.Columns["AppointmentId"].HeaderText = "Appointment Id";
            dataAppointments.Columns["CustomerName"].HeaderText = "Customer Name";
            dataAppointments.Columns["StartTime"].HeaderText = "Start Time";
            dataAppointments.Columns["EndTime"].HeaderText = "End Time";

            dataAppointments.Columns["CustomerId"].Visible = false;
            dataAppointments.Columns["UserId"].Visible = false;
            //dataCustomers.Columns["CreateDate"].Visible = false;
            //dataCustomers.Columns["CreatedBy"].Visible = false;
            //dataCustomers.Columns["LastUpdate"].Visible = false;
            //dataCustomers.Columns["LastUpdateBy"].Visible = false;
            //dataCustomers.Columns["Address"].Visible = false;
        }

        public void UpdateCalendarFilterResultDisplay()
        {
            if (CalendarFilterType == "All")
            {
                lblApptFilterResult.Text = "All Appointments";
            }

            if (CalendarFilterType == "Month")
            {
                
                lblApptFilterResult.Text = $"Appointments in {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(SelectedDate.Date.Month)}";
            }

            if (CalendarFilterType == "Day")
            {
                lblApptFilterResult.Text = $"Appointments on {SelectedDate.ToShortDateString()}";
            }
        }
    }
}
