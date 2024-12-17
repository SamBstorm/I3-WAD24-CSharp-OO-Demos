using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo15_Delegate02.Models
{

    public delegate double MathOperation(double[] nbs);
    public class Eleve
    {
        private List<double> _notes = new List<double>();

        private MathOperation _operations;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Eleve(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void AddNote(double note) { 
            _notes.Add(note);
        }
        public void SetOperation(MathOperation operation)
        {
            _operations = operation;
        }

        public double GetResult()
        {
            return _operations(_notes.ToArray());
        }

    }
}
