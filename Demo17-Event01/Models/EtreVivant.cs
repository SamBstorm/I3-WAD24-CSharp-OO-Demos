using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo17_Event01.Models
{
    public delegate void PVChangedHandler(EtreVivant sender, int currentPV);
    public delegate void DeathHandler(EtreVivant sender);
    public abstract class EtreVivant
    {
        public event PVChangedHandler onPVChanged;
        public event DeathHandler onDeath;
        private int _pv;
        public int PV {
            get { return _pv; }
            protected set {
                if(_pv != value)
                {
                    _pv = value;
                    onPVChanged?.Invoke(this, value);
                    if(value == 0)
                    {
                        onDeath?.Invoke(this);
                        onPVChanged = null;
                    }
                }
            }
        }

        protected EtreVivant()
        {
            PV = 10;
        }

        public abstract void Vieillir();
    }
}
