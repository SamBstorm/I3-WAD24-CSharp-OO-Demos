using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo20_Genericite02.Models
{
    public class Usine<T> : IBatiment where T: IUnite, new()
    {
        protected U Produire<U>() where U : T, new()
        {
            return new U();
        }
    }
}
