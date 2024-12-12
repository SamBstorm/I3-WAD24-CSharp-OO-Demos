using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_Interfaces.Models
{
    internal class VehiculeAmphibie : Voiture, IBateau
    {
        public bool EstCoule { get; set; }
        public VehiculeAmphibie(string matricule) : base(matricule)
        {
        }
        public void Couler()
        {
            if (!EstCoule)
            {
                Console.WriteLine("De l'eau rentre dans l'habitacle!");
                EstCoule = true;
            }
        }

        public void Naviguer()
        {
            Console.WriteLine("Miracle! Elle flotte!");
        }
    }
}
