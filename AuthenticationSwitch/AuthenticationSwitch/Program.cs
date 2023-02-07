namespace AuthenticationIfElse
{
    internal class Program
    {


        static void Main(string[] args)
        {

            string password;

            Console.WriteLine("Input login");
            string username = Console.ReadLine();

            switch (username)
            {
                case "USER":
                    Console.WriteLine("Input Password: ");
                    password = Console.ReadLine();
                    switch (password)
                    {
                        case "secretPass": //ДЛЯ КОРРЕКТНОГО ОТОБРАЖЕНИЯ ПРИВЕТСТВИЯ ПОЛЬЗОВАТЕЛЯ
                            Console.WriteLine("Hello User");
                            break;
                    }
                    switch (password)
                    {
                        case "incorrectPass": //ДЛЯ ОТОБРАЖЕНИЯ УВЕДОМЛЕНИЯ О ВВЕДЕНИИ НЕКОРРЕКТНОГО ПАРОЛЯ
                            Console.WriteLine("Password is not correct"); ;
                            break;
                    }
                    break;
            }
            switch (username)
            {
                case "ADMIN":
                    Console.WriteLine("Input Password: ");
                    password = Console.ReadLine();

                    switch (password)
                    {
                        case "secretPass": //ДЛЯ КОРРЕКТНОГО ОТОБРАЖЕНИЯ ПРИВЕТСТВИЯ ПОЛЬЗОВАТЕЛЯ
                            Console.WriteLine("Hello Administrator ");
                            break;
                    }
                    switch (password)
                    {
                        case "incorrectPass": //ДЛЯ ОТОБРАЖЕНИЯ УВЕДОМЛЕНИЯ О ВВЕДЕНИИ НЕКОРРЕКТНОГО ПАРОЛЯ
                            Console.WriteLine("Password is not correct"); ;
                            break;
                    }
                    break;


            }
            switch (username)
            {
                case "": //ДЛЯ ОТОБРАЖЕНИЯ ПРИВЕТСТВИЯ ПОЛЬЗОВАТЕЛЯ СО ЗНАЧЕНИЕМ НЕИЗВЕСТЕН
                    Console.WriteLine("Hello Anonimous");
                    break;
            }


        }
    }
}
