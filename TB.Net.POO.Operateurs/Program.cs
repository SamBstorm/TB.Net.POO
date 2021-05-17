using System;

namespace TB.Net.POO.Operateurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet potitchien = new Pet();
            potitchien.Nom = "Paf";
            potitchien.Wait();
            potitchien.Wait();
            potitchien.Wait();
            potitchien.Wait();

            Meal pate = new Meal() { Nom = "Pâté", NutritiveValue = 200 };
            Meal bonbon = new Meal() { Nom = "Bonbon", NutritiveValue = 20 };
            Meal fruit = new Meal() { Nom = "Pomme", NutritiveValue = 50 };
            Meal sucre = new Meal() { Nom = "Sucre", NutritiveValue = 0 };

            potitchien.Eat(sucre);
            Console.WriteLine($"Potit chien est-il rassasié? {!potitchien.IsHungry}");
            potitchien.Eat(fruit);
            Console.WriteLine($"Potit chien est-il rassasié? {!potitchien.IsHungry}");
            potitchien.Eat(bonbon);
            Console.WriteLine($"Potit chien est-il rassasié? {!potitchien.IsHungry}");
            potitchien.Eat(pate);
            Console.WriteLine($"Potit chien est-il rassasié? {!potitchien.IsHungry}");
        }
    }
}
