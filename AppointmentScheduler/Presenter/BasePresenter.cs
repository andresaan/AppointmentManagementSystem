using ApplicationCore.Interfaces;
using AppointmentScheduler.Interfaces;
using AppointmentScheduler.View;
using Microsoft.Extensions.DependencyInjection;
using Org.BouncyCastle.Asn1.X509.Qualified;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppointmentScheduler.Presenter
{
    public abstract class BasePresenter
    {

        public void GoHome(object sender, EventArgs e)
        {
            Form appointmentView = (Form)sender;
            appointmentView.Close();

            Program.ServiceProvider.GetRequiredService<MainViewPresenter>();
        }
    }
}
