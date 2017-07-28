

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;
using System.Linq;

namespace Stories
{
	public class Story
	{
		public Story()
		{
			this.Children = new List<Child>();
		}

		public override string ToString()
		{
			return Self;
		}

		public string AppliedNamedGrid { get; set; }

		public string AppliedTOCStyle { get; set; }

		public string StoryTitle { get; set; }

		public bool? TrackChanges { get; set; }

		public string Self { get; set; }

		public StoryPreference StoryPreference { get; set; }

		public InCopyExportOption InCopyExportOption { get; set; }

		public List<Child> Children { get; set; }

		public static Story ReadXml(XmlReader reader)
		{
			Story s = new Story();

			s.Self = reader.GetAttribute("Self");
			s.AppliedNamedGrid = reader.GetAttribute("AppliedNamedGrid");
			s.AppliedTOCStyle = reader.GetAttribute("AppliedTOCStyle");
			s.StoryTitle = reader.GetAttribute("StoryTitle");
			s.TrackChanges = Parser.ParseBoolean(reader.GetAttribute("TrackChanges"));

            if (reader.IsEmptyElement)
                return s;

            while (reader.Read()) {
				switch (reader.Name) {

					case "ParagraphStyleRange":
						s.Children.Add(ParagraphStyleRange.ReadXml(reader));
						break;
					case "StoryPreference":
						s.StoryPreference = StoryPreference.ReadXml(reader);
						break;
					case "InCopyExportOption":
						s.InCopyExportOption = InCopyExportOption.ReadXml(reader);
						break;
					case "XMLElement":
						s.Children.Add(Stories.XmlElement.ReadXml(reader));
						break;
					case "Content":
						s.Children.Add(new Content(reader.ReadString()));
						break;
					case "Br":
						s.Children.Add(new Br());
						break;
					case "Story":
                        if (reader.NodeType == XmlNodeType.EndElement)
                            goto exit1;
						break;
					default:
						Debug.WriteLine("Unrecognized element: {0} in element: {1}", reader.Name, "Story");
						break;
				}
			}

            exit1:
			return s;
		}

        internal void Save(XmlTextWriter textWriter)
        {
            List<Child> items = Children
                .Where(x => x.GetType() == typeof(ParagraphStyleRange))
                .ToList();
            foreach (ParagraphStyleRange item in items)
            {
                textWriter.WriteStartElement("element");
                {
                    item.Save(textWriter);
                }
                textWriter.WriteEndElement();
            }
        }
    }
}
