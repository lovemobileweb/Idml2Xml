

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

public class InsetSpacing
{
	public InsetSpacing()
	{
		ListItems = new List<ListItem>();
	}

	public List<ListItem> ListItems { get; set; }

	public static InsetSpacing ReadXml(XmlReader reader)
	{
		InsetSpacing result = new InsetSpacing();

        if (reader.IsEmptyElement)
            return result;

        while (reader.Read()) {
			if (reader.Name == "ListItem") {
				switch (reader.GetAttribute("type")) {
					case "unit":
						result.ListItems.Add(new ListItemUnit(reader.ReadElementContentAsDouble()));
						break;
				}
			} else if (reader.Name == "InsetSpacing" & reader.NodeType == XmlNodeType.EndElement) {
				break;
			}
		}

		return result;
	}
}
