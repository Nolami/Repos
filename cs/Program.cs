using System;

namespace MyApp
{
    internal class Program
    {

        private static readonly string filepath= @"D:/File/pass.txt";
        
        static void Main(string[] args)
        {
            Console.Write("Kirjoita 0 tai 1 (0 vie registrointiin ja 1 lopettaa): ");
            int binary = int.Parse(Console.ReadLine());
            if (binary == 0)
            {
                Console.WriteLine();
                Console.Write("Kirjoita 0 tai 1 (Registroi tai kirjautu) ");
                int ch = int.Parse(Console.ReadLine());
                if (ch == 0) {
                    var (nimi, sal, cpw) = registering();

                    if (nimi == null || sal == null || cpw == null)
                    {
                        Console.WriteLine("Womp Womp");
                    } else
                    {
                        Console.WriteLine($"Welcome {nimi}");
                    }
                }
                else if (ch == 1)
                {
                    bool suc = login();

                    if(!suc)
                    {
                        Console.WriteLine("Login failed");
                    }
                }
            }
            else if (binary == 1)
            {
                Console.Write("Lopetetaan... ");
                Thread.Sleep(3000);
                return;
            } else
            {
                Console.WriteLine("Numero ei voi olla yli yhden");
            }
        }
        private static void WriteToFile(string username, string password)
        {
            using (StreamWriter writer = new StreamWriter(filepath, true))
            {
                writer.WriteLine($"{username}:{password}");
            }
        }
        
        private static (string nimi, string sal, string cpw) registering()
        {
            Console.Write("Syötä käyttäänimesi: ");
            string nimi = Console.ReadLine();
            Console.Write("Syötä salasana: ");
            string sal = ReadPassword();
            Console.Write("Confirm password: ");
            string cpw = ReadPassword();
            
            try
            {
                WriteToFile(nimi, sal);
                Console.WriteLine("Rekistrointi onnistui!");
                return (nimi, sal, cpw);
            } catch (Exception ex)
            {
                Console.WriteLine($"Womp Womp: {ex.Message}");
                return (null, null, null);
            }
            
            
        }
        private static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
                else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Substring(0, password.Length - 1);
                    Console.Write("\b \b");
                }
            } while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();
            return password;
        }
        private static bool login()
        {
            Console.Write("Syötä käyttäjänimesi: ");
            string nimi = Console.ReadLine();
            Console.Write("Syöta salasana: ");
            string sal = ReadPassword();

            try
            {
                foreach(var line in File.ReadLines(filepath))
                {
                    var parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        string stus = parts[0];
                        string stpw = parts[1];

                        if (nimi == stus && sal == stpw)
                        {
                            Console.WriteLine("Login sucessful!");
                            return true;
                        }
                    }
                }
                Console.WriteLine("Invalid username or password");
                return false;
            } catch(Exception ex)
            {
                Console.WriteLine($"Error reading input {ex}");
                return false;
            }
            
        }
    }


}