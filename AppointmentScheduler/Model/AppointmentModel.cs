using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppointmentScheduler.Model
{
    public class AppointmentModel
    {
        public int AppointmentId { get; set; }
        [Required(ErrorMessage = "Make sure a customer is selected form the above customer table")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Make sure a user is selected from the above user table")]
        public int UserId { get ; set; }

        [Required(ErrorMessage = "Customer Name: cannot be empty")]
        public string CustomerName { get ; set; }

        [Required(ErrorMessage = "Title: cannot be empty")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description: cannot be empty")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Location: cannot be empty")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Contact: cannot be empty")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Type: cannot be empty")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Url: cannot be empty")]
        public string Url { get; set; }

        [Required(ErrorMessage = "Start Time: cannot be empty")]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = "End Time: cannot be empty")]
        public DateTime EndTime { get; set; }

        public List<AppointmentModel> FormatAppointments(List<Appointment> appointments)
        {
            var formattedAppointments = new List<AppointmentModel>();

            foreach (Appointment appointment in appointments)
            {
                var appointmentModel = new AppointmentModel()
                {
                    AppointmentId = appointment.AppointmentId,
                    CustomerId = appointment.CustomerId,
                    UserId = appointment.UserId,
                    CustomerName = appointment.Customer.CustomerName,
                    Title = appointment.Title,
                    Description = appointment.Description,
                    Type = appointment.Type,
                    Location = appointment.Location,
                    StartTime = appointment.Start,
                    EndTime = appointment.End,
                    Contact = appointment.Contact,
                    Url = appointment.Url
                };

                formattedAppointments.Add(appointmentModel);
            }

            return formattedAppointments;
        }
    }
}
