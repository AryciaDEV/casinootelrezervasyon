using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoAppV1
{
    public partial class Current : Form
    {
        public Current()
        {
            InitializeComponent();
        }

        public void Clear1()
        {
            tBoxMulti1.Text = "0";
            tBoxMulti2.Text = "0";
            tBoxMulti3.Text = "0";
            tBoxMulti4.Text = "0";
            tBoxMulti5.Text = "0";

        }

        public void Clear2()
        {
            tBoxSingle1.Text = "0";
            tBoxSingle2.Text = "0";
        }

        private void btnMultiCalculate_Click(object sender, EventArgs e)
        {
            int m1 = Convert.ToInt32(this.tBoxMulti1.Text);
            int m2 = Convert.ToInt32(this.tBoxMulti2.Text);
            int m3 = Convert.ToInt32(this.tBoxMulti3.Text);
            int m4 = Convert.ToInt32(this.tBoxMulti4.Text);
            int m5 = Convert.ToInt32(this.tBoxMulti5.Text);

            lblMulti.Text = "Sonuç: " + (m1 + m2 + m3 + m4 + m5);

            Clear1();

        }

        private void btnSingleCalculate_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(this.tBoxSingle1.Text);
            int s2 = Convert.ToInt32(this.tBoxSingle2.Text);

            lblSingle.Text = "Sonuç: " + (s1 + s2);

            Clear2();
        }
    }
}
