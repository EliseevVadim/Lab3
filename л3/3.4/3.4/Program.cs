using System;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];
            Console.WriteLine("Введите матрицу 1");
            for (int i=0; i<3; i++)
            {
                for (int j=0; j<3; j++)
                {
                    array1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Введите матрицу 2");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            double middle = 0.0d;
            int [,] sumArray= sumArrays(array1,array2, out middle);
            int[,] diffArray = diffArrays(array1, array2);
            Console.WriteLine("Summ of entered arrays is: ");
            for (int i=0; i<3; i++)
            {
                for (int j=0; j<3; j++)
                {
                    Console.Write(sumArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Difference of entered arrays is: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(diffArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Middle value is: "+ middle);


        }
        static int [,] sumArrays (int [,] matrix1, int [,] matrix2, out double res) 
        {
            int[,] resultmatrix = new int[3, 3];
            double sum1 = 0;
            double sum2 = 0;
            for (int i=0; i<3; i++)
            {
                for (int j=0; j<3; j++)
                {
                    resultmatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                    sum1 += matrix1[i, j];
                    sum2 += matrix2[i, j];
                }
            }
            res = (sum1 + sum2) / (2 * matrix1.Length);

            return resultmatrix;
        }
        static int [,] diffArrays (int [,] matrix1, int [,] matrix2)
        {
            int[,] resultmatrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultmatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return resultmatrix;
        }
    }
}
