using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;


namespace Diyetisyen_Uygulamasi
{
    public partial class Form4 : Form
    {
       public string KullaniciTipi;


        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e) // Logn ekranında giriş yapan kullanıcının tipi alınır. Ve duruma göre diyetisyen işlemleri için buton görünürlüğü ayarlanır.
        {
            if (KullaniciTipi == "Admin") 
            {
                btnDiyetisyenIslemleri.Visible = true;
                pictureBoxDiyetisyen.Visible = true;
            }
            else
            {
                btnDiyetisyenIslemleri.Visible = false;
                pictureBoxDiyetisyen.Visible = false;
            } 
              
            HastalariListele();
            DiyetisyenleriListele();


        }




        // İsteğe göre bilgiler veritabanından alınır ve ilgili DataGridView'lere yazdırılır.
        #region Listelemeler

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=diyetisyen.accdb");
        OleDbCommand komut;


        private void HastalariListele()
        {
            DataTable tablo = new DataTable();

            baglanti.Open();

            // Veritabanından kullanıcının hangi bilgilerinin alınacağı seçilir.
            string kod = "select KullaniciID, Ad, Soyad, TC, Tel, Yas, Boy, Kilo from Kullanici where KullaniciTipi=@KullaniciTipi";

            komut = new OleDbCommand(kod, baglanti);
            komut.Parameters.AddWithValue("@KullaniciTipi","Hasta" );

            OleDbDataAdapter adp = new OleDbDataAdapter(komut);
            adp.Fill(tablo);

            //Bilgiler ilgili araçlara yazılır.
            HastaDGV.DataSource = tablo;
            HastaDGV2.DataSource = tablo;
            Hasta3DGV.DataSource = tablo;
            raporDGV.DataSource = tablo;
            baglanti.Close();

        }

        private void DiyetisyenleriListele()
        {
            DataTable tablo2 = new DataTable();

            baglanti.Open();

            // Veritabanından kullanıcının hangi bilgilerinin alınacağı seçilir.
            string kod = "select KullaniciID, Ad, Soyad, TC, Tel, Sifre from Kullanici where KullaniciTipi=@KullaniciTipi";

            komut = new OleDbCommand(kod, baglanti);
            komut.Parameters.AddWithValue("@KullaniciTipi", "Diyetisyen");

            OleDbDataAdapter adp= new OleDbDataAdapter(komut);
            adp.Fill(tablo2);

            //Bilgiler ilgili araçlara yazılır.
            DiyetisyenDGV.DataSource = tablo2;
            baglanti.Close();

        }

        private void KullanıcınınHastalığınıListele()
        {
            string hastalikID="";
            DataTable tablo = new DataTable();
            OleDbDataReader oku;

            baglanti.Open();

            // Kullanıcının mevcut hastalıgının hastalikID'i alınır
            string kod = "select * from Kullanici where KullaniciID=" + labelHastaID2.Text+"";
            komut = new OleDbCommand(kod, baglanti);

            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                hastalikID = oku[2].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            // Alınınan hastalikID'sine göre hastalik bilgileri çekilir.
            kod = "select * from Hastalik where HastalikID="+ hastalikID+"";
            komut = new OleDbCommand(kod, baglanti);

            OleDbDataAdapter adp = new OleDbDataAdapter(komut);
            adp.Fill(tablo);

            //Bilgiler ilgili araçlara yazılır.
            HastalikDGV.DataSource = tablo;
            baglanti.Close();
        }

        private void KullanıcınınDiyetiniListele()
        {
            string diyetID = "";
            DataTable tablo = new DataTable();
            OleDbDataReader oku;

            baglanti.Open();

            // Kullanıcının mevcut diyetinin diyetID'si alınır
            string kod = "select * from Kullanici where KullaniciID=" + labelHastaID3.Text + "";
            komut = new OleDbCommand(kod, baglanti);

            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                diyetID = oku[1].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            // Alınınan diyetID'sine göre diyet bilgileri çekilir.
            kod = "select * from Diyet where DiyetID=" + diyetID + "";
            komut = new OleDbCommand(kod, baglanti);

            OleDbDataAdapter adp = new OleDbDataAdapter(komut);
            adp.Fill(tablo);

            //Bilgiler ilgili araçlara yazılır.
            DiyetDGV.DataSource = tablo;
            baglanti.Close();
        }

