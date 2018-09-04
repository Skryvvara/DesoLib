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
            this.AchievementOneInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SaveButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // AchievementOneBar
            // 
            this.AchievementOneBar.Depth = 0;
            this.AchievementOneBar.ForeColor = System.Drawing.Color.Fuchsia;
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
            // AchievementOneInput
            // 
            this.AchievementOneInput.Depth = 0;
            this.AchievementOneInput.Hint = "";
            this.AchievementOneInput.Location = new System.Drawing.Point(12, 119);
            this.AchievementOneInput.MaxLength = 32767;
            this.AchievementOneInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.AchievementOneInput.Name = "AchievementOneInput";
            this.AchievementOneInput.PasswordChar = '\0';
            this.AchievementOneInput.SelectedText = "";
            this.AchievementOneInput.SelectionLength = 0;
            this.AchievementOneInput.SelectionStart = 0;
            this.AchievementOneInput.Size = new System.Drawing.Size(196, 23);
            this.AchievementOneInput.TabIndex = 2;
            this.AchievementOneInput.TabStop = false;
            this.AchievementOneInput.Text = "0";
            this.AchievementOneInput.UseSystemPasswordChar = false;
            this.AchievementOneInput.TextChanged += new System.EventHandler(this.AchievementOneInput_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = true;
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.Depth = 0;
            this.SaveButton.Icon = null;
            this.SaveButton.Location = new System.Drawing.Point(13, 399);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Primary = false;
            this.SaveButton.Size = new System.Drawing.Size(94, 36);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Speichern";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DungeonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AchievementOneInput);
            this.Controls.Add(this.AchievementOneLabel);
            this.Controls.Add(this.AchievementOneBar);
            this.Name = "DungeonForm";
            this.Text = "DungeonForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DungeonForm_FormClosed);
            this.Shown += new System.EventHandler(this.DungeonForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialProgressBar AchievementOneBar;
        private MaterialSkin.Controls.MaterialLabel AchievementOneLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField AchievementOneInput;
        private MaterialSkin.Controls.MaterialFlatButton SaveButton;
    }
}