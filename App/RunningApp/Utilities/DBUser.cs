using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RunningApp
{
	public class DBUser : IDBUser
	{
		private HttpClient httpClient;

		public DBUser()
		{
			httpClient = new HttpClient();
		}

		public async Task<String> loginUser(string login, string password)
		{
			string method = "login";
			string jsonData = "{\"login\": \"" + login + "\", \"password\": \"" + password + "\" , \"method\": \"" + method + "\"}";

			var httpContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var requestUri = "http://localhost/runningApp/userHelper.php";
			var response = await httpClient.PostAsync(requestUri, httpContent);

			var result = await response.Content.ReadAsStringAsync();
			if (response.IsSuccessStatusCode)
			{
				Debug.WriteLine("Udało się!");
			}

			return result;
		}

		public async Task<String> registeruser(string login, string password, string device)
		{
			string method = "register";
			string jsonData = "{\"login\": \"" + login + "\", \"password\": \"" + password + "\" , \"device\" : \"" + device + "\", \"method\": \"" + method + "\"}";

			var httpContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var requestUri = "http://localhost/runningApp/userHelper.php";
			var response = await httpClient.PostAsync(requestUri, httpContent);

			var result = await response.Content.ReadAsStringAsync();
			if (response.IsSuccessStatusCode)
			{
				Debug.WriteLine("Udało się!");
			}

			return result;
		}
	}
}
