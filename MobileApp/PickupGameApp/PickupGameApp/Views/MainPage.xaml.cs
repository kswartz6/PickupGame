using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PickupGameApp.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			BindingContext = App.Locator.Main;
		}
	}
}
