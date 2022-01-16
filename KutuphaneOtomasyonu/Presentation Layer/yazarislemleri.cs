using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesLayer;
using EntityLayer;
using PresentationLayer;

namespace PresentationLayer
{
    public partial class yazarislemleri : Form
    {
        public yazarislemleri()
        {
            InitializeComponent();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)//Ana sayfa formuna geri dönüş yapılır.
        {
            AnaSayfa yeni = new AnaSayfa();
            this.Hide();
            yeni.Show();
        }
        YazarBL islemyazar = new YazarBL();
        void tumyazarlar()//tüm yazarları listeleleme methodu .
        {
            List<YazarNesne> yazarlar = islemyazar.YazarGoster();
            Yazargrid.DataSource = yazarlar;
        }
        private void btn_tumyazarlar_Click(object sender, EventArgs e)//basıldığı zaman yukarıdaki fonksiyonu çalıştırır.
        {
            tumyazarlar();
        }

        private void btn_ekle_MouseHover(object sender, EventArgs e)//ekle butonuna hover olduğunda çalışacak olan kod
        {
            txt_yazarno.Enabled = false;
            txt_yazarno.Text = "Yazar No Eklemeyiniz.";
        }

        private void btn_ekle_MouseLeave(object sender, EventArgs e)//ekle butonuna leave olduğunda çalışacak olan kod m
        {
            txt_yazarno.Enabled = true;
            txt_yazarno.Text = "";

        }

        private void btn_turekle_MouseHover(object sender, EventArgs e)// turekle butonuna hover olduğunda çalışacak olan kod
        {
            txt_turno.Enabled = false;
            txt_turno.Text = "Tür No Eklemeyiniz.";
        }

        private void btn_turekle_MouseLeave(object sender, EventArgs e)// turekle butonundan leave oluduğunda çalışacak olan kod
        {
            txt_turno.Enabled = true;
            txt_turno.Text = "";
        }
        YazarBL islem2 = new YazarBL();
        private void btn_ekle_Click(object sender, EventArgs e)// yazarekle butonuna basıldığında çalışacak olan blok 
        {
            if (txt_yazarad.Text.Length!=0 && txt_yazarsoyad.Text.Length!=0)//textboxlardaki değer kontrolü yapılır.
            {
                int deger = islem2.YazarEkle(txt_yazarad.Text, txt_yazarsoyad.Text);
                tumyazarlar();
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurunuz.");

            }

        }
        YazarBL islem3 = new YazarBL();
        private void btn_sil_Click(object sender, EventArgs e)//yazarsil butonuna basıldığında çalışacak olan kod .
        {
            if (txt_yazarno.Text.Length != 0)//textboxun içindeki değer kontrolü yapılır.
            {
                int deger = islem3.YazarSil(int.Parse(txt_yazarno.Text));
                tumyazarlar();
            }
            else
            {
                MessageBox.Show("Yazar numarası alanını doldurunuz.");

            }
            
        }
        YazarBL islem4 = new YazarBL();
        private void btn_guncelle_Click(object sender, EventArgs e)//yazargüncelle butonuna basıldığında çalışacak olan kod.
        {
            if (txt_yazarad.Text.Length != 0 && txt_yazarsoyad.Text.Length != 0 && txt_yazarno.Text.Length!=0)//textboxun içindeki değer kontrolü yapılır.
            {
                int deger = islem4.YazarGuncelle(int.Parse(txt_yazarno.Text), txt_yazarad.Text, txt_yazarsoyad.Text);
                tumyazarlar();
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurunuz.");

            }
        }
        TurBL islem_ = new TurBL();
        void tumislemler()//tüm türleri gösteren method
        {
            List<TurNesne> turler = islem_.TurGoster();
            turgrid.DataSource = turler;
        }
     
        private void btn_turekle_Click(object sender, EventArgs e)//tur ekle butonuna basıldığında çalışan kod bloğu
        {
            if (txt_turadi.Text.Length != 0)//textboxun içindeki değer kontrolü yapılır.
            {
                int deger = islem_.TurEkle(txt_turadi.Text);
                tumislemler();
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurunuz.");

            }
        }
        TurBL islem_2 = new TurBL();
        private void btn_tursil_Click(object sender, EventArgs e)//tur sil butonuna basıldığında çalışan kod bloğu
        {
            if (txt_turno.Text.Length != 0)//textbox içindeki değer kontrolü yapılır.
            {
                int deger = islem_2.TurSil(int.Parse(txt_turno.Text));
                tumislemler();
            }
            else
            {
                MessageBox.Show("Turno alanını doldurunuz.");

            }
        }
        TurBL islem_3 = new TurBL();
        private void btn_turguncelle_Click(object sender, EventArgs e)//tur güncelle butonuna basıldığında çalışacak olan kod bloğu
        {
            if (txt_turno.Text.Length != 0 && txt_turadi.Text.Length!=0)//textboxun içindeki değer kontrolü yapılır.
            {
                int deger = islem_3.TurGuncelle(int.Parse(txt_turno.Text), txt_turadi.Text);
                tumislemler();
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurunuz.");

            }
        }

        private void btn_tumTurler_Click(object sender, EventArgs e)//basıldığında tüm islemleri getiren kod bloğu
        {
            tumislemler();
        }
        #region yanlışlık

        private void yazarislemleri_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
