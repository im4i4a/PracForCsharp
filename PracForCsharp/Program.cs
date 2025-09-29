

using System.Data;
using System.Xml.Linq;

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
            /*int bubble = 0;
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
            Console.WriteLine(counter);*/

            /*int[,] arr5 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int temp1;
            for (int i = 0; i <= arr5.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr5.GetUpperBound(1); j++)
                {
                    for (int k = j+1; k <= arr5.GetUpperBound(1); k++)
                    {
                        if (arr5[i, j] > arr5[i,k])
                        {
                            temp1 = arr5[i, j];
                            arr5[i, j] = arr5[i, k];
                            arr5[i, k] = temp1;

                        }
                    }
                }
            }

            for (int i = 0;i < arr5.GetUpperBound(0)+1; i++)
            {
                for(int j = 0;j < arr5.GetUpperBound(1)+1; j++)
                {
                    Console.Write(arr5[i, j] + " ");
                }
                Console.WriteLine();
            }


            var (name, age) = ("Евгения", 27);

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);


            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);
            */
            /* (string Name, string Type, double Age, int NameCount) Pet;
             Pet.Name = Console.ReadLine();
             Pet.Type = Console.ReadLine();
             Pet.Age = Convert.ToDouble(Console.ReadLine());
             Pet.NameCount = 0;
             foreach (var ch in Pet.Name)
             {
                 Pet.NameCount++;
             }
             Console.WriteLine("Кол-во букв в имени {0}",Pet.NameCount);
             */
                (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

            for (int countUsers = 0; countUsers < 3; countUsers++)
            {
                Console.WriteLine("Введите имя");

                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");

                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин");

                User.Login = Console.ReadLine();

                User.LoginLength = User.Login.Length;
                Console.WriteLine($"Длина логина составляет {User.LoginLength}");
                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                string answerPet = Console.ReadLine();
                switch (answerPet)
                {
                    case "Да" or "да":
                        User.HasPet = true;
                        Console.WriteLine("У вас есть домашний питомец");
                        break;
                    case "Нет" or "нет":
                        User.HasPet = false;
                        Console.WriteLine("У вас нет домашнего питомца");
                        break;
                    default:
                        Console.WriteLine("Не корректный ответ");
                        break;

                }

                Console.WriteLine("Введите возраст пользователя");


                User.Age = double.Parse(Console.ReadLine());


                User.favcolors = new string[3];

                Console.WriteLine("Введите три любимых цвета пользователя");

                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    User.favcolors[i] = Console.ReadLine();

                }

            }

            (string Name, string[] dishes) User1;

            User1.Name = Console.ReadLine();
            Console.WriteLine("Введите 5 любимых блюд: ");
            User1.dishes = new string[5];
            for (int i = 0; i < User1.dishes.Length; i++)
            {
                User1.dishes[i] = Console.ReadLine();
            }

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
    
