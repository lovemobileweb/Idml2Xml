

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

public class PathPointType
{

	public UnitPointType Anchor { get; set; }

	public UnitPointType LeftDirection { get; set; }

	public UnitPointType RightDirection { get; set; }

	public static PathPointType ReadXml(XmlReader reader)
	{
		PathPointType ppt = new PathPointType();

        if (reader.HasAttributes)
        {
            ppt.Anchor = new UnitPointType(reader.GetAttribute("Anchor"));
            ppt.LeftDirection = new UnitPointType(reader.GetAttribute("LeftDirection"));
            ppt.RightDirection = new UnitPointType(reader.GetAttribute("RightDirection"));
        }

		return ppt;
	}
}

