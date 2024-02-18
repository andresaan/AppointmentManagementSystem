using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IAppointmentRepository
    {
        List<Appointment> GetAllAppointments();

        void AddAppointment(Appointment appointment);

        void EditAppointment(Appointment appointment);

        void DeleteAppointment(int appointmentId);
    }
}
