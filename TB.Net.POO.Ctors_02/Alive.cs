using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Ctors_02
{
    public class Alive
    {
        private ushort _hp;
        public string Name { get; set; }

        //public Alive()
        //{
        //    _hp = 20;
        //    Name = "Random";
        //}

        public Alive(string name, ushort health_point = 20)
        {
            _hp = health_point;
            Name = name;
        }

    }
}
