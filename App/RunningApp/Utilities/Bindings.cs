using Ninject.Modules;
using Ninject;
namespace RunningApp
{
	public class Bindings : NinjectModule
	{
		public override void Load()
		{
			Bind<IRunnerStatistic>().To<RunnerStatistic>();
		}
	}
}