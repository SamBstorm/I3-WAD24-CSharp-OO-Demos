using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10_Abstraction.Models
{
    internal class ConsoleWriter : IMessageWriter
    {
        public virtual void Write(string message)
        {
            Console.Write(message);
        }
    }
}
