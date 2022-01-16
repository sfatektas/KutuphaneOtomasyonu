using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

namespace DataAccsesLayer
{
    public class VeritabanıBaglantısı
    {
        //Access veritabanı bağlantısı yapılıyor.
        OleDbConnection baglanti;
        public OleDbConnection BaglantiKoprusu//get propertisi ile bağlantının yolunu denetliyorum yoksa yeni bağlantı kuruluyor.
        {
            get
            {
                if (baglanti != null)//Bağlantı hali hazırda herhangi bir veritabanına bağlı ise
                {
                    if (baglanti.State == ConnectionState.Closed)//Bağlantı durumu kapalı ise bağlantıyı açıyoruz.
                    {
                        baglanti.Open();
                    }
                    return baglanti;//Bağlantıyı açıp geri döndürüyoruz.
                }
                else
                {
                    baglanti = new OleDbConnection(YolGetir());//Bağlantı Hiçbir veri tabanına bağlı değilse Bağlantı yolu ile Access veri tabanına bağlanıyoruz.
                    if (baglanti.State == ConnectionState.Closed)//Bağlantı durumu kapalı ise bağlantıyı açıyoruz.
                    {
                        baglanti.Open();
                    }
                    return baglanti;//Bağlantıyı açıp geri döndürüyoruz.
                }
            }
        }
        private string YolGetir()
        {
            return Baglanti.Yol; //Bağlantı sınıfındaki Yolu çağırıyoruz.
        }
    }
}
