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
            Version = "6.1.0",
            PackageName = "Wsz.Oqt.WszTheme",
            Owner = "Wettkampf-Software Zimmer",
            Url = "https://www.wettkampf-software-zimmer.de/",
            Contact = "webmaster@wettkampf-software-zimmer.de",
            License = "Free",
            Resources = new List<Resource>()
            {
		        // Obtained from https://cdnjs.com/libraries
                // Sourcefile: "https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.3/css/bootstrap.min.css"
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "/Themes/Wsz.Oqt.WszTheme/bootstrap.min.css", Integrity = "sha512-jnSuA4Ss2PkkikSOLtYs8BlYIeeIK1h99ty4YfvRPAlzr377vr3CXDb7sb7eEEBYjDtcYj+AjBH3FLv5uSJuXg==", CrossOrigin = "anonymous" },
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/WszTheme.css" },
                // Sourcefile: "https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.3/js/bootstrap.bundle.min.js"
                new Resource { ResourceType = ResourceType.Script, Url = "/Themes/Wsz.Oqt.WszTheme/bootstrap.bundle.min.js", Integrity = "sha512-7Pi/otdlbbCR+LnW+F7PwFcSDJOuUJB3OxtEHbg4vSMvzvJjde4Po1v4BR9Gdc9aXNUNFVUY+SK51wWT8WF0Gg==", CrossOrigin = "anonymous" }
            }
        };

    }
}
