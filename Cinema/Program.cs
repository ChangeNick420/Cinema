using System;
using System.IO;
namespace Cinema
{
class Program
{
        static void Main(string[] args)
        {
            string login="";
            string account="";
            string password="";
            string rlogin="";
            string rpassword="";
            string name = "";    
            int age=0;
            int i = 0;
            string line = "";
            
            
            try
            {
                StreamWriter write = new StreamWriter(@"C:\Users\LENOVO\source\repos\ChangeNick420\Cinema"); line = read.ReadLine();
                
                    write.WriteLine(rlogin);
                write.WriteLine(rpassword);
                write.WriteLine(name);

                    
                
                write.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {

            }

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
                        if (login == line && password == line)
                        {
                            Console.WriteLine("Access Granted");
                        }
                        else if (login != line || password != line)
                        {
                            Console.WriteLine("Access Denied. Try again");
                        }
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
                    }
                }
                while (i == 0);


                    Console.WriteLine("Hello {0}", name);
                    Console.ReadLine();
                
                
                }  //main args
}//program
}//Namespace