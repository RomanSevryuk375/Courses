using System;

namespace H8_T1
{
            internal class Program
        {
            static void Main(string[] args)
            {
                char[] uslessItem = { ' ', '.', ',', ':', ';', '-', '!', '?', '"' };

                var testString = "Лидер бодро, гордо бредил";

                if (string.IsNullOrEmpty(testString))
                {
                    Console.WriteLine("Строка пустая");
                }
                else
                {
                    Console.WriteLine($"Введенная строка:\n{testString}");
                    var strings = testString.ToLower().Split(uslessItem, StringSplitOptions.RemoveEmptyEntries);

                    var joinedStringsArray = string.Join("", strings);

                    for (var i = 0; i < joinedStringsArray.Length; i++)
                    {
                        var left = joinedStringsArray[i];
                        var right = joinedStringsArray[joinedStringsArray.Length - i - 1];
                        if (left != right)
                        {
                            Console.WriteLine("\nНе является палиндромом");
                            break;
                        }
                        else if (i > (joinedStringsArray.Length - i - 1))
                        {
                            Console.WriteLine("\nЯвляется палиндромом");
                            break;
                        }
                        continue;
                    }
                }
                Console.ReadKey();
            }
        }

}
