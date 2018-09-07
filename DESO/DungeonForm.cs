using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
using MaterialSkin.Controls;

namespace DESO
{
    public partial class DungeonForm : MaterialForm
    {
        Properties.Settings _settings = new Properties.Settings();

        public Dungeon CurrentDungeon;
        public Main mainForm;

        public DungeonForm()
        {
            InitializeComponent();

            var themeManager = new ThemeManager();
            themeManager.SetTheme(this, _settings.LightColorScheme);
        }

        private void DungeonForm_Shown(object sender, System.EventArgs e)
        {
            UpdateDungeonData();
        }

        private void DungeonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveDungeonData();
            mainForm.ChangeAllButtonsVisibility(mainForm.ShowAllDungeons);
            mainForm._activeForms.Remove(this);
        }

        /* ---   DUNGEON DATA HANDLING   --- */

        private void UpdateDungeonData()
        {
            string spacer = " / ";

            if (!CurrentDungeon.IsTrial)
            {
                AchievementOneCheckBox.Text = CurrentDungeon.AchievementOneName + spacer + CurrentDungeon.AchievementOneMax;
                AchievementOneCheckBox.Checked = IsSameValue(CurrentDungeon.AchievementOneValue, CurrentDungeon.AchievementOneMax);

                if (CurrentDungeon.AchievementOneValue > CurrentDungeon.AchievementOneMax)
                    CurrentDungeon.AchievementOneValue = CurrentDungeon.AchievementOneMax;
                if (CurrentDungeon.AchievementTwoValue > CurrentDungeon.AchievementTwoMax)
                    CurrentDungeon.AchievementTwoValue = CurrentDungeon.AchievementTwoMax;

                AchievementOneBar.Maximum = CurrentDungeon.AchievementOneMax;
                AchievementOneBar.Value = CurrentDungeon.AchievementOneValue;
                AchievementOneInput.Text = CurrentDungeon.AchievementOneValue.ToString();

                AchievementTwoCheckBox.Text = CurrentDungeon.AchievementTwoName + spacer + CurrentDungeon.AchievementTwoMax;
                AchievementTwoCheckBox.Checked = IsSameValue(CurrentDungeon.AchievementTwoValue, CurrentDungeon.AchievementTwoMax);

                AchievementTwoBar.Maximum = CurrentDungeon.AchievementTwoMax;
                AchievementTwoBar.Value = CurrentDungeon.AchievementTwoValue;
                AchievementTwoInput.Text = CurrentDungeon.AchievementTwoValue.ToString();
            }
            else
            {
                AchievementOneCheckBox.Visible = false;
                AchievementOneBar.Visible = false;
                AchievementOneInput.Visible = false;

                AchievementTwoCheckBox.Visible = false;
                AchievementTwoBar.Visible = false;
                AchievementTwoInput.Visible = false;
            }

            CheckBoxHardmode.Checked = CurrentDungeon.HardmodeDone;
            CheckBoxSpeedrun.Checked = CurrentDungeon.SpeedrunDone;
            CheckBoxNoDeath.Checked = CurrentDungeon.NodeathDone;
            
            SaveDungeonData();
        }

        private bool IsSameValue(int source, int comparison)
        {
            return source == comparison;
        }

        private void SaveDungeonData()
        {
            for (int i = 0; i < mainForm._dungeons.Count; i++)
            {
                if (mainForm._dungeons[i].DungeonName == CurrentDungeon.DungeonName)
                {
                    CurrentDungeon.CheckCompletion();
                    mainForm._dungeons[i] = CurrentDungeon;
                    Debug.Print(CurrentDungeon.IsComplete.ToString());
                    break;
                }
            }

            var fileHandler = new FileHandler();
            fileHandler.WriteToFile(_settings.DefaultDataPath, mainForm._dungeons);
        }

        private void AchievementOneInput_TextChanged(object sender, System.EventArgs e)
        {
            AchievementOneInput.Text = Regex.Replace(AchievementOneInput.Text, "[^0-9]", "");

            if (AchievementOneInput.Text != null && AchievementOneInput.Text != "")
            {
                int value = System.Convert.ToInt32(AchievementOneInput.Text);

                if (value > AchievementOneBar.Maximum)
                {
                    value = AchievementOneBar.Maximum;
                    AchievementOneInput.Text = value.ToString();
                }

                CurrentDungeon.AchievementOneValue = value;
                UpdateDungeonData();
            }
        }

        private void AchievementTwoInput_TextChanged(object sender, System.EventArgs e)
        {
            AchievementTwoInput.Text = Regex.Replace(AchievementTwoInput.Text, "[^0-9]", "");

            if (AchievementTwoInput.Text != null && AchievementTwoInput.Text != "")
            {
                int value = System.Convert.ToInt32(AchievementTwoInput.Text);

                if (value > AchievementTwoBar.Maximum)
                {
                    value = AchievementTwoBar.Maximum;
                    AchievementTwoInput.Text = value.ToString();
                }

                CurrentDungeon.AchievementTwoValue = value;
                UpdateDungeonData();
            }
        }

        private void CheckBoxChanged(object sender, System.EventArgs e)
        {
            MaterialCheckBox checkBox = ((MaterialCheckBox)sender);

            switch (checkBox.Text)
            {
                case "Hardmode":
                    CurrentDungeon.HardmodeDone = checkBox.Checked;
                    break;
                case "Speedrun":
                    CurrentDungeon.SpeedrunDone = checkBox.Checked;
                    break;
                case "No Death":
                    CurrentDungeon.NodeathDone = checkBox.Checked;
                    break;
                default:
                    break;
            }
        }
        /* ---   DUNGEON DATA HANDLING   --- */
    }
}