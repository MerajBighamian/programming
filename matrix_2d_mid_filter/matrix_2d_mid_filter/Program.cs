using System;

namespace App
{
    class Project
    {
        public static int size_of_matrix = 50; 
        static void Main()
        {
            double[,] matrix = new double[size_of_matrix, size_of_matrix];
            //? Fill matrix with user input
            matrix = fill_matrix(matrix);
            //? Filter matrix
            matrix = filter_matrix(matrix);
            print_matrix(matrix);
        }

        private static void print_matrix(double[,] matrix)
        {
            for (int i = 0; i < size_of_matrix; i++)
            {
                for (int j = 0; j < size_of_matrix; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.Write("\n");
            }
        }

        private static double[,] fill_matrix(double[,] matrix)
        {
            for (int i = 0; i < size_of_matrix; i++)
            {
                for (int j = 0; j < size_of_matrix; j++)
                {
                    Console.WriteLine("Please Enter [" + i + "] , [" + j + "]  element: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matrix;
        }

        private static double[,] filter_matrix(double[,] matrix)
        {
            double temp_avg = 0;
            // start from 1 because avg filter not read start and end index
            for (int i = 1; i < size_of_matrix - 1; i++)
            {
                // start from 1 because avg filter not read start and end index
                for (int j = 1; j < size_of_matrix - 1; j++)
                {

                    
                    for (int a = i - 1; a <= i + 1; a++)
                    {
                        for (int b = j - 1; b <= j + 1; b++)
                        {

                            Console.Write(matrix[a, b] + "-");
                            temp_avg += matrix[a, b];
                        }
                    }
                    Console.WriteLine("sum: " + temp_avg);
                    Console.WriteLine("avg: " + temp_avg / 9);
                    matrix[i, j] = temp_avg / 9;
                    // reset temp_avg variable for next iterate
                    temp_avg = 0;
                }
            }

            return matrix;
        }

    }
}