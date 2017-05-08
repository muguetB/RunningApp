using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MvvmCross.Platform;
using Xamarin.Forms;

namespace RunningApp
{
	public partial class MyHistoryPage : ContentPage
	{

		public MyHistoryPage()
		{
			InitializeComponent();
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();
			var runnerStatistic = Mvx.Resolve<IRunnerStatistic>();
			var xml = runnerStatistic.generateXML();
			var document = await runnerStatistic.getStatisticXML(xml);

			var runnerData = XmlParser.FromXml<RunnerDataResponse>(document);
			calories_label.Text = runnerData.Calories;
			kilometer_label.Text = runnerData.Kilometers;
			heartRate_label.Text = runnerData.HeartRate;
		}

	}

}
