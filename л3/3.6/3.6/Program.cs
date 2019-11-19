using System;

namespace _3._6
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
            int sumI = SumIterative(array);
            int minI = MinIterative(array);
            int sumR = SumRecursive(array, 0, 0);
            int minR = MinRecursive(array, 0, array[0]);
            Console.WriteLine("SumIterative is: " + sumI);
            Console.WriteLine("MinIterative is: "+ minI);
            Console.WriteLine("SumRecursive is: "+sumR);
            Console.WriteLine("MinRecursive is: "+minR);

        }
        static int SumIterative (int[]mas)
        {
            int sum = 0;
            for (int i=0; i<mas.Length; i++)
            {
                sum += mas[i];
            }
            return sum;
        }
        static int MinIterative (int [] mas)
        {
            int min = mas[0];
            for (int i=1; i<mas.Length; i++)
            {
                if (mas[i]<min)
                {
                    min = mas[i];
                }
            }
            return min;
        }
        static int SumRecursive (int [] mas, int i, int sum) 
        {
           if (i==mas.Length)
            {
                return sum;
            }
           else
            {
                sum += mas[i];
                i++;
                return SumRecursive(mas, i, sum);
            }
        }
        static int MinRecursive (int [] mas, int i, int min)
        {
            if (i==mas.Length)
            {
                return min;
            }
            else
            {
                if (mas[i]<min)
                {
                    min = mas[i];
                }
                i++;
                return MinRecursive(mas, i, min);
            }
        }
        
        
    }
}
