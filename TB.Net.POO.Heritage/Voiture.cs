using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Heritage
{
    public class Voiture : Transport
    {
        public int NbRoues { get; set; }
        public int VitesseMax { get; set; }
        public int NbPlace { get; set; }

        public bool Decapotable { get; set; }
        public bool Autonome { get; set; }

        public int NbPassager
        {
            get { return _nbPassager; }
            set {
                if (value > NbPlace) return;//Gestion d'erreur
                _nbPassager = value;
            }
        }

        public override void SeDeplacer()
        {
            base.SeDeplacer();
            Console.WriteLine($"En roulant sur {this.NbRoues} roues.");
        }

        public new string EmettreUnSon()
        {
            return "Klaxon...";
        }

        public string GetPlaque()
        {
            return GetMatricule();
        }
    }
}
