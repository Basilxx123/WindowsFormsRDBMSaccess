namespace WindowsFormsRDBMSaccess
{
	partial class ServiceRecord
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.RecIdtxt = new System.Windows.Forms.TextBox();
			this.Vintxt = new System.Windows.Forms.TextBox();
			this.CustIdtxt = new System.Windows.Forms.TextBox();
			this.Datetxt = new System.Windows.Forms.TextBox();
			this.Odotxt = new System.Windows.Forms.TextBox();
			this.Servicetxt = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.Addbtn = new System.Windows.Forms.Button();
			this.Updatebtn = new System.Windows.Forms.Button();
			this.Deletebtn = new System.Windows.Forms.Button();
			this.Closebtn = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(440, 76);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(658, 361);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 109);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Record ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 160);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "VIN";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 271);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Date";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(36, 323);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 17);
			this.label5.TabIndex = 5;
			this.label5.Text = "Odo Reading";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(36, 370);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(132, 17);
			this.label6.TabIndex = 6;
			this.label6.Text = "Services Performed";
			// 
			// RecIdtxt
			// 
			this.RecIdtxt.Location = new System.Drawing.Point(203, 104);
			this.RecIdtxt.Name = "RecIdtxt";
			this.RecIdtxt.ReadOnly = true;
			this.RecIdtxt.Size = new System.Drawing.Size(100, 22);
			this.RecIdtxt.TabIndex = 7;
			// 
			// Vintxt
			// 
			this.Vintxt.Location = new System.Drawing.Point(203, 155);
			this.Vintxt.Name = "Vintxt";
			this.Vintxt.Size = new System.Drawing.Size(100, 22);
			this.Vintxt.TabIndex = 8;
			// 
			// CustIdtxt
			// 
			this.CustIdtxt.Location = new System.Drawing.Point(203, 208);
			this.CustIdtxt.Name = "CustIdtxt";
			this.CustIdtxt.Size = new System.Drawing.Size(100, 22);
			this.CustIdtxt.TabIndex = 9;
			// 
			// Datetxt
			// 
			this.Datetxt.Location = new System.Drawing.Point(203, 266);
			this.Datetxt.Name = "Datetxt";
			this.Datetxt.Size = new System.Drawing.Size(100, 22);
			this.Datetxt.TabIndex = 10;
			// 
			// Odotxt
			// 
			this.Odotxt.Location = new System.Drawing.Point(203, 318);
			this.Odotxt.Name = "Odotxt";
			this.Odotxt.Size = new System.Drawing.Size(100, 22);
			this.Odotxt.TabIndex = 11;
			// 
			// Servicetxt
			// 
			this.Servicetxt.Location = new System.Drawing.Point(203, 367);
			this.Servicetxt.Multiline = true;
			this.Servicetxt.Name = "Servicetxt";
			this.Servicetxt.Size = new System.Drawing.Size(200, 70);
			this.Servicetxt.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Sitka Subheading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(36, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(252, 40);
			this.label7.TabIndex = 13;
			this.label7.Text = "SERVICE RECORD";
			// 
			// Addbtn
			// 
			this.Addbtn.Location = new System.Drawing.Point(440, 481);
			this.Addbtn.Name = "Addbtn";
			this.Addbtn.Size = new System.Drawing.Size(101, 37);
			this.Addbtn.TabIndex = 14;
			this.Addbtn.Text = "Add";
			this.Addbtn.UseVisualStyleBackColor = true;
			this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
			// 
			// Updatebtn
			// 
			this.Updatebtn.Location = new System.Drawing.Point(583, 481);
			this.Updatebtn.Name = "Updatebtn";
			this.Updatebtn.Size = new System.Drawing.Size(90, 37);
			this.Updatebtn.TabIndex = 15;
			this.Updatebtn.Text = "Update";
			this.Updatebtn.UseVisualStyleBackColor = true;
			this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
			// 
			// Deletebtn
			// 
			this.Deletebtn.Location = new System.Drawing.Point(713, 481);
			this.Deletebtn.Name = "Deletebtn";
			this.Deletebtn.Size = new System.Drawing.Size(87, 37);
			this.Deletebtn.TabIndex = 16;
			this.Deletebtn.Text = "Delete";
			this.Deletebtn.UseVisualStyleBackColor = true;
			this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
			// 
			// Closebtn
			// 
			this.Closebtn.Location = new System.Drawing.Point(849, 481);
			this.Closebtn.Name = "Closebtn";
			this.Closebtn.Size = new System.Drawing.Size(95, 37);
			this.Closebtn.TabIndex = 17;
			this.Closebtn.Text = "Close";
			this.Closebtn.UseVisualStyleBackColor = true;
			this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 213);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 17);
			this.label3.TabIndex = 18;
			this.label3.Text = "Customer ID";
			// 
			// ServiceRecord
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1167, 554);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Closebtn);
			this.Controls.Add(this.Deletebtn);
			this.Controls.Add(this.Updatebtn);
			this.Controls.Add(this.Addbtn);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.Servicetxt);
			this.Controls.Add(this.Odotxt);
			this.Controls.Add(this.Datetxt);
			this.Controls.Add(this.CustIdtxt);
			this.Controls.Add(this.Vintxt);
			this.Controls.Add(this.RecIdtxt);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ServiceRecord";
			this.Text = "ServiceRecord";
			this.Load += new System.EventHandler(this.ServiceRecord_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox RecIdtxt;
		private System.Windows.Forms.TextBox Vintxt;
		private System.Windows.Forms.TextBox CustIdtxt;
		private System.Windows.Forms.TextBox Datetxt;
		private System.Windows.Forms.TextBox Odotxt;
		private System.Windows.Forms.TextBox Servicetxt;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button Addbtn;
		private System.Windows.Forms.Button Updatebtn;
		private System.Windows.Forms.Button Deletebtn;
		private System.Windows.Forms.Button Closebtn;
		private System.Windows.Forms.Label label3;
	}
}