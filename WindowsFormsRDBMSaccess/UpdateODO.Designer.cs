namespace WindowsFormsRDBMSaccess
{
    partial class UpdateODO
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
            this.VINtxt = new System.Windows.Forms.TextBox();
            this.Odotxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ChkAvailbtn_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // VINtxt
            // 
            this.VINtxt.Location = new System.Drawing.Point(29, 52);
            this.VINtxt.Name = "VINtxt";
            this.VINtxt.Size = new System.Drawing.Size(161, 22);
            this.VINtxt.TabIndex = 0;
            // 
            // Odotxt
            // 
            this.Odotxt.Location = new System.Drawing.Point(29, 112);
            this.Odotxt.Name = "Odotxt";
            this.Odotxt.Size = new System.Drawing.Size(161, 22);
            this.Odotxt.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(253, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(489, 175);
            this.dataGridView1.TabIndex = 2;
            // 
            // ChkAvailbtn_Click
            // 
            this.ChkAvailbtn_Click.Location = new System.Drawing.Point(29, 186);
            this.ChkAvailbtn_Click.Name = "ChkAvailbtn_Click";
            this.ChkAvailbtn_Click.Size = new System.Drawing.Size(168, 28);
            this.ChkAvailbtn_Click.TabIndex = 3;
            this.ChkAvailbtn_Click.Text = "Update Odometer";
            this.ChkAvailbtn_Click.UseVisualStyleBackColor = true;
            this.ChkAvailbtn_Click.Click += new System.EventHandler(this.ChkAvailbtn_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "VIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Odo";
            // 
            // UpdateODO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChkAvailbtn_Click);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Odotxt);
            this.Controls.Add(this.VINtxt);
            this.Name = "UpdateODO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateODO";
            this.Load += new System.EventHandler(this.UpdateODO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VINtxt;
        private System.Windows.Forms.TextBox Odotxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ChkAvailbtn_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}