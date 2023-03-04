using System;

namespace App
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] numbers = new int[10,10];
            int choose_number_1, choose_number_2;
            int number_existed_1 = 0, number_existed_2 = 0;

            // get items of array from user
            Console.WriteLine("please enter number of array : ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    numbers[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            
            Console.WriteLine("please enter choose number 1: ");
            choose_number_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter choose number 2: ");
            choose_number_2 = Convert.ToInt32(Console.ReadLine());

            // search in array for exist chosen number
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (numbers[i,j] == choose_number_1)
                    {
                        number_existed_1 += 1;
                    }

                    else if (numbers[i,j] == choose_number_2)
                    {
                        number_existed_2 += 1;
                    }
                }
            }

            // output
            Console.WriteLine($"number of repeated chosen number 1 in this array is : {number_existed_1}");
            Console.WriteLine($"number of repeated chosen number 2 in this array is : {number_existed_2}");


        }
    }
}