using MySql.Data.EntityFramework;
using System.Data.Entity;
using Data.Models;

namespace Infrastructure.UnitOfWork
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ClientScheduleDbContext : DbContext
    {
        public ClientScheduleDbContext() : base(GetConnectionString())
        {
        }

        private static string GetConnectionString()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AppointmentScheduler.Properties.Settings.ConnectionString"].ConnectionString;

            return connectionString;
        }

        public DbSet<User> User { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Customer> Customer { get; set; }
    }
}
