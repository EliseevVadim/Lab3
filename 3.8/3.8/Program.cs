using System;

namespace _3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] array = new int[N, N];
            for (int i=0; i<array.GetLength(0); i++)
            {
                for (int j=0; j<array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int determinante = Determinante(array);
            Console.WriteLine(determinante);
        }
        static int Determinante (int [,] mas)
        {
            int sign = 1, result = 0;
            if (mas.Length == 1) return mas[0, 0];
            else if (mas.Length == 4) return mas[0, 0] * mas[1, 1] - mas[0, 1] * mas[1, 0];
            else
            {
                for (int i=0; i<mas.GetLength(1); i++)
                {
                    int[,] minor = Minor(mas, i);
                    result += sign * mas[0, i] * Determinante(minor);
                    sign = -sign;
                }
                return result;
            }
        }
        static int[,] Minor (int [,] arr, int G)
        {
            int [,] resultArray = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
            for (int i=1; i<arr.GetLength(0); i++)
            {
                for (int j=0; j<G; j++)
                {
                    resultArray[i - 1, j] = arr[i, j];
                }
                for (int j=G+1; j<arr.GetLength(0); j++)
                {
                    resultArray[i - 1, j - 1] = arr[i, j];
                }
            }
            return resultArray;
        }
    }
}
