using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Genericite
{
    public class CartoucheSuperNintendo : IJeux
    {
        private string _title;
        public string contenu { get { return $"Super Nintendo : {_title}"; } }
        public CartoucheSuperNintendo(string title)
        {
            _title = title;
        }
    }
}
