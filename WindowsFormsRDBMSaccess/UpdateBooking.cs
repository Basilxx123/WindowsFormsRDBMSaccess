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
    public partial class UpdateBooking : Form
    {
        public string CumObs;

        public UpdateBooking()
        {
            InitializeComponent();
        }

        private void UpdateBooking_Load(object sender, EventArgs e)
        {
            try
            {

                string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
                string MySelect = "SELECT t1.[VIN],[BookingID],convert(varchar(10),[BookingDate],111) as 'BookingDate' " +
                                   " ,[BookingTime], convert(varchar(10),[ReturnDate],111) as 'ReturnDate',[ReturnTime] , " +
                                   "  [OdoReadingOutbound],[OdoReadingInbound],[ObservationsOut],[ObservationsIn],[EmpID] " +
                                   " FROM [CarRental].[dbo].[Booking] as t1 " +
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.CurrentCell = dataGridView1.Rows[currentRow].Cells[0];

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                VINtxt.Text = row.Cells["VIN"].Value.ToString();
                BkgIdtxt.Text = row.Cells["BookingID"].Value.ToString();
                BkgDatetxt.Text = row.Cells["BookingDate"].Value.ToString();
                BkgTimetxt.Text = row.Cells["BookingTime"].Value.ToString();
                RetDatetxt.Text = row.Cells["ReturnDate"].Value.ToString();
                RetTimetxt.Text = row.Cells["ReturnTime"].Value.ToString();
                OdoOuttxt.Text = row.Cells["OdoReadingOutbound"].Value.ToString();
                OdoIntxt.Text = row.Cells["OdoReadingInbound"].Value.ToString();
                ObsOuttxt.Text = row.Cells["ObservationsOut"].Value.ToString();
                ObsIntxt.Text = row.Cells["ObservationsIn"].Value.ToString();
                Empidtxt.Text = row.Cells["EmpID"].Value.ToString();
            }
        }
       

        private void UpdateBkgbtn_Click(object sender, EventArgs e)
        {
            try
            {

                string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
                string sql = "SELECT [CumulativeObservations] FROM [CarRental].[dbo].[Vehicle] as t1 " +
                             "where t1.VIN = '" + VINtxt.Text + "'; ";

                using (var connection = new SqlConnection(str_connection))
                using (var command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        //check the reader has data:
                        if (reader.Read())
                        {
                            CumObs = reader.GetValue(0).ToString();
                        }
                    }
                }
                SqlConnection con2 = new SqlConnection(str_connection);
                con2.Open();
                string MyUpd = "Upate [CarRental].[dbo].[vehicle]" +
                               "set[CumulativeObservations] = '"  + CumObs + ObsIntxt.Text + "' where VIN = '" + VINtxt.Text + "'; ";
                SqlCommand VehUpd2 = new SqlCommand(MyUpd, con2);
                VehUpd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was a problem loading data from the database - plz call 95957777! :{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
