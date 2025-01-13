namespace Demo23_LinQ_LambdaExpression
{
    internal class Program
    {
        //public delegate int FuncAddition(int nb1, int nb2);
        static void Main(string[] args)
        {
            //Func<int,int,int> addition = delegate (int nb1, int nb2)
            //{
            //    return nb1 + nb2;
            //};

            Func<int,int,int> addition = (nb1, nb2) => nb1 + nb2;

            Console.WriteLine($"Le calcul de 1 + 2 donne {addition?.Invoke(1, 2)}");
        }
    }
}
