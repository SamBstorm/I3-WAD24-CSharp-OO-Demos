namespace Demo12_IDisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (TalkieWalkie tw1 = new TalkieWalkie("Samuel"), tw2 = new TalkieWalkie("Les wads"))
            {
                tw1.EmettreMessage("Bonjour à vous les Wad!");
                tw2.EmettreMessage("Bonjour Samuel!");
                tw1.EmettreMessage("Les destructeurs, c'est pas top!");
                tw1.EmettreMessage("Préférez les variables IDisposable!");
                tw2.EmettreMessage("Tu as raison! Nous ne ferons pas de destructeur!");
            }
        }
    }
}
