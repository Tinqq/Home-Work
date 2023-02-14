

using System;

namespace ROMB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void PrintDiamond(int n = 7)
            {
                // Upper half of the diamond
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k <= i; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                // Lower half of the diamond
                for (int i = n - 2; i >= 0; i--)
                {
                    for (int j = 0; j < n - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k <= i; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            PrintDiamond();
        }
    }
}
