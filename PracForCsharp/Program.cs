

using System;

namespace PracForCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Aleksey";
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

            Console.ReadKey();
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
