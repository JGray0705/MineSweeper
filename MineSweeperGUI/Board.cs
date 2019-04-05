using System;

namespace MineSweeperGUI
{
    public class Board
    {
        public Cell[,] grid;
        public int size;

        public Board(int difficulty) // fill the grid with cells and set the difficulty level
        {
            switch (difficulty)
            {
                // difficulty determines size. 0 = 8, 1 = 12, 2 = 16
                // if any other number is entered, default is size 8
                case 0:
                    size = 8;
                    break;
                case 1:
                    size = 12;
                    break;
                case 2:
                    size = 16;
                    break;
                default:
                    size = 8;
                    break;
            }
            // create new grid based on size determined from difficulty
            grid = new Cell[size, size];

            // populate the grid with new cells
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    grid[r, c] = new Cell(r, c);
                }
            }
            ActivateCells();
            SetLiveNeighbors();
        }

        private void ActivateCells() // activate random cells
        {
            // random number to determine if a cell should be activated
            Random rand = new Random();
            for(int r = 0; r < size; r++)
            {
                for(int c = 0; c < size; c++)
                {
                    // 1 in 6 cells should activate. If the random number(0, 6) equals 1, the cell will activate
                    if(rand.Next(0, 6) == 1)
                    {
                        grid[r, c].isLive = true;
                    }
                }
            }
        }

        private void SetLiveNeighbors() // count how many live neighbors a cell has. An active cell will have 9 live neighbors
        {
            // arrays of coordinates for each adjacent cell
            int[] optionsx = { 0, 0, 1, 1, 1, -1, -1, -1 };
            int[] optionsy = { 1, -1, 1, 0, -1, 1, 0, -1 };

            // check every cell in the grid foor live neighbors
            foreach (Cell c in grid)
            {
                //any live cell has liveNeighbors set to 9
                if (c.isLive)
                {
                    c.LiveNeighbors = 9;
                }
                else
                {
                    // loop throught the arrays of coordinates
                    for (int i = 0; i < 8; i++)
                    {
                        // adjacent cells are the current cell added to the  current index of the coordinate arrays
                        int x = c.row + optionsx[i];
                        int y = c.col + optionsy[i];

                        // check to avoid out of bounds exception in the grid
                        if (x >= 0 && x < size && y >= 0 && y < size)
                        {
                            // if the cell being checked is live, add 1 to the liveNeighbors property of the original cell
                            if (grid[x, y].isLive)
                            {
                                c.LiveNeighbors = 1;
                            }
                        }
                    }
                }
            }
        }

        public int TotalLiveCells()
        {
            int total = 0;
            foreach(Cell c in grid)
            {
                if (c.isLive) total++;
            }
            return total;
        }

        public int TotalVisitedCells()
        {
            int total = 0;
            foreach(Cell c in grid)
            {
                if (c.isVisited) total++;
            }
            return total;
        }
    }
}
