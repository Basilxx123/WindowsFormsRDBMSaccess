using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsRDBMSaccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                
                string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
                string MySelect = "SELECT [CustomerID],[FirstName],[LastName],[StreetNo],[Suburb],[State],[StreetName],[PostCode], " +
                                            "[MobPhone],[DriverLicNo],[CreditCardType],[CreditCardNo],[ExpDate],[NameOnCreditCard] " +
                                   "FROM [CarRental].dbo.[Customer] " +
                                   "order by LastName; ";
                SqlConnection con = new SqlConnection(str_connection);
                SqlDataAdapter ada = new SqlDataAdapter(MySelect, con);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                dataGridView1.ReadOnly = false;
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was a problem loading data from the database - plz call 95957777! :{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        int int_custid;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.CurrentCell = dataGridView1.Rows[currentRow].Cells[0];
            string custid = dataGridView1.CurrentCell.Value.ToString();
            int_custid = Int32.Parse(custid);
            dataGridView1.Rows[currentRow].Cells["CustomerID"].ReadOnly = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                CustIDtxt.Text = row.Cells["CustomerID"].Value.ToString();
                FirstNametxt.Text = row.Cells["FirstName"].Value.ToString();
                LastNametxt.Text = row.Cells["LastName"].Value.ToString();
                StreetNotxt.Text = row.Cells["StreetNo"].Value.ToString();
                StreetNametxt.Text = row.Cells["StreetName"].Value.ToString();
                Statetxt.Text = row.Cells["State"].Value.ToString();
                Suburbtxt.Text = row.Cells["Suburb"].Value.ToString();
                PostCodetxt.Text = row.Cells["PostCode"].Value.ToString();
                Mobphtxt.Text = row.Cells["MobPhone"].Value.ToString();
                DLictxt.Text = row.Cells["DriverLicNo"].Value.ToString();
                CardTypetxt.Text = row.Cells["CreditCardType"].Value.ToString();
                CardNotxt.Text = row.Cells["CreditCardNo"].Value.ToString();
                ExpDatetxt.Text = row.Cells["ExpDate"].Value.ToString();
                NameCardtxt.Text = row.Cells["NameOnCreditCard"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
                string MyUpd = "Update [dbo].[Customer] " +
                               "set [StreetNo] = " 
                               + StreetNotxt.Text +
                               "where [CustomerID] = " + int_custid + ";";
                SqlConnection con = new SqlConnection(str_connection);
                con.Open();
                SqlCommand CustUpd = new SqlCommand(MyUpd, con);
                CustUpd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Save Complete!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("There was a problem!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void CreateCustbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
                string MyIns = "Insert into [dbo].[Customer] " +
                               "VALUES ('" +
              FirstNametxt.Text + "','" +
              LastNametxt.Text + "','" +
              StreetNotxt.Text + "','" +
              StreetNametxt.Text + "','" +
              Statetxt.Text + "','" +
              Suburbtxt.Text + "','" +
              PostCodetxt.Text + "','" +
              Mobphtxt.Text + "','" +
              DLictxt.Text + "','" +
              CardTypetxt.Text + "','" +
              CardNotxt.Text + "','" +
              ExpDatetxt.Text + "','" +
              NameCardtxt.Text + "')";

                SqlConnection con = new SqlConnection(str_connection);
                con.Open();
                SqlCommand CustUpd = new SqlCommand(MyIns, con);
                CustUpd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Save Complete!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("There was a problem!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
                string MySrch = "SELECT [CustomerID],[FirstName],[LastName],[StreetNo],[Suburb],[State],[StreetName],[PostCode], " +
                                            "[MobPhone],[DriverLicNo],[CreditCardType],[CreditCardNo],[ExpDate],[NameOnCreditCard] " +
                                   "FROM [CarRental].dbo.[Customer] " +
                                   "where FirstName + LastName like '%" + NameSrchtxt.Text +  "%'; ";
                SqlConnection con = new SqlConnection(str_connection);
                SqlDataAdapter ada = new SqlDataAdapter(MySrch, con);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                dataGridView1.ReadOnly = false;
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was a problem searching for that name - plz call 99736373! :{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CretBooking_btn_Click(object sender, EventArgs e)
        {
            Form Bookingfrm = new BookingForm();
            Bookingfrm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {   
            // Exit program
            const string message = "Are you sure you would like to exit?";
            const string closing = "Closing program";
            var result = MessageBox.Show(message, closing, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Function to clear all textboxes
        void TextCleared(Control con)
        {
            foreach(Control t in con.Controls)
            {
                if (t is TextBox)
                    ((TextBox)t).Clear();
                else
                    TextCleared(t);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult clearDialog = MessageBox.Show("Clear Car Rental?", "All fields Cleared", MessageBoxButtons.YesNo);
            if(clearDialog == DialogResult.Yes)
            {
                TextCleared(this);
                FirstNametxt.Focus();

            }
        }

        private void TolCostbtn_Click(object sender, EventArgs e)
        {
            Form RentalCostfrm = new RentalCost();
            RentalCostfrm.Show();
        }

        private void UpdateOdo_btn_Click(object sender, EventArgs e)
        {
            Form UpdateODOfrm = new UpdateODO();
            UpdateODOfrm.Show();
        }
    }
}
