namespace AppointmentScheduler.View
{
    partial class AppointmentDashboardView
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
            this.components = new System.ComponentModel.Container();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.btnEditAppointment = new System.Windows.Forms.Button();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.calendarApptPicker = new System.Windows.Forms.MonthCalendar();
            this.comboDayMonth = new System.Windows.Forms.ComboBox();
            this.dataAppointments = new System.Windows.Forms.DataGridView();
            this.lblApptFilterResult = new System.Windows.Forms.Label();
            this.btnGoHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Location = new System.Drawing.Point(66, 491);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(153, 42);
            this.btnAddAppointment.TabIndex = 1;
            this.btnAddAppointment.Text = "Add";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            // 
            // btnEditAppointment
            // 
            this.btnEditAppointment.Location = new System.Drawing.Point(326, 491);
            this.btnEditAppointment.Name = "btnEditAppointment";
            this.btnEditAppointment.Size = new System.Drawing.Size(153, 42);
            this.btnEditAppointment.TabIndex = 2;
            this.btnEditAppointment.Text = "Edit";
            this.btnEditAppointment.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Location = new System.Drawing.Point(587, 491);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(153, 42);
            this.btnDeleteAppointment.TabIndex = 3;
            this.btnDeleteAppointment.Text = "Delete";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            // 
            // calendarApptPicker
            // 
            this.calendarApptPicker.Location = new System.Drawing.Point(801, 222);
            this.calendarApptPicker.MaxSelectionCount = 1;
            this.calendarApptPicker.Name = "calendarApptPicker";
            this.calendarApptPicker.TabIndex = 4;
            // 
            // comboDayMonth
            // 
            this.comboDayMonth.FormattingEnabled = true;
            this.comboDayMonth.Items.AddRange(new object[] {
            "All",
            "Day",
            "Month"});
            this.comboDayMonth.Location = new System.Drawing.Point(801, 145);
            this.comboDayMonth.Name = "comboDayMonth";
            this.comboDayMonth.Size = new System.Drawing.Size(121, 24);
            this.comboDayMonth.TabIndex = 5;
            this.comboDayMonth.Text = "All";
            // 
            // dataAppointments
            // 
            this.dataAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAppointments.Location = new System.Drawing.Point(66, 109);
            this.dataAppointments.Name = "dataAppointments";
            this.dataAppointments.RowHeadersWidth = 51;
            this.dataAppointments.RowTemplate.Height = 24;
            this.dataAppointments.Size = new System.Drawing.Size(674, 356);
            this.dataAppointments.TabIndex = 7;
            // 
            // lblApptFilterResult
            // 
            this.lblApptFilterResult.AutoSize = true;
            this.lblApptFilterResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptFilterResult.Location = new System.Drawing.Point(265, 46);
            this.lblApptFilterResult.Name = "lblApptFilterResult";
            this.lblApptFilterResult.Size = new System.Drawing.Size(193, 29);
            this.lblApptFilterResult.TabIndex = 6;
            this.lblApptFilterResult.Text = "All Appointments";
            // 
            // btnGoHome
            // 
            this.btnGoHome.Location = new System.Drawing.Point(66, 43);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(153, 42);
            this.btnGoHome.TabIndex = 8;
            this.btnGoHome.Text = "Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            // 
            // AppointmentDashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 591);
            this.Controls.Add(this.btnGoHome);
            this.Controls.Add(this.dataAppointments);
            this.Controls.Add(this.lblApptFilterResult);
            this.Controls.Add(this.comboDayMonth);
            this.Controls.Add(this.calendarApptPicker);
            this.Controls.Add(this.btnDeleteAppointment);
            this.Controls.Add(this.btnEditAppointment);
            this.Controls.Add(this.btnAddAppointment);
            this.Name = "AppointmentDashboardView";
            this.Text = "Appointment Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Button btnEditAppointment;
        private System.Windows.Forms.ComboBox comboDayMonth;
        private System.Windows.Forms.MonthCalendar calendarApptPicker;
        private System.Windows.Forms.DataGridView dataAppointments;
        private System.Windows.Forms.Label lblApptFilterResult;
        private System.Windows.Forms.Button btnGoHome;
    }
}