using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.Poo.CtorHeritage
{
    public class PoissonClown : PoissonCarnivore
    {
        public int nbRayure = 4;
        public PoissonClown()
        {
            Console.WriteLine("Je suis un Poisson-clown");
        }
    }
}
