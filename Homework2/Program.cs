internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ведите ваше имя");
        string Name = Console.ReadLine();
        Console.WriteLine("Введите ваш возраст");
        int Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите ваш рост");
        double Height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Привет," + Name + "!");
        Console.WriteLine("\tВаш возраст: " + Age + " лет.");
        Console.WriteLine("\t\tВаш рост: " + Height + " м.");
    }
}