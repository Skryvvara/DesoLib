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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DungeonForm));
            this.AchievementOneBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.AchievementOneLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AchievementOneInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SaveButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.AchievementTwoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AchievementTwoBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.AchievementTwoInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CheckBoxHardmode = new MaterialSkin.Controls.MaterialCheckBox();
            this.CheckBoxSpeedrun = new MaterialSkin.Controls.MaterialCheckBox();
            this.CheckBoxNoDeath = new MaterialSkin.Controls.MaterialCheckBox();
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
            this.SaveButton.Location = new System.Drawing.Point(16, 316);
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
            // AchievementTwoLabel
            // 
            this.AchievementTwoLabel.AutoSize = true;
            this.AchievementTwoLabel.Depth = 0;
            this.AchievementTwoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AchievementTwoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AchievementTwoLabel.Location = new System.Drawing.Point(12, 161);
            this.AchievementTwoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AchievementTwoLabel.Name = "AchievementTwoLabel";
            this.AchievementTwoLabel.Size = new System.Drawing.Size(122, 19);
            this.AchievementTwoLabel.TabIndex = 4;
            this.AchievementTwoLabel.Text = "AchievementOne";
            // 
            // AchievementTwoBar
            // 
            this.AchievementTwoBar.Depth = 0;
            this.AchievementTwoBar.ForeColor = System.Drawing.Color.Fuchsia;
            this.AchievementTwoBar.Location = new System.Drawing.Point(12, 183);
            this.AchievementTwoBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.AchievementTwoBar.Name = "AchievementTwoBar";
            this.AchievementTwoBar.Size = new System.Drawing.Size(196, 5);
            this.AchievementTwoBar.TabIndex = 5;
            // 
            // AchievementTwoInput
            // 
            this.AchievementTwoInput.Depth = 0;
            this.AchievementTwoInput.Hint = "";
            this.AchievementTwoInput.Location = new System.Drawing.Point(12, 194);
            this.AchievementTwoInput.MaxLength = 32767;
            this.AchievementTwoInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.AchievementTwoInput.Name = "AchievementTwoInput";
            this.AchievementTwoInput.PasswordChar = '\0';
            this.AchievementTwoInput.SelectedText = "";
            this.AchievementTwoInput.SelectionLength = 0;
            this.AchievementTwoInput.SelectionStart = 0;
            this.AchievementTwoInput.Size = new System.Drawing.Size(196, 23);
            this.AchievementTwoInput.TabIndex = 6;
            this.AchievementTwoInput.TabStop = false;
            this.AchievementTwoInput.Text = "0";
            this.AchievementTwoInput.UseSystemPasswordChar = false;
            this.AchievementTwoInput.TextChanged += new System.EventHandler(this.AchievementTwoInput_TextChanged);
            // 
            // CheckBoxHardmode
            // 
            this.CheckBoxHardmode.AutoSize = true;
            this.CheckBoxHardmode.Depth = 0;
            this.CheckBoxHardmode.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckBoxHardmode.Location = new System.Drawing.Point(12, 220);
            this.CheckBoxHardmode.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxHardmode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxHardmode.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxHardmode.Name = "CheckBoxHardmode";
            this.CheckBoxHardmode.Ripple = true;
            this.CheckBoxHardmode.Size = new System.Drawing.Size(95, 30);
            this.CheckBoxHardmode.TabIndex = 8;
            this.CheckBoxHardmode.Text = "Hardmode";
            this.CheckBoxHardmode.UseVisualStyleBackColor = true;
            this.CheckBoxHardmode.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // CheckBoxSpeedrun
            // 
            this.CheckBoxSpeedrun.AutoSize = true;
            this.CheckBoxSpeedrun.Depth = 0;
            this.CheckBoxSpeedrun.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckBoxSpeedrun.Location = new System.Drawing.Point(12, 250);
            this.CheckBoxSpeedrun.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxSpeedrun.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxSpeedrun.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxSpeedrun.Name = "CheckBoxSpeedrun";
            this.CheckBoxSpeedrun.Ripple = true;
            this.CheckBoxSpeedrun.Size = new System.Drawing.Size(89, 30);
            this.CheckBoxSpeedrun.TabIndex = 9;
            this.CheckBoxSpeedrun.Text = "Speedrun";
            this.CheckBoxSpeedrun.UseVisualStyleBackColor = true;
            this.CheckBoxSpeedrun.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // CheckBoxNoDeath
            // 
            this.CheckBoxNoDeath.AutoSize = true;
            this.CheckBoxNoDeath.Depth = 0;
            this.CheckBoxNoDeath.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckBoxNoDeath.Location = new System.Drawing.Point(12, 280);
            this.CheckBoxNoDeath.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxNoDeath.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxNoDeath.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxNoDeath.Name = "CheckBoxNoDeath";
            this.CheckBoxNoDeath.Ripple = true;
            this.CheckBoxNoDeath.Size = new System.Drawing.Size(87, 30);
            this.CheckBoxNoDeath.TabIndex = 10;
            this.CheckBoxNoDeath.Text = "No Death";
            this.CheckBoxNoDeath.UseVisualStyleBackColor = true;
            this.CheckBoxNoDeath.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // DungeonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 360);
            this.Controls.Add(this.CheckBoxNoDeath);
            this.Controls.Add(this.CheckBoxSpeedrun);
            this.Controls.Add(this.CheckBoxHardmode);
            this.Controls.Add(this.AchievementTwoInput);
            this.Controls.Add(this.AchievementTwoBar);
            this.Controls.Add(this.AchievementTwoLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AchievementOneInput);
            this.Controls.Add(this.AchievementOneLabel);
            this.Controls.Add(this.AchievementOneBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private MaterialSkin.Controls.MaterialLabel AchievementTwoLabel;
        private MaterialSkin.Controls.MaterialProgressBar AchievementTwoBar;
        private MaterialSkin.Controls.MaterialSingleLineTextField AchievementTwoInput;
        private MaterialSkin.Controls.MaterialCheckBox CheckBoxHardmode;
        private MaterialSkin.Controls.MaterialCheckBox CheckBoxSpeedrun;
        private MaterialSkin.Controls.MaterialCheckBox CheckBoxNoDeath;
    }
}