using System;
using MvvmCross.Platform;

namespace RunningApp
{
	public class UserHelper
	{
		public UserHelper()
		{
		}

		public static bool userExists(String login, String password)
		{
			bool exists = false;
			var DBUser = Mvx.Resolve<IDBUser>();
			var result = DBUser.loginUser(login, password);

			return exists;
		}

		//addUser, 
	}
}
