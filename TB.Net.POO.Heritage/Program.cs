using System;

namespace TB.Net.POO.Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport t = new Transport();
            t.SeDeplacer();
            Console.WriteLine(t.EmettreUnSon());

            Voiture v = new Voiture();
            v.NbRoues = 4;
            v.QuantiteStock = 20;
            v.SeDeplacer();
            Console.WriteLine(v.EmettreUnSon());

            //Transport voiture = new Voiture();
            //voiture.SeDeplacer();   // Je me déplace 4 | Je roule 3
            //Console.WriteLine(  voiture.EmettreUnSon() ); // Bruit         3 | Klaxon   2

        }
    }
}
