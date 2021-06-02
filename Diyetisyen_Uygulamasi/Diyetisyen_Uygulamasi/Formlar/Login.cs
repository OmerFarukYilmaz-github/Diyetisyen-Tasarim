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
    public partial class Login : Form
    {

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=diyetisyen.accdb");
        OleDbCommand komut;
        OleDbDataReader oku;
        public Login()
        {
            InitializeComponent();
        }

        private void GirisYapBTN_Click(object sender, EventArgs e)
        {

            string kullaniciTipi="";

            // Login sayfasındaki radiobuttonlara göre giriş yapacak kişinin kullanıcıtipi alınıyor. 

            if(rbtnAdmin.Checked==true) { kullaniciTipi = "Admin"; }
            else if (rbtnDiyetisyen.Checked == true) { kullaniciTipi = "Diyetisyen"; }


            // Login ekranında girilen bilgilere göre veritabanında bir kullanıcı olup  olmadığı kontrol ediliyor.
            baglanti.Open();
            string sqlkodu = "select * from Kullanici where TC=@TC and Sifre=@Sifre and KullaniciTipi=@KullaniciTipi";
            komut = new OleDbCommand(sqlkodu, baglanti);

            komut.Parameters.AddWithValue("@TC", GirisTc_TB.Text);
            komut.Parameters.AddWithValue("@Sifre", GirisSifre_TB.Text);
            komut.Parameters.AddWithValue("@KullaniciTipi", kullaniciTipi);

            oku = komut.ExecuteReader();
            if (oku.Read())  //Eğer girilen bilgilerle uyumlu kullanıcı varsa MainForm açılır.Ve Mainform'agiriş yapan kullanıcınn tipi gönderilir.
            {
                Form4 form4 = new Form4();
                form4.KullaniciTipi = kullaniciTipi;  //Ve Mainform'agiriş yapan kullanıcınn tipi gönderilir.
                form4.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Bilgileriniz Doğru Değil !!! \nLütfen Kullanıcı Tipini, Tc Kimlik Numaranızı ve Şifrenizi Doğru Girdiğinize Emin Olunuz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }


    }
}
