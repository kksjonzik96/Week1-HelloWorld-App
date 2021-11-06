using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserName;
            Console.WriteLine("What is yor name?");
            UserName = Console.ReadLine();
            Console.WriteLine("Hello" + UserName);
            Console.Read();
        }
    }
}
