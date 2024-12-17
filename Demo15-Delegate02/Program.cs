using Demo15_Delegate02.Models;

namespace Demo15_Delegate02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eleve e1 = new Eleve("Tom", "Holland");
            e1.AddNote(10);
            e1.AddNote(13.25);
            e1.AddNote(8.75);
            e1.AddNote(4.31);

            Eleve e2 = new Eleve("Timothée","Chalamet");
            e2.AddNote(18.30);
            e2.AddNote(16.50);
            e2.AddNote(17.50);
            e2.AddNote(7.50);

            Eleve e3 = new Eleve("Zendaya Maree Stoemer", "Coleman");
            e3.AddNote(18.50);
            e3.AddNote(16.40);
            e3.AddNote(10.0);
            e3.AddNote(4.25);
            e3.AddNote(10.25);

            CahierDeNotes c = new CahierDeNotes();
            c.AddEleve(e1);
            c.AddEleve(e2);
            c.AddEleve(e3);

            c.ShowEveryStudentAverage();
            c.ShowEveryStudentSum();
        }
    }
}
