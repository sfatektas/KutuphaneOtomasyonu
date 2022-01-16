using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using BussinesLayer;
using System.Data;
using System.Data.OleDb;

namespace BussinesLayer
{
    public class YazarBL
    {
        DataAccsesLayer.DataAccessLayer datalayer1 = new DataAccsesLayer.DataAccessLayer();//DAL türünde yeni nesne üretiyoruz ve DAL ile birlikte veri tabanında sorgu yapıp istediğimiz sonuçlara ulaşıyoruz.
        public List<YazarNesne> YazarGoster()//Tüm yazarları göstermek için kullanılır.
        {
            OleDbDataReader dataReader = datalayer1.DataReaderVeriCekme("SELECT * FROM Yazar", CommandType.Text);//Gerekli Sql sorguları yazılır.

            if (dataReader.HasRows)//sorguya göre gelen veri var mı ?
            {
                List<YazarNesne> yazarlar = new List<YazarNesne>();
                while (dataReader.Read())//Tüm verileri okur.
                {
                    YazarNesne yazar = new YazarNesne()
                    {
                        YazarNo = int.Parse(dataReader["yazarno"].ToString()),
                        YazarAd = dataReader["yazarad"].ToString(),
                        YazarSoyad = dataReader["yazarsoyad"].ToString()
                    };
                    yazarlar.Add(yazar);

                }
                return yazarlar;

            }
            return null;
        }
        public int YazarSil(int yazarno)//Kullanıcıdan alınan yazar numarası ile ilgili yazar silinir.
        {
            int sorgusonuc = datalayer1.EklemeSilmeGuncelleme("Delete from Yazar WHERE yazarno= " + yazarno + "", System.Data.CommandType.Text);
            return sorgusonuc;
        }
        DataAccsesLayer.DataAccessLayer datalayer2 = new DataAccsesLayer.DataAccessLayer();//DAL türünde yeni nesne üretiyoruz ve DAL ile birlikte veri tabanında sorgu yapıp istediğimiz sonuçlara ulaşıyoruz.
       
        public int YazarEkle(string YazarAdi, string YazarSoyadi)//Kullanıcıdan alınan yazar adi ve yazar soyadını veri tabanına eklerken 
        {
            int sorgusonuc = datalayer2.EklemeSilmeGuncelleme("INSERT into Yazar (yazarad,yazarsoyad) VALUES ('" + YazarAdi + "','" + YazarSoyadi + "')", System.Data.CommandType.Text);
            return sorgusonuc;
        }
        DataAccsesLayer.DataAccessLayer datalayer3 = new DataAccsesLayer.DataAccessLayer();//DAL türünde yeni nesne üretiyoruz ve DAL ile birlikte veri tabanında sorgu yapıp istediğimiz sonuçlara ulaşıyoruz.
        public int YazarGuncelle(int yazarno,string YazarAdi, string YazarSoyadi)//İlgili yazar bilgileri girilerek değiştirmek istenen veriler kullanıcıdan alınır.
        {
            int sorgusonuc = datalayer3.EklemeSilmeGuncelleme("Update Yazar SET yazarad='" + YazarAdi + "',yazarsoyad ='" + YazarSoyadi + "'" + " Where yazarno=" + yazarno + "", System.Data.CommandType.Text);
            return sorgusonuc;
        }
    }
}
