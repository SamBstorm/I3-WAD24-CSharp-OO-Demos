using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Abstract.Models
{
    public class Tigre : Animal
    {
        public override void Crier()
        {
            Console.WriteLine("Graaooowwww!");
            Console.WriteLine("Je suis un tigre!");
        }
    }
}
