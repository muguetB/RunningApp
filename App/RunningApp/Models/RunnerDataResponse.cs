using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace RunningApp
{
	[XmlRoot(ElementName = "result")]
	public class RunnerDataResponse
	{
		[XmlElement(ElementName = "kilometers")]
		public string Kilometers { get; set; }
		[XmlElement(ElementName = "calories")]
		public string Calories { get; set; }
		[XmlElement(ElementName = "heartRate")]
		public string HeartRate { get; set; }
	}

}