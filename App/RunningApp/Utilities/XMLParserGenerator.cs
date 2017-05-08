using System;
using System.IO;
using System.Xml.Serialization;

namespace RunningApp
{
	public static class XMLParserGenerator
	{
		public static String ToXML(object instance)
		{
			XmlSerializer serializer = new XmlSerializer(instance.GetType());
			using (StringWriter textWriter = new Utf8StringWriter())
			{
				serializer.Serialize(textWriter, instance);
				return textWriter.ToString();
			}
		}
	}
}