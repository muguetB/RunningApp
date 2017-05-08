using System;
using System.Collections.Generic;
using MvvmCross.Platform;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

namespace RunningApp
{
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage()
		{
			InitializeComponent();
		}

		async void buttonClicked_register(object sender, EventArgs args)
		{
			var DBUser = Mvx.Resolve<IDBUser>();
			var result = await DBUser.registeruser(login.Text, password.Text, device.Text);
			var userref = JObject.Parse(result).ToObject<Userref>();

			if (userref.userref.ToString() != "0")
			{
				await Navigation.PushModalAsync(new MyPanelPage());
			}

			else
			{
				Blad.IsVisible = true;
			}
		}
	}

	public class Userref
	{
		public string userref { get; set; }
	}
}