        #endregion




        // Tıklanan butona göre ilgili panel görünür hale gelir ve diğer paneller görrünmez olur.
        #region Panel Görünürlükleri

        private void PanelGörünürlükleriniAyarla(Boolean HastaPanelOnay, Boolean HastalikPanelOnay, Boolean DiyetisyenPanelOnay, Boolean DiyetPaneliOnay, Boolean RaporPanelOnay)
        {
            HastaPanel.Visible = HastaPanelOnay;
            HastalikPanel.Visible = HastalikPanelOnay;
            Diyetisyen_Panel.Visible = DiyetisyenPanelOnay;
            DiyetPaneli.Visible = DiyetPaneliOnay;
            RaporPanel.Visible = RaporPanelOnay;
        }
      
        private void btnHastaIslemleri_Click(object sender, EventArgs e)
        {
            HastalariListele();
            PanelGörünürlükleriniAyarla(true,false,false,false,false);
           
        }

        private void btnHastalikIslemleri_Click(object sender, EventArgs e)
        {
            HastalariListele();
            PanelGörünürlükleriniAyarla(false, true, false, false, false);
        }

        private void btnDiyet_Islemleri_Click(object sender, EventArgs e)
        {
            HastalariListele();
            PanelGörünürlükleriniAyarla(false, false, false, true, false);
        }

        private void btnDiyetisyenIslemleri_Click(object sender, EventArgs e)
        {
            DiyetisyenleriListele();
            PanelGörünürlükleriniAyarla(false, false, true, false, false);
        }
        private void RaporIslemBTN_Click(object sender, EventArgs e)
        {
            HastalariListele();
            PanelGörünürlükleriniAyarla(false, false, false, false, true);
        }
        #endregion




        // Yeni kullanıcı ekleme fonksiyonları.
        #region Ekle

