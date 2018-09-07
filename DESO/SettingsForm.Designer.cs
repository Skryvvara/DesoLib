namespace DESO
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.CheckBoxLightTheme = new MaterialSkin.Controls.MaterialCheckBox();
            this.ButtonSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.ButtonDefault = new MaterialSkin.Controls.MaterialFlatButton();
            this.LabelDefaultDataPath = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonChangePath = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // CheckBoxLightTheme
            // 
            this.CheckBoxLightTheme.AutoSize = true;
            this.CheckBoxLightTheme.Depth = 0;
            this.CheckBoxLightTheme.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckBoxLightTheme.Location = new System.Drawing.Point(9, 69);
            this.CheckBoxLightTheme.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxLightTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxLightTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxLightTheme.Name = "CheckBoxLightTheme";
            this.CheckBoxLightTheme.Ripple = true;
            this.CheckBoxLightTheme.Size = new System.Drawing.Size(115, 30);
            this.CheckBoxLightTheme.TabIndex = 2;
            this.CheckBoxLightTheme.Text = "Helles Theme";
            this.CheckBoxLightTheme.UseVisualStyleBackColor = true;
            this.CheckBoxLightTheme.CheckedChanged += new System.EventHandler(this.CheckBoxLightTheme_CheckedChanged);
            // 
            // ButtonSave
            // 
            this.ButtonSave.AutoSize = true;
            this.ButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSave.Depth = 0;
            this.ButtonSave.Icon = null;
            this.ButtonSave.Location = new System.Drawing.Point(13, 270);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Primary = false;
            this.ButtonSave.Size = new System.Drawing.Size(94, 36);
            this.ButtonSave.TabIndex = 3;
            this.ButtonSave.Text = "Speichern";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonDefault
            // 
            this.ButtonDefault.AutoSize = true;
            this.ButtonDefault.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonDefault.Depth = 0;
            this.ButtonDefault.Icon = null;
            this.ButtonDefault.Location = new System.Drawing.Point(172, 270);
            this.ButtonDefault.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonDefault.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonDefault.Name = "ButtonDefault";
            this.ButtonDefault.Primary = false;
            this.ButtonDefault.Size = new System.Drawing.Size(92, 36);
            this.ButtonDefault.TabIndex = 4;
            this.ButtonDefault.Text = "Standard";
            this.ButtonDefault.UseVisualStyleBackColor = true;
            this.ButtonDefault.Click += new System.EventHandler(this.ButtonDefault_Click);
            // 
            // LabelDefaultDataPath
            // 
            this.LabelDefaultDataPath.AutoSize = true;
            this.LabelDefaultDataPath.Depth = 0;
            this.LabelDefaultDataPath.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelDefaultDataPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelDefaultDataPath.Location = new System.Drawing.Point(9, 108);
            this.LabelDefaultDataPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelDefaultDataPath.Name = "LabelDefaultDataPath";
            this.LabelDefaultDataPath.Size = new System.Drawing.Size(144, 19);
            this.LabelDefaultDataPath.TabIndex = 5;
            this.LabelDefaultDataPath.Text = "C:/Darkyne/DesoLib";
            // 
            // ButtonChangePath
            // 
            this.ButtonChangePath.AutoSize = true;
            this.ButtonChangePath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonChangePath.Depth = 0;
            this.ButtonChangePath.Icon = null;
            this.ButtonChangePath.Location = new System.Drawing.Point(13, 133);
            this.ButtonChangePath.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonChangePath.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonChangePath.Name = "ButtonChangePath";
            this.ButtonChangePath.Primary = false;
            this.ButtonChangePath.Size = new System.Drawing.Size(113, 36);
            this.ButtonChangePath.TabIndex = 6;
            this.ButtonChangePath.Text = "Pfad ändern";
            this.ButtonChangePath.UseVisualStyleBackColor = true;
            this.ButtonChangePath.Click += new System.EventHandler(this.ButtonChangePath_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 321);
            this.Controls.Add(this.ButtonChangePath);
            this.Controls.Add(this.LabelDefaultDataPath);
            this.Controls.Add(this.ButtonDefault);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.CheckBoxLightTheme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Sizable = false;
            this.Text = "Einstellungen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckBox CheckBoxLightTheme;
        private MaterialSkin.Controls.MaterialFlatButton ButtonSave;
        private MaterialSkin.Controls.MaterialFlatButton ButtonDefault;
        private MaterialSkin.Controls.MaterialLabel LabelDefaultDataPath;
        private MaterialSkin.Controls.MaterialFlatButton ButtonChangePath;
    }
}