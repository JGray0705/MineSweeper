using System;
using System.Linq;
using System.Windows.Forms;

namespace MineSweeperGUI
{
    public partial class DifficultyForm : Form
    {
        public DifficultyForm()
        {
            InitializeComponent();

            // select the radio button that corresponds to the current difficulty
            switch (Form1.difficulty)
            {
                case 0:
                    radioButton_easy.Select();
                    break;
                case 1:
                    radioButton_medium.Select();
                    break;
                case 2:
                    radioButton_hard.Select();
                    break;
            }
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            // the tag of eaah radio button is a difficulty number that can be used when creating the board
            int difficulty = int.Parse(groupBox_difficulty.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Tag.ToString());
            Form1.difficulty = difficulty;
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            // close the form without changing anything
            Close();
        }
    }
}
