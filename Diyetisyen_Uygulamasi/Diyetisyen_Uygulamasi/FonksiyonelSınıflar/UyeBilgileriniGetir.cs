using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Diyetisyen_Uygulamasi
{
  
    class UyeBilgileriniGetir
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=diyetisyen.accdb");
        OleDbCommand komut;
        OleDbDataReader oku;
        string sqlkodu;
        string ad, soyad, tc, tel, yas, boy, kilo;
        string diyetID, diyetaAdi, diyetAciklama, diyetEtki;
        string hastalikID,hastalikadi;


       public UyeBilgileriniGetir(string KullaniciID)
        {
            // Bize gelen kullanciID'ye göre istediğimiz bilgileri alınır.
            sqlkodu = "select * from Kullanici where KullaniciID=" + KullaniciID + "";
            komut = new OleDbCommand(sqlkodu, baglanti);

            baglanti.Open();

            oku = komut.ExecuteReader();
            if (oku.Read())
            {
               diyetID    = oku[1].ToString();
               hastalikID = oku[2].ToString();
               ad         = oku[4].ToString();
               soyad      = oku[5].ToString();
               tc         = oku[6].ToString();
               tel        = oku[7].ToString();
               yas        = oku[8].ToString();
               boy        = oku[9].ToString();
               kilo       = oku[10].ToString();
            }

            baglanti.Close();

            // Kullanıcıdan alınan DiyetID'ye göre diyet bilgileri alınır.
            sqlkodu = "select * from Diyet where DiyetID=" + diyetID + "";
            komut = new OleDbCommand(sqlkodu, baglanti);

            baglanti.Open();

            oku = komut.ExecuteReader();
            if (oku.Read())
            {
                diyetaAdi       = oku[1].ToString();
                diyetAciklama   = oku[2].ToString();
                diyetEtki       = oku[3].ToString();
            }

            baglanti.Close();


            // Kullanıcıdan alınan HastalikID'ye göre hastalık adı alınır.
            sqlkodu = "select * from Hastalik where HastalikID=" + hastalikID + "";
            komut = new OleDbCommand(sqlkodu, baglanti);

            baglanti.Open();

            oku = komut.ExecuteReader();
            if (oku.Read())
            {
                hastalikadi = oku[1].ToString();
            }

            baglanti.Close();

        }

        // Istenen bilgilerin gönderilmesini sağlayan fonksiyonler
        #region Bilgileri Getirme

        public  string ad_Getir()
        {
            return ad;
        }

        public string soyad_Getir()
        {
            return soyad;
        }

        public string tc_Getir()
        {
            return tc;
        }

        public string tel_Getir()
        {
            return tel;
        }

        public string yas_Getir()
        {
            return yas;
        }

        public string boy_Getir()
        {
            return boy;
        }

        public string kilo_Getir()
        {
            return kilo;
        }

        public string diyetaAdi_Getir()
        {
            return diyetaAdi;
        }

        public string diyetAciklama_Getir()
        {
            return diyetAciklama;
        }

        public string diyetEtki_Getir()
        {
            return diyetEtki;
        }
 
        public string hastalikAdi_Getir()
        {
            return hastalikadi;
        }

        #endregion 


    }
}
