using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo19_Genericite.Models
{
    public class ArrayListGeneric<T>
    {
        private ArrayList _list;

        public T this[int index]
        {
            get
            {
                return (T)_list[index];
            }
            set
            {
                _list[index] = value;
            }
        }

        public ArrayListGeneric()
        {
            _list = new ArrayList();
        }

        public void Add(T value)
        {
            _list.Add(value);
        }
    }
}
