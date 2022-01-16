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
    public partial class Ogrenci_EmanetVer_Detay : Form
    {
        public Ogrenci_EmanetVer_Detay()
        {
            InitializeComponent();
        }

        OgrenciBL islem3 = new OgrenciBL();//Ogrencibl sınıfından yeni nesne üretilir.
        private void btn_ogrbul_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ogrencino.Text.Length != 0)//Textboxtaki Değer kontrolü yapılır.
                {
                    List<OgrenciNesne> ogrenciler1 = islem3.OgrenciGoster(int.Parse(txt_ogrencino.Text));
                    Ogrencigetirdatagrid.DataSource = ogrenciler1;

                }
                else
                {
                    MessageBox.Show("Öğrenci Numarasını Giriniz.");

                }
            }
            catch (Exception)
            {
            
            }
        }

        OgrenciBL islem4 = new OgrenciBL();
        private void btn_ogrenciGetir_Click(object sender, EventArgs e)//basıldığında tüm öğrencileri getirir.
        {
            List<OgrenciNesne> ogrenciler = islem4.OgrenciGoster();

            Ogrencigetirdatagrid.DataSource = ogrenciler;
        }

        KitapBL islem_kitap = new KitapBL();
        private void btn_kitap_bul_Click(object sender, EventArgs e)
        {
            if (txt_kitapadiveyano.Text.Length!=0)//textboxtaki değer kontrolü yapılır.
            {
                try//Eğer kitapnumarası ile arama yapılacaksa bu blok çalışır , eğer aynı fonksiyona string değer girilirse otomatik olarak catch bloğuna düşüceğinden catch bloğunda kitapadı ile arama yapılır.
                {
                    List<KitapNesne> kitaplar = islem_kitap.KitapGoster(int.Parse(txt_kitapadiveyano.Text));
                    KitapgetirDatagridwiew.DataSource = kitaplar;
                }
                catch (Exception)
                {
                    List<KitapNesne> kitaplar = islem_kitap.KitapGoster(txt_kitapadiveyano.Text);
                    KitapgetirDatagridwiew.DataSource = kitaplar;
                }
            }
            else
            {
                MessageBox.Show("Gerekli alanı doldurunuz.");
            }
           
        }
        KitapBL islem_kitap2 = new KitapBL();

        private void btn_tumkitaplar_Click(object sender, EventArgs e)//Basıldığında tüm kitapları datagrid'e listeler.
        {
            List<KitapNesne> kitaplar3 = islem_kitap2.KitapGoster();
            KitapgetirDatagridwiew.DataSource = kitaplar3;
            
        }
        string sontarih;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)//seçilen tarih textbox a atanır ve son teslim tarihi labela atanır.
        {
            txt_datetimepicker.Text = dateTimePicker1.Value.ToShortDateString();
            DateTime alistarih = DateTime.Parse(txt_datetimepicker.Text);
            sontarih = alistarih.AddDays(15).ToShortDateString();
            label_sontarih.Text = sontarih;
        }

        public void emanetiaderenk()//datagriddeki güncel borç ve renklerin ayarı için bu method çalışır.
        {
            double ceza;
            for (int i = 0; i < dataGridView3_emanet.Rows.Count; i++)
            {
                string islemturu = dataGridView3_emanet.Rows[i].Cells[6].Value.ToString();//islem türü değeri çekilir.
                if (islemturu == "iade")//eğer alınan kitap iade edildiyse bu blok çalışır
                {
                    dataGridView3_emanet.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView3_emanet.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                if (islemturu != "iade")//iade edilmediyse borc vs bu blokta hesaplanır.
                {
                    string t1, t2; 
                    DateTime s1, s2;
                    t1 = DateTime.Now.ToShortDateString();
                    DateTime t3 = DateTime.Parse(dataGridView3_emanet.Rows[i].Cells[4].Value.ToString());
                    t2 = t3.ToShortDateString();
                    TimeSpan fark;
                    s1 = DateTime.Parse(t1);
                    s2 = DateTime.Parse(t2);
                    fark = s1.Subtract(s2);

                    //eğer iade tarihine 2 gün veya daha az kaldıysa o kişinin satırı sarı olarak görünür
                    if (Int32.Parse(fark.TotalDays.ToString()) > -2 && Int32.Parse(fark.TotalDays.ToString()) < 1)
                    {
                        dataGridView3_emanet.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        dataGridView3_emanet.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    //eğer son iade tarihi geçmişse satırın kırmızı görünmesi sağlanır.
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        dataGridView3_emanet.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dataGridView3_emanet.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        ceza = int.Parse(fark.TotalDays.ToString()) * 1;
                        dataGridView3_emanet.Rows[i].Cells[5].Value = ceza.ToString();
                    }
                }
            }
        }
        IslemBL yenisilem = new IslemBL();
        private void btn_emanetVer_Click(object sender, EventArgs e)//emanet ver butonuna basıldığında bu blok çalışır.
        {
            if (txt_emanetogrencino.Text.Length!=0 && txt_kitapnoemanet.Text.Length!=0)//textboxtaki değer kontrolü yapılır.
            {
                if (yenisilem.OgrenciVarMıKontrol(int.Parse(txt_emanetogrencino.Text)) && yenisilem.KitapVarMıKontrol(int.Parse(txt_kitapnoemanet.Text)))
                    //!! Öğrencinin ve Kitabın kontrolü if bloğunun içiinde ayrı bir fonksiyonla yapılır.
                {
                    int deger = yenisilem.emanet_vermeislemi(int.Parse(txt_kitapnoemanet.Text), int.Parse(txt_emanetogrencino.Text), DateTime.Parse(txt_datetimepicker.Text), DateTime.Parse(sontarih), "Alım");
                    emanetlerigetir();
                    emanetiaderenk();
                    MessageBox.Show("verildi");
                }
                else
                {
                    MessageBox.Show("Öğrenci veya Kitap Bulunamadı");
                }
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurunuz.");

            }

        }
        void emanetlerigetir() //Tüm emanetleri işlemlerini datagrid'e getiren method.
        {
            List<IslemNesne> emanetler = yenisilem_2.islemiade();
            dataGridView3_emanet.DataSource = emanetler;
        }
        IslemBL yenisilem_2 = new IslemBL();
        private void btn_emanetgetir_Click(object sender, EventArgs e)//yukarıdaki method bu butona basıldığında çağırılır ve renk ayarı yapılır.
        {
            emanetlerigetir();
            emanetiaderenk();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)//basıldığında ana sayfaya dönüş yapılır.
        {

            AnaSayfa yenisayfa = new AnaSayfa();
            this.Hide();
            yenisayfa.Show();
        }

        #region yanlıslık

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ogrenci_EmanetVer_Detay_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
