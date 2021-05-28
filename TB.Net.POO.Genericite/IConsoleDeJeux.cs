using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Genericite
{
    public interface IConsoleDeJeux<TJeux> where TJeux : IJeux
    {
        void Jouer(TJeux jeux);
    }
}
