namespace AppointmentScheduler.View
{
    partial class ReportView
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
            this.tabPgCustReports = new System.Windows.Forms.TabPage();
            this.tableLayoutPnlReportCont = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCustomerCont = new System.Windows.Forms.Panel();
            this.dataCustomers = new System.Windows.Forms.DataGridView();
            this.pnlCustReportFilterCont = new System.Windows.Forms.Panel();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.comboIsActive = new System.Windows.Forms.ComboBox();
            this.lblReportName = new System.Windows.Forms.Label();
            this.lblCustomerFilterHead = new System.Windows.Forms.Label();
            this.tabPgApptReports = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataAppointments = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.lblApptType = new System.Windows.Forms.Label();
            this.comboApptType = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.comboMonthSelection = new System.Windows.Forms.ComboBox();
            this.lblUserSelection = new System.Windows.Forms.Label();
            this.comboUserList = new System.Windows.Forms.ComboBox();
            this.lblUserHead = new System.Windows.Forms.Label();
            this.pnlApptTotalsCont = new System.Windows.Forms.Panel();
            this.lblAppointmentCount = new System.Windows.Forms.Label();
            this.lblAppointmentTotals = new System.Windows.Forms.Label();
            this.tabApptReportCont = new System.Windows.Forms.TabControl();
            this.tabPgCustReports.SuspendLayout();
            this.tableLayoutPnlReportCont.SuspendLayout();
            this.pnlCustomerCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).BeginInit();
            this.pnlCustReportFilterCont.SuspendLayout();
            this.tabPgApptReports.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAppointments)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlApptTotalsCont.SuspendLayout();
            this.tabApptReportCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPgCustReports
            // 
            this.tabPgCustReports.Controls.Add(this.tableLayoutPnlReportCont);
            this.tabPgCustReports.Location = new System.Drawing.Point(4, 25);
            this.tabPgCustReports.Name = "tabPgCustReports";
            this.tabPgCustReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgCustReports.Size = new System.Drawing.Size(928, 523);
            this.tabPgCustReports.TabIndex = 1;
            this.tabPgCustReports.Text = "Customer Reports";
            this.tabPgCustReports.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPnlReportCont
            // 
            this.tableLayoutPnlReportCont.ColumnCount = 1;
            this.tableLayoutPnlReportCont.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPnlReportCont.Controls.Add(this.pnlCustomerCont, 0, 1);
            this.tableLayoutPnlReportCont.Controls.Add(this.pnlCustReportFilterCont, 0, 0);
            this.tableLayoutPnlReportCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPnlReportCont.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPnlReportCont.Name = "tableLayoutPnlReportCont";
            this.tableLayoutPnlReportCont.RowCount = 2;
            this.tableLayoutPnlReportCont.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPnlReportCont.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPnlReportCont.Size = new System.Drawing.Size(922, 517);
            this.tableLayoutPnlReportCont.TabIndex = 0;
            // 
            // pnlCustomerCont
            // 
            this.pnlCustomerCont.Controls.Add(this.dataCustomers);
            this.pnlCustomerCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomerCont.Location = new System.Drawing.Point(20, 175);
            this.pnlCustomerCont.Margin = new System.Windows.Forms.Padding(20);
            this.pnlCustomerCont.Name = "pnlCustomerCont";
            this.pnlCustomerCont.Size = new System.Drawing.Size(882, 322);
            this.pnlCustomerCont.TabIndex = 1;
            // 
            // dataCustomers
            // 
            this.dataCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCustomers.Location = new System.Drawing.Point(0, 0);
            this.dataCustomers.Name = "dataCustomers";
            this.dataCustomers.RowHeadersWidth = 51;
            this.dataCustomers.Size = new System.Drawing.Size(882, 322);
            this.dataCustomers.TabIndex = 0;
            // 
            // pnlCustReportFilterCont
            // 
            this.pnlCustReportFilterCont.Controls.Add(this.lblIsActive);
            this.pnlCustReportFilterCont.Controls.Add(this.comboIsActive);
            this.pnlCustReportFilterCont.Controls.Add(this.lblReportName);
            this.pnlCustReportFilterCont.Controls.Add(this.lblCustomerFilterHead);
            this.pnlCustReportFilterCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustReportFilterCont.Location = new System.Drawing.Point(20, 20);
            this.pnlCustReportFilterCont.Margin = new System.Windows.Forms.Padding(20);
            this.pnlCustReportFilterCont.Name = "pnlCustReportFilterCont";
            this.pnlCustReportFilterCont.Size = new System.Drawing.Size(882, 115);
            this.pnlCustReportFilterCont.TabIndex = 0;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Location = new System.Drawing.Point(684, 65);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(44, 16);
            this.lblIsActive.TabIndex = 3;
            this.lblIsActive.Text = "Active";
            // 
            // comboIsActive
            // 
            this.comboIsActive.AutoCompleteCustomSource.AddRange(new string[] {
            "No Selection",
            "True",
            "False"});
            this.comboIsActive.FormattingEnabled = true;
            this.comboIsActive.Items.AddRange(new object[] {
            "No Selection",
            "True",
            "False"});
            this.comboIsActive.Location = new System.Drawing.Point(734, 62);
            this.comboIsActive.Name = "comboIsActive";
            this.comboIsActive.Size = new System.Drawing.Size(121, 24);
            this.comboIsActive.TabIndex = 2;
            this.comboIsActive.Text = "No Selection";
            // 
            // lblReportName
            // 
            this.lblReportName.AutoSize = true;
            this.lblReportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportName.Location = new System.Drawing.Point(187, 12);
            this.lblReportName.Name = "lblReportName";
            this.lblReportName.Size = new System.Drawing.Size(108, 20);
            this.lblReportName.TabIndex = 1;
            this.lblReportName.Text = "Report Name";
            this.lblReportName.Visible = false;
            // 
            // lblCustomerFilterHead
            // 
            this.lblCustomerFilterHead.AutoSize = true;
            this.lblCustomerFilterHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerFilterHead.Location = new System.Drawing.Point(3, 5);
            this.lblCustomerFilterHead.Name = "lblCustomerFilterHead";
            this.lblCustomerFilterHead.Size = new System.Drawing.Size(154, 25);
            this.lblCustomerFilterHead.TabIndex = 0;
            this.lblCustomerFilterHead.Text = "Customer Filters";
            // 
            // tabPgApptReports
            // 
            this.tabPgApptReports.Controls.Add(this.tableLayoutPanel1);
            this.tabPgApptReports.Location = new System.Drawing.Point(4, 25);
            this.tabPgApptReports.Name = "tabPgApptReports";
            this.tabPgApptReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgApptReports.Size = new System.Drawing.Size(928, 523);
            this.tabPgApptReports.TabIndex = 0;
            this.tabPgApptReports.Text = "User Reports";
            this.tabPgApptReports.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlApptTotalsCont, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.63636F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(922, 517);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataAppointments);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 161);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 289);
            this.panel1.TabIndex = 1;
            // 
            // dataAppointments
            // 
            this.dataAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataAppointments.Location = new System.Drawing.Point(0, 0);
            this.dataAppointments.Name = "dataAppointments";
            this.dataAppointments.RowHeadersWidth = 51;
            this.dataAppointments.Size = new System.Drawing.Size(882, 289);
            this.dataAppointments.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGoHome);
            this.panel2.Controls.Add(this.lblApptType);
            this.panel2.Controls.Add(this.comboApptType);
            this.panel2.Controls.Add(this.lblMonth);
            this.panel2.Controls.Add(this.comboMonthSelection);
            this.panel2.Controls.Add(this.lblUserSelection);
            this.panel2.Controls.Add(this.comboUserList);
            this.panel2.Controls.Add(this.lblUserHead);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 101);
            this.panel2.TabIndex = 0;
            // 
            // btnGoHome
            // 
            this.btnGoHome.Location = new System.Drawing.Point(781, 3);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(98, 34);
            this.btnGoHome.TabIndex = 8;
            this.btnGoHome.Text = "Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            // 
            // lblApptType
            // 
            this.lblApptType.AutoSize = true;
            this.lblApptType.Location = new System.Drawing.Point(540, 63);
            this.lblApptType.Name = "lblApptType";
            this.lblApptType.Size = new System.Drawing.Size(117, 16);
            this.lblApptType.TabIndex = 7;
            this.lblApptType.Text = "Appointment Type";
            // 
            // comboApptType
            // 
            this.comboApptType.AutoCompleteCustomSource.AddRange(new string[] {
            "No Selection",
            "True",
            "False"});
            this.comboApptType.FormattingEnabled = true;
            this.comboApptType.Items.AddRange(new object[] {
            "No Selection"});
            this.comboApptType.Location = new System.Drawing.Point(692, 60);
            this.comboApptType.Name = "comboApptType";
            this.comboApptType.Size = new System.Drawing.Size(121, 24);
            this.comboApptType.TabIndex = 6;
            this.comboApptType.Text = "No Selection";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(268, 63);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(43, 16);
            this.lblMonth.TabIndex = 5;
            this.lblMonth.Text = "Month";
            // 
            // comboMonthSelection
            // 
            this.comboMonthSelection.AutoCompleteCustomSource.AddRange(new string[] {
            "No Selection",
            "True",
            "False"});
            this.comboMonthSelection.FormattingEnabled = true;
            this.comboMonthSelection.Items.AddRange(new object[] {
            "No Selection"});
            this.comboMonthSelection.Location = new System.Drawing.Point(318, 60);
            this.comboMonthSelection.Name = "comboMonthSelection";
            this.comboMonthSelection.Size = new System.Drawing.Size(121, 24);
            this.comboMonthSelection.TabIndex = 4;
            this.comboMonthSelection.Text = "No Selection";
            // 
            // lblUserSelection
            // 
            this.lblUserSelection.AutoSize = true;
            this.lblUserSelection.Location = new System.Drawing.Point(43, 63);
            this.lblUserSelection.Name = "lblUserSelection";
            this.lblUserSelection.Size = new System.Drawing.Size(36, 16);
            this.lblUserSelection.TabIndex = 3;
            this.lblUserSelection.Text = "User";
            // 
            // comboUserList
            // 
            this.comboUserList.AutoCompleteCustomSource.AddRange(new string[] {
            "No Selection",
            "True",
            "False"});
            this.comboUserList.FormattingEnabled = true;
            this.comboUserList.Items.AddRange(new object[] {
            "No Selection"});
            this.comboUserList.Location = new System.Drawing.Point(93, 60);
            this.comboUserList.Name = "comboUserList";
            this.comboUserList.Size = new System.Drawing.Size(121, 24);
            this.comboUserList.TabIndex = 2;
            this.comboUserList.Text = "No Selection";
            // 
            // lblUserHead
            // 
            this.lblUserHead.AutoSize = true;
            this.lblUserHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserHead.Location = new System.Drawing.Point(3, 5);
            this.lblUserHead.Name = "lblUserHead";
            this.lblUserHead.Size = new System.Drawing.Size(179, 25);
            this.lblUserHead.TabIndex = 0;
            this.lblUserHead.Text = "Appointment Filters";
            // 
            // pnlApptTotalsCont
            // 
            this.pnlApptTotalsCont.Controls.Add(this.lblAppointmentCount);
            this.pnlApptTotalsCont.Controls.Add(this.lblAppointmentTotals);
            this.pnlApptTotalsCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlApptTotalsCont.Location = new System.Drawing.Point(3, 473);
            this.pnlApptTotalsCont.Name = "pnlApptTotalsCont";
            this.pnlApptTotalsCont.Size = new System.Drawing.Size(916, 41);
            this.pnlApptTotalsCont.TabIndex = 2;
            // 
            // lblAppointmentCount
            // 
            this.lblAppointmentCount.AutoSize = true;
            this.lblAppointmentCount.Location = new System.Drawing.Point(444, 11);
            this.lblAppointmentCount.Name = "lblAppointmentCount";
            this.lblAppointmentCount.Size = new System.Drawing.Size(41, 16);
            this.lblAppointmentCount.TabIndex = 9;
            this.lblAppointmentCount.Text = "Count";
            // 
            // lblAppointmentTotals
            // 
            this.lblAppointmentTotals.AutoSize = true;
            this.lblAppointmentTotals.Location = new System.Drawing.Point(309, 11);
            this.lblAppointmentTotals.Name = "lblAppointmentTotals";
            this.lblAppointmentTotals.Size = new System.Drawing.Size(129, 16);
            this.lblAppointmentTotals.TabIndex = 8;
            this.lblAppointmentTotals.Text = "Total Appointments: ";
            // 
            // tabApptReportCont
            // 
            this.tabApptReportCont.Controls.Add(this.tabPgApptReports);
            this.tabApptReportCont.Controls.Add(this.tabPgCustReports);
            this.tabApptReportCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabApptReportCont.Location = new System.Drawing.Point(0, 0);
            this.tabApptReportCont.Name = "tabApptReportCont";
            this.tabApptReportCont.SelectedIndex = 0;
            this.tabApptReportCont.Size = new System.Drawing.Size(936, 552);
            this.tabApptReportCont.TabIndex = 0;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 552);
            this.Controls.Add(this.tabApptReportCont);
            this.Name = "ReportView";
            this.Text = "Reports";
            this.tabPgCustReports.ResumeLayout(false);
            this.tableLayoutPnlReportCont.ResumeLayout(false);
            this.pnlCustomerCont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).EndInit();
            this.pnlCustReportFilterCont.ResumeLayout(false);
            this.pnlCustReportFilterCont.PerformLayout();
            this.tabPgApptReports.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAppointments)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlApptTotalsCont.ResumeLayout(false);
            this.pnlApptTotalsCont.PerformLayout();
            this.tabApptReportCont.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPgCustReports;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPnlReportCont;
        private System.Windows.Forms.Panel pnlCustomerCont;
        private System.Windows.Forms.DataGridView dataCustomers;
        private System.Windows.Forms.Panel pnlCustReportFilterCont;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.ComboBox comboIsActive;
        private System.Windows.Forms.Label lblReportName;
        private System.Windows.Forms.Label lblCustomerFilterHead;
        private System.Windows.Forms.TabPage tabPgApptReports;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataAppointments;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblApptType;
        private System.Windows.Forms.ComboBox comboApptType;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox comboMonthSelection;
        private System.Windows.Forms.Label lblUserSelection;
        private System.Windows.Forms.ComboBox comboUserList;
        private System.Windows.Forms.Label lblUserHead;
        private System.Windows.Forms.Panel pnlApptTotalsCont;
        private System.Windows.Forms.Label lblAppointmentCount;
        private System.Windows.Forms.Label lblAppointmentTotals;
        private System.Windows.Forms.TabControl tabApptReportCont;
        private System.Windows.Forms.Button btnGoHome;
    }
}