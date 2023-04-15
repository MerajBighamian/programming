using System;
namespace Project
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            Calc(x);


        }

        private static void Calc(int x)
        {
            double result = Math.Pow(x,2)+(2*x)-4;
            Console.WriteLine(result);
        }
    }
}