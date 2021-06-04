using System;
using System.Collections.Generic;

namespace TB.Net.Poo.CtorHeritage
{
    class Program
    {
        static void Main(string[] args)
        {
            PoissonClown pc = new PoissonClown();
            //PoissonCarnivore carn = new PoissonClown();
            //Poisson p = new PoissonClown();
            //EtreVivant ev = new PoissonClown();
            //object o = new PoissonClown();

            //pc = new PoissonCarnivore();
            //pc = new Poisson();
            //pc = new EtreVivant();
            //pc = new object();

            List<Poisson> contenuAquarium = new List<Poisson>();

            contenuAquarium.Add(new Merou());
            contenuAquarium.Add(new PoissonClown());
            contenuAquarium.Add(new Thon());

            foreach (Poisson poisson in contenuAquarium)
            {
                poisson.Nager();
                if (poisson is PoissonClown) {
                    pc = (PoissonClown)poisson;
                    Console.WriteLine($"J'ai un nombre de rayures de {pc.nbRayure}"); 
                }

                switch (poisson)
                {
                    case PoissonClown p_c:
                        break;
                }
            }
        }
    }
}
