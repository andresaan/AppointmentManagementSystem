using AppointmentScheduler.Interfaces;
using System;
using System.Windows.Forms;

namespace AppointmentScheduler.View
{
    public partial class CustomerDashboardView : Form, ICustomerDashboardView
    {
        public string SelectedCustomerId { get => dataCustomers.RowCount != 0 && dataCustomers.CurrentCell != null ? dataCustomers.CurrentRow.Cells[0].Value.ToString() : null; }
        public string SelectedCustomerName { set => txtCustomerName.Text = value; }
        public string SelectedCustomerPhone { set => txtCustomerPhone.Text = value; }
        public string SelectedCustomerAddressLine1 { set => txtCustomerAddress1.Text = value; }
        public string SelectedCustomerAddressLine2 { set => txtCustomerAddress2.Text = value; }
        public string SelectedCustomerPostal { set => txtCustomerPostal.Text = value; }
        public string SelectedCustomerCity { set => txtCustomerCity.Text = value; }
        public string SelectedCustomerCountry { set => txtCustomerCountry.Text = value; }
        public bool SelectedCustomerActive { set => checkCustomerActive.Checked = value; }

        public CustomerDashboardView()
        {
            InitializeComponent();

            btnAddCustomer.Click += delegate { AddCustomer?.Invoke(this, EventArgs.Empty); };
            btnEditCustomer.Click += delegate { EditCustomer?.Invoke(this, EventArgs.Empty); };
            dataCustomers.DoubleClick += delegate { EditCustomer?.Invoke(this, EventArgs.Empty); };
            btnDeleteCustomer.Click += delegate { DeleteCustomer?.Invoke(this, EventArgs.Empty); };
            dataCustomers.SelectionChanged += delegate { DisplayCustomerDetails?.Invoke(this, EventArgs.Empty); };
            btnGoHome.Click += delegate { GoHome?.Invoke(this, EventArgs.Empty); };
        }


        public event EventHandler EditCustomer;
        public event EventHandler AddCustomer;
        public event EventHandler DeleteCustomer;
        public event EventHandler DisplayCustomerDetails;
        public event EventHandler GoHome;

        public void SetCustomerListBindingSource(BindingSource source)
        {
            dataCustomers.DataSource = source;

            dataCustomers.Columns["CustomerId"].HeaderText = "Customer Id";
            dataCustomers.Columns["CustomerName"].HeaderText = "Customer Name";

            dataCustomers.Columns["Active"].Visible = false;
            dataCustomers.Columns["AddressId"].Visible = false;
            dataCustomers.Columns["CreateDate"].Visible = false;
            dataCustomers.Columns["CreatedBy"].Visible = false;
            dataCustomers.Columns["LastUpdate"].Visible = false;
            dataCustomers.Columns["LastUpdateBy"].Visible = false;
            dataCustomers.Columns["Address"].Visible = false;
        }
    }
}
