using Xamarin.Forms;

namespace PickupGameApp
{
	public partial class PickupGameAppPage : ContentPage
	{
		public PickupGameAppPage()
		{
			InitializeComponent();

			BindingContext = App.Locator.Main;
		}
	}
}
