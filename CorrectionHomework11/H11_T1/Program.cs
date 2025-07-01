namespace H11_T1;

internal class Program
{
    static void Main()
    {
        var worker = new StringWorker();

        try
        {
            int count = worker.CountLetters("   ");   
            Console.WriteLine($"Символов: {count}");
        }
        catch (EmptyStringException ex)          
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[Пользовательская ошибка] {ex.Message}");
        }
        catch (ArgumentNullException ex)       
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[Системная ошибка] {ex.Message}");
        }
        catch (Exception ex)                   
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[Непредвиденная ошибка] {ex.Message}");
        }
        finally
        {
            Console.ResetColor();
            Console.WriteLine("Работа завершена.");
        }
    }
}
