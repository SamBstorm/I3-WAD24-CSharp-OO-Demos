using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11_InterfaceFiltre.Models
{
    internal interface IAttackable
    {
        bool FireOn(int posX, int posY);
    }
}
