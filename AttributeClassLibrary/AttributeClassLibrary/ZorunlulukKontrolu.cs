using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeClassLibrary
{
    public static class ZorunlulukKontrolu
    {
        public static bool Dogrula(object dogrulanacakEntity)
        {
            Type dogrulamacakTur = dogrulanacakEntity.GetType();
            PropertyInfo[] dogrulanacakTurOzellikleri = dogrulamacakTur.GetProperties(
                                                        BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo dogrulanacakOzellik in dogrulanacakTurOzellikleri)
            {
                object[] zorunluAlanOznitelikleri = dogrulanacakOzellik.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);
                if (zorunluAlanOznitelikleri.Length > 0)
                {
                    object deger = dogrulanacakOzellik.GetValue(dogrulanacakEntity);
                    if (deger == null || string.IsNullOrEmpty(deger.ToString()))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
