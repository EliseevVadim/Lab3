using System;

namespace _3._2New
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[7,7];
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(1, 100);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("_________________________________________________________________________");
            int temp = 0;
            for (int i = 0; i < array.GetLength(0) / 2; i++)
            {
                for (int j = i; j < array.GetLength(1) - 1 - i; j++)
                {
                    temp = array[i, j];
                    array[i, j] = array[array.GetLength(0) - j - 1, i];
                    array[array.GetLength(0) - j - 1, i] = array[array.GetLength(0) - i - 1, array.GetLength(0) - j - 1];
                    array[array.GetLength(0) - i - 1, array.GetLength(0) - j - 1] = array[j, array.GetLength(0) - i - 1];
                    array[j, array.GetLength(0) - i - 1] = temp;
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
           // Console.WriteLine(7/2);
        }
    }
}
