using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace DESO
{
    public partial class DungeonForm : MaterialForm
    {
        public Dungeon CurrentDungeon;
        public Main mainForm;

        public DungeonForm()
        {
            InitializeComponent();

            var themeManager = new ThemeManager();
            themeManager.SetTheme(this);
        }

        private void DungeonForm_Shown(object sender, System.EventArgs e)
        {
            UpdateDungeonData();
        }

        private void DungeonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateDefaultButton();
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

            CurrentDungeon.CheckCompletion();

            for (int i = 0; i < mainForm._dungeons.Count; i++)
            {
                if (mainForm._dungeons[i].DungeonName == CurrentDungeon.DungeonName)
                {
                    mainForm._dungeons[i] = CurrentDungeon;
                    SaveDungeonData();
                }
            }
        }

        private bool IsSameValue(int value1, int value2)
        {
            if (value1 == value2)
                return true;
            else
                return false;
        }

        private void SaveDungeonData()
        {
            var fileHandler = new FileHandler();
            fileHandler.WriteToFile("C:/deso", mainForm._dungeons);
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

                this.CurrentDungeon.AchievementOneValue = value;
                //AchievementOneBar.Value = value;
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

                this.CurrentDungeon.AchievementTwoValue = value;
                //AchievementTwoBar.Value = value;
                UpdateDungeonData();
            }
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            UpdateDungeonData();
        }

        private void CheckBoxChanged(object sender, System.EventArgs e)
        {
            if (((MaterialCheckBox)sender).Text == "Hardmode")
            {
                this.CurrentDungeon.HardmodeDone = ((MaterialCheckBox)sender).Checked;
            }
            else if (((MaterialCheckBox)sender).Text == "Speedrun")
            {
                this.CurrentDungeon.SpeedrunDone = ((MaterialCheckBox)sender).Checked;
            }
            else if (((MaterialCheckBox)sender).Text == "No Death")
            {
                this.CurrentDungeon.NodeathDone = ((MaterialCheckBox)sender).Checked;
            }
        }

        /* ---   DUNGEON DATA HANDLING   --- */
    }
}