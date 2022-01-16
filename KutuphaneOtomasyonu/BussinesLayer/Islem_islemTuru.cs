using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using EntityLayer;
using DataAccsesLayer;

namespace BussinesLayer
{
   public class Islem_islemTuru//BU CLASS GRAFİKTEKİ VERİLER İÇİN KULLANILIYOR
    {
        DataAccsesLayer.DataAccessLayer datalayer = new DataAccsesLayer.DataAccessLayer();//DAL türünde yeni nesne üretiyoruz ve DAL ile birlikte veri tabanında sorgu yapıp istediğimiz sonuçlara ulaşıyoruz.
        public int Listele()
        {
            int toplam = 0;
            OleDbDataReader dataReader = datalayer.DataReaderVeriCekme("Select kitapno from Kitap", CommandType.Text);//Kitap tablosundan Kitap isimlerini dataReadere atıyoruz.
            if (dataReader.HasRows)//Eğer Sorguya ait veriler(Satırlar) var ise 
            {
                List<KitapNesne> kitaplar = new List<KitapNesne>();
                while (dataReader.Read())
                {
                    toplam++;//tüm kitapları listeler 
                }
                return toplam; //toplam değeri döndürüyoruz.
            }
            return 0;

        }

        DataAccsesLayer.DataAccessLayer datalayer2 = new DataAccsesLayer.DataAccessLayer();

        public int alma()
        {
            int toplam = 0;
            OleDbDataReader dataReader = datalayer2.DataReaderVeriCekme("Select * From İslem WHERE islemtur='" + "Alım" + "'", CommandType.Text);
            if (dataReader.HasRows)//Eğer Sorguya ait veriler(Satırlar) var ise 
            {
                List<KitapNesne> kitaplar1 = new List<KitapNesne>();
                while (dataReader.Read())//Eğer Sorguya ait veriler(Satırlar) var ise 
                {
                    toplam++;//İşlem Türü Alım olan Kitapların Sayılarını Verir.

                }
                return toplam;//toplam değeri döndürüyoruz.


            }
            return 0;

        }
    }
}
