using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo15_Delegate02.Models
{
    public class CahierDeNotes
    {
        private List<Eleve> _elevesList = new List<Eleve>();

        public Eleve[] Eleves
        {
            get { return _elevesList.ToArray(); }
        }

        public void AddEleve(Eleve nouvelEleve)
        {
            _elevesList.Add(nouvelEleve);
        }

        private double Average(double[] notes)
        {
            /*
            double result = 0;
            foreach (double note in notes)
            {
                result += note;
            }
            return result/notes.Length;*/
            return Sum(notes) / notes.Length;
        }
        private double Sum(double[] notes)
        {
            double result = 0;
            foreach (double note in notes)
            {
                result += note;
            }
            return result;
        }

        public void ShowEveryStudentAverage()
        {
            foreach (Eleve eleve in _elevesList)
            {
                eleve.SetOperation(Average);
                Console.WriteLine($" - {eleve.LastName} {eleve.FirstName} : {eleve.GetResult()}");
            }
        }

        public void ShowEveryStudentSum()
        {
            foreach (Eleve eleve in _elevesList)
            {
                eleve.SetOperation(Sum);
                Console.WriteLine($" - {eleve.LastName} {eleve.FirstName} : {eleve.GetResult()}");
            }
        }
    }
}
