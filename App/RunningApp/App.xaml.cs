using Xamarin.Forms;

namespace RunningApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
		}

		protected override void OnStart()
		{
			IoCContainter.Register();
			MainPage = new NavigationPage(new MainPage())
			{
				BarBackgroundColor = Color.FromHex("e6f2ff"),
				BarTextColor = Color.Navy
			};

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
