using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;

namespace The
{
    internal class Program
    {
        class Warehouse
        {
            private List<int> amount;
            private List<int> weight;
            private List<string> name;
            private List<string> description;
            private static int count = 0;

            public List<int> Am
            {
                get 
                {
                    return amount; }
            }
            public List<int> We
            {
                get {
                    return weight; }
            }
            public List<string> Name
            {
                get {
                    return name; }
            }
            public List<string> Description
            {
                get {
                    return description; }
            }

            public List<int> UpdAm()
            {
                Console.WriteLine();
                Console.Write("Insert new amount: ");
                amount.Add(int.Parse(Console.ReadLine()));
                count++;
                Console.WriteLine();
                return amount;
            }
            public List<int> UpdWe()
            {
                Console.WriteLine();
                Console.Write("Insert new weight: ");
                weight.Add(int.Parse(Console.ReadLine()));
                count++;
                Console.WriteLine();
                return weight;
            }
            public List<string> UpdNa()
            {
                Console.WriteLine();
                Console.Write("Add new name: ");
                Name.Add(Console.ReadLine());
                count++;
                Console.WriteLine();
                return Name;
            }
            public List<string> UpdDes()
            {
                Console.WriteLine();
                Console.Write("Add new description: ");
                Description.Add(Console.ReadLine());
                count++;
                Console.WriteLine();
                return Description;
            }
            public Warehouse()
            {
                amount = new List<int> { 10, 20, 40 };
                weight = new List<int> { 0, 100, 20 };
                name = new List<string> {"Hammer", "Nails", "Horseshoe" };
                description = new List<string> {"This is a hammer", "These are nails", "This is a horseshoe" };
                count++;
            }
            public void Remove(int index)
            {
                if (index >= 0 && index < Name.Count)
                {
                    Name.RemoveAt(index);
                    Description.RemoveAt(index);
                    if (index < weight.Count)
                        weight.RemoveAt(index);
                    if (index < amount.Count)
                        amount.RemoveAt(index);
                    count++;
                }
            }
            public void WeCh(int n_w)
            {
                Console.WriteLine();
                Console.Write("Add new weight: ");
                int newWe = int.Parse(Console.ReadLine());
                weight.Add(newWe);
                count++;
            }
            public void NameChange(int n_n, string NN)
            {
                if (n_n > 0 & n_n < Name.Count) {
                    Name[n_n] = NN;
                    count++;
                }
            }
            public Warehouse(int u_am, int u_we, string u_na, string u_desc)
            {
                amount = new List<int> { u_am };
                weight = new List<int> { u_we };
                name = new List<string> { u_na };
                description = new List<string> { u_desc };

            }
            public static int Count => count;
            
        }
        static void Main(string[] args) 
        {
            Warehouse lib = new Warehouse();

            bool cont = true;

            while (cont)
            {
                DisplayInfo(lib);
                Console.WriteLine();
                Console.Write("What do you want to do (Type 'add' if you want to add something and 'remove' if you want to remove something.\nType end if you want to end the program): ");
                string choice = Console.ReadLine();
                    switch (choice.ToLower())
                    {
                        case "add":
                             lib.UpdNa();
                             lib.UpdWe();
                             lib.UpdAm();
                             lib.UpdDes();
                             
                            break;
                        case "remove":
                            Console.Write("Enter index of the product you want to remove (starting from 0): ");
                            if (int.TryParse(Console.ReadLine(), out int index ))
                            {
                                lib.Remove(index);
                                Console.WriteLine($"Total calls: {Warehouse.Count}");
                            break;
                            }
                            break;
                        case "end":
                            Console.WriteLine("Begone, puny mortal!");
                            cont = false;
                            break;
                        default:
                            Console.WriteLine("Stop it, get some help");
                            Console.WriteLine();
                            break;
                }
            }
        }
        static void DisplayInfo(Warehouse lib)
        {
            List<int> am = lib.Am;
            List<int> we = lib.We;
            List<string> name = lib.Name;
            List<string> desc = lib.Description;
            

            for (int i = 0; i < Math.Min(Math.Min(am.Count, we.Count), Math.Min(name.Count, desc.Count)); i++)
            {
                if (i < name.Count) { Console.WriteLine($"Item name: {name[i]}"); }
                Console.WriteLine();
                if (i < we.Count) { Console.WriteLine($"Item weight: {we[i]}"); }
                Console.WriteLine();
                if (i < am.Count) { Console.WriteLine($"Item amount: {am[i]}"); }
                Console.WriteLine();
                if (i < desc.Count) { Console.WriteLine($"Item Description: {desc[i]}"); }
                Console.WriteLine();
                Console.WriteLine($"Total calls {Warehouse.Count}");
                Console.WriteLine();
            }
        }
    }
}