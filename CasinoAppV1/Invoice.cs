using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using static System.Net.Mime.MediaTypeNames;

namespace CasinoAppV1
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        MailMessage eposta = new MailMessage();

        public void clear()
        {
            tBoxSendMailAdress.Clear();
            tBoxSendMailSubject.Clear();
            rtBoxSendMailMessage.Clear();
        }

        public void sendMail()
        {
            if (IsValidEmail(tBoxSendMailAdress.Text))
            {
                tBoxSendMailAdress.Text = tBoxSendMailAdress.Text.ToLower();

                eposta.From = new MailAddress("diasoftotel@hotmail.com");
                eposta.To.Add(tBoxSendMailAdress.Text.ToString());
                eposta.Subject = tBoxSendMailSubject.Text.ToString();
                eposta.Body = rtBoxSendMailMessage.Text.ToString();
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential("diasoftotel@hotmail.com", "sifre*");
                smtp.Host = "smtp-mail.outlook.com"; //gmail host adresi = "smtp.gmail.com";,
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Send(eposta);

                MessageBox.Show("İşleminiz başarıyla tamamlandı.");
            }
            else
            {
                MessageBox.Show("Geçersiz email adresi!");
            }

        }
        private void btnSendMail_Click(object sender, EventArgs e)
        {
            sendMail();
            clear();
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void tBoxSendMailAdress_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
