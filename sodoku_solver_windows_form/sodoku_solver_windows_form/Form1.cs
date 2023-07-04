namespace sodoku_solver_windows_form
{
    public partial class Form1 : Form
    {
        private int[,] board = new int[9, 9];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void buttonSolve_Click(object sender, EventArgs e)
        {
            // Solve the Sudoku puzzle.
            bool solved = SolveSudoku(board);

            // If the puzzle is solved, show the solution.
            if (solved)
            {
                textBoxSolution.Text = "";
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        textBoxSolution.Text += board[i, j].ToString() + " | ";

                    }
                    textBoxSolution.Text += "\n------------------------------";
                    textBoxSolution.Text += "\n------------------------------";
                }
            }
            else
            {
                textBoxSolution.Text = "The puzzle is not solvable.";
            }
        }

        private bool SolveSudoku(int[,] board)
        {
            // Backtracking algorithm to solve the Sudoku puzzle.
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] == 0)
                    {
                        for (int num = 1; num <= 9; num++)
                        {
                            if (IsSafe(board, i, j, num))
                            {
                                board[i, j] = num;

                                // If the puzzle is solved, return true.
                                if (SolveSudoku(board))
                                    return true;

                                // Otherwise, backtrack and try another number.
                                board[i, j] = 0;
                            }
                        }

                        // If we reach this point, the puzzle is not solvable.
                        return false;
                    }
                }
            }

            // The puzzle is solved.
            return true;
        }

        private bool IsSafe(int[,] board, int row, int col, int num)
        {
            // Check if the number is already in the row.
            for (int i = 0; i < 9; i++)
            {
                if (board[row, i] == num)
                    return false;
            }

            // Check if the number is already in the column.
            for (int i = 0; i < 9; i++)
            {
                if (board[i, col] == num)
                    return false;
            }

            // Check if the number is already in the 3x3 block.
            int blockRow = row / 3;
            int blockCol = col / 3;
            for (int i = blockRow * 3; i < blockRow * 3 + 3; i++)
            {
                for (int j = blockCol * 3; j < blockCol * 3 + 3; j++)
                {
                    if (board[i, j] == num)
                        return false;
                }
            }

            // The number is safe.
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

