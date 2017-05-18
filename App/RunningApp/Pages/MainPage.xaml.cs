using System;
using System.Diagnostics;
using MvvmCross.Platform;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

namespace RunningApp
{
	public partial class MainPage : ContentPage
	{

		public MainPage()
		{
			InitializeComponent();

		}

		async void buttonClicked_login(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new MyPanelPage());
			/*var DBUser = Mvx.Resolve<IDBUser>();
			var result = await DBUser.loginUser(login.Text, password.Text);
			var status = JObject.Parse(result).ToObject<Status>();

			if (status.status.ToString() == "1")
			{
				await Navigation.PushAsync(new MyPanelPage());
			}
			else
			{
				Blad.IsVisible = true;
			}
			*/
		}

		async void buttonClicked_register(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new RegisterPage());
		}
	}

	public class Status
	{
		public string status { get; set; }
	}
}
