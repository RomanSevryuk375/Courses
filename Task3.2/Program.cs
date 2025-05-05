internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите первое значение ");
        var firstValue = Convert.ToBoolean(Console.ReadLine());
        Console.Write("Введите второе значение ");
        var secondValue = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("B1\tB2\tB1&B2\tB1|B2\tB1^B2\t!B1");
        Console.WriteLine($"{firstValue}\t{secondValue}\t{firstValue && secondValue}\t{firstValue || secondValue}\t{firstValue ^ secondValue}\t{!firstValue}");
    }
}