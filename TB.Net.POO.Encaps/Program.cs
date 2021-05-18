using System;

namespace TB.Net.POO.Encaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Login l = new Login { username = "Samuel"};
            l.Password="test1234=";
            Console.WriteLine(  l.username);
            Console.WriteLine(l.CheckPassword("toto"));
        }
    }

    public struct Login
    {
        public string username;
        private string _password;

        public string Password
        {
            private get { return _password; }
            set { _password = value; }
        }

        public bool CheckPassword(string motDePasse)
        {
            return _password == motDePasse;
        }
    }
}
