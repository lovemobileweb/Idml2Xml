

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;
using System.Linq;

namespace Stories
{
	public class CharacterStyleRange : Child
	{

		public CharacterStyleRange()
		{
			Children = new List<Child>();
		}

		public string AppliedCharacterStyle { get; set; }

		public string FillColor { get; set; }

		public string FontStyle { get; set; }

		public string PointSize { get; set; }

		public string AppliedFont { get; set; }

		public string Leading { get; set; }

		public Position? PositionValue { get; set; }

		public List<Child> Children { get; set; }

		public static CharacterStyleRange ReadXml(XmlReader reader)
		{
			CharacterStyleRange csr = new CharacterStyleRange();

			if (reader.HasAttributes) {
				csr.AppliedCharacterStyle = reader.GetAttribute("AppliedCharacterStyle");
				csr.FillColor = reader.GetAttribute("FillColor");
				csr.FontStyle = reader.GetAttribute("FontStyle");
				csr.PointSize = reader.GetAttribute("PointSize");
                csr.PositionValue = (Position?)Parser.ParseEnum<Position>(reader.GetAttribute("Position"));
            }

            if (reader.IsEmptyElement)
                return csr;

            while (reader.Read()) {
				switch (reader.Name) {
					case "Properties":
						while (reader.Read()) {
							switch (reader.Name) {
								case "Leading":
									csr.Leading = reader.ReadString();
									break;
								case "AppliedFont":
									csr.AppliedFont = reader.ReadString();
									break;
								case "Properties":
                                    if (reader.NodeType == XmlNodeType.EndElement)
                                        goto exit1;

									break;
								default:
									Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "CharacterStyleRange -> Properties");
									break;
							}
						}
                        exit1:
						break;
					case "Footnote":
						csr.Children.Add(Footnote.ReadXml(reader));
						break;
					case "GaijiOwnedItemObject":
						csr.Children.Add(GaijiOwnedItemObject.ReadXml(reader));
						break;
					case "Note":
						csr.Children.Add(Note.ReadNote(reader));
						break;
					case "Table":
						csr.Children.Add(Table.ReadXml(reader));
						break;
					case "TextVariableInstance":
						csr.Children.Add(TextVariableInstance.ReadXml(reader));
						break;
					//add more cases here
					case "XMLElement":
						csr.Children.Add(XmlElement.ReadXml(reader));
						break;
					case "HiddenText":
						csr.Children.Add(HiddenText.ReadXml(reader));
						break;
					case "Content":
						csr.Children.Add(new Content(reader.ReadString()));
						break;
					case "Br":
						csr.Children.Add(new Br());
						break;
                    case "HyperlinkTextSource":
                        csr.Children.Add(HyperlinkTextSource.ReadXml(reader));
                        break;
                    case "CharacterStyleRange":
                        if (reader.NodeType == XmlNodeType.EndElement)
                            goto exit2;
						break;
					default:
						Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "CharacterStyleRange");
						break;
				}
			}

            exit2:
			return csr;
		}

        public override string ToString()
        {
            List<Child> items = Children
                .Where(x => x.GetType() == typeof(Content) || x.GetType() == typeof(Br))
                .ToList();
            string str = "";
            bool sup = false;
            if (PositionValue == Position.Superscript || AppliedCharacterStyle == "CharacterStyle/superscript")
                sup = true;
            if (sup)
                str += "<sup>";
            foreach (var item in items)
            {
                str += item.ToString();
            }
            if (sup)
                str += "</sup>";
            return str;
        }
    }
}
