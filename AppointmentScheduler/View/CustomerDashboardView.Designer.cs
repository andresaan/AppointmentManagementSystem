namespace AppointmentScheduler.View
{
    partial class CustomerDashboardView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.pnlCustDetailsCont = new System.Windows.Forms.Panel();
            this.checkCustomerActive = new System.Windows.Forms.CheckBox();
            this.lblCustomerActive = new System.Windows.Forms.Label();
            this.lblCustomerCountry = new System.Windows.Forms.Label();
            this.lblCustomerPostal = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerCity = new System.Windows.Forms.Label();
            this.txtCustomerCity = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress1 = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress2 = new System.Windows.Forms.TextBox();
            this.txtCustomerCountry = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.txtCustomerPostal = new System.Windows.Forms.TextBox();
            this.lblCustomerDetails = new System.Windows.Forms.Label();
            this.pnlCustListCont = new System.Windows.Forms.Panel();
            this.dataCustomers = new System.Windows.Forms.DataGridView();
            this.pnlCustListSearchCont = new System.Windows.Forms.Panel();
            this.pnlCustListBttnCont = new System.Windows.Forms.Panel();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlCustDetailsCont.SuspendLayout();
            this.pnlCustListCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).BeginInit();
            this.pnlCustListBttnCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.pnlCustDetailsCont, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlCustListCont, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlCustListBttnCont, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.35294F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1323, 727);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(628, 450);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(153, 42);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(353, 450);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(153, 42);
            this.btnEditCustomer.TabIndex = 1;
            this.btnEditCustomer.Text = "Edit";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(73, 450);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(153, 42);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // pnlCustDetailsCont
            // 
            this.pnlCustDetailsCont.Controls.Add(this.btnDeleteCustomer);
            this.pnlCustDetailsCont.Controls.Add(this.checkCustomerActive);
            this.pnlCustDetailsCont.Controls.Add(this.btnEditCustomer);
            this.pnlCustDetailsCont.Controls.Add(this.lblCustomerActive);
            this.pnlCustDetailsCont.Controls.Add(this.btnAddCustomer);
            this.pnlCustDetailsCont.Controls.Add(this.lblCustomerCountry);
            this.pnlCustDetailsCont.Controls.Add(this.lblCustomerPostal);
            this.pnlCustDetailsCont.Controls.Add(this.lblCustomerPhone);
            this.pnlCustDetailsCont.Controls.Add(this.lblCustomerCity);
            this.pnlCustDetailsCont.Controls.Add(this.txtCustomerCity);
            this.pnlCustDetailsCont.Controls.Add(this.txtCustomerName);
            this.pnlCustDetailsCont.Controls.Add(this.txtCustomerAddress1);
            this.pnlCustDetailsCont.Controls.Add(this.txtCustomerAddress2);
            this.pnlCustDetailsCont.Controls.Add(this.txtCustomerCountry);
            this.pnlCustDetailsCont.Controls.Add(this.txtCustomerPhone);
            this.pnlCustDetailsCont.Controls.Add(this.lblCustomerName);
            this.pnlCustDetailsCont.Controls.Add(this.lblCustomerAddress);
            this.pnlCustDetailsCont.Controls.Add(this.txtCustomerPostal);
            this.pnlCustDetailsCont.Controls.Add(this.lblCustomerDetails);
            this.pnlCustDetailsCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustDetailsCont.Location = new System.Drawing.Point(436, 168);
            this.pnlCustDetailsCont.Margin = new System.Windows.Forms.Padding(40);
            this.pnlCustDetailsCont.Name = "pnlCustDetailsCont";
            this.pnlCustDetailsCont.Size = new System.Drawing.Size(847, 519);
            this.pnlCustDetailsCont.TabIndex = 0;
            // 
            // checkCustomerActive
            // 
            this.checkCustomerActive.AutoSize = true;
            this.checkCustomerActive.Location = new System.Drawing.Point(571, 132);
            this.checkCustomerActive.Name = "checkCustomerActive";
            this.checkCustomerActive.Size = new System.Drawing.Size(18, 17);
            this.checkCustomerActive.TabIndex = 76;
            this.checkCustomerActive.UseVisualStyleBackColor = true;
            // 
            // lblCustomerActive
            // 
            this.lblCustomerActive.AutoSize = true;
            this.lblCustomerActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerActive.Location = new System.Drawing.Point(477, 128);
            this.lblCustomerActive.Name = "lblCustomerActive";
            this.lblCustomerActive.Size = new System.Drawing.Size(55, 20);
            this.lblCustomerActive.TabIndex = 74;
            this.lblCustomerActive.Text = "Active";
            // 
            // lblCustomerCountry
            // 
            this.lblCustomerCountry.AutoSize = true;
            this.lblCustomerCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCountry.Location = new System.Drawing.Point(465, 292);
            this.lblCustomerCountry.Name = "lblCustomerCountry";
            this.lblCustomerCountry.Size = new System.Drawing.Size(67, 20);
            this.lblCustomerCountry.TabIndex = 67;
            this.lblCustomerCountry.Text = "Country";
            // 
            // lblCustomerPostal
            // 
            this.lblCustomerPostal.AutoSize = true;
            this.lblCustomerPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPostal.Location = new System.Drawing.Point(69, 374);
            this.lblCustomerPostal.Name = "lblCustomerPostal";
            this.lblCustomerPostal.Size = new System.Drawing.Size(75, 20);
            this.lblCustomerPostal.TabIndex = 66;
            this.lblCustomerPostal.Text = "Zip Code";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPhone.Location = new System.Drawing.Point(88, 210);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(56, 20);
            this.lblCustomerPhone.TabIndex = 68;
            this.lblCustomerPhone.Text = "Phone";
            // 
            // lblCustomerCity
            // 
            this.lblCustomerCity.AutoSize = true;
            this.lblCustomerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCity.Location = new System.Drawing.Point(106, 292);
            this.lblCustomerCity.Name = "lblCustomerCity";
            this.lblCustomerCity.Size = new System.Drawing.Size(38, 20);
            this.lblCustomerCity.TabIndex = 65;
            this.lblCustomerCity.Text = "City";
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.Location = new System.Drawing.Point(183, 290);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.Size = new System.Drawing.Size(210, 22);
            this.txtCustomerCity.TabIndex = 73;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(183, 126);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(210, 22);
            this.txtCustomerName.TabIndex = 69;
            // 
            // txtCustomerAddress1
            // 
            this.txtCustomerAddress1.Location = new System.Drawing.Point(571, 208);
            this.txtCustomerAddress1.Name = "txtCustomerAddress1";
            this.txtCustomerAddress1.Size = new System.Drawing.Size(210, 22);
            this.txtCustomerAddress1.TabIndex = 63;
            // 
            // txtCustomerAddress2
            // 
            this.txtCustomerAddress2.Location = new System.Drawing.Point(571, 236);
            this.txtCustomerAddress2.Name = "txtCustomerAddress2";
            this.txtCustomerAddress2.Size = new System.Drawing.Size(210, 22);
            this.txtCustomerAddress2.TabIndex = 64;
            // 
            // txtCustomerCountry
            // 
            this.txtCustomerCountry.Location = new System.Drawing.Point(571, 290);
            this.txtCustomerCountry.Name = "txtCustomerCountry";
            this.txtCustomerCountry.Size = new System.Drawing.Size(210, 22);
            this.txtCustomerCountry.TabIndex = 72;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(183, 208);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(210, 22);
            this.txtCustomerPhone.TabIndex = 70;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(91, 128);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(53, 20);
            this.lblCustomerName.TabIndex = 61;
            this.lblCustomerName.Text = "Name";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(461, 210);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(71, 20);
            this.lblCustomerAddress.TabIndex = 62;
            this.lblCustomerAddress.Text = "Address";
            // 
            // txtCustomerPostal
            // 
            this.txtCustomerPostal.Location = new System.Drawing.Point(183, 372);
            this.txtCustomerPostal.Name = "txtCustomerPostal";
            this.txtCustomerPostal.Size = new System.Drawing.Size(210, 22);
            this.txtCustomerPostal.TabIndex = 71;
            // 
            // lblCustomerDetails
            // 
            this.lblCustomerDetails.AutoSize = true;
            this.lblCustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerDetails.Location = new System.Drawing.Point(345, 35);
            this.lblCustomerDetails.Name = "lblCustomerDetails";
            this.lblCustomerDetails.Size = new System.Drawing.Size(161, 25);
            this.lblCustomerDetails.TabIndex = 60;
            this.lblCustomerDetails.Text = "Customer Details";
            // 
            // pnlCustListCont
            // 
            this.pnlCustListCont.Controls.Add(this.dataCustomers);
            this.pnlCustListCont.Controls.Add(this.pnlCustListSearchCont);
            this.pnlCustListCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustListCont.Location = new System.Drawing.Point(40, 168);
            this.pnlCustListCont.Margin = new System.Windows.Forms.Padding(40);
            this.pnlCustListCont.Name = "pnlCustListCont";
            this.pnlCustListCont.Size = new System.Drawing.Size(316, 519);
            this.pnlCustListCont.TabIndex = 4;
            // 
            // dataCustomers
            // 
            this.dataCustomers.AllowUserToAddRows = false;
            this.dataCustomers.AllowUserToDeleteRows = false;
            this.dataCustomers.AllowUserToOrderColumns = true;
            this.dataCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCustomers.Location = new System.Drawing.Point(0, 56);
            this.dataCustomers.Name = "dataCustomers";
            this.dataCustomers.RowHeadersWidth = 51;
            this.dataCustomers.RowTemplate.Height = 24;
            this.dataCustomers.Size = new System.Drawing.Size(316, 463);
            this.dataCustomers.TabIndex = 5;
            // 
            // pnlCustListSearchCont
            // 
            this.pnlCustListSearchCont.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustListSearchCont.Location = new System.Drawing.Point(0, 0);
            this.pnlCustListSearchCont.Margin = new System.Windows.Forms.Padding(80, 3, 3, 3);
            this.pnlCustListSearchCont.Name = "pnlCustListSearchCont";
            this.pnlCustListSearchCont.Size = new System.Drawing.Size(316, 56);
            this.pnlCustListSearchCont.TabIndex = 6;
            // 
            // pnlCustListBttnCont
            // 
            this.pnlCustListBttnCont.Controls.Add(this.btnGoHome);
            this.pnlCustListBttnCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustListBttnCont.Location = new System.Drawing.Point(3, 3);
            this.pnlCustListBttnCont.MinimumSize = new System.Drawing.Size(200, 50);
            this.pnlCustListBttnCont.Name = "pnlCustListBttnCont";
            this.pnlCustListBttnCont.Size = new System.Drawing.Size(390, 122);
            this.pnlCustListBttnCont.TabIndex = 3;
            // 
            // btnGoHome
            // 
            this.btnGoHome.Location = new System.Drawing.Point(37, 29);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(153, 42);
            this.btnGoHome.TabIndex = 1;
            this.btnGoHome.Text = "Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            // 
            // CustomerDashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 727);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomerDashboardView";
            this.Text = "Customer Dashboard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlCustDetailsCont.ResumeLayout(false);
            this.pnlCustDetailsCont.PerformLayout();
            this.pnlCustListCont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).EndInit();
            this.pnlCustListBttnCont.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlCustDetailsCont;
        private System.Windows.Forms.Button btnGoHome;
        private System.Windows.Forms.Label lblCustomerCountry;
        private System.Windows.Forms.Label lblCustomerPostal;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerCity;
        private System.Windows.Forms.TextBox txtCustomerCity;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerAddress1;
        private System.Windows.Forms.TextBox txtCustomerAddress2;
        private System.Windows.Forms.TextBox txtCustomerCountry;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerPostal;
        private System.Windows.Forms.Label lblCustomerDetails;
        private System.Windows.Forms.Panel pnlCustListCont;
        private System.Windows.Forms.DataGridView dataCustomers;
        private System.Windows.Forms.Panel pnlCustListSearchCont;
        private System.Windows.Forms.Label lblCustomerActive;
        private System.Windows.Forms.CheckBox checkCustomerActive;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Panel pnlCustListBttnCont;
    }
}