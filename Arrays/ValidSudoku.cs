using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
You are given a a 9 x 9 Sudoku board board. A Sudoku board is valid if the following rules are followed:

Each row must contain the digits 1-9 without duplicates.
Each column must contain the digits 1-9 without duplicates.
Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without duplicates.
Return true if the Sudoku board is valid, otherwise return false

Note: A board does not need to be full or be solvable to be valid.*/

namespace Arrays_Basic
{
    internal class ValidSudoku
    {
        static void Main(string[] args)
        {
            char[][] board = new char[][]
            {
                new char[] {'5','3','.','.','7','.','.','.','.'},
                new char[] {'6','.','.','1','9','5','.','.','.'},
                new char[] {'.','9','8','.','.','.','.','6','.'},
                new char[] {'8','.','.','.','6','.','.','.','3'},
                new char[] {'4','.','.','8','.','3','.','.','1'},
                new char[] {'7','.','.','.','2','.','.','.','6'},
                new char[] {'.','6','.','.','.','.','2','8','.'},
                new char[] {'.','.','.','4','1','9','.','.','5'},
                new char[] {'.','.','.','.','8','.','.','7','9'}
            };
            bool isValid = IsValidSudoku(board);
            Console.WriteLine(isValid ? "The board is valid." : "The board is invalid.");
        }

        public static bool IsValidSudoku(char[][] board)
        {
            HashSet<string> seen = new HashSet<string>();

            for(int i=0; i<9; i++)
            {
                for(int j=0; j<9; j++)
                {
                    char currentVal = board[i][j];
                    if (currentVal != '.')
                    {
                        if(seen.Add($"{currentVal} found in row {i}") || 
                            seen.Add($"{currentVal} found in column {j}") ||
                            seen.Add($"{currentVal} found in sub-box {i / 3}-{j / 3}"))
                        {
                            return false;
                        }
                    }

                }
            }
            return true;
        }
    }
}
