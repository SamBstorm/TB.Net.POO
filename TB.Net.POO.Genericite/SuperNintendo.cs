using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Genericite
{
    public class SuperNintendo : IConsoleDeJeux<CartoucheSuperNintendo>
    {
        public void Jouer(CartoucheSuperNintendo jeux)
        {
            Console.WriteLine($"Je joue sur Super Nintendo : {jeux.contenu}");
        }
    }
}
