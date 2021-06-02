using System.Windows.Forms;
using System.Data.OleDb;

namespace Diyetisyen_Uygulamasi
{
    class Seker : IHastalikAta
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=diyetisyen.accdb");
        OleDbCommand komut;
        public bool HastalikAta(string kullaniciID)
        {
            return SekerAta(kullaniciID);
        }
        private bool SekerAta(string kullaniciID)
        {
            baglanti.Open();
            string sqlkodu = "update Kullanici set [HastalikID]=@HastalikID where KullaniciID=" + kullaniciID + "";

            komut = new OleDbCommand(sqlkodu, baglanti);
            komut.Parameters.AddWithValue("@HastalikID", "2");

            if (komut.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Hastalik atamaası Basraılı!");
            }

            baglanti.Close();
            return true;
        }
    }
}
