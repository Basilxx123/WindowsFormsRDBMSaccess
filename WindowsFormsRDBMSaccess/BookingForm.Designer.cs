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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.VehicleAvail_btn = new System.Windows.Forms.Button();
			this.Startdate_txt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ReturnDate_txt = new System.Windows.Forms.TextBox();
			this.UpdateBkgBtn = new System.Windows.Forms.Button();
			this.BookingDatetxt = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(54, 31);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(857, 200);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// VehicleAvail_btn
			// 
			this.VehicleAvail_btn.Location = new System.Drawing.Point(734, 266);
			this.VehicleAvail_btn.Name = "VehicleAvail_btn";
			this.VehicleAvail_btn.Size = new System.Drawing.Size(177, 31);
			this.VehicleAvail_btn.TabIndex = 1;
			this.VehicleAvail_btn.Text = "Check Availability";
			this.VehicleAvail_btn.UseVisualStyleBackColor = true;
			this.VehicleAvail_btn.Click += new System.EventHandler(this.VehicleAvail_btn_Click);
			// 
			// Startdate_txt
			// 
			this.Startdate_txt.Location = new System.Drawing.Point(220, 277);
			this.Startdate_txt.Name = "Startdate_txt";
			this.Startdate_txt.Size = new System.Drawing.Size(164, 22);
			this.Startdate_txt.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 280);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Start Date YYYY-MM-DD";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(421, 276);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Return Date";
			// 
			// ReturnDate_txt
			// 
			this.ReturnDate_txt.Location = new System.Drawing.Point(512, 275);
			this.ReturnDate_txt.Name = "ReturnDate_txt";
			this.ReturnDate_txt.Size = new System.Drawing.Size(164, 22);
			this.ReturnDate_txt.TabIndex = 6;
			// 
			// UpdateBkgBtn
			// 
			this.UpdateBkgBtn.Location = new System.Drawing.Point(233, 352);
			this.UpdateBkgBtn.Name = "UpdateBkgBtn";
			this.UpdateBkgBtn.Size = new System.Drawing.Size(138, 27);
			this.UpdateBkgBtn.TabIndex = 8;
			this.UpdateBkgBtn.Text = "Update Booking";
			this.UpdateBkgBtn.UseVisualStyleBackColor = true;
			this.UpdateBkgBtn.Click += new System.EventHandler(this.UpdateBkgBtn_Click);
			// 
			// BookingDatetxt
			// 
			this.BookingDatetxt.Location = new System.Drawing.Point(54, 354);
			this.BookingDatetxt.Name = "BookingDatetxt";
			this.BookingDatetxt.Size = new System.Drawing.Size(151, 22);
			this.BookingDatetxt.TabIndex = 9;
			// 
			// BookingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(993, 409);
			this.Controls.Add(this.BookingDatetxt);
			this.Controls.Add(this.UpdateBkgBtn);
			this.Controls.Add(this.ReturnDate_txt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Startdate_txt);
			this.Controls.Add(this.VehicleAvail_btn);
			this.Controls.Add(this.dataGridView1);
			this.Name = "BookingForm";
			this.Text = "BookingForm";
			this.Load += new System.EventHandler(this.BookingForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button VehicleAvail_btn;
        private System.Windows.Forms.TextBox Startdate_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReturnDate_txt;
		private System.Windows.Forms.Button UpdateBkgBtn;
		private System.Windows.Forms.TextBox BookingDatetxt;
	}
}