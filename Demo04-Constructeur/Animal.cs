using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Constructeur
{
    internal class Animal
    {
        public string Nom { get; set; }
        public int PointDeVie { get; private set; }
        public int PointDeBonheur { get; private set; }
        private List<string> _jouets;
        public string[] Jouets
        {
            get { return _jouets.ToArray(); }
        }

        public Animal(string nom) : this(nom, 10, 3, new string[0])
        {
        }

        public Animal(string nom, int pv, int pb, string[] jouets) {
            _jouets = new List<string>(jouets);
            PointDeVie = pv;
            PointDeBonheur = pb;
            Nom = nom;
        }

        public void Jouer(string jouet)
        {
            if (jouet is null) return;
            if (_jouets.Contains(jouet)) PointDeBonheur++;
            else PointDeBonheur--;
            /*OU
            PointDeBonheur += (_jouets.Contains(jouet)) ? PointDeBonheur + 1 : PointDeBonheur - 1;
            */
            /*OU
            PointDeBonheur += (_jouets.Contains(jouet)) ? 1 : -1;
            */
        }

        public void OffrirJouet(string jouet)
        {
            if (jouet is null)
            {
                PointDeBonheur = 0;
                return;
            }
            if (_jouets.Contains(jouet)) PointDeBonheur++;
            else
            {
                PointDeBonheur += 2;
                _jouets.Add(jouet);
            }
        }

        public void Manger()
        {
            PointDeVie++;
        }

    }
}
