using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Reflexions
{
    public class MaClassReflechi
    {
        private int _champ_un;
        public int champ_deux;
        public int Prop_un { 
            get { return _champ_un; }
            set { _champ_un = value; }
        }

        public int Prop_deux { get; set; }
    }
}
