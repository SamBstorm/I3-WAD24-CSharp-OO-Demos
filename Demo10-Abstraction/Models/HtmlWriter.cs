using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10_Abstraction.Models
{
    internal class HtmlWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.Write(@$"<!DOCTYPE html>
<html>
    <head>
        <title>Document HtmlWriter</title>
    </head>
    <body>
        <h1>{message}</h1>
    </body>
</html>");

        }
    }
}
