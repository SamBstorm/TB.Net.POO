using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Operateurs
{
    public class Pet
    {
        private string _nom;
        private ushort _isHungry;
        private ushort _isHappy;

        public string Nom
        {
            get { return _nom; }
            set {
                string temp = value;
                if (temp.Length > 8) temp = value.Substring(0, 8);
                _nom = temp; 
            }
        }

        public bool IsHungry
        {
            get { return (_isHungry > 0); }
        }

        public void Wait()
        {
            _isHungry += 20;
            _isHappy -= 10;
        }

        public void Eat(Meal meal)
        {
            _isHungry = _isHungry + meal;
        }
    }
}
