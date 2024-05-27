using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CasinoAppV1;
using System.Data.SqlClient;

namespace CasinoApp
{
    public partial class Login : Form
    {

        SqlConnection conn = new SqlConnection("Server=localhost; Database=appdatabase; Integrated Security=True");

        public static string dbUsername;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword_Log.Checked)
            {
                tboxPassword_Log.PasswordChar = '\0';
            }
            else
            {
                tboxPassword_Log.PasswordChar = '*';
            }
        }

        public void loginComplete()
        {
            conn.Open();
            string login = "SELECT * FROM app_table2 where username= '" + tboxUserID_Log.Text + "' and password= '" + tboxPassword_Log.Text + "'";
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand(login, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                dbUsername = tboxUserID_Log.Text;
                Home home = new Home();
                home.Show();
                this.Hide();

                conn.Close();
            }
            else
            {
                conn.Close();
                MessageBox.Show("Bilgileriniz hatalı veya eksik lütfen tekrar deneyiniz!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginComplete();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
