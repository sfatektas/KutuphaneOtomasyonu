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

namespace PresentationLayer
{
    public partial class Ekle_Sil_Guncelle : Form
    {
        public Ekle_Sil_Guncelle()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)//datgridi temizlemek için kullanılan method
        {
            Ogrencilistesi.DataSource = null;
        }

        OgrenciBL islem = new OgrenciBL();

        public void ogrencigoster()//Tüm Öğrencileri getiren method
        {
            List<OgrenciNesne> ogrenciler = islem.OgrenciGoster();

            Ogrencilistesi.DataSource = ogrenciler;
        }

        private void btn_tumunugoster_Click(object sender, EventArgs e)//Tüm Öğrencileri getiren methodu kullanıyoruz
        {
            ogrencigoster();
        }
        OgrenciBL islem_2 = new OgrenciBL();
        private void btn_ara_Click(object sender, EventArgs e)//Öğrencileri aramak için yapılan ara methodu
        {
            List<OgrenciNesne> ogrenciler1 = islem_2.OgrenciGoster(int.Parse(txt_ogrencino.Text));
            Ogrencilistesi.DataSource = ogrenciler1;
        }
        OgrenciBL islem_3 = new OgrenciBL();
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (ogrnobolum.Text.Length!=0 && ogradbolum.Text.Length!= 0 && ogrsoyadbolum.Text.Length!=0 && dogumtarihbolum.Text.Length!=0 && ogrcinsiyet.SelectedItem.ToString().Length!=0 && BolumBolum.Text.Length!= 0)
            {//kullanıcı girişlerini kontrol amaçlar kullanıcının boş değer göndermesini engeller

                int deger = islem_3.OgrenciEkle(
                    int.Parse(ogrnobolum.Text),
                    ogradbolum.Text,
                    ogrsoyadbolum.Text,
                    dogumtarihbolum.Text,
                    ogrcinsiyet.SelectedItem.ToString(),
                    BolumBolum.Text
                    );
                ogrencigoster();
            }
            else
            {
                MessageBox.Show("Alanlar Boş Bırakılmamalıdır.");
            }
        }

        private void dogumtarihbolum_TextChanged(object sender, EventArgs e)
        {

        }
        OgrenciBL islem_4 = new OgrenciBL();
        private void btn_sil_Click(object sender, EventArgs e)//Öğrenci silme işlemi bu butonun clicklenmesiyle gerçekleşir.
        {
            try
            {
                if (ogrnobolum.Text.Length != 0)//kullanıcı girişlerini kontrol amaçlar kullanıcının boş değer göndermesini engeller
                {
                    islem_4.OgrenciSil(int.Parse(ogrnobolum.Text));
                    ogrencigoster();
                }
                else
                {
                    MessageBox.Show("Öğrenci Numarası Giriniz.");

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hata var");
              
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)//Öğrenci Güncelleme işlemi bu kısımın clicklenmesiyle oluşur.
        {
            if (ogrnobolum.Text.Length != 0 && ogradbolum.Text.Length != 0 && ogrsoyadbolum.Text.Length != 0 && dogumtarihbolum.Text.Length != 0 && ogrcinsiyet.SelectedItem.ToString().Length != 0 && BolumBolum.Text.Length != 0)
            {//kullanıcı girişlerini kontrol amaçlar kullanıcının boş değer göndermesini engeller

                int deger = islem_3.OgrenciGuncelle(int.Parse(ogrnobolum.Text), ogradbolum.Text, ogrsoyadbolum.Text, dogumtarihbolum.Text, ogrcinsiyet.Text, BolumBolum.Text);
            }
            else
            {
                MessageBox.Show("Alanlar Boş Bırakılmamalıdır.");
            }
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)//butona clicklenmesiyle anasayfaya yönlendirilir.
        {
            AnaSayfa yenisayfa = new AnaSayfa();
            this.Hide();
            yenisayfa.Show();
        }
        #region yanlışlık

        private void Ekle_Sil_Guncelle_Load(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
