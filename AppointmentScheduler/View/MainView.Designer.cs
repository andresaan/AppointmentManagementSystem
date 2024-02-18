namespace AppointmentScheduler.View
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowCustDash = new System.Windows.Forms.Button();
            this.btnShowApptDash = new System.Windows.Forms.Button();
            this.pnlReminderContainer = new System.Windows.Forms.Panel();
            this.lblUpcomingAppt = new System.Windows.Forms.Label();
            this.lblUpcomingApptHead = new System.Windows.Forms.Label();
            this.btnShowReports = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.pnlReminderContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowCustDash
            // 
            this.btnShowCustDash.Location = new System.Drawing.Point(13, 24);
            this.btnShowCustDash.Name = "btnShowCustDash";
            this.btnShowCustDash.Size = new System.Drawing.Size(131, 45);
            this.btnShowCustDash.TabIndex = 0;
            this.btnShowCustDash.Text = "Customers";
            this.btnShowCustDash.UseVisualStyleBackColor = true;
            // 
            // btnShowApptDash
            // 
            this.btnShowApptDash.Location = new System.Drawing.Point(229, 24);
            this.btnShowApptDash.Name = "btnShowApptDash";
            this.btnShowApptDash.Size = new System.Drawing.Size(131, 45);
            this.btnShowApptDash.TabIndex = 1;
            this.btnShowApptDash.Text = "Appointments";
            this.btnShowApptDash.UseVisualStyleBackColor = true;
            // 
            // pnlReminderContainer
            // 
            this.pnlReminderContainer.Controls.Add(this.lblUpcomingAppt);
            this.pnlReminderContainer.Controls.Add(this.lblUpcomingApptHead);
            this.pnlReminderContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlReminderContainer.Location = new System.Drawing.Point(0, 97);
            this.pnlReminderContainer.Name = "pnlReminderContainer";
            this.pnlReminderContainer.Size = new System.Drawing.Size(814, 219);
            this.pnlReminderContainer.TabIndex = 2;
            // 
            // lblUpcomingAppt
            // 
            this.lblUpcomingAppt.AutoSize = true;
            this.lblUpcomingAppt.Location = new System.Drawing.Point(41, 89);
            this.lblUpcomingAppt.Name = "lblUpcomingAppt";
            this.lblUpcomingAppt.Size = new System.Drawing.Size(175, 16);
            this.lblUpcomingAppt.TabIndex = 1;
            this.lblUpcomingAppt.Text = "No Upcoming Appointments";
            // 
            // lblUpcomingApptHead
            // 
            this.lblUpcomingApptHead.AutoSize = true;
            this.lblUpcomingApptHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcomingApptHead.Location = new System.Drawing.Point(39, 22);
            this.lblUpcomingApptHead.Name = "lblUpcomingApptHead";
            this.lblUpcomingApptHead.Size = new System.Drawing.Size(215, 25);
            this.lblUpcomingApptHead.TabIndex = 0;
            this.lblUpcomingApptHead.Text = "Upcoming Appointment";
            // 
            // btnShowReports
            // 
            this.btnShowReports.Location = new System.Drawing.Point(449, 24);
            this.btnShowReports.Name = "btnShowReports";
            this.btnShowReports.Size = new System.Drawing.Size(131, 45);
            this.btnShowReports.TabIndex = 3;
            this.btnShowReports.Text = "Reports";
            this.btnShowReports.UseVisualStyleBackColor = true;
            // 
            // btnExitApp
            // 
            this.btnExitApp.Location = new System.Drawing.Point(661, 24);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(131, 45);
            this.btnExitApp.TabIndex = 5;
            this.btnExitApp.Text = "Exit";
            this.btnExitApp.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 316);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.btnShowReports);
            this.Controls.Add(this.pnlReminderContainer);
            this.Controls.Add(this.btnShowApptDash);
            this.Controls.Add(this.btnShowCustDash);
            this.Name = "MainView";
            this.Text = "MainView";
            this.pnlReminderContainer.ResumeLayout(false);
            this.pnlReminderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowCustDash;
        private System.Windows.Forms.Button btnShowApptDash;
        private System.Windows.Forms.Panel pnlReminderContainer;
        private System.Windows.Forms.Label lblUpcomingAppt;
        private System.Windows.Forms.Label lblUpcomingApptHead;
        private System.Windows.Forms.Button btnShowReports;
        private System.Windows.Forms.Button btnExitApp;
    }
}