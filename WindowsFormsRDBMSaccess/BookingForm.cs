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
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
			try
			{
				string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
				string MySelect = "SELECT [BookingID] ,[CustomerID] ,[VIN] ,convert(varchar(10),[BookingDate],111) as 'Booking Date' ,[BookingTime] " +
								  " ,convert(varchar(10),[ReturnDate],111) as 'Return Date' ,[ReturnTime] ,[OdoReadingOutbound] ,[OdoReadingInbound] ,[Discount] " +
								  " ,[ObservationsOut] ,[ObservationsIn] ,[EmpID] " +
								   " FROM[CarRental].[dbo].[Booking] " +
								   " order by [BookingDate] asc; ";
				SqlConnection con = new SqlConnection(str_connection);
				SqlDataAdapter ada = new SqlDataAdapter(MySelect, con);
				DataSet ds = new DataSet();
				ada.Fill(ds);
				dataGridView1.ReadOnly = false;
				dataGridView1.DataSource = ds.Tables[0];
			}
			catch (Exception ex)
			{
				MessageBox.Show($"There was a problem loading data from the database - pls call 95557777! : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void VehicleAvail_btn_Click(object sender, EventArgs e)
        {
			dataGridView1.Visible = false;
			//dataGridView1.Rows.Clear();
			dataGridView1.DataSource = null;

			try
			{
				string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
				string MySelect = "SELECT 'Clashes--' as 'Clash Factor',t1.BookingID, t2.[VIN] ,[Make] ,[Model] ,[Type] ,convert(varchar(10),[BookingDate],111) as 'Booking Date',YearofManuf ,RegoNo ,[DailyRate] ,[HourlyRate] " +
								  "  FROM[CarRental].[dbo].[Booking] as t1, Vehicle as t2 " +
								  "  where t1.VIN = t2.VIN and " +
								  " ('" + Startdate_txt.Text + "' > t1.ReturnDate or '" + ReturnDate_txt.Text + "' < t1.BookingDate) " +
								  " and not BookingDate > convert(varchar(10), getdate(), 111) " +
								  " order by t2.VIN";

				SqlConnection con = new SqlConnection(str_connection);
				SqlDataAdapter ada2 = new SqlDataAdapter(MySelect, con);
				DataSet ds2 = new DataSet();
				ada2.Fill(ds2);
				dataGridView1.ReadOnly = false;
				dataGridView1.DataSource = ds2.Tables[0];
				dataGridView1.Visible = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"There was a problem loading data from the database - pls call 95557777! : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		string BkgID;
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int currentRow = dataGridView1.CurrentCell.RowIndex;
			dataGridView1.CurrentCell = dataGridView1.Rows[currentRow].Cells[0];
			BkgID = dataGridView1.CurrentCell.Value.ToString();
			//int_prodid = Int32.Parse(prodid);
			dataGridView1.Rows[currentRow].Cells["VIN"].ReadOnly = true;

			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				BookingDatetxt.Text = row.Cells["Booking Date"].Value.ToString();

			}
		}

		private void UpdateBkgBtn_Click(object sender, EventArgs e)
		{
			string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
			string MyUpd = "Update [CarRental].[dbo].[Booking] " +
						   " set [BookingDate] = convert(varchar(10),'" + BookingDatetxt.Text + "',111) " +
						   "  where [BookingID] = " + BkgID + ";";
			SqlConnection con = new SqlConnection(str_connection);
			con.Open();
			SqlCommand ProdUpd = new SqlCommand(MyUpd, con);
			ProdUpd.ExecuteNonQuery();
			con.Close();
		}
	}
}
