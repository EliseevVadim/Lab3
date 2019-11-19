using System;

namespace Task3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for (int i=0; i < array.Length; i++){
                array[i] = int.Parse(Console.ReadLine());
            }
            int k = int.Parse(Console.ReadLine());
            for (int i=0; i<k; i++)
            {
                int temp = array[0];
                for (int j=0; j<array.Length-1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[N -1] = temp;
            }
            for (int i=0; i<array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
