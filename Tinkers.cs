using System;
namespace The
{
    internal class Program
    {
        class Lib
        {
            private int ing_am; //12
            private int other; //13
            private List<string> ing_nam; //A lot
            private List<string> other_nam; //A lot

            public int Am
            {
                get { return ing_am; }
                set { ing_am += value; }
            }
            public int Other
            {
                get { return other; }
                set { other += value; }
            }
            public List<string> IngNam
            {
                get { return ing_nam; }
            }
            public List<string> OtNam
            {
                get { return other_nam; }
            }

            public int UpdAm()
            {
                Console.WriteLine();
                Console.Write("Update material amount: ");
                int New_ing_am = int.Parse(Console.ReadLine());
                int old_Am = ing_am;
                ing_am = New_ing_am;
                Console.WriteLine();
                Console.WriteLine($"Old amount: {old_Am}");
                Console.WriteLine();
                return ing_am;
            }
            public int UpdOther()
            {
                Console.WriteLine();
                Console.Write("Update material amount: ");
                int New_other = int.Parse(Console.ReadLine());
                int old_Other = other;
                other = New_other;
                Console.WriteLine();
                Console.WriteLine($"Old material amount: {old_Other}");
                Console.WriteLine();
                return other;
            }
            public List<string> UpdNam()
            {
                Console.WriteLine();
                Console.Write("Update new ingots: ");
                IngNam.Add(Console.ReadLine());
                Console.WriteLine();
                return IngNam;
            }
            public List<string> UpdOther_Nam()
            {
                Console.WriteLine();
                Console.Write("Update new materials: ");
                OtNam.Add(Console.ReadLine());
                Console.WriteLine();
                return OtNam;
            }

            public Lib()
            {
                ing_am = 12;
                other = 13;
                ing_nam = new List<string> {"Iron", "Pig Iron", "Cobalt", "Ardite", "Manyullyn", "Copper", "Lead", "Bronze", "Silver", "Steel", "Electrum", "Constantan" };
                other_nam = new List<string> {"Wood", "Stone", "Flint", "Cactus", "Bone","Obsidian", "Prismarine", "End Stone", "Paper", "Sponge", "Magma Cream", "Netherrack", "Treated wood" };
            }
            public Lib(int u_am, int u_other, string u_nam, string u_onam)
            {
                ing_am = u_am;
                other = u_other;
                ing_nam = new List<string> { u_nam };
                other_nam = new List<string> { u_onam } ;
            }
        }
        static void Main(string[] args)
        {

            Lib lib = new Lib();

            bool continuerunning = true;
            
            while (continuerunning)
            {
                DisplayInfo(lib);

                Console.WriteLine();
                Console.Write("Do you want to add or modify something on the list? (Yes or no): ");
                string ans = Console.ReadLine();
                if (ans.ToLower() == "no")
                {
                    continuerunning = false;
                } else if (ans.ToLower() == "yes")
                {
                    Console.WriteLine();
                    Console.Write("What do you want to add? (Ingot amount, material amount, unique ingots, unique materials or nothing): ");
                    string mod = Console.ReadLine();
                    switch (mod.ToLower())
                    {
                        case "ingot amount":
                            lib.UpdAm();
                            break;
                        case "material amount":
                            lib.UpdOther();
                            break;
                        case "unique ingots":
                            lib.UpdNam();
                            break;
                        case "unique materials":
                            lib.UpdOther_Nam();
                            break;
                        case "nothing":
                            continuerunning = false;
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("Invalid answer");
                            break;
                    }
                }
            }

        }
        static void DisplayInfo(Lib lib)
        {
            int ing_amount = lib.Am;
            int other_amount = lib.Other;
            List<string> ing_name = lib.IngNam;
            List<string> ot_nam = lib.OtNam;

            Console.WriteLine($"Amount of unique ingots: {ing_amount}");
            Console.WriteLine();
            Console.WriteLine($"Amount of unique materials: {other_amount}");
            Console.WriteLine();
            Console.WriteLine("All unique ingots: ");
            Console.WriteLine();
            foreach (string i in ing_name)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("All unique materials");
            Console.WriteLine();
            foreach (string l in ot_nam)
            {
                Console.WriteLine(l);
            }
        }
    }
}