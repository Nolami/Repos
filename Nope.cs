using System;
using System.Runtime.CompilerServices;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Give second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] nums = { num1, num2 };

            Array.Sort(nums);

            Array.Reverse(nums);

            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            int[] numbers = { 7, 2, 48 };

            Array.Sort(numbers);
            Array.Reverse(numbers);
            foreach (int num in numbers)
            {
            Console.Write(num + " ");

            }

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Give a number from 0 to 9: ");
            int ran = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (ran)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Give a number 5 times");
            Console.WriteLine();

            int[] numbers2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"give {i + 1}. number ");
                numbers2[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Array.Sort(numbers2);
            Array.Reverse(numbers2);
            foreach (int num in numbers2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.Write("What do you want to input (int, double or string)? ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "int":
                    Console.Write("Insert full number: ");
                    int num = int.Parse(Console.ReadLine());
                    int ans = num + 1;
                    Console.Write(ans);
                    break;
                case "double":
                    Console.Write("Insert a decimal point number: ");
                    double numb = double.Parse(Console.ReadLine());
                    double ans2 = numb + 1;
                    Console.Write(ans2);
                    break;
                case "string":
                    Console.Write("Insert a word: ");
                    string word = Console.ReadLine();
                    word = word + "*";
                    Console.Write(word);
                    break;
            }
            

        }
    }
}