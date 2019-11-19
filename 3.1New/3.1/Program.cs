using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int a = 0;
            int c = 10;
          int  b= N;
            for (int i=0; i<array.Length; i++)
            {
                array[i] = rand.Next(-30, 45);
            }
            while (b>0)
            {
                if (b-10>=0)
                {
                    for (int i=a; i<c; i++ )
                    {
                        Console.Write(array[i] + " ");
                    }
                    b -= 10;
                    a += 10;
                    c += 10;
                    Console.WriteLine();
                }
                else
                {
                    for (int i=a; i<array.Length; i++)
                    {
                        Console.Write(array[i] + " ");
                    } break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("________________________________________________________________________________");
            for (int i=array.Length-1; i>=0; i--)
            {
                if (array[i]>=0)
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.ReadKey();

        }
    }
}
