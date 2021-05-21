using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Exceptions
{
    public static class ClassEloignee
    {
        /// <summary>
        /// Récupère seulement les valeurs paires
        /// </summary>
        /// <param name="input">Valeur au format texte</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">input null</exception>
        /// <exception cref="System.FormatException">input au mauvais format</exception>
        /// <exception cref="TB.Net.POO.Exceptions.BadValueException">input impair</exception>
        public static int GetPair(string input)
        {
            if (input is null) throw new ArgumentNullException();
            if (input == "") throw new FormatException();
            int i = int.Parse(input);
            if (i % 2 != 0) throw new BadValueException("La valeur doit être pair", i);
            return i;
        }
    }
}
