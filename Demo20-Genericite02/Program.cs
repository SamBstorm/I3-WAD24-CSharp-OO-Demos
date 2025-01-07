using Demo20_Genericite02.Models;

namespace Demo20_Genericite02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Barraque barraque = new Barraque();

            List<Soldat> troupes = new List<Soldat>();

            troupes.Add(barraque.CreerOfficier());
            //Pas compatible, nos Chars (U) ne sont pas d'lhéritage du Soldat (T)
            //troupes.Add(barraque.Produire<Models.Char>());
            for (int i = 0; i < 10; i++)
            {
                troupes.Add(barraque.CreerSoldat());
            }

            foreach (IUnite unite in troupes)
            {
                Console.WriteLine(unite);
            }

            UsineVehicule usine = new UsineVehicule();
            Models.Char tank = usine.CreerChar();
        }
    }
}
