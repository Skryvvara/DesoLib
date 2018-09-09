using System.Collections.Generic;
using System.Windows.Forms;
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
        private bool HasSearched = false;

        public Main()
        {
            InitializeComponent();

            PatchnotesBrowser.ScriptErrorsSuppressed = true;
            _activeForms = new List<MaterialForm>();
            _activeDungeonButtons = new List<MaterialFlatButton>();
            FindAllButtons();

            var themeManager = new ThemeManager();
            themeManager.SetTheme(this, _settings.LightColorScheme);

            var fileHandler = new FileHandler();
            _dungeons = fileHandler.ReadFromFile(_settings.DefaultDataPath);


            // HIDE UNFINISHED

            SearchInputLine.Visible = true;
            ButtonSearch.Visible = true;

            // HIDE UNFINISHED
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

                    if (!isOpen)
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
            DialogResult result = MessageBox.Show("Möchten Sie die Dungeon-Datei wirklich neu anfordern?", "Warnung",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DialogResult result2 = MessageBox.Show("Möchten Sie Ihre bisherigen eigetragenen Daten behalten?", "Warnung",
                                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result2 == DialogResult.Yes)
                {
                    UpdateDungeonFile();
                    ChangeAllButtonsVisibility(ShowAllDungeons);
                }
                else if (result2 == DialogResult.No)
                {
                    var fileHandler = new FileHandler();
                    fileHandler.ReCreateDungeonFile(_settings.DefaultDataPath);

                    _dungeons = fileHandler.ReadFromFile(_settings.DefaultDataPath);
                    for (int i = 0; i < _dungeons.Count; i++)
                    {
                        _dungeons[i].CheckCompletion();
                    }

                    ChangeAllButtonsVisibility(ShowAllDungeons);
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void UpdateDungeonFile()
        {
            var fileHandler = new FileHandler();
            List<Dungeon> newDungeonFile = fileHandler.GetFreshDungeonList();

            for (int i = 0; i < newDungeonFile.Count; i++)
            {
                Dungeon dungeon = _dungeons.Find(x => x.DungeonName == newDungeonFile[i].DungeonName);
                if (dungeon != null)
                {
                    newDungeonFile[i].AchievementOneValue = dungeon.AchievementOneValue;
                    newDungeonFile[i].AchievementTwoValue = dungeon.AchievementTwoValue;
                    newDungeonFile[i].HardmodeDone = dungeon.HardmodeDone;
                    newDungeonFile[i].SpeedrunDone = dungeon.SpeedrunDone;
                    newDungeonFile[i].NodeathDone = dungeon.NodeathDone;
                    newDungeonFile[i].IsComplete = dungeon.IsComplete;
                }
            }

            _dungeons = newDungeonFile;
        }

        private void CheckBoxHideCompleted_CheckedChanged(object sender, System.EventArgs e)
        {
            if(HasSearched)
                SearchForSet(null, null);

            ChangeAllButtonsVisibility(!CheckBoxHideCompleted.Checked);
            ShowAllDungeons = !CheckBoxHideCompleted.Checked;
        }

        public void ChangeAllButtonsVisibility(bool state)
        {
            if (HasSearched)
                return;

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

        private void SearchInputLine_Click(object sender, System.EventArgs e)
        {
            SearchInputLine.Text = "";
        }

        private void SearchForSet(object sender, System.EventArgs e)
        {
            if (HasSearched)
            {
                HasSearched = false;
                ChangeAllButtonsVisibility(ShowAllDungeons);
                return;
            }

            if (SearchInputLine.Text == "")
                return;

            HasSearched = true;
            for (int i = 0; i < _dungeons.Count; i++)
            {
                int contains = 0;
                for (int j = 0; j < _dungeons[i].Sets.Count; j++)
                {
                    if (_dungeons[i].Sets[j].SetName.Contains(SearchInputLine.Text))
                    {
                        contains++;
                    }
                }

                if(contains == 0)
                    _activeDungeonButtons.Find(x => x.Text == _dungeons[i].DungeonName).Enabled = false;
                else
                    _activeDungeonButtons.Find(x => x.Text == _dungeons[i].DungeonName).Enabled = true;
            }
        }

        private void CallSettingsForm(object sender, System.EventArgs e)
        {
            bool isOpen = false;
            for (int i = 0; i < _activeForms.Count; i++)
            {
                if (_activeForms[i].Text == "Einstellungen")
                {
                    isOpen = true;
                    break;
                }
            }

            if (!isOpen)
            {
                var settingsForm = new SettingsForm();
                settingsForm.mainForm = this;
                _activeForms.Add(settingsForm);

                settingsForm.Show();
            }
        }

        public void RestartApplication()
        {
            Application.Restart();
        }
    }
}