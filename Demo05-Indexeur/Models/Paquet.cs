using Demo05_Indexeur.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05_Indexeur.Models
{
    public class Paquet
    {
        private List<Carte> _cartes;

        public Carte this[int index]
        {
            get {
                Carte c = _cartes[index];
                _cartes.Remove(c);
                return c;
            }
            private set {
                _cartes[index] = value;
            }
        }

        public Carte? this[ValeurCarte valeur, CouleurCarte couleur]
        {
            get
            {
                foreach (Carte carte in _cartes)
                {
                    if (carte.Couleur == couleur && carte.Valeur == valeur)
                    {
                        _cartes.Remove(carte);
                        return carte;
                    }
                }
                return null;
            }
        }

        public int Count
        {
            get { return _cartes.Count; }
        }

        public Paquet()
        {
            _cartes = new List<Carte>();
            foreach (CouleurCarte couleur in Enum.GetValues<CouleurCarte>())
            {
                foreach (ValeurCarte valeur in Enum.GetValues<ValeurCarte>())
                {
                    _cartes.Add(new Carte(couleur, valeur));
                }
            }
        }
    }
}
