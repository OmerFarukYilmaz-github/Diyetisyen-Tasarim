using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyetisyen_Uygulamasi
{
    public abstract class RaporBuilder
    {
        protected RaporBilgi bilgi;
        public RaporBuilder(RaporBilgi raporbilgi)
        {
            bilgi = raporbilgi;
        }
        public string BuildCikti()
        {
            string cikti = BuildHastaBilgileri();
            cikti += BuildDiyetAciklama();
            cikti += BuildDiyetEtki();
            cikti += BuildHastalik();
            return cikti;
        }
        public abstract string BuildHastaBilgileri();
        public abstract string BuildDiyetAciklama();
        public abstract string BuildDiyetEtki();
        public abstract string BuildHastalik();


    }
}
