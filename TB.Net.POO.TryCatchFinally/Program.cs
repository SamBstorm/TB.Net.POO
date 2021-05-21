using System;

namespace TB.Net.POO.TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            double left, right, result = 0;
            left = default;
            bool isCorrect = false;
            do
            {
                try
                {
                    string input = Console.ReadLine();
                    left = InputNumeric.Input(input);
                    isCorrect = true;
                }
                catch (FormatException error)
                {
                    Console.WriteLine($"Oups, vous avez entré une mauvaise valeur...\n{error.GetType()}\n{error.Message}");
                }
                catch (ArgumentNullException error)
                {
                    Console.WriteLine($"Oups, vous avez oublié d'entrer une valeur...\n{error.GetType()}\n{error.Message}");
                }
                catch (Exception error)
                {
                    Console.WriteLine($"Oups, erreur inconnue...\n{error.GetType()}\n{error.Message}");
                }
            } while (!isCorrect);
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.OemPlus:
                    right = double.Parse(Console.ReadLine());
                    result = Calculatrice.Addition(left, right);
                    break;
                case ConsoleKey.OemMinus:
                    right = double.Parse(Console.ReadLine());
                    result = Calculatrice.Soustraction(left, right);
                    break;
                case ConsoleKey.Oem1:
                    right = double.Parse(Console.ReadLine());
                    result = Calculatrice.Multiplication(left, right);
                    break;
                case ConsoleKey.Oem2:
                    right = double.Parse(Console.ReadLine());
                    result = Calculatrice.Division(left, right);
                    break;
                default:
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
