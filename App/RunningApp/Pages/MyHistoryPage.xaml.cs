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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

namespace RunningApp
{
	public partial class MyHistoryPage : ContentPage
	{
		public ObservableCollection<Route> Routes { get; set; } = new ObservableCollection<Route>();

		public MyHistoryPage()
		{
			InitializeComponent();
			BindingContext = this;
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

			foreach (var route in await createRoutes(1))
			{
				route.time = route.finishTime.Subtract(route.startTime);
				Routes.Add(route);
			}
		}

		async Task<IEnumerable<Route>> createRoutes(int user)
		{
			var DBRoutes = Mvx.Resolve<IDBRoutes>();
			var result = await DBRoutes.getUsersRoutes(user);
			var routesDictionary = JsonConvert.DeserializeObject<Dictionary<int, Route>>(result);
			return routesDictionary.Values;
		}

	}

}
