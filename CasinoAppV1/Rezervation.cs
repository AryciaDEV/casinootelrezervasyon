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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using CasinoApp;


namespace CasinoAppV1
{
    public partial class Rezervation : Form
    {
        SqlConnection conn = new SqlConnection("Server=localhost; Database=appdatabase; Integrated Security=True");

        public Rezervation()
        {
            InitializeComponent();

        }

        public void ClearAdd()
        {
            tBoxName_User.Clear();
            tBoxLastName_User.Clear();
            tBoxPhone_User.Clear();
            tBoxNationality_User.Clear();
            tBoxMoney_User.Clear();
        }

        public void ClearUpdate()
        {
            tBoxName_Update.Clear();
            tBoxLastName_Update.Clear();
            tBoxPhone_Update.Clear();
            tBoxNationality_Update.Clear();
            tBoxMoney_Update.Clear();
        }

        private void btnUserAdd_User_Click(object sender, EventArgs e)
        {
            conn.Open();
            string kayit = "insert into app_table5 (name,lastname,phonenumber,gender,nationality,roomtype,totalday,enterday,totaluser,money) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
            SqlCommand ekle = new SqlCommand(kayit, conn);
            ekle.Parameters.AddWithValue("@p1", tBoxName_User.Text);
            ekle.Parameters.AddWithValue("@p2", tBoxLastName_User.Text);
            ekle.Parameters.AddWithValue("@p3", tBoxPhone_User.Text);
            ekle.Parameters.AddWithValue("@p4", cBoxGender_Add.Text);
            ekle.Parameters.AddWithValue("@p5", tBoxNationality_User.Text);
            ekle.Parameters.AddWithValue("@p6", cBoxRoomType_Add.Text);
            ekle.Parameters.AddWithValue("@p7", totalUser_Add.Value);
            ekle.Parameters.AddWithValue("@p8", dateTimePicker1.Value);
            ekle.Parameters.AddWithValue("@p9", totalUser_Add.Value);
            ekle.Parameters.AddWithValue("@p10", tBoxMoney_User.Text);

            MessageBox.Show("Misafir kaydı başarılı!");
            ClearAdd();

            ekle.ExecuteNonQuery();
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sorgu = "update app_table5 set name = '" + tBoxName_Update.Text + "' ,lastname ='" + tBoxLastName_Update.Text + "',phonenumber ='" + tBoxPhone_Update.Text + "',gender ='" + cBoxGender_Update.Text + "',na" +
                "tionality ='" + tBoxNationality_Update.Text + "',roomtype ='" + cBoxRoomType_Update.Text + "', totalday ='" + totalDay_Update.Text + "', totaluser ='" + totalUser_Update.Text + "', money ='" + tBoxMoney_Update.Text + "' where id =" + tBoxID_Update.Text + "";
            SqlCommand cmd = new SqlCommand(sorgu, conn);
            DialogResult secenek = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşleminiz başarıyla tamamlandı.");
                ClearUpdate();
                //this.InvokeOnClick(btnListe, EventArgs.Empty);
                conn.Close();
            }
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sorgu = "delete from app_table5 where id =" + tBoxID_Update.Text + "";
            SqlCommand cmd = new SqlCommand(sorgu, conn);
            DialogResult secenek = MessageBox.Show("Misafir silme işlemini onaylıyormusunuz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşleminiz başarıyla tamamlandı.");
            }
        }

        private void btnListe_User_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable tbl = new DataTable();
            string vara, cumle;
            vara = tBoxUsername_Search.Text;
            cumle = "Select * from app_table5 where name like '%" + tBoxUsername_Search.Text + "%'";
            SqlDataAdapter adptr = new SqlDataAdapter(cumle, conn);
            adptr.Fill(tbl);
            conn.Close();
            dataGridView1.DataSource = tbl;
        }

        private void btnSearch_User_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable tbl = new DataTable();
            string vara, cumle;
            vara = tBoxUsername_Search.Text;
            cumle = "Select * from app_table5 where name like '%" + tBoxUsername_Search.Text + "%'";
            SqlDataAdapter adptr = new SqlDataAdapter(cumle, conn);
            adptr.Fill(tbl);
            conn.Close();
            dataGridView1.DataSource = tbl;
        }
    }
}
