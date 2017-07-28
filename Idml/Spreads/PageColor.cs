

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

public class PageColor
{
	public PageColorOptions PageColorOptions { get; set; }

	public InDesignUIColorType InDesignUIColorType { get; set; }

	public static PageColor ReadXml(XmlReader reader)
	{
		PageColor pc = new PageColor();

		if (reader.HasAttributes) {
			if (!string.IsNullOrEmpty(reader.GetAttribute("type")) && reader.GetAttribute("type") == "enumeration") {
				pc.PageColorOptions = (PageColorOptions)Parser.ParseEnum<PageColorOptions>(reader.ReadElementString());
			} else {
				throw new NotImplementedException();
			}
		} else {
			throw new NotImplementedException();
		}

		return pc;
	}
}
