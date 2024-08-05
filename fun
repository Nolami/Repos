using System;
using System.Runtime.CompilerServices;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me number y: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            List<string> sel = new List<string>();
            string[] opt = { "Addition", "Subtraction", "Multiplication"};
            int x;
            while (sel.Count < opt.Length)
            {
            Console.Write($"Which option do you want? ({String.Join(", ", opt)}) ");
            string choice = Console.ReadLine();
            if (string.IsNullOrEmpty(choice))
                {
                    continue;
                }
            switch (choice.ToLower()) { 
                case "addition":
                    Console.WriteLine();
                    x = y + 3;
                    Console.WriteLine($"Answer is: {x}");
                        Console.WriteLine();
                    break;
                case "subtraction":
                    Console.WriteLine();
                    x = y - 2;
                    Console.WriteLine($"Answer is {x}");
                        Console.WriteLine();
                        break;
                case "multiplication":
                    Console.WriteLine(); 
                    x = y * 5;
                    Console.WriteLine($"Answer is {x}");
                        Console.WriteLine();
                        break;

            }
                sel.Add(choice);

            }
            Console.Write("Give number y: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Give number x: ");
            x = int.Parse(Console.ReadLine());
            int ans = x / y;
            Console.WriteLine();
            Console.WriteLine($"Answer is {ans}");
            Console.WriteLine();
            List<string> selected = new List<string>();
            string[] opt2 = { "Median", "Addition", "Subtraction", "Multiplication", "Division" };
            Console.Write("Give number y: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Give number x: ");
            x = int.Parse(Console.ReadLine());
            while (selected.Count < opt2.Length)
            {
            Console.Write($"Which option do you want? ({String.Join(", ", opt2)}) ");
            string choice2 = Console.ReadLine();
                if (string.IsNullOrEmpty(choice2)) {
                    continue;
                }

            int ans2;
            switch (choice2.ToLower())
            {
                case "median":
                    Console.WriteLine();
                    ans2 = x % y;
                    Console.WriteLine($"Answer is: {ans2}");
                        Console.WriteLine();
                        break;
                case "addition":
                    Console.WriteLine();
                    ans2 = x += y;
                    Console.WriteLine($"Answer is {ans2}");
                        Console.WriteLine();
                        break;
                case "subtraction":
                    Console.WriteLine();
                    ans2 = x -= y;
                    Console.WriteLine($"Answer is {ans2}");
                        Console.WriteLine();
                        break;
                case "multiplication":
                    Console.WriteLine();
                    ans2 = x *= y;
                    Console.WriteLine($"Answer is {ans2}");
                        Console.WriteLine();
                        break;
                case "division":
                    Console.WriteLine();
                    ans2 = x /= y;
                    Console.WriteLine($"Answer is {ans2}");
                        Console.WriteLine();
                        break;
            }
                selected.Add(choice2);
            }
        }
    }
}