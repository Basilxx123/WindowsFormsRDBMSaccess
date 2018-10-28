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
using System.Globalization;

namespace WindowsFormsRDBMSaccess
{
    public partial class BookingForm : Form
    {

        //Function created to create and open Connection. Common Function 
        private SqlConnection OpenConnection()
        {
            string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
            SqlConnection con= new SqlConnection(str_connection);
            con.Open();
            return con;

        }

        //Function created to create and close Connection. Common Function 
        private void CloseConnection(SqlConnection con)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        public BookingForm()
        {
            InitializeComponent();
        }


        private void BookingForm_Load(object sender, EventArgs e)
        {
			
			try
            {	
				BookingIDtxt.Enabled = false;
                BindGrid(); //Function Call
                BindCustomerID(); //Function Call
                BindVehicleID(); //Function Call
				BindEmpName();

				//Default booking time settings
				dtBkgTime.Format = DateTimePickerFormat.Custom;
                dtBkgTime.CustomFormat = "HH:mm:ss";
                dtBkgTime.ShowUpDown = true;

                //Default return time settings
                dtRtnTime.Format = DateTimePickerFormat.Custom;
                dtRtnTime.CustomFormat = "HH:mm:ss";
                dtRtnTime.ShowUpDown = true;

				//Bookings radio buttons
				DataGridviewBookings_data();
				cmbStatus.Items.Add("Finished");
				cmbStatus.Items.Add("Active");
				cmbStatus.Items.Add("Pending");

			}
            catch (Exception ex)
            {
				
				MessageBox.Show("There was a problem loading data from the database - plz call 95957777! :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        //Following function to bind the grid
        private void BindGrid()
        {
            string MySelect = "SELECT [BookingID],[CustomerID],[VIN],[BookingDate],[BookingTime] " +
                                        " ,[ReturnDate],[ReturnTime]" +
										" ,[OdoReadingOutbound],[OdoReadingInbound],[Discount]" +
										" ,[ObservationsOut],[ObservationsIn],[EmpID],[Cost]" +
							   "FROM [CarRental].dbo.[Booking] " +
                               "order by [Bookingdate] asc; ";

            SqlConnection con = OpenConnection();
            SqlDataAdapter ada = new SqlDataAdapter(MySelect, con);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            CloseConnection(con);
            dataGridView1.ReadOnly = false;
            dataGridView1.DataSource = ds.Tables[0];
        }

        //Functions added
        private void BindCustomerID()
        {
            string MySelect = "select * from Customer";
            SqlConnection con = OpenConnection();
            SqlDataAdapter ada = new SqlDataAdapter(MySelect, con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            
            CloseConnection(con); 
            
            if (dt != null)
            {
                cmbCustomerID.ValueMember = "CustomerID";
                cmbCustomerID.DisplayMember = "CustomerID";
                cmbCustomerID.DataSource = dt;
            }
        }
		private void BindEmpName()
		{
			string MySelect = "select * from Employee";
			SqlConnection con = OpenConnection();
			SqlDataAdapter ada = new SqlDataAdapter(MySelect, con);
			DataTable dt = new DataTable();
			ada.Fill(dt);

			CloseConnection(con);

			if (dt != null)
			{
				CmbEmpName.ValueMember = "EmpID";
				CmbEmpName.DisplayMember = "FirstName";
				CmbEmpName.DataSource = dt;
			}
		}
		private void BindVehicleID()
        {
            
            string MySelect = "select * from vehicle";
            SqlConnection con = OpenConnection();
            SqlDataAdapter ada = new SqlDataAdapter(MySelect, con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            CloseConnection(con); 
            if (dt != null)
            {
                cmbVihicleID.ValueMember = "VIN";
                cmbVihicleID.DisplayMember = "VIN";
                cmbVihicleID.DataSource = dt;
            }
        }
		int int_bookingid;
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int currentRow = dataGridView1.CurrentCell.RowIndex;
			dataGridView1.CurrentCell = dataGridView1.Rows[currentRow].Cells[0];
			string bookingid = dataGridView1.CurrentCell.Value.ToString();
			int_bookingid = Int32.Parse(bookingid);
			dataGridView1.Rows[currentRow].Cells["BookingID"].ReadOnly = true;

			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				BookingIDtxt.Text = row.Cells["BookingID"].Value.ToString();
				//CustIDtxt.Text = row.Cells["CustomerID"].Value.ToString();
                cmbCustomerID.SelectedValue = Convert.ToInt32(row.Cells["CustomerID"].Value.ToString());
				//VINtxt.Text = row.Cells["VIN"].Value.ToString();
                cmbVihicleID.SelectedValue = Convert.ToInt32(row.Cells["VIN"].Value.ToString());

                //Start:Date handling
                DateTime dt = DateTime.Parse(row.Cells["BookingDate"].Value.ToString(), CultureInfo.InvariantCulture);
                dtpBkgDate.Text = dt.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                DateTime dt1 = DateTime.Parse(row.Cells["ReturnDate"].Value.ToString(), CultureInfo.InvariantCulture);
                dtpRtnDate.Text = dt1.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                //End

                dtBkgTime.Text = row.Cells["BookingTime"].Value.ToString();
				dtRtnTime.Text = row.Cells["ReturnTime"].Value.ToString();
				OdoOuttxt.Text = row.Cells["OdoReadingOutbound"].Value.ToString();
				OdoIntxt.Text = row.Cells["OdoReadingInbound"].Value.ToString();
				Discount_txt.Text = row.Cells["Discount"].Value.ToString();
				ObsOuttxt.Text = row.Cells["ObservationsOut"].Value.ToString();
				ObsIntxt.Text = row.Cells["ObservationsIn"].Value.ToString();
				Costtxt.Text = row.Cells["Cost"].Value.ToString();

				if (row.Cells["Booking Status"].Value.ToString() == "Pending")
				{
					cmbStatus.ResetText();
					cmbStatus.SelectedText = "Pending";
				}

				if (row.Cells["Booking Status"].Value.ToString() == "Active")
				{
					cmbStatus.ResetText();
					cmbStatus.SelectedText = "Active";
				}

				if (row.Cells["Booking Status"].Value.ToString() == "Finished")
				{
					cmbStatus.ResetText();
					cmbStatus.SelectedText = "Finished";
				}

			}
		}


		public void DataGridviewBookings_data()
		{

			try
			{		
				string MySelect = "SELECT [BookingID] ,[Booking Status], [CustomerID] ,[VIN] , CONVERT(char(10),[BookingDate], 111) as [BookingDate] ,  [BookingTime], " +
				" CONVERT(char(10),[ReturnDate], 111) as [ReturnDate] ,[ReturnTime]  ,[OdoReadingOutbound]  ,[OdoReadingInbound]  ,[Discount]  ,[ObservationsOut]  ,[ObservationsIn] ,[EmpID], Cost " +
				"FROM dbo.Booking where 1=1 ";


				if (rbCurrentBkg.Checked == true)
				{
					MySelect = MySelect + " and Status = 'Active'";
				}

				if (RbPastBkg.Checked == true)
				{
					MySelect = MySelect + " and Status = 'Finished'";

				}
				if (rbfutureBkg.Checked == true)
				{
					MySelect = MySelect + " and Status = 'Pending'";

				}

				MySelect = MySelect + " order by BookingDate asc; ";
				SqlConnection con = OpenConnection();
				SqlDataAdapter ada = new SqlDataAdapter(MySelect, con);
				DataSet ds = new DataSet();
				ada.Fill(ds);
				dataGridView1.ReadOnly = false;
				dataGridView1.DataSource = ds.Tables[0];
			}
			catch (Exception ex)
			{
				MessageBox.Show($"There was problem while loading data from the databese! : {ex.Message}", "Error", MessageBoxButtons.OK);
			}


		}

		private void CreateBkgbtn_Click(object sender, EventArgs e)
		{
			try
			{
				string MyIns = "Insert into [dbo].[Booking] " +
							   "VALUES (" +
			  
			  Convert.ToInt32(cmbCustomerID.SelectedValue) + "," +
			  Convert.ToInt32(cmbCustomerID.SelectedValue) + ",'" +
			  Convert.ToDateTime(dtpBkgDate.Text).ToShortDateString() + "'," +
			  Convert.ToDateTime(dtBkgTime.Text).ToShortTimeString() + "'," +
			  Convert.ToDateTime(dtpRtnDate.Text).ToShortDateString() + "'," +
			  Convert.ToDateTime(dtRtnTime.Text).ToShortTimeString() + "'" +
			  OdoOuttxt.Text + "','" +
			  OdoIntxt.Text + "','" +
			  Discount_txt.Text + "','" +
			  Costtxt.Text + "','" +
			  ObsOuttxt.Text + "','" +
			  ObsIntxt.Text + "')";

				SqlConnection con = OpenConnection();
				SqlCommand BkgUpd = new SqlCommand(MyIns, con);
				BkgUpd.ExecuteNonQuery();
                CloseConnection(con);

				MessageBox.Show("Save Complete!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("There was a problem loading data from the database - plz call 95957777! :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdateVehbtn_Click(object sender, EventArgs e)
		{
			try
			{	
				string MyUpd = "Update [dbo].[Booking] " +
							   "set [ObservationsIn] = '" + ObsIntxt.Text + "'," +
							   " [BookingDate] = '" + Convert.ToDateTime(dtpBkgDate.Text).ToShortDateString() + "'," +
							   " [BookingTime] = '" + Convert.ToDateTime(dtBkgTime.Text).ToShortTimeString() + "'," +
							   " [ReturnDate] = '" + Convert.ToDateTime(dtpRtnDate.Text).ToShortDateString() + "'," +
							   " [ReturnTime] = '" + Convert.ToDateTime(dtRtnTime.Text).ToShortTimeString() + "'" +
							   " where [BookingID] = " + int_bookingid + ";";
				SqlConnection con = OpenConnection();		
				SqlCommand BkgUpd = new SqlCommand(MyUpd, con);
				BkgUpd.ExecuteNonQuery();
                CloseConnection(con);
				MessageBox.Show("Save Complete!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("There was a problem loading data from the database - plz call 95957777! :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DeleteVehbtn_Click(object sender, EventArgs e)
		{
			try
			{             
                
				string MyDelete = "Delete from [dbo].[Booking] where [BookingID] = '" + int_bookingid + "'";
                SqlConnection con = OpenConnection();
				SqlCommand BkgUpd = new SqlCommand(MyDelete, con);
				BkgUpd.ExecuteNonQuery();
                CloseConnection(con);
				BindGrid();
				MessageBox.Show("Data deleted successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("There was a problem loading data from the database - plz call 95957777! :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

		//Search by date functionality
		private void Searchbtn_Click(object sender, EventArgs e)
		{
			try
			{

				string MySelect = "SELECT [BookingID],[Booking Status],[CustomerID] ,[VIN] , CONVERT(char(10),[BookingDate], 111) as [BookingDate] ,  [BookingTime], " +
				" CONVERT(char(10),[ReturnDate], 111) as [ReturnDate] ,[ReturnTime]  ,[OdoReadingOutbound]  ,[OdoReadingInbound]  ,[Discount]  ,[ObservationsOut]  ,[ObservationsIn] ,[EmpID], Cost " +
				"FROM dbo.Booking where BookingDate >= '" + SearchBydateBtn.Text + "'";
				MySelect = MySelect + " order by BookingDate asc; ";
				SqlConnection con = OpenConnection();
				SqlDataAdapter ada = new SqlDataAdapter(MySelect, con);
				DataSet ds = new DataSet();
				ada.Fill(ds);
				dataGridView1.ReadOnly = false;
				dataGridView1.DataSource = ds.Tables[0];

			}
			catch (Exception ex)
			{
				MessageBox.Show($"There was problem while lifting bookings by date! : {ex.Message}", "Error", MessageBoxButtons.OK);
			}
		}
		//Button for Check Vehicle availbality
		private void btnVehivleAvailability_Click(object sender, EventArgs e)
		{
			try
			{
				string MySelect = "SELECT * " +
								  "From Booking as t1 " +
								  "WHERE t1.VIN not in (" +
								  "SELECT t1.VIN " +
								  "FROM Booking as t1, " +
								  "Booking as t2 " +
								  "Where t1.VIN = t2.VIN and not (t2.ReturnDate < '" + txtStartdt.Text + "' or t2.BookingDate > '" + txtEnddt.Text + "'));";
				SqlConnection con = OpenConnection();
				SqlDataAdapter ada = new SqlDataAdapter(MySelect, con);
				DataSet ds = new DataSet();
				ada.Fill(ds);
				dataGridView1.ReadOnly = false;
				dataGridView1.DataSource = ds.Tables[0];
			}
			catch (Exception ex)
			{
				MessageBox.Show($"There was problem whit loading data from the databese! : {ex.Message}", "Error", MessageBoxButtons.OK);
			}
		}

		private void RbPastBkg_CheckedChanged(object sender, EventArgs e)
		{
			this.DataGridviewBookings_data();
		}

		private void rbCurrentBkg_CheckedChanged(object sender, EventArgs e)
		{
			this.DataGridviewBookings_data();
		}

		private void rbfutureBkg_CheckedChanged(object sender, EventArgs e)
		{
			this.DataGridviewBookings_data();
		}
		
	}
}

