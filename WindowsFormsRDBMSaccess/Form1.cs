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
		//Function to clear all textboxes
		void TextCleared(Control con)
		{
			foreach (Control t in con.Controls)
			{
				if (t is TextBox)
					((TextBox)t).Clear();
				else
					TextCleared(t);
			}
		}

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
				MessageBox.Show("There was a problem loading data from the database - plz call 95957777! :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		//Update Customer into the database firstname,Lastname & NameonCreditCard

		private void button1_Click(object sender, EventArgs e)
        {
            try
            {
				string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
				string MyUpd = "Update [dbo].[Customer] " +
							   "set [LastName] = '" + LastNametxt.Text + "'" +
							    ", [FirstName] = '" + FirstNametxt.Text + "'" +
								", NameonCreditCard = '" + NameCardtxt.Text + "'" +
							   "where [CustomerID] = " + CustIDtxt.Text + ";";
				SqlConnection con = new SqlConnection(str_connection);
				con.Open();
				SqlCommand CustUpd = new SqlCommand(MyUpd, con);
				CustUpd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Save Complete!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("There was a problem loading data from the database - plz call 95957777! :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//Insert Customer into database
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
			catch (Exception ex)
			{
				MessageBox.Show("There was a problem loading data from the database - plz call 95957777! :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}      

		//Delete Customer form database
		private void DeleteCustbtn_Click(object sender, EventArgs e)
		{
			try
			{
				string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
				string MyDelete = "Delete from [dbo].[Customer] where [CustomerID] = '" + int_custid + "'";				  
				SqlConnection con = new SqlConnection(str_connection);
				con.Open();
				SqlCommand CustUpd = new SqlCommand(MyDelete, con);
				CustUpd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Data deleted successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{

				MessageBox.Show("There was a problem loading data from the database - plz call 95957777! :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//Search customer by Firstname & lastname
		private void Search_btn_Click(object sender, EventArgs e)
		{
			try
			{
				string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
				string MySrch = "SELECT [CustomerID],[FirstName],[LastName],[StreetNo],[Suburb],[State],[StreetName],[PostCode], " +
											"[MobPhone],[DriverLicNo],[CreditCardType],[CreditCardNo],[ExpDate],[NameOnCreditCard] " +
								   "FROM [CarRental].dbo.[Customer] " +
								   "where FirstName + LastName like '%" + NameSrchtxt.Text + "%'; ";
				SqlConnection con = new SqlConnection(str_connection);
				SqlDataAdapter ada = new SqlDataAdapter(MySrch, con);
				DataSet ds = new DataSet();
				ada.Fill(ds);
				dataGridView1.ReadOnly = false;
				dataGridView1.DataSource = ds.Tables[0];
			}
			catch (Exception ex)
			{
				MessageBox.Show("There was a problem loading data from the database - plz call 95957777! :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Opening Vehicle Form
		private void Vehicle_btn_Click(object sender, EventArgs e)
		{
			Form Vehicle = new Vehicle();
			Vehicle.Show();
		}
		// Opening Booking Form
		private void CretBooking_btn_Click(object sender, EventArgs e)
		{
			Form Bookingfrm = new BookingForm();
			Bookingfrm.Show();
		}
		// Reset textfields
		private void Resetbtn_Click(object sender, EventArgs e)
		{
			DialogResult clearDialog = MessageBox.Show("Clear Car Rental?", "All fields Cleared", MessageBoxButtons.YesNo);
			if (clearDialog == DialogResult.Yes)
			{
				TextCleared(this);
				FirstNametxt.Focus();

			}
		}

		// Exit program
		private void BtnExit_Click(object sender, EventArgs e)
		{
			
			const string message = "Are you sure you would like to exit?";
			const string closing = "Closing program";
			var result = MessageBox.Show(message, closing, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