        //Hasta tipinde ve girilen bilgilerde kullanıcı eklenir.
        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.KullaniciEkle(0,0,"Hasta",HastaEkleAdTB.Text,HastaEkleSoyadTB.Text,HastaEkleTcTB.Text,HastaEkleTelTB.Text,HastaEkleYasTB.Text,HastaEkleBoyTB.Text,HastaEkleKiloTB.Text,"");
        }


        //Diyet tipinde ve girilen bilgilerde kullanıcı eklenir.
        private void btnDiyetisyenEkle_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.KullaniciEkle(0, 0, "Diyetisyen", DEkleAdTB.Text, DEkleSoyadTB.Text, DEkleTcTB.Text, DEkleTelTB.Text, "", "", "", DEkleSifreTB.Text);

        }

        #endregion




        // Tıklanan DataGrid'teki ilgili indislerdeki bilgiler ilgili textboxlara aktarılır.
        #region DataGrid'ten Kutulara Cekme
        private void HastaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelHastaID.Text = HastaDGV.CurrentRow.Cells[0].Value.ToString();
            HastaEkleAdTB.Text = HastaDGV.CurrentRow.Cells[1].Value.ToString();
            HastaEkleSoyadTB.Text = HastaDGV.CurrentRow.Cells[2].Value.ToString();
            HastaEkleTcTB.Text = HastaDGV.CurrentRow.Cells[3].Value.ToString();
            HastaEkleTelTB.Text = HastaDGV.CurrentRow.Cells[4].Value.ToString();
            HastaEkleYasTB.Text = HastaDGV.CurrentRow.Cells[5].Value.ToString();
            HastaEkleBoyTB.Text = HastaDGV.CurrentRow.Cells[6].Value.ToString();
            HastaEkleKiloTB.Text = HastaDGV.CurrentRow.Cells[7].Value.ToString();

            HastalariListele();
        }

        private void HastaDGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelHastaID2.Text= HastaDGV2.CurrentRow.Cells[0].Value.ToString();
            SecilenHastaAdı_TB.Text = HastaDGV2.CurrentRow.Cells[1].Value.ToString();
            SecilenHastaSoyadı_TB.Text = HastaDGV2.CurrentRow.Cells[2].Value.ToString();
            SecilenHastaTc_TB.Text = HastaDGV2.CurrentRow.Cells[3].Value.ToString();

            KullanıcınınHastalığınıListele();
        }

        private void Hasta3DGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            labelHastaID3.Text = Hasta3DGV.CurrentRow.Cells[0].Value.ToString();
            txtDiyetHastaAd.Text = Hasta3DGV.CurrentRow.Cells[1].Value.ToString();
            txtDiyetHastaSoyad.Text = Hasta3DGV.CurrentRow.Cells[2].Value.ToString();
            txtDiyetHastaTc.Text = Hasta3DGV.CurrentRow.Cells[3].Value.ToString();
            KullanıcınınDiyetiniListele();
        }

        private void DiyetisyenDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelDiyetisyenID.Text = DiyetisyenDGV.CurrentRow.Cells[0].Value.ToString();
            DEkleAdTB.Text = DiyetisyenDGV.CurrentRow.Cells[1].Value.ToString();
            DEkleSoyadTB.Text = DiyetisyenDGV.CurrentRow.Cells[2].Value.ToString();
            DEkleTcTB.Text = DiyetisyenDGV.CurrentRow.Cells[3].Value.ToString();
            DEkleTelTB.Text = DiyetisyenDGV.CurrentRow.Cells[4].Value.ToString();
            DEkleSifreTB.Text = DiyetisyenDGV.CurrentRow.Cells[5].Value.ToString();

            DiyetisyenleriListele();

        }

        private void raporDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelRaporID.Text = raporDGV.CurrentRow.Cells[0].Value.ToString();
        }

        #endregion





        #region Hastalık & Diyet Atama
        private void btnHastalıkAta_Click(object sender, EventArgs e) // calısmıyur
        {

            HastalikAtamaFabrikası hastalikAtamaFabrikası = new HastalikAtamaFabrikası();                        // Hastalık fabrikası olusturulur.
            IHastalikAta hastalikAta = hastalikAtamaFabrikası.HastalikNesnesiOlustur(cmbxHastalikAdi.Text);      //Fabrikanın olusturucağı tipteki hastalik adi gönderilir.
            hastalikAta.HastalikAta(labelHastaID2.Text);                                                         // olusturulan hastalik tipi, gönderilen kullanıcının kullanıcıId'sine göre hastalik atanır.
            KullanıcınınHastalığınıListele();
        }

        private void btnDiyetAta_Click_1(object sender, EventArgs e)
        {

            DiyetAtamaFabrikası diyetAtamaFabrikası = new DiyetAtamaFabrikası();                                    // Diyet fabrikası olusturulur.
            IDiyetAta diyetAta = diyetAtamaFabrikası.DiyetNesnesiOlustur(labelHastaID3.Text, cmbxDiyetAdi.Text);    // Fabrikanın olusturucağı tipteki Diyet adi gönderilir.
            diyetAta.DiyetAta(labelHastaID3.Text);                                                                  // olusturulan diyet tipi, gönderilen kullanıcının kullanıcıId'sine göre diyet atanır.
            KullanıcınınDiyetiniListele();

        }

        #endregion




        // İstenilen kullanıcı veritabanından silinir 
        #region Silme
        private void btnHastaSil_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.KullanıcıSil(labelHastaID.Text);
            HastalariListele();
        }

        private void btnDiyetisyenSil_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.KullanıcıSil(labelDiyetisyenID.Text);
            DiyetisyenleriListele();
        }


        #endregion




        // Textboxlardaki bilgilere göre kullanıcı güncellenir.
        #region Güncellemeler
   
        private void btnHastaBilgileriniGüncelle_Click(object sender, EventArgs e)
        {
             Kullanici kullanici = new Kullanici();
            kullanici.KullanıcıGuncelle(labelHastaID.Text, HastaEkleAdTB.Text, HastaEkleSoyadTB.Text, HastaEkleTcTB.Text,
                                        HastaEkleTelTB.Text, HastaEkleYasTB.Text, HastaEkleBoyTB.Text, HastaEkleKiloTB.Text,"");
            HastalariListele();
            
        }
        private void btnDiyetisyenBilgileriniGüncelle_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.KullanıcıGuncelle(labelDiyetisyenID.Text, DEkleAdTB.Text, DEkleSoyadTB.Text, DEkleTcTB.Text,
                                        DEkleTelTB.Text, "", "", "", DEkleSifreTB.Text);
            DiyetisyenleriListele();

        }
      



        #endregion





        #region Raporlama

        private void RaporOlusturBTN_Click(object sender, EventArgs e)
        {
            UyeBilgileriniGetir uyebilgi = new UyeBilgileriniGetir(labelRaporID.Text);
            StreamWriter sw;
            RaporBuilder builder;
            RaporListelemeTipi listelemeTipi;
            string str;
            string dosya;

            RaporBilgi bilgi = new RaporBilgi();                                   //RaporBilgi fonksiyonunu kullanmak için parametre oluşturuluyor.
            bilgi.DiyetAdi = "Diyet Adı : " + uyebilgi.diyetaAdi_Getir();
            bilgi.DiyetAciklama = "Diyet açıklaması :" + uyebilgi.diyetAciklama_Getir();                 //Bilgiler oluşturulan parametre kullanılarak bilgiler gerekli yerlere atanıyor.
            bilgi.DiyetEtki = "Diyet etkisi : " + uyebilgi.diyetEtki_Getir();
            bilgi.Hastalik = "Hastalik Adı : " + uyebilgi.hastalikAdi_Getir();
            bilgi.KisiselBilgiler = new List<string>();                            //RaporBilgi fonksiyonunu kullanmak için list tipinde parametre oluşturuluyor.
            bilgi.KisiselBilgiler.Add("Ad : " + uyebilgi.ad_Getir());
            bilgi.KisiselBilgiler.Add("Soyad : " + uyebilgi.soyad_Getir());
            bilgi.KisiselBilgiler.Add("TC : " + uyebilgi.tc_Getir());                       // Bilgiler oluşturulan parametre kullanılarak bilgiler gerekli yerlere atanıyor.
            bilgi.KisiselBilgiler.Add("Yas : " + uyebilgi.yas_Getir());
            bilgi.KisiselBilgiler.Add("Boy : " + uyebilgi.boy_Getir());

            if (HtmlKaydetRB.Checked == true)
            {

                builder = new HtmlTipindeRaporlama(bilgi);                 //HtmlTipindeRaporlama class'ı için değişken oluşturuluyor ve girilen bilgileri class'a yolluyor.
                listelemeTipi = new RaporListelemeTipi(builder);     //RaporListelemeTipi class'ı için değişken oluşturuyor.

            }
            else
            {

                builder = new JsonTipindeRaporlama(bilgi);                 //HtmlTipindeRaporlama class'ı için değişken oluşturuluyor ve girilen bilgileri class'a yolluyor.
                listelemeTipi = new RaporListelemeTipi(builder);     //RaporListelemeTipi class'ı için değişken oluşturuyor.

            }



            if (IlkKisiselBilgilerRB.Checked == true)                                 //Radio Button'ların seçimine göre listeleme işlemlerini yönlendiriyor.
            {

                str = listelemeTipi.kisiselBilgi();                          //RaporListelemeTipi class'ı için oluşturulan parametreye göre class içerisindeki fonksiyonu çağırıyor.
                dosya = @"C:\Users\HamzaKaya\Desktop\DiyetRapor.html";           //Oluşturulacak dosyanın nereye kaydedileceği belirleniyor.
            }
            else
            {

                str = listelemeTipi.diyetBilgi();                            //RaporListelemeTipi class'ı için oluşturulan parametreye göre class içerisindeki fonksiyonu çağırıyor.
                dosya = @"C:\Users\HamzaKaya\Desktop\DiyetRapor.html";           //Oluşturulacak dosyanın nereye kaydedileceği belirleniyor.

            }

            sw = new StreamWriter(dosya);                          //Dosya parametresi oluşturuluyor.
            sw.WriteLine(str);                                                  //Yazma işlemi gerçekleşiyor.
            sw.Close();                                                         //Dosya işlemleri kapatılıyor.

            MessageBox.Show("Rapor Oluşturulmuştur!");

        }

        #endregion


    }
}