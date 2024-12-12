using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_Interfaces.Models
{
    internal class Canoe : IBateau
    {
        public bool EstCoule { get; set; }

        public void Couler()
        {
            if (!EstCoule)
            {
                Console.WriteLine("Zut! Un trou dans mon canoë!");
                EstCoule = true;
            }
        }

        public void Naviguer()
        {
            Console.WriteLine("Je navigue à bord de mon canoë!");
        }
    }
}
