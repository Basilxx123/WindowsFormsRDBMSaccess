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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.TolCostbtn = new System.Windows.Forms.Button();
            this.UpdateOdo_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(604, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(861, 458);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CustIDtxt
            // 
            this.CustIDtxt.Location = new System.Drawing.Point(180, 25);
            this.CustIDtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustIDtxt.Name = "CustIDtxt";
            this.CustIDtxt.ReadOnly = true;
            this.CustIDtxt.Size = new System.Drawing.Size(100, 22);
            this.CustIDtxt.TabIndex = 1;
            // 
            // FirstNametxt
            // 
            this.FirstNametxt.Location = new System.Drawing.Point(180, 71);
            this.FirstNametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstNametxt.Name = "FirstNametxt";
            this.FirstNametxt.Size = new System.Drawing.Size(100, 22);
            this.FirstNametxt.TabIndex = 2;
            // 
            // LastNametxt
            // 
            this.LastNametxt.Location = new System.Drawing.Point(180, 126);
            this.LastNametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastNametxt.Name = "LastNametxt";
            this.LastNametxt.Size = new System.Drawing.Size(100, 22);
            this.LastNametxt.TabIndex = 3;
            // 
            // Mobphtxt
            // 
            this.Mobphtxt.Location = new System.Drawing.Point(180, 302);
            this.Mobphtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mobphtxt.Name = "Mobphtxt";
            this.Mobphtxt.Size = new System.Drawing.Size(100, 22);
            this.Mobphtxt.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 684);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Address";
            // 
            // StreetNotxt
            // 
            this.StreetNotxt.Location = new System.Drawing.Point(180, 183);
            this.StreetNotxt.Margin = new System.Windows.Forms.Padding(4);
            this.StreetNotxt.Name = "StreetNotxt";
            this.StreetNotxt.Size = new System.Drawing.Size(100, 22);
            this.StreetNotxt.TabIndex = 13;
            // 
            // StreetNametxt
            // 
            this.StreetNametxt.Location = new System.Drawing.Point(297, 183);
            this.StreetNametxt.Margin = new System.Windows.Forms.Padding(4);
            this.StreetNametxt.Name = "StreetNametxt";
            this.StreetNametxt.Size = new System.Drawing.Size(116, 22);
            this.StreetNametxt.TabIndex = 14;
            // 
            // Suburbtxt
            // 
            this.Suburbtxt.Location = new System.Drawing.Point(435, 183);
            this.Suburbtxt.Margin = new System.Windows.Forms.Padding(4);
            this.Suburbtxt.Name = "Suburbtxt";
            this.Suburbtxt.Size = new System.Drawing.Size(112, 22);
            this.Suburbtxt.TabIndex = 15;
            // 
            // PostCodetxt
            // 
            this.PostCodetxt.Location = new System.Drawing.Point(325, 239);
            this.PostCodetxt.Margin = new System.Windows.Forms.Padding(4);
            this.PostCodetxt.Name = "PostCodetxt";
            this.PostCodetxt.Size = new System.Drawing.Size(100, 22);
            this.PostCodetxt.TabIndex = 16;
            // 
            // Statetxt
            // 
            this.Statetxt.Location = new System.Drawing.Point(180, 239);
            this.Statetxt.Margin = new System.Windows.Forms.Padding(4);
            this.Statetxt.Name = "Statetxt";
            this.Statetxt.Size = new System.Drawing.Size(116, 22);
            this.Statetxt.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 351);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "DriversLic";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 401);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "CardType";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 452);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "CardNo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 498);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "ExpDate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(68, 555);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "NameOnCard";
            // 
            // DLictxt
            // 
            this.DLictxt.Location = new System.Drawing.Point(180, 351);
            this.DLictxt.Margin = new System.Windows.Forms.Padding(4);
            this.DLictxt.Name = "DLictxt";
            this.DLictxt.Size = new System.Drawing.Size(132, 22);
            this.DLictxt.TabIndex = 23;
            // 
            // CardTypetxt
            // 
            this.CardTypetxt.Location = new System.Drawing.Point(180, 399);
            this.CardTypetxt.Margin = new System.Windows.Forms.Padding(4);
            this.CardTypetxt.Name = "CardTypetxt";
            this.CardTypetxt.Size = new System.Drawing.Size(132, 22);
            this.CardTypetxt.TabIndex = 24;
            // 
            // CardNotxt
            // 
            this.CardNotxt.Location = new System.Drawing.Point(180, 448);
            this.CardNotxt.Margin = new System.Windows.Forms.Padding(4);
            this.CardNotxt.Name = "CardNotxt";
            this.CardNotxt.Size = new System.Drawing.Size(132, 22);
            this.CardNotxt.TabIndex = 25;
            // 
            // ExpDatetxt
            // 
            this.ExpDatetxt.Location = new System.Drawing.Point(180, 498);
            this.ExpDatetxt.Margin = new System.Windows.Forms.Padding(4);
            this.ExpDatetxt.Name = "ExpDatetxt";
            this.ExpDatetxt.Size = new System.Drawing.Size(132, 22);
            this.ExpDatetxt.TabIndex = 26;
            // 
            // NameCardtxt
            // 
            this.NameCardtxt.Location = new System.Drawing.Point(180, 555);
            this.NameCardtxt.Margin = new System.Windows.Forms.Padding(4);
            this.NameCardtxt.Name = "NameCardtxt";
            this.NameCardtxt.Size = new System.Drawing.Size(132, 22);
            this.NameCardtxt.TabIndex = 27;
            // 
            // CreateCustbtn
            // 
            this.CreateCustbtn.Location = new System.Drawing.Point(312, 684);
            this.CreateCustbtn.Name = "CreateCustbtn";
            this.CreateCustbtn.Size = new System.Drawing.Size(157, 28);
            this.CreateCustbtn.TabIndex = 28;
            this.CreateCustbtn.Text = "Create Customer";
            this.CreateCustbtn.UseVisualStyleBackColor = true;
            this.CreateCustbtn.Click += new System.EventHandler(this.CreateCustbtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(601, 558);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Search on Name";
            // 
            // NameSrchtxt
            // 
            this.NameSrchtxt.Location = new System.Drawing.Point(716, 558);
            this.NameSrchtxt.Name = "NameSrchtxt";
            this.NameSrchtxt.Size = new System.Drawing.Size(165, 22);
            this.NameSrchtxt.TabIndex = 32;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(913, 553);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 33);
            this.Search_btn.TabIndex = 33;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // CretBooking_btn
            // 
            this.CretBooking_btn.Location = new System.Drawing.Point(584, 684);
            this.CretBooking_btn.Name = "CretBooking_btn";
            this.CretBooking_btn.Size = new System.Drawing.Size(139, 28);
            this.CretBooking_btn.TabIndex = 34;
            this.CretBooking_btn.Text = "Create Booking";
            this.CretBooking_btn.UseVisualStyleBackColor = true;
            this.CretBooking_btn.Click += new System.EventHandler(this.CretBooking_btn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1377, 664);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 31);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1246, 664);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 31);
            this.btnReset.TabIndex = 36;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // TolCostbtn
            // 
            this.TolCostbtn.Location = new System.Drawing.Point(994, 684);
            this.TolCostbtn.Name = "TolCostbtn";
            this.TolCostbtn.Size = new System.Drawing.Size(144, 28);
            this.TolCostbtn.TabIndex = 37;
            this.TolCostbtn.Text = "Total Rental Cost";
            this.TolCostbtn.UseVisualStyleBackColor = true;
            this.TolCostbtn.Click += new System.EventHandler(this.TolCostbtn_Click);
            // 
            // UpdateOdo_btn
            // 
            this.UpdateOdo_btn.Location = new System.Drawing.Point(784, 684);
            this.UpdateOdo_btn.Name = "UpdateOdo_btn";
            this.UpdateOdo_btn.Size = new System.Drawing.Size(143, 26);
            this.UpdateOdo_btn.TabIndex = 38;
            this.UpdateOdo_btn.Text = "Update Odometer";
            this.UpdateOdo_btn.UseVisualStyleBackColor = true;
            this.UpdateOdo_btn.Click += new System.EventHandler(this.UpdateOdo_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 737);
            this.Controls.Add(this.UpdateOdo_btn);
            this.Controls.Add(this.TolCostbtn);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
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
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button TolCostbtn;
        private System.Windows.Forms.Button UpdateOdo_btn;
    }
}

