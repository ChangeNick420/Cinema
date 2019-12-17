using System;

namespace Cinema
{
class Program
{
        static void Main(string[] args)
        {
            string login;
            string account;
            string password;
            string rlogin;
            string rpassword;
            string name = "";
            int age;
            int i = 0;
            string FilePath = @"C:\Users\5202616\source\repos\Cinema";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to Gloucester Cinema.| \n________________________________________________________|");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Have you got an existing account? Yes/No");
                account = Console.ReadLine().ToUpper();
                if (account == "YES")
                {
                    Console.Write("Login:");
                    login = Console.ReadLine();
                    Console.Write("Password");
                    password = Console.ReadLine();
                    i++;
                }
                else if (account == "NO")
                {
                    Console.Write("Create Login:");
                    login = Console.ReadLine();
                    Console.Write("Create Password:");
                    password = Console.ReadLine();
                    Console.Write("Name:");
                    name = Console.ReadLine();
                    Console.Write("Age:");
                    age = Convert.ToInt32(Console.ReadLine());
                    i++;
                    lines.Add(login, password, name, age);
                    File.WriteAllLines(FilePath, lines);
                }
            } while (i == 0);
            Console.WriteLine("Hello {0}", name);
            Console.ReadLine();

        }//main args
}//program
}//Namespace
    