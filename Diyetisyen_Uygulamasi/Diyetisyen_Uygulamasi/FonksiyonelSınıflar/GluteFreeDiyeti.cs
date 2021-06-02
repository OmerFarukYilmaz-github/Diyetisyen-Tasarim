using System.Windows.Forms;
using System.Data.OleDb;

namespace Diyetisyen_Uygulamasi
{
    class GluteFreeDiyeti : IDiyetAta
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=diyetisyen.accdb");
        OleDbCommand komut;
        public bool DiyetAta(string kullaniciID)
        {
            return GluteFreeDiyetiAta(kullaniciID);
        }
        private bool GluteFreeDiyetiAta(string kullaniciID)
        {
            baglanti.Open();

            string sqlkodu = "update Kullanici set [DiyetID]=@DiyetID where KullaniciID=" + kullaniciID + "";

            komut = new OleDbCommand(sqlkodu, baglanti);
            komut.Parameters.AddWithValue("@DiyetID", "3");

            if (komut.ExecuteNonQuery() > 0) { MessageBox.Show("Diyet atandı"); }
            baglanti.Close();
            return true;
        }
    }
}