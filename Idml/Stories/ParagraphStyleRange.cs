

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;
using System.Linq;

namespace Stories
{
	public class ParagraphStyleRange : Child
	{

		public ParagraphStyleRange()
		{
			this.Children = new List<Child>();
		}

		public List<Child> Children { get; set; }

		public string AppliedParagraphStyle { get; set; }

		public static ParagraphStyleRange ReadXml(XmlReader reader)
		{
			ParagraphStyleRange psr = new ParagraphStyleRange();

            if (reader.HasAttributes)
                psr.AppliedParagraphStyle = reader.GetAttribute("AppliedParagraphStyle");

            if (reader.IsEmptyElement)
                return psr;

            while (reader.Read()) {
				switch (reader.Name) {
					case "Footnote":
						psr.Children.Add(Footnote.ReadXml(reader));
						break;
					case "GaijiOwnedItemObject":
						psr.Children.Add(GaijiOwnedItemObject.ReadXml(reader));
						break;
					case "Note":
						psr.Children.Add(Note.ReadNote(reader));
						break;
					case "Table":
						psr.Children.Add(Table.ReadXml(reader));
						break;
					case "TextVariableInstance":
						psr.Children.Add(TextVariableInstance.ReadXml(reader));
						break;
					case "HiddenText":
						psr.Children.Add(HiddenText.ReadXml(reader));
						break;
					case "XMLElement":
						psr.Children.Add(XmlElement.ReadXml(reader));
						break;
					case "HyperlinkTextSource":
						psr.Children.Add(HyperlinkTextSource.ReadXml(reader));
						break;
					case "CharacterStyleRange":
						psr.Children.Add(CharacterStyleRange.ReadXml(reader));
						break;
					case "Content":
						psr.Children.Add(new Content(reader.ReadString()));
						break;
					case "Br":
						psr.Children.Add(new Br());
						break;
					case "ParagraphStyleRange":
                        if (reader.NodeType == XmlNodeType.EndElement)
                            goto exit1;
						break;
					default:
						Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "ParagraphStyleRange");
						break;
				}
			}

            exit1:
            return psr;
		}

        internal void Save(XmlTextWriter textWriter)
        {
            List<Child> items = Children
                .Where(x => x.GetType() == typeof(CharacterStyleRange) || x.GetType() == typeof(HyperlinkTextSource))
                .ToList();
            string str = "";
            foreach (var item in items)
            {
                str += item.ToString();
            }
            textWriter.WriteStartElement("type");
            {
                textWriter.WriteString("paragraph");
            }
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("content");
            {
                textWriter.WriteCData(str);
            }
            textWriter.WriteEndElement();
        }
    }
}
