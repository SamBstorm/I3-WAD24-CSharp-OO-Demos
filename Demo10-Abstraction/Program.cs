using Demo10_Abstraction.Models;

namespace Demo10_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMessageWriter writer = new HtmlWriter();

            writer.Write("Hello");

        }
    }
}
