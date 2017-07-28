

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

namespace Stories
{
	public class XmlAttribute : Child
	{

		public override string ToString()
		{
			return this.Self;
		}

		public string Self { get; set; }

		public string Name { get; set; }

		public string Value { get; set; }

		public static XmlAttribute ReadXml(XmlReader reader)
		{
			XmlAttribute xa = new XmlAttribute();

            if (reader.HasAttributes)
            {
                xa.Self = reader.GetAttribute("Self");
                xa.Name = reader.GetAttribute("Name");
                xa.Value = reader.GetAttribute("Value");
            }

			return xa;
		}
	}
}
