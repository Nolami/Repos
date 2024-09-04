using System;
namespace Creature
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;
            private int birthyear;

            public string Name //This is name
            {
                get {  return name; }
                set {  name = value; }
            }
            public int Age //Here we got age
            {
                get {  return age; } set {  age = value; }
            }
            public int Birthyear //And the birthyear
            {
                get { return birthyear; } set { birthyear = value; }
            }
            public Person() //constructur
            {
                name = "";
                age = 0;
                birthyear = 0;
            }
            public Person(string names, int birthyears) //overloaded
            {
                name = names;
                birthyear = birthyears;
            }
            public void SetInfo()// info
            {
                Console.Write("Set your name: ");
                name = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Set your birthyear: ");
                birthyear = int.Parse(Console.ReadLine());

                Console.WriteLine("Used the SetInfo method");
            }
            public void CalcAge(int birth) //Calculate age
            {
                age = DateTime.Now.Year - birth; //that functions simply calls the current year, so it can be used always
            }
            public string ReturnName() //Return the name
            {
                Console.WriteLine();
                string sent = $"Greetings, {name}";

                Console.WriteLine("Used the ReturnName method");
                return sent;
            }
            public string ReturnAge() //return the age
            {
                int age = Age;
                Console.WriteLine();
                string sent = $"You are/just turned {age} years old";

                Console.WriteLine("Used the ReturnAge method");
                return sent;
            }


        }
        static void Main(string[] args)
        {
            Person lib = new Person();
            string named = "Jones";
            int birthyeard = 1940;
            Person lib2 = new Person(named, birthyeard);
            lib2.CalcAge(birthyeard);
            string name = lib2.ReturnName();
            string age = lib2.ReturnAge();

            Console.WriteLine(name + " " + age);
            
            lib.SetInfo();
            int birthyear = lib.Birthyear;
            lib.CalcAge(birthyear);
            name = lib.ReturnName();
            age = lib.ReturnAge();

            Console.WriteLine(name+ " " + age);

        }
    }
}