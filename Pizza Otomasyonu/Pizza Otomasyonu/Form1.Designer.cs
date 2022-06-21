namespace Pizza_Otomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmricecekadet = new System.Windows.Forms.NumericUpDown();
            this.nmrpizzaadet = new System.Windows.Forms.NumericUpDown();
            this.cmbicecek = new System.Windows.Forms.ComboBox();
            this.cmbpizzaboy = new System.Windows.Forms.ComboBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chket = new System.Windows.Forms.CheckBox();
            this.chkpeynir = new System.Windows.Forms.CheckBox();
            this.chkmantar = new System.Windows.Forms.CheckBox();
            this.chkzeytin = new System.Windows.Forms.CheckBox();
            this.chksosis = new System.Windows.Forms.CheckBox();
            this.chksucuk = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listucret = new System.Windows.Forms.ListBox();
            this.listicecekadet = new System.Windows.Forms.ListBox();
            this.listekstra = new System.Windows.Forms.ListBox();
            this.listpizzaboyadet = new System.Windows.Forms.ListBox();
            this.listadres = new System.Windows.Forms.ListBox();
            this.listtel = new System.Windows.Forms.ListBox();
            this.listadsoyad = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnsiparis = new System.Windows.Forms.Button();
            this.btntemiz = new System.Windows.Forms.Button();
            this.btnsiparistemizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmricecekadet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrpizzaadet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nmricecekadet);
            this.groupBox1.Controls.Add(this.nmrpizzaadet);
            this.groupBox1.Controls.Add(this.cmbicecek);
            this.groupBox1.Controls.Add(this.cmbpizzaboy);
            this.groupBox1.Controls.Add(this.txtadres);
            this.groupBox1.Controls.Add(this.txttel);
            this.groupBox1.Controls.Add(this.txtadsoyad);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Adres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "İçecek:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pizza Boyu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adı Soyadı:";
            // 
            // nmricecekadet
            // 
            this.nmricecekadet.Location = new System.Drawing.Point(359, 210);
            this.nmricecekadet.Name = "nmricecekadet";
            this.nmricecekadet.Size = new System.Drawing.Size(65, 22);
            this.nmricecekadet.TabIndex = 6;
            // 
            // nmrpizzaadet
            // 
            this.nmrpizzaadet.Location = new System.Drawing.Point(359, 154);
            this.nmrpizzaadet.Name = "nmrpizzaadet";
            this.nmrpizzaadet.Size = new System.Drawing.Size(65, 22);
            this.nmrpizzaadet.TabIndex = 5;
            // 
            // cmbicecek
            // 
            this.cmbicecek.FormattingEnabled = true;
            this.cmbicecek.Location = new System.Drawing.Point(101, 208);
            this.cmbicecek.Name = "cmbicecek";
            this.cmbicecek.Size = new System.Drawing.Size(195, 24);
            this.cmbicecek.TabIndex = 4;
            // 
            // cmbpizzaboy
            // 
            this.cmbpizzaboy.FormattingEnabled = true;
            this.cmbpizzaboy.Location = new System.Drawing.Point(101, 150);
            this.cmbpizzaboy.Name = "cmbpizzaboy";
            this.cmbpizzaboy.Size = new System.Drawing.Size(195, 24);
            this.cmbpizzaboy.TabIndex = 3;
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(450, 38);
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(462, 172);
            this.txtadres.TabIndex = 2;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(101, 94);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(195, 22);
            this.txttel.TabIndex = 1;
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(101, 38);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(195, 22);
            this.txtadsoyad.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chket);
            this.groupBox2.Controls.Add(this.chkpeynir);
            this.groupBox2.Controls.Add(this.chkmantar);
            this.groupBox2.Controls.Add(this.chkzeytin);
            this.groupBox2.Controls.Add(this.chksosis);
            this.groupBox2.Controls.Add(this.chksucuk);
            this.groupBox2.Location = new System.Drawing.Point(1102, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekstralar";
            // 
            // chket
            // 
            this.chket.AutoSize = true;
            this.chket.Location = new System.Drawing.Point(226, 136);
            this.chket.Name = "chket";
            this.chket.Size = new System.Drawing.Size(41, 20);
            this.chket.TabIndex = 5;
            this.chket.Text = "Et";
            this.chket.UseVisualStyleBackColor = true;
            // 
            // chkpeynir
            // 
            this.chkpeynir.AutoSize = true;
            this.chkpeynir.Location = new System.Drawing.Point(226, 90);
            this.chkpeynir.Name = "chkpeynir";
            this.chkpeynir.Size = new System.Drawing.Size(67, 20);
            this.chkpeynir.TabIndex = 4;
            this.chkpeynir.Text = "Peynir";
            this.chkpeynir.UseVisualStyleBackColor = true;
            // 
            // chkmantar
            // 
            this.chkmantar.AutoSize = true;
            this.chkmantar.Location = new System.Drawing.Point(226, 39);
            this.chkmantar.Name = "chkmantar";
            this.chkmantar.Size = new System.Drawing.Size(70, 20);
            this.chkmantar.TabIndex = 3;
            this.chkmantar.Text = "Mantar";
            this.chkmantar.UseVisualStyleBackColor = true;
            // 
            // chkzeytin
            // 
            this.chkzeytin.AutoSize = true;
            this.chkzeytin.Location = new System.Drawing.Point(72, 136);
            this.chkzeytin.Name = "chkzeytin";
            this.chkzeytin.Size = new System.Drawing.Size(65, 20);
            this.chkzeytin.TabIndex = 2;
            this.chkzeytin.Text = "Zeytin";
            this.chkzeytin.UseVisualStyleBackColor = true;
            // 
            // chksosis
            // 
            this.chksosis.AutoSize = true;
            this.chksosis.Location = new System.Drawing.Point(72, 90);
            this.chksosis.Name = "chksosis";
            this.chksosis.Size = new System.Drawing.Size(63, 20);
            this.chksosis.TabIndex = 1;
            this.chksosis.Text = "Sosis";
            this.chksosis.UseVisualStyleBackColor = true;
            // 
            // chksucuk
            // 
            this.chksucuk.AutoSize = true;
            this.chksucuk.Location = new System.Drawing.Point(72, 38);
            this.chksucuk.Name = "chksucuk";
            this.chksucuk.Size = new System.Drawing.Size(66, 20);
            this.chksucuk.TabIndex = 0;
            this.chksucuk.Text = "Sucuk";
            this.chksucuk.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listucret);
            this.groupBox3.Controls.Add(this.listicecekadet);
            this.groupBox3.Controls.Add(this.listekstra);
            this.groupBox3.Controls.Add(this.listpizzaboyadet);
            this.groupBox3.Controls.Add(this.listadres);
            this.groupBox3.Controls.Add(this.listtel);
            this.groupBox3.Controls.Add(this.listadsoyad);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(27, 402);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1515, 193);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // listucret
            // 
            this.listucret.FormattingEnabled = true;
            this.listucret.ItemHeight = 16;
            this.listucret.Location = new System.Drawing.Point(1108, 49);
            this.listucret.Name = "listucret";
            this.listucret.Size = new System.Drawing.Size(120, 132);
            this.listucret.TabIndex = 27;
            // 
            // listicecekadet
            // 
            this.listicecekadet.FormattingEnabled = true;
            this.listicecekadet.ItemHeight = 16;
            this.listicecekadet.Location = new System.Drawing.Point(925, 49);
            this.listicecekadet.Name = "listicecekadet";
            this.listicecekadet.Size = new System.Drawing.Size(120, 132);
            this.listicecekadet.TabIndex = 26;
            // 
            // listekstra
            // 
            this.listekstra.FormattingEnabled = true;
            this.listekstra.ItemHeight = 16;
            this.listekstra.Location = new System.Drawing.Point(742, 49);
            this.listekstra.Name = "listekstra";
            this.listekstra.Size = new System.Drawing.Size(120, 132);
            this.listekstra.TabIndex = 25;
            // 
            // listpizzaboyadet
            // 
            this.listpizzaboyadet.FormattingEnabled = true;
            this.listpizzaboyadet.ItemHeight = 16;
            this.listpizzaboyadet.Location = new System.Drawing.Point(559, 49);
            this.listpizzaboyadet.Name = "listpizzaboyadet";
            this.listpizzaboyadet.Size = new System.Drawing.Size(120, 132);
            this.listpizzaboyadet.TabIndex = 24;
            // 
            // listadres
            // 
            this.listadres.FormattingEnabled = true;
            this.listadres.ItemHeight = 16;
            this.listadres.Location = new System.Drawing.Point(376, 49);
            this.listadres.Name = "listadres";
            this.listadres.Size = new System.Drawing.Size(120, 132);
            this.listadres.TabIndex = 23;
            // 
            // listtel
            // 
            this.listtel.FormattingEnabled = true;
            this.listtel.ItemHeight = 16;
            this.listtel.Location = new System.Drawing.Point(193, 49);
            this.listtel.Name = "listtel";
            this.listtel.Size = new System.Drawing.Size(120, 132);
            this.listtel.TabIndex = 22;
            // 
            // listadsoyad
            // 
            this.listadsoyad.FormattingEnabled = true;
            this.listadsoyad.ItemHeight = 16;
            this.listadsoyad.Location = new System.Drawing.Point(10, 49);
            this.listadsoyad.Name = "listadsoyad";
            this.listadsoyad.Size = new System.Drawing.Size(120, 132);
            this.listadsoyad.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1105, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Ücret";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(922, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "İçecek ve Adet";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(739, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Ekstralar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(556, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Pizza Boy ve Adet";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(373, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Adres";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(190, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ad Soyad";
            // 
            // btnsiparis
            // 
            this.btnsiparis.Location = new System.Drawing.Point(1225, 259);
            this.btnsiparis.Name = "btnsiparis";
            this.btnsiparis.Size = new System.Drawing.Size(239, 95);
            this.btnsiparis.TabIndex = 2;
            this.btnsiparis.Text = "Sipariş Al";
            this.btnsiparis.UseVisualStyleBackColor = true;
            this.btnsiparis.Click += new System.EventHandler(this.btnsiparis_Click);
            // 
            // btntemiz
            // 
            this.btntemiz.Location = new System.Drawing.Point(1023, 259);
            this.btntemiz.Name = "btntemiz";
            this.btntemiz.Size = new System.Drawing.Size(84, 39);
            this.btntemiz.TabIndex = 3;
            this.btntemiz.Text = "Temizle";
            this.btntemiz.UseVisualStyleBackColor = true;
            this.btntemiz.Click += new System.EventHandler(this.btntemiz_Click);
            // 
            // btnsiparistemizle
            // 
            this.btnsiparistemizle.Location = new System.Drawing.Point(1102, 304);
            this.btnsiparistemizle.Name = "btnsiparistemizle";
            this.btnsiparistemizle.Size = new System.Drawing.Size(100, 50);
            this.btnsiparistemizle.TabIndex = 4;
            this.btnsiparistemizle.Text = "Siparişleri Temizle";
            this.btnsiparistemizle.UseVisualStyleBackColor = true;
            this.btnsiparistemizle.Click += new System.EventHandler(this.btnsiparistemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 631);
            this.Controls.Add(this.btnsiparistemizle);
            this.Controls.Add(this.btntemiz);
            this.Controls.Add(this.btnsiparis);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmricecekadet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrpizzaadet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmricecekadet;
        private System.Windows.Forms.NumericUpDown nmrpizzaadet;
        private System.Windows.Forms.ComboBox cmbicecek;
        private System.Windows.Forms.ComboBox cmbpizzaboy;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.CheckBox chket;
        private System.Windows.Forms.CheckBox chkpeynir;
        private System.Windows.Forms.CheckBox chkmantar;
        private System.Windows.Forms.CheckBox chkzeytin;
        private System.Windows.Forms.CheckBox chksosis;
        private System.Windows.Forms.CheckBox chksucuk;
        private System.Windows.Forms.ListBox listucret;
        private System.Windows.Forms.ListBox listicecekadet;
        private System.Windows.Forms.ListBox listekstra;
        private System.Windows.Forms.ListBox listpizzaboyadet;
        private System.Windows.Forms.ListBox listadres;
        private System.Windows.Forms.ListBox listtel;
        private System.Windows.Forms.ListBox listadsoyad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsiparis;
        private System.Windows.Forms.Button btntemiz;
        private System.Windows.Forms.Button btnsiparistemizle;
    }
}

