using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueensProblem
{
    public partial class Form1 : Form
    {

        int boardSize = 8, spacing = 10, buttonSize = 50, counter, displayCounter, x, y, queenCounter;
        bool userPower = false;
        Button[,] board;
        int[,] numBoard;
        int[] solutions = new int[0];

        private void CreateBoard()
        {
            //creating board
            board = new Button[boardSize, boardSize];
            numBoard = new int[boardSize, boardSize];

            int tagCounter = 0;
            for (int x = 0; x < boardSize; x++)
            {
                for (int y = 0; y < boardSize; y++)
                {
                    board[y, x] = new Button();
                    board[y, x].Size = new Size(buttonSize, buttonSize);
                    board[y, x].Location = new Point(x * buttonSize, y * buttonSize);
                    if (x % 2 == y % 2)
                        board[y, x].BackColor = Color.SaddleBrown;
                    else
                        board[y, x].BackColor = Color.Moccasin;
                    panel1.Controls.Add(board[y, x]);
                    board[y, x].Tag = tagCounter;
                    board[y, x].FlatStyle = FlatStyle.Flat;
                    board[y, x].Click += Form1_Click;

                    tagCounter++;
                }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((Button)(sender)).Tag.ToString());

            int bx = id % boardSize;
            int by = id / boardSize;

            if (userPower && numBoard[by, bx] != 2)
            {
                
                //if clicked button is empty, put a queen on it
                if (numBoard[by, bx] == 0)
                {
                    board[bx, by].BackColor = Color.Black;
                    numBoard[by, bx] = 1;
                    queenCounter++;

                    //paint the tiles that aren't an option anymore
                    int column = bx;
                    int row = by;

                    //going over the queen's row
                    for (int x = 0; x < boardSize; x++)
                    {
                        if (x != column)
                        {
                            board[x, row].BackColor = Color.Red;
                            numBoard[row, x] = 2;
                        }
                    }

                    //going over the queen's column
                    for (int y = 0; y < boardSize; y++)
                    {
                        if (y != row)
                        {
                            board[column, y].BackColor = Color.Red;
                            numBoard[y, column] = 2;
                        }

                    }

                    //going over diagonals
                    x = column;
                    y = row;
                    while (true)
                    {
                        if (x < boardSize - 1 && y < boardSize - 1)
                        {
                            x++;
                            y++;
                        }
                        else
                            break;
                        board[x, y].BackColor = Color.Red;
                        numBoard[y, x] = 2;

                    }

                    x = column;
                    y = row;
                    while (true)
                    {
                        if (x > 0 && y > 0)
                        {
                            x--;
                            y--;
                        }
                        else
                            break;
                        board[x, y].BackColor = Color.Red;
                        numBoard[y, x] = 2;

                    }

                    x = column;
                    y = row;
                    while (true)
                    {
                        if (x > 0 && y < boardSize - 1)
                        {
                            x--;
                            y++;
                        }
                        else
                            break;
                        board[x, y].BackColor = Color.Red;
                        numBoard[y, x] = 2;
                    }

                    x = column;
                    y = row;
                    while (true)
                    {
                        if (x < boardSize - 1 && y > 0)
                        {
                            x++;
                            y--;
                        }
                        else
                            break;
                        board[x, y].BackColor = Color.Red;
                        numBoard[y, x] = 2;

                    }

                    if (queenCounter == boardSize)
                    {
                        MessageBox.Show("Congrats Dude");
                        userPower = false;
                    }
                }

                if (queenCounter > 0)
                {
                    Try.Text = "Try Again";
                }
                else
                    Try.Text = "Try Yourself";
            }
        }

        private void DeleteBoard()
        {
            for (int x = 0; x < boardSize; x++)
            {
                for (int y = 0; y < boardSize; y++)
                {
                    board[x, y].Dispose();
                }
            }
        }

        private bool isClash(int column, int row)
        {
            //going over the queen's row
            for (int x = 0; x < boardSize - 1; x++)
            {
                if (x != column && numBoard[row, x] == 1)
                    return true;
            }

            //going over the queen's column
            for (int y = 0; y < boardSize - 1; y++)
            {
                if (y != row && numBoard[y, column] == 1)
                    return true;
            }

            //going over diagonals
            x = column;
            y = row;
            while (true)
            {
                if (x < boardSize - 1 && y < boardSize - 1)
                {
                    x++;
                    y++;
                }
                else
                    break;
                if (numBoard[y, x] == 1)
                    return true;
            }

            x = column;
            y = row;
            while (true)
            {
                if (x > 0 && y > 0)
                {
                    x--;
                    y--;
                }
                else
                    break;
                if (numBoard[y, x] == 1)
                    return true;
            }

            x = column;
            y = row;
            while (true)
            {
                if (x > 0 && y < boardSize - 1)
                {
                    x--;
                    y++;
                }
                else
                    break;
                if (numBoard[y, x] == 1)
                    return true;
            }

            x = column;
            y = row;
            while (true)
            {
                if (x < boardSize - 1 && y > 0)
                {
                    x++;
                    y--;
                }
                else
                    break;
                if (numBoard[y, x] == 1)
                    return true;
            }

            // if no clash is found
            return false;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            DeleteBoard();
            CreateBoard();


            //display solutions

            for (int i = 0; i < boardSize; i++)
            {
                board[solutions[displayCounter], solutions[displayCounter + 1]].BackColor = Color.Black;

                displayCounter += 2;
            }

            if (displayCounter == solutions.Length)
            {
                Next.Enabled = false;
                Next.BackColor = Color.Red;
            }
               

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Try_Click(object sender, EventArgs e)
        {
            DeleteBoard();
            CreateBoard();

            Next.Enabled = false;
            Next.BackColor = Color.Red;
            Try.Text = "Try Yourself";

            userPower = true;
            queenCounter = 0;
        }   

        private void SolveQueens()
        {
            Array.Resize(ref solutions, 0);
            SolveQueens(0, 0);
        }

        private void SolveQueens(int column, int row)                   
        {

            numBoard[row, column] = 1;
            
            //if we're at the end and there's a solution
            if (column == boardSize - 1 && !isClash(column, row))
            {
                Array.Resize(ref solutions, solutions.Length + boardSize * 2);

                counter = 0;

                //saving solution
                for (int x = 0; x < boardSize; x++)
                {
                    for (int y = 0; y < boardSize; y++)
                    {
                        if (numBoard[y, x] == 1)
                        {
                            solutions[solutions.Length - boardSize * 2 + counter] = x;
                            solutions[solutions.Length - boardSize * 2 + counter + 1] = y;
                            counter += 2;
                        }
                    }
                }
            }

            //if there's no clash start going over the next column
            if (!isClash(column, row) && column < boardSize - 1)
            {                       
                SolveQueens(column + 1, 0);
                numBoard[row, column + 1] = 0;
            }

            //going one row down 
            if (row < boardSize - 1)
            {
                numBoard[row, column] = 0;
                SolveQueens(column, row + 1);
                numBoard[row + 1, column] = 0;
            }
        }

        public Form1()
        {
            InitializeComponent();

            CreateBoard();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // designing
            panel1.Size = new Size(boardSize * buttonSize, boardSize * buttonSize);
            panel1.Location = new Point(spacing * 2 + 100, spacing);
            Solve.Size = new Size(100, buttonSize);
            Solve.Location = new Point(spacing, spacing);
            sizeController.Size = new Size(100, 10);
            sizeController.Location = new Point(spacing, spacing * 2 + buttonSize);
            this.Size = new Size(boardSize * buttonSize + 100 + spacing * 4 + 5, boardSize * buttonSize + spacing * 2 + 38);
            Next.Location = new Point(spacing, this.Size.Height - 97);
            Next.Size = new Size(100, 50);
            Try.Size = new Size(100, 50);
            Try.Location = new Point(spacing, this.Size.Height - 157);


        }

        private void Solve_Click(object sender, EventArgs e)
        {
            DeleteBoard();
            CreateBoard();

            userPower = false;
            Try.Text = "Try Yourself";

            numBoard = new int[boardSize, boardSize];

            //put all solutions in an array
            SolveQueens();

            //display solutions
            displayCounter = 0;

            for (int i = 0; i < boardSize * 1; i++)
            {
                board[solutions[displayCounter], solutions[displayCounter + 1]].BackColor = Color.Black;

                displayCounter += 2;
            }

            Next.Enabled = true;
            Next.BackColor = Color.White;
        }

        private void sizeController_ValueChanged(object sender, EventArgs e)
        {
            DeleteBoard();

            boardSize = int.Parse(sizeController.Value.ToString());

            // designing
            panel1.Size = new Size(boardSize * buttonSize, boardSize * buttonSize);
            this.Size = new Size(boardSize * buttonSize + 100 + spacing * 4 + 5, boardSize * buttonSize + spacing * 2 + 38);

            CreateBoard();

            Next.Enabled = false;
            Next.BackColor = Color.Red;
        }
    }
}
