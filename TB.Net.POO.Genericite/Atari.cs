using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Genericite
{
    public class Atari : IConsoleDeJeux<CartoucheAtari>
    {
        public void Jouer(CartoucheAtari jeux)
        {
            Console.WriteLine($"Je joue sur Atari à un jeu : {jeux.contenu}.");
        }
    }
}
