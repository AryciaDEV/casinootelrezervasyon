using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoAppV1
{
    public partial class Case : Form
    {
        SqlConnection conn = new SqlConnection("Server=localhost; Database=appdatabase; Integrated Security=True");

        public Case()
        {
            InitializeComponent();

            //Toplam Para
            int count4;
            SqlCommand cmd4 = new SqlCommand("SELECT SUM(money) FROM app_table5", conn);
            conn.Open();
            count4 = (Int32)cmd4.ExecuteScalar();
            lblTotalMoney.Text = count4.ToString();
            conn.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string kayit = "insert into app_table5 (money) values (@p1)";
            SqlCommand ekle = new SqlCommand(kayit, conn);
            ekle.Parameters.AddWithValue("@p1", tBoxChashin.Text);

            MessageBox.Show("Para ekleme işlemi başarılı!");

            ekle.ExecuteNonQuery();
            conn.Close();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            int count4;
            SqlCommand cmd4 = new SqlCommand("SELECT SUM(money) FROM app_table5", conn);
            conn.Open();
            count4 = (Int32)cmd4.ExecuteScalar();
            int cout = Convert.ToInt32(tBoxChashout.Text);
            int tcout = count4 - cout;
            lblTotalMoney.Text = tcout.ToString();
            conn.Close();
        }
    }
}
