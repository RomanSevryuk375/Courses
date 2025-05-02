internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ведите число А");
        var numberA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число В");
        var numberB = Convert.ToDouble(Console.ReadLine());
        var sum = numberA + numberB;
        var diff = numberA - numberB;
        var prod = numberA * numberB;
        var priv = numberA / numberB;
        Console.WriteLine("Сумма " +  sum);
        Console.WriteLine("Разность " + diff);
        Console.WriteLine("Произведение " + prod);
        Console.WriteLine("Частное " + priv);
    }
}