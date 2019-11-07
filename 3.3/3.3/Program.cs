using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for (int i=0; i<array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int k = int.Parse(Console.ReadLine());
            int[] newArray = new int[N - k];
            for (int i=0;i<newArray.Length; i++)
            {
                newArray[i] = array[i + k];
                Console.Write(newArray[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
