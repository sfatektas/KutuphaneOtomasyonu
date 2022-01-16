
namespace PresentationLayer
{
    partial class Kitapİslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitapİslemleri));
            this.btn_kitapekle = new System.Windows.Forms.Button();
            this.btn_kitapemanetlistesi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kitapekle
            // 
            this.btn_kitapekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_kitapekle.Image")));
            this.btn_kitapekle.Location = new System.Drawing.Point(64, 128);
            this.btn_kitapekle.Name = "btn_kitapekle";
            this.btn_kitapekle.Size = new System.Drawing.Size(146, 128);
            this.btn_kitapekle.TabIndex = 0;
            this.btn_kitapekle.UseVisualStyleBackColor = true;
            this.btn_kitapekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_kitapemanetlistesi
            // 
            this.btn_kitapemanetlistesi.Image = ((System.Drawing.Image)(resources.GetObject("btn_kitapemanetlistesi.Image")));
            this.btn_kitapemanetlistesi.Location = new System.Drawing.Point(290, 128);
            this.btn_kitapemanetlistesi.Name = "btn_kitapemanetlistesi";
            this.btn_kitapemanetlistesi.Size = new System.Drawing.Size(152, 131);
            this.btn_kitapemanetlistesi.TabIndex = 0;
            this.btn_kitapemanetlistesi.UseVisualStyleBackColor = true;
            this.btn_kitapemanetlistesi.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Ekleme-Silme-Güncelleme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Emanet ve İade Listesi";
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btn_anasayfa.Image")));
            this.btn_anasayfa.Location = new System.Drawing.Point(207, 23);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(79, 66);
            this.btn_anasayfa.TabIndex = 2;
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // Kitapİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(514, 356);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kitapemanetlistesi);
            this.Controls.Add(this.btn_kitapekle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kitapİslemleri";
            this.Text = "Kitap İslemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kitapekle;
        private System.Windows.Forms.Button btn_kitapemanetlistesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_anasayfa;
    }
}