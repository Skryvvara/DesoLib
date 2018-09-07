using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace DESO
{
    public partial class SettingsForm : MaterialForm
    {
        private Properties.Settings _settings = new Properties.Settings();
        public Main mainForm;

        public SettingsForm()
        {
            InitializeComponent();

            var themeManager = new ThemeManager();
            themeManager.SetTheme(this, _settings.LightColorScheme);

            InitializeSettingControls();
        }

        private void InitializeSettingControls()
        {
            CheckBoxLightTheme.Checked = _settings.LightColorScheme;
            LabelDefaultDataPath.Text = _settings.DefaultDataPath;
        }

        private void SaveSettings()
        {
            _settings.Save();
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm._activeForms.Remove(this);
        }

        private void CheckBoxLightTheme_CheckedChanged(object sender, System.EventArgs e)
        {
            _settings.LightColorScheme = CheckBoxLightTheme.Checked;
            SaveSettings();
        }

        private void ButtonChangePath_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                _settings.DefaultDataPath = folderBrowserDialog.SelectedPath + @"\";
                LabelDefaultDataPath.Text = _settings.DefaultDataPath;
            }
        }

        private void ButtonDefault_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sind Sie sicher, dass sie die Einstellungen auf Standartwerte zurücksetzen wollen?.",
                                    "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _settings.DefaultDataPath = _settings.RestoreDataPath;
                _settings.LightColorScheme = false;
                SaveSettings();
                InitializeSettingControls();
            }
            else
            {

            }
        }

        private void ButtonSave_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sind Sie sicher, dass sie die Einstellungen speichern wollen?.",
                                    "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SaveSettings();
                DialogResult result2 = MessageBox.Show("Einstellungen gespeichert! Die Einstellungen werden erst nach einem Neustart des Programmes übernommen," + 
                                        "möchten Sie das Programm neu Starten?", "Hinweis", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result2 == DialogResult.Yes)
                {
                    mainForm._activeForms.Remove(this);
                    this.mainForm.RestartApplication();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}