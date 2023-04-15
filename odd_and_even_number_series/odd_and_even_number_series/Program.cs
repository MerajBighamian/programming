using System;
using System.Security.Cryptography.X509Certificates;

namespace Project
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            
            if(x %2 == 0)
            {
                even(x);
            }
            else
            {
                odd(x);
            }
        }

        private static void even(int X)
        {
            int sum = 0, zarb = 1;
            for(int i = 2;i<=X;i++)
            {
                sum += i;
                zarb *= i;
            }

            Console.WriteLine("sum of 1 to chosen number : " + sum);
            Console.WriteLine("multiply of 1 to chosen number : " + zarb);
        }

        private static void odd(int X)
        {
            int sum = 0, zarb = 1;
            for (int i = 1; i <= X; i++)
            {
                sum += i;
                zarb *= i;
            }

            Console.WriteLine("sum of 1 to chosen number : " + sum);
            Console.WriteLine("multiply of 1 to chosen number : " + zarb);
        }

    }
}