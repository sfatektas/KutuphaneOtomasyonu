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
    public partial class KitapEmanetİadeListesi : Form
    {
        public KitapEmanetİadeListesi()
        {
            InitializeComponent();
        }
        IslemBL yenisislem = new IslemBL();
        private void button2_Click(object sender, EventArgs e)//tüm kayıtları getir butonuna basıldığı zaman çalışacak olan kodlar
        {
           List<IslemNesne> emanets =  yenisislem.islemiade();
            dataGridView1.DataSource = emanets;
            emanetiaderenk();

        }

        private void KitapEmanetİadeListesi_Load(object sender, EventArgs e)
        {

        }
        IslemBL yenisislem2 = new IslemBL();
        private void btn_bul_Click(object sender, EventArgs e)//basıldığı zaman ilgili textboxun içindeki değeri ilgili methoda dahil eder
        {
            if (txt_kitapno.Text.Length != 0)//textboxtaki değer kontrolü yapılır.
            {
                List<IslemNesne> kayitgetir = yenisislem2.kayitlisteleme_sonedit(int.Parse(txt_kitapno.Text));
                dataGridView1.DataSource = kayitgetir;
                emanetiaderenk();
            }
            else
            {
                MessageBox.Show("Kitap No kısmını doldurunuz.");
            }

        }
        public void emanetiaderenk()//datagridlerdeki değerlerin borcunu , sarı-kırmızı-beyaz , renklerini vs göstermesi için kullanılır.
        {
            double ceza;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string islemturu = dataGridView1.Rows[i].Cells[6].Value.ToString();//islem türü yazan değeri çekeriz.
                if (islemturu == "iade")//eğer alınan kitap iade edildiyse bu blok çalışır
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                if (islemturu != "iade")//iade edilmediyse borc vs bu blokta hesaplanır.
                {
                    string t1, t2;
                    DateTime s1, s2;
                    t1 = DateTime.Now.ToShortDateString();
                    DateTime t3 = DateTime.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    t2 = t3.ToShortDateString();
                    TimeSpan fark;
                    s1 = DateTime.Parse(t1);
                    s2 = DateTime.Parse(t2);
                    fark = s1.Subtract(s2);

                    //eğer iade tarihine 2 gün veya daha az kaldıysa o kişinin satırı sarı olarak görünür
                    if (Int32.Parse(fark.TotalDays.ToString()) > -2 && Int32.Parse(fark.TotalDays.ToString()) < 1)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    //eğer son iade tarihi geçmişse satırın kırmızı görünmesi sağlanır.
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        ceza = int.Parse(fark.TotalDays.ToString()) * 1;
                        dataGridView1.Rows[i].Cells[5].Value = ceza.ToString();
                    }
                }
            }
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)//basıldığı zaman ana sayfaya yönlendirilir
        {

            AnaSayfa yenisayfa = new AnaSayfa();
            this.Hide();
            yenisayfa.ShowDialog();
        }

        private void btn_grafik_Click(object sender, EventArgs e)//basıldığı zaman grafik formuna geçiş yapılır.
        {
            Grafik yeni = new Grafik();
            this.Hide();
            yeni.Show();
        }
    }
}
