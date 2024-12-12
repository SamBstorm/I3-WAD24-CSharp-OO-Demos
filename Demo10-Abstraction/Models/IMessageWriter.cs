using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10_Abstraction.Models
{
    internal interface IMessageWriter
    {
        void Write(string message);
    }
}
