namespace WindowsFormsRDBMSaccess
{
    partial class Form1
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
			this.CustIDtxt = new System.Windows.Forms.TextBox();
			this.FirstNametxt = new System.Windows.Forms.TextBox();
			this.LastNametxt = new System.Windows.Forms.TextBox();
			this.Mobphtxt = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.StreetNotxt = new System.Windows.Forms.TextBox();
			this.StreetNametxt = new System.Windows.Forms.TextBox();
			this.Suburbtxt = new System.Windows.Forms.TextBox();
			this.PostCodetxt = new System.Windows.Forms.TextBox();
			this.Statetxt = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.DLictxt = new System.Windows.Forms.TextBox();
			this.CardTypetxt = new System.Windows.Forms.TextBox();
			this.CardNotxt = new System.Windows.Forms.TextBox();
			this.ExpDatetxt = new System.Windows.Forms.TextBox();
			this.NameCardtxt = new System.Windows.Forms.TextBox();
			this.CreateCustbtn = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.NameSrchtxt = new System.Windows.Forms.TextBox();
			this.Search_btn = new System.Windows.Forms.Button();
			this.CretBooking_btn = new System.Windows.Forms.Button();
			this.DeleteCustbtn = new System.Windows.Forms.Button();
			this.Vehicle_btn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.Resetbtn = new System.Windows.Forms.Button();
			this.BtnExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(606, 86);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(908, 458);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// CustIDtxt
			// 
			this.CustIDtxt.Location = new System.Drawing.Point(180, 86);
			this.CustIDtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.CustIDtxt.Name = "CustIDtxt";
			this.CustIDtxt.ReadOnly = true;
			this.CustIDtxt.Size = new System.Drawing.Size(132, 22);
			this.CustIDtxt.TabIndex = 1;
			// 
			// FirstNametxt
			// 
			this.FirstNametxt.Location = new System.Drawing.Point(180, 132);
			this.FirstNametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.FirstNametxt.Name = "FirstNametxt";
			this.FirstNametxt.Size = new System.Drawing.Size(132, 22);
			this.FirstNametxt.TabIndex = 2;
			// 
			// LastNametxt
			// 
			this.LastNametxt.Location = new System.Drawing.Point(180, 179);
			this.LastNametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.LastNametxt.Name = "LastNametxt";
			this.LastNametxt.Size = new System.Drawing.Size(132, 22);
			this.LastNametxt.TabIndex = 3;
			// 
			// Mobphtxt
			// 
			this.Mobphtxt.Location = new System.Drawing.Point(180, 340);
			this.Mobphtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Mobphtxt.Name = "Mobphtxt";
			this.Mobphtxt.Size = new System.Drawing.Size(132, 22);
			this.Mobphtxt.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(281, 684);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(144, 28);
			this.button1.TabIndex = 6;
			this.button1.Text = "Update Customer";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(67, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "Customer ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(67, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "First Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(67, 183);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "Last Name";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(67, 344);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 17);
			this.label5.TabIndex = 11;
			this.label5.Text = "Phone";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(71, 230);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 17);
			this.label6.TabIndex = 12;
			this.label6.Text = "Address";
			// 
			// StreetNotxt
			// 
			this.StreetNotxt.Location = new System.Drawing.Point(180, 230);
			this.StreetNotxt.Margin = new System.Windows.Forms.Padding(4);
			this.StreetNotxt.Name = "StreetNotxt";
			this.StreetNotxt.Size = new System.Drawing.Size(132, 22);
			this.StreetNotxt.TabIndex = 13;
			// 
			// StreetNametxt
			// 
			this.StreetNametxt.Location = new System.Drawing.Point(325, 230);
			this.StreetNametxt.Margin = new System.Windows.Forms.Padding(4);
			this.StreetNametxt.Name = "StreetNametxt";
			this.StreetNametxt.Size = new System.Drawing.Size(100, 22);
			this.StreetNametxt.TabIndex = 14;
			// 
			// Suburbtxt
			// 
			this.Suburbtxt.Location = new System.Drawing.Point(440, 230);
			this.Suburbtxt.Margin = new System.Windows.Forms.Padding(4);
			this.Suburbtxt.Name = "Suburbtxt";
			this.Suburbtxt.Size = new System.Drawing.Size(102, 22);
			this.Suburbtxt.TabIndex = 15;
			// 
			// PostCodetxt
			// 
			this.PostCodetxt.Location = new System.Drawing.Point(325, 286);
			this.PostCodetxt.Margin = new System.Windows.Forms.Padding(4);
			this.PostCodetxt.Name = "PostCodetxt";
			this.PostCodetxt.Size = new System.Drawing.Size(100, 22);
			this.PostCodetxt.TabIndex = 16;
			// 
			// Statetxt
			// 
			this.Statetxt.Location = new System.Drawing.Point(180, 286);
			this.Statetxt.Margin = new System.Windows.Forms.Padding(4);
			this.Statetxt.Name = "Statetxt";
			this.Statetxt.Size = new System.Drawing.Size(132, 22);
			this.Statetxt.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(67, 389);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 17);
			this.label7.TabIndex = 18;
			this.label7.Text = "DriversLic";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(67, 439);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 17);
			this.label8.TabIndex = 19;
			this.label8.Text = "CardType";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(67, 490);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 17);
			this.label9.TabIndex = 20;
			this.label9.Text = "CardNo";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(67, 536);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(61, 17);
			this.label10.TabIndex = 21;
			this.label10.Text = "ExpDate";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(68, 593);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(94, 17);
			this.label11.TabIndex = 22;
			this.label11.Text = "NameOnCard";
			// 
			// DLictxt
			// 
			this.DLictxt.Location = new System.Drawing.Point(180, 389);
			this.DLictxt.Margin = new System.Windows.Forms.Padding(4);
			this.DLictxt.Name = "DLictxt";
			this.DLictxt.Size = new System.Drawing.Size(132, 22);
			this.DLictxt.TabIndex = 23;
			// 
			// CardTypetxt
			// 
			this.CardTypetxt.Location = new System.Drawing.Point(180, 437);
			this.CardTypetxt.Margin = new System.Windows.Forms.Padding(4);
			this.CardTypetxt.Name = "CardTypetxt";
			this.CardTypetxt.Size = new System.Drawing.Size(132, 22);
			this.CardTypetxt.TabIndex = 24;
			// 
			// CardNotxt
			// 
			this.CardNotxt.Location = new System.Drawing.Point(180, 486);
			this.CardNotxt.Margin = new System.Windows.Forms.Padding(4);
			this.CardNotxt.Name = "CardNotxt";
			this.CardNotxt.Size = new System.Drawing.Size(132, 22);
			this.CardNotxt.TabIndex = 25;
			// 
			// ExpDatetxt
			// 
			this.ExpDatetxt.Location = new System.Drawing.Point(180, 536);
			this.ExpDatetxt.Margin = new System.Windows.Forms.Padding(4);
			this.ExpDatetxt.Name = "ExpDatetxt";
			this.ExpDatetxt.Size = new System.Drawing.Size(132, 22);
			this.ExpDatetxt.TabIndex = 26;
			// 
			// NameCardtxt
			// 
			this.NameCardtxt.Location = new System.Drawing.Point(180, 593);
			this.NameCardtxt.Margin = new System.Windows.Forms.Padding(4);
			this.NameCardtxt.Name = "NameCardtxt";
			this.NameCardtxt.Size = new System.Drawing.Size(132, 22);
			this.NameCardtxt.TabIndex = 27;
			// 
			// CreateCustbtn
			// 
			this.CreateCustbtn.Location = new System.Drawing.Point(70, 684);
			this.CreateCustbtn.Name = "CreateCustbtn";
			this.CreateCustbtn.Size = new System.Drawing.Size(157, 28);
			this.CreateCustbtn.TabIndex = 28;
			this.CreateCustbtn.Text = "Add Customer";
			this.CreateCustbtn.UseVisualStyleBackColor = true;
			this.CreateCustbtn.Click += new System.EventHandler(this.CreateCustbtn_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(605, 585);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(114, 17);
			this.label12.TabIndex = 31;
			this.label12.Text = "Search on Name";
			// 
			// NameSrchtxt
			// 
			this.NameSrchtxt.Location = new System.Drawing.Point(720, 585);
			this.NameSrchtxt.Name = "NameSrchtxt";
			this.NameSrchtxt.Size = new System.Drawing.Size(165, 22);
			this.NameSrchtxt.TabIndex = 32;
			// 
			// Search_btn
			// 
			this.Search_btn.Location = new System.Drawing.Point(917, 580);
			this.Search_btn.Name = "Search_btn";
			this.Search_btn.Size = new System.Drawing.Size(75, 33);
			this.Search_btn.TabIndex = 33;
			this.Search_btn.Text = "Search";
			this.Search_btn.UseVisualStyleBackColor = true;
			this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
			// 
			// CretBooking_btn
			// 
			this.CretBooking_btn.Location = new System.Drawing.Point(1375, 21);
			this.CretBooking_btn.Name = "CretBooking_btn";
			this.CretBooking_btn.Size = new System.Drawing.Size(128, 28);
			this.CretBooking_btn.TabIndex = 34;
			this.CretBooking_btn.Text = "Booking";
			this.CretBooking_btn.UseVisualStyleBackColor = true;
			this.CretBooking_btn.Click += new System.EventHandler(this.CretBooking_btn_Click);
			// 
			// DeleteCustbtn
			// 
			this.DeleteCustbtn.Location = new System.Drawing.Point(487, 684);
			this.DeleteCustbtn.Name = "DeleteCustbtn";
			this.DeleteCustbtn.Size = new System.Drawing.Size(132, 28);
			this.DeleteCustbtn.TabIndex = 35;
			this.DeleteCustbtn.Text = "Delete Customer";
			this.DeleteCustbtn.UseVisualStyleBackColor = true;
			this.DeleteCustbtn.Click += new System.EventHandler(this.DeleteCustbtn_Click);
			// 
			// Vehicle_btn
			// 
			this.Vehicle_btn.Location = new System.Drawing.Point(1229, 21);
			this.Vehicle_btn.Name = "Vehicle_btn";
			this.Vehicle_btn.Size = new System.Drawing.Size(126, 28);
			this.Vehicle_btn.TabIndex = 36;
			this.Vehicle_btn.Text = "Vehicle";
			this.Vehicle_btn.UseVisualStyleBackColor = true;
			this.Vehicle_btn.Click += new System.EventHandler(this.Vehicle_btn_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Sitka Subheading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(63, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(169, 40);
			this.label4.TabIndex = 37;
			this.label4.Text = "CUSTOMER";
			// 
			// Resetbtn
			// 
			this.Resetbtn.Location = new System.Drawing.Point(1326, 689);
			this.Resetbtn.Name = "Resetbtn";
			this.Resetbtn.Size = new System.Drawing.Size(82, 28);
			this.Resetbtn.TabIndex = 38;
			this.Resetbtn.Text = "Reset";
			this.Resetbtn.UseVisualStyleBackColor = true;
			this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
			// 
			// BtnExit
			// 
			this.BtnExit.Location = new System.Drawing.Point(1439, 689);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(75, 28);
			this.BtnExit.TabIndex = 39;
			this.BtnExit.Text = "Exit";
			this.BtnExit.UseVisualStyleBackColor = true;
			this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1580, 737);
			this.Controls.Add(this.BtnExit);
			this.Controls.Add(this.Resetbtn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Vehicle_btn);
			this.Controls.Add(this.DeleteCustbtn);
			this.Controls.Add(this.CretBooking_btn);
			this.Controls.Add(this.Search_btn);
			this.Controls.Add(this.NameSrchtxt);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.CreateCustbtn);
			this.Controls.Add(this.NameCardtxt);
			this.Controls.Add(this.ExpDatetxt);
			this.Controls.Add(this.CardNotxt);
			this.Controls.Add(this.CardTypetxt);
			this.Controls.Add(this.DLictxt);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.Statetxt);
			this.Controls.Add(this.PostCodetxt);
			this.Controls.Add(this.Suburbtxt);
			this.Controls.Add(this.StreetNametxt);
			this.Controls.Add(this.StreetNotxt);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Mobphtxt);
			this.Controls.Add(this.LastNametxt);
			this.Controls.Add(this.FirstNametxt);
			this.Controls.Add(this.CustIDtxt);
			this.Controls.Add(this.dataGridView1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox CustIDtxt;
        private System.Windows.Forms.TextBox FirstNametxt;
        private System.Windows.Forms.TextBox LastNametxt;
        private System.Windows.Forms.TextBox Mobphtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StreetNotxt;
        private System.Windows.Forms.TextBox StreetNametxt;
        private System.Windows.Forms.TextBox Suburbtxt;
        private System.Windows.Forms.TextBox PostCodetxt;
        private System.Windows.Forms.TextBox Statetxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DLictxt;
        private System.Windows.Forms.TextBox CardTypetxt;
        private System.Windows.Forms.TextBox CardNotxt;
        private System.Windows.Forms.TextBox ExpDatetxt;
        private System.Windows.Forms.TextBox NameCardtxt;
        private System.Windows.Forms.Button CreateCustbtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NameSrchtxt;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button CretBooking_btn;
		private System.Windows.Forms.Button DeleteCustbtn;
		private System.Windows.Forms.Button Vehicle_btn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button Resetbtn;
		private System.Windows.Forms.Button BtnExit;
	}
}

