using System;
namespace RunningApp
{
	public class Routes
	{
		int km { get; set; }
		int calories { get; set; }
		int heart_rate { get; set; }
		DateTime date { get; set; }
		DateTime time { get; set; }

		public Routes(int km, int calories, int heart_rate)
		{
			this.km = km;
			this.calories = calories;
			this.heart_rate = heart_rate;
		}


	}
}
