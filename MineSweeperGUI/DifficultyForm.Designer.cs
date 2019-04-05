namespace MineSweeperGUI
{
    partial class DifficultyForm
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
            this.groupBox_difficulty = new System.Windows.Forms.GroupBox();
            this.radioButton_hard = new System.Windows.Forms.RadioButton();
            this.radioButton_medium = new System.Windows.Forms.RadioButton();
            this.radioButton_easy = new System.Windows.Forms.RadioButton();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.groupBox_difficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_difficulty
            // 
            this.groupBox_difficulty.Controls.Add(this.radioButton_hard);
            this.groupBox_difficulty.Controls.Add(this.radioButton_medium);
            this.groupBox_difficulty.Controls.Add(this.radioButton_easy);
            this.groupBox_difficulty.Location = new System.Drawing.Point(12, 12);
            this.groupBox_difficulty.Name = "groupBox_difficulty";
            this.groupBox_difficulty.Size = new System.Drawing.Size(168, 146);
            this.groupBox_difficulty.TabIndex = 0;
            this.groupBox_difficulty.TabStop = false;
            // 
            // radioButton_hard
            // 
            this.radioButton_hard.AutoSize = true;
            this.radioButton_hard.Location = new System.Drawing.Point(6, 75);
            this.radioButton_hard.Name = "radioButton_hard";
            this.radioButton_hard.Size = new System.Drawing.Size(112, 21);
            this.radioButton_hard.TabIndex = 2;
            this.radioButton_hard.TabStop = true;
            this.radioButton_hard.Tag = "2";
            this.radioButton_hard.Text = "Hard (16x16)";
            this.radioButton_hard.UseVisualStyleBackColor = true;
            // 
            // radioButton_medium
            // 
            this.radioButton_medium.AutoSize = true;
            this.radioButton_medium.Location = new System.Drawing.Point(6, 48);
            this.radioButton_medium.Name = "radioButton_medium";
            this.radioButton_medium.Size = new System.Drawing.Size(130, 21);
            this.radioButton_medium.TabIndex = 1;
            this.radioButton_medium.TabStop = true;
            this.radioButton_medium.Tag = "1";
            this.radioButton_medium.Text = "Medium (12x12)";
            this.radioButton_medium.UseVisualStyleBackColor = true;
            // 
            // radioButton_easy
            // 
            this.radioButton_easy.AutoSize = true;
            this.radioButton_easy.Location = new System.Drawing.Point(6, 21);
            this.radioButton_easy.Name = "radioButton_easy";
            this.radioButton_easy.Size = new System.Drawing.Size(96, 21);
            this.radioButton_easy.TabIndex = 0;
            this.radioButton_easy.TabStop = true;
            this.radioButton_easy.Tag = "0";
            this.radioButton_easy.Text = "Easy (8x8)";
            this.radioButton_easy.UseVisualStyleBackColor = true;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(208, 20);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(202, 61);
            this.button_confirm.TabIndex = 1;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(208, 100);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(202, 58);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 170);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.groupBox_difficulty);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Difficulty";
            this.groupBox_difficulty.ResumeLayout(false);
            this.groupBox_difficulty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_difficulty;
        private System.Windows.Forms.RadioButton radioButton_hard;
        private System.Windows.Forms.RadioButton radioButton_medium;
        private System.Windows.Forms.RadioButton radioButton_easy;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_cancel;
    }
}