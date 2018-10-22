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

		private void Vehicle_Load(object sender, EventArgs e)
		{
			try
			{

				string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
				string MySelect = "SELECT [VIN],[Make],[Model],[Colour],[Type],[CurrentOdo],[RegoNo]," +
											"[DailyRate],[HourlyRate],[CumulativeObservations]" +
								   "FROM [CarRental].dbo.[Vehicle]" +
								   "order by Model;";
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

		int int_VIN;
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int currentRow = dataGridView1.CurrentCell.RowIndex;
			dataGridView1.CurrentCell = dataGridView1.Rows[currentRow].Cells[0];
			string custid = dataGridView1.CurrentCell.Value.ToString();
			int_VIN = Int32.Parse(custid);
			dataGridView1.Rows[currentRow].Cells["VIN"].ReadOnly = true;

			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				VINtxt.Text = row.Cells["VIN"].Value.ToString();
				Maketxt.Text = row.Cells["Make"].Value.ToString();
				Modeltxt.Text = row.Cells["Model"].Value.ToString();
				Colourtxt.Text = row.Cells["Colour"].Value.ToString();
				Typetxt.Text = row.Cells["Type"].Value.ToString();
				CurrentOdotxt.Text = row.Cells["CurrentOdo"].Value.ToString();
				RegoNotxt.Text = row.Cells["RegoNo"].Value.ToString();
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
										  RegoNotxt.Text + "','" +
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
				MessageBox.Show("There was a problem! : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DeleteVehbtn_Click(object sender, EventArgs e)
		{
			try
			{
				string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
				string MyDelete = "Delete from [dbo].[Vehicle] where [VIN] = '" + int_VIN + "'";
				SqlConnection con = new SqlConnection(str_connection);
				con.Open();
				SqlCommand VehicleUpd = new SqlCommand(MyDelete, con);
				VehicleUpd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Data deleted successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("There was a problem! : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdateVehbtn_Click(object sender, EventArgs e)
		{
			try
			{
				string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
				string MyUpd = "Update [dbo].[Vehicle] " +
							   "set [CurrentOdo] = " + CurrentOdotxt.Text +
							   "where [CustomerID] = " + int_VIN + ";";
				SqlConnection con = new SqlConnection(str_connection);
				con.Open();
				SqlCommand CustUpd = new SqlCommand(MyUpd, con);
				CustUpd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Save Complete!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("There was a problem! : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
