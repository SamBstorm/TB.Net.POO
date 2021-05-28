using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Genericite
{
    public class Pomme : Fruit
    {
        public Pomme(): this("Rouge")
        {

        }
        public Pomme(string color)
        {
            Name = "Pomme";
            Color = color;
            IsMultiple = false;
        }
    }
}
