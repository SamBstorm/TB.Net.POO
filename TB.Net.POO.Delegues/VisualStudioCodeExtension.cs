using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Delegues
{
    public class VisualStudioCodeExtension
    {
        public string Name { get; set; }
        public void Main(string[] args)
        {
            Console.WriteLine($"Exécution de l'extension : {Name}");
        }
    }
}
