

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

public class PathGeometry
{
	public PathGeometry()
	{
		this.GeometryPathTypes = new List<GeometryPathType>();
	}

	public List<GeometryPathType> GeometryPathTypes { get; set; }

	public static PathGeometry ReadXml(XmlReader reader)
	{
		PathGeometry pg = new PathGeometry();

		while (reader.Read()) {
			if (reader.Name == "GeometryPathType") {
				pg.GeometryPathTypes.Add(GeometryPathType.ReadXml(reader));
			} else if (reader.Name == "PathGeometry" & reader.NodeType == XmlNodeType.EndElement) {
				break;
			}
		}

		return pg;
	}
}
