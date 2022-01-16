
namespace PresentationLayer
{
    partial class Ogrenci_EmanetVer_Detay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrenci_EmanetVer_Detay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.btn_emanetVer = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label_sontarih = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Sonteslim = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_datetimepicker = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_kitapnoemanet = new System.Windows.Forms.TextBox();
            this.txt_emanetogrencino = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_kitap_bul = new System.Windows.Forms.Button();
            this.txt_kitapadiveyano = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ogrbul = new System.Windows.Forms.Button();
            this.txt_ogrencino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Ogrencigetirdatagrid = new System.Windows.Forms.DataGridView();
            this.KitapgetirDatagridwiew = new System.Windows.Forms.DataGridView();
            this.dataGridView3_emanet = new System.Windows.Forms.DataGridView();
            this.btn_ogrenciGetir = new System.Windows.Forms.Button();
            this.btn_tumkitaplar = new System.Windows.Forms.Button();
            this.btn_emanetgetir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ogrencigetirdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitapgetirDatagridwiew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3_emanet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_anasayfa);
            this.groupBox1.Controls.Add(this.btn_emanetVer);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(0, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 698);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet Verme İşlemi";
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Location = new System.Drawing.Point(37, 655);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(197, 32);
            this.btn_anasayfa.TabIndex = 3;
            this.btn_anasayfa.Text = "Ana Sayfaya Dön";
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // btn_emanetVer
            // 
            this.btn_emanetVer.Location = new System.Drawing.Point(34, 607);
            this.btn_emanetVer.Name = "btn_emanetVer";
            this.btn_emanetVer.Size = new System.Drawing.Size(197, 32);
            this.btn_emanetVer.TabIndex = 3;
            this.btn_emanetVer.Text = "Emanet Ver";
            this.btn_emanetVer.UseVisualStyleBackColor = true;
            this.btn_emanetVer.Click += new System.EventHandler(this.btn_emanetVer_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.dateTimePicker1);
            this.groupBox5.Controls.Add(this.txt_datetimepicker);
            this.groupBox5.Location = new System.Drawing.Point(12, 285);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(237, 180);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Alınan Tarih";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label_sontarih);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.Sonteslim);
            this.groupBox6.Location = new System.Drawing.Point(6, 86);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(216, 77);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Emanet Edilecek Tarih";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // label_sontarih
            // 
            this.label_sontarih.AutoSize = true;
            this.label_sontarih.Location = new System.Drawing.Point(113, 43);
            this.label_sontarih.Name = "label_sontarih";
            this.label_sontarih.Size = new System.Drawing.Size(0, 13);
            this.label_sontarih.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Son Teslim Tarihi;";
            // 
            // Sonteslim
            // 
            this.Sonteslim.AutoSize = true;
            this.Sonteslim.Location = new System.Drawing.Point(117, 43);
            this.Sonteslim.Name = "Sonteslim";
            this.Sonteslim.Size = new System.Drawing.Size(0, 13);
            this.Sonteslim.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_datetimepicker
            // 
            this.txt_datetimepicker.Location = new System.Drawing.Point(9, 54);
            this.txt_datetimepicker.Name = "txt_datetimepicker";
            this.txt_datetimepicker.Size = new System.Drawing.Size(213, 20);
            this.txt_datetimepicker.TabIndex = 1;
            this.txt_datetimepicker.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox4.Controls.Add(this.txt_kitapnoemanet);
            this.groupBox4.Controls.Add(this.txt_emanetogrencino);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(12, 484);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 105);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Emanet Verilecek Kitap ve Öğrenci Bilgileri";
            // 
            // txt_kitapnoemanet
            // 
            this.txt_kitapnoemanet.Location = new System.Drawing.Point(78, 61);
            this.txt_kitapnoemanet.Name = "txt_kitapnoemanet";
            this.txt_kitapnoemanet.Size = new System.Drawing.Size(127, 20);
            this.txt_kitapnoemanet.TabIndex = 1;
            this.txt_kitapnoemanet.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_emanetogrencino
            // 
            this.txt_emanetogrencino.Location = new System.Drawing.Point(78, 28);
            this.txt_emanetogrencino.Name = "txt_emanetogrencino";
            this.txt_emanetogrencino.Size = new System.Drawing.Size(127, 20);
            this.txt_emanetogrencino.TabIndex = 1;
            this.txt_emanetogrencino.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kitap No:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ogrenci NO:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox3.Controls.Add(this.btn_kitap_bul);
            this.groupBox3.Controls.Add(this.txt_kitapadiveyano);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 101);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitap Ara";
            // 
            // btn_kitap_bul
            // 
            this.btn_kitap_bul.Location = new System.Drawing.Point(67, 55);
            this.btn_kitap_bul.Name = "btn_kitap_bul";
            this.btn_kitap_bul.Size = new System.Drawing.Size(75, 23);
            this.btn_kitap_bul.TabIndex = 3;
            this.btn_kitap_bul.Text = "Bul";
            this.btn_kitap_bul.UseVisualStyleBackColor = true;
            this.btn_kitap_bul.Click += new System.EventHandler(this.btn_kitap_bul_Click);
            // 
            // txt_kitapadiveyano
            // 
            this.txt_kitapadiveyano.Location = new System.Drawing.Point(126, 25);
            this.txt_kitapadiveyano.Name = "txt_kitapadiveyano";
            this.txt_kitapadiveyano.Size = new System.Drawing.Size(100, 20);
            this.txt_kitapadiveyano.TabIndex = 1;
            this.txt_kitapadiveyano.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Adi Veya Kitap No";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.btn_ogrbul);
            this.groupBox2.Controls.Add(this.txt_ogrencino);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Ara";
            // 
            // btn_ogrbul
            // 
            this.btn_ogrbul.Location = new System.Drawing.Point(67, 71);
            this.btn_ogrbul.Name = "btn_ogrbul";
            this.btn_ogrbul.Size = new System.Drawing.Size(75, 23);
            this.btn_ogrbul.TabIndex = 3;
            this.btn_ogrbul.Text = "Bul";
            this.btn_ogrbul.UseVisualStyleBackColor = true;
            this.btn_ogrbul.Click += new System.EventHandler(this.btn_ogrbul_Click);
            // 
            // txt_ogrencino
            // 
            this.txt_ogrencino.Location = new System.Drawing.Point(78, 31);
            this.txt_ogrencino.Name = "txt_ogrencino";
            this.txt_ogrencino.Size = new System.Drawing.Size(100, 20);
            this.txt_ogrencino.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kitaplar Tablosu";
            // 
            // Ogrencigetirdatagrid
            // 
            this.Ogrencigetirdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ogrencigetirdatagrid.Location = new System.Drawing.Point(284, 28);
            this.Ogrencigetirdatagrid.Name = "Ogrencigetirdatagrid";
            this.Ogrencigetirdatagrid.Size = new System.Drawing.Size(643, 135);
            this.Ogrencigetirdatagrid.TabIndex = 1;
            this.Ogrencigetirdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // KitapgetirDatagridwiew
            // 
            this.KitapgetirDatagridwiew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KitapgetirDatagridwiew.Location = new System.Drawing.Point(284, 254);
            this.KitapgetirDatagridwiew.Name = "KitapgetirDatagridwiew";
            this.KitapgetirDatagridwiew.Size = new System.Drawing.Size(643, 144);
            this.KitapgetirDatagridwiew.TabIndex = 1;
            this.KitapgetirDatagridwiew.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView3_emanet
            // 
            this.dataGridView3_emanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3_emanet.Location = new System.Drawing.Point(284, 475);
            this.dataGridView3_emanet.Name = "dataGridView3_emanet";
            this.dataGridView3_emanet.Size = new System.Drawing.Size(643, 142);
            this.dataGridView3_emanet.TabIndex = 1;
            this.dataGridView3_emanet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_ogrenciGetir
            // 
            this.btn_ogrenciGetir.Location = new System.Drawing.Point(343, 169);
            this.btn_ogrenciGetir.Name = "btn_ogrenciGetir";
            this.btn_ogrenciGetir.Size = new System.Drawing.Size(461, 42);
            this.btn_ogrenciGetir.TabIndex = 2;
            this.btn_ogrenciGetir.Text = "Tüm Öğrencileri Getir";
            this.btn_ogrenciGetir.UseVisualStyleBackColor = true;
            this.btn_ogrenciGetir.Click += new System.EventHandler(this.btn_ogrenciGetir_Click);
            // 
            // btn_tumkitaplar
            // 
            this.btn_tumkitaplar.Location = new System.Drawing.Point(343, 404);
            this.btn_tumkitaplar.Name = "btn_tumkitaplar";
            this.btn_tumkitaplar.Size = new System.Drawing.Size(461, 37);
            this.btn_tumkitaplar.TabIndex = 2;
            this.btn_tumkitaplar.Text = "Tüm Kitapları Getir";
            this.btn_tumkitaplar.UseVisualStyleBackColor = true;
            this.btn_tumkitaplar.Click += new System.EventHandler(this.btn_tumkitaplar_Click);
            // 
            // btn_emanetgetir
            // 
            this.btn_emanetgetir.Location = new System.Drawing.Point(352, 634);
            this.btn_emanetgetir.Name = "btn_emanetgetir";
            this.btn_emanetgetir.Size = new System.Drawing.Size(452, 38);
            this.btn_emanetgetir.TabIndex = 2;
            this.btn_emanetgetir.Text = "Tüm Emanet Verilen Öğrencileri Getir";
            this.btn_emanetgetir.UseVisualStyleBackColor = true;
            this.btn_emanetgetir.Click += new System.EventHandler(this.btn_emanetgetir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Öğrenciler Tablosu";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Emanet ve İade Tablosu";
            // 
            // Ogrenci_EmanetVer_Detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(994, 699);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_emanetgetir);
            this.Controls.Add(this.btn_tumkitaplar);
            this.Controls.Add(this.btn_ogrenciGetir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView3_emanet);
            this.Controls.Add(this.KitapgetirDatagridwiew);
            this.Controls.Add(this.Ogrencigetirdatagrid);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ogrenci_EmanetVer_Detay";
            this.Text = "Öğrenci Emanet İşlemi";
            this.Load += new System.EventHandler(this.Ogrenci_EmanetVer_Detay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ogrencigetirdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitapgetirDatagridwiew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3_emanet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Ogrencigetirdatagrid;
        private System.Windows.Forms.DataGridView KitapgetirDatagridwiew;
        private System.Windows.Forms.DataGridView dataGridView3_emanet;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_ogrencino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ogrenciGetir;
        private System.Windows.Forms.Button btn_tumkitaplar;
        private System.Windows.Forms.Button btn_emanetgetir;
        private System.Windows.Forms.TextBox txt_kitapadiveyano;
        private System.Windows.Forms.Button btn_kitap_bul;
        private System.Windows.Forms.Button btn_ogrbul;
        private System.Windows.Forms.Button btn_emanetVer;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Sonteslim;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_datetimepicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kitapnoemanet;
        private System.Windows.Forms.TextBox txt_emanetogrencino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_sontarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_anasayfa;
    }
}