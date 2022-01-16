
namespace PresentationLayer
{
    partial class Ogrenci_Emanet_Iade_islemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrenci_Emanet_Iade_islemleri));
            this.btn_emanet = new System.Windows.Forms.Button();
            this.btn_iadeet = new System.Windows.Forms.Button();
            this.btn_anasayfayadon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_emanet
            // 
            this.btn_emanet.Image = ((System.Drawing.Image)(resources.GetObject("btn_emanet.Image")));
            this.btn_emanet.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_emanet.Location = new System.Drawing.Point(41, 132);
            this.btn_emanet.Name = "btn_emanet";
            this.btn_emanet.Size = new System.Drawing.Size(136, 102);
            this.btn_emanet.TabIndex = 0;
            this.btn_emanet.UseVisualStyleBackColor = true;
            this.btn_emanet.Click += new System.EventHandler(this.btn_emanet_click);
            // 
            // btn_iadeet
            // 
            this.btn_iadeet.Image = ((System.Drawing.Image)(resources.GetObject("btn_iadeet.Image")));
            this.btn_iadeet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_iadeet.Location = new System.Drawing.Point(268, 132);
            this.btn_iadeet.Name = "btn_iadeet";
            this.btn_iadeet.Size = new System.Drawing.Size(133, 102);
            this.btn_iadeet.TabIndex = 0;
            this.btn_iadeet.UseVisualStyleBackColor = true;
            this.btn_iadeet.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_anasayfayadon
            // 
            this.btn_anasayfayadon.Image = ((System.Drawing.Image)(resources.GetObject("btn_anasayfayadon.Image")));
            this.btn_anasayfayadon.Location = new System.Drawing.Point(174, 12);
            this.btn_anasayfayadon.Name = "btn_anasayfayadon";
            this.btn_anasayfayadon.Size = new System.Drawing.Size(78, 73);
            this.btn_anasayfayadon.TabIndex = 1;
            this.btn_anasayfayadon.UseVisualStyleBackColor = true;
            this.btn_anasayfayadon.Click += new System.EventHandler(this.btn_anasayfayadon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ana Sayfaya Dön";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Emanet Ver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "İade Et";
            // 
            // Ogrenci_Emanet_Iade_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(448, 282);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_anasayfayadon);
            this.Controls.Add(this.btn_iadeet);
            this.Controls.Add(this.btn_emanet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ogrenci_Emanet_Iade_islemleri";
            this.Text = "Öğrenci Emanet Iade İslemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_emanet;
        private System.Windows.Forms.Button btn_iadeet;
        private System.Windows.Forms.Button btn_anasayfayadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}