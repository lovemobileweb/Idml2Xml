

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

namespace Spreads
{
	public class RasterVectorBalance
	{

		private double _value;
		public FlattenerLevel FlattenerLevel { get; set; }

		public double Value {
			get { return _value; }
			set {
				if (value >= 0 & value <= 100) {
					_value = value;
				}
			}
		}

		public static RasterVectorBalance ReadXml(XmlReader reader)
		{
			RasterVectorBalance rvb = new RasterVectorBalance();

			if (reader.HasAttributes) {
				if (reader.GetAttribute("type") == "enum") {
					rvb.FlattenerLevel = (FlattenerLevel)Parser.ParseEnum<FlattenerLevel>(reader.ReadElementContentAsString());
				} else if (reader.GetAttribute("type") == "double") {
					rvb.Value = (double)Parser.ParseDouble(reader.ReadElementContentAsString());
				}
			}

			return rvb;
		}
	}
}
