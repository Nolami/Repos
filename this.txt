using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string he = "Greetings, puny mortal!"; //beter for later on calling
            Console.WriteLine(he);
            Console.WriteLine();
            string na = "Egert Sulger"; //Gonna be using this a lot
            Console.WriteLine(na);
            Console.WriteLine();
            int[] num = { 1, 11, 101, 1001 }; //Easier to use arrays rather than print out each individual number
            foreach (int number in num) //can't forget actually reading the array
            {
                Console.WriteLine(number);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Insert name, NOW! "); //Asks question
            string name = Console.ReadLine(); //Reads it
            Console.WriteLine();
            Console.WriteLine($"Hello {name}"); //Prints out with string integrated
        }
    }
}