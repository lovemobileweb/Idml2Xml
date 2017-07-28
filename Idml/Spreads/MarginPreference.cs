

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

public class MarginPreference
{

	public int ColumnCount { get; set; }

	public double ColumnGutter { get; set; }

	public double Top { get; set; }

	public double Bottom { get; set; }

	public double Left { get; set; }

	public double Right { get; set; }

	public object ColumnDirection { get; set; }

	public string ColumnsPositions { get; set; }

	public static MarginPreference ReadXml(XmlReader reader)
	{
		MarginPreference mp = new MarginPreference();

		if (reader.HasAttributes) {
			mp.ColumnCount = Convert.ToInt32(reader.GetAttribute("ColumnCount"));
			mp.ColumnGutter = (double)Parser.ParseDouble(reader.GetAttribute("ColumnGutter"));
			mp.Top = (double)Parser.ParseDouble(reader.GetAttribute("Top"));
			mp.Bottom = (double)Parser.ParseDouble(reader.GetAttribute("Bottom"));
			mp.Left = (double)Parser.ParseDouble(reader.GetAttribute("Left"));
			mp.Right = (double)Parser.ParseDouble(reader.GetAttribute("Right"));
			mp.ColumnDirection = Enum.Parse(typeof(HorizontalOrVertical), reader.GetAttribute("ColumnDirection"));
			mp.ColumnsPositions = reader.GetAttribute("ColumnsPositions");
		}

		return mp;
	}
}
