using Demo_Enum_Rainbow;
using System;

namespace TB.Net.POO.EspaceNom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CommonObject.Contact contact = new CommonObject.Contact();
            contact.FirstName = "Diego";
            contact.LastName = "Bastin";
            contact.BirthDate = new DateTime(1995, 3, 22);
            RainbowUI rain = new RainbowUI();
            rain.WriteLine(contact.FirstName);
        }
    }
}
