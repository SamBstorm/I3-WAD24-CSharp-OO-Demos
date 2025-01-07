using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo18_Event02.Handlers
{
    public class OperationEventArgs : EventArgs
    {
        public string OperationName { get; set; }
    }
}
