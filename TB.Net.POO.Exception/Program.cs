using System;

namespace TB.Net.POO.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PetitJeu.Jouer();
                byte b ;
                object o = 1400;
                b = (byte)o;
            }
            catch (BadValueException e)
            {
                Console.WriteLine($"Erreur personnalisé : {e.Message} - {e.Value}");
                Console.WriteLine(e);
            }      
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e);
            }

        }
    }
}
