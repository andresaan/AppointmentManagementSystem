using ApplicationCore.Interfaces;
using Data.Models;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace ApplicationCore.Services
{
    public class AppointmentService : IAppointmentService
    {
        private IUnitOfWorkFactory _unitOfWorkFactory;
        public AppointmentService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }
        
        public List<Appointment> GetAllAppointments()
        {
            var unit = _unitOfWorkFactory.CreateUnitOfWork();
            var appointmentRepository = unit.AppointmentRepository;

            List<Appointment> appointments = appointmentRepository.GetAllAppointments();

            unit.Dispose();

            foreach (Appointment appointment in appointments)
            {
                appointment.Start = TimeZone.CurrentTimeZone.ToLocalTime(appointment.Start);
                appointment.End = TimeZone.CurrentTimeZone.ToLocalTime(appointment.End);
            }


            return appointments;
        }

        public IEnumerable<T> GetAll<T>()
        {
            var unit = _unitOfWorkFactory.CreateUnitOfWork();
            var appointmentRepository = unit.AppointmentRepository;

            List<Appointment> appointments = appointmentRepository.GetAllAppointments();

            unit.Dispose();

            foreach (Appointment appointment in appointments)
            {
                appointment.Start = TimeZone.CurrentTimeZone.ToLocalTime(appointment.Start);
                appointment.End = TimeZone.CurrentTimeZone.ToLocalTime(appointment.End);
            }


            return (IEnumerable<T>)appointments;
        }

        public string SaveAppointment(Appointment appointment)
        {
            // Validate that appointment start is before end

            if (DateTime.Compare(DateTime.UtcNow, appointment.Start) > 0)
            {
                return "Start date must be a valid date and time in the future";
            }

            if (DateTime.Compare(appointment.Start, appointment.End) > 0)
            {
                return "Start time must be before end time";
            }

            // Validate that appointment is within business hours 9AM - 5PM EST

            var easternStandardTime = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            var nineAmEst = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0, DateTimeKind.Unspecified);
            var fivePmEst = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0, DateTimeKind.Unspecified);

            var nineAmUtc = TimeZoneInfo.ConvertTimeToUtc(nineAmEst, easternStandardTime);
            var fivePmUtc = TimeZoneInfo.ConvertTimeToUtc(fivePmEst, easternStandardTime);

            if (TimeSpan.Compare(appointment.Start.TimeOfDay, nineAmUtc.TimeOfDay) == -1 || TimeSpan.Compare(appointment.End.TimeOfDay, fivePmUtc.TimeOfDay) == 1)
            {
                return $"Appointments must be scheduled between {nineAmUtc.ToLocalTime().TimeOfDay} and {fivePmUtc.ToLocalTime().TimeOfDay}";
            }

            // Validate that appointment is shcheduled M-F

            if (appointment.Start.DayOfWeek == DayOfWeek.Saturday || appointment.Start.DayOfWeek == DayOfWeek.Sunday || appointment.End.DayOfWeek == DayOfWeek.Saturday || appointment.End.DayOfWeek == DayOfWeek.Sunday)
            {
                return "Appointments can only be scheduled Monday through Friday";
            }

            // Find schedule conflicts

            var appointments = GetAllAppointments();

            var start = appointment.Start.ToLocalTime();
            var end = appointment.End.ToLocalTime();

            appointments = appointments.Where(a => a.UserId == appointment.UserId && a.AppointmentId != appointment.AppointmentId && a.Start.Date == appointment.Start.Date && ((a.Start < start && a.End > start) || (a.Start < end && a.End > end) || (start < a.Start && end > a.Start) || (start < a.End && end > a.End))).ToList();

            if (appointments.Count != 0)
            {
                return "conflict";
            }

            var unit = _unitOfWorkFactory.CreateUnitOfWork();
            var appointmentRepository = unit.AppointmentRepository;

            if (appointment.AppointmentId == -1)
            {
                appointment.CreatedBy = appointment.LastUpdateBy;
                appointment.CreateDate = appointment.LastUpdate;

                appointmentRepository.AddAppointment(appointment);
            }
            else
            {
                if (appointment.AppointmentId > 0)
                {
                    appointmentRepository.EditAppointment(appointment);
                }
            }

            unit.Dispose();
            return null;
        }

        public void DeleteAppointment(int appointmentId)
        {
            var unit = _unitOfWorkFactory.CreateUnitOfWork();
            var appointmentRepository = unit.AppointmentRepository;

            appointmentRepository.DeleteAppointment(appointmentId);

            unit.Dispose();
        }
    }
}
