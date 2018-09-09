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
            this.AchievementTwoBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.AchievementTwoInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CheckBoxVeteran = new MaterialSkin.Controls.MaterialCheckBox();
            this.CheckBoxSpeedrun = new MaterialSkin.Controls.MaterialCheckBox();
            this.CheckBoxNoDeath = new MaterialSkin.Controls.MaterialCheckBox();
            this.AchievementOneCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.AchievementTwoCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.LightArmorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.MediumArmorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.HeavyArmorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.MonsterSetLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AchievementOneInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TrialArmorSet1 = new MaterialSkin.Controls.MaterialLabel();
            this.TrialArmorSet0 = new MaterialSkin.Controls.MaterialLabel();
            this.TrialArmorSet2 = new MaterialSkin.Controls.MaterialLabel();
            this.TrialArmorSet3 = new MaterialSkin.Controls.MaterialLabel();
            this.CheckBoxHardmode = new MaterialSkin.Controls.MaterialCheckBox();
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
            // CheckBoxVeteran
            // 
            this.CheckBoxVeteran.AutoSize = true;
            this.CheckBoxVeteran.Depth = 0;
            this.CheckBoxVeteran.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckBoxVeteran.Location = new System.Drawing.Point(12, 220);
            this.CheckBoxVeteran.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxVeteran.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxVeteran.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxVeteran.Name = "CheckBoxVeteran";
            this.CheckBoxVeteran.Ripple = true;
            this.CheckBoxVeteran.Size = new System.Drawing.Size(78, 30);
            this.CheckBoxVeteran.TabIndex = 8;
            this.CheckBoxVeteran.Text = "Veteran";
            this.CheckBoxVeteran.UseVisualStyleBackColor = true;
            this.CheckBoxVeteran.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // CheckBoxSpeedrun
            // 
            this.CheckBoxSpeedrun.AutoSize = true;
            this.CheckBoxSpeedrun.Depth = 0;
            this.CheckBoxSpeedrun.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckBoxSpeedrun.Location = new System.Drawing.Point(12, 280);
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
            this.CheckBoxNoDeath.Location = new System.Drawing.Point(12, 310);
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
            // LightArmorLabel
            // 
            this.LightArmorLabel.AutoSize = true;
            this.LightArmorLabel.Depth = 0;
            this.LightArmorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightArmorLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LightArmorLabel.Location = new System.Drawing.Point(125, 226);
            this.LightArmorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LightArmorLabel.Name = "LightArmorLabel";
            this.LightArmorLabel.Size = new System.Drawing.Size(106, 15);
            this.LightArmorLabel.TabIndex = 14;
            this.LightArmorLabel.Text = "Light Armor Set";
            this.LightArmorLabel.Click += new System.EventHandler(this.SetLabelClicked);
            // 
            // MediumArmorLabel
            // 
            this.MediumArmorLabel.AutoSize = true;
            this.MediumArmorLabel.Depth = 0;
            this.MediumArmorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.MediumArmorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MediumArmorLabel.Location = new System.Drawing.Point(125, 256);
            this.MediumArmorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MediumArmorLabel.Name = "MediumArmorLabel";
            this.MediumArmorLabel.Size = new System.Drawing.Size(126, 15);
            this.MediumArmorLabel.TabIndex = 15;
            this.MediumArmorLabel.Text = "Medium Armor Set";
            this.MediumArmorLabel.Click += new System.EventHandler(this.SetLabelClicked);
            // 
            // HeavyArmorLabel
            // 
            this.HeavyArmorLabel.AutoSize = true;
            this.HeavyArmorLabel.Depth = 0;
            this.HeavyArmorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.HeavyArmorLabel.ForeColor = System.Drawing.Color.Red;
            this.HeavyArmorLabel.Location = new System.Drawing.Point(125, 286);
            this.HeavyArmorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.HeavyArmorLabel.Name = "HeavyArmorLabel";
            this.HeavyArmorLabel.Size = new System.Drawing.Size(112, 15);
            this.HeavyArmorLabel.TabIndex = 16;
            this.HeavyArmorLabel.Text = "Heavy Armor Set";
            this.HeavyArmorLabel.Click += new System.EventHandler(this.SetLabelClicked);
            // 
            // MonsterSetLabel
            // 
            this.MonsterSetLabel.AutoSize = true;
            this.MonsterSetLabel.Depth = 0;
            this.MonsterSetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.MonsterSetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MonsterSetLabel.Location = new System.Drawing.Point(125, 316);
            this.MonsterSetLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MonsterSetLabel.Name = "MonsterSetLabel";
            this.MonsterSetLabel.Size = new System.Drawing.Size(126, 15);
            this.MonsterSetLabel.TabIndex = 17;
            this.MonsterSetLabel.Text = "Monster Armor Set";
            this.MonsterSetLabel.Click += new System.EventHandler(this.SetLabelClicked);
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
            // TrialArmorSet1
            // 
            this.TrialArmorSet1.AutoSize = true;
            this.TrialArmorSet1.Depth = 0;
            this.TrialArmorSet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.TrialArmorSet1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TrialArmorSet1.Location = new System.Drawing.Point(125, 376);
            this.TrialArmorSet1.MouseState = MaterialSkin.MouseState.HOVER;
            this.TrialArmorSet1.Name = "TrialArmorSet1";
            this.TrialArmorSet1.Size = new System.Drawing.Size(138, 15);
            this.TrialArmorSet1.TabIndex = 20;
            this.TrialArmorSet1.Text = "Additional Armor Set";
            this.TrialArmorSet1.Visible = false;
            this.TrialArmorSet1.Click += new System.EventHandler(this.SetLabelClicked);
            // 
            // TrialArmorSet0
            // 
            this.TrialArmorSet0.AutoSize = true;
            this.TrialArmorSet0.Depth = 0;
            this.TrialArmorSet0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.TrialArmorSet0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TrialArmorSet0.Location = new System.Drawing.Point(125, 346);
            this.TrialArmorSet0.MouseState = MaterialSkin.MouseState.HOVER;
            this.TrialArmorSet0.Name = "TrialArmorSet0";
            this.TrialArmorSet0.Size = new System.Drawing.Size(138, 15);
            this.TrialArmorSet0.TabIndex = 21;
            this.TrialArmorSet0.Text = "Additional Armor Set";
            this.TrialArmorSet0.Click += new System.EventHandler(this.SetLabelClicked);
            // 
            // TrialArmorSet2
            // 
            this.TrialArmorSet2.AutoSize = true;
            this.TrialArmorSet2.Depth = 0;
            this.TrialArmorSet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.TrialArmorSet2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TrialArmorSet2.Location = new System.Drawing.Point(125, 406);
            this.TrialArmorSet2.MouseState = MaterialSkin.MouseState.HOVER;
            this.TrialArmorSet2.Name = "TrialArmorSet2";
            this.TrialArmorSet2.Size = new System.Drawing.Size(138, 15);
            this.TrialArmorSet2.TabIndex = 26;
            this.TrialArmorSet2.Text = "Additional Armor Set";
            this.TrialArmorSet2.Visible = false;
            this.TrialArmorSet2.Click += new System.EventHandler(this.SetLabelClicked);
            // 
            // TrialArmorSet3
            // 
            this.TrialArmorSet3.AutoSize = true;
            this.TrialArmorSet3.Depth = 0;
            this.TrialArmorSet3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.TrialArmorSet3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TrialArmorSet3.Location = new System.Drawing.Point(125, 436);
            this.TrialArmorSet3.MouseState = MaterialSkin.MouseState.HOVER;
            this.TrialArmorSet3.Name = "TrialArmorSet3";
            this.TrialArmorSet3.Size = new System.Drawing.Size(138, 15);
            this.TrialArmorSet3.TabIndex = 28;
            this.TrialArmorSet3.Text = "Additional Armor Set";
            this.TrialArmorSet3.Visible = false;
            this.TrialArmorSet3.Click += new System.EventHandler(this.SetLabelClicked);
            // 
            // CheckBoxHardmode
            // 
            this.CheckBoxHardmode.AutoSize = true;
            this.CheckBoxHardmode.Depth = 0;
            this.CheckBoxHardmode.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckBoxHardmode.Location = new System.Drawing.Point(12, 250);
            this.CheckBoxHardmode.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxHardmode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxHardmode.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxHardmode.Name = "CheckBoxHardmode";
            this.CheckBoxHardmode.Ripple = true;
            this.CheckBoxHardmode.Size = new System.Drawing.Size(95, 30);
            this.CheckBoxHardmode.TabIndex = 29;
            this.CheckBoxHardmode.Text = "Hardmode";
            this.CheckBoxHardmode.UseVisualStyleBackColor = true;
            this.CheckBoxHardmode.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // DungeonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 465);
            this.Controls.Add(this.CheckBoxHardmode);
            this.Controls.Add(this.TrialArmorSet3);
            this.Controls.Add(this.TrialArmorSet2);
            this.Controls.Add(this.TrialArmorSet0);
            this.Controls.Add(this.TrialArmorSet1);
            this.Controls.Add(this.MonsterSetLabel);
            this.Controls.Add(this.HeavyArmorLabel);
            this.Controls.Add(this.MediumArmorLabel);
            this.Controls.Add(this.LightArmorLabel);
            this.Controls.Add(this.AchievementTwoCheckBox);
            this.Controls.Add(this.AchievementOneCheckBox);
            this.Controls.Add(this.CheckBoxNoDeath);
            this.Controls.Add(this.CheckBoxSpeedrun);
            this.Controls.Add(this.CheckBoxVeteran);
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
        private MaterialSkin.Controls.MaterialProgressBar AchievementTwoBar;
        private MaterialSkin.Controls.MaterialSingleLineTextField AchievementTwoInput;
        private MaterialSkin.Controls.MaterialCheckBox CheckBoxVeteran;
        private MaterialSkin.Controls.MaterialCheckBox CheckBoxSpeedrun;
        private MaterialSkin.Controls.MaterialCheckBox CheckBoxNoDeath;
        private MaterialSkin.Controls.MaterialCheckBox AchievementOneCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox AchievementTwoCheckBox;
        private MaterialSkin.Controls.MaterialLabel LightArmorLabel;
        private MaterialSkin.Controls.MaterialLabel MediumArmorLabel;
        private MaterialSkin.Controls.MaterialLabel HeavyArmorLabel;
        private MaterialSkin.Controls.MaterialLabel MonsterSetLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField AchievementOneInput;
        private MaterialSkin.Controls.MaterialLabel TrialArmorSet1;
        private MaterialSkin.Controls.MaterialLabel TrialArmorSet0;
        private MaterialSkin.Controls.MaterialLabel TrialArmorSet2;
        private MaterialSkin.Controls.MaterialLabel TrialArmorSet3;
        private MaterialSkin.Controls.MaterialCheckBox CheckBoxHardmode;
    }
}