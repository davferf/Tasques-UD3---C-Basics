using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 16;

            Console.WriteLine(N += 77);
            Console.WriteLine(N -= 3);
            Console.WriteLine(N *= 2);

            Console.ReadKey();
        }
    }
}
