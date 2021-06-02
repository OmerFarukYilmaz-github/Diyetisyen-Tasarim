

namespace Diyetisyen_Uygulamasi
{
    class HastalikAtamaFabrikası //Gelen hastalikAdi'na göre ilgili nesne oluşturulur.
    {
        public IHastalikAta HastalikNesnesiOlustur(string HastalikAdi)
        {
            if (HastalikAdi == "Obezite")
            {
                return new Obezite();
            }
            else if (HastalikAdi == "Çölyak")
            {
                return new Cölyak();
            }
            else if (HastalikAdi == "Şeker")
            {
                return new Seker();
            }
            else return null;
        }
    }
}
