namespace H11_T1;

internal class Program
{
    private static void Main(string[] args)
    {
        var num1 = "99";

        Check(num1);
    }

    public static void Check(string num)
    {
        try
        {
            var result = Addition.AdditionByTen(num);
            Console.WriteLine("result = " + result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}