using Oqtane.Models;
using Oqtane.Themes;
using Oqtane.Shared;

namespace Wsz.Oqt.WszTheme
{
    public class ThemeInfo : ITheme
    {
        public Theme Theme => new Theme
        {
            Name = "Wettkampf-Software Theme",
            Version = "5.0.2",
            PackageName = "Wsz.Oqt.WszTheme",
            Owner = "Wettkampf-Software Zimmer",
            Url = "https://www.wettkampf-software-zimmer.de/",
            Contact = "webmaster@wettkampf-software-zimmer.de",
            License = "Free",
            Resources = new List<Resource>()
            {
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/css/bootstrap.min.css", Integrity = "sha512-t4GWSVZO1eC8BM339Xd7Uphw5s17a86tIZIj8qRxhnKub6WoyhnrxeCIMeAqBPgdZGlCcG2PrZjMc+Wr78+5Xg==", CrossOrigin = "anonymous" },
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/WszTheme.css" },
                new Resource { ResourceType = ResourceType.Script, Url = "https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/js/bootstrap.bundle.min.js", Integrity = "sha512-VK2zcvntEufaimc+efOYi622VN5ZacdnufnmX7zIhCPmjhKnOi9ZDMtg1/ug5l183f19gG1/cBstPO4D8N/Img==", CrossOrigin = "anonymous" }
            }
        };

    }
}
