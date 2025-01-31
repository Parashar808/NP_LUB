using Microsoft.AspNetCore.Components;

namespace NPLubricants.Components.Layout
{
    public partial class Navbar
    {

        [Parameter] public bool showNav { get; set; } = false;
		[Parameter] public EventCallback<bool> OnShowNavChanged { get; set; }

		private void ShowNavMenu()
        {
			showNav = !showNav;
			OnShowNavChanged.InvokeAsync(showNav);

		}
		private void CloseNavMenu()
		{
			showNav = false;
			OnShowNavChanged.InvokeAsync(showNav);
		}


	}
}