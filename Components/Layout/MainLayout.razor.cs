namespace NPLubricants.Components.Layout
{
	public partial class MainLayout
	{
		private bool nav { get; set; }

		private void HandleShowNavChanged(bool value)
		{
			nav = value; 
			StateHasChanged();
		}
		private void closeMenu()
		{
			nav = false;
			StateHasChanged();
		}
	}
}