using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using DataAccsesLayer;
using EntityLayer;//entity ve dal katmanını başvuru olarak ekliyoruz 

namespace BussinesLayer
{
    public class OgrenciBL
    {
        DataAccsesLayer.DataAccessLayer datalayer1 = new DataAccsesLayer.DataAccessLayer();//DAL türünde yeni nesne üretiyoruz ve DAL ile birlikte veri tabanında sorgu yapıp istediğimiz sonuçlara ulaşıyoruz.
        public List<OgrenciNesne> OgrenciGoster()//Tüm Öğrencileri gösteren method 
        {
            OleDbDataReader dataReader = datalayer1.DataReaderVeriCekme("SELECT * FROM Ogrenci", CommandType.Text);//tüm öğrenci verilerini çekiyoruz
            
            if (dataReader.HasRows)//
            {
                List<OgrenciNesne> ogrenciler = new List<OgrenciNesne>();

                while (dataReader.Read())
                {
                    OgrenciNesne ogrenci = new OgrenciNesne
                    {
                        OgrenciNo = int.Parse(dataReader["ogrno"].ToString()),
                        OgrenciAdi = dataReader["ograd"].ToString(),
                        OgrenciSoyadi = dataReader["ogrsoyad"].ToString(),
                        Cinsiyet = dataReader["cinsiyet"].ToString(),
                        DogumTarihi = dataReader["dtarih"].ToString(),
                        Bolum= dataReader["bolum"].ToString()
                    };
                    ogrenciler.Add(ogrenci);
                }
                return ogrenciler;
            }
            return null;
        }
        DataAccsesLayer.DataAccessLayer datalayer2 = new DataAccsesLayer.DataAccessLayer();//DAL türünde yeni nesne üretiyoruz ve DAL ile birlikte veri tabanında sorgu yapıp istediğimiz sonuçlara ulaşıyoruz.


        public List<OgrenciNesne> OgrenciGoster(int ogrenciNo)//kullanıcıdan öğrencinin numarasını alarak ilgili öğrencinin verilerini gösteriyoruz.
        {
            OleDbDataReader dataReader = datalayer2.DataReaderVeriCekme("Select * FROM Ogrenci WHERE ogrno=" + ogrenciNo + "", CommandType.Text);
            if (dataReader.HasRows)//sorguya göre gelen veri var mı ?
            {
                List<OgrenciNesne> ogrenciler1 = new List<OgrenciNesne>();
                while (dataReader.Read())//Tüm verileri okur.
                {
                    OgrenciNesne ogrenci = new OgrenciNesne()
                    {
                        OgrenciNo = int.Parse(dataReader["ogrno"].ToString()),
                        OgrenciAdi = dataReader["ograd"].ToString(),
                        OgrenciSoyadi = dataReader["ogrsoyad"].ToString(),
                        Cinsiyet = dataReader["cinsiyet"].ToString(),
                        DogumTarihi = dataReader["dtarih"].ToString(),
                        Bolum = dataReader["bolum"].ToString()
                    };
                    ogrenciler1.Add(ogrenci);
                }
                return ogrenciler1;
            }
            return null;
        }

        DataAccsesLayer.DataAccessLayer datalayer3 = new DataAccsesLayer.DataAccessLayer();//DAL türünde yeni nesne üretiyoruz ve DAL ile birlikte veri tabanında sorgu yapıp istediğimiz sonuçlara ulaşıyoruz.
        public int OgrenciEkle(int OgrenciNo, string OgrenciAdi, string OgrenciSoyadi, string DogumTarihi, string Cinsiyet, string Bolum)//Kullanıcıdan öğrencinin bilgilerini alarak yeni öğrenci ekleniyor
        {
            //Gerekli sql sorguları yazılıyor
            int sorgusonuc = datalayer3.EklemeSilmeGuncelleme("INSERT into Ogrenci (ogrno,ograd,ogrsoyad,cinsiyet,dtarih,bolum) VALUES ('" + OgrenciNo + "','" + OgrenciAdi + "','" + OgrenciSoyadi + "','" + Cinsiyet + "','" + DogumTarihi + "','" + Bolum+"')",System.Data.CommandType.Text);
            return sorgusonuc;
        }
        DataAccsesLayer.DataAccessLayer datalayer4 = new DataAccsesLayer.DataAccessLayer();//DAL türünde yeni nesne üretiyoruz ve DAL ile birlikte veri tabanında sorgu yapıp istediğimiz sonuçlara ulaşıyoruz.
        public int OgrenciGuncelle(int OgrenciNo, string OgrenciAdi, string OgrenciSoyadi, string DogumTarihi, string Cinsiyet, string Bolum)
        {
            //Gerekli sql sorguları yazılıyor
            int sorgusonuc = datalayer4.EklemeSilmeGuncelleme("Update Ogrenci SET ograd='" + OgrenciAdi + "',ogrsoyad ='" + OgrenciSoyadi + "',cinsiyet='" + Cinsiyet + "',dtarih= '" + DogumTarihi + "',bolum='" + Bolum + "'" + " Where ogrno=" + OgrenciNo + "", System.Data.CommandType.Text);
            return sorgusonuc;
        }
        DataAccsesLayer.DataAccessLayer datalayer5 = new DataAccsesLayer.DataAccessLayer();//DAL türünde yeni nesne üretiyoruz ve DAL ile birlikte veri tabanında sorgu yapıp istediğimiz sonuçlara ulaşıyoruz.
        public int OgrenciSil(int OgrenciNo)
        {
            //Gerekli sql sorguları yazılıyor
            int sorgusonuc = datalayer5.EklemeSilmeGuncelleme("Delete from Ogrenci WHERE ogrno= " + OgrenciNo + "", System.Data.CommandType.Text);
            return sorgusonuc;
        }

    }
}
