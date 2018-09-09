using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Drawing;
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
            InitializeDungeonData();
        }

        private void DungeonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveDungeonData();
            mainForm.ChangeAllButtonsVisibility(mainForm.ShowAllDungeons);
            mainForm._activeForms.Remove(this);
        }

        /* ---   DUNGEON DATA HANDLING   --- */

        private void InitializeDungeonData()
        {
            if (!CurrentDungeon.IsTrial)
            {
                TrialArmorSet0.Visible = false;
                TrialArmorSet1.Visible = false;
                LightArmorLabel.Text = CurrentDungeon.Sets[0].SetName;
                MediumArmorLabel.Text = CurrentDungeon.Sets[1].SetName;
                HeavyArmorLabel.Text = CurrentDungeon.Sets[2].SetName;
                MonsterSetLabel.Text = CurrentDungeon.Sets[3].SetName;
            }
            else if (CurrentDungeon.IsTrial)
            {
                AchievementOneCheckBox.Visible = false;
                AchievementOneBar.Visible = false;
                AchievementOneInput.Visible = false;

                AchievementTwoCheckBox.Visible = false;
                AchievementTwoBar.Visible = false;
                AchievementTwoInput.Visible = false;

                LightArmorLabel.Text = CurrentDungeon.Sets[0].SetName;
                MediumArmorLabel.Text = CurrentDungeon.Sets[1].SetName;
                HeavyArmorLabel.Text = CurrentDungeon.Sets[2].SetName;
                MonsterSetLabel.Text = CurrentDungeon.Sets[3].SetName;

                if (CurrentDungeon.Sets.Count >= 5)
                {
                    TrialArmorSet0.Visible = true;
                    TrialArmorSet0.Text = CurrentDungeon.Sets[4].SetName;
                }
                else
                    TrialArmorSet0.Visible = false;

                if (CurrentDungeon.Sets.Count >= 6)
                {
                    TrialArmorSet1.Visible = true;
                    TrialArmorSet1.Text = CurrentDungeon.Sets[5].SetName;
                }
                else
                    TrialArmorSet1.Visible = false;

                if (CurrentDungeon.Sets.Count >= 7)
                {
                    TrialArmorSet2.Visible = true;
                    TrialArmorSet2.Text = CurrentDungeon.Sets[6].SetName;
                }
                else
                    TrialArmorSet2.Visible = false;

                if (CurrentDungeon.Sets.Count >= 8)
                {
                    TrialArmorSet3.Visible = true;
                    TrialArmorSet3.Text = CurrentDungeon.Sets[7].SetName;
                }
                else
                    TrialArmorSet3.Visible = false;
            }

            this.Height = 225;
            for (int i = 0; i < CurrentDungeon.Sets.Count; i++)
            {
                this.Height = Height + 30;
            }

            CheckBoxHardmode.Visible = CurrentDungeon.HasHardmode;
            CheckBoxSpeedrun.Visible = CurrentDungeon.HasSpeedrun;
            CheckBoxNoDeath.Visible = CurrentDungeon.HasNoDeath;

            UpdateDungeonData();
        }

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

            CheckBoxVeteran.Checked = CurrentDungeon.DoneOnVet;

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
                    break;
                }
            }

            var fileHandler = new FileHandler();
            fileHandler.WriteToFile(_settings.DefaultDataPath, mainForm._dungeons);
        }

        private void AchievementOneInput_TextChanged(object sender, System.EventArgs e)
        {
            AchievementOneInput.Text = Regex.Replace(AchievementOneInput.Text, "[^0-9]", "");

            if (AchievementOneInput.Text != null)
            {
                if (AchievementOneInput.Text == "")
                    AchievementOneInput.Text = 0.ToString();

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

            if (AchievementTwoInput.Text != null)
            {
                if (AchievementTwoInput.Text == "")
                    AchievementTwoInput.Text = 0.ToString();

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
                case "Veteran":
                    CurrentDungeon.DoneOnVet = checkBox.Checked;
                    break;
                default:
                    break;
            }

            UpdateDungeonData();
        }

        private void SetLabelClicked(object sender, System.EventArgs e)
        {
            string url = CurrentDungeon.Sets.Find(x => x.SetName == ((MaterialLabel)sender).Text).SetURL;
            System.Diagnostics.Process.Start(url);
        }
        /* ---   DUNGEON DATA HANDLING   --- */
    }
}