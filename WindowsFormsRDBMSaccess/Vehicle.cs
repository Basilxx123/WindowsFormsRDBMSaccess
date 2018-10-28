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
	public partial class Vehicle : Form
	{
		

		public Vehicle()
		{
			InitializeComponent();
		}

        public void BindGrid()
        {
			
			try
			{
				string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
				string MySelect = "SELECT [VIN],[Make],[Model],[Colour],[Type],[CurrentOdo],[YearOfManuf],[RegoNo],[RegoExpiry]," +
								  "[DailyRate],[HourlyRate],[CumulativeObservations]" +
								  "FROM [CarRental].dbo.[Vehicle]";
				SqlConnection con = new SqlConnection(str_connection);
				SqlDataAdapter ada = new SqlDataAdapter(MySelect, con);
				DataSet ds = new DataSet();
				ada.Fill(ds);
				gridviewVehicles_data.ReadOnly = false;
				gridviewVehicles_data.DataSource = ds.Tables[0];

			}
			catch (Exception ex)
			{
				MessageBox.Show($"There was problem whit loading data from the databese! : {ex.Message}", "Error", MessageBoxButtons.OK);
			}
		
		}

		private void Vehicle_Load(object sender, EventArgs e)
		{
			gridviewVehicles_data.DataSource = null;

			try
			{
                BindGrid();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"There was problem while loading data from the databese! : {ex.Message}", "Error", MessageBoxButtons.OK);
			}
		}

		int int_VIN;
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int currentRow = gridviewVehicles_data.CurrentCell.RowIndex;
			gridviewVehicles_data.CurrentCell = gridviewVehicles_data.Rows[currentRow].Cells[0];
			string vin = gridviewVehicles_data.CurrentCell.Value.ToString();
			int_VIN = Int32.Parse(vin);
			gridviewVehicles_data.Rows[currentRow].Cells["VIN"].ReadOnly = true;

			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.gridviewVehicles_data.Rows[e.RowIndex];
				VINtxt.Text = row.Cells["VIN"].Value.ToString();
				Maketxt.Text = row.Cells["Make"].Value.ToString();
				Modeltxt.Text = row.Cells["Model"].Value.ToString();
				Colourtxt.Text = row.Cells["Colour"].Value.ToString();
				Typetxt.Text = row.Cells["Type"].Value.ToString();
				CurrentOdotxt.Text = row.Cells["CurrentOdo"].Value.ToString();
				YrManutxt.Text = row.Cells["YearOfManuf"].Value.ToString();
				RegoNotxt.Text = row.Cells["RegoNo"].Value.ToString();
				RegoExtxt.Text = row.Cells["RegoExpiry"].Value.ToString();
				DailyRatetxt.Text = row.Cells["DailyRate"].Value.ToString();
				HourlyRatetxt.Text = row.Cells["HourlyRate"].Value.ToString();
				CumulativeObstxt.Text = row.Cells["CumulativeObservations"].Value.ToString();

			}
		}

		private void CreateVehbtn_Click(object sender, EventArgs e)
		{
			try
			{
				string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
				string MyIns = "Insert into [dbo].[Vehicle] " +
							   "VALUES ('" +
										  VINtxt.Text + "','" +
										  Maketxt.Text + "','" +
										  Modeltxt.Text + "','" +
										  Colourtxt.Text + "','" +
										  Typetxt.Text + "','" +
										  CurrentOdotxt.Text + "','" +
										  YrManutxt.Text + "','" +
										  RegoNotxt.Text + "','" +
										  RegoExtxt.Text + "','" +
										  DailyRatetxt.Text + "','" +
										  HourlyRatetxt.Text + "','" +
										  CumulativeObstxt.Text + "')";

				SqlConnection con = new SqlConnection(str_connection);
				con.Open();
				SqlCommand VehicleUpd = new SqlCommand(MyIns, con);
				VehicleUpd.ExecuteNonQuery();
				con.Close();
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
				string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
				string MyDelete = "Delete from [dbo].[Vehicle] where [VIN] = " + int_VIN ;
				SqlConnection con = new SqlConnection(str_connection);
				con.Open();
				SqlCommand VehicleUpd = new SqlCommand(MyDelete, con);
				VehicleUpd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Data deleted successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
				string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
				string MyUpd = "Update [dbo].[Vehicle] " +
							   "set [CurrentOdo] = " + CurrentOdotxt.Text +
							   "where [VIN] = " + int_VIN + ";";

				SqlConnection con = new SqlConnection(str_connection);
				con.Open();
				SqlCommand VehicleUpd = new SqlCommand(MyUpd, con);
				VehicleUpd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Save Complete!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BindGrid();

			}
			catch (Exception ex)
			{

				MessageBox.Show("There was a problem loading data from the database - plz call 95957777! :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Opening Customer Form
		private void CustBtn_Click(object sender, EventArgs e)
		{
			Form Form1 = new Vehicle();
			Form1.Show();
		}

		// Opening Booking Form
		private void Bkgbtn_Click(object sender, EventArgs e)
		{
			Form Bookingfrm = new BookingForm();
			Bookingfrm.Show();
		}

		private void UpdateSRbtn_Click(object sender, EventArgs e)
		{
			Form ServiceRecordfrm = new ServiceRecord();
			ServiceRecordfrm.Show();

		}

		
	}
}
