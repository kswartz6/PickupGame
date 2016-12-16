using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command; using GalaSoft.MvvmLight.Views;

namespace PickupGameApp.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
		private string _hello;
		public string Hello
		{
			get
			{
				return _hello;
			}
		}
			
        public MainViewModel()
        {
			_hello = "Hello World!";
        }
    }
}