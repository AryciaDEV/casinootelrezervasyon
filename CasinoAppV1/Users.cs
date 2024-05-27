using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using AMRConnector;

namespace CasinoAppV1
{
    public partial class Users : Form
    {
        SqlConnection conn = new SqlConnection("Server=localhost; Database=appdatabase; Integrated Security=True");
        DbConnector db;
        private string ID = "";

        public Users()
        {
            InitializeComponent();
            db = new DbConnector();


        }

        public void Clear()
        {
            tBoxUsername_Add.Clear();
            tboxPassword_Add.Clear();
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            if (tBoxUsername_Add.Text != "" && tboxPassword_Add.Text != "")
            {
                if (tBoxUsername_Add.TextLength >= 6)
                {
                    if (tboxPassword_Add.TextLength >= 6)
                    {
                        conn.Open();
                        string kayit = "insert into app_table2 (username,password) values (@p1,@p2)";
                        SqlCommand ekle = new SqlCommand(kayit, conn);
                        ekle.Parameters.AddWithValue("@p1", tBoxUsername_Add.Text);
                        ekle.Parameters.AddWithValue("@p2", tboxPassword_Add.Text);

                        MessageBox.Show("Başarıyla kayıt oldunuz!");
                        Clear();

                        ekle.ExecuteNonQuery();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Parolanız çok kısa lütfen tekrar deneyiniz!");
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen kullanıcı adı veya parolanıza daha fazla karakter ekleyiniz!");
                    Clear();
                }

            }
            else
            {
                MessageBox.Show("Lütfen tüm boşlukları eksiksiz şekilde doldurunuz!");
            }
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From app_table2", conn);

            DataSet ds = new DataSet();

            //Bağlantıyı açıyoruz
            conn.Open();

            //dataadaptere çektiğimiz verileri datasete aktarıyoruz 
            da.Fill(ds, "personel");

            //datasettteki verileri datagridviewde gösteriyoruz.
            dataGridView1.DataSource = ds.Tables[0];

            //Bağlantıyı kapatıyoruz.
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sorgu = "update app_table2 set username = '" + tBoxUsername_Update.Text + "' ,password ='" + tboxPassword_Update.Text + "' where id =" + tBoxID_Update.Text + "";
            SqlCommand cmd = new SqlCommand(sorgu, conn);
            DialogResult secenek = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşleminiz başarıyla tamamlandı.");
                //this.InvokeOnClick(btnListe, EventArgs.Empty);
                conn.Close();
            }
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sorgu = "delete from app_table2 where id =" + tBoxID_Update.Text + "";
            SqlCommand cmd = new SqlCommand(sorgu, conn);
            DialogResult secenek = MessageBox.Show("Kullanıcı silme işlemini onaylıyormusunuz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşleminiz başarıyla tamamlandı.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable tbl = new DataTable();
            string vara, cumle;
            vara = tBoxUsername_Search.Text;            
            cumle = "Select * from app_table2 where username like '%" + tBoxUsername_Search.Text + "%'";
            SqlDataAdapter adptr = new SqlDataAdapter(cumle, conn);                      
            adptr.Fill(tbl);
            conn.Close();
            dataGridView1.DataSource = tbl;
        }
    }
}