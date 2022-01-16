
namespace PresentationLayer
{
    partial class Ogrenci_emanetislemeleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrenci_emanetislemeleri));
            this.btn_anasayfadon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.txt_ogrno = new System.Windows.Forms.TextBox();
            this.label_ogrencino = new System.Windows.Forms.Label();
            this.btn_tumkayitlarıgoster = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_anasayfadon
            // 
            this.btn_anasayfadon.Location = new System.Drawing.Point(437, 23);
            this.btn_anasayfadon.Name = "btn_anasayfadon";
            this.btn_anasayfadon.Size = new System.Drawing.Size(126, 39);
            this.btn_anasayfadon.TabIndex = 0;
            this.btn_anasayfadon.Text = "Ana Sayfaya Dön";
            this.btn_anasayfadon.UseVisualStyleBackColor = true;
            this.btn_anasayfadon.Click += new System.EventHandler(this.btn_anasayfadon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.btn_ara);
            this.groupBox1.Controls.Add(this.txt_ogrno);
            this.groupBox1.Controls.Add(this.label_ogrencino);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet ve İade Edilen Kitap";
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(238, 50);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 2;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // txt_ogrno
            // 
            this.txt_ogrno.Location = new System.Drawing.Point(83, 52);
            this.txt_ogrno.Name = "txt_ogrno";
            this.txt_ogrno.Size = new System.Drawing.Size(110, 20);
            this.txt_ogrno.TabIndex = 1;
            // 
            // label_ogrencino
            // 
            this.label_ogrencino.AutoSize = true;
            this.label_ogrencino.Location = new System.Drawing.Point(13, 55);
            this.label_ogrencino.Name = "label_ogrencino";
            this.label_ogrencino.Size = new System.Drawing.Size(64, 13);
            this.label_ogrencino.TabIndex = 0;
            this.label_ogrencino.Text = "Öğrenci No:";
            // 
            // btn_tumkayitlarıgoster
            // 
            this.btn_tumkayitlarıgoster.Location = new System.Drawing.Point(437, 77);
            this.btn_tumkayitlarıgoster.Name = "btn_tumkayitlarıgoster";
            this.btn_tumkayitlarıgoster.Size = new System.Drawing.Size(126, 40);
            this.btn_tumkayitlarıgoster.TabIndex = 2;
            this.btn_tumkayitlarıgoster.Text = "Tüm Kayıtları Göster";
            this.btn_tumkayitlarıgoster.UseVisualStyleBackColor = true;
            this.btn_tumkayitlarıgoster.Click += new System.EventHandler(this.btn_tumkayitlarıgoster_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 177);
            this.dataGridView1.TabIndex = 3;
            // 
            // Ogrenci_emanetislemeleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(585, 350);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_tumkayitlarıgoster);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_anasayfadon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ogrenci_emanetislemeleri";
            this.Text = "Öğrenci Emanet-İade Listesi";
            this.Load += new System.EventHandler(this.Ogrenci_emanetislemeleri_Load);
            this.Click += new System.EventHandler(this.Ogrenci_emanetislemeleri_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_anasayfadon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox txt_ogrno;
        private System.Windows.Forms.Label label_ogrencino;
        private System.Windows.Forms.Button btn_tumkayitlarıgoster;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}