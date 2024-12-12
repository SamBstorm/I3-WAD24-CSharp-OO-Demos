using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_Interfaces.Models
{
    internal interface ICouler
    {
        bool EstCoule { get; }
        void Couler();
    }
}
