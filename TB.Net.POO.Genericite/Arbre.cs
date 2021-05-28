using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Genericite
{
    #region Sans généricité
    //public class Pommier
    //{
    //    public int NbFruits { get; set; }

    //    public List<Pomme> Recolter(int nb)
    //    {
    //        NbFruits -= nb;
    //        List<Pomme> recolte = new List<Pomme>();
    //        for(int i=0; i< nb; i++)
    //        {
    //            recolte.Add(new Pomme());
    //        }
    //        return recolte;
    //    }
    //}

    //public class Oranger
    //{
    //    public int NbFruits { get; set; }

    //    public List<Orange> Recolter(int nb)
    //    {
    //        NbFruits -= nb;
    //        List<Orange> recolte = new List<Orange>();
    //        for (int i = 0; i < nb; i++)
    //        {
    //            recolte.Add(new Orange());
    //        }
    //        return recolte;
    //    }
    //} 
    #endregion

    public class Arbre<T> where T : Fruit, new()
    {
        public int NbFruits { get; set; }

        public List<T> Recolter(int nb)
        {
            NbFruits -= nb;
            List<T> recolte = new List<T>();
            for (int i = 0; i < nb; i++)
            {
                T fruit = new T();
                recolte.Add(fruit);
            }
            return recolte;
        }
    }
}
