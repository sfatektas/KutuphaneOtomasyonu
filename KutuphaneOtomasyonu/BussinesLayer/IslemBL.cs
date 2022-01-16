using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccsesLayer;
using EntityLayer;
using System.Data;
using System.Data.OleDb;

namespace BussinesLayer
{
    public class IslemBL
    {
        DataAccsesLayer.DataAccessLayer datalayer1 = new DataAccsesLayer.DataAccessLayer();//DAL türünde yeni nesne üretiyoruz ve DAL ile birlikte veri tabanında sorgu yapıp istediğimiz sonuçlara ulaşıyoruz.
        public List<IslemNesne> islemiade()//tüm işlemleri gösteren method 
        {
            OleDbDataReader dataReader = datalayer1.DataReaderVeriCekme("Select * From İslem", CommandType.Text);//İslem tablosundaki tüm verileri dataReadera atanır.
            if (dataReader.HasRows)//herhangi bir verilere sahipse 
            {
                List<IslemNesne> kayitislem = new List<IslemNesne>();//Her islem verisini, islemnesne tipinde bir arrayliste atamak için yeni arraylist oluşturulur.
                while (dataReader.Read())//tüm değerleri okuması için whlie döngüsüne alınır.
                {
                    IslemNesne nesneıslem = new IslemNesne //tüm veriler nesneye atanır
                    {
                        IslemNo = int.Parse(dataReader["islemno"].ToString()),
                        OgrenciNo = int.Parse(dataReader["ogrno"].ToString()),
                        KitapNo = int.Parse(dataReader["kitapno"].ToString()),
                        AlisTarihi = dataReader["alistarih"].ToString(),
                        VerisTarihi = dataReader["veristarih"].ToString(),
                        Borc = int.Parse(dataReader["borc"].ToString()),
                        IslemTuru = dataReader["islemtur"].ToString()
                    };
                    kayitislem.Add(nesneıslem); // atanan nesneler arrayliste eklenir.
                }
                return kayitislem;
            }
            return null;
        }
        DataAccsesLayer.DataAccessLayer datalayer2 = new DataAccsesLayer.DataAccessLayer();//DAL türünde yeni nesne üretiyoruz ve DAL ile birlikte veri tabanında sorgu yapıp istediğimiz sonuçlara ulaşıyoruz.
        public int iadeduzenleme(int OgrenciNo, int KitapNo, string Islemturu)
        {
            //İslem türününü iade veye emanet verilirken bu method çağırılır
            int deger = datalayer2.EklemeSilmeGuncelleme("UPDATE İslem set islemtur='" + Islemturu + "' WHERE ogrno=" + OgrenciNo + "and kitapno= " + KitapNo + "", System.Data.CommandType.Text);
            return deger;
        }
        public List<IslemNesne> kayitlisteleme(int OgrenciNo)
        {
            //bir öğrencinin daha önce ve şimdi aldığı kitapları gösterir.
            OleDbDataReader dataReader = datalayer2.DataReaderVeriCekme("Select * from islem where ogrno in (select ogrno from Ogrenci WHERE ogrno ='" + OgrenciNo + "')", CommandType.Text);
            if (dataReader.HasRows)//herhangi bir verilere sahipse 
            {
                List<IslemNesne> islemkayit = new List<IslemNesne>();//Her islem verisini, islemkayit tipinde bir arrayliste atamak için yeni arraylist oluşturulur.
                while (dataReader.Read())//tüm değerleri okuması için whlie döngüsüne alınır.
                {
                    IslemNesne duzenkayit = new IslemNesne //tüm veriler nesneye atanır
                    {
                        OgrenciNo = int.Parse(dataReader["ogrno"].ToString()),
                        KitapNo = int.Parse(dataReader["kitapno"].ToString()),
                        AlisTarihi = dataReader["alistarih"].ToString(),
                        VerisTarihi = dataReader["veristarih"].ToString(),
                        Borc = int.Parse(dataReader["borc"].ToString()),
                        IslemNo = int.Parse(dataReader["islemno"].ToString()),
                        IslemTuru = dataReader["islemtur"].ToString()
                    };
                    islemkayit.Add(duzenkayit);// atanan nesneler arrayliste eklenir.

                }
                return islemkayit;
            }
            return null;
        }

