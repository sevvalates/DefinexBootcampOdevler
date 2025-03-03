using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu
{
    public class OdemeIslemi
    {
        public IOdemeIslemi iOdemeIslemi;

        public OdemeIslemi(IOdemeIslemi iOdemeIslemi)
        {
            this.iOdemeIslemi = iOdemeIslemi;
        }

        public string Ode(int tutar)
        {
            return iOdemeIslemi.OdemeYap(tutar);
        }
    }
}
