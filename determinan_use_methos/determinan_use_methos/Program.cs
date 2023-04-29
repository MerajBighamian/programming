using System;

namespace Calc_Determinan_With_Csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] numbers_array = new int[3, 3];
            int determinan;

            // get items of array from user
            Console.WriteLine("please enter number of array : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    numbers_array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            determinan = CalcDeterminanWithCsharp(numbers_array);
           if(determinan != 0)
            {
                int[,] reverse_matrix = ReverseMatrix(determinan, numbers_array);
            }

            else
            {
                Console.WriteLine("not exist reverse matrix !!");
            }

            // output (calculated determinan)
            Console.WriteLine($"the determian of this array is : {determinan} ");
        }


        public static int CalcDeterminanWithCsharp(int[,] numbers )
        {
            int determinan;
            // calculate determinan
            determinan = (numbers[0, 0] * ((numbers[1, 1] * numbers[2, 2]) - (numbers[1, 2] * numbers[2, 1]))) - (numbers[0, 1] * ((numbers[1, 0] * numbers[2, 2]) - (numbers[1, 2] * numbers[2, 0]))) + (numbers[0, 2] * ((numbers[1, 0] * numbers[2, 1]) - (numbers[1, 1] * numbers[2, 0])));
            return determinan;


        }

        public static int[,] ReverseMatrix(int determinan_value, int[,] numbers)
        {


                for(int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        numbers[i,j] =  numbers[i,j] / determinan_value;
                    }       
                }
                return numbers;




        }
    }
}
