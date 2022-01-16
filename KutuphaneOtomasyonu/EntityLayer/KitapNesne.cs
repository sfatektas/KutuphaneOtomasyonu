using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class KitapNesne//Kitap nesnesi için gerekli olan propertyleri tanımlıyoruz.
    {
        public int KitapNo { get; set; }
        public string Kitapadi { get; set; }
        public int YazarNo { get; set; }
        public int TurNO { get; set; }
        public int SayfaSayisi { get; set; }
        
    }
}
