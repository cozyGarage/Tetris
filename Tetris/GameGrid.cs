using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class GameGrid
    {
        
        private readonly int[,] grid;                                               // 2D array to store the state of the game grid
        public int Rows { get; }                                                    // property to get the number of rows in the game grid
        public int Columns { get; }                                                 // property to get the number of rows in the game grid
        public int this[int r,int c]                                                // indexer to access the state of a particular cell in the game grid
        {
            get => grid[r, c];                                                      // get the value of the cell at the given row and column
            set => grid[r, c] = value;                                              // set the value of the cell at the given row and column
        }
        
        public GameGrid(int rows, int columns)                                      // constructor to initialize the game grid with the given number of rows and columns
        {
            Rows = rows;                                                            // set the number of rows
            Columns = columns;                                                      // set the number of columns              
            grid = new int[Rows, Columns];                                          // initialize the game grid with the given number of rows and columns
        }
        // method to check if a given row and column is inside the bounds of the game grid
        public bool IsInside(int r, int c)
        {
            return r>=0 && c>=0 && r<Rows && c < Columns;
        }
        // method to check if a given cell in the game grid is empty (i.e., has a value of 0)
        public bool IsEmpty(int r, int c)
        {
            /*  return IsInside(r, c) && grid[r, c] == 0; */
            const int emptyBlock = 0;
            return IsInside(r, c) && grid[r, c] == emptyBlock; ;
        }
        // method to check if a given row in the game grid is full (i.e., all cells in the row have non-zero values)
        public bool IsRowFull(int r)
        {
            /*for(int c = 0; c < this.Columns; c++)
            {
                if (grid[r, c] == 0)
                {
                    return false;
                }
            }
            return true;*/
            const int emptyBlock = 0;
            return !Enumerable.Range(0, Columns).Any(c => grid[r, c] == emptyBlock);

        }
        // method to check if a given row in the game grid is empty (i.e., all cells in the row have a value of 0)
        public bool IsRowEmpty(int r)
        {
            /*for (int c = 0; c < this.Columns; c++)
            {
                if (grid[r, c] != 0)
                {
                    return false;
                }
            }
            return true;*/
            const int emptyBlock = 0;
            return !Enumerable.Range(0, Columns).Any(c => grid[r, c] != emptyBlock);
        }
        // method to clear a given row in the game grid (i.e., set all cells in the row to 0)
        private void ClearRow(int r)
        {
            const int emptyBlock = 0;
            for (int c = 0; c < Columns; c++)
            {
                grid[r, c] = emptyBlock;
            }
        }
    
        // method to move a given row in the game grid down by the specified number of rows
        private void MoveRowDown(int r, int numRows)
        {
            for( int c = 0; c < this.Columns; c++)
            {
                grid[r +numRows, c] = grid[r, c];// move the cell in the row down by the specified number of rows
                grid[r, c] = 0; // set the original cell to 0
            }
        }
        // shifts a row down by a given number of rows.
        // It does this by copying each element of the row to the corresponding element in the new row below it, and then setting the original element to 0.
        // This is used in the ClearFullRows function to move all rows above a cleared row down by the number of rows that were cleared.
        public int ClearFullRows()
        {
            int clearedRows = 0; // variable to keep track of the number of rows that are cleared
            for (int r = Rows -1; r >=0; r--)
            {
                if (IsRowFull(r))
                {
                    ClearRow(r); // clear the full row
                    clearedRows++;
                }
                else if (clearedRows > 0)
                {
                    MoveRowDown(r,clearedRows); // method to move a given row in the game grid down by the specified number of rows
                }
            }
            return clearedRows;
        }

    }
}
