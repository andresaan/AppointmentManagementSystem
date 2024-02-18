using AppointmentScheduler.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace AppointmentScheduler.View
{
    public partial class ReportView : Form, IReportView
    {

        public string CustomerActivityFilter { get => comboIsActive.Text; }
        public string UserFilter { get => comboUserList.Text; }
        public int MonthFilter { get => comboMonthSelection.SelectedIndex; }
        public string AppointmentTypeFilter { get => comboApptType.Text; }



        public event EventHandler FilterAppointments;
        public event EventHandler FilterCustomers;
        public event EventHandler GoHome;

        public ReportView()
        {
            InitializeComponent();

            comboIsActive.SelectedValueChanged += delegate { FilterCustomers?.Invoke(this, EventArgs.Empty); };
            comboUserList.SelectedValueChanged += delegate { FilterAppointments?.Invoke(this, EventArgs.Empty); };
            comboMonthSelection.SelectedValueChanged += delegate { FilterAppointments?.Invoke(this, EventArgs.Empty); };
            comboApptType.SelectedValueChanged += delegate { FilterAppointments?.Invoke(this, EventArgs.Empty); };
            btnGoHome.Click += delegate { GoHome?.Invoke(this, EventArgs.Empty); };

            dataAppointments.RowsAdded  += SetAppointmentCount;
            dataAppointments.RowsRemoved += SetAppointmentCount;

            SetMonthComboCollection();
        }

        private void SetAppointmentCount(object sender, EventArgs e)
        {
            var numberOfAppointments = dataAppointments.RowCount - 1;

            lblAppointmentCount.Text = numberOfAppointments.ToString();
        }

        private void SetMonthComboCollection()
        {
            var months = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            comboMonthSelection.Items.AddRange(months);
        }

        public void SetCustomerListBindingSource(BindingSource source)
        {
            dataCustomers.DataSource = source;

            dataCustomers.Columns["Id"].HeaderText = "Customer Id";
            dataCustomers.Columns["Name"].HeaderText = "Customer Name";
            dataCustomers.Columns["AddressLine1"].HeaderText = "Address Line 1";
            dataCustomers.Columns["AddressLine2"].HeaderText = "Address Line 2";
            dataCustomers.Columns["PostalCode"].HeaderText = "Postal Code";
            dataCustomers.Columns["IsActive"].HeaderText = "Is Active";
        }

        public void SetAppointmentListBindingSource(BindingSource source)
        {
            dataAppointments.DataSource = source;

            dataAppointments.Columns["AppointmentId"].HeaderText = "Appointment Id";
            dataAppointments.Columns["CustomerName"].HeaderText = "Customer Name";
            dataAppointments.Columns["StartTime"].HeaderText = "Start Time";
            dataAppointments.Columns["EndTime"].HeaderText = "End Time";

            dataAppointments.Columns["CustomerId"].Visible = false;
            dataAppointments.Columns["UserId"].Visible = false;
        }

        public void SetUserList(List<string> userList)
        {
            comboUserList.Items.AddRange(userList.ToArray());
        }

        public void SetAppoitmetnTypesList(HashSet<string> appointmentTypes)
        {
            comboApptType.Items.AddRange(appointmentTypes.ToArray());
        }
    }
}
