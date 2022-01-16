using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLayer;
using EntityLayer;
using System.Data;
using System.Data.OleDb;

namespace BussinesLayer
{
    public class TurBL
    {
        DataAccsesLayer.DataAccessLayer datalayer1 = new DataAccsesLayer.DataAccessLayer();//DAL türünde yeni nesne üretiyoruz ve DAL ile birlikte veri tabanında sorgu yapıp istediğimiz sonuçlara ulaşıyoruz.
        public List<TurNesne> TurGoster()//Tüm kitap türlerini göstermek için gerekli olan method 
        {
            OleDbDataReader dataReader = datalayer1.DataReaderVeriCekme("SELECT * FROM Tur", CommandType.Text);//Gerekli Sql sorguları yazılıyor

            if (dataReader.HasRows)//gerekli veriler var ise
            {
                List<TurNesne> turler = new List<TurNesne>();
                while (dataReader.Read())//gelen verilerin hepsi okunur
                {
                    TurNesne Tur = new TurNesne()
                    {
                        TurNo = int.Parse(dataReader["turno"].ToString()),
                        Turadi = dataReader["turadi"].ToString()
                    };
                    turler.Add(Tur);//array liste okunan veriler eklenir.

                }
                return turler;//array listi döndürür.

            }
            return null;
        }
        public int TurSil(int turno)//Tur numarası alınarak veri tabanından kitap türü silinir.
        {
            int sorgusonuc = datalayer1.EklemeSilmeGuncelleme("Delete from Tur WHERE turno=" + turno + "", System.Data.CommandType.Text);
            return sorgusonuc;
        }
        DataAccsesLayer.DataAccessLayer datalayer2 = new DataAccsesLayer.DataAccessLayer();
        public int TurEkle(string turadi)//Tur Adı alınarak veri tabanına kitap türü eklenir.
        {
            int sorgusonuc = datalayer2.EklemeSilmeGuncelleme("INSERT into Tur (turadi) VALUES ('" + turadi + "')", System.Data.CommandType.Text);
            return sorgusonuc;
        }
        DataAccsesLayer.DataAccessLayer datalayer_3 = new DataAccsesLayer.DataAccessLayer();
        public int TurGuncelle(int turno, string turAdi)//Tür numarası yazılarak istenilen veri kullanıcı tarafından değiştirilir.
        {
            int sorgusonuc = datalayer_3.EklemeSilmeGuncelleme("Update Tur SET turadi='" + turAdi + "'" + " WHERE turno =" + turno + "", System.Data.CommandType.Text);
            return sorgusonuc;
        }
    }
}
