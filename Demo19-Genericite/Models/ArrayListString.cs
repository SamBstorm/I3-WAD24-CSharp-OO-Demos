using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo19_Genericite.Models
{
    public class ArrayListString
    {
        private ArrayList _list;

        public string this[int index]
        {
            get
            {
                return (string)_list[index];
            }
            set
            {
                _list[index] = value;
            }
        }

        public ArrayListString()
        {
            _list = new ArrayList();
        }

        public void Add(string value) 
        { 
            _list.Add(value);
        }
    }
}
