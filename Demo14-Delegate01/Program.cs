using Demo14_Delegate01.Models;

namespace Demo14_Delegate01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VSCExtension ext1 = new VSCExtension("C#");
            //VSCExtension ext2 = new VSCExtension("dotnet");
            //List<VSCExtension> exts = new List<VSCExtension> ([ext1,ext2]);

            if (args.Contains("--cheatcode"))
            {
                Console.WriteLine("Hello les wads!");
            }

            List<VSCExtension> exts = new List<VSCExtension>();
            int i = 0;
            foreach (string extName in args)
            {
                if(extName != "--cheatcode")
                {
                    exts.Add(new VSCExtension(extName));
                    i++;
                }
            }

            using (VisualStudioCode vsc = new VisualStudioCode(exts.ToArray()))
            {
                vsc.RestartExtensions();
            }

        }
    }
}
