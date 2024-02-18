using System;
using System.Windows.Forms;

namespace AppointmentScheduler.View
{
    partial class AppointmentView
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
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCustCont = new System.Windows.Forms.Panel();
            this.dataCustomers = new System.Windows.Forms.DataGridView();
            this.pnlCustomerSearch = new System.Windows.Forms.Panel();
            this.pnlUserCont = new System.Windows.Forms.Panel();
            this.dataUsers = new System.Windows.Forms.DataGridView();
            this.pnlUserSearch = new System.Windows.Forms.Panel();
            this.pnlUserInputCont = new System.Windows.Forms.Panel();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.timeEnd = new System.Windows.Forms.DateTimePicker();
            this.lblApptEnd = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblDateTimeStart = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.txtApptDescription = new System.Windows.Forms.RichTextBox();
            this.txtApptType = new System.Windows.Forms.TextBox();
            this.lblApptType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtApptTitle = new System.Windows.Forms.TextBox();
            this.lblApptTitle = new System.Windows.Forms.Label();
            this.txtApptLocation = new System.Windows.Forms.TextBox();
            this.lblApptLocation = new System.Windows.Forms.Label();
            this.txtCustomerContact = new System.Windows.Forms.TextBox();
            this.lblCustomerContact = new System.Windows.Forms.Label();
            this.lblAppointmentDetails = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtApptId = new System.Windows.Forms.TextBox();
            this.lblApptId = new System.Windows.Forms.Label();
            this.tableLayout.SuspendLayout();
            this.pnlCustCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).BeginInit();
            this.pnlUserCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).BeginInit();
            this.pnlUserInputCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Controls.Add(this.pnlCustCont, 0, 0);
            this.tableLayout.Controls.Add(this.pnlUserCont, 1, 0);
            this.tableLayout.Controls.Add(this.pnlUserInputCont, 0, 1);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayout.Size = new System.Drawing.Size(1525, 767);
            this.tableLayout.TabIndex = 0;
            // 
            // pnlCustCont
            // 
            this.pnlCustCont.Controls.Add(this.dataCustomers);
            this.pnlCustCont.Controls.Add(this.pnlCustomerSearch);
            this.pnlCustCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustCont.Location = new System.Drawing.Point(20, 20);
            this.pnlCustCont.Margin = new System.Windows.Forms.Padding(20);
            this.pnlCustCont.Name = "pnlCustCont";
            this.pnlCustCont.Size = new System.Drawing.Size(722, 266);
            this.pnlCustCont.TabIndex = 0;
            // 
            // dataCustomers
            // 
            this.dataCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCustomers.Location = new System.Drawing.Point(0, 56);
            this.dataCustomers.Name = "dataCustomers";
            this.dataCustomers.RowHeadersWidth = 51;
            this.dataCustomers.RowTemplate.Height = 24;
            this.dataCustomers.Size = new System.Drawing.Size(722, 210);
            this.dataCustomers.TabIndex = 0;
            // 
            // pnlCustomerSearch
            // 
            this.pnlCustomerSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomerSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomerSearch.Name = "pnlCustomerSearch";
            this.pnlCustomerSearch.Size = new System.Drawing.Size(722, 56);
            this.pnlCustomerSearch.TabIndex = 1;
            // 
            // pnlUserCont
            // 
            this.pnlUserCont.Controls.Add(this.dataUsers);
            this.pnlUserCont.Controls.Add(this.pnlUserSearch);
            this.pnlUserCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserCont.Location = new System.Drawing.Point(782, 20);
            this.pnlUserCont.Margin = new System.Windows.Forms.Padding(20);
            this.pnlUserCont.Name = "pnlUserCont";
            this.pnlUserCont.Size = new System.Drawing.Size(723, 266);
            this.pnlUserCont.TabIndex = 1;
            // 
            // dataUsers
            // 
            this.dataUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataUsers.Location = new System.Drawing.Point(0, 56);
            this.dataUsers.Name = "dataUsers";
            this.dataUsers.RowHeadersWidth = 51;
            this.dataUsers.RowTemplate.Height = 24;
            this.dataUsers.Size = new System.Drawing.Size(723, 210);
            this.dataUsers.TabIndex = 0;
            // 
            // pnlUserSearch
            // 
            this.pnlUserSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlUserSearch.Name = "pnlUserSearch";
            this.pnlUserSearch.Size = new System.Drawing.Size(723, 56);
            this.pnlUserSearch.TabIndex = 2;
            // 
            // pnlUserInputCont
            // 
            this.tableLayout.SetColumnSpan(this.pnlUserInputCont, 2);
            this.pnlUserInputCont.Controls.Add(this.txtApptId);
            this.pnlUserInputCont.Controls.Add(this.lblApptId);
            this.pnlUserInputCont.Controls.Add(this.btnAddAppointment);
            this.pnlUserInputCont.Controls.Add(this.timeEnd);
            this.pnlUserInputCont.Controls.Add(this.lblApptEnd);
            this.pnlUserInputCont.Controls.Add(this.dateEnd);
            this.pnlUserInputCont.Controls.Add(this.timeStart);
            this.pnlUserInputCont.Controls.Add(this.txtUrl);
            this.pnlUserInputCont.Controls.Add(this.lblUrl);
            this.pnlUserInputCont.Controls.Add(this.lblDateTimeStart);
            this.pnlUserInputCont.Controls.Add(this.dateStart);
            this.pnlUserInputCont.Controls.Add(this.txtApptDescription);
            this.pnlUserInputCont.Controls.Add(this.txtApptType);
            this.pnlUserInputCont.Controls.Add(this.lblApptType);
            this.pnlUserInputCont.Controls.Add(this.lblDescription);
            this.pnlUserInputCont.Controls.Add(this.txtApptTitle);
            this.pnlUserInputCont.Controls.Add(this.lblApptTitle);
            this.pnlUserInputCont.Controls.Add(this.txtApptLocation);
            this.pnlUserInputCont.Controls.Add(this.lblApptLocation);
            this.pnlUserInputCont.Controls.Add(this.txtCustomerContact);
            this.pnlUserInputCont.Controls.Add(this.lblCustomerContact);
            this.pnlUserInputCont.Controls.Add(this.lblAppointmentDetails);
            this.pnlUserInputCont.Controls.Add(this.txtCustomerName);
            this.pnlUserInputCont.Controls.Add(this.lblCustomerName);
            this.pnlUserInputCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserInputCont.Location = new System.Drawing.Point(20, 326);
            this.pnlUserInputCont.Margin = new System.Windows.Forms.Padding(20);
            this.pnlUserInputCont.Name = "pnlUserInputCont";
            this.pnlUserInputCont.Size = new System.Drawing.Size(1485, 421);
            this.pnlUserInputCont.TabIndex = 2;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Location = new System.Drawing.Point(1303, 308);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(75, 32);
            this.btnAddAppointment.TabIndex = 96;
            this.btnAddAppointment.Text = "Save";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            // 
            // timeEnd
            // 
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeEnd.Location = new System.Drawing.Point(850, 313);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.ShowUpDown = true;
            this.timeEnd.Size = new System.Drawing.Size(107, 22);
            this.timeEnd.TabIndex = 95;
            this.timeEnd.Value = new System.DateTime(2024, 1, 29, 10, 42, 1, 0);
            // 
            // lblApptEnd
            // 
            this.lblApptEnd.AutoSize = true;
            this.lblApptEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptEnd.Location = new System.Drawing.Point(541, 313);
            this.lblApptEnd.Name = "lblApptEnd";
            this.lblApptEnd.Size = new System.Drawing.Size(38, 20);
            this.lblApptEnd.TabIndex = 94;
            this.lblApptEnd.Text = "End";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(603, 313);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(230, 22);
            this.dateEnd.TabIndex = 93;
            this.dateEnd.Value = new System.DateTime(2024, 1, 29, 10, 42, 1, 0);
            // 
            // timeStart
            // 
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeStart.Location = new System.Drawing.Point(381, 313);
            this.timeStart.Name = "timeStart";
            this.timeStart.ShowUpDown = true;
            this.timeStart.Size = new System.Drawing.Size(107, 22);
            this.timeStart.TabIndex = 92;
            this.timeStart.Value = new System.DateTime(2024, 1, 31, 10, 47, 27, 0);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(582, 171);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(210, 22);
            this.txtUrl.TabIndex = 91;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(532, 171);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(31, 20);
            this.lblUrl.TabIndex = 90;
            this.lblUrl.Text = "Url";
            // 
            // lblDateTimeStart
            // 
            this.lblDateTimeStart.AutoSize = true;
            this.lblDateTimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimeStart.Location = new System.Drawing.Point(72, 313);
            this.lblDateTimeStart.Name = "lblDateTimeStart";
            this.lblDateTimeStart.Size = new System.Drawing.Size(45, 20);
            this.lblDateTimeStart.TabIndex = 87;
            this.lblDateTimeStart.Text = "Start";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(134, 313);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(230, 22);
            this.dateStart.TabIndex = 86;
            this.dateStart.Value = new System.DateTime(2024, 2, 6, 0, 0, 0, 0);
            // 
            // txtApptDescription
            // 
            this.txtApptDescription.Location = new System.Drawing.Point(1004, 171);
            this.txtApptDescription.Name = "txtApptDescription";
            this.txtApptDescription.Size = new System.Drawing.Size(374, 119);
            this.txtApptDescription.TabIndex = 85;
            this.txtApptDescription.Text = "";
            // 
            // txtApptType
            // 
            this.txtApptType.Location = new System.Drawing.Point(582, 232);
            this.txtApptType.Name = "txtApptType";
            this.txtApptType.Size = new System.Drawing.Size(210, 22);
            this.txtApptType.TabIndex = 84;
            // 
            // lblApptType
            // 
            this.lblApptType.AutoSize = true;
            this.lblApptType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptType.Location = new System.Drawing.Point(507, 234);
            this.lblApptType.Name = "lblApptType";
            this.lblApptType.Size = new System.Drawing.Size(45, 20);
            this.lblApptType.TabIndex = 83;
            this.lblApptType.Text = "Type";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(879, 171);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(95, 20);
            this.lblDescription.TabIndex = 81;
            this.lblDescription.Text = "Description";
            // 
            // txtApptTitle
            // 
            this.txtApptTitle.Location = new System.Drawing.Point(1004, 97);
            this.txtApptTitle.Name = "txtApptTitle";
            this.txtApptTitle.Size = new System.Drawing.Size(374, 22);
            this.txtApptTitle.TabIndex = 80;
            // 
            // lblApptTitle
            // 
            this.lblApptTitle.AutoSize = true;
            this.lblApptTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptTitle.Location = new System.Drawing.Point(912, 97);
            this.lblApptTitle.Name = "lblApptTitle";
            this.lblApptTitle.Size = new System.Drawing.Size(41, 20);
            this.lblApptTitle.TabIndex = 79;
            this.lblApptTitle.Text = "Title";
            // 
            // txtApptLocation
            // 
            this.txtApptLocation.Location = new System.Drawing.Point(582, 97);
            this.txtApptLocation.Name = "txtApptLocation";
            this.txtApptLocation.Size = new System.Drawing.Size(210, 22);
            this.txtApptLocation.TabIndex = 76;
            // 
            // lblApptLocation
            // 
            this.lblApptLocation.AutoSize = true;
            this.lblApptLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptLocation.Location = new System.Drawing.Point(490, 97);
            this.lblApptLocation.Name = "lblApptLocation";
            this.lblApptLocation.Size = new System.Drawing.Size(73, 20);
            this.lblApptLocation.TabIndex = 75;
            this.lblApptLocation.Text = "Location";
            // 
            // txtCustomerContact
            // 
            this.txtCustomerContact.Location = new System.Drawing.Point(164, 231);
            this.txtCustomerContact.Name = "txtCustomerContact";
            this.txtCustomerContact.ReadOnly = true;
            this.txtCustomerContact.Size = new System.Drawing.Size(210, 22);
            this.txtCustomerContact.TabIndex = 74;
            // 
            // lblCustomerContact
            // 
            this.lblCustomerContact.AutoSize = true;
            this.lblCustomerContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerContact.Location = new System.Drawing.Point(72, 234);
            this.lblCustomerContact.Name = "lblCustomerContact";
            this.lblCustomerContact.Size = new System.Drawing.Size(67, 20);
            this.lblCustomerContact.TabIndex = 73;
            this.lblCustomerContact.Text = "Contact";
            // 
            // lblAppointmentDetails
            // 
            this.lblAppointmentDetails.AutoSize = true;
            this.lblAppointmentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDetails.Location = new System.Drawing.Point(40, 22);
            this.lblAppointmentDetails.Name = "lblAppointmentDetails";
            this.lblAppointmentDetails.Size = new System.Drawing.Size(186, 25);
            this.lblAppointmentDetails.TabIndex = 72;
            this.lblAppointmentDetails.Text = "Appointment Details";
            this.lblAppointmentDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(164, 164);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(210, 22);
            this.txtCustomerName.TabIndex = 71;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(57, 166);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 20);
            this.lblCustomerName.TabIndex = 70;
            this.lblCustomerName.Text = "Customer";
            // 
            // txtApptId
            // 
            this.txtApptId.Location = new System.Drawing.Point(206, 97);
            this.txtApptId.Name = "txtApptId";
            this.txtApptId.ReadOnly = true;
            this.txtApptId.Size = new System.Drawing.Size(168, 22);
            this.txtApptId.TabIndex = 98;
            // 
            // lblApptId
            // 
            this.lblApptId.AutoSize = true;
            this.lblApptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptId.Location = new System.Drawing.Point(57, 99);
            this.lblApptId.Name = "lblApptId";
            this.lblApptId.Size = new System.Drawing.Size(120, 20);
            this.lblApptId.TabIndex = 97;
            this.lblApptId.Text = "Appointment Id";
            // 
            // AppointmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 767);
            this.Controls.Add(this.tableLayout);
            this.Name = "AppointmentView";
            this.Text = "Appointment";
            this.tableLayout.ResumeLayout(false);
            this.pnlCustCont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).EndInit();
            this.pnlUserCont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).EndInit();
            this.pnlUserInputCont.ResumeLayout(false);
            this.pnlUserInputCont.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Panel pnlCustCont;
        private System.Windows.Forms.DataGridView dataCustomers;
        private System.Windows.Forms.Panel pnlCustomerSearch;
        private System.Windows.Forms.Panel pnlUserCont;
        private System.Windows.Forms.DataGridView dataUsers;
        private System.Windows.Forms.Panel pnlUserSearch;
        private System.Windows.Forms.Panel pnlUserInputCont;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.RichTextBox txtApptDescription;
        private System.Windows.Forms.TextBox txtApptType;
        private System.Windows.Forms.Label lblApptType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtApptTitle;
        private System.Windows.Forms.Label lblApptTitle;
        private System.Windows.Forms.TextBox txtApptLocation;
        private System.Windows.Forms.Label lblApptLocation;
        private System.Windows.Forms.TextBox txtCustomerContact;
        private System.Windows.Forms.Label lblCustomerContact;
        private System.Windows.Forms.Label lblAppointmentDetails;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblDateTimeStart;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker timeStart;
        private System.Windows.Forms.DateTimePicker timeEnd;
        private System.Windows.Forms.Label lblApptEnd;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private Button btnAddAppointment;
        private TextBox txtApptId;
        private Label lblApptId;
    }
}