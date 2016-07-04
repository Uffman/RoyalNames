using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]
            {
                "Fillip XI",
                "Fillip IV",
                "Fillip III",
                "Fillipe I"
            };
            Array.Sort(names, new AlphanumComparator());

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
