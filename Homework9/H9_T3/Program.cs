using System;
using System.Collections.Generic;

namespace H9_T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var uniqWords = new Dictionary<string, int>();
            Console.WriteLine("Enter your text: ");
            string inputString = Console.ReadLine();
            Console.Clear();
            if (!string.IsNullOrWhiteSpace(inputString))
            {
                string[] words = inputString.Split(new[] { ' ', ';', '.', ',', ':', '?', '!', '-' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    if (uniqWords.ContainsKey(words[i].ToLower()))
                    {
                        uniqWords[words[i].ToLower()]++;
                    }
                    else
                    {
                        uniqWords.Add(words[i].ToLower(), 1);
                    }
                }
            }

            Console.WriteLine("Output");
            Console.WriteLine($"You text is: {inputString}");
            foreach (var uniq in uniqWords)
            {
                Console.WriteLine($"{uniq.Key} - {uniq.Value} times");
            }
        }
    }
}
