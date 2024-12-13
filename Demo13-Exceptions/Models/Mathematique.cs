using Demo13_Exceptions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo13_Exceptions.Models
{
    internal static class Mathematique
    {
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static int Division(int nb1, int nb2)
        {
            if (nb2 == 0) throw new ArgumentOutOfRangeException();
            return nb1 / nb2;
        }
        /// <summary>
        /// Méthode statique permettant d'obtenir une moyenne de type entier à l'aide d'un tableau de valeurs de type entier.
        /// </summary>
        /// <param name="nombres">Ensemble de valeur soumis en format d'un tableau d'entiers (doit contenir au minimum 1 valeur)</param>
        /// <returns>Nombre entier correspondant à la moyenne d'un ensemble de valeurs.</returns>
        /// <exception cref="ArgumentNullException">Certains paramètres (nombres) ne doivent pas être null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Certains paramètres (nombres) doivent avoir au minimum 1 valeur.</exception>
        public static int Moyenne(int[] nombres)
        {
            if (nombres is null)
            {
                throw new ArgumentNullException(nameof(nombres), "Attention, le paramètre est null.");
            }
            if (nombres.Length <= 1)
            {
                throw new ArgumentArrayNeedValueException(2,nombres.Length,nameof(nombres));
            }
            int somme = 0;
            foreach (int nb in nombres)
            {
                somme += nb;
            }
            return somme/nombres.Length;
        }
    }
}
