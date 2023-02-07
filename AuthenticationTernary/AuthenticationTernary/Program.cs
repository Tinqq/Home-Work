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
                string hello = (password == "secretPass") ? "Hello User!" : "Password is not correct"; //ДЛЯ ПОЛУЧЕНИЯ СООБЩЕНИЯ О НЕПРАВИЛЬНОМ ВВОДЕ ПАРОЛЯ МОЖНО ВВЕСТИ ЛЮБУЮ СТРОКУ\СИМВОЛ
                Console.WriteLine(hello);
            }

            if (username == "ADMIN")
            {
                Console.WriteLine("Input Password: ");
                string password = Console.ReadLine();
                string hello = (password == "secretPass") ? "Hello Administrator!" : "Password is not correct"; //ДЛЯ ПОЛУЧЕНИЯ СООБЩЕНИЯ О НЕПРАВИЛЬНОМ ВВОДЕ ПАРОЛЯ МОЖНО ВВЕСТИ ЛЮБУЮ СТРОКУ\СИМВОЛ
                Console.WriteLine(hello);
            }
            
            
            string world = "Hello Anonimous";
            switch (username)
            {
                
                case "":
                    Console.WriteLine(world);
                    break;
            }

            /*if (username == "")
            {
                string world = "Hello Anonimous";
                Console.WriteLine(world);

            }*/
            
            
            /*string hello2 = (username == "") ? "Hello Anonimous" : ""; - Хотел сделать так, но там постоянно выводит при корректных\некорректных данных в других случаях пустую строку,
            а это не красиво и неправильно. ПО этому создал переменную и при условии вывел её в консоль через иф\свитч
            Console.WriteLine(hello2);*/


        }
    }
}



