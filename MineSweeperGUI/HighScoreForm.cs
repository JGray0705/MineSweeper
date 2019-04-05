using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MineSweeperGUI
{
    public partial class HighScoreForm : Form
    {
        PlayerStats ps;

        public HighScoreForm(bool recordingScore, PlayerStats ps)
        {
            InitializeComponent();

            this.ps = ps;
            int difficulty = Form1.difficulty;
            if (recordingScore) { recordScore(); }
            else { showScores(difficulty); }
        }

        private void showScores(int difficulty)
        {
            string[] diffs = { "easy", "medium", "hard" };
            label2.Text += " - " + diffs[difficulty];
            List<PlayerStats> ps = GetHighscores(difficulty);
            if (ps == null) { label1.Text = "No scores to display yet!"; }
            else
            {
                for (int i = 0; i < ps.Count(); i++)
                {
                    label1.Text += $"{(i + 1).ToString()}. {ps[i].ToString()} \n";
                }
            }
            label1.Visible = true;
            label2.Visible = true;
        }

        private void recordScore()
        {
            textBox_name.Visible = true;
            button_saveScore.Visible = true;
            label3.Visible = true;
            label3.Text = $"Your score: {ps.score.ToString()}\n{label3.Text}";
        }

        private List<PlayerStats> GetHighscores(int difficulty)
        {
            if (new FileInfo("highscores.csv").Length == 0) return null;
            List<string> scores = File.ReadAllLines("highscores.csv").ToList();
            List<PlayerStats> highscores = new List<PlayerStats>();
            foreach (string score in scores)
            {
                string[] stats = score.Split(',');

                highscores.Add(new PlayerStats(stats[0], int.Parse(stats[1]), int.Parse(stats[2])));
            }
            highscores.Sort();

            // take the 5 best scores for the current difficulty
            return highscores.Where(stat => stat.difficulty == difficulty).Take(5).ToList();
        }

        private void button_saveScore_Click(object sender, EventArgs e)
        {
            // high scores are written to a comma-separated file
            // so, any user input cannot contain a comma
            string name = textBox_name.Text.Replace(',' , ' ');
            if(name == "")
            {
                MessageBox.Show("Name cannot be blank");
                return;
            }
            ps.name = name;
            ps.RecordScore();
            Close();
            MessageBox.Show("New score saved");
        }
    }
}
