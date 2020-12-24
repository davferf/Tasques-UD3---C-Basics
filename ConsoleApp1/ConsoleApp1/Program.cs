using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 1, B = 2, C = 3, D = 4, aux;

            aux = B;
            B = C;
            C = A;
            A = D;
            D = aux;

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            Console.WriteLine(D);

            Console.ReadKey();
        }
    }
}
