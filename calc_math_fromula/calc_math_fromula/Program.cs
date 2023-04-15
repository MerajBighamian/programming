using System;
namespace Project
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Calc(x, y);

        }

        private static void Calc(int a, int b)
        {
            double result = Math.Sqrt(Math.Abs(a)+Math.Pow(b,2));
            Console.WriteLine(result);
        }
    }
}