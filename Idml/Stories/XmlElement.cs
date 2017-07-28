

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

namespace Stories
{
	public class XmlElement : Child
	{

		public XmlElement()
		{
			this.Children = new List<Child>();
		}

		public override string ToString()
		{
			return this.Self;
		}

		public string Self { get; set; }
		public string MarkupTag { get; set; }
		public string XmlContent { get; set; }
		public bool? NoTextMarker { get; set; }

		public List<Child> Children { get; set; }

		public static XmlElement ReadXml(XmlReader reader)
		{
			XmlElement xe = new XmlElement();

            if (reader.HasAttributes)
            {
                xe.Self = reader.GetAttribute("Self");
                xe.MarkupTag = reader.GetAttribute("MarkupTag");
                xe.XmlContent = reader.GetAttribute("XMLContent");
                xe.NoTextMarker = Parser.ParseBoolean(reader.GetAttribute("NoTextMarker"));
            }

            if (reader.IsEmptyElement)
                return xe;

            while (reader.Read()) {
				switch (reader.Name) {
					case "XMLAttribute":
						xe.Children.Add(XmlAttribute.ReadXml(reader));
						break;
					case "XMLElement":
						if (reader.NodeType == XmlNodeType.EndElement) {
                            goto exit1;
						} else {
							xe.Children.Add(XmlElement.ReadXml(reader));
						}
						break;
					case "XMLComment":
						xe.Children.Add(XmlComment.ReadXml(reader));
						break;
					case "XMLInstruction":
						xe.Children.Add(XmlInstruction.ReadXml(reader));
						break;
					case "Table":
						xe.Children.Add(Table.ReadXml(reader));
						break;
					case "Footnote":
						xe.Children.Add(Footnote.ReadXml(reader));
						break;
					case "Note":
						xe.Children.Add(Note.ReadNote(reader));
						break;
					case "GaijiOwnedItemObject":
						xe.Children.Add(GaijiOwnedItemObject.ReadXml(reader));
						break;
					case "TextVariableInstance":
						xe.Children.Add(TextVariableInstance.ReadXml(reader));
						break;
					//add more cases here
					case "HiddenText":
						xe.Children.Add(HiddenText.ReadXml(reader));
						break;
					//add more cases here
					case "ParagraphStyleRange":
						xe.Children.Add(ParagraphStyleRange.ReadXml(reader));
						break;
					case "CharacterStyleRange":
						xe.Children.Add(CharacterStyleRange.ReadXml(reader));
						break;
					case "Content":
						xe.Children.Add(new Content(reader.ReadString()));
						break;
					case "Br":
						xe.Children.Add(new Br());
						break;
					case "":
						break;
					default:
						break;
				}
			}

            exit1:
			return xe;
		}
	}
}
