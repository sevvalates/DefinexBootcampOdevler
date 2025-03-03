using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu
{
    public class OdemeIslemiFactory
    {

        public IOdemeIslemi GetInstance(string classname)
        {
            var newClass = Assembly.GetAssembly(typeof(IOdemeIslemi)).CreateInstance("OdemeFormu." + classname);
            return (IOdemeIslemi)newClass;
        }

    }

}
