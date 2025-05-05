internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int Age = Convert.ToInt32(Console.ReadLine());
        if (Age % 2 == 0)
        {
            Console.WriteLine("Четное");
        }
        else 
        {
            Console.WriteLine("Нечетное");
        }
        if (Age >= 0 && Age <= 2)
        {
            Console.WriteLine("Младенец");
        }
        else if (Age >= 3 && Age <= 12)
        {
            Console.WriteLine("Ребенок");
        }
        else if (Age >= 13 && Age <= 17)
        {
            Console.WriteLine("Подросток");
        }
        else if (Age >= 18 && Age <= 59)
        {
            Console.WriteLine("Взрослый");
        }
        else if (Age >= 60)
        {
            Console.WriteLine("Пожилой");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}