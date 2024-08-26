using System;
namespace The
{
    internal class Program
    {
        class Lib
        {


            private int due;
            private int types;
            private string name;
            public static int calc = 0;

            public int Due() { return due; }
            public int Types() { return types; }
            public string Name() { return name; }

            public int NewDue()
            {
                Console.WriteLine();
                Console.Write("Give new due date amount: ");
                due = int.Parse(Console.ReadLine());
                return due;
            }

            public Lib()
            {
                due = 0;
                types = 0;
                name = "";
                calc++;
            }
            public Lib(int u_due, int u_types, string u_name)
            {
                due = u_due;
                types = u_types;
                name = u_name;
                calc++;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Let's try the library out!");
            Console.WriteLine();
            string u_name = "Fence";

            Lib lib = new Lib(30, 1, u_name);

            int d = lib.Due();
            int ty = lib.Types();
            string na = lib.Name();

            Console.WriteLine($"Due date is: {d} days");
            Console.WriteLine($"Type: {ty}");
            Console.WriteLine($"Name: {na}");

            d = lib.NewDue();
            Console.WriteLine("");
            Console.WriteLine("New values are:");
            Console.WriteLine();

            Console.WriteLine($"Due date is: {d} days");
            Console.WriteLine($"Type: {ty}");
            Console.WriteLine($"Name: {na}");

            Console.WriteLine();
            Console.WriteLine($"Total amount: {Lib.calc}");
        }
    }
}