using System;

namespace TB.Net.POO.Statique
{
    class Program
    {
        static void Main(string[] args)
        {
            Twingo class1 = new Twingo();
            Twingo class2 = new Twingo();

            class1.Couleur = Couleur.rouge;
            class2.Couleur = Couleur.bleu;

            Velo.NbRoue = 2;
            Twingo.NbRoue = 4;

            class1.SeDeplacer();
            class2.SeDeplacer();
            Twingo.NbRoue = 3;

            class1.SeDeplacer();
            class2.SeDeplacer();

            Velo v = new Velo();
            v.SeDeplacer();

        }
    }

    public abstract class Vehicule
    {
        public static int NbRoue { get; set; }
        public abstract void SeDeplacer();
    }

    public enum Couleur { rouge, bleu }

    public class Twingo
    {
        public static int NbRoue { get; set; }
        public Couleur Couleur { get; set; }

        public void SeDeplacer()
        {
            Console.WriteLine($"Je roule avec ma Twingo de couleur {this.Couleur.ToString()} avec ses {Twingo.NbRoue} roues.");
        }
    }

    public class Velo
    {
        public static int NbRoue { get; set; }
        public void SeDeplacer()
        {
            Console.WriteLine($"Je roule avec mon vélo avec ses {Velo.NbRoue} roues.");
        }
    }
}
