using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace DESO
{
    public partial class Main : MaterialForm
    {
        public List<Dungeon> _dungeons;
        public List<MaterialForm> _activeForms;

        public Main()
        {
            InitializeComponent();

            PatchnotesBrowser.ScriptErrorsSuppressed = true;
            _activeForms = new List<MaterialForm>();

            var themeManager = new ThemeManager();
            themeManager.SetTheme(this);

            var fileHandler = new FileHandler();
            _dungeons = fileHandler.ReadFromFile("C:/deso");
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
                        }
                    }

                    if (isOpen == false)
                    {
                        OpenDungeonForm(_dungeons[i]);
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
    }
}
