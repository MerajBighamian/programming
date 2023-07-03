﻿using System;

namespace SudokuSolver
{
    public class Sudoku
    {
        // base puzzle
        private int[,] puzzle;

        // setter and getter for sudoko puzzle
        public Sudoku(int[,] puzzle)
        {
            this.puzzle = puzzle;
        }

        // method for solve sodoku puzzle
        public bool Solve()
        {
            // use backtracking algorithm to solve sudoku puzzle.
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (puzzle[i, j] == 0)
                    {
                        for (int num = 1; num <= 9; num++)
                        {
                            if (IsSafe(i, j, num))
                            {
                                puzzle[i, j] = num;

                                // If the puzzle is solved, return true.
                                if (Solve())
                                    return true;

                                // backtrack and try another number.
                                puzzle[i, j] = 0;
                            }
                        }

                        // If we reach this point, the puzzle is not solvable.
                        return false;
                        Console.WriteLine("puzzle is not solved!");

                    }
                }
            }

            // The puzzle is solved.
            return true;
        }

        private bool IsSafe(int row, int col, int num)
        {
            // Check number in row
            for (int i = 0; i < 9; i++)
            {
                if (puzzle[row, i] == num)
                    return false;
            }

            // Check number in column
            for (int i = 0; i < 9; i++)
            {
                if (puzzle[i, col] == num)
                    return false;
            }

            // Check number in 3x3 block
            int blockRow = row / 3;
            int blockCol = col / 3;
            for (int i = blockRow * 3; i < blockRow * 3 + 3; i++)
            {
                for (int j = blockCol * 3; j < blockCol * 3 + 3; j++)
                {
                    if (puzzle[i, j] == num)
                        return false;
                }
            }

            // the number is safe in position.
            return true;
        }

        public static void Main()
        {

            // create sudoku puzzle.
            int[,] puzzle = new int[9, 9];
            // test sudoku
            //puzzle[0, 0] = 1;
            //puzzle[0, 1] = 2;
            //puzzle[1, 2] = 3;
            //puzzle[0, 3] = 4;
            //puzzle[0, 4] = 5;
            //puzzle[3, 5] = 6;
            //puzzle[0, 6] = 7;
            //puzzle[7, 7] = 4;
            //puzzle[7, 8] = 9;

            for (int i = 0; i < 9; i++)
            {
                for(int j = 0; j<9; j++)
                {
                    Console.WriteLine("Please enter value of element row {1} and column {0} (for blank enter one space) :", j+1, i+1);
                    string userInput = Console.ReadLine();
                    if(userInput == " ")
                    {
                        userInput = "0";
                    }
                    puzzle[i, j] = Convert.ToInt32(userInput);
                }
            }

            // create sudoku object
            Sudoku sudoku = new Sudoku(puzzle);

            //solve sodoku puzzle.
            bool solved = sudoku.Solve();

            // print sudoko solved
            if (solved)
            {
                Console.WriteLine('\n');
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Console.Write(sudoku.puzzle[i, j] + " | ");
                        
                    }
                    Console.WriteLine("\n-----------------------------------");
                }
            }
            else
            {
                Console.WriteLine("The puzzle is not solvable.");
            }
        }
    }
}
