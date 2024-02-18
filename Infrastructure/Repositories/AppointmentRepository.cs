using Data.Models;
using Infrastructure.Interfaces;
using Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private ClientScheduleDbContext _dbContext;

        public AppointmentRepository(ClientScheduleDbContext clientScheduleDbContext)
        {
            _dbContext = clientScheduleDbContext;
        }

        public void AddAppointment(Appointment appointment)
        {
            _dbContext.Appointment.Add(appointment);

            _dbContext.SaveChanges();
        }

        public void DeleteAppointment(int appointmentId)
        {
            var appointment = _dbContext.Appointment.Find(appointmentId);

            _dbContext.Appointment.Remove(appointment);

            _dbContext.SaveChanges();
        }

        public void EditAppointment(Appointment appointment)
        {
            var existingAppointment = _dbContext.Appointment.FirstOrDefault(a => a.AppointmentId == appointment.AppointmentId);

            if (existingAppointment != null)
            {
                appointment.CreateDate = existingAppointment.CreateDate;
                appointment.CreatedBy = existingAppointment.CreatedBy;

                _dbContext.Entry(existingAppointment).CurrentValues.SetValues(appointment);
            }

            _dbContext.SaveChanges();
        }

        public List<Appointment> GetAllAppointments()
        {
            return _dbContext.Appointment
                .Include("Customer.Address")
                .Include("User")
                .ToList();
        }
    }
}
