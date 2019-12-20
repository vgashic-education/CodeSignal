using System;
using System.Collections.Generic;

namespace Sudoku {
    /*
       Sudoku is a number-placement puzzle. The objective is to fill a 9 × 9 grid with numbers in such a way that each column, each row, and each of the nine 3 × 3 sub-grids that compose the grid all contain all of the numbers from 1 to 9 one time.

       Implement an algorithm that will check whether the given grid of numbers represents a valid Sudoku puzzle according to the layout rules described above. Note that the puzzle represented by grid does not have to be solvable.

       Example

       For

       grid = [['.', '.', '.', '1', '4', '.', '.', '2', '.'],
               ['.', '.', '6', '.', '.', '.', '.', '.', '.'],
               ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
               ['.', '.', '1', '.', '.', '.', '.', '.', '.'],
               ['.', '6', '7', '.', '.', '.', '.', '.', '9'],
               ['.', '.', '.', '.', '.', '.', '8', '1', '.'],
               ['.', '3', '.', '.', '.', '.', '.', '.', '6'],
               ['.', '.', '.', '.', '.', '7', '.', '.', '.'],
               ['.', '.', '.', '5', '.', '.', '.', '7', '.']]
       the output should be
       sudoku2(grid) = true;

       For

       grid = [['.', '.', '.', '.', '2', '.', '.', '9', '.'],
               ['.', '.', '.', '.', '6', '.', '.', '.', '.'],
               ['7', '1', '.', '.', '7', '5', '.', '.', '.'],
               ['.', '7', '.', '.', '.', '.', '.', '.', '.'],
               ['.', '.', '.', '.', '8', '3', '.', '.', '.'],
               ['.', '.', '8', '.', '.', '7', '.', '6', '.'],
               ['.', '.', '.', '.', '.', '2', '.', '.', '.'],
               ['.', '1', '.', '2', '.', '.', '.', '.', '.'],
               ['.', '2', '.', '.', '3', '.', '.', '.', '.']]
       the output should be
       sudoku2(grid) = false.

       The given grid is not correct because there are two 1s in the second column. Each column, each row, and each 3 × 3 subgrid can only contain the numbers 1 through 9 one time.

       Input/Output

       [execution time limit] 3 seconds (cs)

       [input] array.array.char grid

       A 9 × 9 array of characters, in which each character is either a digit from '1' to '9' or a period '.'.

       [output] boolean

       Return true if grid represents a valid Sudoku puzzle, otherwise return false
   */

    class Sudoku {
        static void Main(string[] args) {

            char[][] grid = new char[9][];

            grid[0] = new[] { '.', '.', '.', '1', '4', '.', '.', '2', '.' };
            grid[1] = new[] { '.', '.', '6', '.', '.', '.', '.', '.', '.' };
            grid[2] = new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' };
            grid[3] = new[] { '.', '.', '1', '.', '.', '.', '.', '.', '.' };
            grid[4] = new[] { '.', '6', '7', '.', '.', '.', '.', '.', '9' };
            grid[5] = new[] { '.', '.', '.', '.', '.', '.', '8', '1', '.' };
            grid[6] = new[] { '.', '3', '.', '.', '.', '.', '.', '.', '6' };
            grid[7] = new[] { '.', '.', '.', '.', '.', '7', '.', '.', '.' };
            grid[8] = new[] { '.', '.', '.', '5', '.', '.', '.', '7', '.' };

            bool isValid = sudoku2(grid);

            Console.WriteLine(isValid);

        }



        static bool sudoku2(char[][] grid) {

            // arrays that needs to be checked
            // one for each row, column and sub-grid
            // 0-8......sub-grids
            // 9-17.....rows
            // 18-26....columns
            char[][] arraysToCheck = new char[27][];

            char[][] subGrids = new char[9][];
            int[] subGridIndexes = new int[9];

            // fill arraysToCheck
            for (int i = 0; i < 9; i++) {

                char[] rows = new char[9];
                char[] columns = new char[9];

                for (int j = 0; j < 9; j++) {

                    // add sub-grids
                    // first calculate to which subgrid element belongs
                    int subGrid = 3 * (i / 3) + (j / 3);

                    // then add it to it's grid...
                    subGrids[subGrid] = subGrids[subGrid] ?? new char[9];
                    subGrids[subGrid][subGridIndexes[subGrid]] = grid[i][j];

                    // and increase grid counter
                    subGridIndexes[subGrid]++;

                    // add row
                    rows[j] = grid[i][j];

                    // add column
                    columns[j] = grid[j][i];

                }

                arraysToCheck[i] = subGrids[i];
                arraysToCheck[i + 9] = rows;
                arraysToCheck[i + 18] = columns;

            }

            foreach (char[] item in arraysToCheck) {

                // check duplicates
                if (HasDuplicates(item)) {
                    return false;
                }

            }

            return true;

        }


        /// <summary>
        /// Check if char array contains duplicates
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static bool HasDuplicates(char[] arr) {

            Dictionary<char, int> elementsCount = new Dictionary<char, int>();

            foreach (var item in arr) {

                // skip dots
                if (item != '.') {
                    if (!elementsCount.ContainsKey(item)) {
                        elementsCount.Add(item, 1);
                    } else {
                        return true;
                    }
                }

            }

            return false;

        }



    }
}
