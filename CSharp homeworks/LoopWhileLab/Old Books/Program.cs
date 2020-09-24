using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int checkedBooks = 0;
            string searchBook = "";

            while (checkedBooks < count)
            {
                searchBook = Console.ReadLine();
                checkedBooks ++;
                if (searchBook == bookName)
                {
                    Console.WriteLine($"You checked {checkedBooks-1} books and found it.");
                    break;
                }
            }
            if (searchBook != bookName)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");
            }
        }
    }
}
