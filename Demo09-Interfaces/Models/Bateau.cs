using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_Interfaces.Models
{
    internal class Bateau : IBateau
    {
        public string Matricule { get; set; }

        public bool EstCoule { get; private set; }

        public Bateau(string matricule)
        {
            Matricule = matricule;
            EstCoule = false;
        }
        public void Naviguer()
        {
            Console.WriteLine("Je navigue sur mon bateau!");
        }

        public void Couler()
        {
            if(!EstCoule)
            {
                Console.WriteLine("Je coule!");
                EstCoule = true;
            }
        }
    }
}
