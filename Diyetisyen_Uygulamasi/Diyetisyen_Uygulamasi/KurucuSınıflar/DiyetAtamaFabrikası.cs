using System.Windows.Forms;
using System.Data.OleDb;

namespace Diyetisyen_Uygulamasi
{
    class DiyetAtamaFabrikası
    {

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=diyetisyen.accdb");
        OleDbCommand komut;
        OleDbDataReader oku;
        DialogResult mesaj = new DialogResult();

        public IDiyetAta DiyetNesnesiOlustur(string kullaniciID, string Diyetadi)
        {
            // KullanıcıID'sine göre  ilgili kullanıcının mevcut diyetinin DiyetID'si alınır.
            string sqlkodu = "select * from Kullanici where KullaniciID=" + kullaniciID + "";
            komut = new OleDbCommand(sqlkodu, baglanti);

            string diyetid = "";

            baglanti.Open();
            oku = komut.ExecuteReader();
            if (oku.Read())
            {
                diyetid = oku[1].ToString();
            }

            baglanti.Close();




            if (diyetid != "0") // diyetID sıfır değil ise diyeti var demektir ve bu diyetin değiştirilmesinin istenirliği sorulur.
            {
                mesaj = MessageBox.Show("Seçtiğiniz Kullanıcının hali hazırda mevcut diyeti bulunmaktadır. Eğer devam ederseniz mevcut diyeti yerine yeni seçimş olduğunuz diyet atanacaktır.  \n Devam Etmek İstiyormusunuz?", "Diyet Atansın mı?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }
            if (diyetid == "0" || mesaj ==DialogResult.Yes)
            {
                //Gelen DiyetAdi'na göre ilgili nesne oluşturulur.
                if (Diyetadi == "Akdeniz")
                {
                    return new AkdenizDiyeti();
                }
                else if (Diyetadi == "Deniz ürünleri")
                {
                    return new DenizUrunleriDiyeti();
                }
                else if (Diyetadi == "Glüten free")
                {
                    return new GluteFreeDiyeti();
                }
                else if (Diyetadi == "Yeşillikler dünyası")
                {
                    return new YesilliklerDunyasiDiyeti();
                }
            }
            return null;

        }

    }
}
