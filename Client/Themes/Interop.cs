using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace codeXpert.Theme.SideBar
{
    public class Interop
    {
        private readonly IJSRuntime _jsRuntime;

        public Interop(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task Load()
        {
            try
            {
                await _jsRuntime.InvokeVoidAsync("Oqtane.SideBar.load");
            }
            catch
            {
                // handle exception
            }
        }

        public async Task LoadAdminLte()
        {
            try
            {
                await _jsRuntime.InvokeVoidAsync("AdminLte.SideBar.load");
            }
            catch
            {
                // handle exception
            }
        }

    }

}
