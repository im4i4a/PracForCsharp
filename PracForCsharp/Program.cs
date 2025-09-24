

using System;

namespace PracForCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* const string MyName = "Aleksey";
            Console.WriteLine(MyName);

            Console.WriteLine("Привет, мир");
            Console.WriteLine("\tМне 22 года");
            Console.WriteLine("\nMy name is {0}", MyName);
            Console.WriteLine("\x03");

            string name = "Aleksey";
            int age = 22;
            bool haveAPet = true;
            double footSize = 44.5;

            Console.WriteLine("My name is {0}",name);
            Console.WriteLine("i am "+age+" years old!");
            Console.WriteLine(haveAPet);
            Console.WriteLine("My foot size is " + footSize);
            
            Console.WriteLine(daysOfWeek.tuesday);

            double result = 5.0 / 3.0;
            Console.WriteLine(result);

            int counter = 10;
            Console.WriteLine("Value : {0} Increment: {1}", counter, ++counter);
            */
            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.Write("What is ur favorite week?");
            daysOfWeek week = (daysOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine(week);
            */
            var name = Console.ReadLine();

            var age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            Console.Write("What is your favorite day of week? ");

            var day = (daysOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);
            Console.WriteLine("Enter ur bithday");
            var bithday = Console.ReadLine();
            Console.WriteLine($"Your bithday is {bithday}!");
        }
        
    }
    enum daysOfWeek : byte
    {
        monday,
        tuesday,
        wednesday,
        thearsday,
        friday,
        saturday,
        sunday

    }
    enum semaphore
    {
        red = 100,
        yellow = 200,
        green = 300,
        
    }
}
