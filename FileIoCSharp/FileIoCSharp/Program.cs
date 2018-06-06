using System;

namespace FileIoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string FilePath = Console.ReadLine();

            Console.WriteLine("Your file path is: ");
            Console.WriteLine("                  " + FilePath);
            Console.WriteLine("Press any key to continue...");

            Console.ReadLine();

        }
    }
}
