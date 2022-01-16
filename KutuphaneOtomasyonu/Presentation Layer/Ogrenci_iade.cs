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
    public partial class Ogrenci_iade : Form
    {
        public Ogrenci_iade()
        {
            InitializeComponent();
        }
        //Gerekli BL sınıflarından yeni nesneler oluşturulur.
        OgrenciBL yenibl = new OgrenciBL();
        KitapBL kitapbl = new KitapBL();
        IslemBL islembl = new IslemBL();
        
        public void emanetiaderenk()//
        {
            double ceza;
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                string islemturu = dataGridView3.Rows[i].Cells[6].Value.ToString();//islemtürü değeri burda saklanır.
                if (islemturu == "iade")//datagriddeki güncel borç ve renklerin ayarı için bu method çalışır.
                {
                    dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView3.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                if (islemturu != "iade")//iade edilmediyse borc vs bu blokta hesaplanır.
                {
                    string t1, t2;
                    DateTime s1, s2;
                    t1 = DateTime.Now.ToShortDateString();
                    DateTime t3 = DateTime.Parse(dataGridView3.Rows[i].Cells[4].Value.ToString());
                    t2 = t3.ToShortDateString();
                    TimeSpan fark;
                    s1 = DateTime.Parse(t1);
                    s2 = DateTime.Parse(t2);
                    fark = s1.Subtract(s2);

                    //eğer iade tarihine 2 gün veya daha az kaldıysa o kişinin satırı sarı olarak görünür
                    if (Int32.Parse(fark.TotalDays.ToString()) > -2 && Int32.Parse(fark.TotalDays.ToString()) < 1)
                    {
                        dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        dataGridView3.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    //eğer son iade tarihi geçmişse satırın kırmızı görünmesi sağlanır.
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dataGridView3.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        ceza = int.Parse(fark.TotalDays.ToString()) * 1;
                        dataGridView3.Rows[i].Cells[5].Value = ceza.ToString();
                    }
                }
            }
        }
        private void btn_tumogrenciler_Click(object sender, EventArgs e)//basıldığında tüm öğrencileri datagride çeker.
        {
            try
            {
                List<OgrenciNesne> kayitgetir = yenibl.OgrenciGoster();
                dataGridView2.DataSource = kayitgetir;
            }
            catch (Exception)
            {

                throw;
            }
        }
        void tumkayitgetir()//tüm islem kayitlarini getiren method
        {
            List<IslemNesne> kayitgetir = islembl.islemiade();
            dataGridView3.DataSource = kayitgetir;
            emanetiaderenk();//getirilen verilerin renk ayarların yapılır .
        }
        private void btn_tumkayitlar_Click(object sender, EventArgs e)//basıldığında yukarıdaki method çalıştırılır.
        {
            try
            {
                tumkayitgetir();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_tumkitaplar_Click(object sender, EventArgs e)//basıldığında tüm kitap kayıtları getirilir.
        {
            try
            {
                List<KitapNesne> kayitgetir = kitapbl.KitapGoster();
                dataGridView1.DataSource = kayitgetir;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_ogrenciara_Click(object sender, EventArgs e)//basıldığında ilgili öğrenci arama fonksiyonu çalışır.
        {
            try
            {
                if (txtbx_ogrencino.Text.Length!=0)//textbox içindeki değer kontrolü yapılır.
                {
                    List<OgrenciNesne> kayitgetir = yenibl.OgrenciGoster(int.Parse(txtbx_ogrencino.Text));
                    dataGridView2.DataSource = kayitgetir;
                }
                else
                {
                    MessageBox.Show("Gerekli alanı doldurunuz");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_kitapara_Click(object sender, EventArgs e)//basıldığında ilgili kitap arama fonksiyonu çalışır.
        {
            try
            {
                if (txtbox_ktpno.Text.Length != 0)//textbox içindeki değer kontrolü yapılır.
                {
                    List<KitapNesne> kayitgetir = kitapbl.KitapGoster(int.Parse(txtbox_ktpno.Text));
                    dataGridView1.DataSource = kayitgetir;
                }
                else
                {
                    MessageBox.Show("Gerekli alanı doldurunuz");
                }
              
            }
            catch (Exception)
            {

                throw;
            }
        }
        IslemBL islembl2 = new IslemBL();
        private void btn_iade_Click(object sender, EventArgs e)//basıldığında iade fonksiyonu çalıştırılır.
        {
            try
            {
                if (txt_iadekitapno.Text.Length !=0 && txt_iadeogrencino.Text.Length !=0)//textbox içerisindeki değer kontrolleri yapılır.
                {
                    int iade = islembl2.iadeduzenleme(int.Parse(txt_iadeogrencino.Text), int.Parse(txt_iadekitapno.Text), "iade");
                    tumkayitgetir();
                }
                else
                {
                    MessageBox.Show("Gerekli alanları doldurunuz.");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)//Anasayfaya geri dönüş işlemi yapılır.
        {

            AnaSayfa yenisayfa = new AnaSayfa();
            this.Hide();
            yenisayfa.Show();
        }
        #region yanlıslık
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Ogrenci_iade_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
