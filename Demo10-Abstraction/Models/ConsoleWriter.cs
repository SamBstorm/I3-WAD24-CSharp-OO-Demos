using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10_Abstraction.Models
{
    internal abstract class ConsoleWriter : IMessageWriter
    {
        public abstract void Write(string message);
    }
}
