namespace DESO
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.MainTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.MainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.NewsTab = new System.Windows.Forms.TabPage();
            this.PatchnotesBrowser = new System.Windows.Forms.WebBrowser();
            this.DungeonsTrialsPage = new System.Windows.Forms.TabPage();
            this.ButtonFungalGrottoII = new MaterialSkin.Controls.MaterialFlatButton();
            this.ButtonFungalGrottoI = new MaterialSkin.Controls.MaterialFlatButton();
            this.DungeonLabel = new MaterialSkin.Controls.MaterialLabel();
            this.MainTabControl.SuspendLayout();
            this.NewsTab.SuspendLayout();
            this.DungeonsTrialsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainTabSelector
            // 
            this.MainTabSelector.BaseTabControl = this.MainTabControl;
            this.MainTabSelector.Depth = 0;
            this.MainTabSelector.Location = new System.Drawing.Point(0, 64);
            this.MainTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainTabSelector.Name = "MainTabSelector";
            this.MainTabSelector.Size = new System.Drawing.Size(1232, 23);
            this.MainTabSelector.TabIndex = 1;
            this.MainTabSelector.Text = "MainTabSelector";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.NewsTab);
            this.MainTabControl.Controls.Add(this.DungeonsTrialsPage);
            this.MainTabControl.Depth = 0;
            this.MainTabControl.Location = new System.Drawing.Point(0, 93);
            this.MainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1232, 625);
            this.MainTabControl.TabIndex = 2;
            // 
            // NewsTab
            // 
            this.NewsTab.Controls.Add(this.PatchnotesBrowser);
            this.NewsTab.Location = new System.Drawing.Point(4, 22);
            this.NewsTab.Name = "NewsTab";
            this.NewsTab.Padding = new System.Windows.Forms.Padding(3);
            this.NewsTab.Size = new System.Drawing.Size(1224, 599);
            this.NewsTab.TabIndex = 0;
            this.NewsTab.Text = "Patchnotes";
            this.NewsTab.UseVisualStyleBackColor = true;
            // 
            // PatchnotesBrowser
            // 
            this.PatchnotesBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatchnotesBrowser.Location = new System.Drawing.Point(3, 3);
            this.PatchnotesBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.PatchnotesBrowser.Name = "PatchnotesBrowser";
            this.PatchnotesBrowser.Size = new System.Drawing.Size(1218, 593);
            this.PatchnotesBrowser.TabIndex = 0;
            this.PatchnotesBrowser.Url = new System.Uri("https://forums.elderscrollsonline.com/en/categories/patch-notes", System.UriKind.Absolute);
            // 
            // DungeonsTrialsPage
            // 
            this.DungeonsTrialsPage.Controls.Add(this.ButtonFungalGrottoII);
            this.DungeonsTrialsPage.Controls.Add(this.ButtonFungalGrottoI);
            this.DungeonsTrialsPage.Controls.Add(this.DungeonLabel);
            this.DungeonsTrialsPage.Location = new System.Drawing.Point(4, 22);
            this.DungeonsTrialsPage.Name = "DungeonsTrialsPage";
            this.DungeonsTrialsPage.Padding = new System.Windows.Forms.Padding(3);
            this.DungeonsTrialsPage.Size = new System.Drawing.Size(1224, 599);
            this.DungeonsTrialsPage.TabIndex = 1;
            this.DungeonsTrialsPage.Text = "Dungeons & Trials";
            this.DungeonsTrialsPage.UseVisualStyleBackColor = true;
            // 
            // ButtonFungalGrottoII
            // 
            this.ButtonFungalGrottoII.AutoSize = true;
            this.ButtonFungalGrottoII.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonFungalGrottoII.Depth = 0;
            this.ButtonFungalGrottoII.Icon = null;
            this.ButtonFungalGrottoII.Location = new System.Drawing.Point(12, 85);
            this.ButtonFungalGrottoII.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonFungalGrottoII.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonFungalGrottoII.Name = "ButtonFungalGrottoII";
            this.ButtonFungalGrottoII.Primary = false;
            this.ButtonFungalGrottoII.Size = new System.Drawing.Size(112, 36);
            this.ButtonFungalGrottoII.TabIndex = 2;
            this.ButtonFungalGrottoII.Text = "Pilzgrotte 2";
            this.ButtonFungalGrottoII.UseVisualStyleBackColor = true;
            this.ButtonFungalGrottoII.Click += new System.EventHandler(this.CallDungeonForm);
            // 
            // ButtonFungalGrottoI
            // 
            this.ButtonFungalGrottoI.AutoSize = true;
            this.ButtonFungalGrottoI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonFungalGrottoI.Depth = 0;
            this.ButtonFungalGrottoI.Icon = null;
            this.ButtonFungalGrottoI.Location = new System.Drawing.Point(12, 37);
            this.ButtonFungalGrottoI.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonFungalGrottoI.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonFungalGrottoI.Name = "ButtonFungalGrottoI";
            this.ButtonFungalGrottoI.Primary = false;
            this.ButtonFungalGrottoI.Size = new System.Drawing.Size(108, 36);
            this.ButtonFungalGrottoI.TabIndex = 1;
            this.ButtonFungalGrottoI.Text = "Pilzgrotte I";
            this.ButtonFungalGrottoI.UseVisualStyleBackColor = true;
            this.ButtonFungalGrottoI.Click += new System.EventHandler(this.CallDungeonForm);
            // 
            // DungeonLabel
            // 
            this.DungeonLabel.AutoSize = true;
            this.DungeonLabel.Depth = 0;
            this.DungeonLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.DungeonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DungeonLabel.Location = new System.Drawing.Point(8, 12);
            this.DungeonLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DungeonLabel.Name = "DungeonLabel";
            this.DungeonLabel.Size = new System.Drawing.Size(89, 19);
            this.DungeonLabel.TabIndex = 0;
            this.DungeonLabel.Text = "DUNGEONS";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 720);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.MainTabSelector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DESO";
            this.MainTabControl.ResumeLayout(false);
            this.NewsTab.ResumeLayout(false);
            this.DungeonsTrialsPage.ResumeLayout(false);
            this.DungeonsTrialsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialTabSelector MainTabSelector;
        private MaterialSkin.Controls.MaterialTabControl MainTabControl;
        private System.Windows.Forms.TabPage NewsTab;
        private System.Windows.Forms.WebBrowser PatchnotesBrowser;
        private System.Windows.Forms.TabPage DungeonsTrialsPage;
        private MaterialSkin.Controls.MaterialLabel DungeonLabel;
        private MaterialSkin.Controls.MaterialFlatButton ButtonFungalGrottoI;
        private MaterialSkin.Controls.MaterialFlatButton ButtonFungalGrottoII;
    }
}

