using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10_Abstraction.Models
{
    internal class ConsoleRainbowWriter : ConsoleWriter
    {
        public override void Write(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.BackgroundColor = (ConsoleColor) (i%16);
                Console.ForegroundColor = (ConsoleColor) (15-(i%16));
                Console.Write(message[i]);
            }
            Console.ResetColor();
        }
    }
}
