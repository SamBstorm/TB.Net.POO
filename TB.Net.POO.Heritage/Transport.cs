using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Heritage
{
    public class Transport
    {
        private string _matricule;
        protected int _nbPassager;
        public string TypeMoteur { get; set; }
        public int QuantiteStock { get; set; }
        public virtual void SeDeplacer()
        {
            Console.WriteLine("Je me déplace");
        }

        public string EmettreUnSon()
        {
            return "Bruit...";
        }

        protected string GetMatricule()
        {
            return _matricule;
        }
    }
}
