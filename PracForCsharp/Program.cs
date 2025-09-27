

using System.Data;

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
            /*var name = Console.ReadLine();

            var age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            Console.Write("What is your favorite day of week? ");

            var day = (daysOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);
            Console.WriteLine("Enter ur bithday");
            var bithday = Console.ReadLine();
            Console.WriteLine($"Your bithday is {bithday}!");
            */

            /* int a = 5;
             int b = 2;
             if (a > b)
             {
                 Console.WriteLine("TRUE");
             }
             else
             {
                 Console.WriteLine("FALSE");
             }*/

            //string color = Console.ReadLine();
            /*
            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else if (color == "yellow")
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
                Console.WriteLine("Нет такого варианта!");
            */
            /*switch (color) 
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("redredredred");
                    break;
                case "green":
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default: 
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
            */
            /*for (int i = 0; i < 3; i++) 
            {

                switch (Console.ReadLine()) 
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("THIS IS RED!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("THIS IS GREEN!");
                        break;
                    case "yellow":
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("THIS IS YELLOW!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("THIS IS CYAN!");
                        break;
                }
            }*/
            /*for (; ; )
            {
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("THIS IS RED!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("THIS IS GREEN!");
                        break;

                    case "yellow":
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("THIS IS YELLOW!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("THIS IS CYAN!");
                        break;

                }
            }*/
            /*int counter = 0;
            do
            {
                var text = Console.ReadLine();
                if (text == "stop")
                {
                    break;
                }
                switch (text)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("THIS IS RED!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("THIS IS GREEN!");
                        break;

                    case "yellow":
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("THIS IS YELLOW!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("THIS IS CYAN!");
                        break;
                    
                }
                counter++;
            } while (true);*/

            //string stringName = Console.ReadLine();
            //Console.WriteLine("Вас зовут = " + stringName);

            /*foreach (var chr in stringName){
                Console.Write(chr + " ");
                
            }*/
            /*for (int i = stringName.Length - 1; i >= 0; i--)
            {
                Console.Write(stringName[i]);
            }
            Console.WriteLine(" Последняя буква имени " + stringName[stringName.Length - 1]);
            */
         
            /*
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };
            for (int i = 0; i < array.GetUpperBound(1)+1; i++) 
            { 
                for (int j = 0; j < array.GetUpperBound(0) + 1; j++)
                {
                    Console.Write(array[j,i] + " ");
                }
                Console.WriteLine();
            }*/

            // Сортировка массива
            int bubble = 0;
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            for (int i = 0; i < arr.Length; i ++)
            {
                for(int j = 0;j < arr.Length - 1; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        bubble = arr[i];
                        arr[i] = arr[j];
                        arr[j] = bubble;
                    }

                }
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            int sum = 0;
            foreach (var number in arr)
            {
                sum += number;
            }
            Console.WriteLine(sum);

            string[][] arrString = new string [3][];

            arrString[0] = new string[] { "картошка","car", "magazin" };
            arrString[1] = new string[] { "Apple" };
            arrString[2] = new string[] { "like","could", "be","dream" };

            foreach (var item in arrString)
            {
                foreach (var word in item)
                {
                    Console.Write(word + " ");
                }
                Console.WriteLine();
            }
            //////////////////////////////////////////
            int[] arr2 = new int[] { 2, 5 ,-5, -10, -3, 6, 63, -41, 15, 9, -9 , 3};
            int counter = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] > 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            
            
            /////////////////////////////////////
            int temp = 0;
            int[,] arr3 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            for (int i = 0; i < arr3.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr3.GetUpperBound(1) + 1; j++)
                {
                    if (arr3[i,j] > 0)
                        temp++;
                }
            }
            Console.WriteLine("ANSWER - " + temp);

            //////////////////////////////////////////
            counter = 0;
            foreach (var item in arr3)
            {
                if (item > 0)
                    counter++;
            }
            Console.WriteLine(counter);
        }
        enum DaysOfWeek : byte
        {
            monday,
            tuesday,
            wednesday,
            thearsday,
            friday,
            saturday,
            sunday

        }
        enum Semaphore
        {
            red = 100,
            yellow = 200,
            green = 300,

        }
    }
}
    
