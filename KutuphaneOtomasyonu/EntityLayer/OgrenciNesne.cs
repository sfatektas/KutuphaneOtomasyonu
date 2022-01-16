using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class OgrenciNesne//Öğrenci nesnesi için gerekli olan propertyleri tanımlıyoruz.
    {
        public int OgrenciNo { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public string Cinsiyet { get; set; }
        public string DogumTarihi { get; set; }
        public string Bolum { get; set; }
    }
}
