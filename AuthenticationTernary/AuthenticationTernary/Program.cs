using System;

namespace AuthenticationTernary
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
 

                Console.WriteLine("Input login");
            string username = Console.ReadLine();

            if (username == "USER")
            {
                Console.WriteLine("Input Password: ");
                string password = Console.ReadLine();
                string hello = (password == "secretPass") ? "Hello User!" : "Password is not correct";
                Console.WriteLine(hello);
            }

            if (username == "ADMIN")
            {
                Console.WriteLine("Input Password: ");
                string password = Console.ReadLine();
                string hello = (password == "secretPass") ? "Hello Administrator!" : "Password is not correct";
                Console.WriteLine(hello);
            }

            if (username == "")
            {
                Console.WriteLine("Hello Anonimous");
                
            }


        }
    }
}



