using System;

namespace TB.Net.POO.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfApp = "Web";
            ILog log;
            switch (typeOfApp)
            {
                case "Windows":
                    log = new LogWindows();
                    break;
                case "Web":
                    log = new LogWebService();
                    break;
                default:
                    log = new LogWindows();
                    break;
            }

            log.WriteError("Crash surprise", "Grave", DateTime.Now);
            ILogError lerror = new LogWebService();

            lerror.WriteError("Message d'erreur seulement disponible", "Marrant", DateTime.Now);
        }
    }
}
