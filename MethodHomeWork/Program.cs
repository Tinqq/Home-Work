namespace MethodHomeWork
{
    internal class Program
    {

        static void PIKACHU()
        {
            
            Console.WriteLine("You have 3 time to make arithmetic operations. So, Let's start..");
            
            try
            {
                for (int attemp = 1; attemp <= 3; attemp++) 
                {
                    int result;
                    Console.WriteLine($"Attemp number {attemp}. \nInput first value");
                    int one = int.Parse(Console.ReadLine());

                    Console.WriteLine("Input Second Value");
                    int second = int.Parse(Console.ReadLine());

                    Console.WriteLine("Input Operator: +, -, *, /, ^");
                    char oper = char.Parse(Console.ReadLine());


                    if (oper == '+')
                    {
                        result = one + second;
                        Console.WriteLine($"Sum of {one} and {second} will be {result}");

                    }

                    if (oper == '-')
                    {
                        result = one - second;
                        Console.WriteLine($"Difference of {one} and {second} will be {result}");
                    }


                    if (oper == '*')
                    {
                        result = one * second;
                        Console.WriteLine($"Multiplication of {one} and {second} will be {result}");
                    }

                    if (oper == '/')
                    {
                        result = one / second;
                        Console.WriteLine($"The division difference of {one} and {second} will be {result}");
                    }

                    if (oper == '^')
                    {
                        result = one ^ second;
                        Console.WriteLine($"exponentiation of {one} and {second} will be {result}");
                    }   
                    //Or another way:
                    /*switch (oper)
                        {
                            case '+':
                                result = one + second;
                                Console.WriteLine($"Sum of {one} and {second} will be {result}");
                                break;

                            case '-':
                                result = one - second;
                                Console.WriteLine($"Difference of {one} and {second} will be {result}");
                                break;

                            case '*':
                                result = one * second;
                                Console.WriteLine($"Multiplication of {one} and {second} will be {result}");
                                break;

                            case '/':
                                result = one / second;
                                Console.WriteLine($"The division difference of {one} and {second} will be {result}");
                                break;

                            case '^':
                                result = one ^ second;
                                Console.WriteLine($"exponentiation of {one} and {second} will be {result}");
                                break;


                        }*/
                }


                 
            }
            catch (DivideByZeroException)//or catch(Exception - for all field's: int: for FormatExeption + DivideByZeroException)
            {
                Console.WriteLine("U can't dividing by zero.");
                
            }

        }


        static void Main(string[] args)
            {
            Console.WriteLine("PIKACHU I CALL YOU");
            PIKACHU();
            }
        }
    }

