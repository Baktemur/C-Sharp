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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici_adi = textBox1.Text;
            string sifre = textBox2.Text;

            if (textBox1.Text == "admin" && textBox2.Text == "123456")
            {
                Frm2 frm = new Frm2();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            
        }

     
    }
}
