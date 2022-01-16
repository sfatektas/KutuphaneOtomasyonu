using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class IslemNesne//İslem nesnesi için gerekli olan propertyleri tanımlıyoruz.
    {
        public int IslemNo { get; set; }
        public int OgrenciNo { get; set; }
        public int KitapNo { get; set; }
        public string AlisTarihi { get; set; }
        public string VerisTarihi { get; set; }
        public int Borc { get; set; }
        public string IslemTuru { get; set; }
    }
}
