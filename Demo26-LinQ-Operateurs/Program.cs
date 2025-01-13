using System.Collections;

namespace Demo26_LinQ_Operateurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(5);
            list.Add("6");
            list.Add(27);
            list.Add(42);
            list.Add(53);

            IEnumerable<int> listInts;
            int maxValue = 0;
            try
            {
                listInts = list.Cast<int>();
                foreach (int value in listInts)
                {
                    if (value > maxValue) { maxValue = value; }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Toutes les valeurs ne sont pas compatible avec le type int.");
                listInts = list.OfType<int>();
                maxValue = 0;
                foreach (int value in listInts)
                {
                    if (value > maxValue) { maxValue = value; }
                }
            }
            Console.WriteLine($"La valeur la plus élevée est {maxValue}");

            //IEnumerable<int> evenList = listInts.Where((value) => value % 2 == 0);
            IEnumerable<int> evenList = from value in listInts
                                        where value % 2 == 0
                                        select value;
            //IEnumerable<int> evenList = listInts.Where(delegate (int value) { return value % 2 == 0; });
            Console.WriteLine("Les nombres paires sont :");
            foreach (int even  in evenList)
            {
                Console.WriteLine(even);
            }


            //listInts = listInts.Select(value => value * value);
            //IEnumerable<string> strings = listInts.Select(value => value.ToString());

            IEnumerable<string> strings = 
                listInts
                .Select((value) => value * value)
                .Select((value) => value.ToString());
            //IEnumerable<string> strings =
            //  from value2string in (from value in listInts
            //                        select value * value)
            //  select value2string.ToString();
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }

        }
    }
}
