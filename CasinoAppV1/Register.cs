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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CasinoApp;

namespace CasinoAppV1
{

    public partial class Register : Form
    {

        SqlConnection conn = new SqlConnection("Server=localhost; Database=appdatabase; Integrated Security=True");

        public Register()
        {
            InitializeComponent();
        }

        public void registerComplete()
        {
            if (tboxUserID_Reg.Text != "" && tboxPassword_Reg.Text != "" && tboxAgainPassword_Reg.Text != "")
            {
                if (tboxUserID_Reg.TextLength >= 6)
                {
                    if (tboxPassword_Reg.Text == tboxAgainPassword_Reg.Text)
                    {
                        conn.Open();
                        string kayit = "insert into app_table2 (username,password) values (@p1,@p2)";
                        SqlCommand ekle = new SqlCommand(kayit, conn);
                        ekle.Parameters.AddWithValue("@p1", tboxUserID_Reg.Text);
                        ekle.Parameters.AddWithValue("@p2", tboxPassword_Reg.Text);

                        MessageBox.Show("Başarıyla kayıt oldunuz giriş ekranına yönlendiriliyorsunuz!");

                        ekle.ExecuteNonQuery();
                        conn.Close();

                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Parolanız uyuşmuyor lütfen tekrar deneyiniz!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen kullanıcı adı veya parolanıza daha fazla karakter ekleyiniz!");
                }

            }
            else
            {
                MessageBox.Show("Lütfen tüm boşlukları eksiksiz şekilde doldurunuz!");
            }

        }

        private void showPassword_Reg_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword_Reg.Checked)
            {
                tboxPassword_Reg.PasswordChar = '\0';
                tboxAgainPassword_Reg.PasswordChar = '\0';
            }
            else
            {
                tboxPassword_Reg.PasswordChar = '*';
                tboxAgainPassword_Reg.PasswordChar = '*';
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registerComplete();
        }

        private void btnSignAccount_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
