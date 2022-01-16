
namespace PresentationLayer
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.btn_Ogrenciislemleri = new System.Windows.Forms.Button();
            this.btn_kitapislemleri = new System.Windows.Forms.Button();
            this.btn_yazar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Ogrenciislemleri
            // 
            this.btn_Ogrenciislemleri.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ogrenciislemleri.Image")));
            this.btn_Ogrenciislemleri.Location = new System.Drawing.Point(65, 28);
            this.btn_Ogrenciislemleri.Name = "btn_Ogrenciislemleri";
            this.btn_Ogrenciislemleri.Size = new System.Drawing.Size(130, 125);
            this.btn_Ogrenciislemleri.TabIndex = 0;
            this.btn_Ogrenciislemleri.UseVisualStyleBackColor = true;
            this.btn_Ogrenciislemleri.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_kitapislemleri
            // 
            this.btn_kitapislemleri.Image = ((System.Drawing.Image)(resources.GetObject("btn_kitapislemleri.Image")));
            this.btn_kitapislemleri.Location = new System.Drawing.Point(288, 28);
            this.btn_kitapislemleri.Name = "btn_kitapislemleri";
            this.btn_kitapislemleri.Size = new System.Drawing.Size(135, 125);
            this.btn_kitapislemleri.TabIndex = 0;
            this.btn_kitapislemleri.UseVisualStyleBackColor = true;
            this.btn_kitapislemleri.Click += new System.EventHandler(this.btn_kitapislemleri_Click);
            // 
            // btn_yazar
            // 
            this.btn_yazar.Image = ((System.Drawing.Image)(resources.GetObject("btn_yazar.Image")));
            this.btn_yazar.Location = new System.Drawing.Point(182, 210);
            this.btn_yazar.Name = "btn_yazar";
            this.btn_yazar.Size = new System.Drawing.Size(136, 114);
            this.btn_yazar.TabIndex = 1;
            this.btn_yazar.UseVisualStyleBackColor = true;
            this.btn_yazar.Click += new System.EventHandler(this.btn_yazar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci İşlemleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(305, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap İşlemleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(195, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazar İşlemleri";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(537, 378);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_yazar);
            this.Controls.Add(this.btn_kitapislemleri);
            this.Controls.Add(this.btn_Ogrenciislemleri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaSayfa";
            this.Text = "Kütüphan Otomasyonu ";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ogrenciislemleri;
        private System.Windows.Forms.Button btn_kitapislemleri;
        private System.Windows.Forms.Button btn_yazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}