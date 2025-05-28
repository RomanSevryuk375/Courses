using System;

namespace H7_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Write number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array, (x, y) => y.CompareTo(x)); 
            Console.WriteLine(string.Join(", ", array)); 
        }
    }
}
