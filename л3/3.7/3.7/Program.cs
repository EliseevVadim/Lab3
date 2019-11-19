using System;

namespace _3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int f = Fib(N);
            Console.WriteLine(f);
        }
        static int Fib(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            {
                return Fib(n - 1) + Fib(n - 2);
            }
                
        }
    }
}
