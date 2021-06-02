using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyetisyen_Uygulamasi
{
    public class RaporListelemeTipi
    {
        private RaporBuilder Builder;
        public RaporListelemeTipi(RaporBuilder builder)
        {
            Builder = builder;
        }
        public string kisiselBilgi()
        {
            string cikti = Builder.BuildCikti();
            return cikti;
        }
        public string diyetBilgi()
        {
            string cikti = Builder.BuildDiyetAciklama();
            cikti += Builder.BuildDiyetEtki();
            cikti += Builder.BuildHastalik();
            cikti += Builder.BuildHastaBilgileri();
            return cikti;
        }
    }
}
