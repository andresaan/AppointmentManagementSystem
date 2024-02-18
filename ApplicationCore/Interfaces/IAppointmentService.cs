using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IAppointmentService
    {
        List<Appointment> GetAllAppointments();
        string SaveAppointment(Appointment appointment);

        void DeleteAppointment(int appointmentId);
    }
}
