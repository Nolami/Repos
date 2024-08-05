using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age? ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"{age}, huh? You look younger than you are.");

            Console.WriteLine();
            Console.Write("Gimme a number that is greater than 10: ");
            int big = int.Parse(Console.ReadLine());
            if (big < 10)
            {
                Console.WriteLine("Ha, Loser");
            }
            for (int i = 0; i < big; i++)
            {
                for (int j = 0; j <= big; j++)
                {
                    Console.Write(big + " ");
                }
                Console.WriteLine();


                for (int j = 0; j <= big; j++)
                {
                    Console.Write(big);
                }
                Console.WriteLine();
            }

                Console.WriteLine();
                Console.Write("Gimme a word: ");
                string input = Console.ReadLine();



                char[] chas = input.ToCharArray();

                // Swap the first and last chas
                char temp = chas[0];
                chas[0] = chas[chas.Length - 1];
                chas[chas.Length - 1] = temp;


                string swappedWord = new string(chas);

                Console.WriteLine(swappedWord);

            Console.WriteLine();
            Console.Write("Gimme number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Gimme number again: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num < 0 && num2 < 0)
            {
                Console.WriteLine("The numbers are negative");
            }
            else if (num > 0 && num2 > 0)
            {
                Console.WriteLine("The numbers are positive");
            }
            else if ((num > 0 && num2 < 0) || (num < 0 && num2 > 0))
            {
                Console.WriteLine("One's positive, the other isn't");
            }

            Console.WriteLine();
            Console.Write("Gimme a sentece: ");
            string word = Console.ReadLine();
            string[] words = word.Split(' ');
            string longe = string.Empty;
            int maxlength = 0;
            
            foreach (string wird in words)
            {
                string trwo = wird.Trim();
                if (trwo.Length > maxlength) { 
                longe = trwo;
                    maxlength = trwo.Length;
                }
            }
            if (longe.Length > 0)
            {
                Console.WriteLine($"Longest word is {longe}");
            }

            Console.WriteLine();
            for (int i = 1; i <= 99; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 1; i <= 99; i += 2)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }



        }
    }
}