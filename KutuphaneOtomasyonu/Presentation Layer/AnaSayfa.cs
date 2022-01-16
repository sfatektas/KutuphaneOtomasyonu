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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Öğrenci detay sayfasına yönlendirilir
        {
            OgrenciDetay yenisayfa = new OgrenciDetay();
            this.Hide();
            yenisayfa.Show();
        }

        private void btn_kitapislemleri_Click(object sender, EventArgs e)
        {
            Kitapİslemleri kitapyeni = new Kitapİslemleri();//Kitap işlemleri sayfasına yönlendirilir
            this.Hide();
            kitapyeni.Show();
        }
        private void btn_yazar_Click(object sender, EventArgs e)
        {
            yazarislemleri yazar = new yazarislemleri();//Yazar işlemleri sayfasına yönlendirilir.
            this.Hide();
            yazar.Show();
        }
        #region yanlışlık
        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
