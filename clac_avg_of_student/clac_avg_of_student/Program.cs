using System;
using System.Security.Cryptography.X509Certificates;

namespace Project
{
    class Program
    {
        public static void Main(string[] args)
        {
            double mid = Convert.ToDouble(Console.ReadLine());
            double final = Convert.ToDouble(Console.ReadLine());


            double result = Calc(mid, final);
            if(result >= 10)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Faild");
            }

        }

        private static double Calc(double Mid, double Final)
        {
            double result = (Mid * 0.35) + (Final * 0.65);
            return result;
        }
    }
}