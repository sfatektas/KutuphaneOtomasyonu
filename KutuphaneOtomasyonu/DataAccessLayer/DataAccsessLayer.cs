using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace DataAccsesLayer
{//ACCESS VERİ TABANINDA KULLANILACAK SORGULAR
    public class DataAccessLayer
    {
        //Access veri tabanında sorguları orda çalıştırmaya yarayan method
        private OleDbCommand SorguYaz(string Sorgu, CommandType SorguTipi)//Sorgu tipi default olarak CommandType.Text değeri gelir.
        {
            VeritabanıBaglantısı baglantı = new VeritabanıBaglantısı();
            OleDbCommand komut = baglantı.BaglantiKoprusu.CreateCommand();
            komut.CommandText = Sorgu;
            komut.CommandType = SorguTipi;
            return komut;
        }
        List<OleDbParameter> parametreler = new List<OleDbParameter>();
        
        public void ParametreleriSorguyaEkle(OleDbCommand KomutNesnesi)
        {
            KomutNesnesi.Parameters.AddRange(parametreler.ToArray());
        }
        public int EklemeSilmeGuncelleme(string Sorgu, CommandType SorguTipi)
        {//Genel olarak EKLEME , SİLME ,GÜNCELLEME İŞLEMLERİ İÇİN BU METHOD KULLANILIR.
            try
            {
                OleDbCommand komut = SorguYaz(Sorgu, SorguTipi);
                ParametreleriSorguyaEkle(komut);
                int sayi = komut.ExecuteNonQuery();//satır sayısını döndürür.
                if (komut.Connection.State == ConnectionState.Open)
                {
                    komut.Connection.Close();
                }
                komut.Connection.Dispose();
                komut.Dispose();
                return sayi;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public OleDbDataReader DataReaderVeriCekme(string Sorgu, CommandType SorguTipi)
        {
            OleDbCommand komut = SorguYaz(Sorgu, SorguTipi);
            ParametreleriSorguyaEkle(komut);
            OleDbDataReader datareader = komut.ExecuteReader(CommandBehavior.CloseConnection);
            return datareader;
        }
    }
}
