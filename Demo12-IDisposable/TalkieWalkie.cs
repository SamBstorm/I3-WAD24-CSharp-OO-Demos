namespace Demo12_IDisposable
{
    internal class TalkieWalkie : IDisposable
    {
        public string UserName { get; set; }

        public TalkieWalkie(string userName)
        {
            UserName = userName;
        }
        public void EmettreMessage(string message)
        {
            Console.WriteLine($"{UserName} {DateTime.Now.ToShortTimeString()} : {message}");
            Console.WriteLine("À vous!");
        }
        public void Dispose()
        {
            Console.WriteLine($"C'était {UserName} : Terminé! {DateTime.Now.ToShortTimeString()}");
        }
        /*DESTRUCTEUR A NE PLUS UTILISER
        ~TalkieWalkie()
        {
            Dispose();
        }
        */
    }
}
