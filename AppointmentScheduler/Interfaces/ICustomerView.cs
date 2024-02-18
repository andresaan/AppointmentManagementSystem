using System;


namespace AppointmentScheduler.Interfaces
{
    public interface ICustomerView
    {
        int CustomerId { get; set; }
        string CustomerName { get; set; }
        string CustomerPhone { get; set; }
        string CustomerAddress1 { get; set; }
        string CustomerAddress2 { get; set; }
        string CustomerCity { get; set; }
        string CustomerCountry { get; set; }
        string CustomerPostal { get; set; }
        bool CustomerActive { get; set; }


        event EventHandler SaveCustomerData;
        event EventHandler Cancel;


        void Show();

        void Close();
    }
}
