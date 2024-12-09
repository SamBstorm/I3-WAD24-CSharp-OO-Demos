using Demo05_Indexeur.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05_Indexeur.Models
{
    public class Carte
    {
        private CouleurCarte _couleur;
        private ValeurCarte _valeur;
        public CouleurCarte Couleur
        {
            get { return _couleur; }
        }
        public ValeurCarte Valeur
        {
            get { return _valeur; }
        }
        public Carte(CouleurCarte couleur, ValeurCarte valeur)
        {
            _couleur = couleur;
            _valeur = valeur;
        }
    }
}
