using System;

namespace H8_T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                var stringTest = "Лидер бодро, гордо бредил.";

                if (string.IsNullOrEmpty(stringTest))
                {
                    Console.WriteLine("Строка пустая");
                }
                else
                {
                    Console.WriteLine($"Исходная строка:\n{stringTest}\n");
                    Console.WriteLine($"Все строчные:\n{stringTest.ToLower()}\n");
                    Console.WriteLine($"Все заглавные:\n{stringTest.ToUpper()}\n");
                    Console.WriteLine($"Первая буква каждого слова в заглавной:");

                    var strings = stringTest.ToLower().Split(' ');
                    foreach (string s in strings)
                    {
                        var endResult = string.Empty;
                        if (string.IsNullOrEmpty(s))
                        {
                            endResult = " ";
                        }
                        else
                        {
                            endResult = string.Concat(s.Substring(0, 1).ToUpper(), s.Substring(1, s.Length - 1), " ");
                        }
                        Console.Write(endResult);
                    }
                }
                Console.ReadKey();
            }
        }
    }

