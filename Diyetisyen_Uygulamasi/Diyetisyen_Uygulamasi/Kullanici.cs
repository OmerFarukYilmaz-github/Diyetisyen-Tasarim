
using System.Windows.Forms;
using System.Data.OleDb;

namespace Diyetisyen_Uygulamasi
{
    class Kullanici
    {
      
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=diyetisyen.accdb");
        OleDbCommand komut;

        public void KullaniciEkle   (int diyetID, int hastalikID, string kullaniciTipi, string ad , string soyad, string tc,
                                    string tel, string yas, string boy, string kilo, string sifre)
        {
            baglanti.Open();

            string sqlkodu = "insert into Kullanici ([DiyetID], [HastalikID], [KullaniciTipi], [Ad], [Soyad], [TC], [Tel], [Yas], [Boy], [Kilo], [Sifre]) " +
                             "values (@DiyetID, @HastalikID, @KullaniciTipi, @Ad, @Soyad, @TC, @Tel, @Yas, @Boy, @Kilo, @Sifre)";


            komut = new OleDbCommand(sqlkodu, baglanti);

            komut.Parameters.AddWithValue("@DiyetID", diyetID);
            komut.Parameters.AddWithValue("@HastalikID", hastalikID);
            komut.Parameters.AddWithValue("@KullaniciTipi", kullaniciTipi);
            komut.Parameters.AddWithValue("@Ad", ad);
            komut.Parameters.AddWithValue("@Soyad", soyad);
            komut.Parameters.AddWithValue("@TC", tc);
            komut.Parameters.AddWithValue("@Tel", tel);
            komut.Parameters.AddWithValue("@Yas", yas);
            komut.Parameters.AddWithValue("@Boy", boy);
            komut.Parameters.AddWithValue("@Kilo", kilo);
            komut.Parameters.AddWithValue("@Sifre", sifre);

            if (komut.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Uye Kaydı Başarılı");
            }


            baglanti.Close();

        }

        public void KullanıcıSil(string kullanıcıID)
        {
            baglanti.Open();
            string sqlkodu = "delete from Kullanici where KullaniciID="+kullanıcıID+"";
            komut = new OleDbCommand(sqlkodu, baglanti);

            if (komut.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Kayıt Silme Başarılı");
            }
            baglanti.Close();

        }
 
        public void KullanıcıGuncelle(string kullaniciID, string ad, string soyad, string tc, string tel, string yas, string boy, string kilo, string sifre)
        {
            baglanti.Open();
            string sqlkodu = "update Kullanici set [Ad]=@Ad,[Soyad]=@Soyad,[TC]=@TC,[Tel]=@Tel,[Yas]=@Yas,[Boy]=@Boy,[Kilo]=@Kilo,[Sifre]=@Sifre where KullaniciID=" + kullaniciID + "";

            komut = new OleDbCommand(sqlkodu, baglanti);

            komut.Parameters.AddWithValue("@Ad", ad);
            komut.Parameters.AddWithValue("@Soyad", soyad);
            komut.Parameters.AddWithValue("@TC", tc);
            komut.Parameters.AddWithValue("@Tel", tel);
            komut.Parameters.AddWithValue("@Yas", yas);
            komut.Parameters.AddWithValue("@Boy", boy);
            komut.Parameters.AddWithValue("@Kilo", kilo);
            komut.Parameters.AddWithValue("@Sifre", sifre);


            if (komut.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Hasta Bilgileri Başarıyla Güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hasta Bilgileri Güncellenirken Hata Oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();

        }

    }
}
