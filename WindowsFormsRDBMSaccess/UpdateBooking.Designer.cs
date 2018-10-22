namespace WindowsFormsRDBMSaccess
{
    partial class UpdateBooking
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
            this.UpdateBkgbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VINtxt = new System.Windows.Forms.TextBox();
            this.BkgIdtxt = new System.Windows.Forms.TextBox();
            this.BkgDatetxt = new System.Windows.Forms.TextBox();
            this.BkgTimetxt = new System.Windows.Forms.TextBox();
            this.RetDatetxt = new System.Windows.Forms.TextBox();
            this.RetTimetxt = new System.Windows.Forms.TextBox();
            this.OdoOuttxt = new System.Windows.Forms.TextBox();
            this.OdoIntxt = new System.Windows.Forms.TextBox();
            this.ObsOuttxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ObsIntxt = new System.Windows.Forms.TextBox();
            this.Empidtxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateBkgbtn
            // 
            this.UpdateBkgbtn.Location = new System.Drawing.Point(369, 476);
            this.UpdateBkgbtn.Name = "UpdateBkgbtn";
            this.UpdateBkgbtn.Size = new System.Drawing.Size(190, 34);
            this.UpdateBkgbtn.TabIndex = 0;
            this.UpdateBkgbtn.Text = "Update Booking";
            this.UpdateBkgbtn.UseVisualStyleBackColor = true;
            this.UpdateBkgbtn.Click += new System.EventHandler(this.UpdateBkgbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(651, 340);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // VINtxt
            // 
            this.VINtxt.Location = new System.Drawing.Point(199, 31);
            this.VINtxt.Name = "VINtxt";
            this.VINtxt.ReadOnly = true;
            this.VINtxt.Size = new System.Drawing.Size(100, 22);
            this.VINtxt.TabIndex = 2;
            // 
            // BkgIdtxt
            // 
            this.BkgIdtxt.Location = new System.Drawing.Point(199, 81);
            this.BkgIdtxt.Name = "BkgIdtxt";
            this.BkgIdtxt.Size = new System.Drawing.Size(100, 22);
            this.BkgIdtxt.TabIndex = 3;
            // 
            // BkgDatetxt
            // 
            this.BkgDatetxt.Location = new System.Drawing.Point(199, 125);
            this.BkgDatetxt.Name = "BkgDatetxt";
            this.BkgDatetxt.Size = new System.Drawing.Size(100, 22);
            this.BkgDatetxt.TabIndex = 4;
            // 
            // BkgTimetxt
            // 
            this.BkgTimetxt.Location = new System.Drawing.Point(199, 174);
            this.BkgTimetxt.Name = "BkgTimetxt";
            this.BkgTimetxt.Size = new System.Drawing.Size(100, 22);
            this.BkgTimetxt.TabIndex = 5;
            // 
            // RetDatetxt
            // 
            this.RetDatetxt.Location = new System.Drawing.Point(199, 218);
            this.RetDatetxt.Name = "RetDatetxt";
            this.RetDatetxt.Size = new System.Drawing.Size(100, 22);
            this.RetDatetxt.TabIndex = 6;
            // 
            // RetTimetxt
            // 
            this.RetTimetxt.Location = new System.Drawing.Point(199, 260);
            this.RetTimetxt.Name = "RetTimetxt";
            this.RetTimetxt.Size = new System.Drawing.Size(100, 22);
            this.RetTimetxt.TabIndex = 7;
            // 
            // OdoOuttxt
            // 
            this.OdoOuttxt.Location = new System.Drawing.Point(199, 302);
            this.OdoOuttxt.Name = "OdoOuttxt";
            this.OdoOuttxt.Size = new System.Drawing.Size(100, 22);
            this.OdoOuttxt.TabIndex = 8;
            // 
            // OdoIntxt
            // 
            this.OdoIntxt.Location = new System.Drawing.Point(199, 346);
            this.OdoIntxt.Name = "OdoIntxt";
            this.OdoIntxt.Size = new System.Drawing.Size(100, 22);
            this.OdoIntxt.TabIndex = 9;
            // 
            // ObsOuttxt
            // 
            this.ObsOuttxt.Location = new System.Drawing.Point(199, 393);
            this.ObsOuttxt.Name = "ObsOuttxt";
            this.ObsOuttxt.Size = new System.Drawing.Size(100, 22);
            this.ObsOuttxt.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "VIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Booking ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Booking Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Booking Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Return Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Return Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "OdoReadingOutbound";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "OdoReadingInbound";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Observations Out";
            // 
            // ObsIntxt
            // 
            this.ObsIntxt.Location = new System.Drawing.Point(199, 443);
            this.ObsIntxt.Name = "ObsIntxt";
            this.ObsIntxt.Size = new System.Drawing.Size(100, 22);
            this.ObsIntxt.TabIndex = 20;
            // 
            // Empidtxt
            // 
            this.Empidtxt.Location = new System.Drawing.Point(199, 488);
            this.Empidtxt.Name = "Empidtxt";
            this.Empidtxt.Size = new System.Drawing.Size(100, 22);
            this.Empidtxt.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Observations In";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 493);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Emp ID";
            // 
            // UpdateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 546);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Empidtxt);
            this.Controls.Add(this.ObsIntxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObsOuttxt);
            this.Controls.Add(this.OdoIntxt);
            this.Controls.Add(this.OdoOuttxt);
            this.Controls.Add(this.RetTimetxt);
            this.Controls.Add(this.RetDatetxt);
            this.Controls.Add(this.BkgTimetxt);
            this.Controls.Add(this.BkgDatetxt);
            this.Controls.Add(this.BkgIdtxt);
            this.Controls.Add(this.VINtxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UpdateBkgbtn);
            this.Name = "UpdateBooking";
            this.Text = "UpdateBooking";
            this.Load += new System.EventHandler(this.UpdateBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateBkgbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox VINtxt;
        private System.Windows.Forms.TextBox BkgIdtxt;
        private System.Windows.Forms.TextBox BkgDatetxt;
        private System.Windows.Forms.TextBox BkgTimetxt;
        private System.Windows.Forms.TextBox RetDatetxt;
        private System.Windows.Forms.TextBox RetTimetxt;
        private System.Windows.Forms.TextBox OdoOuttxt;
        private System.Windows.Forms.TextBox OdoIntxt;
        private System.Windows.Forms.TextBox ObsOuttxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ObsIntxt;
        private System.Windows.Forms.TextBox Empidtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}