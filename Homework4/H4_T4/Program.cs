using System;

namespace H4_T4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Do you want to finish this game?");
                var BoolValueEnd = Console.ReadLine().ToLower() == "yes" ? true : false;
                if (BoolValueEnd)
                {
                    Console.WriteLine("Thanks for playing");
                    break;
                }
                Console.WriteLine("Enter the direction of movement\tW-up\tS-down\tA-left\tD-right");
                var mov = Console.ReadLine().ToLower();
                switch (mov)
                {
                    case "w":
                        Console.WriteLine("Figure moved up");
                        break;
                    case "s":
                        Console.WriteLine("Figure moved down");
                        break;
                    case "a":
                        Console.WriteLine("Figure moved left");
                        break;
                    case "d":
                        Console.WriteLine("Figure moved right");
                        break;
                    default:
                        Console.WriteLine("You enter a wrang letter");
                        break;
                }
            }
        }
    }
}
