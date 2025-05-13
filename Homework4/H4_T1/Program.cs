using System;

namespace H4_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int length = 10;
            var arr = new int[length] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            for (var i = 0; i < length; i++)
            {
                Console.WriteLine($"{arr[i]}");
            }
            Console.WriteLine();
            var j = 0;
            while (j < length)
            {
                Console.WriteLine($"{arr[j]}");
                j++;
            }
            Console.WriteLine();
            var k = 0;
            do 
            { 
                Console.WriteLine($"{arr[k]}");
                k++;
            }
            while (k < length);
        }
    }
}
