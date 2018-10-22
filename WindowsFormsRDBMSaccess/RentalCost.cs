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
    public partial class RentalCost : Form
    {
        public RentalCost()
        {
            InitializeComponent();
        }

        private void RentalCost_Load(object sender, EventArgs e)
        {
            try
            {

                string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
                /*string MySelect = "SELECT t1.[VIN],t1.[CustomerID],[BookingID],convert(varchar(10),[BookingDate],111) as 'BookingDate' " +
                                   " ,[BookingTime], convert(varchar(10),[ReturnDate],111) as 'ReturnDate',[ReturnTime] , " +
                                   "  [DailyRate],[HourlyRate],[Discount]" +*/
                string MySelect = "SELECT T1.VIN, T1.CustomerID," +
                                  "(CASE WHEN(DATEDIFF(hour, T1.BookingTime, T1.ReturnTime) * T2.HourlyRate) <= 0 THEN 0 ELSE(DATEDIFF(hour, T1.BookingTime, T1.ReturnTime) * T2.HourlyRate) END)"
                                  + "DATEDIFF(day,T1.BookingDate, T1.ReturnDate) * T2.DailyRate AS FinalCost,"
                                  + "T1.BookingID" +
                                   "FROM [CarRental].[dbo].[Booking] as t1 " + 
                                   "FROM [CarRental].[dbo].[Vehicle] as T2 ON T1.[VIN] = T2.[VIN] " +
                                   "order by t1.Bookingdate desc";
                SqlConnection con = new SqlConnection(str_connection);
                SqlDataAdapter ada = new SqlDataAdapter(MySelect, con);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                dataGridView1.ReadOnly = false;
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was a problem loading data from the database - plz call 95957777! :{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.CurrentCell = dataGridView1.Rows[currentRow].Cells[0];

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                CustIdtxt.Text = row.Cells["CustomerID"].Value.ToString();
                BkgIdtxt.Text = row.Cells["BookingID"].Value.ToString();
                VINtxt.Text = row.Cells["VIN"].Value.ToString();
                Dailyratetxt.Text = row.Cells["DailyRate"].Value.ToString();
                HrRatetxt.Text = row.Cells["HourlyRate"].Value.ToString();
                DistRatetxt.Text = row.Cells["Discount"].Value.ToString();
                
                
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
