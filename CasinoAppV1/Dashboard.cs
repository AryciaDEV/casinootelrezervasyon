using CasinoApp;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace CasinoAppV1
{
    public partial class Dashboard : Form
    {
        SqlConnection conn = new SqlConnection("Server=localhost; Database=appdatabase; Integrated Security=True");


        public Dashboard()
        {
            InitializeComponent();
            //Toplam Personel
            int count = 0;
            SqlCommand cmd = new SqlCommand("SELECT COUNT(username) FROM app_table2", conn);
            conn.Open();
            count = (Int32)cmd.ExecuteScalar();
            lblTotalPersonel.Text = count.ToString();

            //Toplam Misafir
            int count1 = 0;
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(name) FROM app_table5", conn);
            count1 = (Int32)cmd1.ExecuteScalar();
            lblTotalUser.Text = count1.ToString();
            lblTotalUser2.Text = count1.ToString();

            //Toplam Kadın
            int count2 = 0;
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(gender) FROM app_table5 where gender='kadın'", conn);
            count2 = (Int32)cmd2.ExecuteScalar();
            lblTotalUserWoman.Text = count2.ToString();

            //Toplam Erkek
            int count3 = 0;
            SqlCommand cmd3 = new SqlCommand("SELECT COUNT(gender) FROM app_table5 where gender='erkek'", conn);
            count3 = (Int32)cmd3.ExecuteScalar();
            lblTotalUserMan.Text = count3.ToString();

            //Toplam Para
            int count4 = 0;
            SqlCommand cmd4 = new SqlCommand("SELECT SUM(money) FROM app_table5", conn);
            count4 = (Int32)cmd4.ExecuteScalar();
            lblTotalMoney.Text = count4.ToString();
        }
    }
}
