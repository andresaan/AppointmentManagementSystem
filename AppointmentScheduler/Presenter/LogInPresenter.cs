using ApplicationCore.Interfaces;
using AppointmentScheduler.Interfaces;
using Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace AppointmentScheduler.Presenter
{
    public class LogInPresenter
    {
        private ILogInView _logInView;
        private IUserService _userService;
        public string Location { set => _logInView.UserLocationDisplay = value; }

        public LogInPresenter(ILogInView logInView, IUserService userService)
        {
            _logInView = logInView;
            _userService = userService;

            _logInView.LogIn += Login;

            _logInView.Show();
        }

        private void Login(object sender, EventArgs e)
        {
            var username = _logInView.Username;
            var password = _logInView.Password;

            var user = _userService.ValidateLogInCredentials(username, password);

            if (user != null)
            {
                Properties.Settings.Default.UserInformation = new UserSettings()
                {
                    Id = user.UserId,
                    Username = user.UserName
                };

                Program.ServiceProvider.GetRequiredService<MainViewPresenter>();

                _logInView.Close();
            }
            else
            {
                MessageBox.Show(LogInStrings.LogInErrorMessage);
            }
        }
    }
}
