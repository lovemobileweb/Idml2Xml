

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

public class GeometryPathType
{
	public GeometryPathType()
	{
		this.PathPoints = new List<PathPointType>();
	}

	public bool PathOpen { get; set; }

	public List<PathPointType> PathPoints { get; set; }

	public static GeometryPathType ReadXml(XmlReader reader)
	{
		GeometryPathType gpt = new GeometryPathType();

		if (reader.HasAttributes) {
			gpt.PathOpen = Convert.ToBoolean(reader.GetAttribute("PathOpen"));
		}

        if (reader.IsEmptyElement)
            return gpt;

        while (reader.Read()) {
			if (reader.Name == "PathPointType") {
				gpt.PathPoints.Add(PathPointType.ReadXml(reader));
			} else if (reader.Name == "GeometryPathType" & reader.NodeType == XmlNodeType.EndElement) {
				break;
			}
		}

		return gpt;
	}
}
