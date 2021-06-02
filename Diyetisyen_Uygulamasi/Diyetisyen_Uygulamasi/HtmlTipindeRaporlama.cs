using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyetisyen_Uygulamasi
{
    public class HtmlTipindeRaporlama: RaporBuilder
    {
        public HtmlTipindeRaporlama(RaporBilgi raporBilgi) : base(raporBilgi) { }
        public override string BuildDiyetAciklama()
        {
            return string.Format("<p>{0}</p>",this.bilgi.DiyetAciklama);
        }
        public override string BuildDiyetEtki()
        {
            return string.Format("<p>{0}</p>", this.bilgi.DiyetEtki);
        }
        public override string BuildHastalik()
        {
            return string.Format("<p>{0}</p>", this.bilgi.Hastalik);
        }
        public override string BuildHastaBilgileri()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var KisiselBilgiler in base.bilgi.KisiselBilgiler)
            {
                sb.Append(string.Format("<div>{0}</div>",KisiselBilgiler));
            }
            return sb.ToString();
        }
    }
}