        public List<IslemNesne> kayitlisteleme_sonedit(int kitapno)
        {
            OleDbDataReader dataReader = datalayer2.DataReaderVeriCekme("Select * From islem WHERE kitapno=" + kitapno + "", CommandType.Text); //Kitap numarasından işlemde olan kitapları listeler
            if (dataReader.HasRows)//herhangi bir verilere sahipse 
            {
                List<IslemNesne> islemkayit = new List<IslemNesne>();
                while (dataReader.Read())//tüm değerleri okuması için whlie döngüsüne alınır.
                {
                    IslemNesne duzenkayit = new IslemNesne//tüm veriler nesneye atanır
                    {
                        OgrenciNo = int.Parse(dataReader["ogrno"].ToString()),
                        KitapNo = int.Parse(dataReader["kitapno"].ToString()),
                        AlisTarihi = dataReader["alistarih"].ToString(),
                        VerisTarihi = dataReader["veristarih"].ToString(),
                        Borc = int.Parse(dataReader["borc"].ToString()),
                        IslemNo = int.Parse(dataReader["islemno"].ToString()),
                        IslemTuru = dataReader["islemtur"].ToString()
                    };
                    islemkayit.Add(duzenkayit);// atanan nesneler arrayliste eklenir.

                }
                return islemkayit;
            }
            return null;
        }

        DataAccsesLayer.DataAccessLayer datalayer_1 = new DataAccsesLayer.DataAccessLayer();//DAL türünde yeni nesne üretiyoruz ve DAL ile birlikte veri tabanında sorgu yapıp istediğimiz sonuçlara ulaşıyoruz.
        public int emanet_vermeislemi(int KitapNo, int OgrenciNo,DateTime alistarihi , DateTime veristarih ,string ıslemturu)
        {
            int deger = datalayer_1.EklemeSilmeGuncelleme("INSERT into islem(ogrno ,kitapno , alistarih ,veristarih,islemtur) values ('" + OgrenciNo + "','" + KitapNo + "','" + alistarihi + "','" + veristarih + "','" + ıslemturu+"')",System.Data.CommandType.Text);
            return deger;
        }
        DataAccsesLayer.DataAccessLayer datalayer_2 = new DataAccsesLayer.DataAccessLayer();//DAL türünde yeni nesne üretiyoruz ve DAL ile birlikte veri tabanında sorgu yapıp istediğimiz sonuçlara ulaşıyoruz.

