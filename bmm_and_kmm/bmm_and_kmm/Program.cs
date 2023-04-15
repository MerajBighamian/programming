using System;
namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter number_1 : ");
            int number_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter number_2 : ");
            int number_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kmm is : {0}",kmm(number_1, number_2));
            Console.WriteLine("bmm is : {0}", bmm(number_1, number_2));
        }
        public static int kmm(int a, int b)
        {
            int max = 0;
            if (a > b)
            {
                max = a;
            }
            else max = b;

            while (true)
            {

                if (max % a == 0 && max % b == 0) break;
                else ++max;
            }
            return max;


        }

        public static int bmm(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = b;
                }
                else
                {
                    b -= a;
                }
                    
            }
            return a;

        }
    }
}