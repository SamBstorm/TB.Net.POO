using System;
using System.Collections.Generic;

namespace TB.Net.POO.DelegateGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> {
                "Diego",
                "Fabienne",
                "Dylan",
                "Jean-Michel",
                "Amaury",
                "Constantin",
                "Laetitia",
                "Olivier C.",
                "Olivier B.",
                "Bike",
                "Jeremy",
                "Denis"
            };

            List<string> result = new List<string>();
            foreach (string name in names)
            {
                if (name.Length >= 8) result.Add(name);
            }

            List<string> result2 = new List<string>();
            foreach (string name in names)
            {
                if (name.ToUpper()[0] == 'C') result2.Add(name);
            }

            List<string> result3 = new List<string>();
            foreach (string name in names)
            {
                if (name.Length % 2 == 0) result3.Add(name);
            }

            var res_1 = Filter<string>(names, delegate (string value) { return value.Length >= 8; });
            var res_2 = Filter<string>(names, delegate (string value) { return value.ToUpper()[0] == 'C'; });
            var res_3 = Filter<string>(names, delegate (string value) { return value.Length % 2 == 0; });
            Filter<string>(names, (v) => v.Length % 2 == 0);


        }

        static List<T> Filter<T>(List<T> source,Func<T,bool> filter)
        {
            List<T> result = new List<T>();
            foreach (T value in source)
            {
                if (filter(value)) result.Add(value);
            }
            return result;
        }
    }
}
