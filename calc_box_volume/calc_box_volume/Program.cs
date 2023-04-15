using System;
namespace Project
{
    class Program
    {
        public static void Main(string[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            int w = Convert.ToInt32(Console.ReadLine());

            double show = Calc(l, h, w);
            Console.WriteLine(show);

        }

        private static double Calc(int num1, int num2 ,int num3)
        {
            double result = num1 * num2 * num3;
            return result;
        }
    }
}