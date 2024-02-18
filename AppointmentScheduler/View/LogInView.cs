using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppointmentScheduler.Interfaces;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AppointmentScheduler.View
{
    public partial class LogInView : Form, ILogInView
    {
        public string Username { get => txtUsername.Text; set => txtUsername.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public string UserLocationDisplay { set => lblLocation.Text = value; }

        public event EventHandler LogIn;


        public LogInView()
        {
            InitializeComponent();
            btnSignUp.Enabled = false;

            btnLogIn.Click += delegate { LogIn?.Invoke(this, EventArgs.Empty); };
        }


        // Should be within the app as an admin privilage
        //check username is available
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            //check username is available


            //passed password validation and enter into database

            //string sql = "INSERT INTO `user` (userName, password, active, createDate, createdBy, lastUpdateBY) VALUES (@UserName, @Password, 1, NOW(), @CreatedBY, @LastUpdateBy)";

            //using (var connection = new MySqlConnection(""))
            //using (var command = new MySqlCommand(sql, connection))
            //using (SHA256 sha256Hash = SHA256.Create())
            //{
            //    //string hash = GetHash(sha256Hash, password);
            //    //var hashAtLength = Truncate(hash, 50);

            //    command.Parameters.AddWithValue("@UserName", username);
            //    //command.Parameters.AddWithValue("@Password", hashAtLength);
            //    command.Parameters.AddWithValue("@CreatedBy", username);
            //    command.Parameters.AddWithValue("@LastUpdateBy", username);

            //    connection.Open();
            //    var affected = command.ExecuteNonQuery();
            //}
        }

        // Verify a hash against a string.
        //private static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        //{
        //    // Hash the input.
        //    var hashOfInput = GetHash(hashAlgorithm, input);

        //    // Create a StringComparer an compare the hashes.
        //    StringComparer comparer = StringComparer.OrdinalIgnoreCase;

        //    return comparer.Compare(hashOfInput, hash) == 0;
        //}
    }
}

