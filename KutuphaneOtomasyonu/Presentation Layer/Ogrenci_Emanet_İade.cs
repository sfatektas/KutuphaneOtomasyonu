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
    public partial class Ogrenci_Emanet_Iade_islemleri : Form
    {
        public Ogrenci_Emanet_Iade_islemleri()
        {
            InitializeComponent();
        }

        private void btn_emanet_click(object sender, EventArgs e)//Basıldığında  öğrenciemanetdetay formuna gidilir.
        {
            Ogrenci_EmanetVer_Detay yenidetay = new Ogrenci_EmanetVer_Detay();
            this.Hide();
            yenidetay.Show();
        }

        private void button2_Click(object sender, EventArgs e)//Basıldığında öğrenci detay formuna gidilir.
        {
            Ogrenci_iade detay = new Ogrenci_iade();
            this.Hide();
            detay.Show();
        }

        private void btn_anasayfayadon_Click(object sender, EventArgs e)//Basıldığında Anasayfa formuna dönüşü sağlar
        {

            AnaSayfa yenisayfa = new AnaSayfa();
            this.Hide();
            yenisayfa.Show();
        }
    }
}
