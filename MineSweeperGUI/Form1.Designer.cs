namespace MineSweeperGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_start = new System.Windows.Forms.Button();
            this.label_timer = new System.Windows.Forms.Label();
            this.label_remaining = new System.Windows.Forms.Label();
            this.button_difficulty = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_highScores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 561);
            this.panel1.TabIndex = 0;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(562, 20);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(144, 40);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Start Game";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_timer.Location = new System.Drawing.Point(458, 20);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(98, 38);
            this.label_timer.TabIndex = 4;
            this.label_timer.Text = "00:00";
            // 
            // label_remaining
            // 
            this.label_remaining.AutoSize = true;
            this.label_remaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_remaining.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_remaining.Location = new System.Drawing.Point(226, 20);
            this.label_remaining.Name = "label_remaining";
            this.label_remaining.Size = new System.Drawing.Size(35, 38);
            this.label_remaining.TabIndex = 6;
            this.label_remaining.Text = "0";
            // 
            // button_difficulty
            // 
            this.button_difficulty.Location = new System.Drawing.Point(12, 18);
            this.button_difficulty.Name = "button_difficulty";
            this.button_difficulty.Size = new System.Drawing.Size(144, 40);
            this.button_difficulty.TabIndex = 8;
            this.button_difficulty.Text = "Select Difficulty";
            this.button_difficulty.UseVisualStyleBackColor = true;
            this.button_difficulty.Click += new System.EventHandler(this.Button_difficulty_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MineSweeperGUI.Properties.Resources.stopwatch;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(409, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 41);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MineSweeperGUI.Properties.Resources.bomb;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(177, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 41);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button_highScores
            // 
            this.button_highScores.Location = new System.Drawing.Point(281, 20);
            this.button_highScores.Name = "button_highScores";
            this.button_highScores.Size = new System.Drawing.Size(122, 38);
            this.button_highScores.TabIndex = 9;
            this.button_highScores.Text = "High Scores";
            this.button_highScores.UseVisualStyleBackColor = true;
            this.button_highScores.Click += new System.EventHandler(this.button_highScores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(717, 745);
            this.Controls.Add(this.button_highScores);
            this.Controls.Add(this.button_difficulty);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_remaining);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_remaining;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_difficulty;
        private System.Windows.Forms.Button button_highScores;
    }
}

