

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

public class TextWrapOffset
{

	public double Top { get; set; }

	public double Bottom { get; set; }

	public double Left { get; set; }

	public double Right { get; set; }

	public static TextWrapOffset ReadXml(XmlReader reader)
	{
		TextWrapOffset two = new TextWrapOffset();

		if (reader.HasAttributes) {
			two.Top = (double)Parser.ParseDouble(reader.GetAttribute("Top"));
			two.Bottom = (double)Parser.ParseDouble(reader.GetAttribute("Bottom"));
			two.Left = (double)Parser.ParseDouble(reader.GetAttribute("Left"));
			two.Right = (double)Parser.ParseDouble(reader.GetAttribute("Right"));
		}

        return two;
	}
}
