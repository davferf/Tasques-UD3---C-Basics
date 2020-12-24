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
            int X = 53, Y = 87;
            double N = 12.43, M = 90.4;

            Console.WriteLine(X);
            Console.WriteLine(Y);
            Console.WriteLine(N);
            Console.WriteLine(M);
            Console.WriteLine(X + Y);
            Console.WriteLine(X - Y);
            Console.WriteLine(X * Y);
            Console.WriteLine(X / Y);
            Console.WriteLine(X % Y);
            Console.WriteLine(N + M);
            Console.WriteLine(N - M);
            Console.WriteLine(N * M);
            Console.WriteLine(N / M);
            Console.WriteLine(N % M);
            Console.WriteLine(X + N);
            Console.WriteLine(Y / M);
            Console.WriteLine(Y % M);

            Console.ReadKey();
        }
    }
}
