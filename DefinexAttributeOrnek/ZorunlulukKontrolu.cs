 using System;
using System.Linq;
using System.Reflection;

namespace DefinexAttributeOrnek
    {
        public static class ZorunlulukKontrolu
        {
            public static bool Dogrula(object dogrulanacakEntity)
            {
                Type dogrulamacakTur = dogrulanacakEntity.GetType();
                PropertyInfo[] dogrulanacakTurOzellikleri = dogrulamacakTur.GetProperties();

                foreach (PropertyInfo property in dogrulanacakTurOzellikleri)
                {
                    if (property.GetCustomAttributes(typeof(ZorunluAlanAttribute), true).Any())
                    {
                        string alanDegeri = property.GetValue(dogrulanacakEntity) as string;
                        if (string.IsNullOrEmpty(alanDegeri))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }



