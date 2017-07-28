

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

namespace Stories
{
	public class Footnote : Child
	{

		public Footnote()
		{
			Children = new List<Child>();
		}

		private List<Child> Children { get; set; }

		public static Footnote ReadXml(XmlReader reader)
		{
			Footnote fn = new Footnote();

            if (reader.IsEmptyElement)
                return fn;

            while (reader.Read()) {
				switch (reader.Name) {
					case "GaijiOwnedItemObject":
						fn.Children.Add(GaijiOwnedItemObject.ReadXml(reader));
						break;
					case "TextVariableInstance":
						fn.Children.Add(TextVariableInstance.ReadXml(reader));
						break;
					case "Table":
						fn.Children.Add(Table.ReadXml(reader));
						break;
					case "ParagraphStyleRange":
						fn.Children.Add(ParagraphStyleRange.ReadXml(reader));
						break;
					case "CharacterStyleRange":
						fn.Children.Add(CharacterStyleRange.ReadXml(reader));
						break;
					case "HiddenText":
						fn.Children.Add(HiddenText.ReadXml(reader));
						break;
					case "Note":
                        if (reader.NodeType == XmlNodeType.EndElement)
                            goto exit1;
						break;
					default:
						Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "Note");
						break;
				}
			}

            exit1:
			return fn;
		}

	}
}
