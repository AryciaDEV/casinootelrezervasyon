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

namespace CasinoAppV1
{
    public partial class Rooms : Form
    {
        SqlConnection conn = new SqlConnection("Server=localhost; Database=appdatabase; Integrated Security=True");
        string connctionString = "Server=localhost; Database=appdatabase; Integrated Security=True";

        public Rooms()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable tbl = new DataTable();
            string vara, cumle;
            vara = tBoxOdaType_Search.Text;
            cumle = "Select * from app_table5 where roomtype like '%" + tBoxOdaType_Search.Text + "%'";
            SqlDataAdapter adptr = new SqlDataAdapter(cumle, conn);
            adptr.Fill(tbl);
            conn.Close();
            dataGridView1.DataSource = tbl;
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable tbl = new DataTable();
            string vara, cumle;
            vara = tBoxOdaType_Search.Text;
            cumle = "Select * from app_table5 where roomtype like '%" + tBoxOdaType_Search.Text + "%'";
            SqlDataAdapter adptr = new SqlDataAdapter(cumle, conn);
            adptr.Fill(tbl);
            conn.Close();
            dataGridView1.DataSource = tbl;
        }

        private void btnRoomCalculate_Click(object sender, EventArgs e)
        {
            int count = 0;
            string roomType = tBoxRoomName.Text; // Assuming tBoxRoomName is a TextBox control

            try
            {
                // Validate room type input (optional but recommended)
                if (string.IsNullOrEmpty(roomType))
                {
                    throw new ArgumentException("Please enter a room type.");
                }

                string sorgu = "SELECT COUNT(*) FROM app_table5 WHERE roomtype = @roomtype"; // Corrected query

                using (SqlConnection conn = new SqlConnection(connctionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sorgu, conn))
                    {
                        cmd.Parameters.AddWithValue("@roomtype", roomType);

                        count = (int)cmd.ExecuteScalar(); // Use int for clarity and potential overflow prevention
                    }
                }

                int totalRooms = Convert.ToInt32(tBoxRoomCount.Text); // Assuming tBoxRoomCount is a TextBox control
                int totalAvailable = totalRooms - count;
                lblTotalRoom.Text = totalAvailable.ToString();
            }
            catch (Exception ex)
            {
                // Handle potential exceptions gracefully (e.g., display user-friendly error message)
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
