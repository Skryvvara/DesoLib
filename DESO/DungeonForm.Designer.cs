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
            this.AchievementOneInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AchievementTwoBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.AchievementTwoInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CheckBoxHardmode = new MaterialSkin.Controls.MaterialCheckBox();
            this.CheckBoxSpeedrun = new MaterialSkin.Controls.MaterialCheckBox();
            this.CheckBoxNoDeath = new MaterialSkin.Controls.MaterialCheckBox();
            this.AchievementOneCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.AchievementTwoCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
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
            // AchievementOneCheckBox
            // 
            this.AchievementOneCheckBox.AutoSize = true;
            this.AchievementOneCheckBox.Depth = 0;
            this.AchievementOneCheckBox.Enabled = false;
            this.AchievementOneCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.AchievementOneCheckBox.Location = new System.Drawing.Point(12, 75);
            this.AchievementOneCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.AchievementOneCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AchievementOneCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.AchievementOneCheckBox.Name = "AchievementOneCheckBox";
            this.AchievementOneCheckBox.Ripple = true;
            this.AchievementOneCheckBox.Size = new System.Drawing.Size(135, 30);
            this.AchievementOneCheckBox.TabIndex = 11;
            this.AchievementOneCheckBox.Text = "AchievementOne";
            this.AchievementOneCheckBox.UseVisualStyleBackColor = true;
            // 
            // AchievementTwoCheckBox
            // 
            this.AchievementTwoCheckBox.AutoSize = true;
            this.AchievementTwoCheckBox.Depth = 0;
            this.AchievementTwoCheckBox.Enabled = false;
            this.AchievementTwoCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.AchievementTwoCheckBox.Location = new System.Drawing.Point(12, 150);
            this.AchievementTwoCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.AchievementTwoCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AchievementTwoCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.AchievementTwoCheckBox.Name = "AchievementTwoCheckBox";
            this.AchievementTwoCheckBox.Ripple = true;
            this.AchievementTwoCheckBox.Size = new System.Drawing.Size(137, 30);
            this.AchievementTwoCheckBox.TabIndex = 12;
            this.AchievementTwoCheckBox.Text = "AchievementTwo";
            this.AchievementTwoCheckBox.UseVisualStyleBackColor = true;
            // 
            // DungeonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 317);
            this.Controls.Add(this.AchievementTwoCheckBox);
            this.Controls.Add(this.AchievementOneCheckBox);
            this.Controls.Add(this.CheckBoxNoDeath);
            this.Controls.Add(this.CheckBoxSpeedrun);
            this.Controls.Add(this.CheckBoxHardmode);
            this.Controls.Add(this.AchievementTwoInput);
            this.Controls.Add(this.AchievementTwoBar);
            this.Controls.Add(this.AchievementOneInput);
            this.Controls.Add(this.AchievementOneBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DungeonForm";
            this.Sizable = false;
            this.Text = "DungeonForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DungeonForm_FormClosed);
            this.Shown += new System.EventHandler(this.DungeonForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialProgressBar AchievementOneBar;
        private MaterialSkin.Controls.MaterialSingleLineTextField AchievementOneInput;
        private MaterialSkin.Controls.MaterialProgressBar AchievementTwoBar;
        private MaterialSkin.Controls.MaterialSingleLineTextField AchievementTwoInput;
        private MaterialSkin.Controls.MaterialCheckBox CheckBoxHardmode;
        private MaterialSkin.Controls.MaterialCheckBox CheckBoxSpeedrun;
        private MaterialSkin.Controls.MaterialCheckBox CheckBoxNoDeath;
        private MaterialSkin.Controls.MaterialCheckBox AchievementOneCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox AchievementTwoCheckBox;
    }
}