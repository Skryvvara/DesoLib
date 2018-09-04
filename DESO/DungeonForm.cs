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
            mainForm._activeForms.Remove(this);
        }

        /* ---   Dungeon Data Handling   --- */

        private void UpdateDungeonData()
        {
            AchievementOneLabel.Text = CurrentDungeon.AchievementOneName;
            AchievementOneBar.Maximum = CurrentDungeon.AchievementOneMax;
            AchievementOneBar.Value = CurrentDungeon.AchievementOneValue;
            AchievementOneInput.Text = CurrentDungeon.AchievementOneValue.ToString();


            for (int i = 0; i < mainForm._dungeons.Count; i++)
            {
                if (mainForm._dungeons[i].DungeonName == this.CurrentDungeon.DungeonName)
                {
                    mainForm._dungeons[i] = this.CurrentDungeon;
                    SaveDungeonData();
                }
            }
        }

        private void SaveDungeonData()
        {
            var fileHandler = new FileHandler();
            fileHandler.WriteToFile("C:/deso", mainForm._dungeons);
        }

        private void AchievementOneInput_TextChanged(object sender, System.EventArgs e)
        {
            AchievementOneInput.Text = Regex.Replace(AchievementOneInput.Text, "[^0-9.]", "");

            if (AchievementOneInput.Text != null && AchievementOneInput.Text != "")
            {
                int value = System.Convert.ToInt32(AchievementOneInput.Text);

                if (value > AchievementOneBar.Maximum)
                {
                    value = AchievementOneBar.Maximum;
                    AchievementOneInput.Text = value.ToString();
                }

                this.CurrentDungeon.AchievementOneValue = value;
                AchievementOneBar.Value = value;
            }
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            UpdateDungeonData();
        }

        /* ---   Dungeon Data Handling   --- */
    }
}
