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
	public partial class ServiceRecord : Form
	{
		//Function created to create and open Connection. Common Function 
		private SqlConnection OpenConnection()
		{
			string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
			SqlConnection con = new SqlConnection(str_connection);
			con.Open();
			return con;

		}

		//Function created to create and close Connection. Common Function 
		private void CloseConnection(SqlConnection con)
		{
			if (con.State == ConnectionState.Open)
				con.Close();
		}

		public ServiceRecord()
		{
			InitializeComponent();
		}

		private void ServiceRecord_Load(object sender, EventArgs e)
		{
			try
			{

				//string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
				string MySelect = "SELECT [RecID],[VIN],[CustomerID],[Date],[OdoReading],[Services Performed] " +
								   "FROM [CarRental].dbo.[ServiceRecord] " +
								   "order by VIN";

				//SqlConnection con = new SqlConnection(str_connection);
				SqlConnection con = OpenConnection();
				SqlDataAdapter ada = new SqlDataAdapter(MySelect, con);
				DataSet ds = new DataSet();
				ada.Fill(ds);			
				dataGridView1.ReadOnly = false;
				dataGridView1.DataSource = ds.Tables[0];
				dataGridView1.Visible = true;
				CloseConnection(con);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"There was a problem loading data from the database - plz call 95957777! :{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Addbtn_Click(object sender, EventArgs e)
		{
			try
			{
				//string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
				string MyIns = "Insert into [dbo].[ServiceRecord] " +
							   "VALUES ('" +
			  RecIdtxt.Text + "','" +
			  Vintxt.Text + "','" +
			  CustIdtxt.Text + "','" +
			  Datetxt.Text + "','" +
			  Odotxt.Text + "','" +
			  Servicetxt.Text + "')";

				//SqlConnection con = new SqlConnection(str_connection);
				SqlConnection con = OpenConnection();
				con.Open();
				SqlCommand ServicerdUpd = new SqlCommand(MyIns, con);
				ServicerdUpd.ExecuteNonQuery();
				//con.Close();
				CloseConnection(con);
				MessageBox.Show("Save Complete!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("There was a problem loading data from the database - plz call 95957777! :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int currentRow = dataGridView1.CurrentCell.RowIndex;
			dataGridView1.CurrentCell = dataGridView1.Rows[currentRow].Cells[0];


			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				RecIdtxt.Text = row.Cells["RecID"].Value.ToString();
				Vintxt.Text = row.Cells["VIN"].Value.ToString();
				CustIdtxt.Text = row.Cells["CustomerID"].Value.ToString();
				Datetxt.Text = row.Cells["Date"].Value.ToString();
				Odotxt.Text = row.Cells["OdoReading"].Value.ToString();
				Servicetxt.Text = row.Cells["Services Performed"].Value.ToString();
			}
		}

		private void Updatebtn_Click(object sender, EventArgs e)
		{
			try
			{
				//string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
				string MyUpd = "Update [dbo].[ServiceRecord] " +
							   "set [OdoReading] = '" + Odotxt.Text + "'" +
							   ", [Services Performed] = '" + Servicetxt.Text + "'" +
							   "where [RecID] = " + RecIdtxt.Text + ";";

				//SqlConnection con = new SqlConnection(str_connection);
				SqlConnection con = OpenConnection();
				con.Open();
				SqlCommand ServicerdUpd = new SqlCommand(MyUpd, con);
				ServicerdUpd.ExecuteNonQuery();
				//con.Close();
				CloseConnection(con);
				MessageBox.Show("Save Complete!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("There was a problem loading data from the database - plz call 95957777! :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}	

		private void Deletebtn_Click(object sender, EventArgs e)
		{
			try
			{
				//string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
				string MyDelete = "Delete from [dbo].[ServiceRecord] " +
								  "where [RecID] = " + RecIdtxt.Text + ";";
				//SqlConnection con = new SqlConnection(str_connection);
				SqlConnection con = OpenConnection();
				con.Open();
				SqlCommand ServicerdUpd = new SqlCommand(MyDelete, con);
				ServicerdUpd.ExecuteNonQuery();
				//con.Close();
				CloseConnection(con);
				MessageBox.Show("Data deleted successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{

				MessageBox.Show("There was a problem loading data from the database - plz call 95957777! :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void Closebtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
