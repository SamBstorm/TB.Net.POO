using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Exceptions
{
    public static class PetitJeu
    {
        /// <summary>
        /// Lance un jeu de devinette de chiffre paire
        /// </summary>
        /// <exception cref="System.ArgumentNullException">input null</exception>
        /// <exception cref="System.FormatException">input au mauvais format</exception>
        /// <exception cref="TB.Net.POO.Exceptions.BadValueException">input impair</exception>
        public static void Jouer()
        {
            Console.WriteLine("Veuillez entrer un valeur numérique paire :");
            if (ClassEloignee.GetPair(Console.ReadLine()) % 2 != 0) Console.WriteLine("Perdu");
            else Console.WriteLine("Gagné!");

        }
    }
}
