using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int counter = 0;
            int sum=0;
            for (int i=0; i<array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }
            double middle_arithmetical = sum / array.Length;
            for (int i=0; i<array.Length;i++)
            {
                if (array[i]>middle_arithmetical)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            
            Console.ReadKey();

        }
    }
}
