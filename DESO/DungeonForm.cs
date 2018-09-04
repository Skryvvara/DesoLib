using System.Collections.Generic;
using System.Windows.Forms;
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

        private void DungeonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm._activeForms.Remove(this);
        }
    }
}
