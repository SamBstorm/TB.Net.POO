using System;
using System.Reflection;

namespace TB.Net.POO.Reflexions
{
    class Program
    {
        static void Main(string[] args)
        {
            MaClassReflechi mcr = new MaClassReflechi();
            mcr.champ_deux = 2;
            mcr.Prop_un = 1;
            mcr.Prop_deux = 3;

            Type t = typeof(MaClassReflechi);
            foreach (var prop in t.GetProperties())
            {
                Console.WriteLine(prop.Name);
            }
            foreach (var field in t.GetFields())
            {
                Console.WriteLine(field.Name);
            }
            Console.WriteLine(t.Assembly);

            (string nom, double age) = ("Legrain", 33);
            Console.WriteLine($"Je me nomme {nom} et j'ai {age} ans.");
            Random RNG = new Random();
            RNG.Next();
        }
    }
}
