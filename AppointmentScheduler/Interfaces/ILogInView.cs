using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentScheduler.Interfaces
{
    public interface ILogInView
    {
        string Username { get; set; }
        string Password { get; set; }
        string UserLocationDisplay { set; }

        event EventHandler LogIn;

        void Show();
        void Close();
    }
}
