

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

namespace Stories
{
	public class TextVariableInstance : Child
	{

		public string Self { get; set; }

		public string Name { get; set; }

		public string ResultText { get; set; }

		public string AssociatedTextVariable { get; set; }

		public static TextVariableInstance ReadXml(XmlReader reader)
		{
			TextVariableInstance tv = new TextVariableInstance();

			if (reader.HasAttributes) {
				tv.Self = reader.GetAttribute("Self");
				tv.Name = reader.GetAttribute("Name");
				tv.ResultText = reader.GetAttribute("ResultText");
				tv.AssociatedTextVariable = reader.GetAttribute("AssociatedTextVariable");
			}

			if (!reader.IsEmptyElement) {
				while (reader.Read()) {
					throw new NotImplementedException("Need to implement TextVariableInstance Properties");
					//if (reader.Name == "TextVariableInstance" & reader.NodeType == XmlNodeType.EndElement)
					//	break;
				}
			}

			return tv;
		}

	}
}

