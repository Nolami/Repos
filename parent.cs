using System;
using System.Numerics;

namespace Zinkler
{
    internal class Program
    {
        class Library
        {
            public string name;
            public static int count = 0;

            public Library() 
            {
                name = "";
                Console.WriteLine("Parent program element used");
            }
            public string The
            {
                get { Console.WriteLine("The get");
                    return name;
                }
                set { Console.WriteLine("The set");
                    name = value;
                }
            }
        }
        class Library2:Library
        {
            private int due;
            private int type;

            public Library2()
            {
                due = 0;
                type = 0;
                count++;
                Console.WriteLine("Child attained");

            }    
            public Library2(int n_d, int n_t)
            {
                due = n_d;
                type = n_t;
                count++;
                Console.WriteLine("Child has been overloaded");
            }
            public int day
            {
                get { Console.WriteLine("Getted"); return due; }
                set { Console.WriteLine("Setted"); due = value; }
            }
            public int types
            {
                get { Console.WriteLine("Getted"); return type; }
                set { Console.WriteLine("Setted"); type = value; }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Blyat");
            Console.WriteLine();

            int n_d = 30;
            int n_t = 1;

            Library2 lib = new Library2();
            Console.WriteLine("Child acquired");
            Library2 lib2 = new Library2(n_d, n_t);
            Console.WriteLine("Child has been reacquired");

            int ep = lib2.day;
            int ty = lib2.types;
            string nm = lib.name;

            Console.WriteLine();
            Console.WriteLine($"Values from child2 are now: \n\nDue date is now {ep}\n\nType is now {ty}\n\nName is now: {nm}");

            Console.Write("What is your name?: ");
            string u_name = Console.ReadLine();
            Console.Write("What day you want?");
            n_d = int.Parse(Console.ReadLine());
            lib2.name = u_name;
            lib2.day= n_d;
            ep = lib2.day;
            ty = lib2.types;
            nm = lib2.name;

            Console.WriteLine();
            Console.WriteLine($"Values from child2 are now: \n\nDue date is now {ep}\n\nType is now {ty}\n\nName is now: {nm}");
            Console.WriteLine();

            Console.WriteLine($"Total amount of creatures: {Library.count}");
        }
    }
}