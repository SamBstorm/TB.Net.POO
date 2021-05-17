using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Operateurs
{
    public class Meal
    {
        public string Nom { get; set; }
        public ushort NutritiveValue { get; set; }

        public static ushort operator +(ushort hungryValue, Meal meal)
        {
            int result = hungryValue - meal.NutritiveValue;
            return (ushort)((result <0)?0:result);
        }
    }
}
