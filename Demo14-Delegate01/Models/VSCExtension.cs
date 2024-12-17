using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo14_Delegate01.Models
{
    public class VSCExtension
    {
        public string Name { get; private set; }

        public VSCExtension(string name)
        {
            Name = name;
        }

        public void InitExtension()
        {
            Console.WriteLine($"Extension {Name} démarre...");
        }

        public void StopExtension()
        {
            Console.WriteLine($"Arrêt de l'extension {Name}.");
        }
    }
}
