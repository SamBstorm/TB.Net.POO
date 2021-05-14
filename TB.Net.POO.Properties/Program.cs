using System;

namespace TB.Net.POO.Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //CodeSecret cs = new CodeSecret();
            //cs.Code = 12345;
            //Console.WriteLine(cs.Code);

            Personne p = new Personne();
            p.Gender = "Homme";
            p.BirthDate = new DateTime(1987, 09, 27);
            Console.WriteLine(p.Gender + " " + p.YearsOld);
        }
    }

    public class CodeSecret
    {
        private int _code;

        public int Code
        {
            get {
                Console.WriteLine("Récupération de l'information...");
                return _code;
            }
            set { 
                if(value >=0 && value<= 9999) _code = value; 
            }
        }


    }

    public class Personne
    {
        private bool _gender;
        private DateTime _birthDate;
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string Gender
        {
            get { 
                if (_gender) return "Male";
                return "Female";
            }
            set
            {
                if (value == "Female") _gender = false;
                else _gender = true;
            }
        }

        public int YearsOld
        {
            get
            {
                return DateTime.Now.Year - _birthDate.Year;
            }
        }

        public DateTime BirthDate
        {
            set
            {
                _birthDate = value;
            }
        }
    }
}
