using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtomasyonProje
{
    public partial class Frm2 : Form
    {
        public Frm2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 2000;           
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}
