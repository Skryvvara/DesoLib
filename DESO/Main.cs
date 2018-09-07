using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace DESO
{
    public partial class Main : MaterialForm
    {
        private Properties.Settings _settings = new Properties.Settings();

        public List<Dungeon> _dungeons;
        public List<MaterialForm> _activeForms;
        public List<MaterialFlatButton> _activeDungeonButtons;

        public bool ShowAllDungeons = true;

        public Main()
        {
            InitializeComponent();

            PatchnotesBrowser.ScriptErrorsSuppressed = true;
            _activeForms = new List<MaterialForm>();
            _activeDungeonButtons = new List<MaterialFlatButton>();
            FindAllButtons();

            var themeManager = new ThemeManager();
            themeManager.SetTheme(this);

            var fileHandler = new FileHandler();
            _dungeons = fileHandler.ReadFromFile(_settings.CustomDataPath);
        }

        private void CallDungeonForm(object sender, System.EventArgs e)
        {
            for (int i = 0; i < _dungeons.Count; i++)
            {
                if (_dungeons[i].DungeonName == ((MaterialFlatButton)sender).Text)
                {
                    bool isOpen = false;

                    for (int j = 0; j < _activeForms.Count; j++)
                    {
                        if(_activeForms[j].Text == ((MaterialFlatButton)sender).Text)
                        {
                            isOpen = true;
                            break;
                        }
                    }

                    if (isOpen == false)
                    {
                        OpenDungeonForm(_dungeons[i]);
                        break;
                    }
                }
            }
        }

        private void OpenDungeonForm(Dungeon dungeon)
        {
            DungeonForm dungeonForm = new DungeonForm();
            _activeForms.Add(dungeonForm);

            dungeonForm.CurrentDungeon = dungeon;
            dungeonForm.Text = dungeonForm.CurrentDungeon.DungeonName;
            dungeonForm.mainForm = this;

            dungeonForm.Show();
        }

        private void FindAllButtons()
        {
            foreach (Control ctrl in DungeonsTrialsPage.Controls)
            {
                if (ctrl is MaterialFlatButton)
                {
                    _activeDungeonButtons.Add((MaterialFlatButton)ctrl);
                }
            }
        }

        private void ButtonCloseAllForms_Click(object sender, System.EventArgs e)
        {
            int i = 0;
            while (i < _activeForms.Count)
                _activeForms[i].Close();
        }

        private void ButtonRecreateDungeonFile_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten Sie die Dungeon-Datei wirklich neu anfordern? Ihr bisher gespeicherter Fortschritt geht dabei verloren.",
                    "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                var fileHandler = new FileHandler();
                fileHandler.ReCreateDungeonFile(_settings.CustomDataPath);


                _dungeons = fileHandler.ReadFromFile(_settings.CustomDataPath);
                for (int i = 0; i < _dungeons.Count; i++)
                {
                    _dungeons[i].CheckCompletion();
                    //Debug.Print(_dungeons[i].DungeonName + _dungeons[i].IsComplete.ToString());
                }

                ChangeAllButtonsVisibility(true);
            }
            else
            {

            }
        }

        private void CheckBoxHideCompleted_CheckedChanged(object sender, System.EventArgs e)
        {
            ChangeAllButtonsVisibility(!CheckBoxHideCompleted.Checked);
            ShowAllDungeons = !CheckBoxHideCompleted.Checked;
        }

        public void ChangeAllButtonsVisibility(bool state)
        {
            for (int i = 0; i < _dungeons.Count; i++)
            {
                for (int j = 0; j < _activeDungeonButtons.Count; j++)
                {
                    if (_dungeons[i].DungeonName == _activeDungeonButtons[j].Text)
                    {
                        if (_dungeons[i].IsComplete)
                        {
                            _activeDungeonButtons[j].Enabled = state;
                        }
                        else
                        {
                            _activeDungeonButtons[j].Enabled = true;
                        }
                    }
                }
            }
        }
    }
}
