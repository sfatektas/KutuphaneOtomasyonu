using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DataAccsesLayer
{
    public static class Baglanti//Statik tanımlıyoruz yeni bir nesne oluşturmayacağız var olan bağlantı yoluna ulaşacağız.
    {
        public const string Yol = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\SEFA$$\\Desktop\\kutuphaneson.mdb";//Access Veri Tabanı ile Gerekli olan Bağlantı Yolu tanımlanıyor.
    }
}
