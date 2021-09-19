using System;

namespace If_Statement
{
    class Program
    { static string userName;
        static string password;
        //We need to create static variables to be able to called them thourgh out multiples methods
        static bool loginSucesseful;

        static void Main(string[] args)
        {
            Registration();
            Login();
            Console.WriteLine(loginSucesseful);

            Console.Read();

        }

        public static void Registration()    // Method to register user credentials
        {
            Console.WriteLine("Please create your Username");
            userName = Console.ReadLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Please create your Password");
            password = Console.ReadLine();

        }

        public static void Login() // Method to login

        {
            Console.WriteLine("Please add your Username");

            if (userName == Console.ReadLine())
            {
                Console.WriteLine("Please add your Password");
                if (password == Console.ReadLine())
                {
                    loginSucesseful = true;
                    Console.WriteLine("Login Sucessful");
                }
                else
                {
                    Console.WriteLine("Password incorrect");
                }
            }
            else
            {
                Console.WriteLine("UserName incorrect");
            }

        }
    }
}
