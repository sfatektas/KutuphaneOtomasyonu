
namespace PresentationLayer
{
    partial class Ekle_Sil_Guncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ekle_Sil_Guncelle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ogrencino = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.ogrcinsiyet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BolumBolum = new System.Windows.Forms.TextBox();
            this.dogumtarihbolum = new System.Windows.Forms.TextBox();
            this.ogrsoyadbolum = new System.Windows.Forms.TextBox();
            this.ogradbolum = new System.Windows.Forms.TextBox();
            this.ogrnobolum = new System.Windows.Forms.TextBox();
            this.btn_tumunugoster = new System.Windows.Forms.Button();
            this.Ogrencilistesi = new System.Windows.Forms.DataGridView();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ogrencilistesi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.btn_ara);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_ogrencino);
            this.groupBox1.Location = new System.Drawing.Point(571, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tekli Arama";
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(84, 81);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 2;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci No";
            // 
            // txt_ogrencino
            // 
            this.txt_ogrencino.Location = new System.Drawing.Point(84, 23);
            this.txt_ogrencino.Name = "txt_ogrencino";
            this.txt_ogrencino.Size = new System.Drawing.Size(98, 20);
            this.txt_ogrencino.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.btn_temizle);
            this.groupBox2.Controls.Add(this.btn_guncelle);
            this.groupBox2.Controls.Add(this.btn_sil);
            this.groupBox2.Controls.Add(this.btn_ekle);
            this.groupBox2.Controls.Add(this.ogrcinsiyet);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BolumBolum);
            this.groupBox2.Controls.Add(this.dogumtarihbolum);
            this.groupBox2.Controls.Add(this.ogrsoyadbolum);
            this.groupBox2.Controls.Add(this.ogradbolum);
            this.groupBox2.Controls.Add(this.ogrnobolum);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 299);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Bilgilerii";
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(365, 226);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(106, 35);
            this.btn_temizle.TabIndex = 3;
            this.btn_temizle.Text = "Verileri Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(330, 142);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(173, 36);
            this.btn_guncelle.TabIndex = 3;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(330, 81);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(173, 34);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(330, 28);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(173, 34);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // ogrcinsiyet
            // 
            this.ogrcinsiyet.FormattingEnabled = true;
            this.ogrcinsiyet.Items.AddRange(new object[] {
            "Kız",
            "Erkek"});
            this.ogrcinsiyet.Location = new System.Drawing.Point(118, 245);
            this.ogrcinsiyet.Name = "ogrcinsiyet";
            this.ogrcinsiyet.Size = new System.Drawing.Size(121, 21);
            this.ogrcinsiyet.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Doğum Tarihi";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bolum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Öğrenci Soyadi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Öğrenci Adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci NO:";
            // 
            // BolumBolum
            // 
            this.BolumBolum.Location = new System.Drawing.Point(118, 201);
            this.BolumBolum.Name = "BolumBolum";
            this.BolumBolum.Size = new System.Drawing.Size(118, 20);
            this.BolumBolum.TabIndex = 0;
            this.BolumBolum.TextChanged += new System.EventHandler(this.dogumtarihbolum_TextChanged);
            // 
            // dogumtarihbolum
            // 
            this.dogumtarihbolum.Location = new System.Drawing.Point(118, 158);
            this.dogumtarihbolum.Name = "dogumtarihbolum";
            this.dogumtarihbolum.Size = new System.Drawing.Size(118, 20);
            this.dogumtarihbolum.TabIndex = 0;
            this.dogumtarihbolum.TextChanged += new System.EventHandler(this.dogumtarihbolum_TextChanged);
            // 
            // ogrsoyadbolum
            // 
            this.ogrsoyadbolum.Location = new System.Drawing.Point(118, 108);
            this.ogrsoyadbolum.Name = "ogrsoyadbolum";
            this.ogrsoyadbolum.Size = new System.Drawing.Size(98, 20);
            this.ogrsoyadbolum.TabIndex = 0;
            // 
            // ogradbolum
            // 
            this.ogradbolum.Location = new System.Drawing.Point(118, 66);
            this.ogradbolum.Name = "ogradbolum";
            this.ogradbolum.Size = new System.Drawing.Size(98, 20);
            this.ogradbolum.TabIndex = 0;
            // 
            // ogrnobolum
            // 
            this.ogrnobolum.Location = new System.Drawing.Point(118, 25);
            this.ogrnobolum.Name = "ogrnobolum";
            this.ogrnobolum.Size = new System.Drawing.Size(98, 20);
            this.ogrnobolum.TabIndex = 0;
            // 
            // btn_tumunugoster
            // 
            this.btn_tumunugoster.Location = new System.Drawing.Point(590, 193);
            this.btn_tumunugoster.Name = "btn_tumunugoster";
            this.btn_tumunugoster.Size = new System.Drawing.Size(184, 34);
            this.btn_tumunugoster.TabIndex = 2;
            this.btn_tumunugoster.Text = "Tüm Kayıtları Getir";
            this.btn_tumunugoster.UseVisualStyleBackColor = true;
            this.btn_tumunugoster.Click += new System.EventHandler(this.btn_tumunugoster_Click);
            // 
            // Ogrencilistesi
            // 
            this.Ogrencilistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ogrencilistesi.Location = new System.Drawing.Point(12, 327);
            this.Ogrencilistesi.Name = "Ogrencilistesi";
            this.Ogrencilistesi.Size = new System.Drawing.Size(640, 206);
            this.Ogrencilistesi.TabIndex = 3;
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Location = new System.Drawing.Point(590, 259);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(184, 39);
            this.btn_anasayfa.TabIndex = 4;
            this.btn_anasayfa.Text = "Ana Sayfaya Dön";
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // Ekle_Sil_Guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(818, 545);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.Ogrencilistesi);
            this.Controls.Add(this.btn_tumunugoster);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ekle_Sil_Guncelle";
            this.Text = "Öğrenci İşlemleri";
            this.Load += new System.EventHandler(this.Ekle_Sil_Guncelle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ogrencilistesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ogrencino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_tumunugoster;
        private System.Windows.Forms.TextBox ogrsoyadbolum;
        private System.Windows.Forms.TextBox ogradbolum;
        private System.Windows.Forms.TextBox ogrnobolum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dogumtarihbolum;
        private System.Windows.Forms.ComboBox ogrcinsiyet;
        private System.Windows.Forms.DataGridView Ogrencilistesi;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BolumBolum;
        private System.Windows.Forms.Button btn_anasayfa;
    }
}