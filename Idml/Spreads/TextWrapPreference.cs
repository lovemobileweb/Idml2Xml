

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Xml;

public class TextWrapPreference
{

	public bool Inverse { get; set; }

	public bool ApplyToMasterPageOnly { get; set; }

	public TextWrapSideOptions TextWrapSide { get; set; }

	public TextWrapModes TextWrapMode { get; set; }

	public TextWrapOffset TextWrapOffset { get; set; }

	public static TextWrapPreference ReadXml(XmlReader reader)
	{
		TextWrapPreference twp = new TextWrapPreference();

		if (reader.HasAttributes) {
			twp.Inverse = Convert.ToBoolean(reader.GetAttribute("Inverse"));
			twp.ApplyToMasterPageOnly = Convert.ToBoolean(reader.GetAttribute("ApplyToMasterPageOnly"));
			twp.TextWrapSide = (TextWrapSideOptions)Enum.Parse(typeof(TextWrapSideOptions), reader.GetAttribute("TextWrapSide"));
			twp.TextWrapMode = (TextWrapModes)Enum.Parse(typeof(TextWrapModes), reader.GetAttribute("TextWrapMode"));
		}

        if (reader.IsEmptyElement)
            return twp;

        while (reader.Read()) {
			if (reader.Name == "TextWrapOffset" & reader.NodeType == XmlNodeType.Element) {
				twp.TextWrapOffset = TextWrapOffset.ReadXml(reader);
			} else if (reader.Name == "TextWrapPreference" & reader.NodeType == XmlNodeType.EndElement) {
				break;
			}
		}

		return twp;
	}
}
