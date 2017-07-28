

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;
using System.Linq;

namespace Stories
{
	public class HyperlinkTextSource : Child
	{

		public HyperlinkTextSource()
		{
			this.Children = new List<Child>();
		}

		public List<Child> Children { get; set; }

        public string Self { get; set; }

        public string Name { get; set; }
        
        public bool? Hidden { get; set; }

        public string AppliedCharacterStyle { get; set; }

		public static HyperlinkTextSource ReadXml(XmlReader reader)
		{
            HyperlinkTextSource psr = new HyperlinkTextSource();

            if (reader.HasAttributes)
            {
                psr.Self = reader.GetAttribute("Self");
                psr.Name = reader.GetAttribute("Name");
                psr.Hidden = Parser.ParseBoolean(reader.GetAttribute("Hidden"));
                psr.AppliedCharacterStyle = reader.GetAttribute("AppliedCharacterStyle");
            }

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
					case "CharacterStyleRange":
						psr.Children.Add(CharacterStyleRange.ReadXml(reader));
						break;
					case "Content":
						psr.Children.Add(new Content(reader.ReadString()));
						break;
					case "Br":
						psr.Children.Add(new Br());
						break;
					case "HyperlinkTextSource":
                        if (reader.NodeType == XmlNodeType.EndElement)
                            goto exit1;
						break;
					default:
						Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "HyperlinkTextSource");
						break;
				}
			}

            exit1:
            return psr;
		}

        public override string ToString()
        {
            List<Child> items = Children
                .Where(x => x.GetType() == typeof(CharacterStyleRange) || x.GetType() == typeof(Content))
                .ToList();
            string str = "";
            foreach (var item in items)
            {
                str += item.ToString();
            }
            return str;
        }
    }
}
