using System;

namespace TB.Net.POO.Genericite
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Demo Fruits
            /*Arbre<Pomme> pommier = new Arbre<Pomme>();
                pommier.NbFruits = 5;
                var recolte_pommier  = pommier.Recolter(4);
                Arbre<Orange> oranger = new Arbre<Orange>();
                oranger.NbFruits = 3;
                var recolte_oranger = oranger.Recolter(1);
                */

            //Arbre<string> stringier = new Arbre<string>(); plus possible car seul les fruits sont valides grace au "where"
            #endregion

            #region Demo Interface ConsoleDeJeux

            Atari a = new Atari();
            IJeux j1 = new CartoucheAtari("Wolfenstein");
            IJeux j2 = new CartoucheSuperNintendo("Super Mario Kart");
            a.Jouer((CartoucheAtari)j1);

            SuperNintendo SNES = new SuperNintendo();
            SNES.Jouer((CartoucheSuperNintendo)j2);
            #endregion
        }
    }
}
