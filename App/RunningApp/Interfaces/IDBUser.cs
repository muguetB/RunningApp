using System;
using System.Threading.Tasks;

namespace RunningApp
{
	public interface IDBUser
	{
		Task<String> loginUser(String login, String passowrd);
		Task<String> registeruser(String login, String password, String device);
	}
}
