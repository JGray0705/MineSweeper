using System.Drawing;
using System.Windows.Forms;

namespace MineSweeperGUI
{
    public class Cell : Button
    {
        public int row;
        public int col;
        public bool isVisited;
        public bool isLive;
        private int liveNeighbors = 0;
        public bool isFlagged;

        public Cell(int row, int col)
        {
            this.row = row;
            this.col = col;
            BackColor = Color.FromArgb(73, 126, 134);

            // button design
            FlatStyle = FlatStyle.Popup;
            Font = new Font("helvetica", 15);
        }

        public int LiveNeighbors
        {
            get { return liveNeighbors; }
            set { liveNeighbors += value; }
        }
    }
}
