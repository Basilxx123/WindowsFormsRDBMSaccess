namespace WindowsFormsRDBMSaccess
{
    partial class BookingForm
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
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.DeleteVehbtn = new System.Windows.Forms.Button();
			this.ObsOuttxt = new System.Windows.Forms.TextBox();
			this.ObsIntxt = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.UpdateVehbtn = new System.Windows.Forms.Button();
			this.BookingIDtxt = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.CreateBkgbtn = new System.Windows.Forms.Button();
			this.cmbCustomerID = new System.Windows.Forms.ComboBox();
			this.cmbVihicleID = new System.Windows.Forms.ComboBox();
			this.dtpBkgDate = new System.Windows.Forms.DateTimePicker();
			this.dtpRtnDate = new System.Windows.Forms.DateTimePicker();
			this.dtBkgTime = new System.Windows.Forms.DateTimePicker();
			this.dtRtnTime = new System.Windows.Forms.DateTimePicker();
			this.CmbEmpName = new System.Windows.Forms.ComboBox();
			this.lblEmpName = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.OdoOuttxt = new System.Windows.Forms.TextBox();
			this.OdoIntxt = new System.Windows.Forms.TextBox();
			this.Discount_txt = new System.Windows.Forms.TextBox();
			this.Costtxt = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.SearchBydateBtn = new System.Windows.Forms.TextBox();
			this.RbPastBkg = new System.Windows.Forms.RadioButton();
			this.rbCurrentBkg = new System.Windows.Forms.RadioButton();
			this.rbfutureBkg = new System.Windows.Forms.RadioButton();
			this.Searchbtn = new System.Windows.Forms.Button();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.txtEnddt = new System.Windows.Forms.TextBox();
			this.txtStartdt = new System.Windows.Forms.TextBox();
			this.btnVehivleAvailability = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(70, 346);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 17);
			this.label7.TabIndex = 100;
			this.label7.Text = "Return Date";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(64, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(153, 32);
			this.label4.TabIndex = 99;
			this.label4.Text = "BOOKING";
			// 
			// DeleteVehbtn
			// 
			this.DeleteVehbtn.Location = new System.Drawing.Point(820, 744);
			this.DeleteVehbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DeleteVehbtn.Name = "DeleteVehbtn";
			this.DeleteVehbtn.Size = new System.Drawing.Size(132, 28);
			this.DeleteVehbtn.TabIndex = 98;
			this.DeleteVehbtn.Text = "Delete Booking";
			this.DeleteVehbtn.UseVisualStyleBackColor = true;
			this.DeleteVehbtn.Click += new System.EventHandler(this.DeleteVehbtn_Click);
			// 
			// ObsOuttxt
			// 
			this.ObsOuttxt.Location = new System.Drawing.Point(233, 490);
			this.ObsOuttxt.Margin = new System.Windows.Forms.Padding(4);
			this.ObsOuttxt.Name = "ObsOuttxt";
			this.ObsOuttxt.Size = new System.Drawing.Size(160, 22);
			this.ObsOuttxt.TabIndex = 92;
			// 
			// ObsIntxt
			// 
			this.ObsIntxt.Location = new System.Drawing.Point(233, 440);
			this.ObsIntxt.Margin = new System.Windows.Forms.Padding(4);
			this.ObsIntxt.Name = "ObsIntxt";
			this.ObsIntxt.Size = new System.Drawing.Size(160, 22);
			this.ObsIntxt.TabIndex = 91;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(70, 490);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(115, 17);
			this.label11.TabIndex = 88;
			this.label11.Text = "ObservationsOut";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(69, 444);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(103, 17);
			this.label9.TabIndex = 86;
			this.label9.Text = "ObservationsIn";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(69, 392);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(86, 17);
			this.label8.TabIndex = 85;
			this.label8.Text = "Return Time";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(68, 240);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 17);
			this.label6.TabIndex = 83;
			this.label6.Text = "Booking Date";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(69, 293);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 17);
			this.label5.TabIndex = 82;
			this.label5.Text = "Booking Time";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(69, 187);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 17);
			this.label3.TabIndex = 81;
			this.label3.Text = "VIN";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(69, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 17);
			this.label2.TabIndex = 80;
			this.label2.Text = "CustomerID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(69, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 17);
			this.label1.TabIndex = 79;
			this.label1.Text = "BookingID";
			// 
			// UpdateVehbtn
			// 
			this.UpdateVehbtn.Location = new System.Drawing.Point(637, 744);
			this.UpdateVehbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.UpdateVehbtn.Name = "UpdateVehbtn";
			this.UpdateVehbtn.Size = new System.Drawing.Size(144, 28);
			this.UpdateVehbtn.TabIndex = 78;
			this.UpdateVehbtn.Text = "Update Booking";
			this.UpdateVehbtn.UseVisualStyleBackColor = true;
			this.UpdateVehbtn.Click += new System.EventHandler(this.UpdateVehbtn_Click);
			// 
			// BookingIDtxt
			// 
			this.BookingIDtxt.Location = new System.Drawing.Point(233, 82);
			this.BookingIDtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BookingIDtxt.Name = "BookingIDtxt";
			this.BookingIDtxt.Size = new System.Drawing.Size(160, 22);
			this.BookingIDtxt.TabIndex = 74;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(469, 143);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(981, 465);
			this.dataGridView1.TabIndex = 73;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// CreateBkgbtn
			// 
			this.CreateBkgbtn.Location = new System.Drawing.Point(465, 744);
			this.CreateBkgbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.CreateBkgbtn.Name = "CreateBkgbtn";
			this.CreateBkgbtn.Size = new System.Drawing.Size(137, 28);
			this.CreateBkgbtn.TabIndex = 101;
			this.CreateBkgbtn.Text = "Create Booking";
			this.CreateBkgbtn.UseVisualStyleBackColor = true;
			this.CreateBkgbtn.Click += new System.EventHandler(this.CreateBkgbtn_Click);
			// 
			// cmbCustomerID
			// 
			this.cmbCustomerID.FormattingEnabled = true;
			this.cmbCustomerID.Location = new System.Drawing.Point(233, 135);
			this.cmbCustomerID.Margin = new System.Windows.Forms.Padding(4);
			this.cmbCustomerID.Name = "cmbCustomerID";
			this.cmbCustomerID.Size = new System.Drawing.Size(160, 24);
			this.cmbCustomerID.TabIndex = 102;
			// 
			// cmbVihicleID
			// 
			this.cmbVihicleID.FormattingEnabled = true;
			this.cmbVihicleID.Location = new System.Drawing.Point(233, 183);
			this.cmbVihicleID.Margin = new System.Windows.Forms.Padding(4);
			this.cmbVihicleID.Name = "cmbVihicleID";
			this.cmbVihicleID.Size = new System.Drawing.Size(160, 24);
			this.cmbVihicleID.TabIndex = 103;
			// 
			// dtpBkgDate
			// 
			this.dtpBkgDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpBkgDate.Location = new System.Drawing.Point(233, 232);
			this.dtpBkgDate.Margin = new System.Windows.Forms.Padding(4);
			this.dtpBkgDate.Name = "dtpBkgDate";
			this.dtpBkgDate.Size = new System.Drawing.Size(160, 22);
			this.dtpBkgDate.TabIndex = 104;
			// 
			// dtpRtnDate
			// 
			this.dtpRtnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpRtnDate.Location = new System.Drawing.Point(233, 338);
			this.dtpRtnDate.Margin = new System.Windows.Forms.Padding(4);
			this.dtpRtnDate.Name = "dtpRtnDate";
			this.dtpRtnDate.Size = new System.Drawing.Size(160, 22);
			this.dtpRtnDate.TabIndex = 105;
			// 
			// dtBkgTime
			// 
			this.dtBkgTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtBkgTime.Location = new System.Drawing.Point(233, 285);
			this.dtBkgTime.Margin = new System.Windows.Forms.Padding(4);
			this.dtBkgTime.Name = "dtBkgTime";
			this.dtBkgTime.Size = new System.Drawing.Size(160, 22);
			this.dtBkgTime.TabIndex = 106;
			// 
			// dtRtnTime
			// 
			this.dtRtnTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtRtnTime.Location = new System.Drawing.Point(233, 385);
			this.dtRtnTime.Margin = new System.Windows.Forms.Padding(4);
			this.dtRtnTime.Name = "dtRtnTime";
			this.dtRtnTime.Size = new System.Drawing.Size(160, 22);
			this.dtRtnTime.TabIndex = 107;
			// 
			// CmbEmpName
			// 
			this.CmbEmpName.FormattingEnabled = true;
			this.CmbEmpName.Location = new System.Drawing.Point(231, 635);
			this.CmbEmpName.Name = "CmbEmpName";
			this.CmbEmpName.Size = new System.Drawing.Size(160, 24);
			this.CmbEmpName.TabIndex = 108;
			// 
			// lblEmpName
			// 
			this.lblEmpName.AutoSize = true;
			this.lblEmpName.Location = new System.Drawing.Point(68, 637);
			this.lblEmpName.Name = "lblEmpName";
			this.lblEmpName.Size = new System.Drawing.Size(77, 17);
			this.lblEmpName.TabIndex = 109;
			this.lblEmpName.Text = "Emp Name";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(69, 540);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(151, 17);
			this.label10.TabIndex = 110;
			this.label10.Text = "OdoReadingOutbound";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(69, 591);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(139, 17);
			this.label12.TabIndex = 111;
			this.label12.Text = "OdoReadingInbound";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(68, 731);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(36, 17);
			this.label14.TabIndex = 113;
			this.label14.Text = "Cost";
			// 
			// OdoOuttxt
			// 
			this.OdoOuttxt.Location = new System.Drawing.Point(231, 540);
			this.OdoOuttxt.Name = "OdoOuttxt";
			this.OdoOuttxt.Size = new System.Drawing.Size(160, 22);
			this.OdoOuttxt.TabIndex = 114;
			// 
			// OdoIntxt
			// 
			this.OdoIntxt.Location = new System.Drawing.Point(231, 588);
			this.OdoIntxt.Name = "OdoIntxt";
			this.OdoIntxt.Size = new System.Drawing.Size(160, 22);
			this.OdoIntxt.TabIndex = 115;
			// 
			// Discount_txt
			// 
			this.Discount_txt.Location = new System.Drawing.Point(231, 683);
			this.Discount_txt.Name = "Discount_txt";
			this.Discount_txt.Size = new System.Drawing.Size(160, 22);
			this.Discount_txt.TabIndex = 116;
			// 
			// Costtxt
			// 
			this.Costtxt.Location = new System.Drawing.Point(231, 731);
			this.Costtxt.Name = "Costtxt";
			this.Costtxt.Size = new System.Drawing.Size(160, 22);
			this.Costtxt.TabIndex = 117;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(70, 688);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(63, 17);
			this.label13.TabIndex = 118;
			this.label13.Text = "Discount";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(1072, 107);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(106, 17);
			this.label15.TabIndex = 119;
			this.label15.Text = "Search by Date";
			// 
			// SearchBydateBtn
			// 
			this.SearchBydateBtn.Location = new System.Drawing.Point(1181, 104);
			this.SearchBydateBtn.Name = "SearchBydateBtn";
			this.SearchBydateBtn.Size = new System.Drawing.Size(173, 22);
			this.SearchBydateBtn.TabIndex = 120;
			// 
			// RbPastBkg
			// 
			this.RbPastBkg.AutoSize = true;
			this.RbPastBkg.Location = new System.Drawing.Point(469, 103);
			this.RbPastBkg.Name = "RbPastBkg";
			this.RbPastBkg.Size = new System.Drawing.Size(119, 21);
			this.RbPastBkg.TabIndex = 121;
			this.RbPastBkg.TabStop = true;
			this.RbPastBkg.Text = "Past Bookings";
			this.RbPastBkg.UseVisualStyleBackColor = true;
			this.RbPastBkg.CheckedChanged += new System.EventHandler(this.RbPastBkg_CheckedChanged);
			// 
			// rbCurrentBkg
			// 
			this.rbCurrentBkg.AutoSize = true;
			this.rbCurrentBkg.Location = new System.Drawing.Point(605, 103);
			this.rbCurrentBkg.Name = "rbCurrentBkg";
			this.rbCurrentBkg.Size = new System.Drawing.Size(138, 21);
			this.rbCurrentBkg.TabIndex = 122;
			this.rbCurrentBkg.TabStop = true;
			this.rbCurrentBkg.Text = "Current Bookings";
			this.rbCurrentBkg.UseVisualStyleBackColor = true;
			this.rbCurrentBkg.CheckedChanged += new System.EventHandler(this.rbCurrentBkg_CheckedChanged);
			// 
			// rbfutureBkg
			// 
			this.rbfutureBkg.AutoSize = true;
			this.rbfutureBkg.Location = new System.Drawing.Point(762, 105);
			this.rbfutureBkg.Name = "rbfutureBkg";
			this.rbfutureBkg.Size = new System.Drawing.Size(131, 21);
			this.rbfutureBkg.TabIndex = 123;
			this.rbfutureBkg.TabStop = true;
			this.rbfutureBkg.Text = "Future bookings";
			this.rbfutureBkg.UseVisualStyleBackColor = true;
			this.rbfutureBkg.CheckedChanged += new System.EventHandler(this.rbfutureBkg_CheckedChanged);
			// 
			// Searchbtn
			// 
			this.Searchbtn.Location = new System.Drawing.Point(1375, 98);
			this.Searchbtn.Name = "Searchbtn";
			this.Searchbtn.Size = new System.Drawing.Size(75, 30);
			this.Searchbtn.TabIndex = 124;
			this.Searchbtn.Text = "Search";
			this.Searchbtn.UseVisualStyleBackColor = true;
			this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
			// 
			// cmbStatus
			// 
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Location = new System.Drawing.Point(229, 777);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(160, 24);
			this.cmbStatus.TabIndex = 125;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(67, 777);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(103, 17);
			this.label16.TabIndex = 126;
			this.label16.Text = "Booking Status";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(692, 666);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(85, 17);
			this.label17.TabIndex = 131;
			this.label17.Text = "Return Date";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(469, 665);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(72, 17);
			this.label18.TabIndex = 130;
			this.label18.Text = "Start Date";
			// 
			// txtEnddt
			// 
			this.txtEnddt.Location = new System.Drawing.Point(784, 663);
			this.txtEnddt.Name = "txtEnddt";
			this.txtEnddt.Size = new System.Drawing.Size(100, 22);
			this.txtEnddt.TabIndex = 129;
			// 
			// txtStartdt
			// 
			this.txtStartdt.Location = new System.Drawing.Point(547, 663);
			this.txtStartdt.Name = "txtStartdt";
			this.txtStartdt.Size = new System.Drawing.Size(123, 22);
			this.txtStartdt.TabIndex = 128;
			// 
			// btnVehivleAvailability
			// 
			this.btnVehivleAvailability.Location = new System.Drawing.Point(922, 657);
			this.btnVehivleAvailability.Name = "btnVehivleAvailability";
			this.btnVehivleAvailability.Size = new System.Drawing.Size(132, 28);
			this.btnVehivleAvailability.TabIndex = 127;
			this.btnVehivleAvailability.Text = "Check Availbility";
			this.btnVehivleAvailability.UseVisualStyleBackColor = true;
			this.btnVehivleAvailability.Click += new System.EventHandler(this.btnVehivleAvailability_Click);
			// 
			// BookingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1509, 812);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.txtEnddt);
			this.Controls.Add(this.txtStartdt);
			this.Controls.Add(this.btnVehivleAvailability);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.cmbStatus);
			this.Controls.Add(this.Searchbtn);
			this.Controls.Add(this.rbfutureBkg);
			this.Controls.Add(this.rbCurrentBkg);
			this.Controls.Add(this.RbPastBkg);
			this.Controls.Add(this.SearchBydateBtn);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.Costtxt);
			this.Controls.Add(this.Discount_txt);
			this.Controls.Add(this.OdoIntxt);
			this.Controls.Add(this.OdoOuttxt);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.lblEmpName);
			this.Controls.Add(this.CmbEmpName);
			this.Controls.Add(this.dtRtnTime);
			this.Controls.Add(this.dtBkgTime);
			this.Controls.Add(this.dtpRtnDate);
			this.Controls.Add(this.dtpBkgDate);
			this.Controls.Add(this.cmbVihicleID);
			this.Controls.Add(this.cmbCustomerID);
			this.Controls.Add(this.CreateBkgbtn);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.DeleteVehbtn);
			this.Controls.Add(this.ObsOuttxt);
			this.Controls.Add(this.ObsIntxt);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.UpdateVehbtn);
			this.Controls.Add(this.BookingIDtxt);
			this.Controls.Add(this.dataGridView1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "BookingForm";
			this.Text = "BookingForm";
			this.Load += new System.EventHandler(this.BookingForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button DeleteVehbtn;
		private System.Windows.Forms.TextBox ObsOuttxt;
        private System.Windows.Forms.TextBox ObsIntxt;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateVehbtn;
		private System.Windows.Forms.TextBox BookingIDtxt;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button CreateBkgbtn;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.ComboBox cmbVihicleID;
        private System.Windows.Forms.DateTimePicker dtpBkgDate;
        private System.Windows.Forms.DateTimePicker dtpRtnDate;
        private System.Windows.Forms.DateTimePicker dtBkgTime;
        private System.Windows.Forms.DateTimePicker dtRtnTime;
		private System.Windows.Forms.ComboBox CmbEmpName;
		private System.Windows.Forms.Label lblEmpName;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox OdoOuttxt;
		private System.Windows.Forms.TextBox OdoIntxt;
		private System.Windows.Forms.TextBox Discount_txt;
		private System.Windows.Forms.TextBox Costtxt;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox SearchBydateBtn;
		private System.Windows.Forms.RadioButton RbPastBkg;
		private System.Windows.Forms.RadioButton rbCurrentBkg;
		private System.Windows.Forms.RadioButton rbfutureBkg;
		private System.Windows.Forms.Button Searchbtn;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtEnddt;
		private System.Windows.Forms.TextBox txtStartdt;
		private System.Windows.Forms.Button btnVehivleAvailability;
	}
}