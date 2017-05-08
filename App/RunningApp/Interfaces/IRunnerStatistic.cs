using System;
using System.Threading.Tasks;

namespace RunningApp
{
	public interface IRunnerStatistic
	{
		Task<String> getStatisticXML(String xml);
		String generateXML();
	}
}
