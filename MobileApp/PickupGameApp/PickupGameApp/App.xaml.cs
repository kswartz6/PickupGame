using Xamarin.Forms;
using PickupGameApp.ViewModel;
using PickupGameApp.Views;

namespace PickupGameApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = GetMainPage();
		}
		private static ViewModelLocator _locator;
 
        public static ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
		}
		private static Page GetMainPage()
		{
			return new MainPage();
		}
		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
