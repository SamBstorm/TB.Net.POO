namespace TB.Net.Poo.CtorHeritage
{
    public class Poisson : EtreVivant
    {
        public Poisson()
        {
            System.Console.WriteLine("Je suis un Poisson");
        }

        public void Nager()
        {
            System.Console.WriteLine("Je suis heureux, je nage!");
        }
    }
}