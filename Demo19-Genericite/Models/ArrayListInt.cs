using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo19_Genericite.Models
{
    public class ArrayListInt
    {
        private ArrayList _list;

        public int this[int index]
        {
            get
            {
                return (int)_list[index];
            }
            set
            {
                _list[index] = value;
            }
        }

        public ArrayListInt()
        {
            _list = new ArrayList();
        }

        public void Add(int value)
        {
            _list.Add(value);
        }
    }
}
