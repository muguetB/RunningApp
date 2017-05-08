﻿using System;
using System.IO;
using System.Xml.Serialization;

namespace RunningApp
{
	public static class XmlParser
	{
		public static T FromXml<T>(String xml)
		{
			T returnedXmlClass = default(T);

			try
			{
				using (TextReader reader = new StringReader(xml))
				{
					try
					{
						returnedXmlClass = (T)new XmlSerializer(typeof(T)).Deserialize(reader);
					}
					catch (InvalidOperationException)
					{
						// String passed is not XML, simply return defaultXmlClass
					}
				}
			}
			catch (Exception ex)
			{
			}

			return returnedXmlClass;
		}
	}
}