using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Genericite
{
    public class CartoucheAtari : IJeux
    {
        private string _title;
        public string contenu { get { return $"Atari : {_title}"; }}

        public CartoucheAtari(string title)
        {
            _title = title;
        }
    }
}
