using AppointmentScheduler.Interfaces;
using Data.Models;
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
    public partial class CustomerView : Form, ICustomerView
    {
        public CustomerView()
        {
            InitializeComponent();

            btnSaveCustInfo.Click += delegate { SaveCustomerData?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate { Cancel?.Invoke(this, EventArgs.Empty); };
        }

        public int CustomerId { get; set; } = -1;
        public string CustomerName { get => txtCustomerName.Text; set => txtCustomerName.Text = value; }
        public string CustomerPhone { get => txtCustomerPhone.Text; set => txtCustomerPhone.Text = value; }
        public string CustomerAddress1 { get => txtCustomerAddress1.Text; set => txtCustomerAddress1.Text = value; }
        public string CustomerAddress2 { get => txtCustomerAddress2.Text; set => txtCustomerAddress2.Text = value; }
        public string CustomerCity { get => txtCustomerCity.Text; set => txtCustomerCity.Text = value; }
        public string CustomerCountry { get => txtCustomerCountry.Text; set => txtCustomerCountry.Text = value; }
        public string CustomerPostal { get => txtCustomerPostal.Text; set => txtCustomerPostal.Text = value; }
        public bool CustomerActive { get => checkCustomerActive.Checked; set => checkCustomerActive.Checked = value; }


        public event EventHandler SaveCustomerData;
        public event EventHandler Cancel;
    }
}
