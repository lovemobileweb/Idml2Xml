

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

namespace Stories
{
	public class XmlInstruction : Child
	{

		public override string ToString()
		{
			return this.Self;
		}

		public string Self { get; set; }

		public string Target { get; set; }

		public string Data { get; set; }

		public static XmlInstruction ReadXml(XmlReader reader)
		{
			XmlInstruction xi = new XmlInstruction();

            if (reader.HasAttributes)
            {
                xi.Self = reader.GetAttribute("Self");
                xi.Target = reader.GetAttribute("Target");
                xi.Data = reader.GetAttribute("Data");
            }

			return xi;
		}
	}
}

