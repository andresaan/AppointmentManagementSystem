using AppointmentScheduler.Interfaces;
using System;
using Data.Models;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace AppointmentScheduler.View
{
    public partial class AppointmentView : Form, IAppointmentView
    {
        public bool IsEdit { get; set; } = false;
        public string AppointmentId { get => txtApptId.Text; set => txtApptId.Text = value; }
        public int CustomerId { get; set; } = -1;
        public int UserId { get; set; } = -1;
        public string CustomerName { get => txtCustomerName.Text; set => txtCustomerName.Text = value; }
        public string Title { get => txtApptTitle.Text; set => txtApptTitle.Text = value; }
        public string Description { get => txtApptDescription.Text; set => txtApptDescription.Text = value; }
        public string Contact { get => txtCustomerContact.Text; set => txtCustomerContact.Text = value; }
        public string Type { get => txtApptType.Text; set => txtApptType.Text = value; }
        public string Url { get => txtUrl.Text; set => txtUrl.Text = value; }
        string IAppointmentView.Location { get => txtApptLocation.Text; set => txtApptLocation.Text = value; }
        public DateTime StartTime
        {
            get => dateStart.Value.Date.Add(timeStart.Value.TimeOfDay);
            set
            {
                dateStart.Value = value.Date;
                var time = new DateTime(1753, 1, 1);
                timeStart.Value = time.Add(value.TimeOfDay);
            }
        }
        public DateTime EndTime
        {
            get => dateEnd.Value.Date.Add(timeEnd.Value.TimeOfDay);
            set
            {
                dateEnd.Value = value.Date;
                var time = new DateTime(1753, 1, 1);
                timeEnd.Value = time.Add(value.TimeOfDay);
            }
        }


        public AppointmentView()
        {
            InitializeComponent();
            dateStart.Value = DateTime.Now;
            dateEnd.Value = DateTime.Now;
            timeStart.Value = DateTime.Now;
            timeEnd.Value = DateTime.Now;

            btnAddAppointment.Click += delegate { SaveAppointmentData?.Invoke(this, EventArgs.Empty); };

            dataCustomers.SelectionChanged += dataCustomers_CurrentCellChanged;
            dataUsers.SelectionChanged += dataUsers_CurrentCellChanged;
        }


        public event EventHandler SaveAppointmentData;

        public void SetBindingLists(BindingSource customerBindingSource, BindingSource userBindingSource)
        {
            dataCustomers.DataSource = customerBindingSource.DataSource;

            dataCustomers.Columns["CustomerId"].HeaderText = "Customer Id";
            dataCustomers.Columns["CustomerName"].HeaderText = "Customer Name";

            dataCustomers.Columns["Active"].Visible = false;
            dataCustomers.Columns["AddressId"].Visible = false;
            dataCustomers.Columns["CreateDate"].Visible = false;
            dataCustomers.Columns["CreatedBy"].Visible = false;
            dataCustomers.Columns["LastUpdate"].Visible = false;
            dataCustomers.Columns["LastUpdateBy"].Visible = false;
            dataCustomers.Columns["Address"].Visible = false;

            dataUsers.DataSource = userBindingSource.DataSource;

            dataUsers.Columns["UserId"].HeaderText = "User Id";
            dataUsers.Columns["UserName"].HeaderText = "User Name";

            dataUsers.Columns["Active"].Visible = false;
            dataUsers.Columns["Password"].Visible = false;
            dataUsers.Columns["CreateDate"].Visible = false;
            dataUsers.Columns["CreatedBy"].Visible = false;
            dataUsers.Columns["LastUpdate"].Visible = false;
            dataUsers.Columns["LastUpdateBy"].Visible = false;
        }

        public void SetCustomerAndUserSelections()
        {
            dataCustomers.SelectionChanged -= dataCustomers_CurrentCellChanged;
            dataUsers.SelectionChanged -= dataUsers_CurrentCellChanged;

            dataCustomers.CurrentCell = null;
            dataUsers.CurrentCell = null;

            foreach (DataGridViewRow row in dataCustomers.Rows)
            {
                if (row.Cells[0].Value.ToString() == CustomerId.ToString())
                {
                    row.Selected = true;
                    break;
                }
            }

            foreach (DataGridViewRow row in dataUsers.Rows)
            {
                if (row.Cells[0].Value.ToString() == UserId.ToString())
                {
                    //dataUsers.CurrentCell = row.Cells[0];
                    row.Selected = true;
                    break;
                }
            }

            dataCustomers.SelectionChanged += dataCustomers_CurrentCellChanged;
            dataUsers.SelectionChanged += dataUsers_CurrentCellChanged;
        }

        private void dataUsers_CurrentCellChanged(object sender, EventArgs e)
        {
                if (IsEdit)
                {
                    var result = MessageBox.Show("Edit User", "Are you sure you want to edit the user associated with this appointment?", MessageBoxButtons.YesNo);

                    if (result == DialogResult.No)
                    {
                        SetCustomerAndUserSelections();
                        return;
                    }
                }

                UserId = dataUsers.RowCount != 0 && dataUsers.CurrentCell != null ? Convert.ToInt32(dataUsers.CurrentRow.Cells[0].Value) : -1;
                txtCustomerContact.Text = dataUsers.RowCount != 0 && dataUsers.CurrentCell != null ? dataUsers.CurrentRow.Cells[1].Value.ToString() : null;
        }

        private void dataCustomers_CurrentCellChanged(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                var result = MessageBox.Show("Edit Customer", "Are you sure you want to edit the customer associated with this appointment?", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    SetCustomerAndUserSelections();
                    return;
                }
            }

                CustomerId = dataCustomers.RowCount != 0 && dataCustomers.CurrentCell != null ? Convert.ToInt32(dataCustomers.CurrentRow.Cells[0].Value) : -1;
                txtCustomerName.Text = dataCustomers.RowCount != 0 && dataCustomers.CurrentCell != null ? dataCustomers.CurrentRow.Cells[1].Value.ToString() : null;
        }
    }
}