        ///KİTAP KONTROL////
        public bool KitapVarMıKontrol(int kitapno)//Emanet verirken kitap'ın veri tabanındaki varlığını sorgulamak amacıyla kullanılır.
        {
            OleDbDataReader dataReader = datalayer_2.DataReaderVeriCekme("Select * From kitap WHERE kitapno=" + kitapno + "", CommandType.Text);
            if (dataReader.HasRows)//herhangi bir verilere sahipse 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ///OGRENCİ KONTROLL////
        public bool OgrenciVarMıKontrol(int ogrenciNo)//Emanet verirken Öğrenci'nin veri tabanındaki varlığını sorgulamak amacıyla kullanılır.
        {
            OleDbDataReader dataReader = datalayer2.DataReaderVeriCekme("Select * FROM Ogrenci WHERE ogrno=" + ogrenciNo + "", CommandType.Text);
            if (dataReader.HasRows)//herhangi bir verilere sahipse 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        DataAccsesLayer.DataAccessLayer datalayer3 = new DataAccsesLayer.DataAccessLayer();//DAL türünde yeni nesne üretiyoruz ve DAL ile birlikte veri tabanında sorgu yapıp istediğimiz sonuçlara ulaşıyoruz.
        public List<IslemNesne> ogrenciemanet_iadelistesi(int deger)
        {
            OleDbDataReader dataReader = datalayer3.DataReaderVeriCekme("Select * from islem where ogrno in (Select ogrno from Ogrenci where ogrno=" + deger + ")", CommandType.Text);//Öğrenci numarasına ait işlemeleri işlem sınıfından alır ve öğrencileri aynı ayna öğrenci tablosunda varlığını sorgular
            if (dataReader.HasRows)//herhangi bir verilere sahipse 
            {
                List<IslemNesne> iadeliste = new List<IslemNesne>();
                while (dataReader.Read())
                {
                    IslemNesne emanetlistekayit = new IslemNesne
                    {
                        OgrenciNo = int.Parse(dataReader["ogrno"].ToString()),
                        KitapNo = int.Parse(dataReader["kitapno"].ToString()),
                        AlisTarihi = dataReader["alistarih"].ToString(),
                        VerisTarihi = dataReader["veristarih"].ToString(),
                        Borc = int.Parse(dataReader["borc"].ToString()),
                        IslemNo = int.Parse(dataReader["islemno"].ToString()),
                        IslemTuru = dataReader["islemtur"].ToString()
                    };
                    iadeliste.Add(emanetlistekayit);

                }
                return iadeliste;
            }
            return null;
        }

        //DataAccsesLayer.DataAccessLayer datalayer_4 = new DataAccsesLayer.DataAccessLayer();//DAL türünde yeni nesne üretiyoruz ve DAL ile birlikte veri tabanında sorgu yapıp istediğimiz sonuçlara ulaşıyoruz.
        //public List<IslemNesne> ogrenciemanet_iadelistesi(string deger)
        //{
        //    OleDbDataReader dataReader = datalayer_4.DataReaderVeriCekme("Select * from islem where ogrno in (Select ogrno from Ogrenci where ogrno=" + deger + ")", CommandType.Text);
        //    if (dataReader.HasRows)
        //    {
        //        List<IslemNesne> iadeliste = new List<IslemNesne>();
        //        while (dataReader.Read())
        //        {
        //            IslemNesne emanetlistekayit = new IslemNesne
        //            {
        //                OgrenciNo = int.Parse(dataReader["ogrno"].ToString()),
        //                KitapNo = int.Parse(dataReader["kitapno"].ToString()),
        //                AlisTarihi = dataReader["alistarih"].ToString(),
        //                VerisTarihi = dataReader["veristarih"].ToString(),
        //                Borc = int.Parse(dataReader["borc"].ToString()),
        //                IslemNo = int.Parse(dataReader["islemno"].ToString()),
        //                IslemTuru = dataReader["islemtur"].ToString()
        //            };
        //            iadeliste.Add(emanetlistekayit);

        //        }
        //        return iadeliste;
        //    }
        //    return null;
        //}

        //DataAccsesLayer.DataAccessLayer datalayer4 = new DataAccsesLayer.DataAccessLayer();//DAL türünde yeni nesne üretiyoruz ve DAL ile birlikte veri tabanında sorgu yapıp istediğimiz sonuçlara ulaşıyoruz.
        //public List<IslemNesne> kayitlisteleme_2(string deger, string konum)
        //{
        //    OleDbDataReader dataReader = datalayer4.DataReaderVeriCekme("Select * from islem where kitapno in (Select kitapno from Kitap where " + konum + " ='" + deger + "')", CommandType.Text);
        //    if (dataReader.HasRows)
        //    {
        //        List<IslemNesne> islemkayit2 = new List<IslemNesne>();
        //        while (dataReader.Read())
        //        {
        //            IslemNesne islemkayitnesne1 = new IslemNesne()
        //            {
        //                OgrenciNo = int.Parse(dataReader["ogrno"].ToString()),
        //                KitapNo = int.Parse(dataReader["kitapno"].ToString()),
        //                AlisTarihi = dataReader["alistarih"].ToString(),
        //                VerisTarihi = dataReader["veristarih"].ToString(),
        //                Borc = int.Parse(dataReader["borc"].ToString()),
        //                IslemNo = int.Parse(dataReader["islemno"].ToString()),
        //                IslemTuru = dataReader["islemtur"].ToString()
        //            };
        //            islemkayit2.Add(islemkayitnesne1);
        //        }
        //        return islemkayit2;
        //    }
        //    return null;
        //}
    }
}
