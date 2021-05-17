using System;

namespace TB.Net.POO.Indexeurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d = new Deck();
            d.InitCards();
            Console.WriteLine(d.NbCards);
            Card c = d[CardColor.Coeur, CardValues.As];
            Console.WriteLine(d.NbCards);

            Console.WriteLine(c.Value);
            Console.WriteLine(c.Color);
        }
    }
}
