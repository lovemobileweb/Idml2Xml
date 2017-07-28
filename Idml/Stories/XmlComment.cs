

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

namespace Stories
{
	public class XmlComment : Child
	{

		public override string ToString()
		{
			return this.Self;
		}

		public string Self { get; set; }

		public string Value { get; set; }

		public static XmlComment ReadXml(XmlReader reader)
		{
			XmlComment xc = new XmlComment();

            if (reader.HasAttributes)
            {
                xc.Self = reader.GetAttribute("Self");
                xc.Value = reader.GetAttribute("Value");
            }

			return xc;
		}
	}
}
