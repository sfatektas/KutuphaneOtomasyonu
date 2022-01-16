
namespace PresentationLayer
{
    partial class KitapEklemeSilmeGuncelleme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEklemeSilmeGuncelleme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_sayfasayısı = new System.Windows.Forms.TextBox();
            this.txt_turno = new System.Windows.Forms.TextBox();
            this.txt_yazarno = new System.Windows.Forms.TextBox();
            this.txt_kitapno = new System.Windows.Forms.TextBox();
            this.txt_kitapadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_kitapnotekilarama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_bul = new System.Windows.Forms.Button();
            this.btn_tumkayitlar = new System.Windows.Forms.Button();
            this.btn_anasayfayadon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.txt_sayfasayısı);
            this.groupBox1.Controls.Add(this.txt_turno);
            this.groupBox1.Controls.Add(this.txt_yazarno);
            this.groupBox1.Controls.Add(this.txt_kitapno);
            this.groupBox1.Controls.Add(this.txt_kitapadi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(278, 149);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(104, 32);
            this.btn_guncelle.TabIndex = 2;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(278, 94);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(104, 31);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "Sil";
            this.toolTip1.SetToolTip(this.btn_sil, "Silmek için sadece KitapNo yazın.");
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(278, 36);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(104, 29);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle";
            this.toolTip1.SetToolTip(this.btn_ekle, "Kitab eklemeden Önce Yazarı eklediğinizde emin olunuz.");
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            this.btn_ekle.MouseLeave += new System.EventHandler(this.btn_ekle_MouseLeave);
            this.btn_ekle.MouseHover += new System.EventHandler(this.btn_ekle_MouseHover);
            // 
            // txt_sayfasayısı
            // 
            this.txt_sayfasayısı.Location = new System.Drawing.Point(76, 161);
            this.txt_sayfasayısı.Name = "txt_sayfasayısı";
            this.txt_sayfasayısı.Size = new System.Drawing.Size(178, 20);
            this.txt_sayfasayısı.TabIndex = 1;
            // 
            // txt_turno
            // 
            this.txt_turno.Location = new System.Drawing.Point(76, 131);
            this.txt_turno.Name = "txt_turno";
            this.txt_turno.Size = new System.Drawing.Size(178, 20);
            this.txt_turno.TabIndex = 1;
            // 
            // txt_yazarno
            // 
            this.txt_yazarno.Location = new System.Drawing.Point(76, 100);
            this.txt_yazarno.Name = "txt_yazarno";
            this.txt_yazarno.Size = new System.Drawing.Size(178, 20);
            this.txt_yazarno.TabIndex = 1;
            // 
            // txt_kitapno
            // 
            this.txt_kitapno.Location = new System.Drawing.Point(76, 36);
            this.txt_kitapno.Name = "txt_kitapno";
            this.txt_kitapno.Size = new System.Drawing.Size(178, 20);
            this.txt_kitapno.TabIndex = 1;
            // 
            // txt_kitapadi
            // 
            this.txt_kitapadi.Location = new System.Drawing.Point(76, 65);
            this.txt_kitapadi.Name = "txt_kitapadi";
            this.txt_kitapadi.Size = new System.Drawing.Size(178, 20);
            this.txt_kitapadi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sayfa Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "TurNo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "YazarNo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "KitapNo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "KitapAdi:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.txt_kitapnotekilarama);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_bul);
            this.groupBox2.Location = new System.Drawing.Point(449, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 147);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tekil Arama";
            // 
            // txt_kitapnotekilarama
            // 
            this.txt_kitapnotekilarama.Location = new System.Drawing.Point(108, 28);
            this.txt_kitapnotekilarama.Name = "txt_kitapnotekilarama";
            this.txt_kitapnotekilarama.Size = new System.Drawing.Size(125, 20);
            this.txt_kitapnotekilarama.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Not: Kitabın adını doğru yazdığınıza emin olun.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kitap Adi:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_bul
            // 
            this.btn_bul.Location = new System.Drawing.Point(108, 92);
            this.btn_bul.Name = "btn_bul";
            this.btn_bul.Size = new System.Drawing.Size(104, 29);
            this.btn_bul.TabIndex = 2;
            this.btn_bul.Text = "Bul";
            this.btn_bul.UseVisualStyleBackColor = true;
            this.btn_bul.Click += new System.EventHandler(this.btn_bul_Click);
            // 
            // btn_tumkayitlar
            // 
            this.btn_tumkayitlar.Location = new System.Drawing.Point(449, 173);
            this.btn_tumkayitlar.Name = "btn_tumkayitlar";
            this.btn_tumkayitlar.Size = new System.Drawing.Size(125, 36);
            this.btn_tumkayitlar.TabIndex = 2;
            this.btn_tumkayitlar.Text = "Tüm Kayıtları Göster";
            this.btn_tumkayitlar.UseVisualStyleBackColor = true;
            this.btn_tumkayitlar.Click += new System.EventHandler(this.btn_tumkayitlar_Click);
            // 
            // btn_anasayfayadon
            // 
            this.btn_anasayfayadon.Location = new System.Drawing.Point(593, 173);
            this.btn_anasayfayadon.Name = "btn_anasayfayadon";
            this.btn_anasayfayadon.Size = new System.Drawing.Size(104, 36);
            this.btn_anasayfayadon.TabIndex = 2;
            this.btn_anasayfayadon.Text = "Ana Sayfaya Dön";
            this.btn_anasayfayadon.UseVisualStyleBackColor = true;
            this.btn_anasayfayadon.Click += new System.EventHandler(this.btn_anasayfayadon_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 180);
            this.dataGridView1.TabIndex = 3;
            // 
            // KitapEklemeSilmeGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(721, 447);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_anasayfayadon);
            this.Controls.Add(this.btn_tumkayitlar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitapEklemeSilmeGuncelleme";
            this.Text = "Kitap İşlemleri";
            this.Load += new System.EventHandler(this.KitapEklemeSilmeGuncelleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_tumkayitlar;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_sayfasayısı;
        private System.Windows.Forms.TextBox txt_turno;
        private System.Windows.Forms.TextBox txt_yazarno;
        private System.Windows.Forms.TextBox txt_kitapadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kitapnotekilarama;
        private System.Windows.Forms.Button btn_anasayfayadon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_bul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txt_kitapno;
        private System.Windows.Forms.Label label7;
    }
}