using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02_Static
{
    internal static class Mathematics
    {
        public static double nbPi;

        public static double Addition(params double[] nbs)
        {
            double sum = 0;
            foreach (double nb in nbs)
            {
                sum += nb;
            }
            return sum;
        }
    }
}
