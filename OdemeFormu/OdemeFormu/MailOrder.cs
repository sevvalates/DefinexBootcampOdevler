using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu
{

    public class MailOrder : IOdemeIslemi
    {
        public string OdemeYap(int tutar)
        {
            return tutar + " TL Mail Order ile ödeme yapıldı.";
        }
    }
}
