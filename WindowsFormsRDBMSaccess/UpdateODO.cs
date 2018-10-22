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
    public partial class UpdateODO : Form
    {
        public UpdateODO()
        {
            InitializeComponent();
        }

        

        private void UpdateODO_Load(object sender, EventArgs e)
        {
            try
            {

                string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
                string MySelect = "SELECT [VIN],[Make],[Model],[Type],[Colour],[CurrentOdo],[YearofManuf],[RegoNo],[DailyRate],[HourlyRate] " +
                                   "FROM [CarRental].dbo.[Vehicle] " +
                                   "order by VIN";
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
                Odotxt.Text = row.Cells["CurrentOdo"].Value.ToString();
               
            }
        }
        

        private void ChkAvailbtn_Click_Click(object sender, EventArgs e)
        {
            try
            {
                string str_connection = "Data Source = DESKTOP-DE1TOR3; Initial Catalog = CarRental; Integrated Security = True";
                using (SqlConnection con = new SqlConnection(str_connection))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[UpdateOdo]",con))
                    {
                        cmd.Parameters.AddWithValue("@VIN", SqlDbType.VarChar).Value = VINtxt.Text;
                        cmd.Parameters.AddWithValue("@Odometer", SqlDbType.VarChar).Value = Odotxt.Text;

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Save Complete!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                 }
            }
            catch
            {
                MessageBox.Show("There was a problem!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
