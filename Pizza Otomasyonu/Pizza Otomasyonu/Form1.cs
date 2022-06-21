using System;
using System.Windows.Forms;

namespace Pizza_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbpizzaboy.Items.Add("Küçük");
            cmbpizzaboy.Items.Add("Orta");
            cmbpizzaboy.Items.Add("Büyük");
            cmbicecek.Items.Add("Ayran");
            cmbicecek.Items.Add("2,5 lt Coca Cola");
            cmbicecek.Items.Add("1 lt Pepsi");
        }

        private void btnsiparis_Click(object sender, EventArgs e)
        {
            //ücret ve ekstra adında değişkenler tanımlıyoruz.

            decimal ucret = 0;

            string ekstra = "";

            if (chket.Checked == true)
            {
                ekstra += "Et";
                ucret = 5;
            }
            else if (chkmantar.Checked == true)
            {
                ekstra += "" + "Mantar";
                ucret = 3;
            }
            else if (chkpeynir.Checked == true)
            {
                ekstra = "" + "Peynir";
                ucret = 2;
            }
            else if (chksosis.Checked == true)
            {
                ekstra = "" + "Sosis";
                ucret = 3;
            }
            else if (chksucuk.Checked == true)
            {
                ekstra = "" + "Sucuk";
                ucret = 3;
            }
            else if (chkzeytin.Checked == true)
            {
                ekstra = "" + "Zeytin";
                ucret = 2;

            }
            // pizzalar listesi
            if (cmbpizzaboy.Text == "Küçük")
            {
                ucret += nmrpizzaadet.Value * 15;
            }
            else if (cmbpizzaboy.Text == "Büyük")
            {
                ucret += nmrpizzaadet.Value * 25;
            }
            else if (cmbpizzaboy.Text == "Orta")
            {
                ucret += nmrpizzaadet.Value * 20;
            }
            // içecekler listesi
            if (cmbicecek.Text == "2,5 lt Coca Cola")
            {
                ucret += nmricecekadet.Value * 20;
            }
            else if (cmbicecek.Text == "1 lt Pepsi")
            {
                ucret += nmricecekadet.Value * 11;
            }
            else if (cmbicecek.Text == "Ayran")
            {
                ucret += nmricecekadet.Value * 5;
            }
            listadsoyad.Items.Add(txtadsoyad.Text);
            listadres.Items.Add(txtadres.Text);
            listtel.Items.Add(txttel.Text);
            listpizzaboyadet.Items.Add("Adet " + nmrpizzaadet.Value + " Boyut " + cmbpizzaboy.Text);
            listicecekadet.Items.Add("Adet " + nmricecekadet.Value + " İçecek " + cmbicecek.Text);
            listekstra.Items.Add(ekstra);
            listucret.Items.Add(ucret + " TL");
        }

        private void btntemiz_Click(object sender, EventArgs e)
        {
            // textboxlarımızı temizledik
            txtadsoyad.Text = "";
            txttel.Clear();
            txtadres.Text = null;
            // comboboxları temizledik

            cmbicecek.Text = "";
            cmbpizzaboy.Text = "";
            // numaratiğimizi sıfırladık
            nmricecekadet.Value = 0;
            nmrpizzaadet.Value = 0;

            //checkboxları temizledik
            chket.Checked = false;
            chkmantar.Checked = false;
            chkpeynir.Checked = false;
            chksosis.Checked = false;
            chksucuk.Checked = false;
            chkzeytin.Checked = false;

        }

        private void btnsiparistemizle_Click(object sender, EventArgs e)
        {
            // textboxlarımızı temizledik
            txtadsoyad.Text = "";
            txttel.Clear();
            txtadres.Text = null;
            // comboboxları temizledik

            cmbicecek.Text = "";
            cmbpizzaboy.Text = "";
            // numaratiğimizi sıfırladık
            nmricecekadet.Value = 0;
            nmrpizzaadet.Value = 0;

            //checkboxları temizledik
            chket.Checked = false;
            chkmantar.Checked = false;
            chkpeynir.Checked = false;
            chksosis.Checked = false;
            chksucuk.Checked = false;
            chkzeytin.Checked = false;
            // listelerimizi temizledik
            listadres.Items.Clear();
            listadsoyad.Items.Clear();
            listekstra.Items.Clear();
            listicecekadet.Items.Clear();
            listpizzaboyadet.Items.Clear();
            listtel.Items.Clear();
            listucret.Items.Clear();

        }
    }
}
