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
    public class KitapBL
    {
        DataAccsesLayer.DataAccessLayer dataAccessLayer2 = new DataAccsesLayer.DataAccessLayer();
        public List<KitapNesne> KitapGoster()//Tüm kitapları göstermek için kullanılan method 
        {
            OleDbDataReader dataReader = dataAccessLayer2.DataReaderVeriCekme("Select * from Kitap", CommandType.Text);
            if (dataReader.HasRows)
            {
                List<KitapNesne> kitapNesnesi = new List<KitapNesne>();
                while (dataReader.Read())//Tüm verileri okur.
                {
                    KitapNesne kitap = new KitapNesne()
                    {
                        KitapNo = int.Parse(dataReader["kitapno"].ToString()),
                        Kitapadi = dataReader["kitapadi"].ToString(),
                        SayfaSayisi = int.Parse(dataReader["sayfasayisi"].ToString()),
                        TurNO = int.Parse(dataReader["turno"].ToString()),
                        YazarNo = int.Parse(dataReader["yazarno"].ToString())
                    };
                    kitapNesnesi.Add(kitap);
                }
                return kitapNesnesi;
            }
            return null;
        }
        DataAccsesLayer.DataAccessLayer dataAccessLayer3 = new DataAccsesLayer.DataAccessLayer();
        public List<KitapNesne> KitapGoster(int deger)//kullanıcıdan kitap numarasını alarak ilgili kitapı gösteren method
        {
            OleDbDataReader dataReader = dataAccessLayer3.DataReaderVeriCekme("Select * From kitap WHERE kitapno=" + deger + "", CommandType.Text);
            if (dataReader.HasRows)
            {
                List<KitapNesne> kitapNesnesi = new List<KitapNesne>();
                while (dataReader.Read())//Tüm verileri okur.
                {
                    KitapNesne kitap = new KitapNesne()
                    {
                        KitapNo = int.Parse(dataReader["kitapno"].ToString()),
                        Kitapadi = dataReader["kitapadi"].ToString(),
                        SayfaSayisi = int.Parse(dataReader["sayfasayisi"].ToString()),
                        TurNO = int.Parse(dataReader["turno"].ToString()),
                        YazarNo = int.Parse(dataReader["yazarno"].ToString())
                    };
                    kitapNesnesi.Add(kitap);
                }
                return kitapNesnesi;
            }
            return null;
        }

        DataAccsesLayer.DataAccessLayer dataAccessLayer8 = new DataAccsesLayer.DataAccessLayer();
        public List<KitapNesne> KitapGoster(string deger)//kullanıcıdan kitap adı alarak ilgili kitapı gösteren method
        {
            OleDbDataReader dataReader = dataAccessLayer8.DataReaderVeriCekme("Select * From kitap WHERE kitapadi='" + deger + "'", CommandType.Text);
            if (dataReader.HasRows)
            {
                List<KitapNesne> kitapNesnesi = new List<KitapNesne>();
                while (dataReader.Read())//Tüm verileri okur.
                {
                    KitapNesne kitap = new KitapNesne()
                    {
                        KitapNo = int.Parse(dataReader["kitapno"].ToString()),
                        Kitapadi = dataReader["kitapadi"].ToString(),
                        SayfaSayisi = int.Parse(dataReader["sayfasayisi"].ToString()),
                        TurNO = int.Parse(dataReader["turno"].ToString()),
                        YazarNo = int.Parse(dataReader["yazarno"].ToString())
                    };
                    kitapNesnesi.Add(kitap);
                }
                return kitapNesnesi;
            }
            return null;
        }

        DataAccsesLayer.DataAccessLayer dataAccessLayer4 = new DataAccsesLayer.DataAccessLayer();

        public int KitapEkle(string KitapAdi, string SayfaSayisi, string Turno, string Yazarno)//Kullanıcıdan kitapın bilgilerini alarak yeni kitap eklenmesini sağlar.
        {
            int deger = dataAccessLayer4.EklemeSilmeGuncelleme("insert into kitap (kitapadi,sayfasayisi,turno,yazarno) VALUES ('" + KitapAdi + "','" + SayfaSayisi + "','" + Turno + "','" + Yazarno + "')", System.Data.CommandType.Text);
            return deger;
        }
        DataAccsesLayer.DataAccessLayer dataAccessLayer5 = new DataAccsesLayer.DataAccessLayer();

        public int KitapGuncelle(int kitapno, string KitapAdi, string SayfaSayisi, string Turno, string Yazarno)//Kitap numarasını alarak kitapların güncelleştirilmesini sağlayan method
        {
            int deger = dataAccessLayer5.EklemeSilmeGuncelleme("UPDATE kitap set kitapadi='" + KitapAdi + "', sayfasayisi='" + SayfaSayisi + "',turno='" + Turno + "',yazarno='" + Yazarno + "'" + "WHERE kitapno = " + kitapno + "", System.Data.CommandType.Text);
            return deger;
        }
        DataAccsesLayer.DataAccessLayer dataAccessLayer6 = new DataAccsesLayer.DataAccessLayer();

        public int KitapSil(int kitapno)//Kitap numarası alıp kitap silme işlemi yapan method
        {
            int deger = dataAccessLayer6.EklemeSilmeGuncelleme("Delete from Kitap WHERE kitapno = " + kitapno + "", System.Data.CommandType.Text);
            return deger;
        }
    }
}
