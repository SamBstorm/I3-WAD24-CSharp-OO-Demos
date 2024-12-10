using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Abstract.Models
{
    public sealed class Chat : Animal
    {
        public override void Crier()
        {
            Console.WriteLine("Miaaaouuu!"); ;
        }
    }
}
