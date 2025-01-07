using Demo18_Event02.Handlers;
using Demo18_Event02.Models;

namespace Demo18_Event02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompteEpargne c1 = new CompteEpargne();
            c1.OnOperation += NotifiedOparetion;
            c1.Depot(500M);
            c1.Retrait(750M);
            c1.CalculInteret();

        }

        static void NotifiedOparetion(object sender, EventArgs args)
        {
            OperationEventArgs opArgs = (OperationEventArgs) args;
            Console.WriteLine($"L'opération de {opArgs.OperationName} a été effectué avec succès!\nVotre nouveau solde est de {((Compte)sender).Solde} euro(s).");
        }
    }
}
