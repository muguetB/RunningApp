using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace RunningApp
{
	[XmlRoot(ElementName = "value")]
	public class RunnerValue
	{
		[XmlElement(ElementName = "date")]
		public string Date { get; set; }
		[XmlElement(ElementName = "calories")]
		public string Calories { get; set; }
		[XmlElement(ElementName = "km")]
		public string Km { get; set; }
		[XmlElement(ElementName = "heartRate")]
		public string HeartRate { get; set; }
	}

	[XmlRoot(ElementName = "values")]
	public class RunnerData
	{
		[XmlElement(ElementName = "value")]
		public List<RunnerValue> Value { get; set; }
	}
}


