

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

namespace Spreads
{
	public class AppliedFont
	{
		public string Font { get; set; }

		public static AppliedFont ReadXml(XmlReader reader)
		{
			AppliedFont af = new AppliedFont();

			af.Font = reader.ReadElementContentAsString();

			return af;
		}
	}
}
