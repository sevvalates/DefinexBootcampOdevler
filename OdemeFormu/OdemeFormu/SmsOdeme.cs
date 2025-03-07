using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu
{
    public class SmsOdeme : IOdemeIslemi
    {
        public string OdemeYap(int tutar)
        {
            return tutar + " TL Sms Odeme ile ödeme yapıldı.";
        }
    }
}
