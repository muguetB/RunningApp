using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RunningApp
{
	public class RunnerStatistic : IRunnerStatistic
	{
		private HttpClient httpClient;

		public RunnerStatistic()
		{
			this.httpClient = new HttpClient();
		}

		public async Task<String> getStatisticXML(String dataXML)
		{
			var httpContent = new StringContent(dataXML, Encoding.UTF8, "application/xml");
			var requestUri = "http://malinkowyserwer.ddns.net/Skrypty/readXML.php";
			var response = await httpClient.PostAsync(requestUri, httpContent);

			string resultContent = await response.Content.ReadAsStringAsync();

			if (response.IsSuccessStatusCode)
			{
				Debug.WriteLine("Udało się!");
			}

			return resultContent;
		}

		public String generateXML()
		{
			RunnerValue runningValue = new RunnerValue
			{
				Date = "10-04-2017",
				Km = "9.89",
				Calories = "328",
				HeartRate = "103"

			};

			RunnerData runnerData = new RunnerData();
			var runningValueList = new List<RunnerValue>();
			runningValueList.Add(runningValue);
			runnerData.Value = runningValueList;

			return XMLParserGenerator.ToXML(runnerData);
		}
	}
}
