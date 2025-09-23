

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
        }
    }
}
