
namespace PresentationLayer
{
    partial class yazarislemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yazarislemleri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_yazarsoyad = new System.Windows.Forms.TextBox();
            this.txt_yazarad = new System.Windows.Forms.TextBox();
            this.txt_yazarno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.btn_tumyazarlar = new System.Windows.Forms.Button();
            this.Yazargrid = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_turno = new System.Windows.Forms.TextBox();
            this.txt_turadi = new System.Windows.Forms.TextBox();
            this.turgrid = new System.Windows.Forms.DataGridView();
            this.btn_turekle = new System.Windows.Forms.Button();
            this.btn_tursil = new System.Windows.Forms.Button();
            this.btn_turguncelle = new System.Windows.Forms.Button();
            this.btn_tumTurler = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Yazargrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.txt_yazarsoyad);
            this.groupBox1.Controls.Add(this.txt_yazarad);
            this.groupBox1.Controls.Add(this.txt_yazarno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yazar İşlemleri";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(246, 134);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(110, 23);
            this.btn_guncelle.TabIndex = 2;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(246, 87);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(110, 23);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "Sil";
            this.toolTip1.SetToolTip(this.btn_sil, "Silmek için YazarNo girilmesi yeterli");
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(246, 37);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(110, 23);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            this.btn_ekle.MouseLeave += new System.EventHandler(this.btn_ekle_MouseLeave);
            this.btn_ekle.MouseHover += new System.EventHandler(this.btn_ekle_MouseHover);
            // 
            // txt_yazarsoyad
            // 
            this.txt_yazarsoyad.Location = new System.Drawing.Point(65, 131);
            this.txt_yazarsoyad.Name = "txt_yazarsoyad";
            this.txt_yazarsoyad.Size = new System.Drawing.Size(159, 20);
            this.txt_yazarsoyad.TabIndex = 1;
            // 
            // txt_yazarad
            // 
            this.txt_yazarad.Location = new System.Drawing.Point(65, 84);
            this.txt_yazarad.Name = "txt_yazarad";
            this.txt_yazarad.Size = new System.Drawing.Size(159, 20);
            this.txt_yazarad.TabIndex = 1;
            // 
            // txt_yazarno
            // 
            this.txt_yazarno.Location = new System.Drawing.Point(65, 39);
            this.txt_yazarno.Name = "txt_yazarno";
            this.txt_yazarno.Size = new System.Drawing.Size(159, 20);
            this.txt_yazarno.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "YazarSoyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "YazarAdı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "YazarNo";
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Location = new System.Drawing.Point(77, 376);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(225, 53);
            this.btn_anasayfa.TabIndex = 2;
            this.btn_anasayfa.Text = "Ana Sayfaya Don";
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // btn_tumyazarlar
            // 
            this.btn_tumyazarlar.Location = new System.Drawing.Point(553, 175);
            this.btn_tumyazarlar.Name = "btn_tumyazarlar";
            this.btn_tumyazarlar.Size = new System.Drawing.Size(237, 33);
            this.btn_tumyazarlar.TabIndex = 2;
            this.btn_tumyazarlar.Text = "Tüm Yazarları Göster";
            this.btn_tumyazarlar.UseVisualStyleBackColor = true;
            this.btn_tumyazarlar.Click += new System.EventHandler(this.btn_tumyazarlar_Click);
            // 
            // Yazargrid
            // 
            this.Yazargrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Yazargrid.Location = new System.Drawing.Point(395, 12);
            this.Yazargrid.Name = "Yazargrid";
            this.Yazargrid.Size = new System.Drawing.Size(550, 137);
            this.Yazargrid.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_turguncelle);
            this.groupBox2.Controls.Add(this.btn_tursil);
            this.groupBox2.Controls.Add(this.txt_turadi);
            this.groupBox2.Controls.Add(this.btn_turekle);
            this.groupBox2.Controls.Add(this.txt_turno);
            this.groupBox2.Location = new System.Drawing.Point(15, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 155);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tur İşlemleri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "TürNo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "YazarNo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tür Adı:";
            // 
            // txt_turno
            // 
            this.txt_turno.Location = new System.Drawing.Point(69, 43);
            this.txt_turno.Name = "txt_turno";
            this.txt_turno.Size = new System.Drawing.Size(119, 20);
            this.txt_turno.TabIndex = 1;
            // 
            // txt_turadi
            // 
            this.txt_turadi.Location = new System.Drawing.Point(69, 112);
            this.txt_turadi.Name = "txt_turadi";
            this.txt_turadi.Size = new System.Drawing.Size(119, 20);
            this.txt_turadi.TabIndex = 1;
            // 
            // turgrid
            // 
            this.turgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.turgrid.Location = new System.Drawing.Point(395, 227);
            this.turgrid.Name = "turgrid";
            this.turgrid.Size = new System.Drawing.Size(534, 143);
            this.turgrid.TabIndex = 3;
            // 
            // btn_turekle
            // 
            this.btn_turekle.Location = new System.Drawing.Point(223, 40);
            this.btn_turekle.Name = "btn_turekle";
            this.btn_turekle.Size = new System.Drawing.Size(110, 23);
            this.btn_turekle.TabIndex = 2;
            this.btn_turekle.Text = "Ekle";
            this.btn_turekle.UseVisualStyleBackColor = true;
            this.btn_turekle.Click += new System.EventHandler(this.btn_turekle_Click);
            this.btn_turekle.MouseLeave += new System.EventHandler(this.btn_turekle_MouseLeave);
            this.btn_turekle.MouseHover += new System.EventHandler(this.btn_turekle_MouseHover);
            // 
            // btn_tursil
            // 
            this.btn_tursil.Location = new System.Drawing.Point(223, 76);
            this.btn_tursil.Name = "btn_tursil";
            this.btn_tursil.Size = new System.Drawing.Size(110, 23);
            this.btn_tursil.TabIndex = 2;
            this.btn_tursil.Text = "Sil";
            this.btn_tursil.UseVisualStyleBackColor = true;
            this.btn_tursil.Click += new System.EventHandler(this.btn_tursil_Click);
            // 
            // btn_turguncelle
            // 
            this.btn_turguncelle.Location = new System.Drawing.Point(223, 110);
            this.btn_turguncelle.Name = "btn_turguncelle";
            this.btn_turguncelle.Size = new System.Drawing.Size(110, 23);
            this.btn_turguncelle.TabIndex = 2;
            this.btn_turguncelle.Text = "Güncelle";
            this.btn_turguncelle.UseVisualStyleBackColor = true;
            this.btn_turguncelle.Click += new System.EventHandler(this.btn_turguncelle_Click);
            // 
            // btn_tumTurler
            // 
            this.btn_tumTurler.Location = new System.Drawing.Point(557, 383);
            this.btn_tumTurler.Name = "btn_tumTurler";
            this.btn_tumTurler.Size = new System.Drawing.Size(233, 40);
            this.btn_tumTurler.TabIndex = 2;
            this.btn_tumTurler.Text = "Tum Türleri Göster";
            this.btn_tumTurler.UseVisualStyleBackColor = true;
            this.btn_tumTurler.Click += new System.EventHandler(this.btn_tumTurler_Click);
            // 
            // yazarislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(961, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.turgrid);
            this.Controls.Add(this.Yazargrid);
            this.Controls.Add(this.btn_tumTurler);
            this.Controls.Add(this.btn_tumyazarlar);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "yazarislemleri";
            this.Text = "Yazar İşlemleri";
            this.Load += new System.EventHandler(this.yazarislemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Yazargrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_yazarsoyad;
        private System.Windows.Forms.TextBox txt_yazarad;
        private System.Windows.Forms.TextBox txt_yazarno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.Button btn_tumyazarlar;
        private System.Windows.Forms.DataGridView Yazargrid;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_turguncelle;
        private System.Windows.Forms.Button btn_tursil;
        private System.Windows.Forms.TextBox txt_turadi;
        private System.Windows.Forms.Button btn_turekle;
        private System.Windows.Forms.TextBox txt_turno;
        private System.Windows.Forms.DataGridView turgrid;
        private System.Windows.Forms.Button btn_tumTurler;
    }
}