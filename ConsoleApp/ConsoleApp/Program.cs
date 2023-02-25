using System;

namespace App
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input_1 = Console.ReadLine();
            string input_2 = Console.ReadLine();   
            int num_1 = Convert.ToInt32(input_1);
            int num_2 = Convert.ToInt32(input_2);
            Console.WriteLine(num_1 + num_2);

        }
    }
}