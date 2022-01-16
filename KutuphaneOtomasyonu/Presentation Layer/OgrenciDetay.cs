using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class OgrenciDetay : Form
    {
        public OgrenciDetay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Ekle Sil Güncelle formuna yönlendirilir.
        {
            Ekle_Sil_Guncelle yeni = new Ekle_Sil_Guncelle();
            this.Hide();
            yeni.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)//Öğrenci emanetislemleri formuna yönlendirilir.
        {
            Ogrenci_emanetislemeleri yeniemanet = new Ogrenci_emanetislemeleri();
            this.Hide();
            yeniemanet.ShowDialog();
        }

        private void emanetislemeri_Click(object sender, EventArgs e)//Öğrenci emanet iade islemleri formuna yönlendirilir.
        {

            Ogrenci_Emanet_Iade_islemleri yeni_emanet = new Ogrenci_Emanet_Iade_islemleri();
            this.Hide();
            yeni_emanet.ShowDialog();

        }

        private void btn_anasayfa_Click(object sender, EventArgs e)//AnaSayfa formun yönlendirilir.
        {

            AnaSayfa yenisayfa = new AnaSayfa();
            this.Hide();
            yenisayfa.Show();
        }
        #region yanlışlık

        private void OgrenciDetay_Load(object sender, EventArgs e)
        {

        }
        #endregion
      
    }
}
