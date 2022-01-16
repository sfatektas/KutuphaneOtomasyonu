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
using ZedGraph;



namespace PresentationLayer
{
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
        }
        Islem_islemTuru zedgraph = new Islem_islemTuru();//islemturu sınıfından zedgraph nesnesi oluşturuluyor. 
        private void Grafik_Load(object sender, EventArgs e)
        {
            int tumkitaplar = zedgraph.Listele();//Listele fonkisyonu ile  veri tabanındaki tüm kitapların sayısı çekiliyor.
            int emanetverilenkitaplar = zedgraph.alma();//alma fonksiyonu ile veri tabanındaki tüm emanetverilen kitapların sayısı çekiliyor.

            GraphPane Pane = zedGraphControl1.GraphPane;

            string[] satir ={
                "Emanet Verilen Kitaplar ",
                "Verilmeye Hazır Kitaplar "
                ,"Tüm Kitaplar"};

            double[] veriler = {
                emanetverilenkitaplar,
                tumkitaplar - emanetverilenkitaplar,
                tumkitaplar };//kitaplarla ilgili grafik verileri 

            Pane.AddPieSlices(veriler, new[] { "Verilen Kitaplar", "Verilmeye Hazır Kitaplar", null });//Grafiğin Değer isimleri 
            Pane.Legend.IsVisible = true;

            LineItem cizgi = Pane.AddCurve(null, null, veriler, Color.Red);

            cizgi.Line.Fill = new Fill(Color.Azure, Color.White, Color.Red);
            Pane.XAxis.Scale.TextLabels = satir;
            Pane.XAxis.Type = AxisType.Text;

            Pane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 90F);//Çizilen Grafiğin Renk skalesi ayarları
            Pane.Fill = new Fill(Color.FromArgb(250, 250, 255));
            zedGraphControl1.AxisChange();

        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa yeniana = new AnaSayfa();
            this.Hide();
            yeniana.Show();
        }
    }
}
