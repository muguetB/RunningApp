using System;
using System.Reflection;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;

namespace RunningApp
{
	public static class IoCContainter 	{ 		public static void Register() 		{ 			MvxSimpleIoCContainer.Initialize();
			Mvx.ConstructAndRegisterSingleton<IRunnerStatistic, RunnerStatistic>(); 			Mvx.ConstructAndRegisterSingleton<IDBUser, DBUser>();
		}
	}
}

