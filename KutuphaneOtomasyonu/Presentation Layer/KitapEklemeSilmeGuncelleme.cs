using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BussinesLayer;

namespace PresentationLayer
{
    public partial class KitapEklemeSilmeGuncelleme : Form
    {
        public KitapEklemeSilmeGuncelleme()
        {
            InitializeComponent();
        }

        KitapBL ktpislem = new KitapBL();
        private void btn_ekle_Click(object sender, EventArgs e)//ekle butonuna basıldığında kitap eklemek  için gerekli busines katmanındaki method çalışıyor.
        {
            try
            {
                if (txt_kitapadi.Text.Length != 0  && txt_sayfasayısı.Text.Length != 0 && txt_turno.Text.Length != 0 && txt_yazarno.Text.Length != 0)//Alanların boş geçilmemesi için textbox denetimi yapılıyor.
                {
                    int deger = ktpislem.KitapEkle(txt_kitapadi.Text, txt_sayfasayısı.Text, txt_turno.Text, txt_yazarno.Text);
                    tumkayitlar();
                }
                else
                {
                    MessageBox.Show("Tüm alanları doldurunuz.");

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        void tumkayitlar()
        {
            List<KitapNesne> kitap = ktpislem2.KitapGoster();
            dataGridView1.DataSource = kitap;
        }
        KitapBL ktpislem2 = new KitapBL();
        private void btn_tumkayitlar_Click(object sender, EventArgs e)//basıldığında veri tabanından tüm kayıtlar datagride çekiliyor
        {
            tumkayitlar();
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_kitapnotekilarama.Text.Length != 0)//textbox değer kontrolü yapılıyor.
                {
                    List<KitapNesne> ktp2 = ktpislem2.KitapGoster(txt_kitapnotekilarama.Text);
                    dataGridView1.DataSource = ktp2;
                }
                else
                {
                    MessageBox.Show("Gerekli Alanı Doldurunuz.");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        KitapBL ktpislem3 = new KitapBL();


        private void btn_sil_Click(object sender, EventArgs e)//basıldığı zaman kitap silme methoduna yönlendiriliyor.
        {
            try
            {
                if (txt_kitapno.Text.Length != 0)//textboxtaki değer kontrolü yepılıyor .
                {
                    int deger = ktpislem3.KitapSil(int.Parse(txt_kitapno.Text));
                    tumkayitlar();
                }
                else
                {
                    MessageBox.Show("Kitap Numarasını yazınız.");

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        KitapBL ktpislem4 = new KitapBL();
        private void btn_guncelle_Click(object sender, EventArgs e)//basıldığı zaman kitap silme methoduna yönlendiriliyor.
        {
            try
            {
                if (txt_kitapadi.Text.Length != 0 && txt_kitapno.Text.Length != 0  && txt_sayfasayısı.Text.Length != 0 && txt_turno.Text.Length != 0 && txt_yazarno.Text.Length != 0)
                {
                    //textbox değer kontrolleri yapılıyor.
                    int deger = ktpislem4.KitapGuncelle(int.Parse(txt_kitapno.Text),txt_kitapadi.Text, txt_sayfasayısı.Text, txt_turno.Text, txt_yazarno.Text);
                    tumkayitlar();
                }
                else
                {
                    MessageBox.Show("Tüm Alanları Doldurunuz.");

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_ekle_MouseHover(object sender, EventArgs e)//ekle butonuna mouse geldiğinde çalışır
        {
            txt_kitapno.Enabled = false;
            txt_kitapno.Text = "Kitap eklerken kitapno girmeyiniz.";
        }

        private void btn_ekle_MouseLeave(object sender, EventArgs e)//ekle butonundan mouse ayrıldığında çalışır
        {
            txt_kitapno.Enabled = true;
            txt_kitapno.Text = "";
        }

        private void btn_anasayfayadon_Click(object sender, EventArgs e)//ana sayfaya dön butonuna basınca AnaSayfa clasından yeni nesne oluşturulur.
        {
            AnaSayfa yenisayfa = new AnaSayfa();
            this.Hide();
            yenisayfa.Show();
        }
        #region yanlıslık
        private void KitapEklemeSilmeGuncelleme_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
