namespace DESO
{
    partial class DungeonForm
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
            this.AchievementOneBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.AchievementOneLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // AchievementOneBar
            // 
            this.AchievementOneBar.Depth = 0;
            this.AchievementOneBar.Location = new System.Drawing.Point(12, 108);
            this.AchievementOneBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.AchievementOneBar.Name = "AchievementOneBar";
            this.AchievementOneBar.Size = new System.Drawing.Size(196, 5);
            this.AchievementOneBar.TabIndex = 0;
            // 
            // AchievementOneLabel
            // 
            this.AchievementOneLabel.AutoSize = true;
            this.AchievementOneLabel.Depth = 0;
            this.AchievementOneLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AchievementOneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AchievementOneLabel.Location = new System.Drawing.Point(8, 86);
            this.AchievementOneLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AchievementOneLabel.Name = "AchievementOneLabel";
            this.AchievementOneLabel.Size = new System.Drawing.Size(122, 19);
            this.AchievementOneLabel.TabIndex = 1;
            this.AchievementOneLabel.Text = "AchievementOne";
            // 
            // DungeonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AchievementOneLabel);
            this.Controls.Add(this.AchievementOneBar);
            this.Name = "DungeonForm";
            this.Text = "DungeonForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DungeonForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialProgressBar AchievementOneBar;
        private MaterialSkin.Controls.MaterialLabel AchievementOneLabel;
    }
}