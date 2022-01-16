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
    public partial class Ogrenci_emanetislemeleri : Form
    {
        public Ogrenci_emanetislemeleri()
        {
            InitializeComponent();
        }

        private void btn_anasayfadon_Click(object sender, EventArgs e)//AnaSayfa formuna yönlendirilir.
        {

            AnaSayfa yenisayfa = new AnaSayfa();
            this.Hide();
            yenisayfa.Show();
        }
        public void renkayari()//datagriddeki verilerin borc ,renk ayarları bu fonksiyonla yazılır.
        {
            double borc;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string islemturu = dataGridView1.Rows[i].Cells[6].Value.ToString();////islem türü yazan değeri çekeriz.
                if (islemturu == "iade")//eğer alınan kitap iade edildiyse bu blok çalışır
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }

                if (islemturu != "iade")//iade edilmediyse borc vs bu blokta hesaplanır.
                {

                    string tarih1, tarih2;
                    DateTime s1, s2;
                    tarih1 = DateTime.Now.ToShortDateString();
                    DateTime t3 = DateTime.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    tarih2 = t3.ToShortDateString();
                    TimeSpan tarihfarkı;
                    s1 = DateTime.Parse(tarih1);
                    s2 = DateTime.Parse(tarih2);
                    tarihfarkı = s1.Subtract(s2);

                    //eğer iade tarihine 2 gün veya daha az kaldıysa o kişinin satırı sarı olarak görünür
                    if (Int32.Parse(tarihfarkı.TotalDays.ToString()) > -3 && Int32.Parse(tarihfarkı.TotalDays.ToString()) <1)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    //eğer son iade tarihi geçmişse satırın kırmızı görünmesi sağlanır ve güncel borç hesaplanırı..
                    if (Int32.Parse(tarihfarkı.TotalDays.ToString()) > 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;

                        borc = int.Parse(tarihfarkı.TotalDays.ToString())*1;
                        dataGridView1.Rows[i].Cells[5].Value = borc;
                    }
                }
            }
        }

        IslemBL iade_emanet = new IslemBL(); 
        private void btn_tumkayitlarıgoster_Click(object sender, EventArgs e)//yapılan işlemlerle ilgili Tüm kayıtlar bu fonksiyon ile yapılır
        {
            List<IslemNesne> ktp = iade_emanet.islemiade();
            dataGridView1.DataSource = ktp;
            renkayari();//datagride veriler listelendikten sonra renkayarlarının yapılması için bu fonksiyon çalıştırılır.

        }
         private void btn_ara_Click(object sender, EventArgs e)
        {
            if (txt_ogrno.Text.Length > 0)//textboxtaki değer kontrolü yapılır.
            {
                List<IslemNesne> arama = iade_emanet.ogrenciemanet_iadelistesi(int.Parse(txt_ogrno.Text));
                dataGridView1.DataSource = arama;
                renkayari();//datagride veriler listelendikten sonra renkayarlarının yapılması için bu fonksiyon çalıştırılır.
            }
            else 
            {
                MessageBox.Show("Deger Giriniz.");
            }
        }
        #region yanlışlık
        private void Ogrenci_emanetislemeleri_Click(object sender, EventArgs e)
        {

        }

        private void Ogrenci_emanetislemeleri_Load(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
