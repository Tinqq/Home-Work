namespace AuthenticationIfElse
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            string password;

            Console.WriteLine("Input login");
            string username = Console.ReadLine();

           
// постіні та дублюючі значення краще виносити в константи const string USER = "USER";
            if (username == "USER")
            {
                // постіні та дублюючі значення краще виносити в константи const string ASK_PASSWORD = "Input Password: "; та переюзувати по всіх місцях
                Console.WriteLine("Input Password: ");
                password = Console.ReadLine();

                if(password != "secretPass") //ДЛЯ ОТОБРАЖЕНИЯ УВЕДОМЛЕНИЯ О ВВЕДЕНИИ ПОДОЙДЁТ ЛЮБОЙ СИМВОЛ\СИМВОЛЫ, КРОМЕ secretPass
                {
                    Console.WriteLine("Password is not correct");
                }
// тут краще поміняти місцями та спочатку перевірити на if (password == "secretPass") а в else просто вивести Console.WriteLine("Password is not correct"); тоді на 1 перевірку буде меньш
                else if (password == "secretPass") //ДЛЯ КОРРЕКТНОГО ОТОБРАЖЕНИЯ ПРИВЕТСТВИЯ ПОЛЬЗОВАТЕЛЯ
                {
                    Console.WriteLine("Hello User!");
                }

            }
            else if (username == "ADMIN")
            {
                Console.WriteLine("Input Password: ");
                password = Console.ReadLine();

                if (password != "secretPass")  //ДЛЯ ОТОБРАЖЕНИЯ УВЕДОМЛЕНИЯ О ВВЕДЕНИИ ПОДОЙДЁТ ЛЮБОЙ СИМВОЛ\СИМВОЛЫ, КРОМЕ secretPass
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
