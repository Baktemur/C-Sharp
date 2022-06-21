using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace OtoGaleriProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source=" + Application.StartupPath + "\\otogaleri.accdb");

        private void Form1_Load(object sender, EventArgs e)
        {
            kayitlarilistele();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string marka = comboBox1.SelectedItem.ToString();
            if (marka == "Toyota")
            {
                string[] model = { "Auris", "Yaris", "Corolla" };
                comboBox2.Items.AddRange(model);
            }
            if (marka == "Honda")
            {
                string[] model = { "Civic", "Accord" };
                comboBox2.Items.AddRange(model);
            }
            if (marka == "Opel")
            {
                string[] model = { "Astra", "Vectra", "Corsa" };
                comboBox2.Items.AddRange(model);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void kayitlarilistele()
        {
            try
            {
                baglantim.Open();
                OleDbDataAdapter listele = new OleDbDataAdapter("select * from araclar", baglantim);
                DataSet dshafiza = new DataSet();
                listele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                baglantim.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message);
                baglantim.Close();
            }
        }
    }
}
