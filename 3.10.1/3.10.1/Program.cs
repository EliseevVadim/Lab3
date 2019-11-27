using System;

namespace _3._10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[9, 9];
            int num = 1, counter = 0;
            bool flag = true;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j < counter || array.GetLength(1)-1 - counter < j)
                    {
                        array[j, i] = num;
                        num++;
                    }
                }
                if (flag && counter > 3)
                {
                    flag = false;
                }
                if (flag)
                {
                    counter++;
                }
                else
                {
                    counter--;
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
        }
    }
}
