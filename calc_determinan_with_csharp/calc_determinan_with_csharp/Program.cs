using System;

namespace Calc_Determinan_With_Csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] numbers = new int[3, 3];
            int determinan;

            // get items of array from user
            Console.WriteLine("please enter number of array : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    numbers[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // calculate determinan
            determinan = (numbers[0,0] * ((numbers[1,1] * numbers[2,2]) - (numbers[1,2] * numbers[2,1]))) - (numbers[0,1] * ((numbers[1,0] * numbers[2,2]) - (numbers[1,2] * numbers[2,0]))) + (numbers[0,2] * ((numbers[1,0] * numbers[2,1]) - (numbers[1,1] * numbers[2,0])));

            // output (calculated determinan)
            Console.WriteLine($"the determian of this array is : {determinan} ");
        }
    }
}