using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give number: ");
            double num = double.Parse(Console.ReadLine());
            Console.Write("Give a second number: ");
            double num2 = double.Parse(Console.ReadLine());
            double ans = num + num2;
            Console.WriteLine(ans);
            Console.WriteLine();
            Console.Write("Give Celcius: ");
            double cel = double.Parse(Console.ReadLine());
            double far = cel * 1.8 + 32;
            Console.Write($"Here's your fahrenheit: {far}");
            Console.WriteLine() ;

            Console.Write("Give number: ");
            double nume = double.Parse(Console.ReadLine());
            Console.Write("Give number 2: ");
            double nume2 = double.Parse(Console.ReadLine());

            double add = nume + nume2;
            double sub = nume - nume2;
            double mult = nume * nume2;
            double div = 0;
            
            if (nume2 != 0)
            {
                div = nume / nume2;
            } else
            {
                Console.Write("The space time continuem does not allow this");
            }
            Console.WriteLine($"{add} {sub} {mult} {div}") ;

            Console.WriteLine() ;
            Console.Write("Give number: ");
            double numb = double.Parse(Console.ReadLine());
            Console.WriteLine("Give number again: ") ;
            double numb2 = double.Parse(Console.ReadLine());
            double answ = numb % numb2;
            Console.WriteLine(answ);

            Console.WriteLine();
            Console.Write("Insert your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");

            Console.WriteLine();
            Console.Write("Give a number between 1 and 10: ");
            int big = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int res = big * i;
                Console.WriteLine(res);
            }


        }
    }
}