using System.Text;
using System;

namespace H8_T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var testString = "Лидер бодро, гордо бредил.";
            var modifyString = new StringBuilder(testString);
            if (string.IsNullOrEmpty(testString))
            {
                Console.WriteLine("Пустая строка");
            }
            else
            {
                modifyString.Replace(" ", "");
                Console.WriteLine(modifyString.ToString());
            }
            Console.ReadKey();
        }
    }
}
