using System;
using Xamarin.Forms;

namespace RunningApp
{
	public partial class MyPanelPage : ContentPage
	{
		public MyPanelPage()
		{
			InitializeComponent();
		}

		void buttonClicked_myRoute(object sender, EventArgs args)
		{
		}

		async void buttonClicked_history(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new MyHistoryPage());


		}


	}
}
