using Demo18_Event02.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo18_Event02.Models
{
    //public delegate void OperationHandler(string operationName, decimal nouveauSolde);
    public class Compte
    {
        public event EventHandler OnOperation;
        public decimal Solde { get; protected set; }

        public Compte()
        {
            Solde = 1000M;
        }

        public void Depot(decimal montant)
        {
            Solde += montant;
            OnOperationRaise("Dépot");
        }

        public void Retrait(decimal montant)
        {
            Solde -= montant;
            OnOperationRaise("Retrait");
        }

        protected void OnOperationRaise(string operationName)
        {
            OperationEventArgs args = new OperationEventArgs()
            {
                OperationName = operationName
            };
            OnOperation?.Invoke(this, args);
        }
    }
}
