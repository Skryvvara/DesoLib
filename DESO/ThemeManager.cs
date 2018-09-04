using MaterialSkin;
using MaterialSkin.Controls;

namespace DESO
{
    internal class ThemeManager
    {
        public void SetTheme(MaterialForm form, bool light = false)
        {
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(form);
            skinManager.Theme = light ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;

            skinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey600, Accent.Teal100, TextShade.WHITE);
        }
    }
}
