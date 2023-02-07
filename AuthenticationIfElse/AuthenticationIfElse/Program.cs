namespace AuthenticationIfElse
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            string password;

            Console.WriteLine("Input login");
            string username = Console.ReadLine();

           

            if (username == "USER")
            {
                Console.WriteLine("Input Password: ");
                password = Console.ReadLine();

                if(password != "secretPass") //ДЛЯ ОТОБРАЖЕНИЯ УВЕДОМЛЕНИЯ О ВВЕДЕНИИ НЕКОРРЕКТНОГО ПАРОЛЯ
                {
                    Console.WriteLine("Password is not correct");
                }

                else if (password == "secretPass") //ДЛЯ КОРРЕКТНОГО ОТОБРАЖЕНИЯ ПРИВЕТСТВИЯ ПОЛЬЗОВАТЕЛЯ
                {
                    Console.WriteLine("Hello User!");
                }

            }
            else if (username == "ADMIN")
            {
                Console.WriteLine("Input Password: ");
                password = Console.ReadLine();

                if (password != "secretPass")  //ДЛЯ ОТОБРАЖЕНИЯ УВЕДОМЛЕНИЯ О ВВЕДЕНИИ НЕКОРРЕКТНОГО ПАРОЛЯ
                {
                    Console.WriteLine("Password is not correct");
                }

                 if (password == "secretPass") //ДЛЯ КОРРЕКТНОГО ОТОБРАЖЕНИЯ ПРИВЕТСТВИЯ ПОЛЬЗОВАТЕЛЯ
                {
                    Console.WriteLine("Hello Administrator");
                }
            }
            else if (username == "") //ДЛЯ ОТОБРАЖЕНИЯ ПРИВЕТСТВИЯ ПОЛЬЗОВАТЕЛЯ СО ЗНАЧЕНИЕМ НЕИЗВЕСТЕН
            {
                Console.WriteLine("Hello Anonimous");
            }

           
        }
    }
}
