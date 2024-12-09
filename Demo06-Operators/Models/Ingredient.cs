using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Operators.Models
{
    public class Ingredient
    {
        public string Nom { get; private set; }
        public int ValeurNutritive { get; private set; }

        public Ingredient(string nom, int valeurNutritive) {
            Nom = nom;
            ValeurNutritive = valeurNutritive;
        }

        public static Recette operator +(Ingredient left, Ingredient right){
            Recette nouvelleRecette = new Recette($"{left.Nom} avec {right.Nom}");
            nouvelleRecette.AjouterIngredient(left);
            nouvelleRecette.AjouterIngredient(right);
            return nouvelleRecette;
        }

        public static Recette operator +(Recette left, Ingredient right)
        {
            left.AjouterIngredient(right);
            return left;
        }

        public static int operator *(Ingredient left, int right)
        {
            return left.ValeurNutritive * right;
        }

        public static bool operator ==(Ingredient left, Ingredient right)
        {
            return left.Nom == right.Nom && left.ValeurNutritive == right.ValeurNutritive;
        }

        public static bool operator !=(Ingredient left, Ingredient right)
        {
            return !(left == right);
        }
    }
}
