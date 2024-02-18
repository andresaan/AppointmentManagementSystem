using AppointmentScheduler.Model;
using AppointmentScheduler.Presenter;
using AppointmentScheduler.View;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infrastructure.Repositories;
using Data;
using ApplicationCore.Interfaces;
using ApplicationCore.Services;
using Infrastructure.UnitOfWork;
using AppointmentScheduler.Interfaces;
using Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;
using Serilog;
using System.Globalization;
using System.Transactions.Configuration;
using System.Threading;
using Microsoft.Win32;

namespace AppointmentScheduler
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var regKeyGeoId = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Control Panel\International\Geo");
            var geoID = (string)regKeyGeoId.GetValue("Nation");
            var allRegions = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Select(x => new RegionInfo(x.ToString()));
            var regionInfo = allRegions.FirstOrDefault(r => r.GeoId == Int32.Parse(geoID));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            var presenter = ServiceProvider.GetRequiredService<LogInPresenter>();
            presenter.Location = regionInfo.EnglishName;

            Application.Run(new ApplicationContext()
            {
                Tag = presenter
            });
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .UseSerilog((host, loggerConfiguration) =>
                {
                    loggerConfiguration.WriteTo.File("Login_History.txt");
                })
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<LogInPresenter>();
                    services.AddTransient<ILogInView, LogInView>();

                    services.AddTransient<MainViewPresenter>();
                    services.AddTransient<IMainView, MainView>();

                    services.AddTransient<CustomerDashboardPresenter>();
                    services.AddTransient<ICustomerDashboardView, CustomerDashboardView>();

                    services.AddTransient<CustomerPresenter>();
                    services.AddTransient<ICustomerView, CustomerView>();

                    services.AddTransient<AppointmentDashboardPresenter>();
                    services.AddTransient<IAppointmentDashboardView, AppointmentDashboardView>();

                    services.AddTransient<AppointmentPresenter>();
                    services.AddTransient<IAppointmentView, AppointmentView>();

                    services.AddTransient<ReportPresenter>();
                    services.AddTransient<IReportView, ReportView>();

                    services.AddTransient<ICustomerService, CustomerService>();
                    services.AddTransient<IAppointmentService, AppointmentService>();
                    services.AddTransient<IUserService, UserService>();

                    services.AddTransient<IUnitOfWorkFactory, UnitOfWorkFactory>();

                    services.AddTransient<ICustomerRepository, CustomerRepository>();
                    services.AddTransient<IAppointmentRepository, AppointmentRepository>();
                    services.AddTransient<IUserRepository, UserRepository>();
                });
        }
    }
}
