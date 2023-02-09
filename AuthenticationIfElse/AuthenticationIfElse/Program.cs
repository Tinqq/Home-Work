using System;

namespace AuthenticationIfElse
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            
            string password;
            System.Console.WriteLine("Input Login");
            string username = Console.ReadLine();

            if (username == "USER")
            {
                Console.WriteLine("Input Password");
                password = Console.ReadLine();
                if (password == "secretPass")
                {
                    Console.WriteLine("Hello User");
                }
                else
                {
                    Console.WriteLine("Incorrect Password");
                }
            }
            if (username == "ADMIN")
            {
                Console.WriteLine("Input Password");
                password = Console.ReadLine();

                if (password == "secretPass")
                {
                    Console.WriteLine("Hello Administrator");
                }
                else
                {
                    Console.WriteLine("Incorrect Password");
                }
            }

                    if (username == string.Empty)
                    {
                        Console.WriteLine("Hello Anonimus");
                    }
                










            }
        }
    }
