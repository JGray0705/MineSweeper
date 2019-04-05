using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MineSweeperGUI
{
    public partial class Form1 : Form
    {
        static public Board board;
        private Stopwatch stopwatch;
        private Timer timer = new Timer();
        private int totalFlags;
        static public int difficulty;
        private int score;

        public Form1()
        {
            InitializeComponent();
            // add the tick event for the timer
            timer.Tick += timer_tick;
        }

        private void timer_tick(object sender, EventArgs e)
        {
            // each time the timer tick, update the label to show the elapsed time
            label_timer.Text = string.Format("{0:mm\\:ss}", stopwatch.Elapsed);
            score--;
        }

        private void Button_start_Click(object sender, EventArgs e)
        {
            if(button_start.Text == "Restart")
            {
                if (MessageBox.Show("Are you sure you want to restart the game?", "Restart game", MessageBoxButtons.YesNo) == DialogResult.No) return;
            }
            // create a timer and stopwatch
            score = difficulty * 5000 + 5000;
            timer.Start();
            stopwatch = Stopwatch.StartNew();

            // set start button to say "restart". This will show a confirmation box when clicked
            button_start.Text = "Restart";
            
            // clear the board 
            panel1.Controls.Clear();

            // create new board with set difficulty. If no difficulty is chosen, it will default to easy
            board = new Board(difficulty);
            // fill the grid with cell class based on difficulty
            PopulateGrid();
            totalFlags = board.TotalLiveCells();
            label_remaining.Text = totalFlags.ToString();
        }

        private void PopulateGrid()
        {
            //make the grid square
            panel1.Height = panel1.Width;
            
            //get size of buttons based on button count.
            int buttonSize = panel1.Width / board.size;

            // loop through each button in the board
            foreach(Cell b in board.grid)
            {
                //set button dimensions
                b.Width = b.Height = buttonSize;

                //add button control to the panel
                panel1.Controls.Add(b);

                // set button location
                b.Location = new Point(b.row * buttonSize, b.col * buttonSize);
                
                // add click event
                b.MouseDown += Cell_click;
            }
        }

        private void Cell_click(object sender, EventArgs e)
        {
            // cast EventArgs to MouseEventArgs to be able to check which mouse button was clicked
            // left click will reveal the cell, right click will flag the cell
            MouseEventArgs me = e as MouseEventArgs;
            Cell b = sender as Cell;
     
            // left mouse click: reveal the cell that was clicked if the cell has not been flagged
            if (me.Button == MouseButtons.Left)
            {
                // do not check cells that have been flagged when the left mouse button is clicked
                if (!b.isFlagged)
                {
                    // if the cell is live, reveal all cells and inform the user that a bomb was found
                    if (b.isLive)
                    {
                        // stop the stopwatch and timer display
                        stopwatch.Stop();
                        timer.Stop();

                        // reveal all cells
                        RevealCells();

                        // Game Over message with stopwatch elapsed time
                        MessageBox.Show(String.Format("You found a bomb!\nTime elapsed: {0:mm\\:ss}", stopwatch.Elapsed));
                        button_start.Text = "Start Game";
                    }
                    // if the cell is not live, reveal the cell
                    else RevealSingle(b);
                }
            }
            // right mouse click: toggle flag on cells that have not been revealed
            else if (me.Button == MouseButtons.Right)
            {
                // if the cell has already been flagged, flagged = false, visited = false, remove background image of flag
                if (b.isFlagged)
                {
                    b.isFlagged = false;
                    b.isVisited = false;

                    // remove background image
                    b.BackgroundImage = null;

                    // add flag back to total flags available
                    totalFlags++;
                }
                // if the user has used all flags, they must remove a flag before placing another
                else if (totalFlags > 0 && !b.isVisited)
                {
                    b.isFlagged = true;
                    b.isVisited = true;
                    b.BackgroundImage = Properties.Resources.Flag2;
                    b.BackgroundImageLayout = ImageLayout.Stretch;
                    totalFlags--;
                }
                label_remaining.Text = totalFlags.ToString();
            }
            CheckForWin();
        }
        
        private void RevealSingle(Cell cell)
        {
            // set background image for cells with bombs
            if (cell.isLive)
            {
                cell.BackgroundImage = Properties.Resources.bomb;
                cell.BackgroundImageLayout = ImageLayout.Stretch;
            }

            // if the cell has no live neighbors, reveal all surrounding cells
            else if (cell.LiveNeighbors == 0)
            {
                // no live neighbors will have gray background
                cell.BackColor = Color.DarkGray;

                // options x and y are coordinates for all adjacent cells
                int[] optionsx = { 0, 0, 1, 1, 1, -1, -1, -1 };
                int[] optionsy = { 1, -1, 1, 0, -1, 1, 0, -1 };

                // loop through every cell to check for live neighbors
                for (int i = 0; i < optionsx.Length; i++)
                {
                    // adjacent cell is current cell plus index of options x and y
                    int x = cell.row + optionsx[i];
                    int y = cell.col + optionsy[i];
                    // check for out of bounds index
                    if (x >= 0 && x < board.size && y >= 0 && y < board.size)
                    {
                        // if the cell has not been revealed, reveal it
                        if (!board.grid[x, y].isVisited)
                        {
                            board.grid[x, y].isVisited = true;
                            RevealSingle(board.grid[x, y]);
                        }
                    }
                }
            }
            // all other cells will show their live neighbor count
            else
            {
                cell.BackgroundImage = null;
                cell.Text = cell.LiveNeighbors.ToString();
                cell.BackColor = Color.Gray;
                // text color is based on the number of live neighbors
                Color[] colors = { Color.LawnGreen, Color.Yellow, Color.Red, Color.Orange, Color.SkyBlue, Color.Indigo, Color.Violet, Color.White };
                cell.ForeColor = colors[cell.LiveNeighbors - 1];
            }
            // cell has now been visited and cannot be clicked anymore
            cell.Click -= Cell_click;
            cell.isVisited = true;
        }

        private void RevealCells()
        {
            foreach(Cell c in board.grid)
            {
                RevealSingle(c);
                c.Click -= Cell_click;
            }
        }

        private void CheckForWin()
        {
            // if there are no remaining flags and all cells are visited, the player wins
            if (totalFlags == 0 && board.TotalVisitedCells() == board.size * board.size)
            {
                // stop the timer and stopwatch
                timer.Stop();
                stopwatch.Stop();

                // remove click event from all cells
                foreach (Cell c in board.grid)
                {
                    c.Click -= Cell_click;
                }
                button_start.Text = "Start Game";
                PlayerStats ps = new PlayerStats("name", difficulty, score);

                // form takes a bool argument
                // true means we are adding a new score
                // false means we are just viewing high scores
                // form also takes a playerstats object used for recording new scores
                new HighScoreForm(true, ps).Show();

                // show victory message with total time to used to win the game
                MessageBox.Show(string.Format("You won the game!\nTime elapsed: {0:mm\\:ss}", stopwatch.Elapsed));


            }
        }
        
        private void Button_difficulty_Click(object sender, EventArgs e)
        {
            // show a new form that contains controls for selecting a difficulty
            new DifficultyForm().Show();
        }

        private void button_highScores_Click(object sender, EventArgs e)
        {
            // form takes a bool argument
            // true means we are adding a new score
            // false means we are just viewing high scores
            // form also takes a playerstats object used for recording new scores
            new HighScoreForm(false, null).Show();
        }
    }
}
    