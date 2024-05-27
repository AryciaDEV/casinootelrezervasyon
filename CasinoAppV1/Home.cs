using CasinoApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoAppV1
{
    public partial class Home : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int niWdthEllipse,
            int nHeightEllipse
            );

        public Home()
        {
            InitializeComponent();
            lblUser_ID.Text = Login.dbUsername;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            pnlNavIndicator.Height = btnDashboard.Height;
            pnlNavIndicator.Top = btnDashboard.Top;
            pnlNavIndicator.Left = btnDashboard.Left;
            ButtonColorReset(btnDashboard);
            lblTabTitle.Text = "Gösterge Paneli";
            this.pnlContent.Controls.Clear();
            Dashboard FrmDashboard = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(FrmDashboard);
            FrmDashboard.Show();

            timer1.Start();
        }

        private void ButtonColorReset(Button button)
        {
            Color activeColor = Color.FromArgb(31, 27, 48);
            Color btnColor = Color.FromArgb(26, 23, 40);
            btnDashboard.BackColor = btnColor;
            btnRezervation.BackColor = btnColor;
            btnCurrent.BackColor = btnColor;
            btnCase.BackColor = btnColor;
            btnInvoice.BackColor = btnColor;
            btnRooms.BackColor = btnColor;
            btnUser.BackColor = btnColor;
            btnHelp.BackColor = btnColor;
            button.BackColor = activeColor;
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamayı kapatmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
            {
                Application.Exit();
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnDashboard.Height;
            pnlNavIndicator.Top = btnDashboard.Top;
            pnlNavIndicator.Left = btnDashboard.Left;
            ButtonColorReset(btnDashboard);

            lblTabTitle.Text = "Gösterge Paneli";
            this.pnlContent.Controls.Clear();
            Dashboard frmDashboard = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnRezervation_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnRezervation.Height;
            pnlNavIndicator.Top = btnRezervation.Top;
            pnlNavIndicator.Left = btnRezervation.Left;
            ButtonColorReset(btnRezervation);
            lblTabTitle.Text = "Rezervasyon";
            pnlContent.Controls.Clear();
            Rezervation frmRezervation = new Rezervation() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlContent.Controls.Add(frmRezervation);
            frmRezervation.Show();
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnCurrent.Height;
            pnlNavIndicator.Top = btnCurrent.Top;
            pnlNavIndicator.Left = btnCurrent.Left;
            ButtonColorReset(btnCurrent);
            lblTabTitle.Text = "Hesap";
            pnlContent.Controls.Clear();
            Current frmCurrent = new Current() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlContent.Controls.Add(frmCurrent);
            frmCurrent.Show();
        }

        private void btnCase_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnCase.Height;
            pnlNavIndicator.Top = btnCase.Top;
            pnlNavIndicator.Left = btnCase.Left;
            ButtonColorReset(btnCase);
            lblTabTitle.Text = "Kasa";
            pnlContent.Controls.Clear();
            Case frmCase = new Case() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlContent.Controls.Add(frmCase);
            frmCase.Show();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnInvoice.Height;
            pnlNavIndicator.Top = btnInvoice.Top;
            pnlNavIndicator.Left = btnInvoice.Left;
            ButtonColorReset(btnInvoice);
            lblTabTitle.Text = "E-posta";
            pnlContent.Controls.Clear();
            Invoice frmInvoice = new Invoice() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlContent.Controls.Add(frmInvoice);
            frmInvoice.Show();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnRooms.Height;
            pnlNavIndicator.Top = btnRooms.Top;
            pnlNavIndicator.Left = btnRooms.Left;
            ButtonColorReset(btnRooms);
            lblTabTitle.Text = "Oda Yönetimi";
            pnlContent.Controls.Clear();
            Rooms frmRooms = new Rooms() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlContent.Controls.Add(frmRooms);
            frmRooms.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnHelp.Height;
            pnlNavIndicator.Top = btnHelp.Top;
            pnlNavIndicator.Left = btnHelp.Left;
            ButtonColorReset(btnHelp);
            lblTabTitle.Text = "Yardım";
            pnlContent.Controls.Clear();
            Help frmHelp = new Help() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlContent.Controls.Add(frmHelp);
            frmHelp.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnUser.Height;
            pnlNavIndicator.Top = btnUser.Top;
            pnlNavIndicator.Left = btnUser.Left;
            ButtonColorReset(btnUser);
            lblTabTitle.Text = "Kullanıcılar";
            pnlContent.Controls.Clear();
            Users frmUsers = new Users() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlContent.Controls.Add(frmUsers);
            frmUsers.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }
    }
}
