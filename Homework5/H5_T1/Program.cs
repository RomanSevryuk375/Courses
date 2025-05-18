using System;

namespace H5_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book_1 = new Book();
            Console.WriteLine(book_1.GetDescription());
            Book book_2 = new Book("Arlo Finch in the Valley of Fire", "John August", 336);
            Console.WriteLine(book_2.GetDescription());
        }
    }
}
