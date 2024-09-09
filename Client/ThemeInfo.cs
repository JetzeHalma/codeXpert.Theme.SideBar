using System.Collections.Generic;
using Oqtane.Models;
using Oqtane.Themes;
using Oqtane.Shared;

namespace codeXpert.Theme.SideBar
{
    public class ThemeInfo : ITheme
    {
        public Oqtane.Models.Theme Theme => new Oqtane.Models.Theme
        {
            Name = "codeXpert SideBar",
            Version = "1.0.0",
            PackageName = "codeXpert.Theme.SideBar",
            ThemeSettingsType = "codeXpert.Theme.SideBar.ThemeSettings, codeXpert.Theme.SideBar.Client.Oqtane",
            ContainerSettingsType = "codeXpert.Theme.SideBar.ContainerSettings, codeXpert.Theme.SideBar.Client.Oqtane",
            Resources = new List<Resource>()
            {
                // Google Fonts
               // new Resource { ResourceType = ResourceType.Stylesheet, Url = "https://fonts.googleapis.com/css2?family=Nunito:ital,wght@0,200..1000%7Cdisplay=swap" },
                // Vendor CSS Files
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/assets/vendor/aos/aos.css" },
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "https://cdnjs.cloudflare.com/ajax/libs/overlayscrollbars/2.8.0/styles/overlayscrollbars.min.css" },
               // new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/assets/vendor/OverlayScrollbars/OverlayScrollbars.css" },       // OverlayScrollbars for menu
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/assets/vendor/bootstrap/css/bootstrap.min.css" },
                //new Resource { ResourceType = ResourceType.Stylesheet, Url = "https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.rtl.min.css" },
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/assets/vendor/bootstrap/css/bootstrap-grid.min.css" },
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/assets/vendor/bootstrap-icons/bootstrap-icons.css" },
               // new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/assets/vendor/boxicons/css/boxicons.min.css" },
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/assets/vendor/AdminLTE/adminlte.css" },

                // Template Main CSS File
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/assets/css/Theme.css" },

                // Vendor JS Files
                new Resource { ResourceType = ResourceType.Script, Url = "~/assets/vendor/aos/aos.js", Location = ResourceLocation.Body },
                new Resource { ResourceType = ResourceType.Script, Url = "https://cdnjs.cloudflare.com/ajax/libs/overlayscrollbars/2.8.0/browser/overlayscrollbars.browser.es6.min.js", Location = ResourceLocation.Body },
              //  new Resource { ResourceType = ResourceType.Script, Url = "~/assets/vendor/OverlayScrollbars/OverlayScrollbars.js", Location = ResourceLocation.Body, ES6Module = true },
              //  new Resource { ResourceType = ResourceType.Script, Url = "https://unpkg.com/@popperjs/core@2", Location = ResourceLocation.Body },
                new Resource { ResourceType = ResourceType.Script, Url = "~/assets/vendor/bootstrap/js/bootstrap.bundle.min.js", Location = ResourceLocation.Body },
              //  new Resource { ResourceType = ResourceType.Script, Url = "~/assets/vendor/tinymce/tinymce.js", Location = ResourceLocation.Body },
                new Resource { ResourceType = ResourceType.Script, Url = "~/assets/js/adminlte.js", Location = ResourceLocation.Body },

                // Template Main JS File
                new Resource { ResourceType = ResourceType.Script, Url = "~/assets/js/browser-service.js", Location = ResourceLocation.Body},
                new Resource { ResourceType = ResourceType.Script, Url = "~/assets/js/Interop.js", Location = ResourceLocation.Body, RenderMode = RenderModes.Interactive}
            }
        };

    }
}
