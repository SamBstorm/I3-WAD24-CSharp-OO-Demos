using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo13_Exceptions.Exceptions
{
    internal class ArgumentArrayNeedValueException : ArgumentOutOfRangeException
    {
        public int MinValueRequired { get; private set; }
        public int CurrentQuantityValues {  get; private set; }

        public ArgumentArrayNeedValueException(int minValue, int currentQtyValues) : this (minValue, currentQtyValues, "unknow argument")
        {
        }

        public ArgumentArrayNeedValueException(int minValue, int currentQtyValues, string parameterName) : this(minValue, currentQtyValues, parameterName, "La quantité de valeur du tableau n'est pas suffisante pour le traiter")
        {
        }

        public ArgumentArrayNeedValueException(int minValue, int currentQtyValues, string parameterName, string message) : base(parameterName, message)
        {
            MinValueRequired = minValue;
            CurrentQuantityValues = currentQtyValues;
        }
    }
}
