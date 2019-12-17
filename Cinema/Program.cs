using System;
using System.IO;
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
            //StreamReader read = new StreamReader(@"C:\Users\5202616\source\repos\ChangeNick420\Cinema");
            string FilePath = @"C:\Users\5202616\source\repos\ChangeNick420\Cinema";
            string test=File.ReadAllText(@"C:\Users\5202616\source\repos\ChangeNick420\Cinema");
            
            foreach (string in line in line)
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
                    


                    File.WriteAllText(FilePath, login, password, );
                }
            } while (i == 0);
            Console.WriteLine("Hello {0}", name);
            Console.ReadLine();
            
        }//main args
}//program
}//Namespace
    