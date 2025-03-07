using AttributeClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeOgrenciKayıtConsoleApp
{
    public class Ogrenci
    {
        [ZorunluAlan]
        public string Adi { get; set; }
        [ZorunluAlan]
        public string Soyadi { get; set; }
        [ZorunluAlan]
        public string Bolum { get; set; }
    }
}
