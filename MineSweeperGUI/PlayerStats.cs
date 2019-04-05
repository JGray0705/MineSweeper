using System;
using System.IO;

namespace MineSweeperGUI
{
    public class PlayerStats : IComparable
    {
        public string name { get; set; }
        public int difficulty { get; }
        public int score { get; }

        public PlayerStats(string name, int difficulty, int score)
        {
            this.name = name;
            this.difficulty = difficulty;
            this.score = score;
        }

        public int CompareTo(object obj)
        {
            // CompareTo is used when sorting a list of PlayerStats
            // Stats will be sorted by score

            if (obj == null) { return -1; }
            if (!(obj is PlayerStats stats)) { return -1; }
            return (score < stats.score) ? 1 : -1;
        }

        public void RecordScore()
        {
            File.AppendAllText("highscores.csv", $"{name},{difficulty},{score}\n");
        }
        
        public override string ToString()
        {
            return name + " ---- " + score;
        }
    }
}
