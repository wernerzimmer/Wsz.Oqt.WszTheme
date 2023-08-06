using Oqtane.Models;
using Oqtane.Themes;

namespace Wsz.Oqt.WszTheme
{
    public class ThemeInfo : ITheme
    {
        public Theme Theme => new Theme
        {
            Name = "Wettkampf-Software Theme",
            Version = "1.0.2",
            PackageName = "Wsz.Oqt.WszTheme",
            Owner = "Wettkampf-Software Zimmer",
            Url = "https://www.wettkampf-software-zimmer.de/",
            Contact = "info2021@wettkampf-software-zimmer.de",
            License = "Free",
        };

    }
}
