using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Diyetisyen_Uygulamasi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void HastaIslemBTN_Click(object sender, EventArgs e)
        {
            HastaPanel.Visible = true;
            DiyetPanel.Visible = false;
            HastalikPanel.Visible = false;
            DiyetisyenPanel.Visible = false;
            RaporPanel.Visible = false;
        }

        private void DiyetIslemBTN_Click(object sender, EventArgs e)
        {
            HastaPanel.Visible = false;
            DiyetPanel.Visible = true;
            HastalikPanel.Visible = false;
            DiyetisyenPanel.Visible = false;
            RaporPanel.Visible = false;

        }

        private void HastalikIslemBTN_Click(object sender, EventArgs e)
        {
            HastaPanel.Visible = false;
            DiyetPanel.Visible = false;
            HastalikPanel.Visible = true;
            DiyetisyenPanel.Visible = false;
            RaporPanel.Visible = false;

        }

        private void DiyetisyenIslemBTN_Click(object sender, EventArgs e)
        {
            HastaPanel.Visible = false;
            DiyetPanel.Visible = false;
            HastalikPanel.Visible = false;
            DiyetisyenPanel.Visible = true;
            RaporPanel.Visible = false;

        }

        private void RaporIslemBTN_Click(object sender, EventArgs e)
        {
            HastaPanel.Visible = false;
            DiyetPanel.Visible = false;
            HastalikPanel.Visible = false;
            DiyetisyenPanel.Visible = false;
            RaporPanel.Visible = true;   
        }

        private void RaporOlusturBTN_Click(object sender, EventArgs e)
        {
            if (HtmlKaydetRB.Checked==true)
            {
                RaporBilgi bilgi = new RaporBilgi();                                   //RaporBilgi fonksiyonunu kullanmak için parametre oluşturuluyor.
                bilgi.DiyetAciklama = "Diyet açıklaması dlfjghjldfhgldj";              
                bilgi.DiyetEtki = "Diyet etkisi sşfkhgdfjghdfgkhfd";                   //Bilgiler oluşturulan parametre kullanılarak bilgiler gerekli yerlere atanıyor.
                bilgi.Hastalik = "Hastalik bilgileri dslfghdıuhgsdlkgh";
                bilgi.KisiselBilgiler = new List<string>();                            //RaporBilgi fonksiyonunu kullanmak için list tipinde parametre oluşturuluyor.
                bilgi.KisiselBilgiler.Add("Ad : adı falan filan");
                bilgi.KisiselBilgiler.Add("Soyad : Soyad falan filan");
                bilgi.KisiselBilgiler.Add("TC : TC falan filan");                      // Bilgiler oluşturulan parametre kullanılarak bilgiler gerekli yerlere atanıyor.
                 bilgi.KisiselBilgiler.Add("Yas : Yas falan filan");
                bilgi.KisiselBilgiler.Add("Boy : Boy falan filan");
                RaporBuilder builder = new HtmlTipindeRaporlama(bilgi);                 //HtmlTipindeRaporlama class'ı için değişken oluşturuluyor ve girilen bilgileri class'a yolluyor.
                RaporListelemeTipi listelemeTipi = new RaporListelemeTipi(builder);     //RaporListelemeTipi class'ı için değişken oluşturuyor.
                if (IlkKisiselBilgilerRB.Checked==true)                                 //Radio Button'ların seçimine göre listeleme işlemlerini yönlendiriyor.
                {
                    string str = listelemeTipi.kisiselBilgi();                          //RaporListelemeTipi class'ı için oluşturulan parametreye göre class içerisindeki fonksiyonu çağırıyor.
                    string dosya = @"C:\Users\HamzaKaya\Desktop\deneme.html";           //Oluşturulacak dosyanın nereye kaydedileceği belirleniyor.
                                   
                    StreamWriter sw = new StreamWriter(dosya);                          //Dosya parametresi oluşturuluyor.

                    sw.WriteLine(str);                                                  //Yazma işlemi gerçekleşiyor.
                    sw.Close();                                                         //Dosya işlemleri kapatılıyor.
                }
                else
                {
                    string str = listelemeTipi.diyetBilgi();                            //RaporListelemeTipi class'ı için oluşturulan parametreye göre class içerisindeki fonksiyonu çağırıyor.
                    string dosya = @"C:\Users\HamzaKaya\Desktop\deneme.html";           //Oluşturulacak dosyanın nereye kaydedileceği belirleniyor.

                    StreamWriter sw = new StreamWriter(dosya);                          //Dosya parametresi oluşturuluyor.

                    sw.WriteLine(str);                                                  //Yazma işlemi gerçekleşiyor.
                    sw.Close();                                                         //Dosya işlemleri kapatılıyor.
                }
            }
            else
            {
                RaporBilgi bilgi = new RaporBilgi();                                    //RaporBilgi fonksiyonunu kullanmak için parametre oluşturuluyor.
                bilgi.DiyetAciklama = "Diyet açıklaması dlfjghjldfhgldj";
                bilgi.DiyetEtki = "Diyet etkisi sşfkhgdfjghdfgkhfd";                    //Bilgiler oluşturulan parametre kullanılarak bilgiler gerekli yerlere atanıyor.
                bilgi.Hastalik = "Hastalik bilgileri dslfghdıuhgsdlkgh";
                bilgi.KisiselBilgiler = new List<string>();                             //RaporBilgi fonksiyonunu kullanmak için list tipinde parametre oluşturuluyor.
                bilgi.KisiselBilgiler.Add("Ad : adı falan filan");
                bilgi.KisiselBilgiler.Add("Soyad : Soyad falan filan");
                bilgi.KisiselBilgiler.Add("TC : TC falan filan");                       //Bilgiler oluşturulan parametre kullanılarak bilgiler gerekli yerlere atanıyor.
                bilgi.KisiselBilgiler.Add("Yas : Yas falan filan");
                bilgi.KisiselBilgiler.Add("Boy : Boy falan filan");
                RaporBuilder builder = new JsonTipindeRaporlama(bilgi);                 //HtmlTipindeRaporlama class'ı için değişken oluşturuluyor ve girilen bilgileri class'a yolluyor.
                RaporListelemeTipi listelemeTipi = new RaporListelemeTipi(builder);     //RaporListelemeTipi class'ı için değişken oluşturuyor.
                if (IlkKisiselBilgilerRB.Checked == true)                               //Radio Button'ların seçimine göre listeleme işlemlerini yönlendiriyor.
                {
                    string str = listelemeTipi.kisiselBilgi();                          //RaporListelemeTipi class'ı için oluşturulan parametreye göre class içerisindeki fonksiyonu çağırıyor.
                    string dosya = @"C:\Users\HamzaKaya\Desktop\deneme.json";           //Oluşturulacak dosyanın nereye kaydedileceği belirleniyor.

                    StreamWriter sw = new StreamWriter(dosya);                          //Dosya parametresi oluşturuluyor.

                    sw.WriteLine(str);                                                  //Yazma işlemi gerçekleşiyor.
                    sw.Close();                                                         //Dosya işlemleri kapatılıyor.
                }
                else
                {
                    string str = listelemeTipi.diyetBilgi();                            //RaporListelemeTipi class'ı için oluşturulan parametreye göre class içerisindeki fonksiyonu çağırıyor.
                    string dosya = @"C:\Users\HamzaKaya\Desktop\deneme.json";           //Oluşturulacak dosyanın nereye kaydedileceği belirleniyor.

                    StreamWriter sw = new StreamWriter(dosya);                          //Dosya parametresi oluşturuluyor.

                    sw.WriteLine(str);                                                  //Yazma işlemi gerçekleşiyor.
                    sw.Close();                                                         //Dosya işlemleri kapatılıyor.
                }
            }   
        }
    }
}
